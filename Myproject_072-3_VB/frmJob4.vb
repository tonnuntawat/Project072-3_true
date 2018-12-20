Public Class frmJob4
    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Date.Now.ToString("dd/MM/yy")
    End Sub

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.GeneralDate)
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As Object, e As EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double
        Dim salary, yearsale As Integer
        Dim decR_BONUS = 0.2, decR_ALLOW = 0.01, decR_TAX = 0.07
        salary = FormatNumber(txtSalary.Text)
        yearsale = FormatNumber(txtSale.Text)
        dblYearSalary = salary * 12
        dblBonus = yearsale * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX
        lblYearSalary.Text = dblYearSalary
        lblBonus.Text = dblBonus
        lblAllIncome.Text = dblAllIncome
        lblAllowance.Text = dblAllowance
        lblTax.Text = dblTax

    End Sub
End Class