Public Class Form2
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim int1 As Decimal = Val(txtNum1.Text)
        Dim int2 As Decimal = Val(txtNum2.Text)
        Dim int3 As Decimal = Val(txtNum3.Text)
        Dim int4 As Decimal = Val(txtNum4.Text)
        Dim int5 As Decimal = Val(txtNum5.Text)

        txtDisplay.Text = int1 + int2 + int3 + int4 + int5

        lblOp1.Text = "+"
        lblOp2.Text = "+"
        lblOp3.Text = "+"
        lblOp4.Text = "+"

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click

        Dim int1 As Decimal = Val(txtNum1.Text)
        Dim int2 As Decimal = Val(txtNum2.Text)
        Dim int3 As Decimal = Val(txtNum3.Text)
        Dim int4 As Decimal = Val(txtNum4.Text)
        Dim int5 As Decimal = Val(txtNum5.Text)

        txtDisplay.Text = int1 - int2 - int3 - int4 - int5

        lblOp1.Text = "-"
        lblOp2.Text = "-"
        lblOp3.Text = "-"
        lblOp4.Text = "-"

        If String.IsNullOrEmpty(txtNum1.Text) Then
            MessageBox.Show("Please enter a value in TextBox1.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txtDisplay.Text = ""
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtNum3.Text = ""
            txtNum4.Text = ""
            txtNum5.Text = ""
            lblOp1.Text = ""
            lblOp2.Text = ""
            lblOp3.Text = ""
            lblOp4.Text = ""
        End If

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        Dim int1 As Decimal = If(String.IsNullOrEmpty(txtNum1.Text), 1, Val(txtNum1.Text))
        Dim int2 As Decimal = If(String.IsNullOrEmpty(txtNum2.Text), 1, Val(txtNum2.Text))
        Dim int3 As Decimal = If(String.IsNullOrEmpty(txtNum3.Text), 1, Val(txtNum3.Text))
        Dim int4 As Decimal = If(String.IsNullOrEmpty(txtNum4.Text), 1, Val(txtNum4.Text))
        Dim int5 As Decimal = If(String.IsNullOrEmpty(txtNum5.Text), 1, Val(txtNum5.Text))

        txtDisplay.Text = int1 * int2 * int3 * int4 * int5

        lblOp1.Text = "×"
        lblOp2.Text = "×"
        lblOp3.Text = "×"
        lblOp4.Text = "×"

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click

        Dim int1 As Decimal? = If(String.IsNullOrEmpty(txtNum1.Text), Nothing, Val(txtNum1.Text))
        Dim int2 As Decimal? = If(String.IsNullOrEmpty(txtNum2.Text), Nothing, Val(txtNum2.Text))
        Dim int3 As Decimal? = If(String.IsNullOrEmpty(txtNum3.Text), Nothing, Val(txtNum3.Text))
        Dim int4 As Decimal? = If(String.IsNullOrEmpty(txtNum4.Text), Nothing, Val(txtNum4.Text))
        Dim int5 As Decimal? = If(String.IsNullOrEmpty(txtNum5.Text), Nothing, Val(txtNum5.Text))

        Dim result As Decimal? = int1

        If int2.HasValue AndAlso int2.Value <> 0 Then result /= int2.Value
        If int3.HasValue AndAlso int3.Value <> 0 Then result /= int3.Value
        If int4.HasValue AndAlso int4.Value <> 0 Then result /= int4.Value
        If int5.HasValue AndAlso int5.Value <> 0 Then result /= int5.Value

        txtDisplay.Text = If(result.HasValue, result.Value.ToString(), String.Empty)

        lblOp1.Text = "÷"
        lblOp2.Text = "÷"
        lblOp3.Text = "÷"
        lblOp4.Text = "÷"

        If String.IsNullOrEmpty(txtNum1.Text) Then
            MessageBox.Show("Please enter a value in TextBox1.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txtDisplay.Text = ""
            txtNum1.Text = ""
            txtNum2.Text = ""
            txtNum3.Text = ""
            txtNum4.Text = ""
            txtNum5.Text = ""
            lblOp1.Text = ""
            lblOp2.Text = ""
            lblOp3.Text = ""
            lblOp4.Text = ""
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        txtDisplay.Text = ""
        txtNum1.Text = ""
        txtNum2.Text = ""
        txtNum3.Text = ""
        txtNum4.Text = ""
        txtNum5.Text = ""
        lblOp1.Text = ""
        lblOp2.Text = ""
        lblOp3.Text = ""
        lblOp4.Text = ""

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnGrades.Click

        Me.Hide()
        Form3.Show()
    End Sub


End Class