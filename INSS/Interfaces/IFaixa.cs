using INSS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Interfaces
{
    public interface IFaixa
    {
        /// <summary>
	/// Preenche os valores das faixas
	/// </summary>
        Faixa PreencherFaixas();
    }
}
