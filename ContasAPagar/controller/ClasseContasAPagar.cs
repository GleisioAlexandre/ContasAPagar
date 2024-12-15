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
    class ClasseContasAPagar
    {
        ClasseConfig config = new ClasseConfig();
        public DataTable CarregaGridContasAPagar()
        {
            try
            {
                DataTable dt = new DataTable();
                List<ClasseContAPagar> lista = new List<ClasseContAPagar>();
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "SELECT cp.id, cp.lancamento, f.nome , cp.valor, cp.documento, td.descricao , pc.descricao, s.DESCRICAO, cp.DATAVENC, cp.DATAPG, cp.OBS ,cp.ID_FORNECEDOR, cp.id_tipodocumento, cp.id_planodecontas, cp.id_situacao FROM CONTASAPAGAR cp LEFT JOIN  FORNECEDOR f ON cp.ID_FORNECEDOR = f.ID LEFT JOIN TIPODOCUMENTO td ON cp.ID_TIPODOCUMENTO = td.ID LEFT JOIN PLACONTAS pc ON cp.ID_PLANODECONTAS = pc.ID LEFT JOIN SITUACAO s ON cp.ID_SITUACAO = s.ID";
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        cx.Open();
                        FbDataAdapter adapter = new FbDataAdapter(command);
                        adapter.Fill(dt);

                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao carregar os dados: {ex.Message}");
            }
        }
        public void InserirContas(DateTime lancamento, int idForneceodor, double valor, string documento, int idDocumento, int idPlanDeCont, int idSituacao, DateTime vencimento, DateTime pagamento, string obs)
        {
            try
            {
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "insert into CONTASAPAGAR (LANCAMENTO , ID_FORNECEDOR, VALOR, DOCUMENTO, ID_TIPODOCUMENTO, ID_PLANODECONTAS, ID_SITUACAO, DATAVENC, DATAPG, OBS  ) values (@lancamento, @idForneceodor, @valor, @documento, @idDocumento, @idPlanDeCont, @idSituacao, @vencimento, @pagamento, @obs)";
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@lancamento", lancamento);
                        command.Parameters.AddWithValue("@idForneceodor", idForneceodor);
                        command.Parameters.AddWithValue("@valor", valor);
                        command.Parameters.AddWithValue("@documento", documento);
                        command.Parameters.AddWithValue("@idDocumento", idDocumento);
                        command.Parameters.AddWithValue("@idPlanDeCont", idPlanDeCont);
                        command.Parameters.AddWithValue("@idSituacao", idSituacao);
                        command.Parameters.AddWithValue("@vencimento", vencimento);
                        command.Parameters.AddWithValue("@pagamento", pagamento);
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
        public void EditarContas(DateTime LANCAMENTO, int ID_FORNECEDOR, int ID_PLANODECONTAS, string DOCUMENTO, double VALOR, int ID_TIPODOCUMENTO, DateTime DATAVENC, DateTime DATAPG, string OBS, int ID_SITUACAO, int IDCONTAS)
        {
            try
            {
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "update CONTASAPAGAR set  LANCAMENTO = @LANCAMENTO, ID_FORNECEDOR = @ID_FORNECEDOR, ID_PLANODECONTAS = @ID_PLANODECONTAS, DOCUMENTO = @DOCUMENTO, VALOR = @VALOR, ID_TIPODOCUMENTO = @ID_TIPODOCUMENTO, DATAVENC = @DATAVENC, DATAPG = @DATAPG, OBS = @OBS, ID_SITUACAO = @ID_SITUACAO where (ID = @ID)";
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        command.Parameters.AddWithValue("@LANCAMENTO", LANCAMENTO);
                        command.Parameters.AddWithValue("@ID_FORNECEDOR", ID_FORNECEDOR);
                        command.Parameters.AddWithValue("@ID_PLANODECONTAS", ID_PLANODECONTAS);
                        command.Parameters.AddWithValue("@DOCUMENTO", DOCUMENTO);
                        command.Parameters.AddWithValue("@VALOR", VALOR);
                        command.Parameters.AddWithValue("@ID_TIPODOCUMENTO", ID_TIPODOCUMENTO);
                        command.Parameters.AddWithValue("@DATAVENC", DATAVENC);
                        command.Parameters.AddWithValue("@DATAPG", DATAPG);
                        command.Parameters.AddWithValue("@OBS", OBS);
                        command.Parameters.AddWithValue("@ID_SITUACAO", ID_SITUACAO);
                        command.Parameters.AddWithValue("@ID", IDCONTAS);
                        cx.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar os dados: {ex.Message}");
            }
            
        }
    }
}



