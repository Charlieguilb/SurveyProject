<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnswerQ.aspx.cs" Inherits="SurveyProject.AnswerQ1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 947px;
            height: 656px;
        }
        .auto-style2 {
            width: 477px;
        }
    </style>
</head>
<body>

<form id="form2" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="2">
                <asp:Image ID="Image1" runat="server" Height="178px" ImageAlign="Middle" ImageUrl="~/Images/download.png" Width="919px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ1" runat="server" Width="469px" Wrap="False" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ2" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ2" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ3" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ4" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ4" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ5" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ5" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ6" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ6" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ7" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ7" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ8" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ8" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ9" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ9" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblQ10" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQ10" runat="server" Width="469px" Wrap="False"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="159px" />
    </form >
    </body>



    <%--<form id="form1" runat="server">--%>

    
</html>
 