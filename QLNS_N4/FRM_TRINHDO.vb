Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_TRINHDO

    Private Sub FRM_TONGIAO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_DATA_TRINHDO()
    End Sub

    Public Sub LOAD_DATA_TRINHDO()
        Dim y As Integer
        y = AdvBandedGridView1.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_trinhdo order by trinhdo")
        dgvTrinhDo.DataSource = ds.Tables(0)
        lblMaTrinhDo.DataBindings.Clear()
        lblMaTrinhDo.DataBindings.Add("text", ds.Tables(0), "matrinhdo")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa mã trình độ này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_trinhdo where matrinhdo='" & lblMaTrinhDo.Text & "'")
            LOAD_DATA_TRINHDO()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_DATA_TRINHDO()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView1.RowCount - 1
            dr = AdvBandedGridView1.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                _Update("update tbl_trinhdo set trinhdo=N'" & dr("trinhdo") & "' where matrinhdo='" & dr("matrinhdo") & "'")
            ElseIf dr.RowState = DataRowState.Added Then
                _Save("insert into tbl_trinhdo(matrinhdo,trinhdo) values ('" & dr("matrinhdo") & "',N'" & dr("trinhdo") & "')")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lblMaTrinhDo.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub
End Class