<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KrediKazanimUygulamasi.aspx.cs" Inherits="KrediKazanimUygulamasi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <script type="text/javascript">
                function doPostBack(parameter) {
                    __doPostBack('btnSave', parameter)
                }
            </script>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="txtUyari" runat="server" Text="txtUyari"></asp:Label><div>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:CheckBox ID="CheckBox1" runat="server" />

                <asp:Button ID="Import" runat="server" Text="Button" OnClick="Import_Click" />
            </div>
            <asp:TextBox ID="txtBase" runat="server"></asp:TextBox>
            <asp:Button ID="btnGet" runat="server" Text="Button" OnClick="btnGet_Click" />
            <hr />
            <asp:Label ID="lblCont" runat="server" Text="Label"></asp:Label>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>

        </div>
    </form>
</body>
</html>
