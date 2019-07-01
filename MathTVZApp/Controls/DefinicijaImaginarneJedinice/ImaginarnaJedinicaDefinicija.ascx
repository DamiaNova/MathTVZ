<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImaginarnaJedinicaDefinicija.ascx.cs" Inherits="MathTVZApp.Controls.DefinicijaImaginarneJedinice.ImaginarnaJedinicaDefinicija" %>
<img src="~/Slike/DefinicijaImaginarneJedinice2.png" alt="navigacijska slika" runat="server" class="imgNavigacijaIspod"/>
<div>
    <p class="prvaRecenica">
        Iz toga se razloga definira <b>imaginarna jedinica i=<span style="white-space: nowrap; font-size:larger">
        &radic;<span style="text-decoration:overline;">&nbsp;-1&nbsp;</span>
        </span></b>. To znači da su rješenja jednadžbe x<sup>2</sup> + 1 = 0 sljedeća:
    </p>
    <p id="prvoRjesenje">
        x<sub>1</sub> = 
    </p>
    <asp:TextBox runat="server" ID="txbPrviOdgovor" CssClass="txbPrviOdgovor"  style="text-align: center"></asp:TextBox>
    <asp:Button runat="server" ID="btnProvjeriPrvi" CssClass="btnProvjeriPrvi" OnClick="btnProvjeriPrvi_Click" Text="Provjeri" />
    <img src="~\Slike\pozor.png" alt="provjera unosa" ID="imgPozorPrvi" class="imgPozorPrvi" runat="server" Style="visibility: hidden"/>
    <asp:Label runat="server" Text="-" ID="lblPrviOdg" CssClass="lblPrviOdg" Style="visibility: hidden"></asp:Label>
    <p id="drugoRjesenje">
        x<sub>2</sub> = 
    </p>
    <asp:TextBox runat="server" ID="txbDrugiOdgovor" CssClass="txbDrugiOdgovor"  style="text-align: center"></asp:TextBox>
    <asp:Button runat="server" ID="btnProvjeriDrugi" CssClass="btnProvjeriDrugi" Text="Provjeri" OnClick="btnProvjeriDrugi_Click"/>
    <img src="~\Slike\ok.png" alt="provjera unosa" ID="imgPozorDrugi" class="imgPozorDrugi" runat="server" Style="visibility: hidden"/>
    <asp:Label runat="server" Text="-" ID="lblDrugiOdg" CssClass="lblDrugiOdg" Style="visibility: hidden"></asp:Label>
    <p class="drugaRecenica">
        Broj <i>i</i> čiji je kvadrat jednak -1, <i>i</i><sup>2</sup> = -1, naziv se <b><u>imaginarna jedinica</u></b>.
    </p>
    <asp:Button runat="server" ID="btnRjesenja" CssClass="btnRjesenja" Text="Prikaži rješenja" OnClick="btnRjesenja_Click"/>
</div>