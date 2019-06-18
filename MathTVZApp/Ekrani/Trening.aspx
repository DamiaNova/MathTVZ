<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trening.aspx.cs" Inherits="MathTVZApp.Ekrani.Trening" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trening</title>
    <link href="~/CSS/Master.css" rel="stylesheet" type="text/css" runat="server"/>
    <link href="~/CSS/Trening.css" rel="stylesheet" type="text/css" runat="server"/>
</head>
<body>
    <header>
        <div class="elNavigacije">
            <span class="wrapperZvjezdice">
                <a href="/">Što je MathTVZ?</a>
            </span>
        </div>
        <div class="zvjezdica">
            <span class="wrapperZvjezdice">
                 <img src="~/Slike/zvjezdica.png" class="imgZvjezdica" runat="server" alt="zvjezdica" />
            </span>
        </div>
        <div class="elNavigacije">
            <span class="wrapperZvjezdice">
                <a href="#">Lekcije</a>
            </span>
        </div>
        <div class="zvjezdica">
            <span class="wrapperZvjezdice">
                <img src="~/Slike/zvjezdica.png" class="imgZvjezdica" runat="server" alt="zvjezdica" />
            </span>
        </div>
        <div class="elNavigacije">
            <span class="wrapperZvjezdice">
                <img src="~/Slike/tvzLogo.png" id="logo" runat="server" alt="tvz logo"/>
            </span>
        </div>
        <div class="zvjezdica">
            <span class="wrapperZvjezdice">
                <img src="~/Slike/zvjezdica.png" class="imgZvjezdica" runat="server" alt="zvjezdica" />
            </span>
        </div>
        <div class="elNavigacije">
            <span class="wrapperZvjezdice">
                <asp:HyperLink ID="lnkPrijavaTrening" runat="server" Text="Prijava" CssClass="lnkNavigacije" NavigateUrl="#"></asp:HyperLink>
            </span>
        </div>
        <div class="zvjezdica">
            <span class="wrapperZvjezdice">
                <img src="~/Slike/zvjezdica.png" class="imgZvjezdica" runat="server" alt="zvjezdica" />
            </span>
        </div>
        <div class="elNavigacije">
            <span class="wrapperZvjezdice">
                <asp:HyperLink ID="lnkRegistracijaProfil" runat="server" Text="Registracija" CssClass="lnkNavigacije" NavigateUrl="#"></asp:HyperLink>
            </span>
        </div>
    </header>
    <form id="BodyFormTrening" runat="server">
        <div id="omotacTrening">
            <img src="~/Slike/Trening.png" alt="pozadinska slika" runat="server" id="imgPozadinskaSlikaTrening"/>
            <div>

            </div>
        </div>
    </form>
     <footer id="footerTrening">
        <p id="copyright">Copyright © Mia Blažeković</p>
    </footer>
</body>
</html>
