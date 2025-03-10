<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginform.aspx.cs" Inherits="FOODAPPUI.loginform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 114px; height: 19px">
            EMail:<asp:TextBox ID="email" runat="server"></asp:TextBox>
        </div>
        <p>
            password</p>
        <asp:TextBox ID="pass" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="login" runat="server" OnClick="login_Click" Text="login" />
        </p>
        <asp:Label ID="lblstatus" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
