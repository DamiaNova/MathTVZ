<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="MathTVZApp.Ekrani.Profil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Moj profil</title>
    <link href="~/CSS/Master.css" rel="stylesheet" type="text/css" runat="server"/>
    <link href="~/CSS/Profil.css" rel="stylesheet" type="text/css" runat="server"/>
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
    <form id="BodyFormProfil" runat="server">
        <div id="omotacProfil">
            <img src="~/Slike/Profil.png" alt="pozadinska slika" runat="server" id="imgPozadinskaSlikaProfil"/>
            <div>
                <asp:Button ID="btnOdjava" runat="server" CssClass="btnOdjava" Text="Odjava" OnClick="btnOdjava_Click"/>
                <img src="~\Slike\Diamond.png" alt="dijamantna medalja" id="imgDiamond" class="imgMedalja" runat="server"/>
                <img src="~\Slike\Bronze.png" alt="brončana medalja" id="imgBronze" class="imgMedalja" runat="server" style="visibility: hidden"/>
                <img src="~\Slike\Silver.png" alt="srebrna medalja" id="imgSilver" class="imgMedalja" runat="server" style="visibility: hidden"/>
                <img src="~\Slike\Gold.png" alt="zlatna medalja" id="imgGold" class="imgMedalja" runat="server" style="visibility: hidden"/>
                <p id="pMojiBodovi">Moji bodovi:</p>
                <p id="pBodoviZaBroncu">0-50</p>
                <p id="pBodoviZaSrebro">51-100</p>
                <p id="pBodoviZaZlato">101-150</p>
                <p id="pBodoviZaDiamond">150+</p>
                <%--<asp:Label runat="server" Text="" ID="lblBrojBodova"></asp:Label>--%>
            </div>
        </div>
    </form>
    <footer id="footerProfil">
        <p id="copyright">Copyright © Mia Blažeković</p>
    </footer>
</body>
</html>
