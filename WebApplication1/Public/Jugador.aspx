﻿<%@ Page Title="Jugador" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Jugador.aspx.cs" Inherits="AppWeb.Public.Jugador" %>



<%@ Register assembly="Obout.Ajax.UI" namespace="Obout.Ajax.UI.SmartImage" tagprefix="obout" %>

<%@ Register assembly="obout_AJAXPage" namespace="OboutInc" tagprefix="oajax" %>

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
                            <asp:TableCell runat="server"><asp:Label ID="St" runat="server" Font-Bold="True" Text="-"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Defensor:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Tk" runat="server" Font-Bold="True" Text="-"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Volante:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Ps" runat="server" Font-Bold="True" Text="-"></asp:Label></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Delantero:</asp:TableCell>
                            <asp:TableCell runat="server"><asp:Label ID="Sh" runat="server" Font-Bold="True" Text="-"></asp:Label></asp:TableCell>
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
                   
                   
              

                    <asp:Table ID="TableExp" runat="server" HorizontalAlign="Center" Height="86px">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Exp. Arquero:</asp:TableCell>
                            <asp:TableCell runat="server">
                               
                                 <div class="totalkab" style="width:80px">
                                  
   
                  <asp:Panel runat="server" id="progressokab" style="width:100%; text-align:right" BorderStyle="Solid" BorderWidth="1" BorderColor="White">
                        <asp:Panel runat="server" id="progressokabinterno"    
         style=" 
  background-image:-webkit-linear-gradient(top, #9eddef 0%, #54c0e0 100%);
  background-image:      -o-linear-gradient(top, #9eddef 0%, #54c0e0 100%); 
  background-image: -webkit-gradient(linear, left top, left bottom, from(#9eddef), to (#54c0e0));
  background-image:         linear-gradient(to bottom, #9eddef 0%, #54c0e0 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff5bc0de', endColorstr='#ff31b0d5', GradientType=0);
  background-repeat: repeat-x;">
  <strong>     <span class="sr-only" style="color:#000000"><asp:Label ID="Kab" runat="server" Font-Bold="True" Text="100%" ></asp:Label></span></strong>
              
  </asp:Panel>    </asp:Panel>
</div>
                                

                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Exp. Defensor:</asp:TableCell>
                            <asp:TableCell runat="server"><div class="totaltab" style="width:80px">
                                  
   
                  <asp:Panel runat="server" id="progressotab" style="width:100%; text-align:right" BorderStyle="Solid" BorderWidth="1" BorderColor="White">
                        <asp:Panel runat="server" id="progressotabinterno"    
         style=" 
  background-image:-webkit-linear-gradient(top, #9eddef 0%, #54c0e0 100%);
  background-image:      -o-linear-gradient(top, #9eddef 0%, #54c0e0 100%); 
  background-image: -webkit-gradient(linear, left top, left bottom, from(#9eddef), to (#54c0e0));
  background-image:         linear-gradient(to bottom, #9eddef 0%, #54c0e0 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff5bc0de', endColorstr='#ff31b0d5', GradientType=0);
  background-repeat: repeat-x;">
  <strong>     <span class="sr-only" style="color:#000000"><asp:Label ID="Tab" runat="server" Font-Bold="True" Text="100%" ></asp:Label></span></strong>
              
  </asp:Panel>    </asp:Panel>
</div></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Exp. Volante:</asp:TableCell>
                            <asp:TableCell runat="server"><div class="totalpab" style="width:80px">
                                  
   
                  <asp:Panel runat="server" id="progressopab" style="width:100%; text-align:right" BorderStyle="Solid" BorderWidth="1" BorderColor="White">
                        <asp:Panel runat="server" id="progressopabinterno"    
         style=" 
  background-image:-webkit-linear-gradient(top, #9eddef 0%, #54c0e0 100%);
  background-image:      -o-linear-gradient(top, #9eddef 0%, #54c0e0 100%); 
  background-image: -webkit-gradient(linear, left top, left bottom, from(#9eddef), to (#54c0e0));
  background-image:         linear-gradient(to bottom, #9eddef 0%, #54c0e0 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff5bc0de', endColorstr='#ff31b0d5', GradientType=0);
  background-repeat: repeat-x;">
  <strong>     <span class="sr-only" style="color:#000000" ><asp:Label ID="Pab" runat="server" Font-Bold="True" Text="100%" ></asp:Label></span></strong>
              
  </asp:Panel>    </asp:Panel>
</div></asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Exp. Delantero:</asp:TableCell>
                            <asp:TableCell runat="server"><div class="totalsab" style="width:80px">
                                  
   
                  <asp:Panel runat="server" id="progressosab" style="width:100%; text-align:right" BorderStyle="Solid" BorderWidth="1" BorderColor="White">
                        <asp:Panel runat="server" id="progressosabinterno"    
         style=" 
  background-image:-webkit-linear-gradient(top, #9eddef 0%, #53b2ce 100%);
  background-image:      -o-linear-gradient(top, #9eddef 0%, #53b2ce 100%); 
  background-image: -webkit-gradient(linear, left top, left bottom, from(#9eddef), to (#53b2ce));
  background-image:         linear-gradient(to bottom, #9eddef 0%, #53b2ce 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff5bc0de', endColorstr='#ff31b0d5', GradientType=0);
  background-repeat: repeat-x;">
  <strong>     <span class="sr-only" style="color:#000000" ><asp:Label ID="Sab" runat="server" Font-Bold="True" Text="100%"></asp:Label></span></strong>
              
  </asp:Panel>    </asp:Panel>
</div></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    
                    
                    <br />
                    <br />

                    <br />
                    <br />
                  
<script src="../bootstrap-3.3.6-dist/js/npm.js"></script>
                    <script src="../bootstrap-3.3.6-dist/js/bootstrap.min.js"></script>
                 <link href="../bootstrap-3.3.6-dist/css/bootstrap-theme.css" rel="stylesheet" />
<script src="../bootstrap-3.3.6-dist/js/bootstrap.js"></script>
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
                Datos Historicos:</p>
            <p>
                -</p>
            <p>
                Historial de traspasos:</p>
            <p>
                -</p>
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
