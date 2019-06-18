<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kvizovi.aspx.cs" Inherits="MathTVZApp.Ekrani.Kvizovi" %>
<%@ Register TagPrefix="uc" TagName="ucHeader" Src="~/Controls/Header.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kvizovi</title>
    <link href="~/CSS/Master.css" rel="stylesheet" type="text/css" runat="server"/>
    <link href="~/CSS/Kvizovi.css" rel="stylesheet" type="text/css" runat="server"/>
</head>
<body>
    <header>
        <uc:ucHeader ID="ucHeader" runat="server" />
    </header>
    <form id="BodyFormKvizovi" runat="server">
        <div id="omotacKvizovi">
            <img src="~/Slike/Kvizovi.png" alt="pozadinska slika" runat="server" id="imgPozadinskaSlikaKvizovi"/>
            <div>
                <h1 id="odabirKviza">Odaberite kviz:</h1>
                <asp:Button runat="server" ID="btnDerivacijeKviz" Text="Derivacije" CssClass="btnDerivacijeKviz" OnClick="btnDerivacije_Click"/>
                <asp:Button runat="server" ID="btnLimesiKviz" Text="Limesi" CssClass="btnLimesiKviz"/>
                <asp:Button runat="server" ID="btnInverzFunkcije" Text="Inverz funkcije" CssClass="btnInverzFunkcijeKviz"/>
                <asp:Button runat="server" ID="btnNulTočke" Text="Nultočke" CssClass="btnNulTočkeKviz"/>
                <asp:Button runat="server" ID="btnProdukti" Text="S,K,M produkti" CssClass="btnProduktiKviz"/>
                <asp:Button runat="server" ID="btnVektori" Text="Vektori" CssClass="btnVektoriKviz"/>
                <asp:Button runat="server" ID="btnSustavi" Text="Sustavi jednadžbi" CssClass="btnSustaviKviz"/>
                <asp:Button runat="server" ID="btnMatrice" Text="Matrice" CssClass="btnMatriceKviz"/>
                <asp:Button runat="server" ID="btnKompleksni" Text="KompleksniBrojevi" CssClass="btnKompleksniKviz"/>
                <asp:Button runat="server" ID="btnPovratak" Text="Povratak" CssClass="btnPovratak" OnClick="btnPovratak_Click"/>
            </div>
        </div>
    </form>
    <footer id="footerKvizoviPregled">
        <p id="copyright">Copyright © Mia Blažeković</p>
    </footer>
</body>
</html>
