using Npgsql;
using Dapper;
using PIM_III_ADS_VENDAS.Utils;
using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Service;

namespace PIM_III_ADS_VENDAS.Service
{
    public class PessoaService
    {
        private readonly Dbconexao dbconexao;
        private readonly EnviaEmail enviaEmail;
        private EnviaEmail enviaEmail1;

        public PessoaService(Dbconexao conexao, EnviaEmail enviaEmail)
        {
            this.dbconexao = conexao;
            this.enviaEmail = enviaEmail;
        }

        public void Inserir(PessoaController pessoa)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                conexao.Execute(@"INSERT INTO visitante (NOME, IDADE, EMAIL, CEP, DATA, Codigo) 
                    VALUES (@Nome, @IdadeDb, @Email, @Cep, @Data, @Codigo)",
                    new
                    {
                        pessoa.IdadeDb,
                        pessoa.Nome,
                        pessoa.Email,
                        pessoa.Cep,
                        pessoa.Codigo,
                        Data = DateTime.Today

                    });

                // enviaEmail.EnviarEmail(pessoa.Email, pessoa.Codigo);
            }
        }

        public PessoaController BuscarPessoaPorEmail(string email)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                return conexao.QueryFirstOrDefault<PessoaController>("SELECT * FROM visitante WHERE email = @Email", new { Email = email });
            }
        }

        public PessoaController BuscarPessoaPorNomeEEmail(PessoaController pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                     "SELECT nome, idade, email, cep, codigo FROM public.visitante WHERE nome = @Nome AND email = @Email",
                    new { pessoa.Nome, pessoa.Email });

                if (resultado != null)
                {
                    pessoa.Nome = resultado.nome;
                    pessoa.IdadeDb = resultado.idade;
                    pessoa.Email = resultado.email;
                    pessoa.Cep = resultado.cep;
                    pessoa.Codigo = resultado.codigo;

                    return pessoa;
                }

                return null;
            }
        }

    }
}
