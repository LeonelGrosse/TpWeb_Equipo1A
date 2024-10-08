﻿using System;
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
    public class ClienteNegocio
    {
        List<cliente> lista = new List<cliente>();
        accesoDatos datos = new accesoDatos();
        public List<cliente> listar()
        {

            string consulta = "select Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from clientes"; 

            try
            {
                datos.setConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    cliente aux = new cliente();

                    aux.idCliente = (int)datos.Lector["Id"];
                    aux.dni = (string)datos.Lector["Documento"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.apellido = (string)datos.Lector["Apellido"];
                    aux.email = (string)datos.Lector["Email"];
                    aux.direccion = (string)datos.Lector["Direccion"];
                    aux.ciudad = (string)datos.Lector["Ciudad"];
                    aux.codigoPostal = (int)datos.Lector["CP"];

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
        public void agregar(cliente nuevo)
        {
            accesoDatos datos = new accesoDatos();

            try
            {
                datos.setConsulta("Insert into Clientes values (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.setParametro("@Documento", nuevo.dni);
                datos.setParametro("@Nombre", nuevo.nombre);
                datos.setParametro("@Apellido", nuevo.apellido);
                datos.setParametro("@Email", nuevo.email);
                datos.setParametro("@Direccion", nuevo.direccion);
                datos.setParametro("@Ciudad", nuevo.ciudad);
                datos.setParametro("@CP", nuevo.codigoPostal);
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
