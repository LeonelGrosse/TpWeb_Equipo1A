﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace PromoWeb
{
    public partial class DatoCliente : System.Web.UI.Page
    {
        ClienteNegocio negocio = new ClienteNegocio();
        public List<cliente> listaClientes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            listaClientes = negocio.listar();
            if(!IsPostBack)
            {
                lblErrorDireccion.Text = string.Empty;
            }
        }

        protected void ButtonParticipar_Click(object sender, EventArgs e)
        {
            lblErrorDireccion.Text = string.Empty;
            cliente cliente = new cliente();
            try
            {
                if(!ValidarCampos())
                {
                    return;
                }

                cliente.dni = txtBoxDNI.Text;
                cliente.nombre = txtBoxNombre.Text;
                cliente.apellido = txtBoxApellido.Text;
                cliente.email = txtBoxEmail.Text;
                cliente.direccion = txtBoxDireccion.Text;
                cliente.ciudad = txtBoxCiudad.Text;
                cliente.codigoPostal = int.Parse(txtBoxCP.Text);

                negocio.agregar(cliente);

                Response.Redirect("Exito.aspx", false);
            }
            catch (Exception ex)
            {
                lblErrorDireccion.Text = "Ocurrió un error: " + ex.Message;
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBoxDNI.Text) || !long.TryParse(txtBoxDNI.Text, out _) || txtBoxDNI.Text.Length != 8)
            {
                lblErrorDireccion.Text = "Por favor, ingresa un DNI válido de 8 dígitos y que no sea letras.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBoxNombre.Text) || !txtBoxNombre.Text.All(char.IsLetter))
            {
                lblErrorDireccion.Text = "Por favor, ingresa un nombre válido.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBoxApellido.Text) || !txtBoxApellido.Text.All(char.IsLetter))
            {
                lblErrorDireccion.Text = "Por favor, ingresa un apellido válido.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text) || !ValidacionEmail(txtBoxEmail.Text))
            {
                lblErrorDireccion.Text = "Por favor, ingresa un email válido.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBoxDireccion.Text))
            {
                lblErrorDireccion.Text = "Por favor, ingresa una dirección.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBoxCP.Text) || !int.TryParse(txtBoxCP.Text, out _))
            {
                lblErrorDireccion.Text = "Por favor, ingresa un código postal válido.";
                return false;
            }
            if (!chkBoxTerms.Checked)
            {
                lblErrorDireccion.Text = "Debes aceptar los términos y condiciones.";
                return false;
            }

            return true;
        }
        private bool ValidacionEmail(string email)
        {
            try
            {
                string aux = new MailAddress(email).Address;
                return aux == email;
            }
            catch
            {
                return false;
            }
        }

        protected void txtBoxDNI_TextChanged(object sender, EventArgs e)
        {
            foreach (var cliente in listaClientes)
            {
                if(txtBoxDNI.Text == cliente.dni)
                {
                    txtBoxNombre.Text = cliente.nombre;
                    txtBoxApellido.Text = cliente.apellido;
                    txtBoxEmail.Text = cliente.email;
                    txtBoxDireccion.Text = cliente.direccion;
                    txtBoxCiudad.Text = cliente.ciudad;
                    txtBoxCP.Text = cliente.codigoPostal.ToString();
                }
            }
        }
    }
}