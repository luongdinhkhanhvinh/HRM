Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_NHANVIEN

#Region "XuLy"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf LOAD_NHANVIEN))
                End If
                start = False
                Thread.Sleep(300)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub start_thearing()
        th_NhanDuLieu = New Thread(AddressOf XuLy)
        th_NhanDuLieu.IsBackground = True
        th_NhanDuLieu.Start()
    End Sub
#End Region

#Region "XuLy"
    Public Delegate Sub GoiDuLieuXuLy()
    Dim th_GoiDuLieu As Thread

    Public Sub start_thearing_send()
        th_GoiDuLieu = New Thread(AddressOf XuLyGoiDuLieu)
        th_GoiDuLieu.IsBackground = True
        th_GoiDuLieu.Start()
    End Sub

    Dim f As Boolean
    Public Sub XuLyGoiDuLieu()
        While True
            If f = True Then
                Me.BeginInvoke(New GoiDuLieuXuLy(AddressOf GoiDuLieu))
            End If
            Thread.Sleep(300)
            Exit Sub
        End While
    End Sub

    Public Sub GoiDuLieu()
        start1 = True
    End Sub
#End Region

    Public Sub _XULY_NHANVIEN_NGHIVIEC()
        Dim ds As New DataSet
        ds = _load_data("set dateformat dmy select * from view_NhanVien_NghiViec where SD=1 and NgayNghiViec='" & Now.Date & "'")
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            _Update("update tbl_NhanVien set SD=0 where MaNhanVien='" & dr("MaNhanVien") & "'")
        Next
    End Sub

    Public Sub _LOADDULIEU()
        Dim ds As New DataSet
        ds = _load_data2("select * from view_nhanvien")
        Dim dr As DataRow
        Dim strGioiTinh As String
        For Each dr In ds.Tables(0).Rows
            If dr("gioitinh") = "Nam" Then
                strGioiTinh = 1
            Else
                strGioiTinh = 0
            End If
            _Save("insert into tbl_NhanVien(MaNhanVien,TenNV,GioiTinh,NgaySinh,NoiSinh,DiaChi,DiaChi_TamTru,SoCMND,NoiCap,NgayCap,NgayNhanViec, " & _
                                                 "MaTonGiao,MaDanToc,MaPhongBan,MaChucVu,MaTrinhDo,TinhTrang,SD) values ('" & dr("manv") & "',N'" & dr("tennv") & "','" _
                                                 & strGioiTinh & "','" & dr("ngaysinh") & "',N'" & dr("tinhthanh") & "',N'" & dr("diachi1") & "',N'','" _
                                                 & dr("socmnd") & "',N'" & dr("noicap") & "','24/06/2015','" & dr("ngayvaolam") & "','" & dr("matg") & "','" & dr("madantoc") & "','" _
                                                 & dr("mapx") & "','" & dr("machucvu") & "','" & dr("mahocvan") & "',N'" & dr("tinhtrang") & "',1)")
        Next
    End Sub
    Private Sub FRM_NHANVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _XULY_NHANVIEN_NGHIVIEC()

        LOAD_NHANVIEN()
        LOAD_DANTOC()
        LOAD_PHONGBAN()
        LOAD_CHUCVU()
        LOAD_NOICAP()
        LOAD_TINHTHANH()
        LOAD_TRINHDO()
        LOAD_TONGIAO()
        '  _LOADDULIEU()
    End Sub

    Dim i As Integer = 1
    Public Sub LOAD_NHANVIEN()
        Dim y As Integer
        y = AdvBandedGridView2.FocusedRowHandle
        Dim ds As New DataSet
        If i = 1 Then
            ds = _load_data("select * from view_NhanVien where SD=1 order by MaNhanVien")
        ElseIf i = 2 Then
            ds = _load_data("select * from view_NhanVien order by MaNhanVien")
        End If

        dgvNhanVien.DataSource = ds.Tables(0)
        lbl_MaNhanVien.DataBindings.Clear()
        lblNgaySinh.DataBindings.Clear()
        lblNoiSinh.DataBindings.Clear()
        lbl_ngayvaolam.DataBindings.Clear()
        lblChucvu.DataBindings.Clear()
        lblEmail.DataBindings.Clear()
        lblDienThoai.DataBindings.Clear()
        lblNoilamviec.DataBindings.Clear()
        lbl_HoTen.DataBindings.Clear()

        lbl_MaNhanVien.DataBindings.Add("text", ds.Tables(0), "MaNhanVien")
        lblNgaySinh.DataBindings.Add("text", ds.Tables(0), "NgaySinh")
        lblNoiSinh.DataBindings.Add("text", ds.Tables(0), "NoiSinh")
        lbl_ngayvaolam.DataBindings.Add("text", ds.Tables(0), "NgayNhanViec")
        lblChucvu.DataBindings.Add("text", ds.Tables(0), "ChucVu")
        lblEmail.DataBindings.Add("text", ds.Tables(0), "Email")
        lblDienThoai.DataBindings.Add("text", ds.Tables(0), "DienThoai")
        lblNoilamviec.DataBindings.Add("text", ds.Tables(0), "PhongBan")
        lbl_HoTen.DataBindings.Add("text", ds.Tables(0), "TenNV")
        AdvBandedGridView2.FocusedRowHandle = y
    End Sub

    Public Sub LOAD_DANTOC()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_DanToc order by DanToc")
        cboDanToc.DataSource = ds.Tables(0)
        cboDanToc.DisplayMember = "DanToc"
        cboDanToc.ValueMember = "MaDanToc"
    End Sub

    Public Sub LOAD_PHONGBAN()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_PhongBan order by PhongBan")
        cbo_PhongBan.DataSource = ds.Tables(0)
        cbo_PhongBan.DisplayMember = "PhongBan"
        cbo_PhongBan.ValueMember = "MaPhongBan"
    End Sub

    Public Sub LOAD_CHUCVU()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_ChucVu order by ChucVu")
        cboChucVu.DataSource = ds.Tables(0)
        cboChucVu.DisplayMember = "ChucVu"
        cboChucVu.ValueMember = "MaChucVu"
    End Sub

    Public Sub LOAD_NOICAP()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_TinhThanh order by TinhThanh")
        cboNoiCap.DataSource = ds.Tables(0)
        cboNoiCap.DisplayMember = "TinhThanh"
        cboNoiCap.ValueMember = "TinhThanh"
    End Sub

    Public Sub LOAD_TINHTHANH()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_TinhThanh order by TinhThanh")
        cboTinhThanh.DataSource = ds.Tables(0)
        cboTinhThanh.DisplayMember = "TinhThanh"
        cboTinhThanh.ValueMember = "TinhThanh"
    End Sub

    Public Sub LOAD_TONGIAO()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_TonGiao order by TonGiao")
        cboTonGiao.DataSource = ds.Tables(0)
        cboTonGiao.DisplayMember = "TonGiao"
        cboTonGiao.ValueMember = "MaTonGiao"
    End Sub

    Public Sub LOAD_TRINHDO()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_TrinhDo order by TrinhDo")
        cboHocVan.DataSource = ds.Tables(0)
        cboHocVan.DisplayMember = "TrinhDo"
        cboHocVan.ValueMember = "MaTrinhDo"
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        start_thearing()
        Dim f As New FRM_THEM_NHANVIEN
        f.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên " & _getdata("select TenNV from tbl_NhanVien where MaNhanVien='" & lbl_MaNhanVien.Text & "'") & " này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_HopDong_LaoDong where MaNhanVien='" & lbl_MaNhanVien.Text & "'")
            _Delete("delete from tbl_NhanVien_BaoHiem where MaNhanVien='" & lbl_MaNhanVien.Text & "'")
            _Delete("delete from tbl_NhanVien_ThaiSan where MaNhanVien='" & lbl_MaNhanVien.Text & "'")
            _Delete("delete from tbl_DangKy_TangCa where MaNhanVien='" & lbl_MaNhanVien.Text & "'")
            _Delete("delete from tbl_NhanVien where MaNhanVien='" & lbl_MaNhanVien.Text & "'")
            LOAD_NHANVIEN()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_NHANVIEN()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView2.RowCount - 1
            dr = AdvBandedGridView2.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                _Update("update tbl_NhanVien set TenNV=N'" & dr("TenNV") & "',NoiSinh=N'" & dr("NoiSinh") & "',NgaySinh='" & dr("NgaySinh") & "',TinhTrang=N'" & dr("TinhTrang") _
                        & "',DiaChi=N'" & dr("DiaChi") & "',DiaChi_TamTru=N'" & dr("DiaChi_TamTru") & "',SoCMND='" & dr("SoCMND") & "',NoiCap=N'" & dr("NoiCap") & "',NgayCap='" _
                        & dr("NgayCap") & "',NgayNhanViec='" & dr("NgayNhanViec") & "',MaTonGiao='" & dr("MaTonGiao") & "',MaDanToc='" & dr("MaDanToc") & "',MaPhongBan='" _
                        & dr("MaPhongBan") & "',MaTrinhDo='" & dr("MaTrinhDo") & "',MaChucVu='" & dr("MaChucVu") & "',GhiChu=N'" & dr("GhiChu") & "',Email='" & dr("Email") _
                        & "',DienThoai='" & dr("DienThoai") & "' where MaNhanVien='" & dr("MaNhanVien") & "'")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lbl_MaNhanVien.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub

    Private Sub NavBarItem1_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        start_thearing()
        Dim f As New FRM_THEM_NHANVIEN
        f.Show()
    End Sub

    Private Sub lblNgaySinh_TextChanged(sender As Object, e As EventArgs) Handles lblNgaySinh.TextChanged
        Try
            lblNgaySinh.Text = CDate(lblNgaySinh.Text).Date
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblNoilamviec_TextChanged(sender As Object, e As EventArgs) Handles lbl_ngayvaolam.TextChanged
        Try
            lbl_ngayvaolam.Text = CDate(lbl_ngayvaolam.Text).Date
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbl_MaNhanVien_TextChanged(sender As Object, e As EventArgs) Handles lbl_MaNhanVien.TextChanged
        Dim strThangLam, strNamLam As String
        strThangLam = _getdata("select ThangLam from view_NhanVien where MaNhanVien='" & lbl_MaNhanVien.Text & "'")
        strNamLam = _getdata("select NamLam from view_NhanVien where MaNhanVien='" & lbl_MaNhanVien.Text & "'")
        If strThangLam = 0 And strNamLam = 0 Then
            lbl_thamnien.Text = ""
        Else
            lbl_thamnien.Text = strThangLam & " tháng " & strNamLam & " năm"
        End If

        Try
            PictureBox1.Load(strHinh_NV & lbl_MaNhanVien.Text & ".jpg")
        Catch ex As Exception
            PictureBox1.Load(Application.StartupPath & "\img\No_Image.jpg")
        End Try
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        strMaNhanVien = lbl_MaNhanVien.Text
        Dim f As New FRM_ADD_DIEUDONG_NV
        f.ShowDialog()
    End Sub

    Private Sub NavBarItem6_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem6.LinkClicked
        strMaNhanVien = lbl_MaNhanVien.Text
        Dim f As New FRM_ADD_NHANVIEN_NGHIVIEC
        f.ShowDialog()
    End Sub

    Private Sub NavBarItem2_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        strMaNhanVien = lbl_MaNhanVien.Text
        Dim f As New FRM_DANGKY_TANGCA
        f.ShowDialog()
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        i = 2
        LOAD_NHANVIEN()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        reports = 1
        flag = 1
        dsReports = _load_data("select * from view_NhanVien where SD=1 order by Ten")
        Dim f As New FRM_REPORT
        f.Show()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        reports = 1
        flag = 2
        dsReports = _load_data("select * from view_NhanVien where SD=0 order by Ten")
        Dim f As New FRM_REPORT
        f.Show()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        SaveFileDialog1.Filter = "Excel files |*.xlsx"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim strLenh As String = "select MaNhanVien,HoNV,Ten,Phai,NgaySinh,NoiSinh,NgayNhanViec,SoCMND,NgayCap,NoiCap,TonGiao,DanToc,DiaChi from view_NhanVien"
            ExportToExcel(GetDatatable(strLenh), SaveFileDialog1.FileName)
            System.Diagnostics.Process.Start(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub NavBarItem5_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem5.LinkClicked
        strMaNhanVien = lbl_MaNhanVien.Text
        Dim f As New FRM_THEM_DANGKYTHE
        f.ShowDialog()
    End Sub
End Class