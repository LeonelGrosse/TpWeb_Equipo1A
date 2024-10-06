<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatoCliente.aspx.cs" Inherits="PromoWeb.DatoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/styles.css" rel="stylesheet" />
    <script src="Scripts/scripts.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <h2>Ingresa tus datos</h2>
        <div class="form-group">
            <asp:Label ID="lblDNI" runat="server" Text="DNI:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtBoxDNI" runat="server" Placeholder="99887777" CssClass="form-control" OnTextChanged="txtBoxDNI_TextChanged"  AutoPostBack="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtBoxNombre" runat="server" Placeholder="Juanito" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtBoxApellido" runat="server" Placeholder="Argento" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblEmail" runat="server" Text="Email:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtBoxEmail" runat="server" Placeholder="email@email.com" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblDireccion" runat="server" Text="Dirección:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtBoxDireccion" runat="server" Placeholder="Calle 123" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCiudad" runat="server" Text="Ciudad:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtBoxCiudad" runat="server" Placeholder="Mi ciudad" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCP" runat="server" Text="CP:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtBoxCP" runat="server" Placeholder="XXXX" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Label ID="lblErrorDireccion" runat="server" CssClass="error-message"></asp:Label>
        <div class="form-group">
            <asp:CheckBox ID="chkBoxTerms" runat="server" Text="Acepto los términos y condiciones." CssClass="form-check"></asp:CheckBox>
        </div>
        <asp:Button ID="BtnParticipar" runat="server" Text="¡Participar!" OnClick="ButtonParticipar_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>


