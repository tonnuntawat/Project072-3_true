Public Class frmLab10
    Dim A, B, C As Integer
    Dim decSale(4, 2) As Integer
    Dim saleName(4) As String
    Dim index, decsumsale As Integer



    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Call showDatagit()
    End Sub

    Private Sub frmLab10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 4
            cboIndex.Items.Add(i + 1)
        Next
        cboIndex.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intIndex, decSumSale As Integer
        If txtSaleName.Text.Trim = "" Or txtSaleA.Text.Trim = "" Or txtSaleB.Text.Trim = "" Or txtSaleC.Text.Trim = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่ถูกต้อง/ไม่สมบูรณ์")
            Exit Sub
        End If

        Dim n As Integer = Val(cboIndex.SelectedIndex)

        decSale(n, 0) = Val(txtSaleA.Text)
        decSale(n, 1) = Val(txtSaleB.Text)
        decSale(n, 2) = Val(txtSaleC.Text)
        saleName(n) = txtSaleName.Text
        Call showData()
        txtSaleA.Clear()
        txtSaleB.Clear()
        txtSaleC.Clear()


        If cboIndex.SelectedIndex < cboIndex.Items.Count - 1 Then
            cboIndex.SelectedIndex = cboIndex.SelectedIndex + 1
        End If
        txtSaleName.Focus()


    End Sub
    Sub showData()
        Dim i, tot As Decimal
        lstData.Items.Clear()
        A = 0
        B = 0
        C = 0
        For i = 0 To saleName.Length - 1
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))
            A += decSale(i, 0)
            B += decSale(i, 1)
            C += decSale(i, 2)
            tot = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)
            If decsumsale < tot Then
                decsumsale = tot
                index = i

            End If
        Next


        lblSumA.Text = A
        lblSumB.Text = B
        lblSumC.Text = C
        lblMaxSaleAmount.Text = decsumsale
        lblMaxSaleName.Text = saleName(index)
    End Sub
    Private Sub showDatagit()
        Dim i, total As Integer
        For i = 0 To saleName.Length - 1
            dgaData.Rows.Add()
            dgaData.Item(0, i).Value = saleName(i)
            dgaData.Item(1, i).Value = decSale(i, 0)
            dgaData.Item(2, i).Value = decSale(i, 1)
            dgaData.Item(3, i).Value = decSale(i, 2)

            total = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)
            dgaData.Item(4, i).Value = total


        Next


    End Sub

End Class