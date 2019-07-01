<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KompleksniBrojevi.aspx.cs" Inherits="MathTVZApp.Ekrani.KompleksniBrojevi" %>
<%@ Register TagPrefix="uc" TagName="ucHeader" Src="~/Controls/Header.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kompleksni brojevi</title>
    <link href="~/CSS/Master.css" rel="stylesheet" type="text/css" runat="server"/>
    <link href="~/CSS/KompleksniBrojevi.css" rel="stylesheet" type="text/css" runat="server"/>
</head>
<body>
    <header>
        <uc:ucHeader ID="ucHeader" runat="server" />
    </header>
    <form id="BodyFormKompleksni" runat="server">
        <div id="omotackompleksni">
            <img src="~/Slike/KompleksniBrojevi.png" alt="pozadinska slika" runat="server" id="imgPozadinskaSlikaKompleksni"/>
            <div>
                <h1 id="naslovKompleksni">1. Kompleksni brojevi</h1>
                <img src="~/Slike/NavigacijaKompleksni.png" alt="navigacijska slika" runat="server" id="imgNavigacijaKompleksni"/>
                <a href="/Lekcije" id="lnkLekcije">Lekcije</a>
                <a href="#" id="lnkKompleksni">Kompleksni brojevi</a>
            </div>
        </div>
    </form>
    <footer id="footerKompleksni">
        <p id="copyright">Copyright © Mia Blažeković</p>
    </footer>
</body>
</html>
