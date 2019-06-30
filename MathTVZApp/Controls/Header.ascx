<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="MathTVZApp.Controls.Header" %>

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
        <a href="/Lekcije">Lekcije</a>
    </span>
</div>
<div class="zvjezdica">
    <span class="wrapperZvjezdice">
        <img src="~/Slike/zvjezdica.png" class="imgZvjezdica" runat="server" alt="zvjezdica" />
    </span>
</div>
<div class="elNavigacije">
    <span class="wrapperZvjezdice">
        <asp:Image ID="imgLogo" runat="server" AlternateText="tvz logo" ImageUrl="~/Slike/tvzLogo.png" CssClass="logo" />
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