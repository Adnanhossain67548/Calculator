<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CalculatorRadioButton.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Radio Button</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calculator</h1>
            
        </div>
        <p>
            <asp:Label ID="lblDisplay" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
            <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
            <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButton ID="rbAddition" runat="server" Text="Add" GroupName="Calculator" AutoPostBack="True" OnCheckedChanged="rbAddition_CheckedChanged" />
            <asp:RadioButton ID="rbSubtraction" runat="server" Text="Subtraction" GroupName="Calculator" AutoPostBack="True" OnCheckedChanged="rbSubtraction_CheckedChanged" />
            <asp:RadioButton ID="rbMultiplication" runat="server" Text="Multiplication" GroupName="Calculator" AutoPostBack="True" OnCheckedChanged="rbMultiplication_CheckedChanged" />
            <asp:RadioButton ID="rbDivision" runat="server" Text="Division" GroupName="Calculator" AutoPostBack="True" OnCheckedChanged="rbDivision_CheckedChanged"/>
        </p>
        <p>
            <%--<asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" Text="Calculate" OnClick="Button1_Click" />--%>
        </p>
        <hr />
        <asp:Label ID="lblResult" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
    </form>
</body>
</html>
