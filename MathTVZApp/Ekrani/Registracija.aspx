<%@ Page Title="" Language="C#" MasterPageFile="~/Master/RegistracijaPrijava.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="MathTVZApp.Ekrani.Registracija" %>
<asp:Content ContentPlaceHolderID="HeadContentRegiPrijava" runat="server">
    <link href="/CSS/RegistracijaPrijava.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyContentRegiPrijava" runat="server">
    <div id="Registracija">
        <p class="pPitanje">Već imate korisnički račun?</p>
        <a href="#" class="aPrijaviteSe">Prijavite se.</a>
        <p class="pKorImeEmail">Korisničko ime ili e-mail adresa</p>
        <asp:TextBox ID="txbKorImeEmail" runat="server" CssClass="txbKorisnickoIme" SpellCheck="False"></asp:TextBox>
        <p class="pLozinka">Lozinka</p>
        <asp:TextBox ID="txbLozinkaZaPrijavu" runat="server" CssClass="txbLozinka" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnRegistracija" runat="server" CssClass="btnRegiPrijava" Text="Registriraj se"/>
    </div>
</asp:Content>
