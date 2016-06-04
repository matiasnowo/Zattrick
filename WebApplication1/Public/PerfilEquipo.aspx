<%@ Page Title="Equipo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilEquipo.aspx.cs" Inherits="AppWeb.Public.PerfilEquipo" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC">
            <SelectParameters>
                <asp:QueryStringParameter Name="EquipoLocal" QueryStringField="name" Type="String" />
                <asp:QueryStringParameter Name="EquipoVisitante" QueryStringField="name" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    </p>
    <asp:Panel ID="Panel1" runat="server" CssClass="float-left" Width="200px" BorderStyle="Solid">
        <p>
            Pais:
            <asp:Label ID="LabelPais" runat="server" Font-Bold="True" Text="-"></asp:Label>
          </p>  <p>
                Categoria:
                <asp:Label ID="LabelCategoria" runat="server" Font-Bold="True" Text="-"></asp:Label>
              </p>  
                <p>
                    Año de Fundacion:
                    <asp:Label ID="LabelFundacion" runat="server" Font-Bold="True" Text="-"></asp:Label>
                  </p>  
                    <p>
                        Apodo:
                        <asp:Label ID="LabelApodo" runat="server" Font-Bold="True" Text="-"></asp:Label>
                       </p> 
                        <p>
                            Leyendas:
                            <asp:Label ID="LabelLeyendas" runat="server" Font-Bold="True"  Text="-"></asp:Label>
                          </p>  <p>
                                Rival:
                                <asp:Label ID="LabelRival" runat="server" Font-Bold="True"  Text="-"></asp:Label>
                            </p>
                        
                    
      </asp:Panel>
    
      

    
  
     

  
      

     <asp:Panel ID="Panel6" runat="server" HorizontalAlign="Center" Width="235px" CssClass="float-right" BorderStyle="None">
         <asp:Panel ID="Panel5" runat="server" BorderStyle="Solid" CssClass="float-right" HorizontalAlign="Center" Width="235px">
             <strong>Mejores Jugadores:<br /> -</strong></asp:Panel>
         <asp:Panel ID="Panel4" runat="server" BorderStyle="Solid" CssClass="float-right" HorizontalAlign="Center" Width="235px">
             <strong>Estadio: </strong>
             <asp:Label ID="NombreEstadio" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
             <br />
             <p>
                 Capacidad:&nbsp;
                 <asp:Label ID="Capacidad" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
             </p>
             <p>
                 Hinchada:&nbsp;
                 <asp:Label ID="Hinchada" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
             </p>
             <p>
                 Popularidad Actual:&nbsp;
                 <asp:Label ID="PopuActual" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
             </p>
             <p>
                 Valor historico:&nbsp;
                 <asp:Label ID="VHistorico" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
             </p>
         </asp:Panel>
      </asp:Panel>
    
      

    
  
     

  
      

    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" Width="514px" CssClass="float-left" BorderStyle="Solid">
        <asp:Button ID="Button1" runat="server" BorderStyle="None" Font-Bold="True" Font-Overline="False" Font-Underline="True" OnClick="Button1_Click" Text="Ultimos Partidos:" Width="124px" />
&nbsp;<asp:GridView ID="GridViewTodoslosPartidos" OnRowDataBound="GridViewTodoslosPartidos_RowDataBound" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="5" HorizontalAlign="Center" style="text-align: center" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowCustomPaging="True">
            <Columns>
                <asp:ImageField HeaderImageUrl="~/Content/circulo-azul-icono-3849-16.png">
                </asp:ImageField>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >

                <ItemStyle Font-Bold="True" />
                </asp:BoundField>

                <asp:BoundField DataField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
                <asp:BoundField DataField="Competencia" HeaderText="Competencia" SortExpression="Competencia" >
                                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerSettings Visible="False" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </asp:Panel>

     <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center" Width="514px" CssClass="float-left" BorderStyle="Solid">
        <strong>Copas Ganadas:</strong><br /> -</asp:Panel>

     
   
      </asp:Content>

        
