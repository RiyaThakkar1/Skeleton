<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeliveryDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <asp:Label ID="lblcustomer_id" runat="server" style="z-index: 1; left: 13px; top: 48px; position: absolute; width: 124px; height: 33px" Text="customer_id"></asp:Label>
        <asp:TextBox ID="Txtcustomer_id" runat="server" style="z-index: 1; top: 38px; position: absolute; height: 30px; width: 300px; left: 193px; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblorder_id" runat="server" style="z-index: 1; left: 16px; top: 101px; position: absolute; height: 23px; width: 85px" Text="order_id"></asp:Label>
        <asp:TextBox ID="Txtorder_id" runat="server" style="z-index: 1; left: 194px; top: 88px; position: absolute; width: 300px; height: 30px"></asp:TextBox>
        <asp:Label ID="lbldelivery_id" runat="server" style="z-index: 1; left: 16px; top: 147px; position: absolute; height: 26px; width: 79px" Text="delivery_id"></asp:Label>
        <asp:TextBox ID="Txtdelivery_id" runat="server" style="z-index: 1; left: 192px; top: 136px; position: absolute; width: 300px; height: 30px"></asp:TextBox>
        <asp:Label ID="lbldelivery_description" runat="server" style="z-index: 1; left: 14px; top: 200px; position: absolute" Text="delivery_description"></asp:Label>
        <asp:Label ID="lblorder_availability" runat="server" style="z-index: 1; left: 12px; top: 253px; position: absolute" Text="order_availability"></asp:Label>
        <asp:Label ID="lblorder_confirmation" runat="server" style="z-index: 1; left: 15px; top: 304px; position: absolute" Text="order_confirmation"></asp:Label>
        <asp:Label ID="lblorder_date" runat="server" style="z-index: 1; left: 16px; top: 353px; position: absolute" Text="order_date"></asp:Label>
        <asp:TextBox ID="Txtdelivery_description" runat="server" style="z-index: 1; left: 191px; top: 191px; position: absolute; width: 300px; height: 30px"></asp:TextBox>
        <asp:Button ID="btnfind" runat="server" style="z-index: 1; left: 600px; top: 35px; position: absolute; width: 60px; height: 30px" Text="Find" />
        <p>
            <asp:TextBox ID="Txtorder_availability" runat="server" style="z-index: 1; left: 193px; top: 242px; position: absolute; height: 30px; width: 300px"></asp:TextBox>
        </p>
        <asp:TextBox ID="Txtorder_date" runat="server" style="z-index: 1; left: 196px; top: 343px; position: absolute; width: 300px; height: 30px"></asp:TextBox>
        <asp:Button ID="btnOk" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 16px; top: 470px; position: absolute; width: 60px; height: 30px; right: 1434px;" Text="Ok" />
        <asp:Button ID="btncancel" runat="server" style="z-index: 1; left: 131px; top: 470px; position: absolute; height: 31px; width: 60px" Text="Cancel" OnClick="btncancel_Click" />

        <asp:TextBox ID="Txtorder_confirmation" runat="server" style="z-index: 1; left: 196px; top: 298px; position: absolute; height: 30px; width: 300px"></asp:TextBox>
    <asp:CheckBox ID="ChkActive" runat="server" style="z-index: 1; left: 18px; top: 391px; position: absolute; height: 30px; width: 60px" Text="Active" />
          <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 427px; position: absolute; height: 30px; width: 60px"></asp:Label>
    </form>
        
</body>
</html>
