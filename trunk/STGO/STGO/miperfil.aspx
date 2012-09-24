<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaConMenu.master" AutoEventWireup="true"
    CodeBehind="miperfil.aspx.cs" Inherits="STGO.miperfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPagConMenu" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPaginaConMenu" runat="server">
    <div class="grid_12">
        <h1>
            Mis datos</h1>
        <p>
            Modificar los datos de su Empresa.</p>
        <form id="frmEditarEmpresa" action="default.aspx" method="post">
        <asp:Label ID="lblRazonSocial" Text="Razón Social: " runat="server" AssociatedControlID="txtRazonSocial" />
        <asp:TextBox ID="txtRazonSocial" runat="server" ValidationGroup="valGrupoEdicion"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rqfRazonSocial" runat="server" ControlToValidate="txtRazonSocial"
            ErrorMessage="Debe completar la razón social." Display="Dynamic" ValidationGroup="valGrupoEdicion"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblCuit" Text="Cuit: " runat="server" AssociatedControlID="txtCuit" />
        <asp:TextBox ID="txtCuit" runat="server" ValidationGroup="valGrupoEdicion"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rqfCuit" runat="server" ControlToValidate="txtCuit"
            ErrorMessage="Debe completar el cuit." Display="Dynamic" ValidationGroup="valGrupoEdicion"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revCuit" ErrorMessage="El formato del Cuit es inválido."
            ControlToValidate="txtCuit" runat="server" ValidationExpression="\d{2}-\d{8}-\d"
            ValidationGroup="valGrupoEdicion" Display="Dynamic" />
        <br />
        <asp:Label ID="lblTelefono" Text="Teléfono: " runat="server" AssociatedControlID="txtTelefono" />
        <asp:TextBox ID="txtTelefono" runat="server" ValidationGroup="valGrupoEdicion"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rqfTelefono" runat="server" ControlToValidate="txtTelefono"
            ErrorMessage="Debe completar el teléfono." ValidationGroup="valGrupoEdicion"
            Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revTelefono" ErrorMessage="El formato del telefono es inválido."
            ControlToValidate="txtTelefono" runat="server" ValidationGroup="valGrupoEdicion"
            Display="Dynamic" ValidationExpression="/^(\(?[0-9]{3,3}\)?|[0-9]{3,3}[-. ]?)[ ][0-9]{4,4}[-. ]?[0-9]{4,4}$/" />
        <br />
        <asp:Label ID="lblUsuario" Text="EMail: " runat="server" AssociatedControlID="txtUsuario" />
        <asp:TextBox ID="txtUsuario" ReadOnly="true" runat="server" ValidationGroup="valGrupoEdicion"
            ToolTip="El Email lo identificará como futuro usuario en el sistema."></asp:TextBox>
        <asp:RequiredFieldValidator ID="rqfUsuario" runat="server" ValidationGroup="valGrupoEdicion"
            ErrorMessage="Debe completar el email." Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revUsuario" runat="server" ValidationExpression="^([a-zA-Z0-9]+[a-zA-Z0-9._%-]*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,4})$"
            ErrorMessage="El email ingresado es inválido." Display="Dynamic" ControlToValidate="txtUsuario"
            ValidationGroup="valGrupoEdicion"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="lblPassword" Text="Contraseña: " runat="server" AssociatedControlID="txtPassword" />
        <asp:TextBox ID="txtPassword" runat="server" ValidationGroup="valGrupoEdicion"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rqfPassword" runat="server" ControlToValidate="txtPassword"
            ErrorMessage="Debe ingresar una contraseña." ValidationGroup="valGrupoEdicion"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblPasswordConfirm" Text="Repetir Contraseña: " runat="server" AssociatedControlID="txtPasswordConfirm" />
        <asp:TextBox ID="txtPasswordConfirm" runat="server" ValidationGroup="valGrupoEdicion"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rqfPasswordConfirm" runat="server" ControlToValidate="txtPasswordConfirm"
            ErrorMessage="Debe confirmar la contraseña." ValidationGroup="valGrupoEdicion"
            Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="cmvPasswordConfirm" runat="server" ControlToValidate="txtPasswordConfirm"
            ControlToCompare="txtPassword" Operator="Equal" ValidationGroup="valGrupoEdicion"
            ErrorMessage="Las contraseñas ingresadas deben ser iguales." Display="Dynamic"></asp:CompareValidator>
        </form>
    </div>
</asp:Content>
