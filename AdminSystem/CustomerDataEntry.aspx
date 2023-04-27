<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 32px; top: 112px; position: absolute" Text="CustomerNo"></asp:Label>
        <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 32px; top: 200px; position: absolute" Text="Login"></asp:Label>
        <asp:Label ID="lblCreateAppoinment" runat="server" style="z-index: 1; left: 32px; top: 156px; position: absolute" Text="CreateAppoinment"></asp:Label>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 32px; top: 71px; position: absolute" Text="CustomerId"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 32px; top: 239px; position: absolute" Text="DOB"></asp:Label>
        <asp:Label ID="lblPayment" runat="server" style="z-index: 1; left: 32px; top: 287px; position: absolute; height: 19px" Text="Payment"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 22px; top: 330px; position: absolute" Text="Active" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 12px; top: 397px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 95px; top: 398px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 430px; top: 74px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtCreateAppointment" runat="server" style="z-index: 1; left: 161px; top: 152px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 111px; top: 237px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLogin" runat="server" style="z-index: 1; left: 102px; top: 197px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 129px; top: 113px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPayment" runat="server" style="z-index: 1; left: 128px; top: 288px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 134px; top: 69px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
