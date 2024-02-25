<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SampleAutoPostBack.aspx.vb" Inherits="SampleWebApp.SampleAutoPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Masukkan Keyword : 
            <asp:TextBox ID="txtSearch" runat="server" 
                AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"/>
            <hr />
            <asp:Label ID="lblSearch" Text="" runat="server" />
        </div>
    </form>
</body>
</html>
