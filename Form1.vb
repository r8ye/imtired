Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String
        Dim password As String

        username = txtUser.Text
        password = txtPass.Text

        If (txtUser.Text.Equals("Fraga") And txtPass.Text.Equals("Rachelle")) Then
            MessageBox.Show("Login Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()

        Else
            MessageBox.Show("Login Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cbShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPass.CheckedChanged

        If cbShowPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else txtPass.UseSystemPasswordChar = True
        End If

    End Sub


End Class

