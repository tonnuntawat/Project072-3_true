Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLab12
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Myproject_072_3_VB.My.MySettings.myCom").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New DataSet
    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim oldempID As String
    Dim strSql As String
    Dim userAct As String

    Private Sub frmLab12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Myconnect()
        strSql = "select empId,empName,empLName,Salary,sex,address,depName from tbDepartment,tbEmployee where tbDepartment.depId = tbEmployee.depId "
        myDA = New SqlDataAdapter(strSql, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "showtable")
        DgvEmp.DataSource = MyDS.Tables("showtable")
        myCon.Close()

        depnameShow()
    End Sub

    Private Sub Myconnect()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()

        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub depnameShow()
        Myconnect()

        strSql = "select depName From tbDepartment order by depName "
        myComm = New SqlCommand(strSql, myCon)


        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text

        myDR = myComm.ExecuteReader()
        If myDR.HasRows Then
            While myDR.Read
                'strName = myDR.Item("CategoryName")
                cmbDepart.Items.Add(myDR.Item("depName"))
            End While
            cmbDepart.SelectedIndex = 0
            myDR.Close()
            myCon.Close()
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        panEmp.Enabled = False
        panEmp.Enabled = True
        txtEmpId.Clear()
        txtEmpName.Clear()
        txtEmpLname.Clear()
        txtAddress.Clear()
        txtEmpsalary.Clear()
        radMale.Checked = True
        cmbDepart.SelectedIndex = 0
        txtEmpId.Focus()

        btnInsert.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        userAct = "insert"

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
            Dim depID As String


            If radMale.Checked Then
                gender = "Male"
            Else
                gender = "FeMale"
            End If

            Myconnect()
            strSql = "select depID from tbDepartment where depName = @cname "
            myComm = New SqlCommand(strSql, myCon)
            myComm.CommandType = CommandType.Text
            myComm.CommandTimeout = 15
            myComm.Parameters.AddWithValue("cname", cmbDepart.SelectedItem)
            myDR = myComm.ExecuteReader
            myDR.Read()
            depID = myDR.Item("depID")
            myDR.Close()

            If userAct = "insert" Then 'เพิ่ม
                'เช็ค PK
                strSql = "select empID from tbEmployee where empID = @eid "
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
                strSql = "Insert into tbEmployee(empId,empName,empLName,sex,address,salary,depId) Values(@eid,@ename,@elname,@sex,@add,@sal,@depid)  "
                myComm = New SqlCommand(strSql, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myComm.Parameters.AddWithValue("ename", txtEmpName.Text)
                myComm.Parameters.AddWithValue("elname", txtEmpLname.Text)
                myComm.Parameters.AddWithValue("sex", gender)
                myComm.Parameters.AddWithValue("add", txtAddress.Text)
                myComm.Parameters.AddWithValue("sal", txtEmpsalary.Text)
                myComm.Parameters.AddWithValue("depid", depID)
                myComm.ExecuteNonQuery()
                Call frmLab12_Load(sender, e)
                Call btnCancel_click(sender, e)


                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else 'แก้ไข 

                If txtEmpId.Text <> oldempID Then
                    strSql = "select empID from tbEmployee where empID = @eid "
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

                strSql = "Update tbEmployee set empId=@eid,empName=@ename,empLName=@elname,sex=@sex,address=@add,salary=@sal,depId=@depid where empid=@eoid"
                myComm = New SqlCommand(strSql, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                myComm.Parameters.AddWithValue("ename", txtEmpName.Text)
                myComm.Parameters.AddWithValue("elname", txtEmpLname.Text)
                myComm.Parameters.AddWithValue("sex", gender)
                myComm.Parameters.AddWithValue("add", txtAddress.Text)
                myComm.Parameters.AddWithValue("sal", txtEmpsalary.Text)
                myComm.Parameters.AddWithValue("depid", depID)
                myComm.Parameters.AddWithValue("eoid", oldempID)
                myComm.ExecuteNonQuery()
                Call frmLab12_Load(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        End If
    End Sub

    Private Sub cmbDepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepart.SelectedIndexChanged



    End Sub

    Private Sub DgvEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmp.CellContentClick

    End Sub

    Private Sub DgvEmp_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmp.CellEnter
        If DgvEmp.RowCount = 0 Or DgvEmp.SelectedRows.Count = 0 Then
            Exit Sub
        End If





        Dim r As Integer = DgvEmp.CurrentCell.RowIndex
        Dim pId As String = DgvEmp.Item(0, r).Value

        Myconnect()
        strSql = "select * From tbEmployee,tbDepartment Where tbDepartment.depId =tbEmployee.depId and  empId = @id "
        myComm = New SqlCommand(strSql, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myComm.Parameters.AddWithValue("@id", pId)
        myDR = myComm.ExecuteReader()
        myDR.Read()

        txtEmpId.Text = myDR.Item("empId")
        txtEmpName.Text = myDR.Item("empName")
        txtEmpLname.Text = myDR.Item("empLName")
        txtAddress.Text = myDR.Item("address")
        txtEmpsalary.Text = myDR.Item("salary")
        cmbDepart.Text = myDR.Item("depName")
        If myDR.Item("sex") = "Male" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
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
            strSql = "Delete From tbEmployee where empID = @eid "
            myComm = New SqlCommand(strSql, myCon)
            myComm.CommandType = CommandType.Text
            myComm.CommandTimeout = 15
            myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
            myComm.ExecuteNonQuery()
            Call frmLab12_Load(sender, e)
            MessageBox.Show("ลบข้อมูลพนักงานที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
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

    Private Sub DgvEmp_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmp.CellMouseEnter

    End Sub
End Class