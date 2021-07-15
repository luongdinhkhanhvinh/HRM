<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_NHANVIEN_NGHIVIEC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_NHANVIEN_NGHIVIEC))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dgvNhanVien_NghiViec = New DevExpress.XtraGrid.GridControl()
        Me.AdvBandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn20 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn18 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn21 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn30 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn33 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.cboLoaiNghiViec = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.lbl_STT = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_MaNV = New DevExpress.XtraEditors.LabelControl()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNhanVien_NghiViec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLoaiNghiViec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "1.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "2.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "3.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "4.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "system_search.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "table_excel.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "agt_print.png")
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ribbonImageCollection
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarSubItem1, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem7, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 21
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem13, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem14, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem12, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Tìm kiếm"
        Me.BarButtonItem7.Id = 16
        Me.BarButtonItem7.ImageIndex = 4
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "&Thêm"
        Me.BarButtonItem13.Id = 19
        Me.BarButtonItem13.ImageIndex = 3
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Lưu"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ImageIndex = 0
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Xóa"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ImageIndex = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Nạp lại"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageIndex = 2
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "&In"
        Me.BarButtonItem14.Id = 20
        Me.BarButtonItem14.ImageIndex = 6
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "&Excel"
        Me.BarButtonItem12.Id = 17
        Me.BarButtonItem12.ImageIndex = 5
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1170, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 436)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1170, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 412)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1170, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 412)
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "&Thêm"
        Me.BarButtonItem4.Id = 5
        Me.BarButtonItem4.ImageIndex = 3
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Xóa tất cả danh sách"
        Me.BarButtonItem5.Id = 7
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Xóa tất cả danh sách không đăng ký nghĩ phép"
        Me.BarButtonItem6.Id = 8
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Tùy chọn"
        Me.BarSubItem1.Id = 10
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Nhân viên đang làm việc"
        Me.BarButtonItem8.Id = 12
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Nhân viên đã thôi việc"
        Me.BarButtonItem9.Id = 13
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2))
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Nhân viên nghĩ thai sản"
        Me.BarButtonItem10.Id = 14
        Me.BarButtonItem10.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3))
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Tất cả"
        Me.BarButtonItem11.Id = 15
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgvNhanVien_NghiViec
        '
        Me.dgvNhanVien_NghiViec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNhanVien_NghiViec.Location = New System.Drawing.Point(0, 24)
        Me.dgvNhanVien_NghiViec.MainView = Me.AdvBandedGridView2
        Me.dgvNhanVien_NghiViec.Name = "dgvNhanVien_NghiViec"
        Me.dgvNhanVien_NghiViec.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboLoaiNghiViec})
        Me.dgvNhanVien_NghiViec.ShowOnlyPredefinedDetails = True
        Me.dgvNhanVien_NghiViec.Size = New System.Drawing.Size(1170, 412)
        Me.dgvNhanVien_NghiViec.TabIndex = 16
        Me.dgvNhanVien_NghiViec.UseEmbeddedNavigator = True
        Me.dgvNhanVien_NghiViec.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView2})
        '
        'AdvBandedGridView2
        '
        Me.AdvBandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5, Me.GridBand7, Me.gridBand1})
        Me.AdvBandedGridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.AdvBandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn12, Me.BandedGridColumn13, Me.BandedGridColumn20, Me.BandedGridColumn18, Me.BandedGridColumn21, Me.BandedGridColumn33, Me.BandedGridColumn30, Me.BandedGridColumn2, Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn7})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Expression = "1"
        StyleFormatCondition1.Value1 = "I"
        Me.AdvBandedGridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.AdvBandedGridView2.GridControl = Me.dgvNhanVien_NghiViec
        Me.AdvBandedGridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "stt", Nothing, "")})
        Me.AdvBandedGridView2.Name = "AdvBandedGridView2"
        Me.AdvBandedGridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.AdvBandedGridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.AdvBandedGridView2.OptionsBehavior.AutoExpandAllGroups = True
        Me.AdvBandedGridView2.OptionsFilter.UseNewCustomFilterDialog = True
        Me.AdvBandedGridView2.OptionsView.ShowAutoFilterRow = True
        Me.AdvBandedGridView2.OptionsView.ShowGroupPanel = False
        '
        'GridBand5
        '
        Me.GridBand5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand5.Caption = "Thông tin chi tiết nhân viên"
        Me.GridBand5.Columns.Add(Me.BandedGridColumn12)
        Me.GridBand5.Columns.Add(Me.BandedGridColumn13)
        Me.GridBand5.Columns.Add(Me.BandedGridColumn20)
        Me.GridBand5.Columns.Add(Me.BandedGridColumn18)
        Me.GridBand5.Columns.Add(Me.BandedGridColumn21)
        Me.GridBand5.Name = "GridBand5"
        Me.GridBand5.VisibleIndex = 0
        Me.GridBand5.Width = 450
        '
        'BandedGridColumn12
        '
        Me.BandedGridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.BandedGridColumn12.Caption = "Mã nhân viên"
        Me.BandedGridColumn12.FieldName = "MaNhanVien"
        Me.BandedGridColumn12.Name = "BandedGridColumn12"
        Me.BandedGridColumn12.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn12.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn12.Visible = True
        Me.BandedGridColumn12.Width = 80
        '
        'BandedGridColumn13
        '
        Me.BandedGridColumn13.Caption = "Họ tên"
        Me.BandedGridColumn13.FieldName = "TenNV"
        Me.BandedGridColumn13.Name = "BandedGridColumn13"
        Me.BandedGridColumn13.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn13.Visible = True
        Me.BandedGridColumn13.Width = 176
        '
        'BandedGridColumn20
        '
        Me.BandedGridColumn20.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn20.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn20.Caption = "Phái"
        Me.BandedGridColumn20.FieldName = "Phai"
        Me.BandedGridColumn20.Name = "BandedGridColumn20"
        Me.BandedGridColumn20.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn20.Visible = True
        Me.BandedGridColumn20.Width = 43
        '
        'BandedGridColumn18
        '
        Me.BandedGridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn18.Caption = "Ngày sinh"
        Me.BandedGridColumn18.FieldName = "NgaySinh"
        Me.BandedGridColumn18.Name = "BandedGridColumn18"
        Me.BandedGridColumn18.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn18.Visible = True
        Me.BandedGridColumn18.Width = 71
        '
        'BandedGridColumn21
        '
        Me.BandedGridColumn21.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn21.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn21.Caption = "Ngày vào làm"
        Me.BandedGridColumn21.FieldName = "NgayNhanViec"
        Me.BandedGridColumn21.Name = "BandedGridColumn21"
        Me.BandedGridColumn21.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn21.Visible = True
        Me.BandedGridColumn21.Width = 80
        '
        'GridBand7
        '
        Me.GridBand7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand7.Caption = "Bộ phận làm việc"
        Me.GridBand7.Columns.Add(Me.BandedGridColumn30)
        Me.GridBand7.Columns.Add(Me.BandedGridColumn33)
        Me.GridBand7.Name = "GridBand7"
        Me.GridBand7.VisibleIndex = 1
        Me.GridBand7.Width = 330
        '
        'BandedGridColumn30
        '
        Me.BandedGridColumn30.Caption = "Phòng ban/xưởng"
        Me.BandedGridColumn30.FieldName = "PhongBan"
        Me.BandedGridColumn30.Name = "BandedGridColumn30"
        Me.BandedGridColumn30.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn30.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.BandedGridColumn30.Visible = True
        Me.BandedGridColumn30.Width = 196
        '
        'BandedGridColumn33
        '
        Me.BandedGridColumn33.Caption = "Chức vụ"
        Me.BandedGridColumn33.FieldName = "ChucVu"
        Me.BandedGridColumn33.Name = "BandedGridColumn33"
        Me.BandedGridColumn33.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn33.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.BandedGridColumn33.Visible = True
        Me.BandedGridColumn33.Width = 134
        '
        'gridBand1
        '
        Me.gridBand1.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand1.Caption = "Chi tiết nhân viên thôi việc"
        Me.gridBand1.Columns.Add(Me.BandedGridColumn2)
        Me.gridBand1.Columns.Add(Me.BandedGridColumn3)
        Me.gridBand1.Columns.Add(Me.BandedGridColumn7)
        Me.gridBand1.Columns.Add(Me.BandedGridColumn4)
        Me.gridBand1.Name = "gridBand1"
        Me.gridBand1.VisibleIndex = 2
        Me.gridBand1.Width = 400
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn2.Caption = "Ngày nộp đơn"
        Me.BandedGridColumn2.FieldName = "NgayNopDon"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn2.Visible = True
        Me.BandedGridColumn2.Width = 80
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.BandedGridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn3.Caption = "Ngày nghĩ việc"
        Me.BandedGridColumn3.FieldName = "NgayNghiViec"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn3.Visible = True
        Me.BandedGridColumn3.Width = 80
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.BandedGridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BandedGridColumn7.Caption = "Duyệt"
        Me.BandedGridColumn7.FieldName = "Duyet"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn7.Visible = True
        Me.BandedGridColumn7.Width = 40
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.Caption = "Lý do"
        Me.BandedGridColumn4.FieldName = "LyDo"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.OptionsColumn.FixedWidth = True
        Me.BandedGridColumn4.Visible = True
        Me.BandedGridColumn4.Width = 200
        '
        'cboLoaiNghiViec
        '
        Me.cboLoaiNghiViec.AutoHeight = False
        Me.cboLoaiNghiViec.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cboLoaiNghiViec.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLoaiNghiViec.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("maloai", "Mã loại"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nghiviec", "Loại nghĩ việc")})
        Me.cboLoaiNghiViec.Name = "cboLoaiNghiViec"
        Me.cboLoaiNghiViec.NullText = ""
        '
        'lbl_STT
        '
        Me.lbl_STT.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_STT.Location = New System.Drawing.Point(458, 209)
        Me.lbl_STT.Name = "lbl_STT"
        Me.lbl_STT.Size = New System.Drawing.Size(66, 0)
        Me.lbl_STT.TabIndex = 17
        '
        'lbl_MaNV
        '
        Me.lbl_MaNV.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_MaNV.Location = New System.Drawing.Point(464, 234)
        Me.lbl_MaNV.Name = "lbl_MaNV"
        Me.lbl_MaNV.Size = New System.Drawing.Size(66, 0)
        Me.lbl_MaNV.TabIndex = 18
        '
        'FRM_NHANVIEN_NGHIVIEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 436)
        Me.Controls.Add(Me.lbl_MaNV)
        Me.Controls.Add(Me.lbl_STT)
        Me.Controls.Add(Me.dgvNhanVien_NghiViec)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FRM_NHANVIEN_NGHIVIEC"
        Me.Text = "NHÂN VIÊN NGHĨ VIỆC"
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNhanVien_NghiViec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLoaiNghiViec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dgvNhanVien_NghiViec As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn20 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn18 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn21 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn30 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn33 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cboLoaiNghiViec As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents lbl_MaNV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_STT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
End Class
