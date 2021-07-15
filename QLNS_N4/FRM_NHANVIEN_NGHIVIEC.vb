Imports DevExpress.XtraEditors
Imports System.Threading
Public Class FRM_NHANVIEN_NGHIVIEC

    Private Sub FRM_NHANVIEN_NGHIVIEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   _LOADDULIEU()
        LOAD_NHANVIEN()
    End Sub

    Public Sub LOAD_NHANVIEN()
        Dim ds As New DataSet
        ds = _load_data("select * from view_NhanVien_NghiViec order by stt desc")
        dgvNhanVien_NghiViec.DataSource = ds.Tables(0)
        lbl_MaNV.DataBindings.Clear()
        lbl_STT.DataBindings.Clear()

        lbl_MaNV.DataBindings.Add("text", ds.Tables(0), "MaNhanVien")
        lbl_STT.DataBindings.Add("text", ds.Tables(0), "STT")
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_NHANVIEN()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên này khỏi danh sách nghĩ việc không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_NhanVien_NghiViec where STT='" & lbl_STT.Text & "'")
            LOAD_NHANVIEN()
        End If
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

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        start_thearing()
        Dim f As New FRM_ADD_NHANVIEN_NGHIVIEC
        f.Show()
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
                If dr("Duyet") = True Then
                    strDuyet = 1
                Else
                    strDuyet = 0
                End If
                _Update("update tbl_NhanVien_NghiViec set NgayNopDon='" & dr("NgayNopDon") & "',NgayNghiViec='" & dr("NgayNghiViec") & "',LyDo=N'" & dr("LyDo") & "',Duyet='" _
                        & strDuyet & "' where STT='" & dr("STT") & "'")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lbl_MaNV.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        reports = 1
        flag = 2
        dsReports = _load_data("select * from view_NhanVien where SD=0 order by Ten")
        Dim f As New FRM_REPORT
        f.Show()
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        SaveFileDialog1.Filter = "Excel files |*.xlsx"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim strLenh As String = "select STT,MaNhanVien,HoTen,Ten,Phai,NgaySinh,NgayNghiViec,PhongBan,ChucVu,NgayNopDon,NgayNghiViec,LyDo from view_NhanVien_NghiViec order by MaNhanVien"
            ExportToExcel(GetDatatable(strLenh), SaveFileDialog1.FileName)
            System.Diagnostics.Process.Start(SaveFileDialog1.FileName)
        End If
    End Sub
End Class