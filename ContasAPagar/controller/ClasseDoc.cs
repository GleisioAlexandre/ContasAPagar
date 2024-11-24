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
        private string stringDeConexao = "User=SYSDBA; PASSWORD=masterkey; DataSource=localhost; DataBase=C:/Users/Gleisio/Source/Repos/ContasAPagar/ContasAPagar/Banco de Dados/DB_CONTASAPAGAR.FDB";
       
        public List<ClasseTipoDoc> CaregaGridTipoDoc()
        {
            List<ClasseTipoDoc> lista = new List<ClasseTipoDoc>();

            using (FbConnection cx = new FbConnection(stringDeConexao))
            {
                string query = "select id, descricao from tipodocumento";
                using (FbCommand command = new FbCommand(query, cx))
                {
                    cx.Open();
                    using (FbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ClasseTipoDoc {
                                Id = reader.GetInt32(0),
                                DesCricao = reader.GetString(1)
                            });
                        }
                    }
                }
                return lista;
            }
        }
        public void InserirDoc(string descricao)
        {
            using (FbConnection cx = new FbConnection(stringDeConexao))
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
        public void EditarDoc(int id, string descricao)
        {
            try
            {
                using (FbConnection cx = new FbConnection(stringDeConexao))
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
                using (FbConnection cx = new FbConnection(stringDeConexao))
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

