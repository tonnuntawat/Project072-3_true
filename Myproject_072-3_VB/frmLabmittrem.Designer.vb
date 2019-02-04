<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabmittrem
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.radCar = New System.Windows.Forms.RadioButton()
        Me.radSuv = New System.Windows.Forms.RadioButton()
        Me.radVan = New System.Windows.Forms.RadioButton()
        Me.txtKilo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkGB = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTry = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblKilo = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotal2 = New System.Windows.Forms.Label()
        Me.tyCar = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radc = New System.Windows.Forms.RadioButton()
        Me.radMoto = New System.Windows.Forms.RadioButton()
        Me.txtClo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblko = New System.Windows.Forms.Label()
        Me.tyCar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 63)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'radCar
        '
        Me.radCar.Location = New System.Drawing.Point(20, 37)
        Me.radCar.Name = "radCar"
        Me.radCar.Size = New System.Drawing.Size(196, 39)
        Me.radCar.TabIndex = 0
        Me.radCar.TabStop = True
        Me.radCar.Text = "รถกระบะ กม.ละ 4 บาท"
        Me.radCar.UseVisualStyleBackColor = True
        '
        'radSuv
        '
        Me.radSuv.Location = New System.Drawing.Point(20, 64)
        Me.radSuv.Name = "radSuv"
        Me.radSuv.Size = New System.Drawing.Size(196, 39)
        Me.radSuv.TabIndex = 0
        Me.radSuv.TabStop = True
        Me.radSuv.Text = "รถSUV กม.ละ 6 บาท"
        Me.radSuv.UseVisualStyleBackColor = True
        '
        'radVan
        '
        Me.radVan.Location = New System.Drawing.Point(20, 19)
        Me.radVan.Name = "radVan"
        Me.radVan.Size = New System.Drawing.Size(196, 24)
        Me.radVan.TabIndex = 0
        Me.radVan.TabStop = True
        Me.radVan.Text = "รถเก๋ง กม.ละ 2 บาท"
        Me.radVan.UseVisualStyleBackColor = True
        '
        'txtKilo
        '
        Me.txtKilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtKilo.Location = New System.Drawing.Point(152, 229)
        Me.txtKilo.Multiline = True
        Me.txtKilo.Name = "txtKilo"
        Me.txtKilo.Size = New System.Drawing.Size(185, 42)
        Me.txtKilo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ระยะทางขาไป"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(800, 51)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "โปรแกรมคำนวณค่าเดินทาง"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkGB
        '
        Me.chkGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGB.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkGB.Location = New System.Drawing.Point(26, 289)
        Me.chkGB.Name = "chkGB"
        Me.chkGB.Size = New System.Drawing.Size(260, 43)
        Me.chkGB.TabIndex = 4
        Me.chkGB.Text = "เดินทางแบบไป-กลับ 50 บาท"
        Me.chkGB.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(369, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 42)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ประเภทรถ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(369, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 42)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "อัตราค่ารถโดยสาร"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(369, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 42)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ระยะทาง"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(369, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 42)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "จำนวน"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(369, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 42)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "รวมทั้งหมด"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTry
        '
        Me.lblTry.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTry.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTry.Location = New System.Drawing.Point(585, 54)
        Me.lblTry.Name = "lblTry"
        Me.lblTry.Size = New System.Drawing.Size(127, 42)
        Me.lblTry.TabIndex = 3
        Me.lblTry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNet.Location = New System.Drawing.Point(585, 107)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(127, 42)
        Me.lblNet.TabIndex = 3
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKilo
        '
        Me.lblKilo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblKilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKilo.Location = New System.Drawing.Point(585, 164)
        Me.lblKilo.Name = "lblKilo"
        Me.lblKilo.Size = New System.Drawing.Size(127, 42)
        Me.lblKilo.TabIndex = 3
        Me.lblKilo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(585, 221)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(127, 42)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal2
        '
        Me.lblTotal2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal2.Location = New System.Drawing.Point(585, 346)
        Me.lblTotal2.Name = "lblTotal2"
        Me.lblTotal2.Size = New System.Drawing.Size(127, 42)
        Me.lblTotal2.TabIndex = 3
        Me.lblTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tyCar
        '
        Me.tyCar.Controls.Add(Me.radVan)
        Me.tyCar.Controls.Add(Me.radCar)
        Me.tyCar.Controls.Add(Me.radSuv)
        Me.tyCar.Location = New System.Drawing.Point(26, 117)
        Me.tyCar.Name = "tyCar"
        Me.tyCar.Size = New System.Drawing.Size(286, 106)
        Me.tyCar.TabIndex = 1
        Me.tyCar.TabStop = False
        Me.tyCar.Text = "รถยนต์"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radc)
        Me.GroupBox1.Controls.Add(Me.radMoto)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 61)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทรถ"
        '
        'radc
        '
        Me.radc.Location = New System.Drawing.Point(153, 30)
        Me.radc.Name = "radc"
        Me.radc.Size = New System.Drawing.Size(107, 24)
        Me.radc.TabIndex = 0
        Me.radc.TabStop = True
        Me.radc.Text = "รถยนต์"
        Me.radc.UseVisualStyleBackColor = True
        '
        'radMoto
        '
        Me.radMoto.Location = New System.Drawing.Point(24, 30)
        Me.radMoto.Name = "radMoto"
        Me.radMoto.Size = New System.Drawing.Size(107, 24)
        Me.radMoto.TabIndex = 0
        Me.radMoto.TabStop = True
        Me.radMoto.Text = "รถจักรยานยนต์"
        Me.radMoto.UseVisualStyleBackColor = True
        '
        'txtClo
        '
        Me.txtClo.Location = New System.Drawing.Point(187, 338)
        Me.txtClo.Name = "txtClo"
        Me.txtClo.Size = New System.Drawing.Size(158, 63)
        Me.txtClo.TabIndex = 0
        Me.txtClo.Text = "ปิด"
        Me.txtClo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(369, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 42)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ค่ารอคอย"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblko
        '
        Me.lblko.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblko.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblko.Location = New System.Drawing.Point(585, 290)
        Me.lblko.Name = "lblko"
        Me.lblko.Size = New System.Drawing.Size(127, 42)
        Me.lblko.TabIndex = 3
        Me.lblko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLabmittrem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 420)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkGB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal2)
        Me.Controls.Add(Me.lblko)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblKilo)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblTry)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKilo)
        Me.Controls.Add(Me.tyCar)
        Me.Controls.Add(Me.txtClo)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmLabmittrem"
        Me.Text = "frmLabmittrem"
        Me.tyCar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents radVan As RadioButton
    Friend WithEvents radSuv As RadioButton
    Friend WithEvents radCar As RadioButton
    Friend WithEvents txtKilo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkGB As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTry As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblKilo As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotal2 As Label
    Friend WithEvents tyCar As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radc As RadioButton
    Friend WithEvents radMoto As RadioButton
    Friend WithEvents txtClo As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblko As Label
End Class
