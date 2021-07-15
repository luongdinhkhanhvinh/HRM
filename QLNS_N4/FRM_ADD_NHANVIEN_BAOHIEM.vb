Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_ADD_NHANVIEN_BAOHIEM

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
        txt_TenNV.Text = _getdata("select distinct TenNV from view_NhanVien where SD=1 and MaNhanVien='" & txt_MaNV.Text & "'")
        txt_TenPX.Text = _getdata("select distinct PhongBan from view_NhanVien where SD=1 and MaNhanVien='" & txt_MaNV.Text & "'")
        txtLuongBaoHiem.Text = _getdata("select LuongBaoHiem from tbl_ThamSo")
        If _kiemtra("select count(*) from tbl_NhanVien_BaoHiem where MaNhanVien='" & txt_MaNV.Text & "'") > 0 Then
            txtNgayLapSo.Text = _getdata("select distinct NgayLapSo from tbl_NhanVien_BaoHiem where MaNhanVien='" & txt_MaNV.Text & "'")
            txtSoBHXH.Text = _getdata("select distinct MaSoBHXH from tbl_NhanVien_BaoHiem where MaNhanVien='" & txt_MaNV.Text & "'")
            txtNgayLapSo.Properties.ReadOnly = True
            txtSoBHXH.Properties.ReadOnly = True
        Else
            txtNgayLapSo.Properties.ReadOnly = False
            txtSoBHXH.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtLuongBaoHiem.Text.Length > 0 Then
            If txtSoBHXH.Text.Length > 0 Then
                Dim CdecBHXH, CdecBHYT, CdecBHTN As Decimal
                CdecBHXH = _getdata("select TyleBHXH from tbl_ThamSo")
                CdecBHYT = _getdata("select TyLeBHYT from tbl_ThamSo")
                CdecBHTN = _getdata("select TyLeBHTN from tbl_ThamSo")
                _Save("insert into tbl_NhanVien_BaoHiem(MaNhanVien,NgayDangKy,NgayLapSo,LuongBaoHiem,TyLeBHXH,TyLeBHTN,TyLeBHYT,GhiChu,MaSoBHXH) values ('" _
                      & txt_MaNV.Text & "','" & txtNgayThamGia.Text & "','" & txtNgayLapSo.Text & "','" & txtLuongBaoHiem.Text & "','" & CdecBHXH & "','" & CdecBHYT & "','" _
                      & CdecBHTN & "',N'" & txt_ghichu.Text & "','" & txtSoBHXH.Text & "')")
                txt_MaNV.Text = ""
                XtraMessageBox.Show("Đã cập nhật thành công.")
                f = True
                start_thearing_send()
            Else
                XtraMessageBox.Show("Bạn phải nhập vào số sổ bảo hiểm xã hội", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSoBHXH.Focus()
            End If
        Else
            XtraMessageBox.Show("Bạn vui lòng nhập vào lương bảo hiểm xã hội.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLuongBaoHiem.Focus()
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub txt_MaNV_Leave(sender As Object, e As EventArgs) Handles txt_MaNV.Leave
        loadThongTin()
    End Sub

    Private Sub FRM_ADD_NHANVIEN_BAOHIEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
        txtNgayThamGia.Text = Now.Date
        txtNgayLapSo.Text = Now.Date
    End Sub
End Class