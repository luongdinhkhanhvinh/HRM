Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_PHONGBAN

    'Public Sub _LOADDULIEU()
    '    Dim ds As New DataSet
    '    ds = _load_data2("select * from tbl_phanxuong")
    '    Dim dr As DataRow
    '    For Each dr In ds.Tables(0).Rows
    '        _Save("insert into tbl_phongban(maphongban,phongban) values ('" & dr("mapx") & "',N'" & dr("tenpx") & "')")
    '    Next
    'End Sub

    Private Sub FRM_PHONGBAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    _LOADDULIEU()
        LOAD_DATA_PHONGBAN()
    End Sub

    Public Sub LOAD_DATA_PHONGBAN()
        Dim y As Integer
        y = AdvBandedGridView1.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_phongban order by phongban")
        dgvPhongBan.DataSource = ds.Tables(0)
        lblMaPhongBan.DataBindings.Clear()
        lblMaPhongBan.DataBindings.Add("text", ds.Tables(0), "maphongban")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa mã tôn giáo này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_phongban where maphongban='" & lblMaPhongBan.Text & "'")
            LOAD_DATA_PHONGBAN()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_DATA_PHONGBAN()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView1.RowCount - 1
            dr = AdvBandedGridView1.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                _Update("update tbl_phongban set phongban=N'" & dr("phongban") & "' where maphongban='" & dr("maphongban") & "'")
            ElseIf dr.RowState = DataRowState.Added Then
                _Save("insert into tbl_phongban(maphongban,phongban) values ('" & dr("maphongban") & "',N'" & dr("phongban") & "')")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lblMaPhongBan.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub
End Class