<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebCalc_Fall11.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- Notice that this looks like a hybrid of
             HTML (Braces) and Windows Controls. 
             Not HTML INPUT 
             Notice that HTML will be created to work
             in a web page, but we can still think like 
             a Windows developer...to some extent.
             Sorry...Mic disconnected...See you next class.--->
        <asp:Label ID="lblTime" runat="server" />
    </div>
    </form>
</body>
</html>
