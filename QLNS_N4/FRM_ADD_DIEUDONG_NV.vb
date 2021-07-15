Imports DevExpress.XtraEditors
Imports System.Threading
Public Class FRM_ADD_DIEUDONG_NV

    Public Sub LOAD_CHUCVU()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_chucvu order by chucvu")
        cbo_chucvu.Properties.DataSource = ds.Tables(0)
        cbo_chucvu.Properties.DisplayMember = "ChucVu"
        cbo_chucvu.Properties.ValueMember = "MaChucVu"
    End Sub

    Public Sub LOAD_PHONGBAN()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_PhongBan order by PhongBan")
        cbo_phongban.Properties.DataSource = ds.Tables(0)
        cbo_phongban.Properties.DisplayMember = "PhongBan"
        cbo_phongban.Properties.ValueMember = "MaPhongBan"
    End Sub

    Public Sub loadThongTin()
        txt_MaNV.Text = txt_MaNV.Text
        txt_TenNV.Text = _getdata("select tennv from view_nhanvien where MaNhanVien='" & txt_MaNV.Text & "'")
        txt_TenPX.Text = _getdata("select phongban from view_nhanvien where MaNhanVien='" & txt_MaNV.Text & "'")
        txt_ChucVu.Text = _getdata("select chucvu from view_nhanvien where MaNhanVien='" & txt_MaNV.Text & "'")
        lblGioiTinh.Text = _getdata("select phai from view_nhanvien where MaNhanVien='" & txt_MaNV.Text & "'")
    End Sub

    Private Sub txt_MaNV_Leave(sender As Object, e As EventArgs) Handles txt_MaNV.Leave
        loadThongTin()
    End Sub

    Private Sub FRM_ADD_DIEUDONG_NV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
        LOAD_CHUCVU()
        LOAD_PHONGBAN()
    End Sub

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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txt_MaNV.Text.Length > 0 Then
            If cbo_phongban.Text.Length > 0 Then
                If cbo_chucvu.Text.Length > 0 Then
                    Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn thuyên chuyển nhân viên này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dgrResult = Windows.Forms.DialogResult.Yes Then
                        _Save("insert into tbl_DieuDong_NhanVien(MaNhanVien,NgayDieuDong,PhongBan,ChucVu,GhiChu) values ('" & txt_MaNV.Text & "','" & txt_NgayDangKy.Text & "',N'" & cbo_phongban.Text & "',N'" & cbo_chucvu.Text & "',N'" & txt_ghichu.Text & "')")
                        'cap nhat lai danh sach nhan vien
                        _Update("update tbl_NhanVien set MaPhongBan='" & cbo_phongban.EditValue.ToString & "',MaChucVu='" & cbo_chucvu.EditValue.ToString & "' where MaNhanVien='" & txt_MaNV.Text & "'")
                        XtraMessageBox.Show("Đã thuyên chuyển nhân viên " & txt_TenNV.Text & " sang bộ phận khác thành công.")
                        XOATEXT()
                        f = True
                        start_thearing_send()
                    End If
                Else
                    XtraMessageBox.Show("Bạn phải chọn chức vụ cần chuyển đến.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbo_chucvu.Focus()
                End If
            Else
                XtraMessageBox.Show("Bạn phải chọn phòng ban mà nhân viên chuyển đến.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbo_phongban.Focus()
            End If
        Else
            XtraMessageBox.Show("Bạn phải nhập vào mã nhân viên để thực hiện.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_MaNV.Focus()
        End If
    End Sub

    Public Sub XOATEXT()
        txt_MaNV.Text = ""
        cbo_chucvu.EditValue = DBNull.Value
        cbo_phongban.EditValue = DBNull.Value
        txt_ghichu.Text = ""
        txt_MaNV.Focus()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class