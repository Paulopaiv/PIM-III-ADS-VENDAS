
using PIM_III_ADS_VENDAS.Utils;
using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Utils;

using PIM_III_ADS_VENDAS.Service;

namespace PIM_III_ADS_VENDAS.Model
{
    public class PessoaModel
    {
        Validacao validacao = new Validacao();
        PessoaService pessoaServico = new PessoaService(new Dbconexao(), new EnviaEmail());
        PessoaController pessoa;
        private string mensagem = "";

        public PessoaModel()
        {

        }

        public PessoaModel(PessoaController pessoa)
        {
            this.SalvaPessoa(pessoa);

            this.DeletarPessoa(pessoa);
     
            this.LoginCompra(pessoa);
          
        }

        internal void SalvaPessoa(PessoaController pessoa)
        {
            validacao.ValidarPessoa(pessoa);

            if (validacao.Mensagem.Equals(""))
            {
                pessoaServico.Inserir(pessoa);
                this.mensagem = "Cadastro realizado com sucesso.";
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

      

        internal void DeletarPessoa(PessoaController pessoa)
        {
            if (pessoa.Codigo.Equals(""))
            {
                this.mensagem = "Erro ao Remover pessoa: pessoa não encontrada";
            }
            else
            {
                pessoaServico.Deletar(pessoa);
                this.mensagem = "Pessoa excluída com sucesso!";
            }
        }

    

        //internal void Login(PessoaControle pessoa)
        //{
        //   var codigo = pessoaServico.BuscarPorCodigo(pessoa);

        //    if (codigo.Codigo != null)
        //    {
        //        this.mensagem = "O token fornecido é inválido. Por favor, verifique e tente novamente.";
        //    }
        //    else
        //    {
        //        this.mensagem = $"Olá, {pessoa.Nome}! Por favor, responda o questionário a seguir.";
        //    }
        //}

      

        internal void LoginCompra(PessoaController pessoa)
        {
            pessoa = pessoaServico.BuscarPessoaPorNomeEEmail(pessoa);

            if (pessoa != null && pessoa.Nome != null && pessoa.Email != null)
            {
                this.mensagem = $"Olá, {pessoa.Nome}! Bem-vindo(a)!";
            }
            else
            {
                this.mensagem = "Login inválido. Verifique suas credenciais.";
            }
        }

      
        public string Mensagem
        {
            get { return mensagem; }
        }
        public PessoaService PessoaService
        {
            get { return pessoaServico; }
            set { pessoaServico = value; }
        }

    }
}

