<%@ Page Title="Contact Manager" Language="C#" MasterPageFile="~/Masterpage.master" AutoEventWireup="true" CodeFile="ContactMGR.aspx.cs" Inherits="ContactMGR" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="Server">
    <form id="form1" runat="server">
        <div id="ContactMGR" class="app" style="clear: both;">
            <div id="ContactMGRheader">
                <asp:Label ID="Label1" runat="server" Text="Salutations"></asp:Label>
                <br />
                <br />
            </div>
            <div id="ContactMGRmain">
                <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Street 1"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Street 2"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label8" runat="server" Text="City"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label6" runat="server" Text="State"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                <br />
                <asp:Label ID="Label7" runat="server" Text="Zip"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label9" runat="server" Text="Email"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label10" runat="server" Text="Home Phone"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label11" runat="server" Text="Work Phone"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label12" runat="server" Text="Cell Phone"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label13" runat="server" Text="Birthday"></asp:Label>
                <br />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <br />
                <asp:Label ID="Label14" runat="server" Text="Anniversary"></asp:Label>
                <br />
                <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
                <br />
                <asp:Label ID="Label15" runat="server" Text="Card Worthy"></asp:Label>
                <br />
                <asp:CheckBox ID="Calendar3" runat="server"></asp:CheckBox>
                <br />
                <asp:Label ID="Label16" runat="server" Text="Relationship"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                <br />
                <asp:Label ID="Label17" runat="server" Text="Notes"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox11" runat="server" Width="50%" Height="50px"></asp:TextBox>
                <br />
                <asp:Label ID="Label18" runat="server" Text="Feedback"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox12" runat="server" Width="50%" Height="50px"></asp:TextBox>
                <br />
                <asp:Button ID="Label19" runat="server" Text="Add Contact"></asp:Button>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Clear"></asp:Button>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" runat="Server">
</asp:Content>
