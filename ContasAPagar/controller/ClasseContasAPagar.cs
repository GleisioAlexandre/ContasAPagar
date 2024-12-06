﻿using ContasAPagar.Config;
using ContasAPagar.model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.controller
{
    class ClasseContasAPagar
    {
        ClasseConfig config = new ClasseConfig();
        public List<ClasseContAPagar> CarregaGridContasAPagar()
        {
            try
            {
                List<ClasseContAPagar> lista = new List<ClasseContAPagar>();
                using (FbConnection cx = new FbConnection(config.StringDeConexa()))
                {
                    string query = "SELECT cp.id, cp.lancamento, f.NOME AS NOME_FORNECEDOR, cp.valor, cp.documento, td.descricao AS TIPO_DOCUMENTO, pc.descricao AS PLANO_DE_CONTAS, s.DESCRICAO AS SITUACAO, cp.DATAVENC, cp.DATAPG, cp.OBS FROM CONTASAPAGAR cp LEFT JOIN  FORNECEDOR f ON cp.ID_FORNECEDOR = f.ID LEFT JOIN TIPODOCUMENTO td ON cp.ID_TIPODOCUMENTO = td.ID LEFT JOIN PLACONTAS pc ON cp.ID_PLANODECONTAS = pc.ID LEFT JOIN SITUACAO s ON cp.ID_SITUACAO = s.ID";
                    using (FbCommand command = new FbCommand(query, cx))
                    {
                        cx.Open();
                        using(FbDataReader reader =command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new ClasseContAPagar {
                                    Id = reader.IsDBNull(0) ? (0) : reader.GetInt32(0),
                                    Lancamento = reader.IsDBNull(1) ? (DateTime?)null : reader.GetDateTime(1),
                                    NomeFornecedor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                    Valor = reader.IsDBNull(3) ? (double?)null : reader.GetDouble(3),
                                    Documento = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                                    TipoDocumento = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                                    PlanoDeContas = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                                    Situacao = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                                    DataVenc = reader.IsDBNull(8) ? (DateTime?)null : reader.GetDateTime(8),
                                    DataPg = reader.IsDBNull(9) ? (DateTime?)null : reader.GetDateTime(9),
                                    Obs = reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
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
    }
}