<%@ Page Title="Equipo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Competencia.aspx.cs" Inherits="AppWeb.Public.Competencia" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Equipo], [Jugados], [Ganados], [Empatados], [Perdidos], [GolesFavor], [GolesContra], [Puntos] FROM [Tablas] WHERE (([Competencia] = ?) AND ([Temporada] = ?) AND ([Sub-Fase] = ?) AND ([Fase] = ?))">
            <SelectParameters>
                <asp:QueryStringParameter Name="Competencia" QueryStringField="name" Type="String" />
                <asp:ControlParameter ControlID="LabelTemporada" Name="Temporada" PropertyName="Text" Type="Int32" />
                <asp:QueryStringParameter Name="column1" QueryStringField="subfase" Type="String" />
                <asp:QueryStringParameter Name="Fase" QueryStringField="fase" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    <asp:Panel ID="Panel1" runat="server" CssClass="float-left" Width="190px" BorderStyle="Solid" Height="350px">
        <p>
            Pais:
            <asp:Label ID="LabelPais" runat="server" Font-Bold="True" Text="-"></asp:Label>
          </p>    
                <p>
                    Temporada Actual:
                    <asp:Label ID="LabelTemporada" runat="server" Font-Bold="True" Text="-"></asp:Label>
                  </p>  
                        
                    
      </asp:Panel>
    
      

    
  
     

  
      
  
     

  
      

    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" Width="490px" CssClass="float-left" BorderStyle="Solid" Height="350px">
        <asp:Label ID="LabelTabla" runat="server" BorderStyle="None" Font-Bold="True" Font-Overline="False" Font-Underline="True" Text="Tabla:" Width="124px" ForeColor="#0000CC" />
        <asp:GridView ID="GridViewTablaCompetencia" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="5" HorizontalAlign="Center" style="text-align: center; margin-top: 0px;" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
               <asp:HyperLinkField DataNavigateUrlFields="Equipo" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="Equipo" HeaderText="Equipo" SortExpression="Equipo" />
              
                <asp:BoundField DataField="Jugados" HeaderText="Jug" SortExpression="Jugados" >

                </asp:BoundField>

                 <asp:BoundField DataField="Ganados" HeaderText="Gan" SortExpression="Ganados" >
                                </asp:BoundField>
                <asp:BoundField DataField="Empatados" HeaderText="Emp" SortExpression="Empatados" />
                <asp:BoundField DataField="Perdidos" HeaderText="Per" SortExpression="Perdidos" />
                <asp:BoundField DataField="GolesFavor" HeaderText="Fav" SortExpression="GolesFavor" />
                <asp:BoundField DataField="GolesContra" HeaderText="Cont" SortExpression="GolesContra" />
                <asp:TemplateField HeaderText="Dif"></asp:TemplateField>
                <asp:BoundField DataField="Puntos" HeaderText="Puntos" SortExpression="Puntos" />
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
        
       
          <asp:Panel ID="Panel5" runat="server" BorderStyle="Solid" CssClass="float-left" Width="254px" HorizontalAlign="Center" Height="350px">
             <strong>Mejores Jugadores:</strong>
             <asp:GridView ID="MejoresJugadores" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" HorizontalAlign="Center" ForeColor="Black" GridLines="None">
                 <AlternatingRowStyle BackColor="PaleGoldenrod" />
                 <Columns>
                   <asp:HyperLinkField DataNavigateUrlFields="Equipo" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="Equipo" />
              
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
             <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="MejoresJugadoresDeCompetencia" TypeName="DataAcces.JugadorDAO">
                 <SelectParameters>
                     <asp:QueryStringParameter Name="Competencia" QueryStringField="name" Type="String" />
                 </SelectParameters>
             </asp:ObjectDataSource>
         </asp:Panel>
            
     <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center" Width="486px" CssClass="float-left" BorderStyle="Solid" Height="350px">
            
            
                 <asp:Panel ID="Panel7" runat="server" CssClass="float-left" Height="350px" Width="200px" HorizontalAlign="Center">
                     <span class="auto-style1"><strong>Asistidores
                     <br />
                     </strong> </span>
                     <asp:GridView ID="Asistidores" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="ObjectDataSource3" ForeColor="Black" GridLines="None" HorizontalAlign="Center">
                         <AlternatingRowStyle BackColor="PaleGoldenrod" />
                         <Columns>
                             <asp:HyperLinkField DataNavigateUrlFields="Equipo" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="Equipo" />
                             <asp:HyperLinkField DataNavigateUrlFields="Name" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" DataTextField="Name" HeaderText="Jugador" SortExpression="Name">
                             <ItemStyle Font-Bold="True" />
                             </asp:HyperLinkField>
                             <asp:BoundField DataField="Ass" HeaderText="Asists" SortExpression="Ass" />
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
                    
                 </asp:Panel>
                <asp:Panel ID="Panel6" runat="server" Width="200px" CssClass="float-right" Height="350px" HorizontalAlign="Center">
                 <strong><span class="auto-style1">Goleadores<br />  </span></strong>
                 <asp:GridView ID="Goleadores" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="ObjectDataSource2" ForeColor="Black" GridLines="None" HorizontalAlign="Center">
                     <AlternatingRowStyle BackColor="PaleGoldenrod" />
                     <Columns>
                         <asp:HyperLinkField DataNavigateUrlFields="Equipo" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="Equipo" />
                         <asp:HyperLinkField DataNavigateUrlFields="Name" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" DataTextField="Name" HeaderText="Jugador" SortExpression="Name">
                         <ItemStyle Font-Bold="True" />
                         </asp:HyperLinkField>
                         <asp:BoundField DataField="Gls" HeaderText="Goles" SortExpression="Gls" />
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
                 </asp:Panel>
             </asp:Panel>
             <br /> 
             <br />
              <strong>
             <br />
             <br />
             <br /> </strong>
             <br />
         <br />
         <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GoleadoresDeCompetencia" TypeName="DataAcces.JugadorDAO">
             <SelectParameters>
                 <asp:QueryStringParameter Name="Competencia" QueryStringField="name" Type="String" />
                 <asp:QueryStringParameter Name="Temporada" QueryStringField="temporada" Type="Int32" />
                 <asp:QueryStringParameter Name="Fase" QueryStringField="fase" Type="String" />
             </SelectParameters>
         </asp:ObjectDataSource>
      </asp:Panel>

         <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="AsistidoresDeCompetencia" TypeName="DataAcces.JugadorDAO">
             <SelectParameters>
                 <asp:QueryStringParameter Name="Competencia" QueryStringField="name" Type="String" />
                 <asp:QueryStringParameter Name="Temporada" QueryStringField="temporada" Type="Int32" />
                 <asp:QueryStringParameter Name="Fase" QueryStringField="fase" Type="String" />
             </SelectParameters>
         </asp:ObjectDataSource>



         <asp:Panel ID="Panel4" runat="server" BorderStyle="Solid" CssClass="float-left" HorizontalAlign="Center" Width="454px" Height="350px">
             <strong><span class="auto-style2">Ultimos Ganadores:<br /> </span>
             <asp:GridView ID="UltimosGanadores" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="SqlDataSource2" GridLines="Horizontal" HorizontalAlign="Center">
                 <Columns>
                     <asp:BoundField DataField="Temporada" HeaderText="Año" SortExpression="Temporada" />
                     <asp:BoundField DataField="Fase" HeaderText="Fase" SortExpression="Fase" />
                 <asp:HyperLinkField HeaderText="Campeon" DataNavigateUrlFields="Campeon" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="Campeon" />
                            
                            <asp:BoundField DataField="SegundoPuesto" HeaderText="Segundo" SortExpression="SegundoPuesto" />
                     <asp:BoundField DataField="TercerPuesto" HeaderText="Tercer" SortExpression="TercerPuesto" />
                 </Columns>
                 <FooterStyle BackColor="White" ForeColor="#333333" />
                 <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="White" ForeColor="#333333" />
                 <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F7F7F7" />
                 <SortedAscendingHeaderStyle BackColor="#487575" />
                 <SortedDescendingCellStyle BackColor="#E5E5E5" />
                 <SortedDescendingHeaderStyle BackColor="#275353" />
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Fase], [Temporada], [Campeon], [SegundoPuesto], [TercerPuesto] FROM [UltimosGanadores] WHERE ([Competencia] = ?)">
                 <SelectParameters>
                     <asp:QueryStringParameter Name="Competencia" QueryStringField="Name" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
             </strong></asp:Panel>

    
      


     
   
      </asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</asp:Content>


        
