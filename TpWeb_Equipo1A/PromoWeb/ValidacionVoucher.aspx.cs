using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromoWeb
{
    public partial class ValidacionVoucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCanjear_Click(object sender, EventArgs e)
        {
            voucherNegocio negocio = new voucherNegocio();

            dgvVouchers.DataSource = negocio.Listar(txtVoucher.Text);
            dgvVouchers.DataBind();
        }
    }
}