
using PIM_III_ADS_VENDAS.Utils;
using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Service;

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

        internal void LoginCompra(PessoaController pessoa)
        {
            pessoa = pessoaServico.BuscarPessoaPorNomeEEmail(pessoa);

            if (pessoa != null && pessoa.Nome != null && pessoa.Email != null)
            {
                this.mensagem = "";
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

