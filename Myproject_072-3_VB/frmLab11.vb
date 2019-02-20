Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLab11
    Dim strCon As String = ConfigurationManager.ConnectionStrings("Myproject_072_3_VB.My.MySettings.strCon").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim MyDS As New DataSet
    Dim strSql As String

    Private Sub btnChoice1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice1.Click
        Myconnect()
        strSQL = "select *from Products where productname LIKE 'n%'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro1")
        dgvData.DataSource = MyDS.Tables("mypro1")
        myCon.Close()


    End Sub
    Private Sub Myconnect()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()

        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub btnChoice2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice2.Click
        Myconnect()
        strSQL = "select (UnitPrice * UnitsInStock) as Total from Products where productid LIKE '%64%'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro2")
        dgvData.DataSource = MyDS.Tables("mypro2")
        myCon.Close()
    End Sub

    Private Sub btnChoice3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice3.Click
        Myconnect()
        strSQL = "select count(*)as BRAZIL  from customers where country LIKE '%brazil%'"

        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro3")
        dgvData.DataSource = MyDS.Tables("mypro3")
        myCon.Close()

    End Sub

    Private Sub btnChoice4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice4.Click
        Myconnect()
        strSQL = "select productname,quantity,contactname from customers,orders,orderdetails,products where customers.customerid = orders.customerid and orders.orderid = orderdetails.orderid and orderdetails.productid=products.productid and customers.contactname LIKE 'yang wang'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro4")
        dgvData.DataSource = MyDS.Tables("mypro4")
        myCon.Close()
    End Sub

    Private Sub btnChoice5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice5.Click
        Myconnect()
        strSQL = "select productname, unitsinstock from products where unitsinstock < 10"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro5")
        dgvData.DataSource = MyDS.Tables("mypro5")
        myCon.Close()
    End Sub

    Private Sub btnChoice6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice6.Click
        Myconnect()
        strSQL = "select  *from orders,orderdetails,products where orders.orderid = orderdetails.orderid and  products.productid = orderdetails.productid and orders.orderid  LIKE '%10255%'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro6")
        dgvData.DataSource = MyDS.Tables("mypro6")
        myCon.Close()
    End Sub

    Private Sub btnChoice7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice7.Click
        Myconnect()
        strSQL = "select sum(unitprice*quantity)as total from orders,orderdetails where orders.orderid = orderdetails.orderid  and orders.orderid LIKE '%10255%'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro7")
        dgvData.DataSource = MyDS.Tables("mypro7")
        myCon.Close()
    End Sub

    Private Sub btnChoice8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice8.Click
        Myconnect()
        strSQL = "select orders.orderid,*from customers,orders where customers.customerid=orders.customerid and orders.orderid LIKE '%10347%'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro8")
        dgvData.DataSource = MyDS.Tables("mypro8")
        myCon.Close()
    End Sub

    Private Sub btnChoice9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice9.Click
        Myconnect()
        strSQL = "select suppliers.companyname,orders.orderid,orders.orderdate,products.productname,products.unitprice,orderdetails.quantity from orders,orderdetails,products,suppliers where orders.orderid=orderdetails.orderid and orderdetails.productid = products.productid and products.supplierid=suppliers.supplierid and suppliers.companyname LIKE '%Exotic Liquids%'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro9")
        dgvData.DataSource = MyDS.Tables("mypro9")
        myCon.Close()
    End Sub

    Private Sub btnChoice10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice10.Click
        Myconnect()
        strSQL = "select Count(*) as COUNT_ORDER from customers,orders,orderdetails,products where customers.customerid = orders.customerid and orders.orderid = orderdetails.orderid and orderdetails.productid=products.productid and customers.country LIKE 'ITALY'"
        myDA = New SqlDataAdapter(strSQL, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "mypro10")
        dgvData.DataSource = MyDS.Tables("mypro10")
        myCon.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
