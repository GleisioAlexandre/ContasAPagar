using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAPagar.model
{
    class ClasseTipoDoc
    {
       
        string stringDeConexao = "User=SYSDBA; PASSWORD=masterkey; DataSource=localhost; DataBase=C:/Users/jucaf/source/repos/ContasAPagar/ContasAPagar/Banco de Dados/DB_CONTASAPAGAR.FDB";
        Doc doc = new Doc();
        public void InserirDocumento(string descricao)
        {
            doc.Descricao = descricao;
            string query = "insert into tipodocumento (descricao) values (@descricao)";

            using (FbConnection cx = new FbConnection(stringDeConexao))
            {
                    try
                    {
                        cx.Open();
                        using (FbCommand command = new FbCommand(query, cx))
                        {
                          command.Parameters.AddWithValue("@descricao", doc.Descricao);
                          command.ExecuteNonQuery();
                            MessageBox.Show("Dados inseridos com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
            }
        }
        public List<Doc> CarregaGrid()
        {
            string query = "select * from tipodocumento";
            List<Doc> listaDocumentos = new List<Doc>();

            try
            {
                using (FbConnection cx = new FbConnection(stringDeConexao))
                {
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        cx.Open();
                        using (FbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Doc documento = new Doc()
                                {
                                    Id = reader.GetInt32(0),
                                    Descricao = reader.GetString(1)
                                };
                                listaDocumentos.Add(documento);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os documetnos: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaDocumentos;
        }
        public class Doc
        {
            public int Id { get; set; }
            public string Descricao { get; set; }
        }

    }
}
