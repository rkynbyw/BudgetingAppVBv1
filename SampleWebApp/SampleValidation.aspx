<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SampleValidation.aspx.vb" Inherits="SampleWebApp.SampleValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample Validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtUsername">Username</label>
            <asp:TextBox ID="txtUsername" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredTextValidator" 
                ErrorMessage="Username is required" 
                ControlToValidate="txtUsername" runat="server" 
                ForeColor="red"/>   <br />
        </div>
    </form>
</body>
</html>
