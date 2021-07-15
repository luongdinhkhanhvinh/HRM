Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_THEM_NHANVIEN

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
        start = True
    End Sub

#End Region

    '#Region "XuLy"
    '    Public Delegate Sub process_data()
    '    Dim th_NhanDuLieu As Thread
    '    Public Sub XuLy()
    '        Try
    '            While True
    '                If start1 = True Then
    '                    Me.BeginInvoke(New process_data(AddressOf loadNhanVien))
    '                End If
    '                start1 = False
    '                Thread.Sleep(300)
    '            End While
    '        Catch ex As Exception

    '        End Try
    '    End Sub

    '    Public Sub start_thearing()
    '        th_NhanDuLieu = New Thread(AddressOf XuLy)
    '        th_NhanDuLieu.IsBackground = True
    '        th_NhanDuLieu.Start()
    '    End Sub
    '#End Region

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

#Region "DanhMuc"
    Public Sub LOAD_DANTOC()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_DanToc order by DanToc")
        cbo_DanToc.Properties.DataSource = ds.Tables(0)
        cbo_DanToc.Properties.DisplayMember = "DanToc"
        cbo_DanToc.Properties.ValueMember = "MaDanToc"
    End Sub

    Public Sub LOAD_TONGIAO()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_TonGiao order by TonGiao")
        cbo_TonGiao.Properties.DataSource = ds.Tables(0)
        cbo_TonGiao.Properties.DisplayMember = "TonGiao"
        cbo_TonGiao.Properties.ValueMember = "MaTonGiao"
    End Sub

    Public Sub LOAD_PHONGBAN()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_PhongBan order by PhongBan")
        cbo_PhongBan.Properties.DataSource = ds.Tables(0)
        cbo_PhongBan.Properties.DisplayMember = "PhongBan"
        cbo_PhongBan.Properties.ValueMember = "MaPhongBan"
    End Sub

    Public Sub LOAD_CHUCVU()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_ChucVu order by ChucVu")
        cbo_ChucVu.Properties.DataSource = ds.Tables(0)
        cbo_ChucVu.Properties.DisplayMember = "ChucVu"
        cbo_ChucVu.Properties.ValueMember = "MaChucVu"
    End Sub

    Public Sub LOAD_TRINHDOVANHOA()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_TrinhDo order by TrinhDo")
        cbo_TrinhDo.Properties.DataSource = ds.Tables(0)
        cbo_TrinhDo.Properties.DisplayMember = "TrinhDo"
        cbo_TrinhDo.Properties.ValueMember = "MaTrinhDo"
    End Sub

    Public Sub LOAD_NOISINH()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_TinhThanh order by TinhThanh")
        cbo_NoiSinh.Properties.DataSource = ds.Tables(0)
        cbo_NoiSinh.Properties.DisplayMember = "TinhThanh"
    End Sub

    Public Sub LOAD_NOICAP()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_TinhThanh order by TinhThanh")
        cbo_NoiCap.Properties.DataSource = ds.Tables(0)
        cbo_NoiCap.Properties.DisplayMember = "TinhThanh"
    End Sub
#End Region


    Private Sub FRM_THEM_NHANVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
        LOAD_DANTOC()
        LOAD_TONGIAO()
        LOAD_PHONGBAN()
        LOAD_CHUCVU()
        LOAD_TRINHDOVANHOA()
        LOAD_NOISINH()
        LOAD_NOICAP()
        txt_NgayCap.Text = Now.Date
        txt_NgayNhanViec.Text = Now.Date
        txt_NgaySinh.Text = Now.Date
    End Sub

    Public Sub LUU_NHANVIEN()
        If txt_MaNV.Text.Length > 0 Then
            If txt_HoVaTen.Text.Length > 0 Then
                If txt_SoCMND.Text.Length > 0 Then
                    If cbo_ChucVu.Text.Length > 0 Then
                        If cbo_DanToc.Text.Length > 0 Then
                            If cbo_NoiCap.Text.Length > 0 Then
                                If cbo_NoiSinh.Text.Length > 0 Then
                                    If cbo_PhongBan.Text.Length > 0 Then
                                        If cbo_TonGiao.Text.Length > 0 Then
                                            Dim strGioiTinh As String
                                            If chkGioiTinh.Checked = True Then
                                                strGioiTinh = 1
                                            Else
                                                strGioiTinh = 0
                                            End If
                                            If _kiemtra("select count(*) from tbl_NhanVien where MaNhanVien='" & txt_MaNV.Text & "'") = 0 Then
                                                _Save("insert into tbl_NhanVien(MaNhanVien,TenNV,GioiTinh,NgaySinh,NoiSinh,DiaChi,DiaChi_TamTru,SoCMND,NoiCap,NgayCap,NgayNhanViec, " & _
                                                 "MaTonGiao,MaDanToc,MaPhongBan,MaChucVu,MaTrinhDo,TinhTrang,Email,DienThoai,SD) values ('" & txt_MaNV.Text & "',N'" & txt_HoVaTen.Text & "','" _
                                                 & strGioiTinh & "','" & txt_NgaySinh.Text & "',N'" & cbo_NoiSinh.Text & "',N'" & txt_DiaChi.Text & "',N'" & txt_DiaChi_TamTru.Text & "','" _
                                                 & txt_SoCMND.Text & "',N'" & cbo_NoiCap.Text & "','" & txt_NgayCap.Text & "','" & txt_NgayNhanViec.Text & "','" & cbo_TonGiao.EditValue.ToString & "','" _
                                                 & cbo_DanToc.EditValue.ToString & "','" & cbo_PhongBan.EditValue.ToString & "','" & cbo_ChucVu.EditValue.ToString & "','" & cbo_TrinhDo.EditValue.ToString _
                                                 & "',N'" & cbo_TinhTrang.Text & "','" & txt_Email.Text & "','" & txt_SoDT.Text & "',1)")
                                                XOATEXT()
                                                f = True
                                                start_thearing_send()
                                            Else
                                                XtraMessageBox.Show("Mã nhân viên này đã tồn tại, vui lòng nhập vào mã nhân viên khác.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                txt_MaNV.Focus()
                                            End If
                                        Else
                                            XtraMessageBox.Show("Bạn phải chọn tên tôn giáo nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            cbo_TonGiao.Focus()
                                        End If
                                    Else
                                        XtraMessageBox.Show("Bạn phải chọn tên phòng ban nhân viên làm việc.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        cbo_PhongBan.Focus()
                                    End If
                                Else
                                    XtraMessageBox.Show("Bạn phải chọn nơi sinh của nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    cbo_NoiSinh.Focus()
                                End If
                            Else
                                XtraMessageBox.Show("Bạn phải chọn nơi cấp số chứng minh nhân dân của nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                cbo_NoiCap.Focus()
                            End If
                        Else
                            XtraMessageBox.Show("Bạn phải chọn tên dân tộc cho nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            cbo_DanToc.Focus()
                        End If
                    Else
                        XtraMessageBox.Show("Bạn phải chọn tên chức vụ cho nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        cbo_ChucVu.Focus()
                    End If
                Else
                    XtraMessageBox.Show("Bạn phải nhập vào số chứng mưng nhân dân.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt_SoCMND.Focus()
                End If
            Else
                XtraMessageBox.Show("Bạn phải nhập vào tên nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_HoVaTen.Focus()
            End If
        Else
            XtraMessageBox.Show("Bạn phải nhập vào mã nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_MaNV.Focus()
        End If
    End Sub

    Private Sub btnluu_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        LUU_NHANVIEN()
    End Sub

    Public Sub XOATEXT()
        txt_DiaChi.Text = ""
        txt_DiaChi_TamTru.Text = ""
        txt_Email.Text = ""
        txt_HoVaTen.Text = ""
        txt_SoCMND.Text = ""
        txt_NgayCap.Text = Now.Date
        txt_NgayNhanViec.Text = Now.Date
        txt_NgaySinh.Text = Now.Date
        txt_SoDT.Text = ""
        cbo_ChucVu.EditValue = DBNull.Value
        cbo_DanToc.EditValue = DBNull.Value
        cbo_NhomLaoDong.EditValue = DBNull.Value
        cbo_NoiCap.Text = ""
        cbo_PhongBan.EditValue = DBNull.Value
        cbo_TinhTrang.Text = ""
        cbo_TonGiao.EditValue = DBNull.Value
        cbo_TrinhDo.EditValue = DBNull.Value
        cbo_NoiSinh.Text = ""
        With txt_MaNV
            .Text = ""
            .Focus()
        End With
    End Sub
End Class