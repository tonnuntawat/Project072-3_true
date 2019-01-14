Public Class frmLab8
    Dim sumscore As Integer
    Dim sumcredit As Integer
    Private Sub txtSubject_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubject.KeyPress

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim commission As Decimal
        Dim grade As String
        If txtSubject.Text.Trim() = "" Or txtScore.Text.Trim() = "" Or txtCredit.Text.Trim() = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "Error...", MessageBoxButtons.OK)



        Else
            grade = Gpa(txtScore.Text)

            lstSubject.Items.Add(txtSubject.Text)
            lstScore.Items.Add(txtScore.Text)
            lstCredit.Items.Add(txtCredit.Text)
            Call Grad()

            lstSubject.SelectedIndex = lstSubject.Items.Count - 1
            lstScore.SelectedIndex = lstScore.Items.Count - 1
            lstCredit.SelectedIndex = lstCredit.Items.Count - 1
            lstGrade.SelectedIndex = lstGrade.Items.Count - 1

            txtCredit.Text = ""
            txtScore.Text = ""
            txtSubject.Text = ""



        End If

    End Sub

    Private Sub Grad()

        Dim grade As String
        Dim douGr1, douGR2, douGR3, douGRtotal, sumGrade, i, douA, douB, douC As Double
        i = lstCredit.Items.Count - 1
        For intGR = 0 To i - 1
            sumscore = lstScore.Items(intGR)

            sumCredit = lstCredit.Items(intGR)
            grade = lstGrade.Items(intGR)
            Select Case grade
                Case "A"
                    sumGrade = 4
                Case "B+"
                    sumGrade = 3.5
                Case "B"
                    sumGrade = 3
                Case "C+"
                    sumGrade = 2.5
                Case "C"
                    sumGrade = 2
                Case "D+"
                    sumGrade = 1.5
                Case "D"
                    sumGrade = 1
                Case "F"
                    sumGrade = 0
            End Select
            douA = sumCredit * sumGrade
            douB = douA + douB
            douC = sumCredit + douC

        Next
        douGR2 = lblOldTotalScore.Text + douB
        douGR3 = lblOldTotalCredit.Text + douC
        douGRtotal = douGR2 / douGR3
    End Sub

    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 46 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If

    End Sub

    Private Sub txtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        Dim keyInt As Integer = Asc(e.KeyChar)
        If (keyInt >= 48 And keyInt <= 57) Or keyInt = 46 Or keyInt = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If

    End Sub

    Private Sub lstSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubject.SelectedIndexChanged
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
        lstScore.SelectedIndex = lstSubject.SelectedIndex

    End Sub

    Private Sub lstScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstScore.SelectedIndexChanged
        lstSubject.SelectedIndex = lstScore.SelectedIndex
        lstGrade.SelectedIndex = lstScore.SelectedIndex
        lstCredit.SelectedIndex = lstScore.SelectedIndex
    End Sub

    Private Sub lstCredit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCredit.SelectedIndexChanged
        lstSubject.SelectedIndex = lstCredit.SelectedIndex
        lstScore.SelectedIndex = lstCredit.SelectedIndex
        lstGrade.SelectedIndex = lstCredit.SelectedIndex
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGrade.SelectedIndexChanged
        lstSubject.SelectedIndex = lstGrade.SelectedIndex
        lstScore.SelectedIndex = lstGrade.SelectedIndex
        lstCredit.SelectedIndex = lstGrade.SelectedIndex
    End Sub

    Private Sub frmLab8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Score As Decimal = 150
        Dim Credit As Decimal = 50
        Dim GPA As Decimal
        lblOldTotalScore.Text = Score
        lblOldTotalCredit.Text = Credit
        GPA = Score / Credit
        lblOldGPA.Text = FormatNumber(GPA)

        lstCredit.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()

        txtSubject.Clear()
        txtScore.Clear()
        txtCredit.Clear()
        lblNewGPA.Text = ""

    End Sub
    Private Function Gpa(ByVal score As Decimal) As String
        Dim Grade As String
        If txtScore.Text >= 80 Then
            Grade = "A"
        ElseIf txtScore.Text >= 75 And txtScore.Text <= 79 Then
            Grade = "B+"
        ElseIf txtScore.Text >= 70 And txtScore.Text <= 74 Then
            Grade = "B"
        ElseIf txtScore.Text >= 65 And txtScore.Text <= 69 Then
            Grade = "C+"
        ElseIf txtScore.Text >= 60 And txtScore.Text <= 64 Then
            Grade = "C"
        ElseIf txtScore.Text >= 55 And txtScore.Text <= 59 Then
            Grade = "D+"
        ElseIf txtScore.Text >= 55 And txtScore.Text <= 59 Then
            Grade = "D"
        Else
            Grade = "F"


        End If
        Return Grade
    End Function
End Class