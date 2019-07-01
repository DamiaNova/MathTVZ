<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManjaCjelina.aspx.cs" Inherits="MathTVZApp.Ekrani.ManjaCjelina" %>
<%@ Register TagPrefix="uc" TagName="ucHeader" Src="~/Controls/Header.ascx" %>
<%@ Register TagPrefix="uc" TagName="ucImaginarnaJedinica" Src="~/Controls/DefinicijaImaginarneJedinice/PocetniEkran.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manja cjelina</title>
    <link href="~/CSS/Master.css" rel="stylesheet" type="text/css" runat="server"/>
    <link href="~/CSS/ManjaCjelina.css" rel="stylesheet" type="text/css" runat="server"/>
</head>
<body>
    <header>
        <uc:ucHeader ID="ucHeader" runat="server" />
    </header>
    <form id="BodyFormManjaCjelina" runat="server">
        <div id="omotacManjaCjelina">
            <img src="~/Slike/ManjaCjelina.png" alt="pozadinska slika" runat="server"/>
            <uc:ucImaginarnaJedinica ID="ucImaginarnaJedinica" runat="server" />
        </div>
    </form>
    <footer id="footerManjaCjelina">
        <p id="copyright">Copyright © Mia Blažeković</p>
    </footer>
</body>
</html>
