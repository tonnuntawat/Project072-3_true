Public Class frmLab5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotal, decDiscount, decNet, decCredit As Integer
        Dim salary, sale
        decTotal = lblTotal.Text
        If radMember.Checked And radPaid.Checked Then
            If decTotal < 5000 Then
                lblDiscount.Text = "ได้รับส่วนลด 5 เปอร์เซ็นต์"
                decDiscount = decTotal * 0.05
                decNet = decTotal - decDiscount
                decCredit = 0
            ElseIf decTotal < 10000 Then
                lblDiscount.Text = "ได้รับส่วนลด 10 เปอร์เซ็นต์"
                decDiscount = decTotal * 0.1
                decNet = decTotal - decDiscount
                decCredit = 0
            ElseIf decTotal > 10000 Then
                lblDiscount.Text = "ได้รับส่วนลด 15 เปอร์เซ็นต์"
                decDiscount = decTotal * 0.15
                decNet = decTotal - decDiscount
                decCredit = 0
            Else
                lblDiscount.Text="ไม่ได้รับส่วนลด"
                decNet = decTotal
                decCredit = 0
            End If
        ElseIf radMember.Checked And radCredit.Checked Then
            lblDiscount.Text = "ไม่ได้รับส่วนลด"
            decNet = decTotal - 0
            decCredit = decNet
        Else
            lblDiscount.Text = "ไม่ได้รับส่วนลด"
            decNet = decTotal - 0
            decCredit = 0
        End If
        lblTotal.Text = decTotal
        lblPaid.Text = decNet
        lblCredit.Text = decCredit
        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtUnit.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        End If


    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged

    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        gpbPaid.Enabled = True

    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        gpbPaid.Enabled = False
        radPaid.Checked = True
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged

    End Sub

    Private Sub lblTotal_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        Dim decTotal As Integer
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal
    End Sub
End Class