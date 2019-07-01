<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImaginarnaJedinicaJednadzba.ascx.cs" Inherits="MathTVZApp.Controls.ImaginarnaJedinicaJednadzba" %>
<img src="~/Slike/DefinicijaImaginarneJedinice1.png" alt="navigacijska slika" runat="server" class="imgNavigacijaIspod"/>
<div>
    <p class="prvaRecenica">
        Jednadžba x<sup>2</sup> - 1 = 0 ima dva rješenja u skupu realnih brojeva:
    </p>
    <p id="prvoRjesenje">
        x<sub>1</sub> = 
    </p>
    <asp:TextBox runat="server" ID="txbPrviOdgovor" CssClass="txbPrviOdgovor"></asp:TextBox>
    <asp:Button runat="server" ID="btnProvjeriPrvi" CssClass="btnProvjeriPrvi" OnClick="btnProvjeriPrvi_Click" Text="Provjeri" />
    <img src="~\Slike\pozor.png" alt="provjera unosa" ID="imgPozorPrvi" class="imgPozorPrvi" runat="server" Style="visibility: hidden"/>
    <asp:Label runat="server" Text="-" ID="lblPrviOdg" CssClass="lblPrviOdg" Style="visibility: hidden"></asp:Label>
    <p id="drugoRjesenje">
        x<sub>2</sub> = 
    </p>
    <asp:TextBox runat="server" ID="txbDrugiOdgovor" CssClass="txbDrugiOdgovor"></asp:TextBox>
    <asp:Button runat="server" ID="btnProvjeriDrugi" CssClass="btnProvjeriDrugi" Text="Provjeri" OnClick="btnProvjeriDrugi_Click"/>
    <img src="~\Slike\ok.png" alt="provjera unosa" ID="imgPozorDrugi" class="imgPozorDrugi" runat="server" Style="visibility: hidden"/>
    <asp:Label runat="server" Text="-" ID="lblDrugiOdg" CssClass="lblDrugiOdg" Style="visibility: hidden"></asp:Label>
    <p class="drugaRecenica">
        Slična jednadžba x<sup>2</sup> <b>+</b> 1 = 0 nije rješiva u skupu realnih brojeva.
    </p>
    <p class="trecaRecenica">
        Ne postoji <b><u>realan</u></b> broj čiji je kvadrat jednak broju -1.
    </p>
</div>
