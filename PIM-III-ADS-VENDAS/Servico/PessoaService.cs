using Npgsql;
using System;
using Dapper;
using System.Net.Mail;
using System.Net;
using PIM_III_ADS_2P17.Utils;
using PIM_III_ADS_2P17_AVALIACAO.Controle;

namespace PIM_III_ADS_2P17.Servico
{
    public class PessoaServico
    {
        private readonly Dbconexao dbconexao;
        private readonly EnviaEmail enviaEmail;
      
        public PessoaServico(Dbconexao conexao, EnviaEmail enviaEmail)
        {
            this.dbconexao = conexao;
            this.enviaEmail = enviaEmail;
        }

        public void Inserir(PessoaControle pessoa)
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

                enviaEmail.EnviarEmail(pessoa.Email, pessoa.Codigo);
            }
        }

        public void Atualizar(PessoaControle pessoa)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                conexao.Execute(@"UPDATE visitante SET nome = @Nome, idade = @Idade, email = @Email, cep = @Cep, data = @Data WHERE codigo = @Codigo",
                    new
                    {
                        pessoa.Nome,
                        pessoa.IdadeDb,
                        pessoa.Email,
                        pessoa.Cep,
                        Data = DateTime.Today,
                        Codigo = pessoa.Codigo
                    });
            }
        }

        public void Deletar(PessoaControle pessoa)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                conexao.Execute("DELETE FROM visitante WHERE Codigo  = @Codigo", new { pessoa.Codigo });
            }
        }

        public IEnumerable<PessoaControle> BuscarTodasPessoas()
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                // Consulta SQL modificada para incluir o campo Codigo
                return conexao.Query<PessoaControle>("SELECT codigo as Codigo, nome as Nome, idade as Idade, email as Email, cep as Cep, data as Data FROM visitante");
            }
        }

        public PessoaControle BuscarPessoaPorEmail(string email)
        {
            using (NpgsqlConnection conexao = dbconexao.GetConnection() as NpgsqlConnection)
            {
                return conexao.QueryFirstOrDefault<PessoaControle>("SELECT * FROM visitante WHERE email = @Email", new { Email = email });
            }
        }

        public PessoaControle BuscarPorCodigo(PessoaControle pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                   "SELECT * FROM visitante WHERE Codigo = @codigo ",
                    new { Codigo = pessoa.Codigo });

                if (resultado == null)
                {
                    return null;
                }
                pessoa.Codigo = resultado.codigo;
                pessoa.Nome = resultado.nome;
                return pessoa;
            }
        }
        public PessoaControle BuscarPessoaNomeECodigo(PessoaControle pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                    "SELECT nome, idade, email, cep, codigo FROM public.visitante WHERE nome = @nome AND codigo = @codigo",
                    new { pessoa.Nome, pessoa.Codigo });

                if (resultado != null)
                {
                   
                    pessoa.Nome = resultado.nome;
                    pessoa.IdadeDb = resultado.idade;
                    pessoa.Email = resultado.email;
                    pessoa.Cep = resultado.cep;
                    pessoa.Codigo = resultado.codigo;

                    // Retornando a própria instância de pessoa, que agora está atualizada com os dados encontrados
                    return pessoa;
                }
                return null;
            }
        }

        public PessoaControle BuscarPessoaPorNomeEEmail(PessoaControle pessoa)
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
