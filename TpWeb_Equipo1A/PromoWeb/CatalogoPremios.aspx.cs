using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace PromoWeb
{
    public partial class CatalogoPremios : System.Web.UI.Page
    {
        public List<articulo> ListaArticulo { get; set; }
        public List<imagen> ListaImagen { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            ListaArticulo = negocio.listar();
            imagenNegocio imagenNegocio = new imagenNegocio();
            ListaImagen = imagenNegocio.listar();

            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulo;
                repRepetidor.DataBind();
            }
        }

        protected void btnCanjear_Click(object sender, EventArgs e)
        {
            string codigo = Request.Params["codigo"];
            string valor = ((Button)sender).CommandArgument;
            Response.Redirect("DatoCliente.aspx?idArticulo=" + valor + "&codigo=" + codigo, false);
        }
    }
}