<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CHAMCONGDUPHONG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CHAMCONGDUPHONG))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNgayNopDon = New DevExpress.XtraEditors.DateEdit()
        Me.txt_TenPX = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TenNV = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_MaNV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ThoiGian = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtNgayNopDon.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayNopDon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MaNV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ThoiGian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_ThoiGian)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtNgayNopDon)
        Me.GroupControl1.Controls.Add(Me.txt_TenPX)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_TenNV)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_MaNV)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(505, 141)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 89)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl6.TabIndex = 29
        Me.LabelControl6.Text = "Ngày chấm công:"
        '
        'txtNgayNopDon
        '
        Me.txtNgayNopDon.EditValue = Nothing
        Me.txtNgayNopDon.Location = New System.Drawing.Point(109, 86)
        Me.txtNgayNopDon.Name = "txtNgayNopDon"
        Me.txtNgayNopDon.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayNopDon.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNgayNopDon.Size = New System.Drawing.Size(388, 20)
        Me.txtNgayNopDon.TabIndex = 2
        '
        'txt_TenPX
        '
        Me.txt_TenPX.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_TenPX.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TenPX.Location = New System.Drawing.Point(109, 59)
        Me.txt_TenPX.Name = "txt_TenPX"
        Me.txt_TenPX.Size = New System.Drawing.Size(388, 21)
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
        Me.txt_TenNV.Location = New System.Drawing.Point(109, 32)
        Me.txt_TenNV.Name = "txt_TenNV"
        Me.txt_TenNV.Size = New System.Drawing.Size(388, 21)
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
        Me.txt_MaNV.Location = New System.Drawing.Point(109, 6)
        Me.txt_MaNV.Name = "txt_MaNV"
        Me.txt_MaNV.Properties.NullText = "--- Hãy nhập vào Mã nhân viên ---"
        Me.txt_MaNV.Size = New System.Drawing.Size(388, 20)
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
        'txt_ThoiGian
        '
        Me.txt_ThoiGian.EditValue = New Date(2015, 6, 25, 0, 0, 0, 0)
        Me.txt_ThoiGian.Location = New System.Drawing.Point(109, 112)
        Me.txt_ThoiGian.Name = "txt_ThoiGian"
        Me.txt_ThoiGian.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_ThoiGian.Properties.Mask.EditMask = "hh:mm"
        Me.txt_ThoiGian.Size = New System.Drawing.Size(388, 20)
        Me.txt_ThoiGian.TabIndex = 30
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 115)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl3.TabIndex = 31
        Me.LabelControl3.Text = "Giờ chấm công:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(443, 155)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(70, 23)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "&Thoát"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(367, 155)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(70, 23)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "&Lưu"
        '
        'FRM_CHAMCONGDUPHONG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 191)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FRM_CHAMCONGDUPHONG"
        Me.Text = "CHẤM CÔNG DỰ PHÒNG"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtNgayNopDon.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayNopDon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MaNV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ThoiGian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ThoiGian As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNgayNopDon As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_TenPX As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TenNV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_MaNV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
