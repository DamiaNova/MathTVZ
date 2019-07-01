<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PocetniEkran.ascx.cs" Inherits="MathTVZApp.Controls.PocetniEkran" %>
<%@ Register TagPrefix="uc" TagName="ucJednadzba" Src="~/Controls/DefinicijaImaginarneJedinice/ImaginarnaJedinicaJednadzba.ascx" %>
<%@ Register TagPrefix="uc2" TagName="ucDefinicija" Src="~/Controls/DefinicijaImaginarneJedinice/ImaginarnaJedinicaDefinicija.ascx" %>
<div>
    <h1 id="naslovKompleksniBrojevi">1. Kompleksni brojevi</h1>
    <img src="~/Slike/NavigacijaImaginarnaJedinica.png" alt="navigacijska slika" runat="server" class="imgNavigacija"/>
    <a href="/Lekcije" id="lnkLekcije">Lekcije</a>
    <a href="/Lekcije/KompleksniBrojevi" id="lnkKompleksni">Kompleksni brojevi</a>
    <a href="#" id="lnkImagJedin">1.1 Definicija imaginarne jedinice</a>
    <div id="glavniDio">
        <uc:ucJednadzba ID="ucImaginarnaJedinicaJednadzba" runat="server"/>
        <uc2:ucDefinicija ID="ucImaginarnaJedinicaDefinicija" runat="server" visible="false"/>
        <asp:Button runat="server" ID="btnDalje" CssClass="btnDalje" OnClick="btnDalje_Click" Text="Sljedeće"/>
        <asp:Button runat="server" ID="btnNazad" CssClass="btnNazad" OnClick="btnNazad_Click" Text="Nazad"/>
    </div>
</div>