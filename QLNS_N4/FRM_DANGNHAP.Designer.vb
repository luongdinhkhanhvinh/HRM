<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DANGNHAP
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DANGNHAP))
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblDatabase = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_sever = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblchucvu = New DevExpress.XtraEditors.LabelControl()
        Me.lblmakho = New DevExpress.XtraEditors.LabelControl()
        Me.lblmapb = New System.Windows.Forms.Label()
        Me.lbltruycap = New DevExpress.XtraEditors.LabelControl()
        Me.lblphongban = New DevExpress.XtraEditors.LabelControl()
        Me.lblhoten = New DevExpress.XtraEditors.LabelControl()
        Me.txtmatkhau = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txttennguoisd = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.lblDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sever.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmatkhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttennguoisd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(151, 79)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl7.TabIndex = 345
        Me.LabelControl7.Text = "Database:"
        '
        'lblDatabase
        '
        Me.lblDatabase.EditValue = "QLNS_NHOM4"
        Me.lblDatabase.Location = New System.Drawing.Point(230, 76)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lblDatabase.Properties.Items.AddRange(New Object() {"HOB"})
        Me.lblDatabase.Properties.ReadOnly = True
        Me.lblDatabase.Size = New System.Drawing.Size(244, 20)
        Me.lblDatabase.TabIndex = 344
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(151, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl4.TabIndex = 343
        Me.LabelControl4.Text = "Authentication:"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "SQL Server Authentication"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(230, 38)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"SQL Server Authentication", "Windows Authentication"})
        Me.ComboBoxEdit1.Properties.ReadOnly = True
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(244, 20)
        Me.ComboBoxEdit1.TabIndex = 342
        '
        'txt_sever
        '
        Me.txt_sever.EditValue = "(local)"
        Me.txt_sever.Location = New System.Drawing.Point(230, 12)
        Me.txt_sever.Name = "txt_sever"
        Me.txt_sever.Properties.ReadOnly = True
        Me.txt_sever.Size = New System.Drawing.Size(244, 20)
        Me.txt_sever.TabIndex = 340
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(151, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 341
        Me.LabelControl1.Text = "Sever:"
        '
        'lblchucvu
        '
        Me.lblchucvu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblchucvu.Location = New System.Drawing.Point(166, 217)
        Me.lblchucvu.Name = "lblchucvu"
        Me.lblchucvu.Size = New System.Drawing.Size(66, 0)
        Me.lblchucvu.TabIndex = 338
        '
        'lblmakho
        '
        Me.lblmakho.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblmakho.Location = New System.Drawing.Point(178, 85)
        Me.lblmakho.Name = "lblmakho"
        Me.lblmakho.Size = New System.Drawing.Size(66, 0)
        Me.lblmakho.TabIndex = 337
        '
        'lblmapb
        '
        Me.lblmapb.Location = New System.Drawing.Point(150, 170)
        Me.lblmapb.Name = "lblmapb"
        Me.lblmapb.Size = New System.Drawing.Size(39, 0)
        Me.lblmapb.TabIndex = 336
        '
        'lbltruycap
        '
        Me.lbltruycap.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbltruycap.Location = New System.Drawing.Point(153, 170)
        Me.lbltruycap.Name = "lbltruycap"
        Me.lbltruycap.Size = New System.Drawing.Size(48, 0)
        Me.lbltruycap.TabIndex = 335
        '
        'lblphongban
        '
        Me.lblphongban.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblphongban.Location = New System.Drawing.Point(167, 170)
        Me.lblphongban.Name = "lblphongban"
        Me.lblphongban.Size = New System.Drawing.Size(66, 0)
        Me.lblphongban.TabIndex = 334
        '
        'lblhoten
        '
        Me.lblhoten.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblhoten.Location = New System.Drawing.Point(174, 83)
        Me.lblhoten.Name = "lblhoten"
        Me.lblhoten.Size = New System.Drawing.Size(66, 0)
        Me.lblhoten.TabIndex = 333
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(227, 166)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtmatkhau.Size = New System.Drawing.Size(244, 20)
        Me.txtmatkhau.TabIndex = 328
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(146, 169)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 332
        Me.LabelControl3.Text = "Mật khẩu:"
        '
        'txttennguoisd
        '
        Me.txttennguoisd.Location = New System.Drawing.Point(227, 140)
        Me.txttennguoisd.Name = "txttennguoisd"
        Me.txttennguoisd.Size = New System.Drawing.Size(244, 20)
        Me.txttennguoisd.TabIndex = 327
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(146, 143)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 331
        Me.LabelControl2.Text = "Tên đăng nhập:"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(140, 261)
        Me.PictureEdit1.TabIndex = 339
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(399, 205)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 330
        Me.SimpleButton3.Text = "&Kết thúc"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(306, 205)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(87, 23)
        Me.SimpleButton2.TabIndex = 329
        Me.SimpleButton2.Text = "Đăng &nhập"
        '
        'FRM_DANGNHAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 261)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.Controls.Add(Me.txt_sever)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.lblchucvu)
        Me.Controls.Add(Me.lblmakho)
        Me.Controls.Add(Me.lblmapb)
        Me.Controls.Add(Me.lbltruycap)
        Me.Controls.Add(Me.lblphongban)
        Me.Controls.Add(Me.lblhoten)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.txtmatkhau)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txttennguoisd)
        Me.Controls.Add(Me.LabelControl2)
        Me.KeyPreview = True
        Me.Name = "FRM_DANGNHAP"
        Me.Text = "FRM_DANGNHAP"
        CType(Me.lblDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sever.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmatkhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttennguoisd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDatabase As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_sever As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblchucvu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblmakho As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblmapb As System.Windows.Forms.Label
    Friend WithEvents lbltruycap As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblphongban As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblhoten As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtmatkhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txttennguoisd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
