<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CatalogoPremios.aspx.cs" Inherits="PromoWeb.CatalogoPremios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/styles.css" rel="stylesheet" />
    <script src="Scripts/scripts.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="h2Catalogo">Selecciona tu premio</h2>
    <hr />

    <div class="row row-cols-1 row-cols-md-3 g-4">

        <asp:Repeater ID="repRepetidor" runat="server">
            <ItemTemplate>
                <div class="col">
                    <div class="card h-100">
                        <!--   
                        <asp:Repeater ID="repetidor" runat="server">
                            <ItemTemplate>
                                <img src="<%#Eval("urlImagen") %>" class="card-img-top" alt="...">
                            </ItemTemplate>
                        </asp:Repeater>
                         -->
                        <img src="<%#Eval("imagen.urlImagen") %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("nombre")%></h5>
                            <p class="card-text"><%#Eval("descripcion")%></p>
                        </div>
                        <div class="card-footer">
                            <asp:Button ID="btnCanjear" runat="server" Text="Elegir este premio" CssClass="btn btn-primary" CommandArgument='<%#Eval("idArticulo")%>' CommandName="IDArticulo" OnClick="btnCanjear_Click" />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
