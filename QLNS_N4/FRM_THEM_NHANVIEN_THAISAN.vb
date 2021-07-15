Imports DevExpress.XtraEditors
Imports System.Threading
Public Class FRM_THEM_NHANVIEN_THAISAN

    Private Sub FRM_THEM_NHANVIEN_THAISAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
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

    Public Sub loadThongTin()
        txt_TenNV.Text = _getdata("select distinct tennv from view_nhanvien where MaNhanVien='" & txt_MaNV.Text & "' and gioitinh=0 and sd=1")
        txt_TenPX.Text = _getdata("select distinct phongban from view_nhanvien where MaNhanVien='" & txt_MaNV.Text & "' and gioitinh=0 and sd=1")
    End Sub

    Private Sub txt_MaNV_Leave(sender As Object, e As EventArgs) Handles txt_MaNV.Leave
        loadThongTin()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txt_MaNV.Text.Length > 0 Then
            If CInt(txtLanMangThai.Text) > 0 Then
                _Save("insert into tbl_NhanVien_ThaiSan(MaNhanVien,LanMangThai,NgayNghi_ThaiSan,NgayLamLai,GhiChu,MaLoaiTrangThai) values ('" & txt_MaNV.Text & "','" _
                      & txtLanMangThai.Text & "','" & txtNgayNghi.Text & "','" & txtNgayLamLai.Text & "',N'" & txtGhiChu.Text & "',1)")
                XOATEXT()
                f = True
                start_thearing_send()
            Else
                XtraMessageBox.Show("Bạn phải nhập vào lần mang thai.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtLanMangThai.Focus()
            End If
        Else
            XtraMessageBox.Show("Bạn phải nhập vào mã số nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_MaNV.Focus()
        End If
    End Sub

    Public Sub XOATEXT()
        txtGhiChu.Text = ""
        txt_TenNV.Text = ""
        txt_TenPX.Text = ""
        txtNgayLamLai.Text = Now.Date
        txtNgayNghi.Text = Now.Date
    End Sub
End Class