using INSS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Entidades
{
    internal class Faixa2012 : IFaixa
    {
        /// <summary>
        /// Implementa o método da Interface <see cref="IFaixa"/> para preencher as faixas por ano.
        /// </summary>
        /// <returns>Retorna a classe <see cref="Faixa"/> preenchida com os valores das faixas, alíquota e teto.</returns>
        public Faixa PreencherFaixas()
        {
            var faixa2012 = new Faixa()
            {
                Faixa1 = 1000M,
                Faixa2 = 1500M,
                Faixa3 = 3000M,
                Faixa4 = 4000M,
                Aliquota1 = 0.07M,
                Aliquota2 = 0.08M,
                Aliquota3 = 0.09M,
                Aliquota4 = 0.11M,
                Teto = 500M
            };

            return faixa2012;
        }
    }
}
