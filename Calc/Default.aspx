<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:TextBox ID="txtLCD" runat="server" BorderStyle="Solid" style="text-align: right" Height="50px" Width="600px" OnTextChanged="txtLCD_TextChanged"></asp:TextBox>
        <br />
        <asp:Button class="button" ID="btn1" runat="server" Text="1" CommandArgument ="1" OnCommand="btnNum_Click"  Height="100px" Width="150px" />
        <asp:Button class="button" ID="btn2" runat="server" Text="2" CommandArgument ="2" OnCommand="btnNum_Click"  Height="100px" Width="150px" />
        <asp:Button class="button" ID="btn3" runat="server" Text="3" CommandArgument ="3" OnCommand="btnNum_Click"  Height="100px" Width="150px" style="margin-right: 0px"/>
        <asp:Button class="button" ID="btnDivide" runat="server" Text="/" OnClick="btnDivide_Click" Height="100px" Width="150px"/>

        <br />

        <asp:Button class="button" ID="btn4" runat="server" Text="4" CommandArgument ="4" OnCommand="btnNum_Click" Height="100px" Width="150px" />
        <asp:Button class="button" ID="btn5" runat="server" Text="5" CommandArgument ="5" OnCommand="btnNum_Click" Height="100px" Width="150px" />
        <asp:Button class="button" ID="btn6" runat="server" Text="6" CommandArgument ="6" OnCommand="btnNum_Click" Height="100px" Width="150px"/>
        <asp:Button class="button" ID="btnMulti" runat="server" Text="X" OnClick="btnMulti_Click" Height="100px" Width="150px"/>

        <br />

        <asp:Button class="button" ID="btn7" runat="server" Text="7" CommandArgument ="7" OnCommand="btnNum_Click" Height="100px" Width="150px" />
        <asp:Button class="button" ID="btn8" runat="server" Text="8" CommandArgument ="8" OnCommand="btnNum_Click" Height="100px" Width="150px" />
        <asp:Button class="button" ID="btn9" runat="server" Text="9" CommandArgument ="9" OnCommand="btnNum_Click" Height="100px" Width="150px"/>
        <asp:Button class="button" ID="btnSub" runat="server" Text="-" OnClick="btnSub_Click" Height="100px" Width="150px"/>

        <br />
        <asp:Button class="button" ID="Button0" runat="server" Text="0" CommandArgument ="0" OnCommand="btnNum_Click" Height="100px" Width="150px"/>
        <asp:Button class="button" ID="btnPlus" runat="server" Text="+" OnClick="btnPlus_Click" Height="100px" Width="300px" />

        <br />

        <asp:Button class="button" ID="btnEquals" runat="server" Text="=" OnClick="btnEquals_Click" Height="100px" Width="300px" />
    
    </div>
    </form>
</body>
</html>
