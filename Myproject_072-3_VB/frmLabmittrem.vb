Public Class frmLabmittrem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kilo, type, net, gb, total As Integer
        Dim tot, ty As String
        kilo = Val(txtKilo.Text)
        If txtKilo.Text.Trim = "" Or GroupBox1.Text.Trim = "" Or tyCar.Text.Trim = "" Then

            MessageBox.Show("ป้อนข้อมูลไม่ถูกต้อง/ไม่สมบูรณ์")
            Exit Sub
        End If
        If radMoto.Checked = True Then
            type = 20
            tot = "รถจักรยานยนต์"
            net = kilo * 2
            gb = type + net

        ElseIf radc.Checked = True Then
            If radCar.Text.Trim = "" Or radVan.Text.Trim = "" Or radSuv.Text.Trim = "" Or tyCar.Text.Trim = "" Or txtKilo.Text.Trim = "" Then

                MessageBox.Show("ป้อนข้อมูลไม่ถูกต้อง/ไม่สมบูรณ์")
                Exit Sub
            End If
            If radCar.Checked = True Then
                type = 50
                tot = "รถกระบะ"
                net = kilo * 4
                gb = type + net
            ElseIf radVan.Checked = True Then
                type = 50
                tot = "รถเก๋ง"
                net = kilo * 6
                gb = type + net
            ElseIf radSuv.Checked = True Then
                type = 50
                tot = "รถ Suv"
                net = kilo * 8
                gb = type + net

            End If


        End If

        If chkGB.Checked = True Then
            total = (net * 2) + 50
            ty = "50"

        Else
            total = gb + 0
            ty = "0"

        End If
        lblTry.Text = tot
        lblNet.Text = type
        lblKilo.Text = kilo
        lblTotal.Text = gb
        lblko.Text = ty
        lblTotal2.Text = total
    End Sub

    Private Sub frmLabmittrem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tyCar.Enabled = False
    End Sub

    Private Sub radc_CheckedChanged(sender As Object, e As EventArgs) Handles radc.CheckedChanged
        tyCar.Enabled = True
    End Sub

    Private Sub radMoto_CheckedChanged(sender As Object, e As EventArgs) Handles radMoto.CheckedChanged
        tyCar.Enabled = False
    End Sub

    Private Sub txtClo_Click(sender As Object, e As EventArgs) Handles txtClo.Click
        Me.Close()
    End Sub
End Class