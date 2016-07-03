<%@ Page Title="Equipo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilEquipo.aspx.cs" Inherits="AppWeb.Public.PerfilEquipo" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [ID], [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC">
            <SelectParameters>
                <asp:QueryStringParameter Name="EquipoLocal" QueryStringField="name" Type="String" />
                <asp:QueryStringParameter Name="EquipoVisitante" QueryStringField="name" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    <asp:Panel ID="Panel1" runat="server" CssClass="float-left" Width="190px" BorderStyle="Solid" Height="220px">
        <p>
            Pais:
            <asp:Label ID="LabelPais" runat="server" Font-Bold="True" Text="-"></asp:Label>
          </p>  
        <p>
            Categoria:<asp:Button ID="ButtCategoria" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0000CC"  BorderStyle="None" OnClick="Categoria1_Click" Text="-" />
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
    
      

    
  
     

  
      
  
     

  
      

    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" Width="514px" CssClass="float-left" BorderStyle="Solid" Height="220px">
        <asp:Label ID="LabelPartidos" runat="server" BorderStyle="None" Font-Bold="True" Font-Overline="False" Font-Underline="True" Text="Partidos:" Width="124px" ForeColor="#0000CC" />
        <asp:GridView ID="GridViewTodoslosPartidos" OnRowDataBound="GridViewTodoslosPartidos_RowDataBound" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="5" HorizontalAlign="Center" style="text-align: center" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowCustomPaging="True">
            <Columns>
                <asp:ImageField HeaderImageUrl="~/Content/circulo-azul-icono-3849-16.png">
                </asp:ImageField>
              <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/Public/Partido.aspx?partido={0}" DataTextField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
               <asp:HyperLinkField DataNavigateUrlFields="EquipoLocal" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                   <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >

                <ItemStyle Font-Bold="True" />
                </asp:BoundField>

                 <asp:HyperLinkField DataNavigateUrlFields="EquipoVisitante" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
                  <asp:HyperLinkField DataNavigateUrlFields="Competencia" DataNavigateUrlFormatString="/Public/Competencia.aspx?name={0}" DataTextField="Competencia" HeaderText="Competencia" SortExpression="Competencia" />
             
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
        <asp:Button ID="Button1" runat="server" BorderStyle="None" Font-Bold="True" Font-Overline="False" Font-Underline="True" ForeColor="#0000CC" OnClick="Button1_Click" Text="Ver todos los Partidos" />
    </asp:Panel>
        
       
          <asp:Panel ID="Panel5" runat="server" BorderStyle="Solid" CssClass="float-left" Width="230px" HorizontalAlign="Center" Height="220px">
             <strong>Mejores Jugadores:</strong>
             <asp:GridView ID="MejoresJugadores" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" HorizontalAlign="Center" ForeColor="Black" GridLines="None">
                 <AlternatingRowStyle BackColor="PaleGoldenrod" />
                 <Columns>
                        <asp:HyperLinkField DataTextField="Name" HeaderText="Jugador" SortExpression="Name" DataNavigateUrlFields="Name" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" >
                    <ItemStyle Font-Bold="True" />
                    </asp:HyperLinkField>   <asp:BoundField DataField="ValorStar" HeaderText="Valor" SortExpression="ValorStar" />
                 </Columns>
                 <FooterStyle BackColor="Tan" />
                 <HeaderStyle BackColor="Tan" Font-Bold="True" />
                 <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                 <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                 <SortedAscendingCellStyle BackColor="#FAFAE7" />
                 <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                 <SortedDescendingCellStyle BackColor="#E1DB9C" />
                 <SortedDescendingHeaderStyle BackColor="#C2A47B" />
             </asp:GridView>
             <asp:Button ID="Plantilla" runat="server" BorderStyle="None" Font-Bold="True" Font-Overline="False" Font-Underline="True" ForeColor="#0000CC" OnClick="Plantilla_Click" Text="Ver Plantilla" Width="124px" />
             <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="MejoresJugadoresDeEquipo" TypeName="DataAcces.JugadorDAO">
                 <SelectParameters>
                     <asp:QueryStringParameter Name="Equipo" QueryStringField="name" Type="String" />
                 </SelectParameters>
             </asp:ObjectDataSource>
         </asp:Panel>
            
     <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center" Width="710px" CssClass="float-left" BorderStyle="Solid" Height="200px">
        <strong>Copas Ganadas:</strong><br /> -</asp:Panel>


         <asp:Panel ID="Panel4" runat="server" BorderStyle="Solid" CssClass="float-left" HorizontalAlign="Center" Width="230px" Height="200px">
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

    
      


     
   
      </asp:Content>

        
