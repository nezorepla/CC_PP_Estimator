<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KrediKazanimUygulamasi.aspx.cs" Inherits="KrediKazanimUygulamasi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:CheckBox ID="CheckBox1" runat="server" />
    </div>
    <asp:Button ID="Import" runat="server" Text="Button"  OnClick="Import_Click"/>
     <hr />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div></form>
</body>
</html>
