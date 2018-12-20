Public Class frmLab2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vis, fri As Integer
        Dim toVis, ToFri, MisVis, MisFri, Total, Mis As Double
        vis = Val(txtVis.Text)
        fri = Val(txtFri.Text)
        MisVis = vis * 5 / 100
        MisFri = fri * 10 / 100
        Total = vis + fri
        Mis = MisVis + MisFri
        lblVis.Text = vis
        lblFri.Text = fri
        lblVisMis.Text = MisVis
        lblFriMis.Text = MisFri
        lblTotal.Text = Total
        lblMis.Text = Mis

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class