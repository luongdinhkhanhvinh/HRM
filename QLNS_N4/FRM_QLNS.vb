Imports DevExpress.XtraBars.Helpers
Imports System.IO
Imports System.Threading
Imports DevExpress.XtraEditors
Public Class FRM_QLNS

    'Sub New()
    '    InitSkins()
    '    InitializeComponent()
    '    Me.InitSkinGallery()
    'End Sub

    'Dim strfilename As String
    'Sub InitSkins()
    '    strfilename = Application.StartupPath.ToString() + "\Skin.hob"
    '    Dim _read As StreamReader
    '    _read = New StreamReader(strfilename, False)
    '    DevExpress.Skins.SkinManager.EnableFormSkins()
    '    DevExpress.UserSkins.BonusSkins.Register()

    '    UserLookAndFeel.Default.SetSkinStyle(_read.ReadLine)
    '    _read.Close()
    'End Sub


    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rGallerySkins, True)
    End Sub

    Private Sub FRM_QLNS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinHelper.InitSkinGallery(rGallerySkins)
        Me.WindowState = FormWindowState.Maximized
        '   OpenForm(GetType(FRM_NHANVIEN))

        f.Owner = Me
        mLoad = New Thread(AddressOf LoadDangNhap)
        With mLoad
            .IsBackground = True
            .Start()
        End With
    End Sub

    Dim f As New FRM_DANGNHAP
    Dim mLoad As Thread
    Sub LoadDangNhap()
        Me.BeginInvoke(New MethodInvoker(AddressOf f.ShowDialog))
    End Sub

    Public Sub OpenForm(ByVal typeform As Type)
        For Each frm As Form In MdiChildren
            If frm.GetType() = typeform Then
                frm.Activate()
                Return
            End If
        Next
        Dim f As Form = DirectCast(Activator.CreateInstance(typeform), Form)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=10") Then
            Dim f As New FRM_DANTOC
            f.ShowDialog()
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=9") Then
            Dim f As New FRM_TINHTHANH
            f.ShowDialog()
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=11") Then
            Dim f As New FRM_TONGIAO
            f.ShowDialog()
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=12") Then
            Dim f As New FRM_CHUCVU
            f.ShowDialog()
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=13") Then
            Dim f As New FRM_TRINHDO
            f.ShowDialog()
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=14") Then
            Dim f As New FRM_PHONGBAN
            f.ShowDialog()
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=1") Then
            OpenForm(GetType(FRM_NHANVIEN))
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=8") Then
            OpenForm(GetType(FRM_DIEUDONG_NHANVIEN))
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=2") Then
            OpenForm(GetType(FRM_NHANVIEN_NGHIVIEC))
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=3") Then
            OpenForm(GetType(FRM_NHANVIEN_THAISAN))
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        OpenForm(GetType(FRM_DANGKYTHE_NHANVIEN))
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=4") Then
            OpenForm(GetType(FRM_CAPNHAT_TANGCA))
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=6") Then
            OpenForm(GetType(FRM_BAOHIEM))
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        If _kiemtra("select count(*) from tbl_capquyen where tendangnhap='" & strTenDangNhap & "' and xem=1 and mamenu=7") Then
            OpenForm(GetType(FRM_HOPDONG_LAODONG))
        Else
            XtraMessageBox.Show("Bạn bị hạn chế truy cập vào danh mục này.", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        OpenForm(GetType(FRM_NHATKY_CHAMCONG))
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        OpenForm(GetType(FRM_USER))
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Application.Exit()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim f As New FRM_DANGNHAP
        f.ShowDialog()
    End Sub
End Class