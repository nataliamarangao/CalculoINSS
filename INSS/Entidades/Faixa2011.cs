using INSS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Entidades
{
    internal class Faixa2011 : IFaixa
    {
        /// <summary>
        /// Implementa o método da Interface <see cref="IFaixa"/> para preencher as faixas por ano.
        /// </summary>
        /// <returns>Retorna a classe <see cref="Faixa"/> preenchida com os valores das faixas, alíquota e teto.</returns>
        public Faixa PreencherFaixas()
        {
            var faixa2011 = new Faixa()
            {
                Faixa1 = 1106.90M,
                Faixa2 = 1844.83M,
                Faixa3 = 3689.66M,
                Aliquota1 = 0.08M,
                Aliquota2 = 0.09M,
                Aliquota3 = 0.11M,
                Teto = 405.86M
            };

            return faixa2011;
        }
    }
}
