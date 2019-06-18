<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trening.aspx.cs" Inherits="MathTVZApp.Ekrani.Trening" %>
<%@ Register TagPrefix="uc" TagName="ucHeader" Src="~/Controls/Header.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trening</title>
    <link href="~/CSS/Master.css" rel="stylesheet" type="text/css" runat="server"/>
    <link href="~/CSS/Trening.css" rel="stylesheet" type="text/css" runat="server"/>
</head>
<body>
    <header>
        <uc:ucHeader ID="ucHeader" runat="server" />
    </header>
    <form id="BodyFormTrening" runat="server">
        <div id="omotacTrening">
            <img src="~/Slike/Trening.png" alt="pozadinska slika" runat="server" id="imgPozadinskaSlikaTrening"/>
            <div>
                <h2 id="naslovKvizovi">Kvizovi</h2>
                <h3 id="naslovZadaci">Zadaci</h3>
                <h1 id="naslovPripreme">Pripreme</h1>
                <asp:Button ID="btnKvizovi" runat="server" Text="Kreni" CssClass="btnKvizovi"/>
                <asp:Button ID="btnZadaci" runat="server" Text="Kreni" CssClass="btnZadaci"/>
                <asp:Button ID="btnPripreme" runat="server" Text="Kreni" CssClass="btnPripreme"/>
            </div>
        </div>
    </form>
     <footer id="footerTrening">
        <p id="copyright">Copyright © Mia Blažeković</p>
    </footer>
</body>
</html>
