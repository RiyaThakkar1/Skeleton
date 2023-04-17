<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="OrderID" width="95px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Find" />
        </div>
&nbsp;<br />
        <asp:Label ID="lblOrderName" runat="server" Text="OrderName" width="95px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblOrderPrice" runat="server" Text="OrderPrice" width="95px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblOrderDate" runat="server" Text="OrderDate" width="95px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="height: 29px" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
