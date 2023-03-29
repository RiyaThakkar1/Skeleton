<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 27px; top: 24px; position: absolute" Text="Product ID" height="25px" width="213px"></asp:Label>
            <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 27px; top: 67px; position: absolute; height: 25px" Text="Product Name" width="213px"></asp:Label>
             <asp:TextBox ID="txtProductName" runat="server" height="25px" style="z-index: 1; left: 280px; top: 67px; position: absolute" width="213px"></asp:TextBox>
        </div>
        <p>
            <asp:TextBox ID="txtProductID" runat="server" height="25px" style="z-index: 1; left: 280px; top: 24px; position: absolute" width="213px"></asp:TextBox>
            </p>
        <asp:Label ID="lblProductPrice" runat="server" height="25px" style="z-index: 1; left: 27px; top: 112px; position: absolute" Text="Product Price" width="213px"></asp:Label>
        <asp:TextBox ID="txtProductPrice" runat="server" height="25px" style="z-index: 1; left: 280px; top: 112px; position: absolute" width="213px"></asp:TextBox>
        <asp:Label ID="lblProductDescription" runat="server" height="25px" style="z-index: 1; left: 27px; top: 153px; position: absolute" Text="Product Description" width="213px"></asp:Label>
        <asp:TextBox ID="txtProductDecription" runat="server" height="25px" style="z-index: 1; left: 280px; top: 153px; position: absolute" width="213px"></asp:TextBox>
        <asp:TextBox ID="txtLaunchData" runat="server" height="25px" style="z-index: 1; left: 281px; top: 195px; position: absolute" width="213px" TextMode="Date"></asp:TextBox>
        <p>
            <asp:Label ID="lblLaunchData" runat="server" height="25px" style="z-index: 1; left: 27px; top: 195px; position: absolute" Text="Launch Data" width="213px"></asp:Label>
        </p>
        <asp:Label ID="lblProductAvailablity" runat="server" height="25px" style="z-index: 1; left: 26px; top: 234px; position: absolute" Text="Product Availability" width="213px"></asp:Label>
        <asp:TextBox ID="txtProductAvailability" runat="server" height="25px" style="z-index: 1; left: 279px; top: 234px; position: absolute" width="213px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 26px; top: 288px; position: absolute; height: 25px; width: 97px" Text="Active" />
        <asp:Label ID="lblError" runat="server" height="25px" style="z-index: 1; left: 26px; top: 338px; position: absolute" Text="Error" width="97px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 28px; top: 380px; position: absolute; width: 37px;" Text="OK" />
        <asp:Button ID="btnCancle" runat="server" style="z-index: 1; left: 92px; top: 380px; position: absolute" Text="Cancle" />
    </form>
</body>
</html>
