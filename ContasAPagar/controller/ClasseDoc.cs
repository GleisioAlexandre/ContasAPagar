using ContasAPagar.Config;
using ContasAPagar.model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.controller
{
    class ClasseDoc
    {
        ClasseConfig config = new ClasseConfig();

        public List<ClasseTipoDoc> CarregaGridTipoDoc()
        {
            try
            {
                List<ClasseTipoDoc> lista = new List<ClasseTipoDoc>();

                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "select id, descricao from tipodocumento";

                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        cx.Open();
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new ClasseTipoDoc
                                {
                                    Id = reader.IsDBNull(0) ? (0) : reader.GetInt32(0),
                                    DesCricao = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                });
                            }
                        }
                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar os dados: {ex.Message}");
            }
        }
        public void InserirDoc(string descricao)
        {
            try
            {
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {

                    string query = "insert into tipodocumento (descricao) values (@descricao)";

                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@descricao", descricao);
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
        public void EditarDoc(int id, string descricao)
        {
            try
            {
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {

                    string query = "update tipodocumento set descricao = @descricao where id = @id";

                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@descricao", descricao);
                        command.Parameters.AddWithValue("@id", id);
                        cx.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atulaizar o registro: {ex.Message}");
            }
        }
        public void DeletarDoc(int id)
        {
            try
            {
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "delete from tipodocumento where id = @id";

                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@id", id);
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

