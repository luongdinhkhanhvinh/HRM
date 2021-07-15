<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ADD_HOPDONG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ADD_HOPDONG))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtSoBHXH = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNgayKy = New DevExpress.XtraEditors.DateEdit()
        Me.txtLuongCoBan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ghichu = New DevExpress.XtraEditors.TextEdit()
        Me.txt_TenPX = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TenNV = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_MaNV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cboLoaiHopDong = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtSoBHXH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayKy.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayKy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLuongCoBan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ghichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MaNV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLoaiHopDong.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.cboLoaiHopDong)
        Me.GroupControl1.Controls.Add(Me.txtSoBHXH)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtNgayKy)
        Me.GroupControl1.Controls.Add(Me.txtLuongCoBan)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_ghichu)
        Me.GroupControl1.Controls.Add(Me.txt_TenPX)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_TenNV)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_MaNV)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(476, 195)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'txtSoBHXH
        '
        Me.txtSoBHXH.EditValue = ""
        Me.txtSoBHXH.Location = New System.Drawing.Point(110, 87)
        Me.txtSoBHXH.Name = "txtSoBHXH"
        Me.txtSoBHXH.Properties.NullText = "--- Hãy nhập vào Mã nhân viên ---"
        Me.txtSoBHXH.Size = New System.Drawing.Size(359, 20)
        Me.txtSoBHXH.TabIndex = 4
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(9, 90)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Số hợp đồng:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(255, 116)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "Lương cơ bản:"
        '
        'txtNgayKy
        '
        Me.txtNgayKy.EditValue = Nothing
        Me.txtNgayKy.Location = New System.Drawing.Point(110, 113)
        Me.txtNgayKy.Name = "txtNgayKy"
        Me.txtNgayKy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayKy.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayKy.Size = New System.Drawing.Size(139, 20)
        Me.txtNgayKy.TabIndex = 1
        '
        'txtLuongCoBan
        '
        Me.txtLuongCoBan.EditValue = ""
        Me.txtLuongCoBan.Location = New System.Drawing.Point(330, 113)
        Me.txtLuongCoBan.Name = "txtLuongCoBan"
        Me.txtLuongCoBan.Properties.NullText = "--- Hãy nhập vào Mã nhân viên ---"
        Me.txtLuongCoBan.Size = New System.Drawing.Size(139, 20)
        Me.txtLuongCoBan.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 116)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Ngày ký:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 168)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Ghi chú:"
        '
        'txt_ghichu
        '
        Me.txt_ghichu.EditValue = ""
        Me.txt_ghichu.Location = New System.Drawing.Point(110, 165)
        Me.txt_ghichu.Name = "txt_ghichu"
        Me.txt_ghichu.Properties.NullText = "--- Hãy nhập vào Mã nhân viên ---"
        Me.txt_ghichu.Size = New System.Drawing.Size(359, 20)
        Me.txt_ghichu.TabIndex = 5
        '
        'txt_TenPX
        '
        Me.txt_TenPX.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_TenPX.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TenPX.Location = New System.Drawing.Point(110, 60)
        Me.txt_TenPX.Name = "txt_TenPX"
        Me.txt_TenPX.Size = New System.Drawing.Size(359, 21)
        Me.txt_TenPX.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(9, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Phòng ban/Xưởng:"
        '
        'txt_TenNV
        '
        Me.txt_TenNV.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_TenNV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TenNV.Location = New System.Drawing.Point(110, 33)
        Me.txt_TenNV.Name = "txt_TenNV"
        Me.txt_TenNV.Size = New System.Drawing.Size(359, 21)
        Me.txt_TenNV.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Họ tên:"
        '
        'txt_MaNV
        '
        Me.txt_MaNV.EditValue = ""
        Me.txt_MaNV.Location = New System.Drawing.Point(110, 7)
        Me.txt_MaNV.Name = "txt_MaNV"
        Me.txt_MaNV.Properties.NullText = "--- Hãy nhập vào Mã nhân viên ---"
        Me.txt_MaNV.Size = New System.Drawing.Size(359, 20)
        Me.txt_MaNV.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã nhân viên:"
        '
        'cboLoaiHopDong
        '
        Me.cboLoaiHopDong.Location = New System.Drawing.Point(110, 139)
        Me.cboLoaiHopDong.Name = "cboLoaiHopDong"
        Me.cboLoaiHopDong.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLoaiHopDong.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoaiHopDong", "Loại hợp đồng")})
        Me.cboLoaiHopDong.Properties.NullText = ""
        Me.cboLoaiHopDong.Size = New System.Drawing.Size(359, 20)
        Me.cboLoaiHopDong.TabIndex = 20
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(9, 142)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "Loại hợp đồng:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(418, 211)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(70, 23)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "&Thoát"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(342, 211)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(70, 23)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "&Lưu"
        '
        'FRM_ADD_HOPDONG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 255)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FRM_ADD_HOPDONG"
        Me.Text = "HỢP ĐỒNG"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtSoBHXH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayKy.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayKy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLuongCoBan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ghichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MaNV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLoaiHopDong.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLoaiHopDong As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtSoBHXH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNgayKy As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtLuongCoBan As DevExpress.XtraEditors.TextEdit
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
