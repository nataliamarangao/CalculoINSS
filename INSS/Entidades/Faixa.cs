using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Entidades
{
    public class Faixa
    {
        public virtual decimal Faixa1 { get; set; }
        public virtual decimal Faixa2 { get; set; }
        public virtual decimal Faixa3 { get; set; }
        public virtual decimal Faixa4 { get; set; }
        public virtual decimal Aliquota1 { get; set; }
        public virtual decimal Aliquota2 { get; set; }
        public virtual decimal Aliquota3 { get; set; }
        public virtual decimal Aliquota4 { get; set; }
        public virtual decimal AliquotaFinal { get; set; }
        public virtual decimal Teto { get; set; }
        public virtual decimal TetoFinal { get; set; }
    }
}
