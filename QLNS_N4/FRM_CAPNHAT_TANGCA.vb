Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_CAPNHAT_TANGCA

    Dim y As Integer
    Public Sub load_NHANVIEN_TANGCA()
        Dim ds As New DataSet
        y = AdvBandedGridView1.FocusedRowHandle
        ds = _load_data("set dateformat dmy select * from view_DangKy_TangCa where NgayDangKy='" & txt_NgayLamViec.Text & "' order by MaNhanVien")
        dgv_NHANVIEN_TANGCA.DataSource = ds.Tables(0)

        lbl_MaNV.DataBindings.Clear()
        lbl_MaNV.DataBindings.Add("text", ds.Tables(0), "MaNhanVien")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

#Region "XuLy"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf load_NHANVIEN_TANGCA))
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

    Private Sub FRM_CAPNHAT_TANGCA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_NgayLamViec.Text = Now.Date
        load_NHANVIEN_TANGCA()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        start_thearing()
        strNgayThang = txt_NgayLamViec.Text
        Dim f As New FRM_DANGKY_TANGCA
        f.Show()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lbl_MaNV.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại danh sách đăng ký tăng ca không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            Dim dr As DataRow
            For index = 0 To AdvBandedGridView1.RowCount - 1
                dr = AdvBandedGridView1.GetDataRow(index)
                If IsNothing(dr) Then
                    Exit For
                End If
                Dim dangky As String
                If dr("DK") = True Then
                    dangky = 1
                Else
                    dangky = 0
                End If
                If dr.RowState = DataRowState.Modified Then
                    _Update("update tbl_DangKy_TangCa set DK='" & dangky & "',GhiChu=N'" & dr("GhiChu") & "',GioBD='" & dr("GioBD") & "',PhutBD='" & dr("PhutBD") & "',GioKT='" _
                            & dr("GioKT") & "',PhutKT='" & dr("PhutKT") & "' where STT='" & dr("STT") & "'")
                End If
            Next
        End If
        XtraMessageBox.Show("Đã cập nhật danh sách đăng ký tăng ca.")
    End Sub

    Private Sub txt_NgayLamViec_EditValueChanged(sender As Object, e As EventArgs) Handles txt_NgayLamViec.EditValueChanged
        load_NHANVIEN_TANGCA()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        load_NHANVIEN_TANGCA()
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        reports = 2
        dsReports = _load_data("select * from view_DangKy_TangCa where ngaydangky='" & txt_NgayLamViec.Text & "' order by Ten")
        Dim f As New FRM_REPORT
        f.Show()
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        SaveFileDialog1.Filter = "Excel files |*.xlsx"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim strLenh As String = "select MaNhanVien,HoTen,Ten,Phai,NgaySinh,NgayNhanViec,NgayDangKy,BD,KT from view_DangKy_TangCa where NgayDangKy='" & txt_NgayLamViec.Text & "' order by MaNhanVien"
            ExportToExcel(GetDatatable(strLenh), SaveFileDialog1.FileName)
            System.Diagnostics.Process.Start(SaveFileDialog1.FileName)
        End If
    End Sub
End Class