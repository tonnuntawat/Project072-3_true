Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Myproject_072_3_VB.My.MySettings.myConCompany").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New DataSet
    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim oldempID As String
    Dim strSql As String
    Dim userAct As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Myconnect()
        strSql = "select proID,proName,proStock,proPrice,typeName from Type,Product where Type.typeID= Product.typeID "
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

        strSql = "select typeName From Type order by typeName  "
        myComm = New SqlCommand(strSql, myCon)


        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text

        myDR = myComm.ExecuteReader()
        If myDR.HasRows Then
            While myDR.Read
                'strName = myDR.Item("CategoryName")
                cmbDepart.Items.Add(myDR.Item("typeName"))
            End While
            cmbDepart.SelectedIndex = 0
            myDR.Close()
            myCon.Close()
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        panEmp.Enabled = False
        panEmp.Enabled = True
        txtProid.Clear()
        txtProname.Clear()
        txtProprice.Clear()
        txtProstock.Clear()


        cmbDepart.SelectedIndex = 0
        txtProid.Focus()

        btnInsert.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        userAct = "insert"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtProid.Text = txtProid.Text.Trim
        txtProname.Text = txtProname.Text.Trim
        txtProprice.Text = txtProprice.Text.Trim
        txtProstock.Text = txtProstock.Text.Trim

        If txtProid.Text = "" Or txtProname.Text = "" Or txtProprice.Text = "" Or txtProstock.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProid.Focus()
            Exit Sub

        ElseIf Not IsNumeric(txtProprice.Text) Or IsNumeric(txtProstock.Text) Then
            MessageBox.Show("ท่านป้อนข้อมูลราคาไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProprice.Focus()
            Exit Sub

        Else
            Dim gender As String
            Dim typeID As String


            Myconnect()
            strSql = "select typeID from Type where typeName = @tname "
            myComm = New SqlCommand(strSql, myCon)
            myComm.CommandType = CommandType.Text
            myComm.CommandTimeout = 15
            myComm.Parameters.AddWithValue("tname", cmbDepart.SelectedItem)
            myDR = myComm.ExecuteReader
            myDR.Read()
            typeID = myDR.Item("typenName")
            myDR.Close()

            If userAct = "insert" Then 'เพิ่ม
                'เช็ค PK
                strSql = "select proID from Product where proID = @pid "
                myComm = New SqlCommand(strSql, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("pid", txtProid.Text)
                myDR = myComm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสพนักงานที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If

                myDR.Close()
                strSql = "Insert into Product(proID,proName,proStock,proPrice,typeID) Values(@pid,@pname,@pstoc,@ppri,@tid)  "
                myComm = New SqlCommand(strSql, myCon)
                myComm.CommandType = CommandType.Text
                myComm.CommandTimeout = 15
                myComm.Parameters.AddWithValue("pid", txtProid.Text)
                myComm.Parameters.AddWithValue("pname", txtProname.Text)
                myComm.Parameters.AddWithValue("pstoc", txtProstock)
                myComm.Parameters.AddWithValue("ppri", txtProprice)
                myComm.Parameters.AddWithValue("tid", typeID)
                myComm.ExecuteNonQuery()
                Call Form1_Load(sender, e)
                Call btnCancel_click(sender, e)


                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else 'แก้ไข 

                If txtProid.Text <> oldempID Then
                    strSql = "select empID from tbEmployee where empID = @eid "
                    myComm = New SqlCommand(strSql, myCon)
                    myComm.CommandType = CommandType.Text
                    myComm.CommandTimeout = 15
                    myComm.Parameters.AddWithValue("eid", txtProid.Text)
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
                ' myComm.Parameters.AddWithValue("eid", txtEmpId.Text)
                ' myComm.Parameters.AddWithValue("ename", txtEmpName.Text)
                'myComm.Parameters.AddWithValue("elname", txtEmpLname.Text)
                'myComm.Parameters.AddWithValue("sex", gender)
                ' myComm.Parameters.AddWithValue("add", txtAddress.Text)
                'myComm.Parameters.AddWithValue("sal", txtEmpsalary.Text)
                'myComm.Parameters.AddWithValue("depid", depID)
                myComm.Parameters.AddWithValue("eoid", oldempID)
                myComm.ExecuteNonQuery()
                Call Form1_Load(sender, e)
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class