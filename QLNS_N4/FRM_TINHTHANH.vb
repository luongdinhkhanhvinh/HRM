Imports DevExpress.XtraEditors
Public Class FRM_TINHTHANH

   


    Private Sub FRM_DANTOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
        LOAD_DATA_TINHTHANH()
    End Sub

    Public Sub LOAD_DATA_TINHTHANH()
        Dim y As Integer
        y = AdvBandedGridView1.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_tinhthanh order by tinhthanh")
        dgvTinhThanh.DataSource = ds.Tables(0)
        lblMaTinhThanh.DataBindings.Clear()
        lblMaTinhThanh.DataBindings.Add("text", ds.Tables(0), "matinhthanh")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa mã tỉnh thành này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_tinhthanh where matinhthanh='" & lblMaTinhThanh.Text & "'")
            LOAD_DATA_TINHTHANH()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_DATA_TINHTHANH()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView1.RowCount - 1
            dr = AdvBandedGridView1.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                _Update("update tbl_tinhthanh set tinhthanh=N'" & dr("tinhthanh") & "' where matinhthanh='" & dr("matinhthanh") & "'")
            ElseIf dr.RowState = DataRowState.Added Then
                _Save("insert into tbl_tinhthanh(matinhthanh,tinhthanh) values ('" & dr("matinhthanh") & "',N'" & dr("tinhthanh") & "')")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lblMaTinhThanh.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub
End Class