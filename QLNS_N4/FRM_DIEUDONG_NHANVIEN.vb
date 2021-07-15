Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_DIEUDONG_NHANVIEN

#Region "XuLy"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf LOAD_DIEUDONG_NHANVIEN))
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

    Public Sub LOAD_PHONGBAN()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_PhongBan order by PhongBan")
        cbo_PhongBan.DataSource = ds.Tables(0)
        cbo_PhongBan.DisplayMember = "PhongBan"
        cbo_PhongBan.ValueMember = "PhongBan"
    End Sub

    Public Sub LOAD_CHUCVU()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_ChucVu order by ChucVu")
        cbo_ChucVu.DataSource = ds.Tables(0)
        cbo_ChucVu.DisplayMember = "ChucVu"
        cbo_ChucVu.ValueMember = "ChucVu"
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        start_thearing()
        Dim f As New FRM_ADD_DIEUDONG_NV
        f.ShowDialog()
    End Sub

    Private Sub FRM_DIEUDONG_NHANVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_CHUCVU()
        LOAD_PHONGBAN()
        LOAD_DIEUDONG_NHANVIEN()
    End Sub

    Public Sub LOAD_DIEUDONG_NHANVIEN()
        Dim y As Integer
        y = AdvBandedGridView1.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from view_DieuDong_NhanVien order by MaNhanVien")
        dgvDieuDong_NhanVien.DataSource = ds.Tables(0)
        lblMaNV.DataBindings.Clear()
        lblSTT.DataBindings.Clear()

        lblMaNV.DataBindings.Add("text", ds.Tables(0), "MaNhanVien")
        lblSTT.DataBindings.Add("text", ds.Tables(0), "STT")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim strTenNV As String = _getdata("select TenNV from tbl_NhanVien where MaNhanVien='" & lblMaNV.Text & "'")
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên " & strTenNV & " trong danh sách điều động nhận viên không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_DieuDong_NhanVien where STT='" & lblSTT.Text & "'")
            LOAD_DIEUDONG_NHANVIEN()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_DIEUDONG_NHANVIEN()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView1.RowCount - 1
            dr = AdvBandedGridView1.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                _Update("update tbl_DieuDong_NhanVien set NgayDieuDong='" & dr("NgayDieuDong") & "',GhiChu=N'" & dr("GhiChu") & "' where STT='" & dr("STT") & "'")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lblMaNV.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        SaveFileDialog1.Filter = "Excel files |*.xlsx"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim strLenh As String = "select * from view_DieuDong_NhanVien order by STT"
            ExportToExcel(GetDatatable(strLenh), SaveFileDialog1.FileName)
            System.Diagnostics.Process.Start(SaveFileDialog1.FileName)
        End If
    End Sub
End Class