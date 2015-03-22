using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pj_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLerPessoas_Click(object sender, EventArgs e)
        {
            DataTable dt = PJ_NG.Pessoas_NG.ObterPessoas_NG();
            gvwPessoas.DataSource = dt;
            gvwPessoas.DataBind();
        }
    }
}