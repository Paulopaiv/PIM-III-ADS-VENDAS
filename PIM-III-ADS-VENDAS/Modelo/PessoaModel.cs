using PIM_III_ADS_2P17.Servico;
using PIM_III_ADS_2P17.Utils;
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using PIM_III_ADS_VENDAS.Utils;

namespace PIM_III_ADS_2P17.Controle
{
    public class PessoaModel
    {
        Validacao validacao = new Validacao();
        PessoaServico pessoaServico = new PessoaServico(new Dbconexao(), new EnviaEmail());
        PessoaControle pessoa;
        private string mensagem = "";

        public PessoaModel()
        {

        }

        public PessoaModel(PessoaControle pessoa)
        {
            this.SalvaPessoa(pessoa);
            this.AtualizarPessoa(pessoa);
            this.DeletarPessoa(pessoa);
            this.BuscarPessoa(pessoa);
            this.Login(pessoa);
            this.LoginCompra(pessoa);
            this.BuscarTodasPessoas();
        }

        internal void SalvaPessoa(PessoaControle pessoa)
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

        internal void AtualizarPessoa(PessoaControle pessoa)
        {
            validacao.ValidarPessoa(pessoa);

            if (pessoa != null)
            {
                pessoaServico.Atualizar(pessoa);
                this.mensagem = "Pessoa atualizada com sucesso!";
            }
            else
            {
                this.mensagem = "Erro ao atualizar pessoa: pessoa não encontrada";
            }
        }

        internal void DeletarPessoa(PessoaControle pessoa)
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

        internal void BuscarPessoa(PessoaControle pessoa)
        {
            pessoa = pessoaServico.BuscarPessoaNomeECodigo(pessoa);

            if (pessoa != null && pessoa.Nome != null && pessoa.Codigo != null)
            {
                this.mensagem = "Pessoa encontrada com sucesso!";
            }
            else
            {
                this.mensagem = "Pessoa não encontrada.";
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

        internal void Login(PessoaControle pessoa)
        {
            var codigo = pessoaServico.BuscarPorCodigo(pessoa);

            if (codigo != null)
            {
                this.mensagem = "O token fornecido é inválido. Por favor, verifique e tente novamente.";
            }
            else
            {
                this.mensagem = $"Olá, {pessoa.Nome}! Por favor, responda o questionário a seguir.";
            }
        }

        internal void LoginCompra(PessoaControle pessoa)
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

        internal List<PessoaControle> BuscarTodasPessoas()
        {
            IEnumerable<PessoaControle> todasPessoas = pessoaServico.BuscarTodasPessoas();
            return todasPessoas.ToList();
        }

        public string Mensagem
        {
            get { return mensagem; }
        }
        public PessoaServico PessoaServico
        {
            get { return pessoaServico; }
            set { pessoaServico = value; }
        }

    }
}

