Public Class frmLab8
    Dim sumScore As Decimal = 0
    Dim sumCredit As Decimal = 0
    Private Sub txtSubject_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubject.KeyPress

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSubject.Text <> "" And txtCredit.Text <> "" And txtScore.Text <> "" Then
            Dim score As Decimal = Val(txtScore.Text)
            lstSubject.Items.Add(txtSubject.Text)
            lstSubject.SelectedIndex = lstSubject.Items.Count - 1
            lstScore.Items.Add(txtScore.Text)
            lstScore.SelectedIndex = lstScore.Items.Count - 1
            lstCredit.Items.Add(txtCredit.Text)
            lstCredit.SelectedIndex = lstCredit.Items.Count - 1
            lstGrade.Items.Add(getGrade(score))
            lstGrade.SelectedIndex = lstCredit.Items.Count - 1
            calData()
            txtCredit.Clear()
            txtScore.Clear()
            txtSubject.Clear()
        Else
            MessageBox.Show("กรุณาป้อนข้อมูลใหม่อีกครั้ง", "กรอกข้อมูลให้ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCredit.Clear()
            txtScore.Clear()
            txtSubject.Clear()
        End If

    End Sub

    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If keyInt >= 48 And keyInt <= 57 Or keyInt = 46 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If

    End Sub

    Private Sub txtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        Call txtScore_KeyPress(sender, e)

    End Sub

    Private Sub lstSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSubject.Click
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
    End Sub

    Private Sub lstScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstScore.Click
        lstSubject.SelectedIndex = lstScore.SelectedIndex
        lstCredit.SelectedIndex = lstScore.SelectedIndex
        lstGrade.SelectedIndex = lstScore.SelectedIndex
    End Sub

    Private Sub lstCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCredit.Click
        lstSubject.SelectedIndex = lstCredit.SelectedIndex
        lstScore.SelectedIndex = lstCredit.SelectedIndex
        lstGrade.SelectedIndex = lstCredit.SelectedIndex
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrade.SelectedIndexChanged
        lstCredit.SelectedIndex = lstGrade.SelectedIndex
        lstScore.SelectedIndex = lstGrade.SelectedIndex
        lstSubject.SelectedIndex = lstGrade.SelectedIndex
    End Sub
    Private Function getGrade(ByVal score As Decimal) As String
        If score < 50 Then
            Return "F"
        ElseIf score < 55 Then
            Return "D"
        ElseIf score < 60 Then
            Return "D+"
        ElseIf score < 65 Then
            Return "C"
        ElseIf score < 70 Then
            Return "C+"
        ElseIf score < 75 Then
            Return "B"
        ElseIf score < 80 Then
            Return "B+"
        Else
            Return "A"
        End If
    End Function
    Private Sub calData()
        Dim grade, score, n1, n2 As Decimal

        For i As Integer = 0 To lstScore.Items.Count - 1
            If lstScore.Items(i) < 50 Then
                score = 0
            ElseIf lstScore.Items(i) < 55 Then
                score = 1
            ElseIf lstScore.Items(i) < 60 Then
                score = 1.5
            ElseIf lstScore.Items(i) < 65 Then
                score = 2
            ElseIf lstScore.Items(i) < 70 Then
                score = 2.5
            ElseIf lstScore.Items(i) < 75 Then
                score = 3
            ElseIf lstScore.Items(i) < 80 Then
                score = 3.5
            Else
                score = 4
            End If
            n1 = n1 + lstCredit.Items(i)
            n2 = n2 + score * lstCredit.Items(i)
            grade = (n2 + sumScore) / (n1 + sumCredit)
            lblNewGPA.Text = grade.ToString("#.##")
        Next
        grade = sumScore / sumCredit
        lblOldGPA.Text = grade
    End Sub

    Private Sub frmLab8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sumCredit = 50
        sumScore = 150
        Call calData()
        lblOldTotalScore.Text = sumScore
        lblOldTotalCredit.Text = sumCredit
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call frmLab8_Load(sender, e)
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        lstScore.Items.Clear()
        lstSubject.Items.Clear()
        txtCredit.Clear()
        txtScore.Clear()
        txtSubject.Clear()
        lblNewGPA.Text = ""
    End Sub
End Class