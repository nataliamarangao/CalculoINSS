using INSS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Entidades
{
    internal class LogicaFaixaSalarial
    {
        private Faixa faixa;

        /// <summary>
        /// Método que irá aplicar o valor da alíquota e teto com base no ano e salário.
        /// </summary>
        /// <param name="data">Recebe a data informada no formulário pelo combobox.</param>
        /// <param name="salario">Recebe o salário digitado no formulário.</param>
        /// <returns>Retorna a classe <see cref="Faixa"/> com o valor da alíquota ou o valor do Teto.</returns>
        internal Faixa ValorAplicar(DateTime data, decimal salario)
        {
            BuscarFaixaPorAno(data.Year);

            if (salario <= faixa.Faixa1)
                faixa.AliquotaFinal = faixa.Aliquota1;
            else if (salario > faixa.Faixa1 && salario <= faixa.Faixa2)
                faixa.AliquotaFinal = faixa.Aliquota2;
            else if (salario > faixa.Faixa2 && salario <= faixa.Faixa3)
                faixa.AliquotaFinal = faixa.Aliquota3;
            else if (salario > faixa.Faixa3 && salario <= faixa.Faixa4)
                faixa.AliquotaFinal = faixa.Aliquota4;
            else
                faixa.TetoFinal = faixa.Teto;

            return faixa;
        }

        /// <summary>
        /// Realiza a busca dos valores da alíquota e teto com base no ano informado.
        /// </summary>
        /// <param name="ano">Recebe o ano no qual será preenchido os valores das faixas.</param>
        private void BuscarFaixaPorAno(int ano)
        {
            //Nesse método caso adicione mais um ano, será preciso criar uma classe Faixa para o ano.
            try
            {
                //Cria uma instancia da classe Faixa por ano.
                IFaixa instanciaFaixa = (IFaixa)Activator.CreateInstance(Type.GetType($"INSS.Entidades.Faixa{ano}"));
                //Atribui para a classe padrão da Faixa.
                faixa = instanciaFaixa.PreencherFaixas();
            }
            catch
            {
                faixa = new Faixa();
            }               

        }
    }
}
