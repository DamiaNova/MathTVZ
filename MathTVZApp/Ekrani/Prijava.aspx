<%@ Page Title="Prijava" Language="C#" MasterPageFile="~/Master/RegistracijaPrijava.Master" AutoEventWireup="true" CodeBehind="Prijava.aspx.cs" Inherits="MathTVZApp.Ekrani.Prijava" %>
<asp:Content ContentPlaceHolderID="HeadContentRegiPrijava" runat="server">
    <link href="/CSS/RegistracijaPrijava.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ContentPlaceHolderID="BodyContentRegiPrijava" runat="server">
    <div>
        <p class="pPitanje">Niste naš korisnik?</p>
        <a href="Registracija" class="aRegistrirajteSe">Registrirajte se.</a>
        <p class="pKorImeEmail">Korisničko ime ili e-mail adresa</p>
        <asp:TextBox ID="txbKorImeEmail" runat="server" CssClass="txbKorisnickoIme" SpellCheck="False"></asp:TextBox>
        <p class="pLozinka">Lozinka</p>
        <asp:TextBox ID="txbLozinkaZaPrijavu" runat="server" CssClass="txbLozinka" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnPrijava" runat="server" CssClass="btnRegiPrijava" Text="Prijavi se"/>
    </div>
</asp:Content>
