<%@ Page Title="Jugador" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Jugador.aspx.cs" Inherits="AppWeb.Public.Jugador" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <section class="Jugador">
        <header>
            <asp:Panel ID="PanelInfoGral" runat="server" CssClass="float-left" Width="200px">
                <p>
                    <asp:Label ID="NamePlayer" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                </p>
                <p>
                    <img alt="NamePlayer2" class="auto-style1" src="../Content/pict--footballer-soccer-pictograms---vector-stencils-library.png--diagram-flowchart-example.png" />
                </p>
                <p>
                    Equipo Actual:
                    <asp:Label ID="EquipoActual" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                </p>
                <p>
                    Edad:
                    <asp:Label ID="Edad" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                </p>
                <p>
                    Nacionalidad:
                    <asp:Image ID="BanderaNacion" runat="server" />
                </p>
                <p>
                    Banda:
                    <asp:Label ID="Banda" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
                </p>
            </asp:Panel>

            <br />

            <br />
            <br />
            <asp:Panel ID="PanelHabilidades" runat="server" Width="200px" CssClass="float-left">
                Arquero:&nbsp;
                <asp:Label ID="St" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Defensor:&nbsp;
                <asp:Label ID="Tk" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Volante:
                <asp:Label ID="Ps" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Delantero:&nbsp;
                <asp:Label ID="Sh" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Stamina:&nbsp;
                <asp:Label ID="Sm" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Agresion:&nbsp;
                <asp:Label ID="Ag" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Forma:&nbsp;
                <asp:Label ID="Fit" runat="server" Font-Bold="True" Text="Label"></asp:Label>
            </asp:Panel>
            
            <asp:Panel ID="PanelExp" runat="server" Width="200px" CssClass="float-left">
                Exp. Arquero:&nbsp;
                <asp:Label ID="Kab" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Exp. Defensor:&nbsp;
                <asp:Label ID="Tab" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Exp. Volante:&nbsp;
                <asp:Label ID="Pab" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                Exp. Delantero:&nbsp;
                <asp:Label ID="Sab" runat="server" Font-Bold="True" Text="Label"></asp:Label>
            </asp:Panel>
             <asp:Panel ID="PanelEstadisticas" runat="server" Width="200px" CssClass="float-left">
                 Partidos Jugados:&nbsp;
                 <asp:Label ID="Gam" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                 Tapadas:&nbsp;
                 <asp:Label ID="Sav" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                 Entradas Clave:&nbsp;
                 <asp:Label ID="Ktk" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                 Pases Clave:&nbsp;
                 <asp:Label ID="Kps" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                 Tiros a Arco:&nbsp;
                 <asp:Label ID="Sht" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                 Goles:&nbsp;
                 <asp:Label ID="Gls" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                 <br />
                 Asistencias:&nbsp;
                 <asp:Label ID="Ass" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                 Amarillas: &nbsp;
                 <asp:Label ID="DP" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                 <br />
                 Lesion (Semanas):&nbsp;
                 <asp:Label ID="Inj" runat="server" Font-Bold="True" Text="Label"></asp:Label>
                <br />
                 Fechas Suspension:
                 <asp:Label ID="Sus" runat="server" Font-Bold="True" Text="Label"></asp:Label>
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
    </style>
</asp:Content>
