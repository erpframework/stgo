<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaConMenu.master" AutoEventWireup="true"
    CodeBehind="turnos.aspx.cs" Inherits="STGO.turnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPagConMenu" runat="server">
    <title>STGO-Turnos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPaginaConMenu" runat="server">
    <div class="grid_12">
        <h1>Turnos</h1>
        <asp:Label ID="lblListaEmpresas" runat="server" AssociatedControlID="liEmpresas">Seleccione una Empresa: </asp:Label>
        <asp:DropDownList ID="liEmpresas" runat="server">
        </asp:DropDownList>
        (sólo para superusuario)<br />
        <asp:Label ID="lblLiSalas" runat="server" AssociatedControlID="liSalas">Seleccione una Sala: </asp:Label>
        <asp:DropDownList ID="liSalas" runat="server">
        </asp:DropDownList><br />
        <asp:Button ID="btnNuevoTurno" runat="server" Text="Nuevo Turno" class="boton" />
    </div>
</asp:Content>
