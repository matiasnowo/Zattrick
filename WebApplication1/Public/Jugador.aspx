<%@ Page Title="Jugador" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Jugador.aspx.cs" Inherits="AppWeb.Public.Jugador" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <section class="Jugador">
        <header>
            <br />
                 <span class="auto-style2">   
                    <asp:Label ID="EquipoActual" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label"></asp:Label>
                &nbsp;/
                    <asp:Label ID="NamePlayer" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label"></asp:Label>
                &nbsp;- <asp:Label ID="LabelPosicion" runat="server" Font-Bold="True" Font-Size="Large" Text="Label" CssClass="auto-style2"></asp:Label>
                <asp:Label ID="Banda" runat="server" Font-Bold="True" Font-Size="Large" Text="Label" CssClass="auto-style2"></asp:Label>
                <br /></span>
            <br />
            <asp:Panel ID="PanelInfoGral" runat="server" CssClass="float-left" Width="200px" BorderColor="Blue" BorderStyle="Groove" BorderWidth="5px" Height="280px" HorizontalAlign="Center">
                <p>
                    <img alt="NamePlayer2" class="auto-style1" src="../Content/pict--footballer-soccer-pictograms---vector-stencils-library.png--diagram-flowchart-example.png" />
                </p>
                <p><asp:Image ID="Star1" runat="server" Visible="False" />
                    <asp:Image ID="Star2" runat="server" Visible="False" />
                    <asp:Image ID="Star3" runat="server" Visible="False" />
                    <asp:Image ID="Star4" runat="server"  Visible="False"/>
                    <asp:Image ID="Star5" runat="server" Visible="False"/>
                   </p>
                <asp:Panel ID="PanelEstadisticas0" runat="server" CssClass="float-left" Width="100px" Height="70px" >
                    
                   
                    <asp:Table ID="TableNacAndSueldo" runat="server" HorizontalAlign="Center">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server"><asp:Image ID="BanderaNacion" runat="server" />
                    &nbsp;<asp:Label ID="NacionalidadLabel" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell Font-Size="X-Small" runat="server"><asp:Label ID="Sueldo" runat="server" Font-Bold="True" Font-Size="Large" Text="Sueldo"></asp:Label> <br />Sueldo </asp:TableCell>
                        </asp:TableRow>
                      
                        
                    </asp:Table>
                    <br />
                </asp:Panel>
                <asp:Panel ID="PanelEstadisticas1" runat="server" CssClass="float-left" Width="100px" Height="71px">

                    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center">
                     <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Edad: <asp:Label ID="Edad" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell  Font-Size="X-Small" runat="server"><asp:Label ID="ValorEstimado" runat="server" Font-Bold="True" Font-Size="Large" Text="Valor"></asp:Label>
                    <br />
                    Valor Estimado</asp:TableCell>
                        </asp:TableRow>

</asp:Table>

                    &nbsp;
                    <br />
                    </asp:Panel>
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
            </asp:Panel>

            <asp:Panel ID="PanelHabilidades0" runat="server" Width="600px" CssClass="float-left" BorderColor="Blue" BorderStyle="Groove" BorderWidth="5px" Height="280px">
                <asp:Panel ID="PanelHabilidades" runat="server" Width="200px" CssClass="float-left">
                    
<asp:Table ID="TableEstadisticas" runat="server" HorizontalAlign="Center">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Partidos Jugados:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Gam" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Tapadas:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Sav" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Entradas Clave:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Ktk" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Pases Clave:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Kps" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Tiros a Arco:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Sht" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Goles:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Gls" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Asistencias:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Ass" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Amarillas:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="DP" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Fechas Suspension:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Sus" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Lesion (Semanas):</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Inj" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <br />
                </asp:Panel>
                <asp:Panel ID="PanelExp" runat="server" Width="200px" CssClass="float-left">
               


                    <asp:Table ID="TableHabilidades" runat="server" HorizontalAlign="Center">
                    <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Arquero: </asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="St" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Defensor:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Tk" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Volante:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Ps" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Delantero:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Sh" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Stamina:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Sm" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Agresion:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Ag" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Forma:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Fit" runat="server" Font-Bold="True" Text="Label" ></asp:Label></asp:TableCell>
                        </asp:TableRow>
                      </asp:Table>






                </asp:Panel>
                <asp:Panel ID="PanelEstadisticas" runat="server" Width="200px" CssClass="float-left">
                   
                   
                 
              

                    <asp:Table ID="TableExp" runat="server" HorizontalAlign="Center">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Exp. Arquero:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Kab" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Exp. Defensor:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Tab" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Exp. Volante:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Pab" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Exp. Delantero:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Sab" runat="server" Font-Bold="True" Text="Label"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>

                  </asp:Panel>


            </asp:Panel>
            

           
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                Datos Actuales:</p>
            <p>
                <asp:GridView ID="GridPlayer" runat="server" AutoGenerateColumns="False" DataKeyNames="Name" DataSourceID="SqlDataSource1" Width="500px" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="St" HeaderText="St" SortExpression="St" />
                        <asp:BoundField DataField="Tk" HeaderText="Tk" SortExpression="Tk" />
                        <asp:BoundField DataField="Ps" HeaderText="Ps" SortExpression="Ps" />
                        <asp:BoundField DataField="Sh" HeaderText="Sh" SortExpression="Sh" />
                        <asp:BoundField DataField="Sm" HeaderText="Sm" SortExpression="Sm" />
                        <asp:BoundField DataField="Ag" HeaderText="Ag" SortExpression="Ag" />
                        <asp:BoundField DataField="Kab" HeaderText="Kab" SortExpression="Kab" />
                        <asp:BoundField DataField="Tab" HeaderText="Tab" SortExpression="Tab" />
                        <asp:BoundField DataField="Pab" HeaderText="Pab" SortExpression="Pab" />
                        <asp:BoundField DataField="Sab" HeaderText="Sab" SortExpression="Sab" />
                        <asp:BoundField DataField="Gam" HeaderText="Gm" SortExpression="Gam" />
                        <asp:BoundField DataField="Sav" HeaderText="Sav" SortExpression="Sav" />
                        <asp:BoundField DataField="Ktk" HeaderText="Ktk" SortExpression="Ktk" />
                        <asp:BoundField DataField="Kps" HeaderText="Kps" SortExpression="Kps" />
                        <asp:BoundField DataField="Sht" HeaderText="Sht" SortExpression="Sht" />
                        <asp:BoundField DataField="Gls" HeaderText="Gls" SortExpression="Gls" />
                        <asp:BoundField DataField="Ass" HeaderText="Ass" SortExpression="Ass" />
                        <asp:BoundField DataField="DP" HeaderText="DP" SortExpression="DP" />
                        <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" />
                        <asp:BoundField DataField="Sus" HeaderText="Sus" SortExpression="Sus" />
                        <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" />
                    </Columns>
                    <EditRowStyle BorderColor="Black" />
                    <HeaderStyle Font-Bold="False" />
                    <RowStyle Font-Bold="True" HorizontalAlign="Center" />
            <SortedAscendingHeaderStyle BackColor="#99CCFF" />
            <SortedDescendingHeaderStyle BackColor="#99CCFF" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT * FROM [Jugadores] WHERE ([Name] = ?)">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Name" QueryStringField="name" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </p>
            <p>
                &nbsp;</p>
            <p>
                Datos Historicos:</p>
            <p>
                &nbsp;</p>
            <p>
                Historial de traspasos:</p>
            <p>
                &nbsp;</p>
        </header>
    </section>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 120px;
            height: 120px;
        }
        .auto-style2 {
            font-size: large;
        }
        </style>
</asp:Content>
