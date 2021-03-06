﻿<%@ Page Title="Partido" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Partido.aspx.cs" Inherits="AppWeb.Public.Partido" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    

    <section class="Partido">
        <header>
                   
            <asp:Panel ID="EstadisticasLocal" runat="server" CssClass="float-left" Width="330px">
                  <asp:Panel ID="Panel2" runat="server" Height="350px" ScrollBars="Auto" CssClass="classforpanel">
                      <asp:GridView ID="GridViewLocal" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None"  GridLines="None" BorderWidth="1px" CellPadding="4" HorizontalAlign="Center">
                    <Columns>
               <asp:BoundField DataField="Posicion" HeaderText="Ps" SortExpression="Posicion" >
                         <ItemStyle Font-Bold="True" Font-Size="Small" />
                        </asp:BoundField>
                         <asp:HyperLinkField DataTextField="Jugador" HeaderText="Jugador" SortExpression="Jugador" DataNavigateUrlFields="Jugador" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" >
                <ItemStyle Font-Bold="True" />
                </asp:HyperLinkField>
                        <asp:BoundField DataField="Ass" HeaderText="Ass" SortExpression="Ass" HeaderImageUrl="~/Content/1501-200.png" />
                        <asp:BoundField DataField="Gls" HeaderText="Gls" SortExpression="Gls" HeaderImageUrl="~/Content/minifootball.png" />
                        <asp:BoundField DataField="Yel" HeaderText="Yel" SortExpression="Yel" HeaderImageUrl="~/Content/amarilla.jpg" />
                        <asp:BoundField DataField="Red" HeaderText="Red" SortExpression="Red" HeaderImageUrl="~/Content/roja.png" />
                        <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" HeaderImageUrl="~/Content/1282.png" />
                        <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" >
                        <ItemStyle Font-Bold="False" Font-Size="Small" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Cal" SortExpression="Cal" ValidateRequestMode="Disabled">
                            <ItemStyle Font-Bold="True" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="Sav" HeaderText="Sav"  ValidateRequestMode="Disabled" />
                        <asp:BoundField DataField="Ktk" HeaderText="Ktk"  ValidateRequestMode="Disabled"/>
                        <asp:BoundField DataField="Kps" HeaderText="Kps"  ValidateRequestMode="Disabled"/>
                        <asp:BoundField DataField="Sht" HeaderText="Sht" ValidateRequestMode="Disabled"/>
                        <asp:BoundField DataField="Min" HeaderText="Min" ValidateRequestMode="Disabled"/>
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor= "#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="#CCFFCC" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                      </asp:Panel>
                  <br />
                 <asp:GridView ID="RendimientoLocal" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Minuto" HeaderText="Minuto" SortExpression="Minuto" />
                        <asp:BoundField DataField="RendimientoTk" HeaderText="Defensa" SortExpression="RendimientoTk" />
                        <asp:BoundField DataField="RendimientoPs" HeaderText="Medio" SortExpression="RendimientoPs" />
                        <asp:BoundField DataField="RendimientoSh" HeaderText="Ataque" SortExpression="RendimientoSh" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </asp:Panel>

            
            <asp:Panel ID="ResultadoEInfo" runat="server" Width="300px" CssClass="float-left" HorizontalAlign="Center">
                <asp:Label ID="EquipoLocal" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                &nbsp;<asp:Label ID="ResultadoLocal" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                &nbsp;-
                <asp:Label ID="ResultadoVisitante" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                &nbsp;<asp:Label ID="EquipoVisiitante" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>

            

                <br />
                <br />
              <asp:Panel ID="MinistatsLocal" runat="server" Width="150px" CssClass="float-left" HorizontalAlign="Center">
              
                <asp:Label ID="FormacionLocal" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
               <br />
                <asp:Label ID="TacticaLocal" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
            </asp:Panel>
                 <asp:Panel ID="MinistatsVisitante" runat="server" Width="150px" CssClass="float-left" HorizontalAlign="Center">
              
                <asp:Label ID="FormacionVisitante" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                <br />
                
                <asp:Label ID="TacticaVisitante" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
            </asp:Panel>

                
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="LabelCompetencia" runat="server" Font-Bold="True" Font-Size="Medium" Text="LabelCompetencia" ForeColor="#3366FF"></asp:Label>
                <br />
                <asp:Label ID="FechaPartido" runat="server"  Font-Bold="True" Text="FechaPartido" Font-Size="Medium" ForeColor="#3366FF" ></asp:Label>
                <br /><br />
                <asp:Label ID="TotalDisparosLocal" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                &nbsp;Disparos
                <asp:Label ID="TotalDisparosVisitante" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="ApuertaLocal" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                &nbsp;A Puerta
                <asp:Label ID="ApuertaVisitante" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="PosesionLocal" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                &nbsp;Posesión
                <asp:Label ID="PosesionVisitante" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />



                
                <asp:Label ID="Informe" runat="server" Text="Informe: "></asp:Label>

                
                <br />
           
                <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" ScrollBars="Auto" Width="300px">
                    <asp:ListBox ID="RelatoBox" runat="server" Enabled="True" Font-Bold="True" Font-Size="8pt" Rows="25" style="margin-top: 0px"></asp:ListBox>
                </asp:Panel>
                &nbsp;<br />
                 </asp:Panel>
            
            <asp:Panel ID="EstadisticasVisitante" runat="server" Width="330px" CssClass="float-left">
                <asp:Panel ID="Panel1" runat="server" Height="350px" ScrollBars="Auto" CssClass="classforpanel">
                    <asp:GridView ID="GridViewVisitante" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" GridLines="None" HorizontalAlign="Center">
                        <Columns>
                           <asp:BoundField DataField="Posicion" HeaderText="Ps" SortExpression="Posicion" >
                         <ItemStyle Font-Bold="True" Font-Size="Small" />
                        </asp:BoundField> <asp:HyperLinkField DataNavigateUrlFields="Jugador" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" DataTextField="Jugador" HeaderText="Jugador" SortExpression="Jugador">
                            <ItemStyle Font-Bold="True" />
                            </asp:HyperLinkField>
                            <asp:BoundField DataField="Ass" HeaderImageUrl="~/Content/1501-200.png" HeaderText="Ass" SortExpression="Ass" />
                            <asp:BoundField DataField="Gls" HeaderImageUrl="~/Content/minifootball.png" HeaderText="Gls" SortExpression="Gls" />
                            <asp:BoundField DataField="Yel" HeaderImageUrl="~/Content/amarilla.jpg" HeaderText="Yel" SortExpression="Yel" />
                            <asp:BoundField DataField="Red" HeaderImageUrl="~/Content/roja.png" HeaderText="Red" SortExpression="Red" />
                            <asp:BoundField DataField="Inj" HeaderImageUrl="~/Content/1282.png" HeaderText="Inj" SortExpression="Inj" />
                            <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" >
                        <ItemStyle Font-Bold="False" Font-Size="Small" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Cal" SortExpression="Cal" ValidateRequestMode="Disabled">
                            <ItemStyle Font-Bold="True" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="Sav" HeaderText="Sav"  ValidateRequestMode="Disabled" />
                        <asp:BoundField DataField="Ktk" HeaderText="Ktk"  ValidateRequestMode="Disabled"/>
                        <asp:BoundField DataField="Kps" HeaderText="Kps"  ValidateRequestMode="Disabled"/>
                        <asp:BoundField DataField="Sht" HeaderText="Sht" ValidateRequestMode="Disabled"/>
                            
                        <asp:BoundField DataField="Min" HeaderText="Min" ValidateRequestMode="Disabled"/>
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="#CCFFCC" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                   

                </asp:Panel>
                  <br />
                  <asp:GridView ID="RendimientoVisitante" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource3" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Minuto" HeaderText="Minuto" SortExpression="Minuto" />
                        <asp:BoundField DataField="RendimientoTk" HeaderText="Defensa" SortExpression="RendimientoTk" />
                        <asp:BoundField DataField="RendimientoPs" HeaderText="Medio" SortExpression="RendimientoPs" />
                        <asp:BoundField DataField="RendimientoSh" HeaderText="Ataque" SortExpression="RendimientoSh" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </asp:Panel>
           
           
           
            <br />
            <br />

            
           
            
           
           
            <asp:Panel ID="ResultadoEInfo0" runat="server" Width="320px" CssClass="float-left">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT  JugadorEnPartido.Posicion, JugadorEnPartido.Jugador, JugadorEnPartido.ID_Partido, JugadorEnPartido.Ass, JugadorEnPartido.Gls, JugadorEnPartido.Yel, JugadorEnPartido.Red, JugadorEnPartido.Inj, JugadorEnPartido.Fit, JugadorEnPartido.Sav,  JugadorEnPartido.Ktk,  JugadorEnPartido.Kps,  JugadorEnPartido.Sht, JugadorEnPartido.Min FROM (Partidos INNER JOIN JugadorEnPartido ON Partidos.Id = JugadorEnPartido.ID_Partido) WHERE (Partidos.Id = ?)">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Id" QueryStringField="Partido" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Minuto], [RendimientoTk], [RendimientoPs], [RendimientoSh] FROM [RendimientoEnPartido] WHERE (([Id_Partido] = ?) AND ([Equipo] = true))">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Id" QueryStringField="Partido" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
             <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Minuto], [RendimientoTk], [RendimientoPs], [RendimientoSh] FROM [RendimientoEnPartido] WHERE (([Id_Partido] = ?) AND ([Equipo] = false))">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Id" QueryStringField="Partido" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
               
            </asp:Panel>
            
           
           
        </header>
    </section>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>
