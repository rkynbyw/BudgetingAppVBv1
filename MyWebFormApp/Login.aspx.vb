Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ViewState("ErrorMessage") = ""
        End If
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)
        ' Implement your login logic here, including authentication against a database or other source
        ' If login successful, redirect to a different page or display a success message
        ' If login fails, update ViewState["ErrorMessage"] with an appropriate error message
        ViewState("ErrorMessage") = "Invalid username or password."
    End Sub




End Class