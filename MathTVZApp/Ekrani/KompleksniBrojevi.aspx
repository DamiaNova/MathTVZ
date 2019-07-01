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
                <a href="/Lekcije/KompleksniBrojevi/ManjaCjelina" class="lnkManjaCjelina">
                    <div id="imaginarnaJedinica">
                        <div class="prozirno">
                            <p class="nazivLekcije">1.1 Definicija imaginarne jedinice</p>
                        </div>
                    </div>
                </a>
                <a href="/Lekcije/KompleksniBrojevi/ManjaCjelina" class="lnkManjaCjelina">
                    <div id="kompleksnogBroja">
                        <div class="prozirno">
                            <p class="nazivLekcije">1.2 Definicija kompleksnog broja</p>
                        </div>
                    </div>
                </a>
                <a href="/Lekcije/KompleksniBrojevi/ManjaCjelina" class="lnkManjaCjelina">
                    <div id="operacije">
                        <div class="prozirno">
                            <p class="nazivLekcije">1.3 Operacije s kompleksnim brojevima</p>
                        </div>
                    </div>
                </a>
                <a href="/Lekcije/KompleksniBrojevi/ManjaCjelina" class="lnkManjaCjelina">
                    <div id="trigonometrijskiOblik">
                        <div class="prozirno">
                            <p class="nazivLekcije">1.4 Trigonometrijski oblik kompleksnog broja</p>
                        </div>
                    </div>
                </a>
                <a href="/Lekcije/KompleksniBrojevi/ManjaCjelina" class="lnkManjaCjelina">
                    <div id="eksponencijalniOblik">
                        <div class="prozirno">
                            <p class="nazivLekcije">1.5 Eksponencijalni oblik kompleksnog broja</p>
                        </div>
                    </div>
                </a>
                <a href="/Lekcije/KompleksniBrojevi/ManjaCjelina" class="lnkManjaCjelina">
                    <div id="zadaciKompleksni">
                        <div class="prozirno">
                            <p class="nazivLekcije">1.6 Zadaci za vježbu</p>
                        </div>
                    </div>
                </a>
                <asp:Button runat="server" ID="btnPovratak" Text="Povratak" CssClass="btnPovratak" OnClick="btnPovratak_Click"/>
            </div>
        </div>
    </form>
    <footer id="footerKompleksni">
        <p id="copyright">Copyright © Mia Blažeković</p>
    </footer>
</body>
</html>
