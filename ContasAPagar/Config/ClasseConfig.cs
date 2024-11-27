using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.Config
{
    class ClasseConfig
    {
        public string StringDeConexa()
        {
            string connectionTemplate = Configuracao.Default.stringDeConexao;
            string stringDeConexao = connectionTemplate.Replace("{User}", Configuracao.Default.User);

            return stringDeConexao;
        }
        //"User=SYSDBA; PASSWORD=masterkey; DataSource=localhost; DataBase=C:/Users/gleisio/Source/Repos/ContasAPagar/ContasAPagar/Banco de Dados/DB_CONTASAPAGAR.FDB"
    }
}
