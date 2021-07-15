Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_BAOHIEM

#Region "XuLy nhan du lieu"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf LOAD_NHANVIEN_BHXH))
                    Me.BeginInvoke(New process_data(AddressOf LOAD_CHITIET_BAOHIEM))
                    start = False
                End If
                Thread.Sleep(300)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub start_thearing_nhan()
        th_NhanDuLieu = New Thread(AddressOf XuLy)
        th_NhanDuLieu.IsBackground = True
        th_NhanDuLieu.Start()
    End Sub

#End Region

    Public Sub LOAD_NHANVIEN_BHXH()
        Dim y As Integer
        y = AdvBandedGridView2.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select distinct MaNhanVien,HoNV,Ten,Phai,NgaySinh,NgayNhanViec,PhongBan from view_NhanVien_BaoHiem")
        dgv_NhanVien_BHXH.DataSource = ds.Tables(0)
        lbl_MaNV.DataBindings.Clear()
        lbl_MaNV.DataBindings.Add("text", ds.Tables(0), "MaNhanVien")
        AdvBandedGridView2.FocusedRowHandle = y
    End Sub

    Public Sub LOAD_CHITIET_BAOHIEM()
        Dim ds As New DataSet
        ds = _load_data("select * from view_NhanVien_BaoHiem order by MaNhanVien")
        dgv_ChiTiet_BHXH.DataSource = ds.Tables(0)
        lblSTT.DataBindings.Clear()
        lblSTT.DataBindings.Add("text", ds.Tables(0), "STT")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        start_thearing_nhan()
        Dim f As New FRM_ADD_NHANVIEN_BAOHIEM
        f.Show()
    End Sub

    Private Sub FRM_BAOHIEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_NHANVIEN_BHXH()
    End Sub

    Private Sub lbl_MaNV_TextChanged(sender As Object, e As EventArgs) Handles lbl_MaNV.TextChanged
        LOAD_CHITIET_BAOHIEM()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn có muốn xóa nhân viên đăng ký bảo hiểm này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_NhanVien_BaoHiem where STT='" & lblSTT.Text & "'")
            LOAD_CHITIET_BAOHIEM()
            LOAD_NHANVIEN_BHXH()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_NHANVIEN_BHXH()
        LOAD_NHANVIEN_BHXH()
    End Sub
End Class