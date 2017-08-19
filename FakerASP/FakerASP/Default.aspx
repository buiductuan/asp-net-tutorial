<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FakerASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button runat="server" ID="btnFakeWord" Text="Fake Word" OnClick="btnFakeWord_Click"/>
        <asp:Button runat="server" ID="btnFakeNumber" Text="Fake Number" OnClick="btnFakeNumber_Click"/>
        <asp:Button runat="server" ID="btnFakePhone" Text="Fake Phone number" OnClick="btnFakePhone_Click"/>
        <asp:Button runat="server" ID="btnFakeAddress" Text="Fake Address" OnClick="btnFakeAddress_Click"/>
        <asp:Button runat="server" ID="btnFakeConfig" Text="Fake Config" OnClick="btnFakeConfig_Click"/>
    </form>
</body>
</html>
