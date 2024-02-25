<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="SampleWebApp._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Sample Web Form</h1>
        <div>
            <h3>Display Input</h3>
            <asp:Label ID="Label1" runat="server" Text="Label">Input your name</asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true"></asp:TextBox>
            <asp:Label ID="NameResult" runat="server" Text=" " />
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            <br />
            <h3>Add Counter</h3>
            <asp:Button ID="AddButton" Text="Add" runat="server" />
            <br />
            <asp:Label ID="LabelCounter" Text="0" runat="server" />
            <br />
            <h3>How View State store value</h3>
            <asp:Label  Text="Input1" runat="server" />
            <asp:TextBox ID="x1" runat="server" />
            <br />
            <asp:Label Text="Input2" runat="server" />
            <asp:TextBox ID="x2" runat="server" />
            <br />
            <asp:Button ID="DeleteButton" Text="Delete" runat="server" OnClick="DeleteButton_Click"/>
            <asp:Button ID="RestoreButton" Text="Restore" runat="server" OnClick="RestoreButton_Click"/>

            <p>
                <asp:TextBox runat="server" ID="Txtusername" />
                <asp:TextBox runat="server" ID="TxtPassword"/>
            </p>
            <p>
                <asp:Button ID="submit" Text="submit" runat="server" OnClick="submit_Click"/>
                <asp:Button ID="restore" Text="restore" runat="server" OnClick="restore_Click"/>
            </p>

            <h1>Upload Gambar</h1>
            <p>
                <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            </p>
            <p>
                <asp:FileUpload ID="fileUpload1" runat="server" AllowTypes="image/*" MaxRequestLength="1048576" />
            </p>
            <p>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </p>
            <p>
                <asp:Image ID="imgUploaded" runat="server" Visible="false" />
            </p>

        </div>
        
        
        
    </form>
</body>
</html>
