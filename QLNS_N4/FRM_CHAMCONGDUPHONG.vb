Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_CHAMCONGDUPHONG

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

    Private Sub FRM_CHAMCONGDUPHONG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadThongTin(strMaNhanVien)
        txtNgayNopDon.Text = Now.Date
    End Sub

    Private Sub txt_MaNV_Leave(sender As Object, e As EventArgs) Handles txt_MaNV.Leave
        loadThongTin(txt_MaNV.Text)
    End Sub

    Dim s1, s2 As String
    Public Sub TACH_GIOPHUT()
        Dim a As String = txt_ThoiGian.Text
        Dim Arr As String() = a.Split(":"c)
        s1 = Arr(0)
        s2 = Arr(UBound(Arr))
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txt_MaNV.Text.Length > 0 Then
            TACH_GIOPHUT()
            _Save("insert into tbl_NhatKy_QuetThe(MaNhanVien,NgayQuetThe,Gio,Phut,ThoiGian,IP) values ('" & txt_MaNV.Text & "','" & txtNgayNopDon.Text & "','" & s1 & "','" & s2 & "','" & txt_ThoiGian.Text & "','" & strTenDangNhap.ToUpper & "')")
            XtraMessageBox.Show("Đã chấm công thành công")
            f = True
            start_thearing_send()
        Else
            XtraMessageBox.Show("Bạn phải nhập vào mã số nhân viên để tiến hành chấm công.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_MaNV.Focus()
        End If
    End Sub
End Class