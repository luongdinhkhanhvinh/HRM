Imports System.Threading
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.BandedGrid
Public Class FRM_DANGKY_TANGCA

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
                If _kiemtra("set dateformat dmy select count(*) from tbl_DangKy_TangCa where MaNhanVien='" & dr("MaNhanVien") & "' and NgayDangKy='" & strNgayThang & "'") = 0 Then
                    _Save("insert into tbl_DangKy_TangCa(MaNhanVien,DK,GioBD,PhutBD,GioKT,PhutKT,GhiChu,NgayDangKy) values ('" & dr("MaNhanVien") & "',1,'" & dr("GioBD") & "','" _
                          & dr("PhutBD") & "','" & dr("GioKT") & "','" & dr("PhutKT") & "',N'" & dr("GhiChu") & "','" & strNgayThang & "')")
                End If
            Next
        End If
        f = True
        start_thearing_send()
        XtraMessageBox.Show("Đã cập nhật danh sách đăng ký tăng ca.")
    End Sub

    Dim strLoaiTangCa, strGioBD, strPhutBD, strGioKT, strPhutKT As String
    Private Sub AdvBandedGridView1_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles AdvBandedGridView1.ValidatingEditor
        lbl_MaNV.Focus()
        Dim view As AdvBandedGridView = sender
        Dim i As Integer = view.FocusedRowHandle
        If view.FocusedColumn.FieldName = "MaNhanVien" Then
            If _kiemtra("select count(*) from tbl_nhanvien where MaNhanVien='" & e.Value & "'") = 0 Then
                e.Valid = False
                e.ErrorText = "Mã nhân viên này không hợp lệ."
            Else
                view.SetRowCellValue(i, "TenNV", _getdata("select TenNV from view_nhanvien where MaNhanVien='" & e.Value & "'"))
                view.SetRowCellValue(i, "PhongBan", _getdata("select PhongBan from view_nhanvien where MaNhanVien='" & e.Value & "'"))
                view.SetRowCellValue(i, "NgayDangKy", strNgayThang)
                view.SetRowCellValue(i, "GioBD", strGioBD)
                view.SetRowCellValue(i, "PhutBD", strPhutBD)
                view.SetRowCellValue(i, "GioKT", strGioKT)
                view.SetRowCellValue(i, "PhutKT", strPhutKT)
            End If
        ElseIf view.FocusedColumn.FieldName = "GioBD" Then
            strGioBD = e.Value
        ElseIf view.FocusedColumn.FieldName = "PhutBD" Then
            strPhutBD = e.Value
        ElseIf view.FocusedColumn.FieldName = "GioKT" Then
            strGioKT = e.Value
        ElseIf view.FocusedColumn.FieldName = "PhutKT" Then
            strPhutKT = e.Value
        End If
    End Sub

    Public Sub loadNhanvien_Tangca()
        Dim ds As New DataSet
        ds = _load_data("select * from view_DangKy_TangCa where NgayDangKy='" & strNgayThang & "' order by MaNhanVien")
        dgv_NHANVIEN_TANGCA.DataSource = ds.Tables(0)
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        loadNhanvien_Tangca()
    End Sub

    Private Sub FRM_DANGKY_TANGCA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadNhanvien_Tangca()
    End Sub

End Class