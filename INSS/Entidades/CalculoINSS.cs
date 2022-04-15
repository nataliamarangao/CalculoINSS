using INSS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Entidades
{
    public class CalculoINSS : ICalculadorInss
    {
        /// <summary>
        /// Método que irá realizar o cálculo de desconto do INSS.
        /// </summary>
        /// <param name="data">Recebe a data informada no formulário pelo combobox.</param>
        /// <param name="salario">Recebe o salário digitado no formulário.</param>
        /// <returns>Retorna o valor do desconto com base no ano e salário.</returns>
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            //A variavel valorDesconto recebe a Faixa a ser aplicada por ano e salário.
            //Então aqui no método essa lógica nunca irá mudar.
            var valorDesconto = new LogicaFaixaSalarial().ValorAplicar(data, salario);

            if (valorDesconto.AliquotaFinal.Equals(0))
                return valorDesconto.TetoFinal;
            else
                return valorDesconto.AliquotaFinal * salario;
        }
    }
}
