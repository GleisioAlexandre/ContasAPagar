using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.Config
{
    class ClasseGlobal
    {
        public string usuario = Configuracao.Default.User;
        public string senha = Configuracao.Default.Password;
        public string dataSourc = Configuracao.Default.DataSource;
        public string dataBase = Configuracao.Default.DataBase;
        public int porta = Configuracao.Default.Porta;
    }
}
