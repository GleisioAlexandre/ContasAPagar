using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.model
{
    class ClasseContAPagar
    {
        public int Id { get; set; }
        public DateTime? Lancamento { get; set; }
        public string NomeFornecedor { get; set; }
        public double? Valor { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string PlanoDeContas { get; set; }
        public string Situacao { get; set; }
        public DateTime? DataVenc { get; set; }
        public DateTime? DataPg { get; set; }
        public string Obs { get; set; }
        public int IdFornecedor { get; set; }
        public int IdPlanoDeContas { get; set; }
        public int IdDocumento { get; set; }
    }
}
