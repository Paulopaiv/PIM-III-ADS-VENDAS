﻿using Newtonsoft.Json.Linq;
using PIM_III_ADS_2P17.Servico;
using PIM_III_ADS_2P17.Utils;
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using System.Net;
using System.Text.RegularExpressions;


namespace PIM_III_ADS_VENDAS.Utils
{
    public class Validacao
    {
        private readonly PessoaServico pessoaServico;
        private string mensagem;

        public Validacao()
        {
            pessoaServico = new PessoaServico(new Dbconexao(), new EnviaEmail());
        }

        public Validacao(PessoaControle pessoa)
        {
            ValidarPessoa(pessoa);
        }

        internal void ValidarPessoa(PessoaControle pessoa)
        {
            mensagem = "";
            ValidarCep(pessoa);
            ValidarEmail(pessoa);
            ValidarIdade(pessoa);
            ValidarNome(pessoa);
        }

        private void ValidarNome(PessoaControle pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Nome))
            {
                setMensagem("Por favor, insira um nome.");
            }

            if (pessoa.Nome.Any(char.IsDigit))
            {

                setMensagem("O nome não pode conter números.");
            }

            if (!Regex.IsMatch(pessoa.Nome, @"^[A-Z][a-zA-Z\s]*$"))
            {
                setMensagem("O nome deve começar com uma letra maiúscula e conter apenas letras e espaços.");
            }

            pessoa.Nome = pessoa.Nome;
        }

        private void ValidarIdade(PessoaControle pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Idade))
            {
                setMensagem("Por favor, insira uma idade válida.");
                return;
            }
            if (!int.TryParse(pessoa.Idade, out int idade))
            {
                setMensagem("A idade deve ser um número inteiro válido.");
                return;
            }

            if (idade < 12)
            {
                setMensagem("Menores de 12 anos não podem entrar desacompanhados.");
                return;
            }

            if (idade > 120)
            {
                setMensagem("Por favor, insira uma idade válida.");
                return;
            }

            pessoa.IdadeDb = idade;
        }

        public void ValidarEmail(PessoaControle pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Email))
            {
                setMensagem("Por favor, insira um endereço de e-mail.");
                return;
            }

            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (!Regex.IsMatch(pessoa.Email, pattern))
            {
                setMensagem("Por favor, insira um endereço de e-mail válido.");
                return;
            }

            // Verificar se o email já está em uso apenas ao salvar uma nova pessoa
            if (pessoa.Codigo == null)
            {
                var pessoaExistente = pessoaServico.BuscarPessoaPorEmail(pessoa.Email);
                if (pessoaExistente != null)
                {
                    setMensagem("Este endereço de e-mail já está em uso. Por favor, escolha outro.");
                    return;
                }
            }
        }

        private void ValidarCep(PessoaControle pessoa)
        {
            if (string.IsNullOrWhiteSpace(pessoa.Cep) || !Regex.IsMatch(pessoa.Cep, @"^\d{8}$"))
            {
                setMensagem("Por favor, insira um CEP válido (formato: 00000000)");
            }
            else
            {
                using (WebClient webClient = new WebClient())
                {
                    string url = $"https://viacep.com.br/ws/{pessoa.Cep}/json/";
                    string response = webClient.DownloadString(url);
                    dynamic jsonObject = JObject.Parse(response);

                    if (jsonObject["erro"] != null)
                    {
                        setMensagem("CEP não encontrado. Por favor, insira um CEP válido.");
                    }
                }
            }

            pessoa.Cep = pessoa.Cep;
        }

        public string Mensagem
        {
            get { return mensagem; }
        }

        public void setMensagem(string mensagem)
        {
            this.mensagem = mensagem;
        }
    }
}
