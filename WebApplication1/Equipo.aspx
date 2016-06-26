<%@ Page Title="Equipo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Equipo.aspx.cs" Inherits="AppWeb.Equipo" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" BackColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" OnClick="Button1_Click" Text="General" />
&nbsp;<asp:Button ID="Button2" runat="server" BackColor="#00CCFF" BorderStyle="Solid" BorderWidth="1px" OnClick="Button2_Click" Text="Detallado" />
    
        

         
  
        &nbsp;-
    
        

         
  
        <asp:Label ID="VistaPlantilla" runat="server" Text="Label" Font-Size="Large" Font-Bold="True" style="text-align: center"></asp:Label>
    
        

         
  
        <asp:Panel ID="Panel1" runat="server" Height="700px" HorizontalAlign="Center" ScrollBars="Auto" Width="750px">
            <asp:GridView ID="PlantillaStars" runat="server" AutoGenerateColumns="False" DataKeyNames="Name" DataSourceID="SqlDataSource1" OnRowDataBound="PlantillaStars_RowDataBound" CssClass="CSSTableGenerator" HorizontalAlign="Center" Width="620px" >
                <Columns>
                    <asp:HyperLinkField DataTextField="Name" HeaderText="Name" SortExpression="Name" DataNavigateUrlFields="Name" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" >
                    <ItemStyle Font-Bold="True" />
                    </asp:HyperLinkField>
                    <asp:TemplateField HeaderText="Valor"></asp:TemplateField>
                    <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                    <asp:ImageField DataImageUrlField="Nat" DataImageUrlFormatString="~/Images/Paises/{0}.png" HeaderText="Nat">
                        <HeaderStyle Font-Bold="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:ImageField>
                    <asp:BoundField DataField="Prs" HeaderText="Prs" SortExpression="Prs" >
                    <ItemStyle Font-Bold="False" />
                    </asp:BoundField>
                     


                    <asp:BoundField DataField="Sm" HeaderText="Sm" SortExpression="Sm" >
                    <ItemStyle Font-Bold="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Ag" HeaderText="Ag" SortExpression="Ag"   />
                    <asp:BoundField DataField="Gam" HeaderText="Gm" SortExpression="Gam" />
                    <asp:BoundField DataField="Gls" HeaderText="Gls" SortExpression="Gls" />
                    <asp:BoundField DataField="Ass" HeaderText="Ass" SortExpression="Ass" />
                    <asp:BoundField DataField="DP" HeaderText="DP" SortExpression="DP" />
                    <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" />
                    <asp:BoundField DataField="Sus" HeaderText="Sus" SortExpression="Sus" />
                    <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" />
                </Columns>
                <EditRowStyle BorderColor="Black" />
                <SortedAscendingHeaderStyle BackColor="#99CCFF" />
                <SortedDescendingHeaderStyle BackColor="#99CCFF" />
            </asp:GridView>
            <asp:GridView ID="Plantilla" runat="server" AllowSorting="True" AutoGenerateColumns="False" CssClass="CSSTableGenerator" DataKeyNames="Name" DataSourceID="SqlDataSource1" HorizontalAlign="Center" OnRowDataBound="Plantilla_RowDataBound" Visible="False" Width="720px">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="Name" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" DataTextField="Name" HeaderText="Name" SortExpression="Name">
                    <ItemStyle Font-Bold="True" />
                    </asp:HyperLinkField>
                    <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                    <asp:ImageField DataImageUrlField="Nat" DataImageUrlFormatString="~/Images/Paises/{0}.png" HeaderText="Nat">
                        <HeaderStyle Font-Bold="False" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:ImageField>
                    <asp:BoundField DataField="Prs" HeaderText="Prs" SortExpression="Prs">
                    <ItemStyle Font-Bold="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="St" HeaderText="St" SortExpression="St">
                    <ItemStyle Font-Bold="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Tk" HeaderText="Tk" SortExpression="Tk">
                    <ItemStyle Font-Bold="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Ps" HeaderText="Ps" SortExpression="Ps">
                    <ItemStyle Font-Bold="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Sh" HeaderText="Sh" SortExpression="Sh">
                    <ItemStyle Font-Bold="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Sm" HeaderText="Sm" SortExpression="Sm">
                    <ItemStyle Font-Bold="False" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Ag" HeaderText="Ag" SortExpression="Ag" />
                    <asp:BoundField DataField="Gam" HeaderText="Gm" SortExpression="Gam" />
                    <asp:BoundField DataField="Gls" HeaderText="Gls" SortExpression="Gls" />
                    <asp:BoundField DataField="Ass" HeaderText="Ass" SortExpression="Ass" />
                    <asp:BoundField DataField="DP" HeaderText="DP" SortExpression="DP" />
                    <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" />
                    <asp:BoundField DataField="Sus" HeaderText="Sus" SortExpression="Sus" />
                    <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" />
                </Columns>
                <EditRowStyle BorderColor="Black" />
                <SortedAscendingHeaderStyle BackColor="#99CCFF" />
                <SortedDescendingHeaderStyle BackColor="#99CCFF" />
            </asp:GridView>
    </asp:Panel>
    <p>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>"  ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Name], [Age], [Nat], [Prs], [St], [Tk], [Ps], [Sh], [Sm], [Ag], [Kab], [Tab], [Pab], [Sab], [Gam], [Sav], [Ktk], [Kps], [Sht], [Gls], [Ass], [DP], [Inj], [Sus], [Fit] FROM [Jugadores] WHERE ([Equipo] = ?)" >
                         <InsertParameters>
<asp:Parameter Name="Valorazo" Type="Int32" ConvertEmptyStringToNull="true" />
</InsertParameters>
          
        </asp:SqlDataSource>

         
  
        </asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>