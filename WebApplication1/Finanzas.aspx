<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Finanzas.aspx.cs" Inherits="AppWeb.Finanzas" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    </p>
    <p>
        Dinero:
        <asp:Label ID="Dinero" runat="server" Text="Dinero"></asp:Label>
        <p>
            <strong>Ganancias Semanales:</strong><p>
        Estadio Lleno:
        <asp:Label ID="EstadioLleno" runat="server" Text="EstadioLleno"></asp:Label>

  
        <p>
            Ganancia por Auspiciantes:
        <asp:Label ID="Auspiciantes" runat="server" Text="Auspiciantes"></asp:Label>

  
        <p>
            <strong>Perdidas Semanales:</strong><p>
        Inferiores:
        <asp:Label ID="Inferiores" runat="server" Text="Inferiores"></asp:Label>

  
        <p>
            Manutencion del estadio:
        <asp:Label ID="MantencionDelEstadio" runat="server" Text="MantencionDelEstadio"></asp:Label>

  
        <p>
            Sueldos:
        <asp:Label ID="Sueldos" runat="server" Text="Sueldos"></asp:Label>

  
        <p>
            Sueldo de
            Entrenador:
        <asp:Label ID="SueldEntrenador" runat="server" Text="SueldEntrenador"></asp:Label>

  
        <p>
           
        <asp:ListView ID="ListView1" runat="server" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
            <AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="TextoLabel" runat="server" Text='<%# Eval("Texto") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                    </td>
                    <td>
                        <asp:TextBox ID="TextoTextBox" runat="server" Text='<%# Bind("Texto") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No se han devuelto datos.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                    </td>
                    <td>
                        <asp:TextBox ID="TextoTextBox" runat="server" Text='<%# Bind("Texto") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="TextoLabel" runat="server" Text='<%# Eval("Texto") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr runat="server" style="">
                                    <th runat="server">Ultimos Movimientos:</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style=""></td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="TextoLabel" runat="server" Text='<%# Eval("Texto") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
           
    <p>
            &nbsp;</asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>