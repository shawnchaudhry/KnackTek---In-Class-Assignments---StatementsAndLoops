<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatementsAndLoops.aspx.cs" Inherits="StatementsAndLoops.StatementsAndLoops" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        States:</div>
        <asp:DropDownList ID="ddlStates" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Georgia</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Please Enter a State:<br />
        <asp:TextBox ID="tbStateName" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnAddAState" runat="server" Text="Add State" OnClick="addAState" />
        </p>
    </form>
</body>
</html>
