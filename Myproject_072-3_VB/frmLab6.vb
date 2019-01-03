Public Class frmLab6


    Private Sub frmLab6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        lblSartPrice.Enabled = False
        lblPaidPrice.Enabled = False
    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice1.Text)
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice2.Text)
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice3.Text)
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblItemsPrice4.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblItemsPrice4.Text)
        End If
    End Sub

    Private Sub lblPaidPrice_Click(sender As Object, e As EventArgs) Handles lblPaidPrice.Click

    End Sub

    Private Sub chkFree1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree1.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree2.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree2.Text)
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - Val(lblFree3.Text)
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + Val(lblFree3.Text)
        End If
    End Sub

    Private Sub chkCarForMe_Click_1(sender As Object, e As EventArgs) Handles chkCarForMe.Click
        Dim re As DialogResult
        If chkCarForMe.Checked Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblSartPrice.Enabled = True
            lblPaidPrice.Enabled = True
            lblSartPrice.Text = 1250000
            lblPaidPrice.Text = Val(lblSartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)


        Else
            re = MessageBox.Show("คุณต้องการจะยกเลิกหรือเปล่า", "Hi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If re = Windows.Forms.DialogResult.Yes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                lblPaidPrice.Text = "0"
                lblSartPrice.Text = ""
            Else
                chkCarForMe.Checked = True
            End If
        End If
    End Sub
End Class