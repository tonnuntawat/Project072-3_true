Public Class frmLab7
    Dim i As Integer
    Private Sub frmLab7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(sender As Object, e As EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text <> "" Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        lstAdd.SelectedIndex = 0
        lstAdd.SelectedIndex = lstAdd.Items.Count - 1
        txtAdd.Clear()
    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click

        Dim n1 As Integer = lstAdd.SelectedIndex
        Dim n2 As Integer
        If lstAdd.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลอยู่ใน Listbox")
        Else
            cboOutput.Items.Add(lstAdd.SelectedItem)
            n2 = cboOutput.Items.Count
            cboOutput.SelectedIndex = n2 - 1
            lstAdd.Items.RemoveAt(n1)
            If lstAdd.Items.Count <= n1 Then
                lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            Else
                lstAdd.SelectedIndex = n1
            End If
        End If

    End Sub

    Private Sub btnMoveAll_Click(sender As Object, e As EventArgs) Handles btnMoveAll.Click
        If lstAdd.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลอยู่ใน Listbox")

        Else
            For i As Integer = 0 To lstAdd.Items.Count - 1
                cboOutput.Items.Add(lstAdd.Items(i))
            Next
            lstAdd.Items.Clear()
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If cboOutput.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลอยู่ใน Combobox")
        Else
            lstAdd.Items.Add(cboOutput.SelectedItem)
            cboOutput.Items.RemoveAt(cboOutput.SelectedIndex)
            lstAdd.SelectedIndex = lstAdd.Items.Count - 1
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
        End If
    End Sub

    Private Sub btnBackAll_Click(sender As Object, e As EventArgs) Handles btnBackAll.Click
        If cboOutput.Items.Count = 0 Then
            MsgBox("ไม่มีข้อมูลอยู่ใน Combobox")
        Else
            For i As Integer = 0 To cboOutput.Items.Count - 1
                lstAdd.Items.Add(cboOutput.Items(i))
            Next
            cboOutput.Items.Clear()
            lstAdd.SelectedIndex = (lstAdd.Items.Count - 1)
        End If
    End Sub
    Private Sub cboOutput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        txtAdd.Clear()
        lblOutput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class