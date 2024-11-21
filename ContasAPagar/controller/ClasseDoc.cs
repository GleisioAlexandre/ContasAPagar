using ContasAPagar.model;
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
        public void InsertDoc(string descricao)
        {
            ClasseTipoDoc tipoDoc = new ClasseTipoDoc();
            tipoDoc.InserirDocumento(descricao);
        }
        public List<Doc> CarregaGrid()
        {
            

            return null;

        }
        public class Doc
        {
            public int id { get; set; }
            public string descricao { get; set; }
        }
    }
}

