using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class voucherNegocio
    {
        List<voucher> lista = new List<voucher>();
        accesoDatos datos = new accesoDatos();

        public List<voucher> Listar()
        {

            string select = "";
            string from = "";
            string where = "";

            try
            {
                datos.setConsulta(select + from + where);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    voucher aux = new voucher();

                    lista.Add(aux);

                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }
}
