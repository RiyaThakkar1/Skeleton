<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderDescription" runat="server" height="22px" style="z-index: 1; left: 4px; top: 370px; position: absolute; width: 176px; margin-top: 5px" Text="Order Description"></asp:Label>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" height="22px" style="z-index: 1; left: 11px; top: 17px; position: absolute" Text="Customer ID" width="176px"></asp:Label>
        <asp:Label ID="lblCustomerFirstName" runat="server" height="22px" style="z-index: 1; left: 8px; top: 64px; position: absolute" Text="First Name" width="176px"></asp:Label>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" height="22px" style="z-index: 1; left: 192px; top: 62px; position: absolute" width="176px"></asp:TextBox>
        <asp:Label ID="lblCustomerLastName" runat="server" height="22px" style="z-index: 1; left: 9px; top: 104px; position: absolute" Text="Last Name" width="176px"></asp:Label>
        <asp:TextBox ID="txtCustomerLastName" runat="server" height="22px" style="z-index: 1; left: 193px; top: 104px; position: absolute" width="176px"></asp:TextBox>
        <asp:Label ID="lblCustomerDateOfBirth" runat="server" height="22px" style="z-index: 1; left: 7px; top: 152px; position: absolute" Text="Date of Birth" width="176px"></asp:Label>
        <asp:TextBox ID="txtCustomerDateOfBirth" runat="server" height="22px" style="z-index: 1; left: 195px; top: 149px; position: absolute" width="176px"></asp:TextBox>
        <asp:Label ID="lblCustomerEmailID" runat="server" height="22px" style="z-index: 1; left: 4px; top: 199px; position: absolute" Text="Email ID" width="176px"></asp:Label>
        <asp:Label ID="lblCustomerContactNumber" runat="server" style="z-index: 1; left: 5px; top: 242px; position: absolute; width: 176px; height: 22px;" Text="Contact Number"></asp:Label>
        <asp:TextBox ID="txtCustomerContactNumber" runat="server" height="22px" style="z-index: 1; left: 194px; top: 239px; position: absolute" width="176px"></asp:TextBox>
        <asp:Label ID="lblOrderID" runat="server" height="22px" style="z-index: 1; left: 7px; top: 286px; position: absolute; width: 176px" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" height="22px" style="z-index: 1; left: 196px; top: 283px; position: absolute" width="176px"></asp:TextBox>
        <asp:Label ID="lblOrderQuantity" runat="server" height="22px" style="z-index: 1; left: 5px; top: 328px; position: absolute; width: 176px" Text="Order Quantity"></asp:Label>
        <asp:TextBox ID="txtOrderQuantity" runat="server" height="22px" style="z-index: 1; left: 196px; top: 328px; position: absolute" width="176px"></asp:TextBox>
        <asp:TextBox ID="txtOrderDescription" runat="server" height="22px" style="z-index: 1; left: 198px; top: 372px; position: absolute" width="176px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 462px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 68px; top: 495px; position: absolute" Text="Cancel" />
        <p>
        <asp:TextBox ID="txtCustomerID" runat="server" height="22px" style="z-index: 1; left: 193px; top: 16px; position: absolute" width="176px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 9px; top: 494px; position: absolute" Text="OK" />
        </p>
        <asp:TextBox ID="txtCustomerEmailID" runat="server" height="22px" style="z-index: 1; left: 193px; top: 196px; position: absolute" width="176px"></asp:TextBox>
        <p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 10px; top: 423px; position: absolute" Text="Active" />
        </p>
    </form>
</body>
</html>

