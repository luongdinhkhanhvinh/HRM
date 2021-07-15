Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_NHATKY_CHAMCONG

    Public Sub loadChitiet_Quetthe()
        Dim ds As New DataSet
        ds = _load_data("select * from view_NhatKy_QuetThe where NgayQuetThe='" & txt_NgayQuetThe.Text & "' order by Ten")
        dgvChiTiet_QuetThe.DataSource = ds.Tables(0)
        lbl_STT.DataBindings.Clear()
        lbl_STT.DataBindings.Add("text", ds.Tables(0), "STT")
    End Sub

    Public Sub loadBaocao_Chitiet()
        Dim ds As New DataSet
        ds = _load_data("select * from view_baocao_quetthe where ngayquetthe='" & txt_NgayQuetThe.Text & "' order by Ten")
        dgvBaocao_Chitiet.DataSource = ds.Tables(0)
    End Sub

    Dim iChon As Integer = 1
    Public Sub loadData()
        If iChon = 1 Then
            loadChitiet_Quetthe()
        ElseIf iChon = 2 Then
            loadBaocao_Chitiet()
        End If
    End Sub

    Private Sub FRM_NHATKY_CHAMCONG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_NgayQuetThe.Text = Now.Date
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim f As New FRM_MAYCHAMCONG
        f.ShowDialog()
    End Sub

    Private Sub txt_NgayQuetThe_EditValueChanged(sender As Object, e As EventArgs) Handles txt_NgayQuetThe.EditValueChanged
        loadChitiet_Quetthe()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPage.Name = "XtraTabPage1" Then
            iChon = 1
        ElseIf XtraTabControl1.SelectedTabPage.Name = "XtraTabPage2" Then
            iChon = 2
            loadBaocao_Chitiet()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim f As New FRM_CHAMCONGDUPHONG
        f.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        loadData()
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa nhật ký chấm công của nhân viên này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_NhatKy_QuetThe where STT='" & lbl_STT.Text & "'")
            loadChitiet_Quetthe()
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If iChon = 1 Then
            SaveFileDialog1.Filter = "Excel files |*.xlsx"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim strLenh As String = "select MaNhanVien,HoTen,Ten,Phai,NgaySinh,NgayQuetThe,PhongBan,ChucVu,ThoiGian from view_NhatKy_QuetThe where NgayQuetThe='" & txt_NgayQuetThe.Text & "' order by Ten"
                ExportToExcel(GetDatatable(strLenh), SaveFileDialog1.FileName)
                System.Diagnostics.Process.Start(SaveFileDialog1.FileName)
            End If
        ElseIf iChon = 2 Then
            SaveFileDialog1.Filter = "Excel files |*.xlsx"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim strLenh As String = "select MaNhanVien,HoTen,Ten,NgaySinh,Phai,PhongBan,ChucVu,NgayQuetThe,LanQuet from view_baocao_quetthe where NgayQuetThe='" & txt_NgayQuetThe.Text & "' order by Ten"
                ExportToExcel(GetDatatable(strLenh), SaveFileDialog1.FileName)
                System.Diagnostics.Process.Start(SaveFileDialog1.FileName)
            End If
        End If
    End Sub
End Class