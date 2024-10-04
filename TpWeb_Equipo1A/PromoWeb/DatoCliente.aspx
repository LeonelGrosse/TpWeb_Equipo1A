<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatoCliente.aspx.cs" Inherits="PromoWeb.DatoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Promo Ganá!</h1>
    <p>Ingresa tus datos</p>
    <asp:Label ID="LabelDNI" runat="server" Text="DNI:"></asp:Label>
    <asp:TextBox ID="TextBoxDNI" runat="server"></asp:TextBox><br />
    <asp:Label ID="LabelNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
    <asp:Label ID="LabelApellido" runat="server" Text="Apellido:"></asp:Label>
    <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox><br />
    <asp:Label ID="LabelEmail" runat="server" Text="Email:"></asp:Label>
    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox><br />
    <asp:Label ID="LabelDireccion" runat="server" Text="Dirección:"></asp:Label>
    <asp:TextBox ID="TextBoxDireccion" runat="server" CssClass="error"></asp:TextBox><br />
    <asp:Label ID="LabelCiudad" runat="server" Text="Ciudad:"></asp:Label>
    <asp:TextBox ID="TextBoxCiudad" runat="server"></asp:TextBox>
    <asp:Label ID="LabelCP" runat="server" Text="CP:"></asp:Label>
    <asp:TextBox ID="TextBoxCP" runat="server"></asp:TextBox><br />
    <asp:CheckBox ID="CheckBoxTerms" runat="server" Text="Acepto los términos y condiciones." /><br />
    <asp:Button ID="ButtonParticipar" runat="server" Text="¡Participar!" OnClick="ButtonParticipar_Click" />
</asp:Content>

