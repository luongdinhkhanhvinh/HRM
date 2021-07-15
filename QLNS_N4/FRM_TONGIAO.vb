Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_TONGIAO

    
    Private Sub FRM_TONGIAO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_DATA_TONGIAO()
    End Sub

    Public Sub LOAD_DATA_TONGIAO()
        Dim y As Integer
        y = AdvBandedGridView1.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_tongiao order by tongiao")
        dgvTonGiao.DataSource = ds.Tables(0)
        lblMaTonGiao.DataBindings.Clear()
        lblMaTonGiao.DataBindings.Add("text", ds.Tables(0), "matongiao")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa mã tôn giáo này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("DELETE FROM TBL_TONGIAO WHERE MATONGIAO='" & lblMaTonGiao.Text & "'")
            LOAD_DATA_TONGIAO()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_DATA_TONGIAO()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView1.RowCount - 1
            dr = AdvBandedGridView1.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                _Update("update tbl_tongiao set tongiao=N'" & dr("tongiao") & "' where matongiao='" & dr("matongiao") & "'")
            ElseIf dr.RowState = DataRowState.Added Then
                _Save("insert into tbl_tongiao(matongiao,tongiao) values ('" & dr("matongiao") & "',N'" & dr("tongiao") & "')")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lblMaTonGiao.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub
End Class