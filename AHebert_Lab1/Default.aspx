<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
              <p>
                  &nbsp;</p>
              <p>
                  <asp:TextBox ID="TextLCD" runat="server" Height="30px" Width="278px" OnTextChanged="TextLCD_TextChanged"></asp:TextBox>
              </p>
              <p>
                  <asp:TextBox ID="TextSpecial" runat="server" Width="89px"></asp:TextBox>
              </p>
              <p>
                  <asp:Button ID="Button1" runat="server" Height="69px" Text="1" Width="86px" OnClick="Button1_Click" />
                  <asp:Button ID="Button2" runat="server" Height="69px" Text="2" Width="86px" OnClick="Button2_Click" />
                  <asp:Button ID="Button3" runat="server" Height="69px" Text="2" Width="86px" OnClick="Button3_Click" />
                  <asp:Button ID="Div" runat="server" Height="69px" Text="/" Width="86px" OnClick="ButtonDiv_Click" />
              </p>
              <p>
                  <asp:Button ID="Button4" runat="server" Height="69px" Text="4" Width="86px" OnClick="Button4_Click" />
                  <asp:Button ID="Button5" runat="server" Height="69px" Text="5" Width="86px" OnClick="Button5_Click" />
                  <asp:Button ID="Button6" runat="server" Height="69px" Text="6" Width="86px" OnClick="Button6_Click" />
                  <asp:Button ID="Multi" runat="server" Height="69px" Text="X" Width="86px" OnClick="ButtonMulti_Click" />
              </p>
              <p>
                  <asp:Button ID="Button7" runat="server" Height="69px" Text="7" Width="86px" OnClick="Button7_Click" />
                  <asp:Button ID="Button8" runat="server" Height="69px" Text="8" Width="86px" OnClick="Button8_Click" />
                  <asp:Button ID="Button9" runat="server" Height="69px" Text="9" Width="86px" OnClick="Button9_Click" />
                  <asp:Button ID="Sub" runat="server" Height="69px" Text="-" Width="86px" OnClick="ButtonSub_Click" />
              </p>
    <p>
        
                  <asp:Button ID="Clear" runat="server" Height="69px" Text="Clear" Width="86px" OnClick="ButtonClear_Click" />
                  <asp:Button ID="Button0" runat="server" Height="69px" Text="0" Width="86px" OnClick="Button0_Click" />
                  <asp:Button ID="Decimal" runat="server" Height="69px" Text="." Width="86px" OnClick="ButtonDecimal_Click" Font-Bold="False" Font-Size="Larger" />
                  <asp:Button ID="Add" runat="server" Height="69px" Text="+" Width="86px" OnClick="ButtonAdd_Click" />
                  </p>
              <p>
                  <asp:Button ID="MS" runat="server" Height="69px" Text="MS" Width="86px" OnClick="ButtonMS_Click" />
                  <asp:Button ID="MR" runat="server" Height="69px" Text="MR" Width="86px" OnClick="ButtonMR_Click" />
                  <asp:Button ID="MC" runat="server" Height="69px" Text="MC" Width="86px" OnClick="ButtonMC_Click" />
                  <asp:Button ID="Equals" runat="server" Height="69px" Text="=" Width="86px" OnClick="ButtonEquals_Click" />
              </p>
          </div>
            </form>

        </body>
</html>
