using Npgsql;
using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Utils;

namespace PIM_III_ADS_VENDAS.Service
{
    internal class VendasService
    {
        private Dbconexao dbconexao = new Dbconexao();
        private NpgsqlConnection conexao;
        private EnviaEmail enviaEmail;
        private PessoaController pessoa;

        public VendasService()
        {

        }

        public VendasService(Dbconexao conexao, EnviaEmail enviaEmail)
        {
            this.conexao = dbconexao.GetConnection() as NpgsqlConnection; // Corrigindo aqui
            this.enviaEmail = enviaEmail;
        }

        internal void RegistrarVenda(string pagamentoAtual, string codigoUsuario, string vendaAtual)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                //conexao.Open(); // Abra a conexão antes de usar

                using (NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO public.vendas(formadepagamento, ingresso, data, codigo) VALUES (@formadepagamento, @ingresso, @Data, @CodigoPessoa)", conexao))
                {
                    command.Parameters.AddWithValue("@CodigoPessoa", codigoUsuario);
                    command.Parameters.AddWithValue("@ingresso", vendaAtual);
                    command.Parameters.AddWithValue("@formadepagamento", pagamentoAtual);
                    command.Parameters.AddWithValue("@Data", DateTime.Now);

                    int linhasAfetadas = command.ExecuteNonQuery();

                    if (linhasAfetadas < 0)
                    {
                        MessageBox.Show("Falha ao registrar o voto.");
                    }

                    enviaEmail.EnviarEmail(pessoa.Email, pessoa.Codigo);
                }
            }
        }
    }
}
