Public Class RPT_DANGKY_TANGCA
    Dim strstt As Integer
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        strstt += 1
        lbl_STT.Text = strstt.ToString
    End Sub

    Public Sub BindData()
        lbl_Ngay.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second & ", Ngày  " & Now.Day & "  tháng  " & Now.Month & "  năm  " & Now.Year

        lbl_BD.DataBindings.Add("Text", DataSource, "BD")
        lbl_KT.DataBindings.Add("Text", DataSource, "KT")
        lbl_HoTen.DataBindings.Add("Text", DataSource, "HoTen")
        lbl_MaNhanVien.DataBindings.Add("Text", DataSource, "MaNhanVien")
        lbl_NgayTangCa.DataBindings.Add("Text", DataSource, "NgayDangKy").FormatString = "{0:dd/MM/yyyy}"
        lbl_NgayTC.DataBindings.Add("Text", DataSource, "NgayDangKy").FormatString = "{0:dd/MM/yyyy}"
        lbl_Ten.DataBindings.Add("Text", DataSource, "Ten")
        lbl_GioiTinh.DataBindings.Add("Text", DataSource, "Phai")
        lbl_PhongBan.DataBindings.Add("Text", DataSource, "PhongBan")
        lbl_GhiChu.DataBindings.Add("Text", DataSource, "GhiChu")
        ' lbl_NguoiLap.Text = "NGƯỜI LẬP: " & _getdata("select hoten from view_user where tendangnhap='" & strNguoiDung & "'")
    End Sub
End Class