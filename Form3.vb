Public Class Form3
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim name As String
        Dim program As String

        name = txtName.Text
        program = txtProgram.Text

        Dim subject1 As String
        Dim subject2 As String
        Dim subject3 As String
        Dim subject4 As String

        subject1 = txtSubj1.Text
        subject2 = txtSubj2.Text
        subject3 = txtSubj3.Text
        subject4 = txtSubj4.Text

        Dim int1 As Decimal = Val(txtG1.Text)
        Dim int2 As Decimal = Val(txtG2.Text)
        Dim int3 As Decimal = Val(txtG3.Text)
        Dim int4 As Decimal = Val(txtG4.Text)

        txtGwa.Text = ((int1 + int2 + int3 + int4) / 4)

        If txtGwa.Text >= 4.0 Then
            txtRemarks.Text = "Failed"
        Else
            txtRemarks.Text = "Passed"
        End If

        If String.IsNullOrEmpty(txtG1.Text) OrElse
           String.IsNullOrEmpty(txtG2.Text) OrElse
           String.IsNullOrEmpty(txtG3.Text) OrElse
           String.IsNullOrEmpty(txtG4.Text) Then
            MessageBox.Show("Textbox can not be empty.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txtG1.Text = ""
            txtG2.Text = ""
            txtG3.Text = ""
            txtG4.Text = ""
            txtGwa.Text = ""
            txtRemarks.Text = ""
        End If

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click

        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click

        txtName.Text = ""
        txtProgram.Text = ""
        txtSubj1.Text = ""
        txtSubj2.Text = ""
        txtSubj3.Text = ""
        txtSubj4.Text = ""
        txtG1.Text = ""
        txtG2.Text = ""
        txtG3.Text = ""
        txtG4.Text = ""
        txtGwa.Text = ""
        txtRemarks.Text = ""

    End Sub

End Class