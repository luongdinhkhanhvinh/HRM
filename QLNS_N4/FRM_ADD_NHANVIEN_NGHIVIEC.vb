Imports DevExpress.XtraEditors
Imports System.Threading
Public Class FRM_ADD_NHANVIEN_NGHIVIEC


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

    Public Sub loadThongTin(strMaNhanVien As String)
        txt_TenNV.Text = _getdata("select TenNV from view_nhanvien where MaNhanVien='" & strMaNhanVien & "' and SD=1")
        txt_TenPX.Text = _getdata("select PhongBan from view_nhanvien where MaNhanVien='" & strMaNhanVien & "' and SD=1")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txtGhiChu.Text.Length > 0 Then
            _Save("insert into tbl_NhanVien_NghiViec(MaNhanVien,NgayNopDon,NgayNghiViec,LyDo) values ('" & txt_MaNV.Text & "','" & txtNgayNopDon.Text & "','" _
                  & txtNgayNghi.Text & "',N'" & txtGhiChu.Text & "')")

            'dua ve danh sach nghi viec
            txtGhiChu.Text = ""

            With txt_MaNV
                .Text = ""
                .Focus()
            End With
            f = True
            start_thearing_send()
        Else
            XtraMessageBox.Show("Bạn phải nhập vào lý do nghĩ việc của nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGhiChu.Focus()
        End If
    End Sub

    Private Sub FRM_ADD_NHANVIEN_NGHIVIEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
        txtNgayNghi.Text = Now.Date
        txtNgayNopDon.Text = Now.Date
        loadThongTin(strMaNhanVien)
        txt_MaNV.Text = strMaNhanVien
    End Sub

    Private Sub txt_MaNV_Leave(sender As Object, e As EventArgs) Handles txt_MaNV.Leave
        loadThongTin(txt_MaNV.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class