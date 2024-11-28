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
            string usuario = Configuracao.Default.User;
            string senha = Configuracao.Default.Password;
            string dataSource = Configuracao.Default.DataSource;
            string dataBase = Configuracao.Default.DataBase;
            int porta = Configuracao.Default.Porta;
            string stringDeConexao = $"User={usuario}; PASSWORD={senha}; DataSource={dataSource}; DataBase={dataBase}; Port = {porta}";

            return stringDeConexao;
        }
      
    }
}
