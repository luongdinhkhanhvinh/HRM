Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_DANGKYTHE_NHANVIEN

    Public Sub LOAD_LOAIDANGKYTHE()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_LoaiDangKyThe order by LoaiDangKy")
        cbo_LoaiMatThe.DataSource = ds.Tables(0)
        cbo_LoaiMatThe.DisplayMember = "LoaiDangKy"
        cbo_LoaiMatThe.ValueMember = "MaLoai"
    End Sub

    Private Sub FRM_DANGKYTHE_NHANVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_NHANVIEN()
        LOAD_LOAIDANGKYTHE()
    End Sub

    Public Sub LOAD_NHANVIEN()
        Dim y As Integer
        y = AdvBandedGridView1.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from view_DangKyThe_NhanVien order by MaNhanVien")
        dgv_DANGKY_NGHIPHEP.DataSource = ds.Tables(0)
        lbl_STT.DataBindings.Clear()
        lbl_MaNhanVien.DataBindings.Clear()

        lbl_STT.DataBindings.Add("text", ds.Tables(0), "STT")
        lbl_MaNhanVien.DataBindings.Add("text", ds.Tables(0), "MaNhanVien")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        start_thearing()
        Dim f As New FRM_THEM_DANGKYTHE
        f.ShowDialog()
    End Sub

#Region "XuLy"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf LOAD_NHANVIEN))
                End If
                Thread.Sleep(300)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub start_thearing()
        th_NhanDuLieu = New Thread(AddressOf XuLy)
        th_NhanDuLieu.IsBackground = True
        th_NhanDuLieu.Start()
    End Sub
#End Region

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_NHANVIEN()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        lbl_STT.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên đăng ký thẻ này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_DangKy_The where STT='" & lbl_STT.Text & "'")
            LOAD_NHANVIEN()
        End If
    End Sub
End Class