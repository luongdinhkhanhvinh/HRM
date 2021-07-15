Public Class RPT_NHANVIEN
    Dim strstt As Integer
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        strstt += 1
        lbl_STT.Text = strstt.ToString
    End Sub

    Public Sub BindData()
        lbl_Ngay.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second & ", Ngày  " & Now.Day & "  tháng  " & Now.Month & "  năm  " & Now.Year
        If flag = 1 Then
            lbl_TieuDe.Text = "DANH SÁCH NHÂN VIÊN"
        ElseIf flag = 2 Then
            lbl_TieuDe.Text = "DANH SÁCH NHÂN VIÊN NGHĨ VIỆC"
        End If

        lbl_DanToc.DataBindings.Add("Text", DataSource, "DanToc")
        lbl_DiaChi.DataBindings.Add("Text", DataSource, "DiaChi")
        lbl_HoNV.DataBindings.Add("Text", DataSource, "HoNV")
        lbl_MaNhanVien.DataBindings.Add("Text", DataSource, "MaNhanVien")
        lbl_NgaySinh.DataBindings.Add("Text", DataSource, "NgaySinh").FormatString = "{0:dd/MM/yyyy}"
        lbl_NgayVaoLam.DataBindings.Add("Text", DataSource, "NgayNhanViec").FormatString = "{0:dd/MM/yyyy}"
        lbl_NoiCap.DataBindings.Add("Text", DataSource, "NoiCap")
        lbl_NoiSinh.DataBindings.Add("Text", DataSource, "NoiSinh")
        lbl_PhongBan.DataBindings.Add("Text", DataSource, "PhongBan")
        lbl_TenNV.DataBindings.Add("Text", DataSource, "Ten")
        lbl_TonGiao.DataBindings.Add("Text", DataSource, "TonGiao")
        ' lbl_NguoiLap.Text = "NGƯỜI LẬP: " & _getdata("select hoten from view_user where tendangnhap='" & strNguoiDung & "'")
    End Sub
End Class