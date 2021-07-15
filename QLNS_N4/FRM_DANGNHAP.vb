Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_DANGNHAP

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If txttennguoisd.Text.Length > 0 And txttennguoisd.Text <> "-" Then
            If txtmatkhau.Text.Length > 0 Then
                Try
                    If _kiemtra("select count(*) from tbl_user where tendangnhap='" & txttennguoisd.Text & "' and matkhau='" & md5(txtmatkhau.Text) & "'") = 1 Then
                        If _getdata("select truycap from tbl_user where tendangnhap='" & txttennguoisd.Text & "'") = "True" Then
                            strTenDangNhap = txttennguoisd.Text
                            Me.Close()
                        Else
                            XtraMessageBox.Show("Tài khoản này chưa kích hoạt hoặc tạm khóa. Xin liên hệ người quản trị hệ thống để kích hoạt tài khoản", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    Else
                        XtraMessageBox.Show("Đăng nhập không thành công, tên đăng nhập hoặc mật khẩu không đúng.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        txtmatkhau.Text = ""
                        With txttennguoisd
                            .Text = ""
                            .Focus()
                        End With
                    End If
                Catch ex As Exception
                    XtraMessageBox.Show("Đăng nhập không thành công, tên đăng nhập hoặc mật khẩu không đúng.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End Try
            Else
                XtraMessageBox.Show("Đăng nhập không thành công, mật khẩu không được bỏ trống.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtmatkhau.Focus()
            End If
        Else
            XtraMessageBox.Show("Đăng nhập không thành công, tên đăng nhập không được bỏ trống.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txttennguoisd.Focus()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Application.Exit()
    End Sub

    Private Sub FRM_DANGNHAP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center_windows(Me)
    End Sub

    Private Sub FRM_DANGNHAP_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                SimpleButton2_Click(sender, e)
            Case Keys.Escape
                Application.Exit()
        End Select
    End Sub
End Class