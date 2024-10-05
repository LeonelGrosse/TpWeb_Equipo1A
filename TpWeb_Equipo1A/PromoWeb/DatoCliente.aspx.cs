using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromoWeb
{
    public partial class DatoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblErrorDireccion.Text = string.Empty;
            }
        }

        protected void ButtonParticipar_Click(object sender, EventArgs e)
        {
            lblErrorDireccion.Text = string.Empty;
            try
            {
                if(!ValidarCampos())
                {
                    return;
                }    
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
    }
}