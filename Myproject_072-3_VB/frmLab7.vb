Public Class frmLab7
    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        btnAdd.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        btnAdd.Enabled = True
        txtAdd.Text = ""
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click

        'If lstAdd.Items.Count = 0 Then
        'MessageBox.Show("กรุณาใส่ข้อมูล")
        'Else
        'Dim de As Integer
        'de = cboOutput.SelectedIndex


        'End If
        cboOutput.Items.Add(lstAdd.SelectedItem)
        cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        lstAdd.Items.Remove(lstAdd.SelectedItem)



    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        cboOutput.Items.Add(lstAdd.SelectedItem)
        lstAdd.Items.Remove(lstAdd.SelectedItem)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        lstAdd.Items.Add(cboOutput.SelectedItem)
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1
        cboOutput.Items.Remove(cboOutput.SelectedItem)
    End Sub
End Class