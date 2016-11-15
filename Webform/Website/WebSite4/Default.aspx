<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="A" Text="Sang" Checked="true"/>
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="A" Text="Chieu" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="A" Text="Toi" />
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GetValues" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Width="212px">
<br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="HTML" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="C#" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="SQL" />

        </asp:Panel>
        
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
