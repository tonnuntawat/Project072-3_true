Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmTran12
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Myproject_072_3_VB.My.MySettings.myConCompany").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New DataSet
    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim oldempID As String
    Dim strSql As String
    Dim userAct As String
    Private Sub Myconnect()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()

        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmTran12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Myconnect()
        strSql = "select empID,empName,empAddress,empTel,empEmail,empBirth,empSex,empIDcard,empSalary from Employee "
        myDA = New SqlDataAdapter(strSql, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "showtable")
        DgvEmp.DataSource = MyDS.Tables("showtable")
        myCon.Close()


    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        panEmp.Enabled = False
        panEmp.Enabled = True
        txtEmpId.Clear()
        txtEmpName.Clear()
        txtEmpLname.Clear()
        txtAddress.Clear()
        txtEmpsalary.Clear()
        txtEmail.Clear()
        txtBirth.Clear()
        txtTel.Clear()


        txtEmpId.Focus()

        btnInsert.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        userAct = "insert"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txtEmpId.Text = txtEmpId.Text.Trim

        panEmp.Enabled = False
        panEmp.Enabled = True
        txtEmpId.Focus()
        btnInsert.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        oldempID = txtEmpId.Text
        userAct = "update"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtEmpId.Text = txtEmpId.Text.Trim
        txtEmpName.Text = txtEmpName.Text.Trim
        txtEmpLname.Text = txtEmpLname.Text.Trim
        txtAddress.Text = txtAddress.Text.Trim

        If txtEmpId.Text = "" Or txtEmpName.Text = "" Or txtEmpLname.Text = "" Or txtAddress.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmpId.Focus()
            Exit Sub

        ElseIf Not IsNumeric(txtEmpsalary.Text) Then
            MessageBox.Show("ท่านป้อนข้อมูลเงินเดือนไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmpsalary.Focus()
            Exit Sub

        Else
            Dim gender As String



            If radMale.Checked Then
                gender = "Male"
            Else
                gender = "FeMale"
            End If

            Myconnect()
            If userAct = "insert" Then 'เพิ่ม
                'เช็ค PK

                strSql = "select empID from Employee where empID = @eid "
                myComm = New SqlCommand(strSql, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myDR = myComm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสพนักงานที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If

                myDR.Close()
                strSql = "Insert into Employee(empID,empName,empAddress,empTel,empEmail,empBirth,empSex,empIDcard,empSalary) Values(@eid,@ename,@add,@etel,@eemail,@ebirth,@esex,@eidc,@sal)  "
                myComm = New SqlCommand(strSql, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myComm.Parameters.AddWithValue("ename", txtEmpName.Text)
                myComm.Parameters.AddWithValue("eidc", txtEmpLname.Text)
                myComm.Parameters.AddWithValue("esex", gender)
                myComm.Parameters.AddWithValue("add", txtAddress.Text)
                myComm.Parameters.AddWithValue("sal", txtEmpsalary.Text)
                myComm.Parameters.AddWithValue("eemail", txtEmail.Text)
                myComm.Parameters.AddWithValue("etel", txtTel.Text)
                myComm.Parameters.AddWithValue("ebirth", txtBirth.Text)
                myComm.ExecuteNonQuery()
                Call frmTran12_Load(sender, e)
                Call btnCancel_click(sender, e)


                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else 'แก้ไข 

                If txtEmpId.Text <> oldempID Then
                    strSql = "select empID from Employee where empID = @eid "
                    myComm = New SqlCommand(strSql, myCon)
                    myComm.CommandType = CommandType.Text
                    myComm.CommandTimeout = 15
                    myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                    myDR = myComm.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("รหัสพนักงานที่ท่านเปลี่ยนแปลง เป็นรหัสของพนักงานคนอื่นที่ใช้อยู่ในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        myDR.Close()
                        Exit Sub
                    End If
                    myDR.Close()
                End If

                strSql = "Update Employee set empId=@eid,empName=@ename,empIDcard=@eidc,empSex=@sex,empAddress=@add,empSalary=@sal,empEmail=@eemail,empTel=@etel,empBirth=@ebirth where empid=@eoid"
                myComm = New SqlCommand(strSql, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myComm.Parameters.AddWithValue("ename", txtEmpName.Text)
                myComm.Parameters.AddWithValue("eidc", txtEmpLname.Text)
                myComm.Parameters.AddWithValue("sex", gender)
                myComm.Parameters.AddWithValue("add", txtAddress.Text)
                myComm.Parameters.AddWithValue("sal", txtEmpsalary.Text)
                myComm.Parameters.AddWithValue("eemail", txtEmail.Text)
                myComm.Parameters.AddWithValue("etel", txtTel.Text)
                myComm.Parameters.AddWithValue("ebirth", txtBirth.Text)
                myComm.Parameters.AddWithValue("eoid", oldempID)
                myComm.ExecuteNonQuery()
                Call frmTran12_Load(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        panEmp.Enabled = True
        panEmp.Enabled = False

        btnInsert.Enabled = True
        If txtEmpId.Text = "" Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        Else
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        End If
        btnClose.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("โปรดยืนยันการลบข้อมูลพนักงาน รหัส: " & txtEmpId.Text & " ชื่อ: " & txtEmpName.Text & "  " & txtEmpLname.Text, "โปรดระวัง..", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If dgr = Windows.Forms.DialogResult.Yes Then
            Myconnect()
            strSql = "Delete From Employee where empID = @eid "
            myComm = New SqlCommand(strSql, myCon)
            myComm.CommandType = CommandType.Text
            myComm.CommandTimeout = 15
            myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
            myComm.ExecuteNonQuery()
            Call frmTran12_Load(sender, e)
            MessageBox.Show("ลบข้อมูลพนักงานที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class