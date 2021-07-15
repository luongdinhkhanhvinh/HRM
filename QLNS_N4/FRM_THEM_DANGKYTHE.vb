Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_THEM_DANGKYTHE

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

    Public Sub loadThongtin(strMaNV As String)
        txt_TenNV.Text = _getdata("select TenNV from view_nhanvien where MaNhanVien='" & strMaNV & "' and sd=1")
        txt_TenPX.Text = _getdata("select PhongBan from view_nhanvien where MaNhanVien='" & strMaNV & "' and sd=1")
    End Sub

    Private Sub FRM_THEM_DANGKYTHE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
        txt_NgayDangKy.Text = CDate(Now).Date
        LOAD_LOAIDANGKYTHE()
        loadThongtin(strMaNhanVien)
        txt_MaNV.Text = strMaNhanVien
    End Sub

    Public Sub LOAD_LOAIDANGKYTHE()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_LoaiDangKyThe order by LoaiDangKy")
        cbo_LoaiDangKy.Properties.DataSource = ds.Tables(0)
        cbo_LoaiDangKy.Properties.DisplayMember = "LoaiDangKy"
        cbo_LoaiDangKy.Properties.ValueMember = "MaLoai"
    End Sub

    Private Sub txt_MaNV_Leave(sender As Object, e As EventArgs) Handles txt_MaNV.Leave
        loadThongtin(txt_MaNV.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If txt_MaNV.Text.Length > 0 Then
            If cbo_LoaiDangKy.Text.Length > 0 Then
                _Save("insert into tbl_DangKy_The(MaNhanVien,NgayDangKy,GhiChu,TraThe,MaLoaiDangKy) values ('" & txt_MaNV.Text & "','" & txt_NgayDangKy.Text & "',N'" & txt_ghichu.Text & "','0','" & cbo_LoaiDangKy.EditValue.ToString & "')")

                XtraMessageBox.Show("Đã đăng ký thẻ cho nhân viên " & txt_TenNV.Text & ".")
                With txt_MaNV
                    .Text = ""
                    .Focus()
                End With
                f = True
                start_thearing_send()
            Else
                XtraMessageBox.Show("Bạn phải chọn tên loại đăng ký thẻ của nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbo_LoaiDangKy.Focus()
            End If
        Else
            XtraMessageBox.Show("Bạn phải nhập vào mã nhân viên để đăng ký thẻ.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Question)
            txt_MaNV.Focus()
        End If
    End Sub
End Class