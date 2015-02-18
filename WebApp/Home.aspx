<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 181px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:DropDownList ID="DropDownList1" runat="server" style="display: block; margin: 0 auto;" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Selected="True">Google</asp:ListItem>
            <asp:ListItem>AppNeta</asp:ListItem>
            <asp:ListItem>Weather</asp:ListItem>
            <asp:ListItem>News</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="SubmitButton" runat="server" OnClick="Button1_Click" Text="Go to site" style="display: block; margin: 0 auto;" />
        </p>
    </form>
</body>
</html>
