<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Returns the number of media with this hashtag name</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label" runat="server" Text="Label"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="#"></asp:Label>
        <asp:TextBox ID="HashTagSearchInput" runat="server"></asp:TextBox>
        <asp:Button ID="Button" runat="server" OnClick="Button1_Click" Text="Go!" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
