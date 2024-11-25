using ContasAPagar.model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.controller
{
    class ClassePContas
    {
        private string stringDeConexao = "User=SYSDBA; PASSWORD=masterkey; DataSource=localhost; DataBase=C:/Users/Gleisio/Source/Repos/ContasAPagar/ContasAPagar/Banco de Dados/DB_CONTASAPAGAR.FDB";

        public List<ClassePlanoDeContas> CarregaGridPDContas()
        {
            List<ClassePlanoDeContas> lista = new List<ClassePlanoDeContas>();

            using (FbConnection cx = new FbConnection(stringDeConexao))
            {
                string query = "select id, descricao from placontas";

                using (FbCommand command = new FbCommand(query, cx))
                {
                    cx.Open();
                    using (FbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ClassePlanoDeContas { 
                                Id = reader.GetInt32(0),
                                Descricao = reader.GetString(1)
                                });
                        }
                    }
                }
            }
                return lista;
        }
        public void InserirPlanoDeContas(string descricao)
        {
            try
            {
                using (FbConnection cx = new FbConnection(stringDeConexao))
                {
                    string query = "insert into placontas (descricao) values (@descricao)";

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
        public void EditarPlanoDeContas(int id, string descricao)
        {
            try
            {
                using (FbConnection cx = new FbConnection(stringDeConexao))
                {
                    string query = "update placontas set descricao = @descricao where id = @id";

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
                throw new Exception($"Erro ao atualizar o registro: {ex.Message}");
            }
        }
        public void DeletarPlanoDeContas(int id)
        {
            try
            {
                using (FbConnection cx = new FbConnection(stringDeConexao))
                {
                    string query = "delete from placontas where id = @id";

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
