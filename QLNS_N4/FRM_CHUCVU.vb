Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_CHUCVU

    Private Sub FRM_CHUCVU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_DATA_CHUCVU()
    End Sub

    Public Sub LOAD_DATA_CHUCVU()
        Dim y As Integer
        y = AdvBandedGridView1.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_chucvu order by chucvu")
        dgvChucVu.DataSource = ds.Tables(0)
        lblMaChucVu.DataBindings.Clear()
        lblMaChucVu.DataBindings.Add("text", ds.Tables(0), "machucvu")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa mã chức vụ này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_chucvu where machucvu='" & lblMaChucVu.Text & "'")
            LOAD_DATA_CHUCVU()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_DATA_CHUCVU()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView1.RowCount - 1
            dr = AdvBandedGridView1.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                _Update("update tbl_chucvu set chucvu=N'" & dr("chucvu") & "' where machucvu='" & dr("machucvu") & "'")
            ElseIf dr.RowState = DataRowState.Added Then
                _Save("insert into tbl_chucvu(machucvu,chucvu) values ('" & dr("machucvu") & "',N'" & dr("chucvu") & "')")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lblMaChucVu.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub
End Class