Public Class Basics
    Private Sub Basics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        txtbxName.Text = "Hello " & txtbxName.Text & "!"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxName.TextChanged

    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        MessageBox.Show("Hello " & txtbxName.Text)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            Dim firstNum As Integer = CInt(txtNum1.Text)
            Dim secondNum As Integer = CInt(txtNum2.Text)
            Dim result = firstNum + secondNum

            txtNumResult.Text = CStr(result)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter a number", "Error")

        Catch ex As Exception
            MessageBox.Show("Unknow error occured", "Error")
        End Try
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Try
            Dim firstNum As Integer = CInt(txtNum1.Text)
            Dim secondNum As Integer = CInt(txtNum2.Text)
            Dim result = firstNum - secondNum

            txtNumResult.Text = CStr(result)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter a number", "Error")

        Catch ex As Exception
            MessageBox.Show("Unknow error occured", "Error")
        End Try
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Try
            Dim firstNum As Integer = CInt(txtNum1.Text)
            Dim secondNum As Integer = CInt(txtNum2.Text)
            Dim result = firstNum * secondNum

            txtNumResult.Text = CStr(result)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter a number", "Error")

        Catch ex As Exception
            MessageBox.Show("Unknow error occured", "Error")
        End Try
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Try
            Dim firstNum As Integer = CInt(txtNum1.Text)
            Dim secondNum As Integer = CInt(txtNum2.Text)
            Dim result = firstNum / secondNum

            txtNumResult.Text = CStr(result)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter a number", "Error")

        Catch ex As Exception
            MessageBox.Show("Unknow error occured", "Error")
        End Try
    End Sub
End Class
