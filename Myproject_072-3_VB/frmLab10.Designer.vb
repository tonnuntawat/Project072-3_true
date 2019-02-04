<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLab10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.txtSaleA = New System.Windows.Forms.TextBox()
        Me.txtSaleB = New System.Windows.Forms.TextBox()
        Me.txtSaleC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSumA = New System.Windows.Forms.Label()
        Me.lblSumB = New System.Windows.Forms.Label()
        Me.lblSumC = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMaxSaleName = New System.Windows.Forms.Label()
        Me.lblMaxSaleAmount = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgaData = New System.Windows.Forms.DataGridView()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.dgaName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSumA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgaSumB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgaSumC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgaSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgaData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(38, 82)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(162, 199)
        Me.lstData.TabIndex = 0
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(38, 319)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(162, 21)
        Me.cboIndex.TabIndex = 1
        '
        'txtSaleName
        '
        Me.txtSaleName.Location = New System.Drawing.Point(38, 378)
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(162, 20)
        Me.txtSaleName.TabIndex = 2
        '
        'txtSaleA
        '
        Me.txtSaleA.Location = New System.Drawing.Point(277, 378)
        Me.txtSaleA.Name = "txtSaleA"
        Me.txtSaleA.Size = New System.Drawing.Size(72, 20)
        Me.txtSaleA.TabIndex = 2
        '
        'txtSaleB
        '
        Me.txtSaleB.Location = New System.Drawing.Point(365, 378)
        Me.txtSaleB.Name = "txtSaleB"
        Me.txtSaleB.Size = New System.Drawing.Size(72, 20)
        Me.txtSaleB.TabIndex = 2
        '
        'txtSaleC
        '
        Me.txtSaleC.Location = New System.Drawing.Point(452, 378)
        Me.txtSaleC.Name = "txtSaleC"
        Me.txtSaleC.Size = New System.Drawing.Size(72, 20)
        Me.txtSaleC.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "โปรแกรมคำนวณยอดขายจากอาเรย์"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "รวมยอดขายสินค้า A"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "รวมยอดขายสินค้า B"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "รวมยอดขายสินค้า C"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSumA
        '
        Me.lblSumA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumA.Location = New System.Drawing.Point(432, 63)
        Me.lblSumA.Name = "lblSumA"
        Me.lblSumA.Size = New System.Drawing.Size(108, 32)
        Me.lblSumA.TabIndex = 3
        Me.lblSumA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSumB
        '
        Me.lblSumB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumB.Location = New System.Drawing.Point(432, 120)
        Me.lblSumB.Name = "lblSumB"
        Me.lblSumB.Size = New System.Drawing.Size(108, 32)
        Me.lblSumB.TabIndex = 3
        Me.lblSumB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSumC
        '
        Me.lblSumC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSumC.Location = New System.Drawing.Point(432, 175)
        Me.lblSumC.Name = "lblSumC"
        Me.lblSumC.Size = New System.Drawing.Size(108, 32)
        Me.lblSumC.TabIndex = 3
        Me.lblSumC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 32)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "พนักงานขายคนที่"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 32)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ชื่อ พนง.ขาย"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(213, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 32)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "ผู้ที่ทำยอดขายสูงสุด"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(213, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 32)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "เป็นเงิน"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaxSaleName
        '
        Me.lblMaxSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMaxSaleName.Location = New System.Drawing.Point(432, 251)
        Me.lblMaxSaleName.Name = "lblMaxSaleName"
        Me.lblMaxSaleName.Size = New System.Drawing.Size(108, 32)
        Me.lblMaxSaleName.TabIndex = 3
        Me.lblMaxSaleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaxSaleAmount
        '
        Me.lblMaxSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMaxSaleAmount.Location = New System.Drawing.Point(432, 302)
        Me.lblMaxSaleAmount.Name = "lblMaxSaleAmount"
        Me.lblMaxSaleAmount.Size = New System.Drawing.Size(108, 32)
        Me.lblMaxSaleAmount.TabIndex = 3
        Me.lblMaxSaleAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(345, 413)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 34)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "รายการขาย"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(277, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ยอดขาย A"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(365, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ยอดขาย B"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(452, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "ยอดขาย C"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgaData
        '
        Me.dgaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgaData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgaName, Me.dgvSumA, Me.dgaSumB, Me.dgaSumC, Me.dgaSale})
        Me.dgaData.Location = New System.Drawing.Point(12, 464)
        Me.dgaData.Name = "dgaData"
        Me.dgaData.Size = New System.Drawing.Size(547, 179)
        Me.dgaData.TabIndex = 7
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(455, 413)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(97, 34)
        Me.btnShow.TabIndex = 8
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'dgaName
        '
        Me.dgaName.HeaderText = "ชื่อพนักงาน"
        Me.dgaName.Name = "dgaName"
        '
        'dgvSumA
        '
        Me.dgvSumA.HeaderText = "สินค้า A"
        Me.dgvSumA.Name = "dgvSumA"
        '
        'dgaSumB
        '
        Me.dgaSumB.HeaderText = "สินค้า B"
        Me.dgaSumB.Name = "dgaSumB"
        '
        'dgaSumC
        '
        Me.dgaSumC.HeaderText = "สินค้า C"
        Me.dgaSumC.Name = "dgaSumC"
        '
        'dgaSale
        '
        Me.dgaSale.HeaderText = "ยอดขายรวม"
        Me.dgaSale.Name = "dgaSale"
        '
        'frmLab10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 696)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.dgaData)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMaxSaleAmount)
        Me.Controls.Add(Me.lblMaxSaleName)
        Me.Controls.Add(Me.lblSumC)
        Me.Controls.Add(Me.lblSumB)
        Me.Controls.Add(Me.lblSumA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSaleC)
        Me.Controls.Add(Me.txtSaleB)
        Me.Controls.Add(Me.txtSaleA)
        Me.Controls.Add(Me.txtSaleName)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.lstData)
        Me.Name = "frmLab10"
        Me.Text = "Max Sale Program"
        CType(Me.dgaData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents txtSaleName As TextBox
    Friend WithEvents txtSaleA As TextBox
    Friend WithEvents txtSaleB As TextBox
    Friend WithEvents txtSaleC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSumA As Label
    Friend WithEvents lblSumB As Label
    Friend WithEvents lblSumC As Label
    Friend WithEvents cboIndex As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblMaxSaleName As Label
    Friend WithEvents lblMaxSaleAmount As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgaData As DataGridView
    Friend WithEvents btnShow As Button
    Friend WithEvents dgaName As DataGridViewTextBoxColumn
    Friend WithEvents dgvSumA As DataGridViewTextBoxColumn
    Friend WithEvents dgaSumB As DataGridViewTextBoxColumn
    Friend WithEvents dgaSumC As DataGridViewTextBoxColumn
    Friend WithEvents dgaSale As DataGridViewTextBoxColumn
End Class
