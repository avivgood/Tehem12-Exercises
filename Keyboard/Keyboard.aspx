<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Keyboard.aspx.cs" Inherits="Keyboard.Keyboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 137px;
            width: 1447px;
        }
        #input {
            width: 1487px;
            height: 142px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Text" runat="server" OnLoad="Text_Load" Text="Label"></asp:Label>
        <asp:Panel ID="Btns" runat="server" Height="691px">
        </asp:Panel>
    </form>
</body>
</html>
