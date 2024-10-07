using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using dominio;
using System.Reflection;
using System.Text.RegularExpressions;

namespace negocio
{
    public class voucherNegocio
    {
        List<voucher> lista = new List<voucher>();
        accesoDatos datos = new accesoDatos();

        public List<voucher> Listar(string codigo)
        {

            string select = "select CodigoVoucher, IdCliente, FechaCanje, IdArticulo ";
            string from = "from Vouchers ";
            string where = "WHERE CodigoVoucher like ('" + codigo + "') ";

            try
            {
                datos.setConsulta(select + from + where);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    voucher aux = new voucher();

                    aux.codigo = (string)datos.Lector["CodigoVoucher"];

                    if (!(datos.Lector["FechaCanje"] is DBNull))
                    {
                        aux.idCliente = (int)datos.Lector["IdCliente"];
                        aux.fechaCanje = (DateTime)datos.Lector["FechaCanje"];
                        aux.idArticulo = (int)datos.Lector["IdArticulo"];
                    }

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
        public void modificar(voucher vou)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setConsulta("Update Vouchers set IdCliente= @IdCliente, FechaCanje= @FechaCanje, IdArticulo= @IdArticulo Where CodigoVoucher like @codigo");
                datos.setParametro("@IdCliente", vou.idCliente);
                datos.setParametro("@FechaCanje", vou.fechaCanje);
                datos.setParametro("@IdArticulo", vou.idArticulo);
                datos.setParametro("@codigo", vou.codigo);

                datos.ejecutarAccion();
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
