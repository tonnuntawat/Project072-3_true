Public Class frmLab3
    Private Sub cboSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim fSize As Integer
        Integer.TryParse(cboSelect.Text, fSize)
        txtDigis.Font = New Font(txtDigis.Font.Name, fSize, FontStyle.Regular)
    End Sub

    Private Sub lblFRed_Click(sender As Object, e As EventArgs) Handles lblFRed.Click
        txtDigis.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(sender As Object, e As EventArgs) Handles lblFBlue.Click
        txtDigis.ForeColor = Color.Blue
    End Sub

    Private Sub lblFViolet_Click(sender As Object, e As EventArgs) Handles lblFViolet.Click
        txtDigis.ForeColor = Color.Green
    End Sub

    Private Sub lblFBlack_Click(sender As Object, e As EventArgs) Handles lblFBlack.Click
        txtDigis.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(sender As Object, e As EventArgs) Handles lblFOrange.Click
        txtDigis.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(sender As Object, e As EventArgs) Handles lblFYellow.Click
        txtDigis.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(sender As Object, e As EventArgs) Handles lblFBrown.Click
        txtDigis.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub lblFWhite_Click(sender As Object, e As EventArgs) Handles lblFWhite.Click
        txtDigis.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(sender As Object, e As EventArgs) Handles lblFSky.Click
        txtDigis.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRed_Click(sender As Object, e As EventArgs) Handles lblBRed.Click
        txtDigis.BackColor = Color.Red
    End Sub

    Private Sub lblBBlue_Click(sender As Object, e As EventArgs) Handles lblBBlue.Click
        txtDigis.BackColor = Color.Blue
    End Sub

    Private Sub lblBGreen_Click(sender As Object, e As EventArgs) Handles lblBGreen.Click
        txtDigis.BackColor = Color.Green
    End Sub

    Private Sub lblBViolet_Click(sender As Object, e As EventArgs) Handles lblBViolet.Click
        txtDigis.BackColor = Color.Violet
    End Sub

    Private Sub lblFVio_Click(sender As Object, e As EventArgs) Handles lblFVio.Click
        txtDigis.ForeColor = Color.Violet
    End Sub

    Private Sub lblBBlack_Click(sender As Object, e As EventArgs) Handles lblBBlack.Click
        txtDigis.BackColor = Color.Black
    End Sub

    Private Sub lblBOrange_Click(sender As Object, e As EventArgs) Handles lblBOrange.Click
        txtDigis.BackColor = Color.Orange
    End Sub

    Private Sub lblBYellow_Click(sender As Object, e As EventArgs) Handles lblBYellow.Click
        txtDigis.BackColor = Color.Yellow
    End Sub

    Private Sub lblBBrown_Click(sender As Object, e As EventArgs) Handles lblBBrown.Click
        txtDigis.BackColor = Color.SaddleBrown

    End Sub

    Private Sub lblBWhite_Click(sender As Object, e As EventArgs) Handles lblBWhite.Click
        txtDigis.BackColor = Color.White
    End Sub

    Private Sub lblBSky_Click(sender As Object, e As EventArgs) Handles lblBSky.Click
        txtDigis.BackColor = Color.SkyBlue
    End Sub

    Private Sub bthHigh_Click(sender As Object, e As EventArgs) Handles bthHigh.Click

        txtDigis.Text = Val(txtDigis.Text) + 2
    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click


        txtDigis.Text = Val(txtDigis.Text) - 2
    End Sub

    Private Sub txtDigis_TextChanged(sender As Object, e As EventArgs) Handles txtDigis.TextChanged

    End Sub
End Class