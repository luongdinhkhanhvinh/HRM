<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ADD_USER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ADD_USER))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_TenPB = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_TenNV = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_xacnhan_matkhau = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_matkhau = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_MaNV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tendangnhap = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_xacnhan_matkhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_matkhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MaNV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tendangnhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.lbl_TenPB)
        Me.GroupControl1.Controls.Add(Me.lbl_TenNV)
        Me.GroupControl1.Controls.Add(Me.CheckEdit1)
        Me.GroupControl1.Controls.Add(Me.txt_xacnhan_matkhau)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_matkhau)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_MaNV)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_tendangnhap)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(7, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(450, 178)
        Me.GroupControl1.TabIndex = 62
        Me.GroupControl1.Text = "GroupControl1"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(13, 62)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl7.TabIndex = 58
        Me.LabelControl7.Text = "Phòng ban/Xưởng:"
        '
        'lbl_TenPB
        '
        Me.lbl_TenPB.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_TenPB.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_TenPB.Location = New System.Drawing.Point(114, 59)
        Me.lbl_TenPB.Name = "lbl_TenPB"
        Me.lbl_TenPB.Size = New System.Drawing.Size(328, 20)
        Me.lbl_TenPB.TabIndex = 57
        '
        'lbl_TenNV
        '
        Me.lbl_TenNV.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_TenNV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_TenNV.Location = New System.Drawing.Point(215, 33)
        Me.lbl_TenNV.Name = "lbl_TenNV"
        Me.lbl_TenNV.Size = New System.Drawing.Size(227, 20)
        Me.lbl_TenNV.TabIndex = 56
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(11, 103)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Mật khẩu trùng tên đăng nhập"
        Me.CheckEdit1.Size = New System.Drawing.Size(284, 19)
        Me.CheckEdit1.TabIndex = 4
        '
        'txt_xacnhan_matkhau
        '
        Me.txt_xacnhan_matkhau.Location = New System.Drawing.Point(114, 151)
        Me.txt_xacnhan_matkhau.Name = "txt_xacnhan_matkhau"
        Me.txt_xacnhan_matkhau.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_xacnhan_matkhau.Size = New System.Drawing.Size(328, 20)
        Me.txt_xacnhan_matkhau.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(13, 154)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl6.TabIndex = 47
        Me.LabelControl6.Text = "Xác nhận mật khẩu:"
        '
        'txt_matkhau
        '
        Me.txt_matkhau.Location = New System.Drawing.Point(114, 125)
        Me.txt_matkhau.Name = "txt_matkhau"
        Me.txt_matkhau.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_matkhau.Size = New System.Drawing.Size(328, 20)
        Me.txt_matkhau.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 128)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl5.TabIndex = 46
        Me.LabelControl5.Text = "Mật khẩu:"
        '
        'txt_MaNV
        '
        Me.txt_MaNV.Location = New System.Drawing.Point(114, 33)
        Me.txt_MaNV.Name = "txt_MaNV"
        Me.txt_MaNV.Size = New System.Drawing.Size(95, 20)
        Me.txt_MaNV.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 43
        Me.LabelControl2.Text = "Mã nhân viên:"
        '
        'txt_tendangnhap
        '
        Me.txt_tendangnhap.Location = New System.Drawing.Point(114, 7)
        Me.txt_tendangnhap.Name = "txt_tendangnhap"
        Me.txt_tendangnhap.Size = New System.Drawing.Size(328, 20)
        Me.txt_tendangnhap.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 42
        Me.LabelControl1.Text = "Tên đăng nhập:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(392, 196)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(65, 23)
        Me.SimpleButton3.TabIndex = 64
        Me.SimpleButton3.Text = "Thoát"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(321, 196)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(65, 23)
        Me.SimpleButton1.TabIndex = 63
        Me.SimpleButton1.Text = "Lưu"
        '
        'FRM_ADD_USER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 243)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FRM_ADD_USER"
        Me.Text = "NGƯỜI DÙNG"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_xacnhan_matkhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_matkhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MaNV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tendangnhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_TenPB As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_TenNV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_xacnhan_matkhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_matkhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_MaNV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_tendangnhap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
