Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_USER

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim f As New FRM_ADD_USER
        f.Show()
    End Sub

    Private Sub FRM_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_USER()
    End Sub

    Public Sub LOAD_USER()
        Dim ds As New DataSet
        ds = _load_data("select * from view_User order by TenDangNhap")
        dgv_User.DataSource = ds.Tables(0)
        lbl_TenDangNhap.DataBindings.Clear()
        lbl_TenDangNhap.DataBindings.Add("text", ds.Tables(0), "TenDangNhap")
    End Sub

    Public Sub LOAD_CAPQUYEN()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_CapQuyen where TenDangNhap='" & lbl_TenDangNhap.Text & "'")
        dgv_CapQuyen.DataSource = ds.Tables(0)
        lblMaMeNu.DataBindings.Clear()
        lblMaMeNu.DataBindings.Add("text", ds.Tables(0), "MaMenu")
    End Sub

    Private Sub lbl_TenDangNhap_TextChanged(sender As Object, e As EventArgs) Handles lbl_TenDangNhap.TextChanged
        LOAD_CAPQUYEN()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa tên đăng nhập này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_CapQuyen where TenDangNhap='" & lbl_TenDangNhap.Text & "'")
            _Delete("delete from tbl_User where TenDangNhap='" & lbl_TenDangNhap.Text & "'")
            LOAD_USER()
        End If
    End Sub

    Private Sub btnNaplai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNaplai.ItemClick
        LOAD_CAPQUYEN()
        LOAD_USER()
    End Sub
End Class