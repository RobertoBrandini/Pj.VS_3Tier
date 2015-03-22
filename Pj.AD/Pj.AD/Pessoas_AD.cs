using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj_AD
{
    public static class Pessoas_AD
    {
        public static DataTable ObterPessoas_AD()
        {
            DataTable dt = new DataTable();

            DataColumn col1 = new DataColumn("ID_Pessoa");
            DataColumn col2 = new DataColumn("Nome");

            col1.DataType = System.Type.GetType("System.Int32");
            col2.DataType = System.Type.GetType("System.String");

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);

            DataRow row = dt.NewRow();
            row[col1] = 1;
            row[col2] = "Joao";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[col1] = 2;
            row[col2] = "Maria";
            dt.Rows.Add(row);

            return dt;
        }
    }
}
