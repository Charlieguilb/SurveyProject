<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SurveyProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Employee ID"></asp:Label>
        <asp:TextBox ID="txtID" runat="server" Width="325px"></asp:TextBox>
        <asp:RadioButtonList ID="rblEmployeeType" runat="server" Width="146px">
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Astronaut</asp:ListItem>
            <asp:ListItem>Scientist</asp:ListItem>
            <asp:ListItem>Staff</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
    </form>
</body>
</html>
