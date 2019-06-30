<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lekcije.aspx.cs" Inherits="MathTVZApp.Ekrani.Lekcije" %>
<%@ Register TagPrefix="uc" TagName="ucHeader" Src="~/Controls/Header.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lekcije</title>
    <link href="~/CSS/Master.css" rel="stylesheet" type="text/css" runat="server"/>
    <link href="~/CSS/Lekcije.css" rel="stylesheet" type="text/css" runat="server"/>
</head>
<body>
    <header>
        <uc:ucHeader ID="ucHeader" runat="server" />
    </header>
    <form id="BodyFormLekcije" runat="server">
        <div id="omotacLekcije">
            <img src="~/Slike/Lekcije2.png" alt="pozadinska slika" runat="server" id="imgPozadinskaSlikaLekcije"/>
            <div>
                <h1 id="naslovLekcije">Lekcije</h1>
                <h2 id="zaMatematikaI">za kolegij Matematika I</h2>
                <p id="autori">Autori: Ivana Božić Dragun</p>
                    <div id="kompleksniBrojevi">
                        <a href="/Lekcije/KompleksniBrojevi" id="lnkKompleksni">
                            <img src="~/Slike/NightSky6.png" alt="pozadinska slika" runat="server" id="imgLekcija7"/>
                        </a>
                        <div class="crta">
                            <p class="nazivLekcije">Kompleksni brojevi</p>
                        </div>
                    </div>
                <div id="matrice">
                    <img src="~/Slike/NightSky3.png" alt="pozadinska slika" runat="server" id="imgLekcija6"/>
                    <div class="crta">
                        <p class="nazivLekcije">Matrice</p>
                    </div>
                </div>
                <div id="vektori">
                    <img src="~/Slike/NightSky5.png" alt="pozadinska slika" runat="server" id="imgLekcija5"/>
                    <div class="crta">
                        <p class="nazivLekcije">Vektori</p>
                    </div>
                </div>
                <div id="elementarneFunkcije">
                    <img src="~/Slike/NightSky1.png" alt="pozadinska slika" runat="server" id="imgLekcija4"/>
                    <div class="crta">
                        <p class="nazivLekcije">Elementarne funkcije</p>
                    </div>
                </div>
                <div id="limes">
                    <img src="~/Slike/NightSky2.png" alt="pozadinska slika" runat="server" id="imgLekcija3"/>
                    <div class="crta">
                        <p class="nazivLekcije">Limes i neprekidnost funkcije</p>
                    </div>
                </div>
                <div id="derivacija">
                    <img src="~/Slike/NightSky4.png" alt="pozadinska slika" runat="server" id="imgLekcija1"/>
                    <div class="crta">
                        <p class="nazivLekcije">Derivacija funkcije</p>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <footer id="footerLekcijePregled">
        <p id="copyright">Copyright © Mia Blažeković</p>
    </footer>
</body>
</html>
