<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DefinicijaImaginarneJedinice.ascx.cs" Inherits="MathTVZApp.Controls.DefinicijaImaginarneJedinice" %>
<%@ Register TagPrefix="uc" TagName="ucJednadzba" Src="~/Controls/ImaginarnaJedinicaJednadzba.ascx" %>
<div>
    <h1 id="naslovKompleksniBrojevi">1. Kompleksni brojevi</h1>
    <img src="~/Slike/NavigacijaImaginarnaJedinica.png" alt="navigacijska slika" runat="server" class="imgNavigacija"/>
    <a href="/Lekcije" id="lnkLekcije">Lekcije</a>
    <a href="/Lekcije/KompleksniBrojevi" id="lnkKompleksni">Kompleksni brojevi</a>
    <a href="#" id="lnkImagJedin">1.1 Definicija imaginarne jedinice</a>
    <div id="glavniDio">
        <uc:ucJednadzba ID="ucImaginarnaJedinicaJednadzba" runat="server" />
    </div>
</div>