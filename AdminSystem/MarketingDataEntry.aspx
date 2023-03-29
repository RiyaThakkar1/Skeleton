<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MarketingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 377px;
            width: 1137px;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2" style="width: 81px; height: 31px">
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 16px; top: 15px; position: absolute; width: 92px;" Text="Order Id"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 218px; top: 14px; position: absolute; height: 26px; width: 205px"></asp:TextBox>
        </div>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 218px; top: 60px; position: absolute; width: 205px; height: 26px"></asp:TextBox>
        <p class="auto-style2">
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 16px; top: 65px; position: absolute" Text="Customer Id"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerName" runat="server" height="26px" style="z-index: 1; left: 218px; top: 110px; position: absolute" width="205px"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 16px; top: 113px; position: absolute" Text="Customer Name"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtOrderDate" runat="server" height="26px" style="z-index: 1; left: 218px; top: 154px; position: absolute" width="205px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerSatis" runat="server" height="26px" style="z-index: 1; left: 218px; top: 198px; position: absolute" width="205px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 14px; top: 257px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 147px; top: 259px; position: absolute" Text="Error"></asp:Label>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 16px; top: 332px; position: absolute" Text="OK" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 163px; top: 331px; position: absolute" Text="CANCEL" />
        <asp:Label ID="lblCustomerSatis" runat="server" style="z-index: 1; left: 16px; top: 203px; position: absolute" Text="Customer Satisfaction"></asp:Label>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 16px; top: 162px; position: absolute" Text="Order Date"></asp:Label>
    </form>
</body>
</html>
