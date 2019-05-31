<%@ Page Title="Index" Language="C#" MasterPageFile="~/Master/MathTVZ.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MathTVZApp.Ekrani.Index" %>
<asp:Content ID="ContentMain" ContentPlaceHolderID="BodyContent" runat="server">
        <div id="divPrvi">
            <h1>Što je MathTVZ?</h1>
            <p class="članak">Iz želje da se pomogne i na neki način olakša brucošima teško razdoblje privikavanja kroz koje 
                većina prolazi tijekom prvog semestra prve godine studija, nastala je web aplikaciju MathTVZ koja 
                omogućava jednostavno i kontinuirano praćenje gradiva kolegija Matematika I.
            </p>
            <img src="~/Slike/Characters.png" runat="server" alt="studenti" class="imgStudenti" />
            <p class="članak">Ovdje se nalazi biblioteka zadaka za pripremu i vježbu koji će dobro doći pri ponavljanju 
                za kolokvije i ispite ili jednostavno za učvršćivanje znanja iz željenih područja.
                Svi zadaci imaju rješenja ispisana „korak po korak“ kako bi bili što razumljiviji 
                svim studentima, bez obzira na njihovu trenutnu razinu znanja.
            </p>
        </div>
        <div id="divRegiPrijava">
            <h1 id="RegistracijaPrijava">
                Želiš nam se pridružiti?
            </h1>
            <asp:Button ID="btnRegistracija" Text="Registracija" runat="server" CssClass="btnRegistracija" PostBackUrl="../Registracija"/>
            <img src="~/Slike/brojPetCopy.png" runat="server" alt="broj 5 među oblacima" class="imgBrojPet" />
            <img src="~/Slike/brojDva.png" runat="server" alt="broj 2 među oblacima" class="imgBrojDva"/>
        </div>
</asp:Content>
