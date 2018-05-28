<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtLCD" runat="server" Width="161px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblNum1" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblNum2" runat="server"></asp:Label>
&nbsp;
        <asp:Label ID="lblOperator" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btn1" runat="server" onclick="btn1_Click" Text="1" 
            Width="20px" />
&nbsp;
        <asp:Button ID="btn2" runat="server" onclick="btn2_Click1" Text="2" 
            Width="20px" />
&nbsp;
        <asp:Button ID="btn3" runat="server" onclick="btn3_Click1" Text="3" 
            Width="20px" />
&nbsp;&nbsp;
        <asp:Button ID="btnPlus" runat="server" onclick="btnPlus_Click" Text="+" 
            Width="20px" />
&nbsp;&nbsp;
        <asp:Button ID="btnEquals" runat="server" onclick="btnEquals_Click" Text="=" 
            Width="20px" />
    
    </div>
    </form>
</body>
</html>
