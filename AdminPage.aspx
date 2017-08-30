<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="SurveyProject.WebForm2"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 424px;
        }
        .auto-style2 {
            width: 19px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="LblAddQuestion" runat="server" Text="Add Question"></asp:Label>
        <asp:TextBox ID="txtQuestion" runat="server" Width="744px"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" rowspan="5">
                    <asp:ListBox ID="lbxQuestions" runat="server" Height="415px" Width="544px"></asp:ListBox>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEmpType" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAddToList" runat="server" Text="Add to list" OnClick="btnAddToList_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnRemoveFromList" runat="server" Text="Remove from list" OnClick="btnRemoveFromList_Click" style="height: 29px" />
                    <asp:Label ID="lblIsThere" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnClearList" runat="server" Text="Clear list" OnClick="btnClearList_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnContinue" runat="server" Text="Continue" OnClick="btnContinue_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnShowLists" runat="server" OnClick="btnShowLists_Click" Text="Show Lists" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
