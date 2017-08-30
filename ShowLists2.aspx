<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowLists2.aspx.cs" Inherits="SurveyProject.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>Astronaut Questions</td>
                <td>Scientist Questions</td>
                <td>Staff Questions</td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="lbxAstronautQuestions" runat="server" Height="443px" Width="460px"></asp:ListBox>
                </td>
                <td>
                    <asp:ListBox ID="lbxScientistQuestions" runat="server" Height="448px" Width="464px"></asp:ListBox>
                </td>
                <td>
                    <asp:ListBox ID="lbxStaffQuestions" runat="server" Height="442px" Width="430px"></asp:ListBox>
                </td>
            </tr>
        </table>
        <div>
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
        </div>
    </form>
</body>
</html>
