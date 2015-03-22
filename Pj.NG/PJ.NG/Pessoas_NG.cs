using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_NG
{
    public static class Pessoas_NG
    {
        public static DataTable ObterPessoas_NG()
        {
            return Pj_AD.Pessoas_AD.ObterPessoas_AD();
        }
    }
}
