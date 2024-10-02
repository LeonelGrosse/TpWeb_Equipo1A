<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ValidacionVoucher.aspx.cs" Inherits="PromoWeb.ValidacionVoucher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="row">
        <div class="col-2"></div>
        <div class="col">

            <div class="mb-3">
                <label for="txtVoucher" class="form-label">CODIGO DE VOUCHER</label>
                <asp:TextBox runat="server" ID="txtVoucher" CssClass="form-control" type="password"/>
            </div>
            <asp:Button Text="CANJEAR" CssClass="btn btn-primary" ID="btnCanjear" onclick="btnCanjear_Click" runat="server" />

        </div>
        <div class="col-2"></div>
    </div>

</asp:Content>
