<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="FOODAPPUI.AddUser" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add User</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add User</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="lblUserName" runat="server" Text="User Name:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="lblRole" runat="server" Text="Role:"></asp:Label>
            <asp:DropDownList ID="ddlRole" runat="server">
                <asp:ListItem Text="Admin" Value="admin"></asp:ListItem>
                <asp:ListItem Text="User" Value="user"></asp:ListItem>
                <asp:ListItem Text="Owner" Value="owner"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblLocation" runat="server" Text="Location:"></asp:Label>
            <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAddUser" runat="server" Text="Add User" OnClick="btnAddUser_Click" />
        </div>
    </form>
</body>
</html>
