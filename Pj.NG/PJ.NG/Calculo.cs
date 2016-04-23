using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj_NG
{
    /// <summary>
    /// 
    /// </summary>
    public static class Calculo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="precoCompra"></param>
        /// <param name="margemLucro"></param>
        /// <returns></returns>
        public static Decimal CalcularPrecoVenda(decimal precoCompra, decimal margemLucro)
        {
            return precoCompra * (1 + (margemLucro / 100));
        }

    }
}
