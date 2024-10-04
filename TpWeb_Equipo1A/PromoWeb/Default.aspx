<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PromoWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">

            <div class="mb-3">
                <label for="txtVoucher" class="form-label">INGRESE EL CODIGO DE SU VOUCHER</label>
                <asp:TextBox runat="server" ID="txtVoucher" CssClass="form-control" type="text" />
            </div>
            <asp:Button Text="CANJEAR" CssClass="btn btn-primary" ID="btnCanjear" OnClick="btnCanjear_Click" runat="server" />

        </div>
        <div class="lblTexto">
            <asp:Label ID="lblTexto" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
