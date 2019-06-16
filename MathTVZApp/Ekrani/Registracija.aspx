<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Master/RegistracijaPrijava.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="MathTVZApp.Ekrani.Registracija" %>
<asp:Content ContentPlaceHolderID="HeadContentRegiPrijava" runat="server">
    <link href="/CSS/RegistracijaPrijava.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyContentRegiPrijava" runat="server">
    <div>
        <p class="pPitanje">Već imate korisnički račun?</p>
        <a href="Prijava" class="aPrijaviteSe">Prijavite se.</a>
        <p class="pKorImeEmail">Korisničko ime ili e-mail adresa</p>
        <asp:TextBox ID="txbUsername" runat="server" CssClass="txbKorisnickoIme" SpellCheck="False"></asp:TextBox>
        <p class="pLozinka">Lozinka</p>
        <asp:TextBox ID="txbLozinkaZaPrijavu" runat="server" CssClass="txbLozinka" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnRegistracija" runat="server" CssClass="btnRegiPrijava" Text="Registriraj se" OnClick="btnRegistracija_Click"/>
        <img src="~\Slike\pozor.png" alt="prekratka lozinka" ID="imgPozorLozinka" class="imgPozorLozinka" runat="server" Style="visibility: hidden"/>
        <img src="~\Slike\pozor.png" alt="prekratko korisničko ime" ID="imgPozorUsername" class="imgPozorUsername" runat="server" Style="visibility: hidden"/>
        <asp:Label runat="server" ID="lblPrekratkoIme" CssClass="lblPrekratkoIme" Style="visibility: hidden">Slabo</asp:Label>
        <asp:Label runat="server" ID="lblPrekratkaLozinka" CssClass="lblPrekratkaLozinka" Style="visibility: hidden">Slabo</asp:Label>
        <asp:Label runat="server" ID="lblZauzetoIme" CssClass="lblZauzetoIme" Style="visibility: hidden">Korisničko ime je već zauzeto.</asp:Label>
    </div>
</asp:Content>
