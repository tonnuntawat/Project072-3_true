Public Class frmLab1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        lblSalary.Text = Val(txtSalary.Text) * 12
        lblTax.Text = lblSalary.Text * 5 / 100
        lblTotal.Text = lblSalary.Text - lblTax.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class