<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RPT_NHANVIEN
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lbl_STT = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_MaNhanVien = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_HoNV = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_TenNV = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_NgaySinh = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_NoiSinh = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_NgayVaoLam = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_NoiCap = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_DanToc = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_TonGiao = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_DiaChi = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lbl_NoiCap1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.lbl_PhongBan = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.lbl_Ngay = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl_TieuDe = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 22.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "DataField"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1116.0!, 22.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lbl_STT, Me.lbl_MaNhanVien, Me.lbl_HoNV, Me.lbl_TenNV, Me.lbl_NgaySinh, Me.lbl_NoiSinh, Me.lbl_NgayVaoLam, Me.XrTableCell18, Me.lbl_NoiCap, Me.lbl_DanToc, Me.lbl_TonGiao, Me.lbl_DiaChi})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'lbl_STT
        '
        Me.lbl_STT.Font = New System.Drawing.Font("Calibri Light", 10.0!)
        Me.lbl_STT.Name = "lbl_STT"
        Me.lbl_STT.StylePriority.UseFont = False
        Me.lbl_STT.StylePriority.UseTextAlignment = False
        Me.lbl_STT.Text = "1000"
        Me.lbl_STT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lbl_STT.Weight = 0.39211593307074483R
        '
        'lbl_MaNhanVien
        '
        Me.lbl_MaNhanVien.Name = "lbl_MaNhanVien"
        Me.lbl_MaNhanVien.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.lbl_MaNhanVien.StylePriority.UsePadding = False
        Me.lbl_MaNhanVien.Weight = 0.66792071966694933R
        '
        'lbl_HoNV
        '
        Me.lbl_HoNV.Name = "lbl_HoNV"
        Me.lbl_HoNV.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.lbl_HoNV.StylePriority.UsePadding = False
        Me.lbl_HoNV.Text = "Họ "
        Me.lbl_HoNV.Weight = 1.2212178939621126R
        '
        'lbl_TenNV
        '
        Me.lbl_TenNV.Name = "lbl_TenNV"
        Me.lbl_TenNV.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100.0!)
        Me.lbl_TenNV.StylePriority.UsePadding = False
        Me.lbl_TenNV.StylePriority.UseTextAlignment = False
        Me.lbl_TenNV.Text = "Nguyệt"
        Me.lbl_TenNV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lbl_TenNV.Weight = 0.637502454256712R
        '
        'lbl_NgaySinh
        '
        Me.lbl_NgaySinh.Name = "lbl_NgaySinh"
        Me.lbl_NgaySinh.StylePriority.UseTextAlignment = False
        Me.lbl_NgaySinh.Text = "10/10/2010"
        Me.lbl_NgaySinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lbl_NgaySinh.Weight = 0.73521710075496383R
        '
        'lbl_NoiSinh
        '
        Me.lbl_NoiSinh.Name = "lbl_NoiSinh"
        Me.lbl_NoiSinh.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100.0!)
        Me.lbl_NoiSinh.StylePriority.UsePadding = False
        Me.lbl_NoiSinh.StylePriority.UseTextAlignment = False
        Me.lbl_NoiSinh.Text = "Bà Rịa - Vũng Tàu"
        Me.lbl_NoiSinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lbl_NoiSinh.Weight = 1.0293042755487611R
        '
        'lbl_NgayVaoLam
        '
        Me.lbl_NgayVaoLam.Name = "lbl_NgayVaoLam"
        Me.lbl_NgayVaoLam.StylePriority.UseTextAlignment = False
        Me.lbl_NgayVaoLam.Text = "Ngày vào làm"
        Me.lbl_NgayVaoLam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lbl_NgayVaoLam.Weight = 0.83324607923732574R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "123 456 789"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell18.Weight = 0.88226081083457131R
        '
        'lbl_NoiCap
        '
        Me.lbl_NoiCap.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbl_NoiCap.Name = "lbl_NoiCap"
        Me.lbl_NoiCap.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100.0!)
        Me.lbl_NoiCap.StylePriority.UseFont = False
        Me.lbl_NoiCap.StylePriority.UsePadding = False
        Me.lbl_NoiCap.StylePriority.UseTextAlignment = False
        Me.lbl_NoiCap.Text = "Nơi cấp"
        Me.lbl_NoiCap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.lbl_NoiCap.Weight = 1.0293043382152884R
        '
        'lbl_DanToc
        '
        Me.lbl_DanToc.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbl_DanToc.Name = "lbl_DanToc"
        Me.lbl_DanToc.StylePriority.UseFont = False
        Me.lbl_DanToc.StylePriority.UseTextAlignment = False
        Me.lbl_DanToc.Text = "Dân tộc"
        Me.lbl_DanToc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lbl_DanToc.Weight = 0.59390697392749026R
        '
        'lbl_TonGiao
        '
        Me.lbl_TonGiao.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lbl_TonGiao.Name = "lbl_TonGiao"
        Me.lbl_TonGiao.StylePriority.UseFont = False
        Me.lbl_TonGiao.StylePriority.UseTextAlignment = False
        Me.lbl_TonGiao.Text = "Thiên chúa"
        Me.lbl_TonGiao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lbl_TonGiao.Weight = 0.70417045799421618R
        '
        'lbl_DiaChi
        '
        Me.lbl_DiaChi.Font = New System.Drawing.Font("Calibri Light", 8.0!)
        Me.lbl_DiaChi.Name = "lbl_DiaChi"
        Me.lbl_DiaChi.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.lbl_DiaChi.StylePriority.UseFont = False
        Me.lbl_DiaChi.StylePriority.UsePadding = False
        Me.lbl_DiaChi.Text = "Địa chỉ"
        Me.lbl_DiaChi.Weight = 2.2138673706848842R
        Me.lbl_DiaChi.WordWrap = False
        '
        'PageHeaderBand1
        '
        Me.PageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeaderBand1.HeightF = 35.0!
        Me.PageHeaderBand1.Name = "PageHeaderBand1"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(1116.0!, 35.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.lbl_NoiCap1, Me.XrTableCell9, Me.XrTableCell11, Me.XrTableCell10})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "STT"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 0.39211593307074483R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.Text = "Mã NV"
        Me.XrTableCell1.Weight = 0.66792071966694933R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell2.StylePriority.UsePadding = False
        Me.XrTableCell2.Text = "Họ "
        Me.XrTableCell2.Weight = 1.2212178939621126R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Tên"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 0.63750214907997094R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Ngày sinh"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 0.73521733114152688R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Nơi sinh"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 1.0293043473309247R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "Ngày vào làm"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell6.Weight = 0.8332463723820086R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "Số CMND"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 0.88226081985861449R
        '
        'lbl_NoiCap1
        '
        Me.lbl_NoiCap1.Name = "lbl_NoiCap1"
        Me.lbl_NoiCap1.StylePriority.UseTextAlignment = False
        Me.lbl_NoiCap1.Text = "Nơi cấp"
        Me.lbl_NoiCap1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lbl_NoiCap1.Weight = 1.0293043261832306R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Dân tộc"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell9.Weight = 0.59390637560606607R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Tôn giáo"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell11.Weight = 0.70417048335724719R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UsePadding = False
        Me.XrTableCell10.Text = "Địa chỉ"
        Me.XrTableCell10.Weight = 2.2138676565146231R
        '
        'GroupHeaderBand1
        '
        Me.GroupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("PhongBan", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeaderBand1.HeightF = 22.0!
        Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
        Me.GroupHeaderBand1.StyleName = "DataField"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(1116.0!, 22.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.lbl_PhongBan})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'lbl_PhongBan
        '
        Me.lbl_PhongBan.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_PhongBan.Name = "lbl_PhongBan"
        Me.lbl_PhongBan.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.lbl_PhongBan.StylePriority.UseFont = False
        Me.lbl_PhongBan.StylePriority.UsePadding = False
        Me.lbl_PhongBan.Text = "Địa chỉ"
        Me.lbl_PhongBan.Weight = 10.940034408154018R
        '
        'PageFooterBand1
        '
        Me.PageFooterBand1.Expanded = False
        Me.PageFooterBand1.HeightF = 29.0!
        Me.PageFooterBand1.Name = "PageFooterBand1"
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbl_Ngay, Me.lbl_TieuDe, Me.XrLabel1})
        Me.ReportHeaderBand1.HeightF = 49.62501!
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'lbl_Ngay
        '
        Me.lbl_Ngay.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_Ngay.LocationFloat = New DevExpress.Utils.PointFloat(818.3291!, 0.0!)
        Me.lbl_Ngay.Name = "lbl_Ngay"
        Me.lbl_Ngay.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_Ngay.SizeF = New System.Drawing.SizeF(297.6708!, 23.0!)
        Me.lbl_Ngay.StylePriority.UseFont = False
        Me.lbl_Ngay.StylePriority.UseTextAlignment = False
        Me.lbl_Ngay.Text = "lbl_Ngay"
        Me.lbl_Ngay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'lbl_TieuDe
        '
        Me.lbl_TieuDe.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_TieuDe.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 11.00001!)
        Me.lbl_TieuDe.Multiline = True
        Me.lbl_TieuDe.Name = "lbl_TieuDe"
        Me.lbl_TieuDe.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_TieuDe.SizeF = New System.Drawing.SizeF(1116.0!, 38.625!)
        Me.lbl_TieuDe.StylePriority.UseFont = False
        Me.lbl_TieuDe.StylePriority.UseTextAlignment = False
        Me.lbl_TieuDe.Text = "DANH SÁCH NHÂN VIÊN"
        Me.lbl_TieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(182.2916!, 38.625!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "CÔNG TY TNHH HÒA BÌNH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P. NHÂN SỰ"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 24.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 26.20834!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'RPT_NHANVIEN
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeaderBand1, Me.GroupHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(23, 30, 24, 26)
        Me.PageHeight = 827
        Me.PageWidth = 1169
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "13.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents lbl_TieuDe As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lbl_MaNhanVien As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_HoNV As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_TenNV As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_NgaySinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_NoiSinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_NgayVaoLam As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_NoiCap As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_DanToc As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_TonGiao As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_DiaChi As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_NoiCap1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_STT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents lbl_PhongBan As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lbl_Ngay As DevExpress.XtraReports.UI.XRLabel
End Class
