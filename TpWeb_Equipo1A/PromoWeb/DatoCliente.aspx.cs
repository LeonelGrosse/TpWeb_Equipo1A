using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PromoWeb
{
    public partial class DatoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonParticipar_Click(object sender, EventArgs e)
        {
            lblErrorDireccion.Text = string.Empty;
            try
            {
                if (string.IsNullOrWhiteSpace(txtBoxDNI.Text) || !long.TryParse(txtBoxDNI.Text, out _))
                {
                    lblErrorDireccion.Text = "Por favor, ingresa un DNI válido.";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBoxNombre.Text) || !txtBoxNombre.Text.All(char.IsLetter))
                {
                    lblErrorDireccion.Text = "Por favor, ingresa un nombre válido.";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBoxApellido.Text) || !txtBoxApellido.Text.All(char.IsLetter))
                {
                    lblErrorDireccion.Text = "Por favor, ingresa un apellido válido.";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBoxEmail.Text) || !validacionEmail(txtBoxEmail.Text))
                {
                    lblErrorDireccion.Text = "Por favor, ingresa un email válido.";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBoxDireccion.Text))
                {
                    lblErrorDireccion.Text = "Por favor, ingresa una dirección.";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBoxCP.Text) || !int.TryParse(txtBoxCP.Text, out _))
                {
                    lblErrorDireccion.Text = "Por favor, ingresa un código postal válido.";
                    return;
                }
                if (!chkBoxTerms.Checked)
                {
                    lblErrorDireccion.Text = "Debes aceptar los términos y condiciones.";
                    return;
                }
            }
            catch (Exception ex)
            {
                lblErrorDireccion.Text = "Ocurrió un error: " + ex.Message;
            }
        }
        private bool validacionEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}