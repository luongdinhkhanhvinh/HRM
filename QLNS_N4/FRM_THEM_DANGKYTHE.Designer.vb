<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_THEM_DANGKYTHE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_THEM_DANGKYTHE))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_NgayDangKy = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbo_LoaiDangKy = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ghichu = New DevExpress.XtraEditors.TextEdit()
        Me.txt_TenPX = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TenNV = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_MaNV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_NgayDangKy.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NgayDangKy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo_LoaiDangKy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ghichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MaNV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_NgayDangKy)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.cbo_LoaiDangKy)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_ghichu)
        Me.GroupControl1.Controls.Add(Me.txt_TenPX)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_TenNV)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_MaNV)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(482, 145)
        Me.GroupControl1.TabIndex = 31
        Me.GroupControl1.Text = "GroupControl1"
        '
        'txt_NgayDangKy
        '
        Me.txt_NgayDangKy.EditValue = Nothing
        Me.txt_NgayDangKy.Location = New System.Drawing.Point(348, 86)
        Me.txt_NgayDangKy.Name = "txt_NgayDangKy"
        Me.txt_NgayDangKy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_NgayDangKy.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_NgayDangKy.Size = New System.Drawing.Size(127, 20)
        Me.txt_NgayDangKy.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(272, 89)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl6.TabIndex = 29
        Me.LabelControl6.Text = "Ngày đăng ký:"
        '
        'cbo_LoaiDangKy
        '
        Me.cbo_LoaiDangKy.Location = New System.Drawing.Point(105, 86)
        Me.cbo_LoaiDangKy.Name = "cbo_LoaiDangKy"
        Me.cbo_LoaiDangKy.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cbo_LoaiDangKy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbo_LoaiDangKy.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoaiDangKy", "Loại đăng ký")})
        Me.cbo_LoaiDangKy.Properties.NullText = ""
        Me.cbo_LoaiDangKy.Size = New System.Drawing.Size(161, 20)
        Me.cbo_LoaiDangKy.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(10, 89)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl4.TabIndex = 27
        Me.LabelControl4.Text = "Loại đăng ký thẻ:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 115)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Ghi chú:"
        '
        'txt_ghichu
        '
        Me.txt_ghichu.EditValue = ""
        Me.txt_ghichu.Location = New System.Drawing.Point(105, 112)
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.Properties.NullText = "--- Hãy nhập vào Mã nhân viên ---"
        Me.txt_ghichu.Size = New System.Drawing.Size(370, 20)
        Me.txt_ghichu.TabIndex = 3
        '
        'txt_TenPX
        '
        Me.txt_TenPX.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_TenPX.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TenPX.Location = New System.Drawing.Point(105, 59)
        Me.txt_TenPX.Name = "txt_TenPX"
        Me.txt_TenPX.Size = New System.Drawing.Size(370, 21)
        Me.txt_TenPX.TabIndex = 20
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(10, 63)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Phòng ban/Xưởng:"
        '
        'txt_TenNV
        '
        Me.txt_TenNV.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_TenNV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TenNV.Location = New System.Drawing.Point(105, 32)
        Me.txt_TenNV.Name = "txt_TenNV"
        Me.txt_TenNV.Size = New System.Drawing.Size(370, 21)
        Me.txt_TenNV.TabIndex = 17
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Họ tên:"
        '
        'txt_MaNV
        '
        Me.txt_MaNV.Location = New System.Drawing.Point(105, 6)
        Me.txt_MaNV.Name = "txt_MaNV"
        Me.txt_MaNV.Properties.NullText = "--- Hãy nhập vào Mã nhân viên ---"
        Me.txt_MaNV.Size = New System.Drawing.Size(370, 20)
        Me.txt_MaNV.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Mã nhân viên:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(420, 161)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(70, 23)
        Me.SimpleButton2.TabIndex = 33
        Me.SimpleButton2.Text = "&Thoát"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(344, 161)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(70, 23)
        Me.SimpleButton1.TabIndex = 32
        Me.SimpleButton1.Text = "&Đăng ký"
        '
        'FRM_THEM_DANGKYTHE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 198)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FRM_THEM_DANGKYTHE"
        Me.Text = "ĐĂNG KÝ THẺ NHÂN VIÊN"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_NgayDangKy.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NgayDangKy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo_LoaiDangKy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ghichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MaNV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_NgayDangKy As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbo_LoaiDangKy As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ghichu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TenPX As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TenNV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_MaNV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
