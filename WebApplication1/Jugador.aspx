<%@ Page Title="Jugador" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Jugador.aspx.cs" Inherits="AppWeb.Jugador" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <section class="Jugador">
        <header>
            <p>
                <asp:Label ID="NamePlayer" runat="server" Font-Bold="True" Font-Size="Large" Text="Label"></asp:Label>
            </p>
            <p>
                <img alt="NamePlayer2" class="auto-style1" src="Content/pict--footballer-soccer-pictograms---vector-stencils-library.png--diagram-flowchart-example.png" /></p>
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
            <p>
            </p>
            <p>
                Datos Actuales:</p>
            <p>
                <asp:GridView ID="GridPlayer" runat="server" AutoGenerateColumns="False" DataKeyNames="Name" DataSourceID="SqlDataSource1" Width="500px">
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Jugadores] WHERE ([Name] = ?)">
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
