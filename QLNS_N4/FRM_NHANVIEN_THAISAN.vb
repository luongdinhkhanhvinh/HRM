Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_NHANVIEN_THAISAN

#Region "XuLy"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf LOAD_NHANVIEN_THAISAN))
                End If
                start = False
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

    Public Sub LOAD_TRANGTHAI()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_LoaiTrangThai order by LoaiTrangThai")
        cboLoaiTrangThai.DataSource = ds.Tables(0)
        cboLoaiTrangThai.DisplayMember = "LoaiTrangThai"
        cboLoaiTrangThai.ValueMember = "MaLoai"
    End Sub

    Private Sub FRM_NHANVIEN_THAISAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_NHANVIEN_THAISAN()
        LOAD_TRANGTHAI()
    End Sub

    Public Sub LOAD_NHANVIEN_THAISAN()
        Dim y As Integer
        y = AdvBandedGridView2.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from view_NhanVien_ThaiSan where SD=1 order by MaNhanVien")
        dgvNhanVien_ThaiSan.DataSource = ds.Tables(0)
        lbl_MaNhanVien.DataBindings.Clear()
        lbl_STT.DataBindings.Clear()

        lbl_MaNhanVien.DataBindings.Add("text", ds.Tables(0), "MaNhanVien")
        lbl_STT.DataBindings.Add("text", ds.Tables(0), "STT")
        AdvBandedGridView2.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        start_thearing()
        Dim f As New FRM_THEM_NHANVIEN_THAISAN
        f.ShowDialog()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_NHANVIEN_THAISAN()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView2.RowCount - 1
            dr = AdvBandedGridView2.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                Dim strDuyet As String
             
                _Update("update tbl_NhanVien_ThaiSan set LanMangThai='" & dr("LanMangThai") & "',NgayNghi_ThaiSan='" & dr("NgayNghi_ThaiSan") & "',NgayLamLai='" & dr("NgayLamLai") _
                        & "',GhiChu=N'" & dr("GhiChu") & "',MaLoaiTrangThai='" & dr("MaLoaiTrangThai") & "' where STT='" & dr("STT") & "'")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên trong danh sách thai sản này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_NhanVien_ThaiSan where MaNhanVien='" & lbl_MaNhanVien.Text & "'")
            LOAD_NHANVIEN_THAISAN()
        End If
    End Sub
End Class