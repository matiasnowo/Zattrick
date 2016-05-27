<%@ Page Title="Tactica" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tactica.aspx.cs" Inherits="AppWeb.Tactica" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" CssClass="float-right" HorizontalAlign="Right" Width="320px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="ControlID" ShowHeader="False" SortExpression="ControlID" Visible="False"></asp:TemplateField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                    <asp:BoundField DataField="Nat" HeaderText="Nat" SortExpression="Nat" />
                    <asp:BoundField DataField="Prs" HeaderText="Prs" SortExpression="Prs" />
                    <asp:BoundField DataField="St" HeaderText="St" SortExpression="St" />
                    <asp:BoundField DataField="Tk" HeaderText="Tk" SortExpression="Tk" />
                    <asp:BoundField DataField="Ps" HeaderText="Ps" SortExpression="Ps" />
                    <asp:BoundField DataField="Sh" HeaderText="Sh" SortExpression="Sh" />
                    <asp:BoundField DataField="Sm" HeaderText="Sm" SortExpression="Sm" />
                    <asp:BoundField DataField="Ag" HeaderText="Ag" SortExpression="Ag" />
                    <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" />
                    <asp:BoundField DataField="Sus" HeaderText="Sus" SortExpression="Sus" HeaderImageUrl="~/Content/roja.png" />
                    <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" />
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
    </p>
    <p>
        Tactica
        <asp:DropDownList ID="DropTactic" runat="server" OnSelectedIndexChanged="DropTactic_SelectedIndexChanged">
            <asp:ListItem Value="A">Atacante</asp:ListItem>
            <asp:ListItem Value="D">Defensivo</asp:ListItem>
            <asp:ListItem Value="P">A los Pases</asp:ListItem>
            <asp:ListItem Value="L">Pases Largos</asp:ListItem>
            <asp:ListItem Value="C">Contra-Ataque</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
        <br />
    </p>
    <p>
        Jugador1
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="GK">Portero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList156" runat="server" DataSourceID="SqlDataSource2" AutoPostBack = "true"   DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList24_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Name] FROM [Jugadores] WHERE ([Equipo] = ?)" OnSelecting="SqlDataSource2_Selecting">
            <SelectParameters>
                <asp:SessionParameter Name="Equipo" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Name], [Age], [Nat], [Prs], [St], [Tk], [Ps], [Sh], [Sm], [Ag], [Inj], [Sus], [Fit] FROM [Jugadores] WHERE ([Equipo] = ?)">
            <SelectParameters>
                <asp:SessionParameter Name="Equipo" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Name], [Age], [Nat], [Prs], [St], [Tk], [Ps], [Sh], [Sm], [Ag], [Inj], [Sus], [Fit] FROM [Jugadores] WHERE (([Equipo] = ?) AND ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?))" OnSelecting="SqlDataSource1_Selecting">
            <SelectParameters>
                <asp:SessionParameter Name="Equipo" SessionField="Equipo" Type="String" />
                <asp:ControlParameter ControlID="DropDownList156" Name="Name" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList24" Name="Name2" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList157" Name="Name3" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList158" Name="Name4" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList159" Name="Name5" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList160" Name="Name6" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList161" Name="Name7" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList162" Name="Name8" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList163" Name="Name9" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList164" Name="Name10" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList165" Name="Name11" PropertyName="SelectedValue" Type="String" />


            </SelectParameters>
        </asp:SqlDataSource>
   
        <p>
        Jugador2 <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList13" runat="server">
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList24" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name"  AutoPostBack = "true"  OnSelectedIndexChanged="DropDownList24_SelectedIndexChanged" style="margin-bottom: 0px">
        </asp:DropDownList>
        
            <p>
   
        Jugador3
        <asp:DropDownList ID="DropDownList122" runat="server">
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
        </asp:DropDownList>
    &nbsp; -
        <asp:DropDownList ID="DropDownList140" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList157" runat="server" AutoPostBack = "true"   DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList157_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Jugador4
        <asp:DropDownList ID="DropDownList123" runat="server">
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList141" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList158" runat="server" AutoPostBack = "true"   DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList158_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Jugador5
        <asp:DropDownList ID="DropDownList5" runat="server">
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
            <asp:ListItem>Volante Def</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem>Volante Ofe</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList142" runat="server">
            <asp:ListItem Value="R">Derecha</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="C">Centro</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList159" runat="server" AutoPostBack = "true"   DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList159_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Jugador6
        <asp:DropDownList ID="DropDownList124" runat="server">
            <asp:ListItem>Volante Def</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem>Volante Ofe</asp:ListItem>
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList143" runat="server">
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList160" runat="server" AutoPostBack = "true"  DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList160_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Jugador7
        <asp:DropDownList ID="DropDownList125" runat="server">
            <asp:ListItem>Volante Def</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem>Volante Ofe</asp:ListItem>
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList144" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList161" runat="server" AutoPostBack = "true"  DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList161_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Jugador8
        <asp:DropDownList ID="DropDownList126" runat="server">
            <asp:ListItem>Volante Def</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem>Volante Ofe</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList145" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList162" runat="server" AutoPostBack = "true"  DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList162_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Jugador9
        <asp:DropDownList ID="DropDownList130" runat="server">
            <asp:ListItem>Volante Def</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem>Volante Ofe</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList146" runat="server">
            <asp:ListItem Value="R">Derecha</asp:ListItem>
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList163" runat="server" AutoPostBack = "true"  DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList163_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Jugador10
        <asp:DropDownList ID="DropDownList131" runat="server">
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
            <asp:ListItem>Volante Def</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem>Volante Ofe</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList147" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList164" runat="server" AutoPostBack = "true"  DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList164_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
        
            <p>
        Jugador11
        <asp:DropDownList ID="DropDownList129" runat="server">
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList148" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList165" runat="server" AutoPostBack = "true"  DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList165_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
      
            &nbsp;<asp:Panel ID="Panel5" runat="server" CssClass="float-right" HorizontalAlign="Center" Width="501px">
        Ordenes:&nbsp;
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Name] FROM [Jugadores] WHERE ([Equipo] = ?)">
            <SelectParameters>
                <asp:SessionParameter Name="Equipo" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Height="80px" BackColor="#99CCFF" CssClass="float-right" HorizontalAlign="Center" Width="501px">
           
            1)
        <asp:DropDownList ID="DropDownList62" AutoPostBack = "true" runat="server" OnSelectedIndexChanged="DropDownList62_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="CambiarJugador">Cambiar Jugador</asp:ListItem>
            <asp:ListItem Value="CambiarPosicion">Cambiar Posicion</asp:ListItem>
            <asp:ListItem Value="CambiarTactica">Cambiar Tactica</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList63" runat="server" Enabled="false" AutoPostBack = "true" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList63_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList64" runat="server" Enabled="false" AutoPostBack = "true" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList64_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;-&nbsp;<asp:DropDownList AutoPostBack = "true" Enabled="false" ID="DropDownList260" runat="server" OnSelectedIndexChanged="DropDownList260_SelectedIndexChanged">
            <asp:ListItem Value="GK">Portero</asp:ListItem>
            <asp:ListItem Value="DFR">Defensor Derecha</asp:ListItem>
            <asp:ListItem Value="DFL">Defensor Izquierda</asp:ListItem>
            <asp:ListItem Value="DFC">Defensor Central</asp:ListItem>
            <asp:ListItem Value="DMR">Volante Defensivo Derecha</asp:ListItem>
            <asp:ListItem Value="DMC">Volante Defensivo Central</asp:ListItem>
            <asp:ListItem Value="DML">Volante Defensivo Izquierda</asp:ListItem>
            <asp:ListItem Value="MFR">Volante Derecha</asp:ListItem>
            <asp:ListItem Value="MFL">Volante Izquierda</asp:ListItem>
            <asp:ListItem Value="MFC">Volante Central</asp:ListItem>
            <asp:ListItem Value="AMR">Volante Ofensivo Derecha</asp:ListItem>
            <asp:ListItem Value="AML">Volante Ofensivo Izquierda</asp:ListItem>
            <asp:ListItem Value="AMC">Volante Ofensivo Centro</asp:ListItem>
            <asp:ListItem Value="FWR">Delantero Derecha</asp:ListItem>
            <asp:ListItem Value="FWC">Delantero Central</asp:ListItem>
            <asp:ListItem Value="FWL">Delantero Izquierda</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
            <br />
        SI
        <asp:DropDownList ID="DropDownList174" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList174_SelectedIndexChanged">
            <asp:ListItem>Minuto</asp:ListItem>
            <asp:ListItem>Resultado</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList175" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList175_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="&lt;=">&lt;=</asp:ListItem>
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList176" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList176_SelectedIndexChanged">
            <asp:ListItem>-4</asp:ListItem>
            <asp:ListItem>-3</asp:ListItem>
            <asp:ListItem>-2</asp:ListItem>
            <asp:ListItem>-1</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>65</asp:ListItem>
            <asp:ListItem>70</asp:ListItem>
            <asp:ListItem>75</asp:ListItem>
            <asp:ListItem>80</asp:ListItem>
            <asp:ListItem>85</asp:ListItem>
            <asp:ListItem>90</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
        &nbsp;Y SI
        <asp:DropDownList ID="DropDownList261" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList261_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Enabled="False">Minuto</asp:ListItem>
            <asp:ListItem>Resultado</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList262" AutoPostBack = "true" Enabled="false" runat="server">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="&lt;=">&lt;=</asp:ListItem>
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList263" AutoPostBack = "true"  Enabled="false" runat="server">
            <asp:ListItem>-4</asp:ListItem>
            <asp:ListItem>-3</asp:ListItem>
            <asp:ListItem>-2</asp:ListItem>
            <asp:ListItem>-1</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>65</asp:ListItem>
            <asp:ListItem>70</asp:ListItem>
            <asp:ListItem>75</asp:ListItem>
            <asp:ListItem>80</asp:ListItem>
            <asp:ListItem>85</asp:ListItem>
            <asp:ListItem>90</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
        </asp:Panel>                
        <asp:Panel ID="Panel2" runat="server" Height="80px" BackColor="#BBDDFF" CssClass="float-right" HorizontalAlign="Center" Width="501px">2)
        <asp:DropDownList ID="DropDownList65" AutoPostBack = "true" runat="server">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="CambiarJugador">Cambiar Jugador</asp:ListItem>
            <asp:ListItem Value="CambiarPosicion">Cambiar Posicion</asp:ListItem>
            <asp:ListItem Value="CambiarTactica">Cambiar Tactica</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
    <asp:DropDownList ID="DropDownList66" runat="server" Enabled="false" AutoPostBack = "true" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList66_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;-
       <asp:DropDownList ID="DropDownList67" runat="server" Enabled="false" AutoPostBack = "true" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList67_SelectedIndexChanged">
        </asp:DropDownList>
            &nbsp;-
            
            <asp:DropDownList ID="DropDownList178" runat="server" AutoPostBack="true" Enabled="false" OnSelectedIndexChanged="DropDownList178_SelectedIndexChanged">
                <asp:ListItem Value="GK">Portero</asp:ListItem>
                <asp:ListItem Value="DFR">Defensor Derecha</asp:ListItem>
                <asp:ListItem Value="DFL">Defensor Izquierda</asp:ListItem>
                <asp:ListItem Value="DFC">Defensor Central</asp:ListItem>
                <asp:ListItem Value="DMR">Volante Defensivo Derecha</asp:ListItem>
                <asp:ListItem Value="DMC">Volante Defensivo Central</asp:ListItem>
                <asp:ListItem Value="DML">Volante Defensivo Izquierda</asp:ListItem>
                <asp:ListItem Value="MFR">Volante Derecha</asp:ListItem>
                <asp:ListItem Value="MFL">Volante Izquierda</asp:ListItem>
                <asp:ListItem Value="MFC">Volante Central</asp:ListItem>
                <asp:ListItem Value="AMR">Volante Ofensivo Derecha</asp:ListItem>
                <asp:ListItem Value="AML">Volante Ofensivo Izquierda</asp:ListItem>
                <asp:ListItem Value="AMC">Volante Ofensivo Centro</asp:ListItem>
                <asp:ListItem Value="FWR">Delantero Derecha</asp:ListItem>
                <asp:ListItem Value="FWC">Delantero Central</asp:ListItem>
                <asp:ListItem Value="FWL">Delantero Izquierda</asp:ListItem>
                <asp:ListItem Selected="True"></asp:ListItem>
            </asp:DropDownList><br />
            &nbsp;SI&nbsp;<asp:DropDownList ID="DropDownList179" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList179_SelectedIndexChanged">
            <asp:ListItem>Minuto</asp:ListItem>
            <asp:ListItem>Resultado</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList180" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList180_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="&lt;=">&lt;=</asp:ListItem>
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList181" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList181_SelectedIndexChanged">
            <asp:ListItem>-4</asp:ListItem>
            <asp:ListItem>-3</asp:ListItem>
            <asp:ListItem>-2</asp:ListItem>
            <asp:ListItem>-1</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>65</asp:ListItem>
            <asp:ListItem>70</asp:ListItem>
            <asp:ListItem>75</asp:ListItem>
            <asp:ListItem>80</asp:ListItem>
            <asp:ListItem>85</asp:ListItem>
            <asp:ListItem>90</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
              &nbsp;Y SI
        <asp:DropDownList ID="DropDownList300" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList300_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Enabled="False">Minuto</asp:ListItem>
            <asp:ListItem>Resultado</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList301" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList301_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="&lt;=">&lt;=</asp:ListItem>
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList302" AutoPostBack = "true"  Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList302_SelectedIndexChanged">
            <asp:ListItem>-4</asp:ListItem>
            <asp:ListItem>-3</asp:ListItem>
            <asp:ListItem>-2</asp:ListItem>
            <asp:ListItem>-1</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>65</asp:ListItem>
            <asp:ListItem>70</asp:ListItem>
            <asp:ListItem>75</asp:ListItem>
            <asp:ListItem>80</asp:ListItem>
            <asp:ListItem>85</asp:ListItem>
            <asp:ListItem>90</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
</asp:Panel>
    
     

        <asp:Panel ID="Panel3" runat="server" Height="80px" BackColor="#99CCFF" CssClass="float-right" HorizontalAlign="Center" Width="501px">3)
        <asp:DropDownList ID="DropDownList303" AutoPostBack = "true" runat="server" OnSelectedIndexChanged="DropDownList303_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="CambiarJugador">Cambiar Jugador</asp:ListItem>
            <asp:ListItem Value="CambiarPosicion">Cambiar Posicion</asp:ListItem>
            <asp:ListItem Value="CambiarTactica">Cambiar Tactica</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
    <asp:DropDownList ID="DropDownList304" runat="server" Enabled="false" AutoPostBack = "true" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList304_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;-
       <asp:DropDownList ID="DropDownList305" runat="server" Enabled="false" AutoPostBack = "true" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList305_SelectedIndexChanged">
        </asp:DropDownList>
            &nbsp;-
            
            <asp:DropDownList ID="DropDownList306" runat="server" AutoPostBack="true" Enabled="false" OnSelectedIndexChanged="DropDownList306_SelectedIndexChanged">
                <asp:ListItem Value="GK">Portero</asp:ListItem>
                <asp:ListItem Value="DFR">Defensor Derecha</asp:ListItem>
                <asp:ListItem Value="DFL">Defensor Izquierda</asp:ListItem>
                <asp:ListItem Value="DFC">Defensor Central</asp:ListItem>
                <asp:ListItem Value="DMR">Volante Defensivo Derecha</asp:ListItem>
                <asp:ListItem Value="DMC">Volante Defensivo Central</asp:ListItem>
                <asp:ListItem Value="DML">Volante Defensivo Izquierda</asp:ListItem>
                <asp:ListItem Value="MFR">Volante Derecha</asp:ListItem>
                <asp:ListItem Value="MFL">Volante Izquierda</asp:ListItem>
                <asp:ListItem Value="MFC">Volante Central</asp:ListItem>
                <asp:ListItem Value="AMR">Volante Ofensivo Derecha</asp:ListItem>
                <asp:ListItem Value="AML">Volante Ofensivo Izquierda</asp:ListItem>
                <asp:ListItem Value="AMC">Volante Ofensivo Centro</asp:ListItem>
                <asp:ListItem Value="FWR">Delantero Derecha</asp:ListItem>
                <asp:ListItem Value="FWC">Delantero Central</asp:ListItem>
                <asp:ListItem Value="FWL">Delantero Izquierda</asp:ListItem>
                <asp:ListItem Selected="True"></asp:ListItem>
            </asp:DropDownList><br />
            &nbsp;SI&nbsp;<asp:DropDownList ID="DropDownList307" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList307_SelectedIndexChanged">
            <asp:ListItem>Minuto</asp:ListItem>
            <asp:ListItem>Resultado</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList308" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList308_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="&lt;=">&lt;=</asp:ListItem>
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList309" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList309_SelectedIndexChanged">
            <asp:ListItem>-4</asp:ListItem>
            <asp:ListItem>-3</asp:ListItem>
            <asp:ListItem>-2</asp:ListItem>
            <asp:ListItem>-1</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>65</asp:ListItem>
            <asp:ListItem>70</asp:ListItem>
            <asp:ListItem>75</asp:ListItem>
            <asp:ListItem>80</asp:ListItem>
            <asp:ListItem>85</asp:ListItem>
            <asp:ListItem>90</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
              &nbsp;Y SI
        <asp:DropDownList ID="DropDownList310" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList310_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Enabled="False">Minuto</asp:ListItem>
            <asp:ListItem>Resultado</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList311" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList311_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="&lt;=">&lt;=</asp:ListItem>
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList312" AutoPostBack = "true"  Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList312_SelectedIndexChanged">
            <asp:ListItem>-4</asp:ListItem>
            <asp:ListItem>-3</asp:ListItem>
            <asp:ListItem>-2</asp:ListItem>
            <asp:ListItem>-1</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>65</asp:ListItem>
            <asp:ListItem>70</asp:ListItem>
            <asp:ListItem>75</asp:ListItem>
            <asp:ListItem>80</asp:ListItem>
            <asp:ListItem>85</asp:ListItem>
            <asp:ListItem>90</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
</asp:Panel>
    
     

        <asp:Panel ID="Panel4" runat="server" Height="80px" BackColor="#BBDDFF" CssClass="float-right" HorizontalAlign="Center" Width="501px">4)
        <asp:DropDownList ID="DropDownList313" AutoPostBack = "true" runat="server" OnSelectedIndexChanged="DropDownList313_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="CambiarJugador">Cambiar Jugador</asp:ListItem>
            <asp:ListItem Value="CambiarPosicion">Cambiar Posicion</asp:ListItem>
            <asp:ListItem Value="CambiarTactica">Cambiar Tactica</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
    <asp:DropDownList ID="DropDownList314" runat="server" Enabled="false" AutoPostBack = "true" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList314_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;-
       <asp:DropDownList ID="DropDownList315" runat="server" Enabled="false" AutoPostBack = "true" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList315_SelectedIndexChanged">
        </asp:DropDownList>
            &nbsp;-
            
            <asp:DropDownList ID="DropDownList316" runat="server" AutoPostBack="true" Enabled="false" OnSelectedIndexChanged="DropDownList316_SelectedIndexChanged">
                <asp:ListItem Value="GK">Portero</asp:ListItem>
                <asp:ListItem Value="DFR">Defensor Derecha</asp:ListItem>
                <asp:ListItem Value="DFL">Defensor Izquierda</asp:ListItem>
                <asp:ListItem Value="DFC">Defensor Central</asp:ListItem>
                <asp:ListItem Value="DMR">Volante Defensivo Derecha</asp:ListItem>
                <asp:ListItem Value="DMC">Volante Defensivo Central</asp:ListItem>
                <asp:ListItem Value="DML">Volante Defensivo Izquierda</asp:ListItem>
                <asp:ListItem Value="MFR">Volante Derecha</asp:ListItem>
                <asp:ListItem Value="MFL">Volante Izquierda</asp:ListItem>
                <asp:ListItem Value="MFC">Volante Central</asp:ListItem>
                <asp:ListItem Value="AMR">Volante Ofensivo Derecha</asp:ListItem>
                <asp:ListItem Value="AML">Volante Ofensivo Izquierda</asp:ListItem>
                <asp:ListItem Value="AMC">Volante Ofensivo Centro</asp:ListItem>
                <asp:ListItem Value="FWR">Delantero Derecha</asp:ListItem>
                <asp:ListItem Value="FWC">Delantero Central</asp:ListItem>
                <asp:ListItem Value="FWL">Delantero Izquierda</asp:ListItem>
                <asp:ListItem Selected="True"></asp:ListItem>
            </asp:DropDownList><br />
            &nbsp;SI&nbsp;<asp:DropDownList ID="DropDownList317" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList317_SelectedIndexChanged">
            <asp:ListItem>Minuto</asp:ListItem>
            <asp:ListItem>Resultado</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList318" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList318_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="&lt;=">&lt;=</asp:ListItem>
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList319" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList319_SelectedIndexChanged">
            <asp:ListItem>-4</asp:ListItem>
            <asp:ListItem>-3</asp:ListItem>
            <asp:ListItem>-2</asp:ListItem>
            <asp:ListItem>-1</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>65</asp:ListItem>
            <asp:ListItem>70</asp:ListItem>
            <asp:ListItem>75</asp:ListItem>
            <asp:ListItem>80</asp:ListItem>
            <asp:ListItem>85</asp:ListItem>
            <asp:ListItem>90</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
              &nbsp;Y SI
        <asp:DropDownList ID="DropDownList320" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList320_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Enabled="False">Minuto</asp:ListItem>
            <asp:ListItem>Resultado</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList321" AutoPostBack = "true" Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList321_SelectedIndexChanged">
            <asp:ListItem Selected="True"></asp:ListItem>
            <asp:ListItem Value="&lt;=">&lt;=</asp:ListItem>
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList322" AutoPostBack = "true"  Enabled="false" runat="server" OnSelectedIndexChanged="DropDownList322_SelectedIndexChanged">
            <asp:ListItem>-4</asp:ListItem>
            <asp:ListItem>-3</asp:ListItem>
            <asp:ListItem>-2</asp:ListItem>
            <asp:ListItem>-1</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>15</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>45</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
            <asp:ListItem>60</asp:ListItem>
            <asp:ListItem>65</asp:ListItem>
            <asp:ListItem>70</asp:ListItem>
            <asp:ListItem>75</asp:ListItem>
            <asp:ListItem>80</asp:ListItem>
            <asp:ListItem>85</asp:ListItem>
            <asp:ListItem>90</asp:ListItem>
            <asp:ListItem Selected="True"></asp:ListItem>
        </asp:DropDownList>
</asp:Panel>
    
     

    <p>
        Tiros Libres: <asp:DropDownList ID="DropDownList166" Enabled ="false" runat="server" DataSourceID="SqlDataSource5" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList166_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource5" runat="server"   ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Name] FROM [Jugadores] WHERE (([Equipo] = ?) AND ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?) OR ([Name] = ?))">
            <SelectParameters>
                <asp:SessionParameter Name="Equipo" SessionField="Equipo" Type="String" />
                <asp:ControlParameter ControlID="DropDownList156" Name="Name" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList24" Name="Name2" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList157" Name="Name3" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList158" Name="Name4" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList159" Name="Name5" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList160" Name="Name6" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList161" Name="Name7" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList162" Name="Name8" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList163" Name="Name9" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList164" Name="Name10" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="DropDownList165" Name="Name11" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    <p>
        Suplente1
        <asp:DropDownList ID="DropDownList132" runat="server">
            <asp:ListItem Value="GK">Portero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList149" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList167" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList167_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Suplente2 <asp:DropDownList ID="DropDownList133" runat="server">
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList254" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList168" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList168_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Suplente3
        <asp:DropDownList ID="DropDownList134" runat="server">
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList255" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList169" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList169_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Suplente4 <asp:DropDownList ID="DropDownList135" runat="server">
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList256" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList170" runat="server"  DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList170_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Suplente5
        <asp:DropDownList ID="DropDownList136" runat="server">
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList257" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList171" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList171_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <p>
        Suplente6 <asp:DropDownList ID="DropDownList137" runat="server">
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList258" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList172" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList172_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
        <p>
        Suplente7
        <asp:DropDownList ID="DropDownList138" runat="server">
            <asp:ListItem Value="DF">Defensor</asp:ListItem>
            <asp:ListItem Value="MF">Volante</asp:ListItem>
            <asp:ListItem Value="FW">Delantero</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList259" runat="server">
            <asp:ListItem Value="C">Centro</asp:ListItem>
            <asp:ListItem Value="L">Izquierda</asp:ListItem>
            <asp:ListItem Value="R">Derecha</asp:ListItem>
        </asp:DropDownList>
    &nbsp;-
        <asp:DropDownList ID="DropDownList173" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="DropDownList173_SelectedIndexChanged" style="height: 22px">
        </asp:DropDownList>
    <asp:Panel ID="Panel6" runat="server" BorderStyle="None" HorizontalAlign="Center" Width="500px">
        <asp:Button ID="Guardar" runat="server" Text="Guardar Tactica" BorderStyle="Solid" BorderWidth="7px" BorderColor="Black" Font-Underline="False" />
    </asp:Panel>
</asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>