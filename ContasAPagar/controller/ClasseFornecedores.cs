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
                    string query = "select * from fornecedor";
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        cx.Open();
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new ClasseFornecedor
                                {
                                    Id = reader.GetInt32(0),
                                    Nome = reader.GetString(1),
                                    CadastroDePessoa = reader.GetString(2),
                                    Cep = reader.GetString(3),
                                    Logradouro = reader.GetString(4),
                                    Numero = reader.GetInt32(5),
                                    Complemento = reader.GetString(6),
                                    Bairro = reader.GetString(7),
                                    Cidade = reader.GetString(8),
                                    Estado = reader.GetString(9),
                                    Obs = reader.GetString(10)

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
    }
}
