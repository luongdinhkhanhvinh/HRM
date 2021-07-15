Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_ADD_HOPDONG


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
        txtLuongCoBan.Text = _getdata("select LuongBaoHiem from tbl_ThamSo")
    End Sub

    Public Sub LOAIHOPDONG()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_LoaiHopDong")
        cboLoaiHopDong.Properties.DataSource = ds.Tables(0)
        cboLoaiHopDong.Properties.DisplayMember = "LoaiHopDong"
        cboLoaiHopDong.Properties.ValueMember = "MaLoaiHopDong"
    End Sub

    Private Sub FRM_ADD_HOPDONG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
        LOAIHOPDONG()
    End Sub

    Private Sub txt_MaNV_Leave(sender As Object, e As EventArgs) Handles txt_MaNV.Leave
        loadThongTin()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtLuongCoBan.Text.Length > 0 Then
            If txtSoBHXH.Text.Length > 0 Then
                If cboLoaiHopDong.Text.Length > 0 Then
                    If _kiemtra("select count(*) from tbl_HopDong_LaoDong where SoHopDong='" & txtSoBHXH.Text & "'") = 0 Then
                        _Save("insert into tbl_HopDong_LaoDong(MaNhanVien,SoHopDong,MaLoaiHopDong,NgayKyHD,GhiChu,LuongCoBan) values ('" & txt_MaNV.Text & "','" _
                        & txtSoBHXH.Text & "','" & cboLoaiHopDong.EditValue.ToString & "','" & txtNgayKy.Text & "',N'" & txt_ghichu.Text & "','" & txtLuongCoBan.Text & "')")
                        txt_MaNV.Text = ""
                        XtraMessageBox.Show("Đã cập nhật thành công.")
                        f = True
                        start_thearing_send()
                    Else
                        XtraMessageBox.Show("Số hợp đồng này đã tồn tại.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtSoBHXH.Focus()
                    End If
                  
                Else
                    XtraMessageBox.Show("Bạn phải chọn loại hợp đồng lao động.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cboLoaiHopDong.Focus()
                End If
            Else
                XtraMessageBox.Show("Bạn phải nhập vào số sổ bảo hiểm xã hội", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSoBHXH.Focus()
            End If
        Else
            XtraMessageBox.Show("Bạn vui lòng nhập vào lương bảo hiểm xã hội.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLuongCoBan.Focus()
        End If
    End Sub
End Class