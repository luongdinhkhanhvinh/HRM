Imports DevExpress.XtraEditors
Imports System.Threading
Public Class FRM_HOPDONG_LAODONG

#Region "XuLy nhan du lieu"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf LOAD_HOPDONG))
                    Me.BeginInvoke(New process_data(AddressOf LOAD_CHITIET_HOPDONG))
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

    Private Sub FRM_HOPDONG_LAODONG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_HOPDONG()
    End Sub

    Public Sub LOAD_HOPDONG()
        Dim y As Integer
        y = AdvBandedGridView2.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select distinct MaNhanVien,HoNV,Ten,Phai,NgaySinh,NgayNhanViec,PhongBan from view_HopDong")
        dgv_NhanVien_BHXH.DataSource = ds.Tables(0)
        lbl_MaNV.DataBindings.Clear()
        lbl_MaNV.DataBindings.Add("text", ds.Tables(0), "MaNhanVien")
        AdvBandedGridView2.FocusedRowHandle = y
    End Sub

    Public Sub LOAD_CHITIET_HOPDONG()
        Dim ds As New DataSet
        ds = _load_data("select * from view_HopDong order by MaNhanVien")
        dgv_ChiTiet_BHXH.DataSource = ds.Tables(0)
        lbl_STT.DataBindings.Clear()
        lbl_STT.DataBindings.Add("text", ds.Tables(0), "STT")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim f As New FRM_ADD_HOPDONG
        f.Show()
    End Sub

    Private Sub lbl_MaNV_TextChanged(sender As Object, e As EventArgs) Handles lbl_MaNV.TextChanged
        LOAD_CHITIET_HOPDONG()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_HOPDONG()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa hợp đồng lao động của nhân viên này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_HopDong_LaoDong where stt='" & lbl_STT.Text & "'")
            LOAD_CHITIET_HOPDONG()
        End If
    End Sub
End Class