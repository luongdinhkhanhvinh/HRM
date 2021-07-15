Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_DANTOC

#Region "XuLy"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf LOAD_DATA_DANTOC))
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

    Private Sub FRM_DANTOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_DATA_DANTOC()
    End Sub

    Public Sub LOAD_DATA_DANTOC()
        Dim y As Integer
        y = AdvBandedGridView1.FocusedRowHandle
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_dantoc order by dantoc")
        dgvDanToc.DataSource = ds.Tables(0)
        lblMaDanToc.DataBindings.Clear()
        lblMaDanToc.DataBindings.Add("text", ds.Tables(0), "madantoc")
        AdvBandedGridView1.FocusedRowHandle = y
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa mã dân tộc này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("DELETE FROM TBL_DANTOC WHERE MADANTOC='" & lblMaDanToc.Text & "'")
            LOAD_DATA_DANTOC()
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        LOAD_DATA_DANTOC()
    End Sub

    Private Sub LUU()
        Dim dr As DataRow
        For index = 0 To AdvBandedGridView1.RowCount - 1
            dr = AdvBandedGridView1.GetDataRow(index)
            If IsNothing(dr) Then
                Exit For
            End If
            If dr.RowState = DataRowState.Modified Then
                _Update("UPDATE TBL_DANTOC SET DANTOC=N'" & dr("DanToc") & "' where MADANTOC='" & dr("madantoc") & "'")
            ElseIf dr.RowState = DataRowState.Added Then
                _Save("insert into tbl_dantoc(madantoc,dantoc) values ('" & dr("madantoc") & "','" & dr("dantoc") & "')")
            End If
        Next
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        lblMaDanToc.Focus()
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn lưu lại những thay đổi không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            LUU()
        End If
    End Sub
End Class