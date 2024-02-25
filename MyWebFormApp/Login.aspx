<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="MyWebFormApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h2>Login</h2>
    <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server" MaxLength="50" Width="200px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required." InitialValue="*" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" MaxLength="50" Width="200px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required." InitialValue="*" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
  </form>
</body>
</html>
