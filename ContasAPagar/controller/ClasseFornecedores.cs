using ContasAPagar.Config;
using ContasAPagar.model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.controller
{
    class ClasseFornecedores
    {
        ClasseConfig config = new ClasseConfig();

        public List<ClasseFornecedor> CarregaGRidFornecedor()
        {
            try
            {
                List<ClasseFornecedor> lista = new List<ClasseFornecedor>();

                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "select id, nome, cadastropessoa, cep, logradouro, numero, complemento, bairro, cidade, estado, obs  from fornecedor"; //
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        cx.Open();
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new ClasseFornecedor
                                {
                                    Id = reader.IsDBNull(0) ? (0) : reader.GetInt32(0),
                                    Nome = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                    CadastroDePessoa = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                    Cep = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                    Logradouro = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                                    Numero = reader.IsDBNull(5) ? (0) : reader.GetInt32(5),
                                    Complemento = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                                    Bairro = reader.IsDBNull(7) ? string.Empty :  reader.GetString(7),
                                    Cidade = reader.IsDBNull(8) ? string.Empty :  reader.GetString(8),
                                    Estado = reader.IsDBNull(9) ? string.Empty :  reader.GetString(9),
                                    Obs = reader.IsDBNull(10) ? string.Empty :  reader.GetString(10)

                                });
                            }

                        }
                    }
                }
                    return lista;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar os dados: {ex.Message}");
            }
           
        }
        public void InserirFornecedor(string nome, string cadastropessoa, string cep, string logradouro, int numero, string complemento, string bairro, string cidade, string estado, string obs )
        {
            try
            {
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "insert into FORNECEDOR (NOME, CADASTROPESSOA, CEP, LOGRADOURO, NUMERO, COMPLEMENTO ,BAIRRO, CIDADE, ESTADO, OBS ) values(@nome, @cadastropessoa, @cep, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @obs) ";
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@cadastropessoa", cadastropessoa);
                        command.Parameters.AddWithValue("@cep", cep);
                        command.Parameters.AddWithValue("@logradouro", logradouro);
                        command.Parameters.AddWithValue("@numero", numero);
                        command.Parameters.AddWithValue("@complemento", complemento);
                        command.Parameters.AddWithValue("@bairro", bairro);
                        command.Parameters.AddWithValue("@cidade", cidade);
                        command.Parameters.AddWithValue("@estado", estado);
                        command.Parameters.AddWithValue("@obs", obs);
                        cx.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao insserir os dados: {ex.Message}");
            }
        }
    }
}
