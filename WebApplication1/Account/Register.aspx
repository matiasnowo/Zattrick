<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AppWeb.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use el formulario siguiente para crear una cuenta nueva.</h2>
    </hgroup>
   
     
                </p>
            <h2>Nuevo Usuario</h2>
            <p>
                 <asp:Label ID="UserName" runat="server" AssociatedControlID="UserName">Nombre de usuario</asp:Label>
                <asp:TextBox ID="txtUser" runat="server" ></asp:TextBox>
               <asp:Label ID="ErrortxtUser" runat="server" CssClass="field-validation-error"  AssociatedControlID="UserName" Visible="False">El campo de nombre de usuario es obligatorio.</asp:Label>
           <asp:Label ID="ErrortxtUser2" runat="server" CssClass="field-validation-error"  AssociatedControlID="UserName" Visible="False">El nombre de usuario ya existe</asp:Label>
            </p>
            <p>
                 <asp:Label ID="Email" runat="server" AssociatedControlID="Email">Dirección de correo electrónico</asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                 <asp:Label ID="ErrortxtEmail" runat="server" CssClass="field-validation-error"  AssociatedControlID="UserName" Visible="False">El campo de nombre de E-Mail es obligatorio.</asp:Label>
        <asp:Label ID="ErrortxtEmail2" runat="server" CssClass="field-validation-error"  AssociatedControlID="UserName" Visible="False">No es un Mail Valido</asp:Label>
            
            </p>
            <p>
                 <asp:Label ID="Password" runat="server" AssociatedControlID="Password">Contraseña</asp:Label>
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="ErrortxtPass" runat="server" CssClass="field-validation-error"  AssociatedControlID="UserName" Visible="False">La contraseña debe tener al menos 6 caracteres.</asp:Label>
        
            </p>
       <p>
                 <asp:Label ID="Password2" runat="server" AssociatedControlID="Password2">Confirmar Contraseña</asp:Label>
                <asp:TextBox ID="txtPass2" runat="server" TextMode="Password"></asp:TextBox>
           <asp:Label ID="ErrortxtPass2" runat="server" CssClass="field-validation-error"  AssociatedControlID="UserName" Visible="False">Las contraseñas ingresadas no coinciden.</asp:Label>
        
            </p>
           
            <p>
                <asp:Button ID="btnCrear" runat="server" Text="Registrarse" 
                    onclick="btnCrear_Click" ValidationGroup="Requerido" 
                    />
            </p>
          
        </asp:Content>