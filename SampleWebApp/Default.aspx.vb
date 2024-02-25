Imports System.IO

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        NameResult.Text = "Haloo" & TextBox1.Text
        TextBox1.Text = ""
    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ViewState("x1") = x1.Text
        ViewState("x2") = x2.Text

        x1.Text = ""
        x2.Text = ""
    End Sub

    Protected Sub RestoreButton_Click(sender As Object, e As EventArgs) Handles RestoreButton.Click
        x1.Text = ViewState("x1")
        x2.Text = ViewState("x2")
    End Sub

    Protected Sub submit_Click(sender As Object, e As EventArgs)
        ViewState("tb1") = Txtusername.Text
        ViewState("tb2") = TxtPassword.Text
        Txtusername.Text = ""
        TxtPassword.Text = ""
    End Sub

    Protected Sub restore_Click(sender As Object, e As EventArgs)
        Txtusername.Text = ViewState("tb1")
        TxtPassword.Text = ViewState("tb2")
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If fileUpload1.HasFile Then
            If IsValidImage(fileUpload1.PostedFile) Then
                Dim fileName As String = Path.GetFileName(fileUpload1.PostedFile.FileName)
                Dim filePath As String = Server.MapPath("~/images/" & fileName)
                fileUpload1.PostedFile.SaveAs(filePath)

                imgUploaded.Visible = True
                imgUploaded.ImageUrl = "~/images/" & fileName
                imgUploaded.Height = 100
                imgUploaded.Width = 100
            Else
                lblError.Text = "File yang diunggah bukan gambar yang valid."
            End If
        Else
            lblError.Text = "Silakan pilih file gambar untuk diunggah."
        End If
    End Sub

    Private Function IsValidImage(file As HttpPostedFile) As Boolean
        Dim validImageTypes As String() = {"image/jpeg", "image/png", "image/gif"}
        Return validImageTypes.Contains(file.ContentType)
    End Function



End Class