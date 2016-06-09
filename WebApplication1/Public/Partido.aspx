<%@ Page Title="Partido" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Partido.aspx.cs" Inherits="AppWeb.Public.Partido" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <section class="Partido">
        <header>
            <asp:Panel ID="EstadisticasLocal" runat="server" CssClass="float-left" Width="320px">
                <asp:GridView ID="GridViewLocal" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <Columns>
                        <asp:BoundField DataField="Jugador" HeaderText="Jugador" SortExpression="Jugador" />
                        <asp:BoundField DataField="Ass" HeaderText="Ass" SortExpression="Ass" />
                        <asp:BoundField DataField="Gls" HeaderText="Gls" SortExpression="Gls" />
                        <asp:BoundField DataField="Yel" HeaderText="Yel" SortExpression="Yel" />
                        <asp:BoundField DataField="Red" HeaderText="Red" SortExpression="Red" />
                        <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" />
                        <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="#99FF66" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT JugadorEnPartido.Jugador, JugadorEnPartido.ID_Partido, JugadorEnPartido.Ass, JugadorEnPartido.Gls, JugadorEnPartido.Yel, JugadorEnPartido.Red, JugadorEnPartido.Inj, JugadorEnPartido.Fit FROM (Partidos INNER JOIN JugadorEnPartido ON Partidos.Id = JugadorEnPartido.ID_Partido) WHERE (Partidos.Id = ?)">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Id" QueryStringField="Partido" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </asp:Panel>

            
            <asp:Panel ID="ResultadoEInfo" runat="server" Width="320px" CssClass="float-left">
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
            
            <asp:Panel ID="EstadisticasVisitante" runat="server" Width="320px" CssClass="float-left">
                <asp:GridView ID="GridViewVisitante" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <Columns>
                        <asp:BoundField DataField="Jugador" HeaderText="Jugador" SortExpression="Jugador" />
                        <asp:BoundField DataField="Ass" HeaderText="Ass" SortExpression="Ass" />
                        <asp:BoundField DataField="Gls" HeaderText="Gls" SortExpression="Gls" />
                        <asp:BoundField DataField="Yel" HeaderText="Yel" SortExpression="Yel" />
                        <asp:BoundField DataField="Red" HeaderText="Red" SortExpression="Red" />
                        <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" />
                        <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="#99FF66" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </asp:Panel>
           

           
        </header>
    </section>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>
