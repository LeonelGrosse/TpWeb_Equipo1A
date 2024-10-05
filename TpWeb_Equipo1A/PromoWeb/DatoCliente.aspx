<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatoCliente.aspx.cs" Inherits="PromoWeb.DatoCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/styles.css" rel="stylesheet" />
    <script src="Scripts/scripts.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Ingresa tus datos</p>
    <asp:Label ID="lblDNI" runat="server" Text="DNI:"></asp:Label>
    <asp:TextBox ID="txtBoxDNI" runat="server" Placeholder="99887777"></asp:TextBox><br />
    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="txtBoxNombre" runat="server" Placeholder="Juanito"></asp:TextBox>
    <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
    <asp:TextBox ID="txtBoxApellido" runat="server" Placeholder="Argento"></asp:TextBox><br />
    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
    <asp:TextBox ID="txtBoxEmail" runat="server" Placeholder="email@email.com"></asp:TextBox><br />
    <asp:Label ID="lblDireccion" runat="server" Text="Dirección:"></asp:Label>
    <asp:TextBox ID="txtBoxDireccion" runat="server" CssClass="error" Placeholder="Calle 123"></asp:TextBox><br />
    <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:"></asp:Label>
    <asp:TextBox ID="txtBoxCiudad" runat="server" Placeholder="Mi ciudad"></asp:TextBox>
    <asp:Label ID="lblCP" runat="server" Text="CP:"></asp:Label>
    <asp:TextBox ID="txtBoxCP" runat="server" Placeholder="XXXX"></asp:TextBox><br />
    <asp:Label ID="lblErrorDireccion" runat="server" CssClass="error-message"></asp:Label><br />
    <asp:CheckBox ID="chkBoxTerms" runat="server" Text="Acepto los términos y condiciones." /><br />
    <asp:Button ID="BtnParticipar" runat="server" Text="¡Participar!" OnClick="ButtonParticipar_Click" CssClass="btn-participar" />
</asp:Content>


