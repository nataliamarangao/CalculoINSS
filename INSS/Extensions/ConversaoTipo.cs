using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Extensions
{
    public static class ConversaoTipo
    {
        public static decimal ConvertStringToDecimal(this string stringOriginal)
        {
            return Convert.ToDecimal(stringOriginal);
        }

        public static int ConvertObjectToInt(this object objetoOriginal)
        {
            return Convert.ToInt32(objetoOriginal);
        }
    }
}
