using negocio;
using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromoWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCanjear_Click(object sender, EventArgs e)
        {
            voucherNegocio negocio = new voucherNegocio();
            voucher voucher = new voucher();
            List<voucher> voucherList = new List<voucher>();
            try
            {
                string cod = txtVoucher.Text;
                voucherList = negocio.Listar(cod);
                if (voucherList.Count != 0)
                voucher = (voucherList[0]);
                if (voucher.codigo == null)
                {
                    lblTexto.Text = "Codigo incorrecto. Ingreselo nuevamente";
                }
                else if(voucher.fechaCanje.Year != 0001)
                {
                    lblTexto.Text = "El codigo ya fue canjeado. Ingrese otro codigo";
                }
                else
                {
                    Response.Redirect("CatalogoPremios.aspx?codigo=" + txtVoucher.Text, false);
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx", false);
                throw ex;
            }
        }

    }
}