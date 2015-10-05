<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KrediKazanimUygulamasi.aspx.cs"
    Inherits="KrediKazanimUygulamasi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Kredi Kazanim Grubu</title>
    <style type="text/css">
        .style1
        {
            width: 347px;
        }
        .style2
        {
            width: 408px;
        }
     table td {
    /*border-top-style: dotted;
    border-right-style: solid;
    border-left-style: solid;*/
     border-width:1px;
    border-bottom-style: dotted;
}     table th {
    /*border-top-style: dotted;
    border-right-style: solid;
    border-left-style: solid;*/
     border-width:1px;
    border-left-style: dotted;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <script type="text/javascript">
             
        </script>

        <asp:Label ID="txtUyari" runat="server"></asp:Label>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Data Import</asp:LinkButton>
        <span id="ImportArea" runat="server" visible="false">
            <div>
                <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Is Header" Checked="true" />
                <br />
                <asp:Button ID="Import" runat="server" Text="CSV FILE TO SERVER" OnClick="Import_Click" />
        </span>
    </div>
    <asp:TextBox ID="txtBase" runat="server"></asp:TextBox>
    <asp:Button ID="btnGet" runat="server" Text="Müşteri Getir" OnClick="btnGet_Click" />
    <hr />
    <asp:Label ID="lblCont" runat="server"></asp:Label>
    <span id="ActionArea" runat="server">
        <asp:Label ID="lblAct" runat="server"></asp:Label>
        <table>
            <tr>
                <td class="style2">
                    Portföy Sorumlusu
                </td>
                <td class="style1">
                    <asp:Label ID="lblPortfoySorumlusu" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Şube Adı
                </td>
                <td class="style1">
                    <asp:Label ID="lblSubeAdi" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Şube İli
                </td>
                <td class="style1">
                    <asp:Label ID="lblSubeIli" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Müşteri Nosu
                </td>
                <td class="style1">
                    <asp:Label ID="lblMusteriNosu" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Kredi No/Kart No - Adı Soyadı
                </td>
                <td class="style1">
                    <asp:Label ID="lblBilgi" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Telefonla İletişim Durumu
                </td>
                <td class="style1">
                    <asp:DropDownList ID="ddlTelefonDurumu" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Ulaşılan Telefon No
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    İletişim Sonucu
                </td>
                <td class="style1">
                    <asp:DropDownList ID="ddlIletisimSonucu" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Peşin Ödeme Sözü Tarihi / Taksit Başlangıç Tarihi (gg/aa/yyyy)
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtPesinOdemeTarihi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Taksitli Ödemelerde Peşinat Alındı ise Peşinat Tutarı
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtPesinatTutari" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Taksitli Ödemelerde Peşinat Alındı ise Peşinat Tarihi (gg/aa/yyyy)
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtPesinatTarihi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Taksit Sayısı
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtTaksitSayisi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Peşin Ödenecek Tutar/Taksit Tutarı
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtPesinTutar" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Sulh Sözleşmesi İmzalandı mı?
                </td>
                <td class="style1">
                    <asp:DropDownList ID="ddlSulhSozlesmesi" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Adrese Ziyaret Yapıldı Mı?
                </td>
                <td class="style1">
                    <asp:DropDownList ID="ddlAdresZiyareti" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Ziyaret Yapılan Adres
                </td>
                <td class="style1">
                    <asp:TextBox ID="txtAdres" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Ziyaret Sonucu
                </td>
                <td class="style1">
                    <asp:DropDownList ID="ddlZiyaretSonucu" runat="server">
                    </asp:DropDownList>
                </td>
                <tr><td colspan=2>
                    <asp:Button ID="btnTamamla" runat="server" Text="Aksiyonları Kaydet" 
                        Width="626px" /></td></tr>
            </tr>
        </table>
    </span></div>
    </form>
</body>
</html>
