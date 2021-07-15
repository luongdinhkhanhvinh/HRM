Imports System.Threading
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Public Class FRM_ADD_USER

    Public Sub luu()
        Dim s As String = "insert into tbl_User(TenDangNhap,MatKhau,MaNhanVien,TruyCap) values ('" & txt_tendangnhap.Text & "','" & md5(txt_matkhau.Text) & "','" & txt_MaNV.Text & "',1)"
        open_connect()
        Dim cmd As New SqlCommand(s, strconnect)
        cmd.ExecuteNonQuery()
        close_connect()
    End Sub

    Public Sub CapQuyen()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_capquyen where TenDangNhap='admin'")
        Dim dr As DataRow
        Dim mamenu, menu, phanhe As String
        For Each dr In ds.Tables(0).Rows
            mamenu = dr.Item("MaMeNu")
            menu = dr.Item("ChucNang")
            phanhe = dr.Item("PhanHe")

            _Save("insert into tbl_capquyen(mamenu,tendangnhap,chucnang,phanhe,xem,luu,xoa,sua,[in]) values ('" & mamenu & "','" _
                  & txt_tendangnhap.Text & "',N'" & menu & "',N'" & phanhe & "','0','0','0','0',0)")
        Next
    End Sub

#Region "XuLy"
    Public Delegate Sub GoiDuLieuXuLy()
    Dim th_GoiDuLieu As Thread

    Public Sub start_thearing()
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
        If txt_tendangnhap.Text.Length > 0 Then
            If txt_MaNV.Text.Length > 0 Then
                If _kiemtra("select count(*) from tbl_user where tendangnhap='" & txt_tendangnhap.Text & "'") = 0 Then
                    luu()
                    CapQuyen()
                    f = True
                    start_thearing()
                    XtraMessageBox.Show("Đã tạo người dùng thành công.")
                Else
                    XtraMessageBox.Show("Tên đăng nhập này đã tồn tại, vui lòng nhập tên khác.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt_tendangnhap.Focus()
                End If
            Else
                XtraMessageBox.Show("Bạn phải nhập vào mã nhân viên.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_MaNV.Focus()
            End If
        Else
            XtraMessageBox.Show("Bạn phải nhập vào tên đăng nhập.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_tendangnhap.Focus()
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txt_matkhau.Text = txt_tendangnhap.Text.ToLower
            txt_matkhau.Properties.ReadOnly = True
            txt_xacnhan_matkhau.Properties.ReadOnly = True
        Else
            txt_matkhau.Text = ""
            txt_matkhau.Properties.ReadOnly = False
            txt_xacnhan_matkhau.Properties.ReadOnly = False
        End If
    End Sub

    Private Sub txt_MaNV_Leave(sender As Object, e As EventArgs) Handles txt_MaNV.Leave
        lbl_TenNV.Text = _getdata("select TenNV from tbl_NhanVien where MaNhanVien='" & txt_MaNV.Text & "'")
        lbl_TenPB.Text = _getdata("select PhongBan from view_NhanVien where MaNhanVien='" & txt_MaNV.Text & "'")
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub

    Private Sub FRM_ADD_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
    End Sub
End Class