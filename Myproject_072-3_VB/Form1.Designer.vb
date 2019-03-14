<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtProprice = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.DgvEmp = New System.Windows.Forms.DataGridView()
        Me.cmbDepart = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtProname = New System.Windows.Forms.TextBox()
        Me.panEmp = New System.Windows.Forms.Panel()
        Me.txtProstock = New System.Windows.Forms.TextBox()
        Me.txtProid = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProprice
        '
        Me.txtProprice.Location = New System.Drawing.Point(95, 156)
        Me.txtProprice.Multiline = True
        Me.txtProprice.Name = "txtProprice"
        Me.txtProprice.Size = New System.Drawing.Size(124, 20)
        Me.txtProprice.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(174, 456)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "ออก"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(57, 415)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "เพิ่ม"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'DgvEmp
        '
        Me.DgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmp.Location = New System.Drawing.Point(247, 12)
        Me.DgvEmp.Name = "DgvEmp"
        Me.DgvEmp.Size = New System.Drawing.Size(552, 385)
        Me.DgvEmp.TabIndex = 8
        '
        'cmbDepart
        '
        Me.cmbDepart.FormattingEnabled = True
        Me.cmbDepart.Location = New System.Drawing.Point(95, 119)
        Me.cmbDepart.Name = "cmbDepart"
        Me.cmbDepart.Size = New System.Drawing.Size(124, 21)
        Me.cmbDepart.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(57, 456)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtProname
        '
        Me.txtProname.Location = New System.Drawing.Point(94, 84)
        Me.txtProname.Multiline = True
        Me.txtProname.Name = "txtProname"
        Me.txtProname.Size = New System.Drawing.Size(124, 20)
        Me.txtProname.TabIndex = 2
        '
        'panEmp
        '
        Me.panEmp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panEmp.Controls.Add(Me.DateTimePicker1)
        Me.panEmp.Controls.Add(Me.cmbDepart)
        Me.panEmp.Controls.Add(Me.txtProprice)
        Me.panEmp.Controls.Add(Me.txtProname)
        Me.panEmp.Controls.Add(Me.txtProstock)
        Me.panEmp.Controls.Add(Me.txtProid)
        Me.panEmp.Controls.Add(Me.btnCancel)
        Me.panEmp.Controls.Add(Me.btnSave)
        Me.panEmp.Controls.Add(Me.Label7)
        Me.panEmp.Controls.Add(Me.Label6)
        Me.panEmp.Controls.Add(Me.Label3)
        Me.panEmp.Controls.Add(Me.Label2)
        Me.panEmp.Controls.Add(Me.Label1)
        Me.panEmp.Location = New System.Drawing.Point(7, 12)
        Me.panEmp.Name = "panEmp"
        Me.panEmp.Size = New System.Drawing.Size(234, 385)
        Me.panEmp.TabIndex = 9
        '
        'txtProstock
        '
        Me.txtProstock.Location = New System.Drawing.Point(97, 194)
        Me.txtProstock.Multiline = True
        Me.txtProstock.Name = "txtProstock"
        Me.txtProstock.Size = New System.Drawing.Size(124, 20)
        Me.txtProstock.TabIndex = 2
        '
        'txtProid
        '
        Me.txtProid.Location = New System.Drawing.Point(95, 47)
        Me.txtProid.Multiline = True
        Me.txtProid.Name = "txtProid"
        Me.txtProid.Size = New System.Drawing.Size(124, 20)
        Me.txtProid.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(137, 235)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(47, 235)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ประเภท"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "คงเหลือ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคา"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(174, 415)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(18, 290)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DgvEmp)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.panEmp)
        Me.Controls.Add(Me.btnEdit)
        Me.Name = "Form1"
        Me.Text = "การจัดการสินค้า"
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panEmp.ResumeLayout(False)
        Me.panEmp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtProprice As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents DgvEmp As DataGridView
    Friend WithEvents cmbDepart As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtProname As TextBox
    Friend WithEvents panEmp As Panel
    Friend WithEvents txtProstock As TextBox
    Friend WithEvents txtProid As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
