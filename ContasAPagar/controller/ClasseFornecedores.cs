using ContasAPagar.Config;
using ContasAPagar.model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;

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
                    string query = "select ID, NOME, CADASTROPESSOA, CEP, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, TELEFONE, CELULAR, EMAIL, OBS  from fornecedor";

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
                                    Bairro = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                                    Cidade = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                                    Estado = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                                    Telefone = reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
                                    Celular = reader.IsDBNull(11) ? string.Empty : reader.GetString(11),
                                    Email = reader.IsDBNull(12) ? string.Empty :reader.GetString(12),
                                    Obs = reader.IsDBNull(13) ? string.Empty :  reader.GetString(13)

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

        public List<ClasseFornecedor> CarregaComboxFornecedor()
        {
            try
            {
                List<ClasseFornecedor> lista = new List<ClasseFornecedor>();

                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "select  ID, NOME  from fornecedor";

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
            public void InserirFornecedor(string nome, string cadastropessoa, string cep, string logradouro, int numero, string complemento, string bairro, string cidade, string estado, string telefone, string celular, string email, string obs)
             {
            try
            {
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "insert into FORNECEDOR (NOME, CADASTROPESSOA, CEP, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, TELEFONE, CELULAR, EMAIL, OBS) values (@NOME, @CADASTROPESSOA, @CEP, @LOGRADOURO, @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, @ESTADO, @TELEFONE, @CELULAR, @EMAIL, @OBS)";
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@NOME", nome);
                        command.Parameters.AddWithValue("@CADASTROPESSOA", cadastropessoa);
                        command.Parameters.AddWithValue("@CEP", cep);
                        command.Parameters.AddWithValue("@LOGRADOURO", logradouro);
                        command.Parameters.AddWithValue("@NUMERO", numero);
                        command.Parameters.AddWithValue("@COMPLEMENTO", complemento);
                        command.Parameters.AddWithValue("@BAIRRO", bairro);
                        command.Parameters.AddWithValue("@CIDADE", cidade);
                        command.Parameters.AddWithValue("@ESTADO", estado);
                        command.Parameters.AddWithValue("@TELEFONE", telefone);
                        command.Parameters.AddWithValue("@CELULAR", celular);
                        command.Parameters.AddWithValue("@EMAIL", email);
                        command.Parameters.AddWithValue("@OBS", obs);
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
        public void EditarFornecedor(int id, string nome, string cadastropessoa, string cep, string logradouro, int numero, string complemento, string bairro, string cidade, string estado, string telefone, string celular, string email, string obs)
        {
            try
            {
                using(FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "update FORNECEDOR set NOME = @NOME, CADASTROPESSOA = @CADASTROPESSOA, CEP = @CEP, LOGRADOURO = @LOGRADOURO, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, CIDADE = @CIDADE, ESTADO = @ESTADO, TELEFONE = @TELEFONE, CELULAR = @CELULAR, EMAIL = @EMAIL, OBS = @OBS where (ID = @ID) ";
                    using(FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@NOME", nome);
                        command.Parameters.AddWithValue("@CADASTROPESSOA", cadastropessoa);
                        command.Parameters.AddWithValue("@CEP", cep);
                        command.Parameters.AddWithValue("@LOGRADOURO", logradouro);
                        command.Parameters.AddWithValue("@NUMERO", numero);
                        command.Parameters.AddWithValue("@COMPLEMENTO", complemento);
                        command.Parameters.AddWithValue("@BAIRRO", bairro);
                        command.Parameters.AddWithValue("@CIDADE", cidade);
                        command.Parameters.AddWithValue("@ESTADO", estado);
                        command.Parameters.AddWithValue("@TELEFONE", telefone);
                        command.Parameters.AddWithValue("@CELULAR", celular);
                        command.Parameters.AddWithValue("@EMAIL", email);
                        command.Parameters.AddWithValue("@OBS", obs);
                        command.Parameters.AddWithValue("@ID", id);
                        cx.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar o registro: {ex.Message}");
            }
        }
        public void DeletarFornecedor(int id)
        {
            try
            {
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "delete from FORNECEDOR where(ID = @ID) ";
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        cx.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao remover o registro: {ex.Message}");
            }
        }
    }
}
