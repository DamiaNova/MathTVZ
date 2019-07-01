<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImaginarnaMiniKviz.ascx.cs" Inherits="MathTVZApp.Controls.DefinicijaImaginarneJedinice.ImaginarnaMiniKviz" %>
<img src="~/Slike/DefinicijaImaginarneJedinice3.png" alt="navigacijska slika" runat="server" class="imgNavigacijaIspod"/>
<div>
    <p class="prvaRecenicaMiniKviz">Pitanja za ponavljanje:</p>
     <p class="prvoPitanje">
        1. Koliko iznosi <i>i</i><sup>2</sup> ?
    </p>
    <p id="prviOdgovorPitanje">
        Odgovor:
    </p>
    <asp:TextBox runat="server" ID="txbPrviOdgovor" CssClass="txbPrviOdgovorPitanje"  style="text-align: center"></asp:TextBox>
    <img src="~\Slike\ok.png" alt="provjera unosa" ID="imgTocnoPrvo" class="imgTocnoPrvo" runat="server" Visible ="false"/>
    <asp:Label runat="server" Text="-" ID="lblPrviOdgKviz" CssClass="lblPrviOdgKviz" Visible ="false"></asp:Label>
    <p class="drugoPitanje">
        2. Kako je definirana imaginarna jedinica?
    </p>
    <asp:RadioButtonList runat="server" ID="rblImaginarnaJedinica" CssClass="rblImaginarnaJedinica">
        <asp:ListItem> i= &#8730;-1</asp:ListItem>
        <asp:ListItem> i= &#8730;1</asp:ListItem>
        <asp:ListItem> i = &#8730;(-1)&sup2;</asp:ListItem>
    </asp:RadioButtonList>
    <img src="~\Slike\ok.png" alt="provjera unosa" ID="imgTocnoDrugo" class="imgTocnoDrugo" runat="server"  Visible ="false"/>
    <asp:Label runat="server" Text="-" ID="lblDrugiOdgKviz" CssClass="lblDrugiOdgKviz" Visible ="false"></asp:Label>
    <p class="trecePitanje">
        3. Ima li jednadžba x<sup>2</sup> <b>-</b> 1 = 0 rješenje u skupu realnih brojeva?
    </p>
    <asp:RadioButtonList runat="server" ID="rblSkupRealnih" CssClass="rblSkupRealnih">
        <asp:ListItem> Da</asp:ListItem>
        <asp:ListItem> Ne</asp:ListItem>
    </asp:RadioButtonList>
    <img src="~\Slike\ok.png" alt="provjera unosa" ID="imgTreceTocno" class="imgTreceTocno" runat="server" Visible ="false"/>
    <asp:Label runat="server" Text="-" ID="lblTreciOdgKviz" CssClass="lblTreciOdgKviz" Visible ="false"></asp:Label>
    <p class="zadnjePitanje">
        4. Ima li jednadžba x<sup>2</sup> <b>+</b> 1 = 0 rješenje u skupu realnih brojeva?
    </p>
    <asp:RadioButtonList runat="server" ID="rblNema" CssClass="rblNema">
        <asp:ListItem> Da</asp:ListItem>
        <asp:ListItem> Ne</asp:ListItem>
    </asp:RadioButtonList>
    <img src="~\Slike\ok.png" alt="provjera unosa" ID="imgTocnoCetvrto" class="imgTocnoCetvrto" runat="server" Visible ="false"/>
    <asp:Label runat="server" Text="-" ID="lblCetvrtiOdgKviz" CssClass="lblCetvrtiOdgKviz" Visible ="false"></asp:Label>
     <asp:Button runat="server" ID="btnRjesenja" CssClass="btnRjesenjaMiniKviz" Text="Prikaži rješenja" OnClick="btnRjesenja_Click"/>
    <asp:Button runat="server" ID="btnOcisti" CssClass="btnOcisti" Text="Očisti" OnClick="btnOcisti_Click"/>
    <asp:Button runat="server" ID="btnProvjeri" CssClass="btnProvjeriMiniKviz" Text="Provjeri" OnClick="btnProvjeri_Click"/>
</div>