Public Class FRM_REPORT 

    Private Sub FRM_REPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If reports = 1 Then
            Me.Text = "DANH SÁCH NHÂN VIÊN"
            Dim rpt As New RPT_NHANVIEN
            rpt.DataSource = dsReports
            rpt.BindData()
            DocumentViewer1.PrintingSystem = rpt.PrintingSystem
            rpt.CreateDocument()
        ElseIf reports = 2 Then
            Me.Text = "ĐĂNG KÝ TĂNG CA"
            Dim rpt As New RPT_DANGKY_TANGCA
            rpt.DataSource = dsReports
            rpt.BindData()
            DocumentViewer1.PrintingSystem = rpt.PrintingSystem
            rpt.CreateDocument()
        End If
    End Sub
End Class