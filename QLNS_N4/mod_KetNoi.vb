Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports System.Data.OleDb
Imports System.Threading
Imports Microsoft.Office.Interop
Module mod_KetNoi
    Public strconnect, strconnect2 As New SqlConnection
    Public strDiaChiIP, strIP, strNgayThang, strMaNhanVien, strTenDangNhap As String
    Public start, start1 As Boolean
    Public reports, flag As Integer
    Public dsReports As New DataSet
    Public strHinh_NV As String = "F:\Hinh_NV\"
    Public Sub open_connect()
        Try
            strconnect.ConnectionString = "server=.;uid=sa;database=QLNS_NHOM4;password=minh123;"
            strconnect.Open()
        Catch ex As Exception
            ' XtraMessageBox.Show("Lỗi kết nối đến máy chủ. Vui lòng thử lại.")
        End Try
    End Sub


    Public Sub open_connect2()
        Try
            strconnect2.ConnectionString = "server=.;uid=sa;database=HOB;password=minh123;"
            strconnect2.Open()
        Catch ex As Exception
            ' XtraMessageBox.Show("Lỗi kết nối đến máy chủ. Vui lòng thử lại.")
        End Try
    End Sub

    Public Sub close_connect()
        strconnect.Close()
    End Sub

    Public Sub close_connect2()
        strconnect2.Close()
    End Sub

    Public Function _getdata(ByVal strLenh As String) As String
        Dim str As String
        open_connect()
        Dim d As String = "set dateformat dmy"
        Dim cmd As New SqlCommand(strLenh, strconnect)
        Dim cmd1 As New SqlCommand(d, strconnect)
        str = cmd.ExecuteScalar
        close_connect()
        Return str
    End Function

    Public Function _getdata2(ByVal strLenh As String) As String
        Dim str As String
        open_connect2()
        Dim d As String = "set dateformat dmy"
        Dim cmd As New SqlCommand(strLenh, strconnect2)
        Dim cmd1 As New SqlCommand(d, strconnect2)
        str = cmd.ExecuteScalar
        close_connect2()
        Return str
    End Function

    Public Function _kiemtra(ByVal strLenh As String) As Integer
        Dim intKiemTra As Integer
        open_connect()
        Dim cmd As New SqlCommand(strLenh, strconnect)
        intKiemTra = cmd.ExecuteScalar
        close_connect()
        Return intKiemTra
    End Function

    Public Function _load_data(ByVal strLenh As String) As DataSet
        Dim ds As New DataSet
        open_connect()
        Dim d As String = "set dateformat dmy"
        Dim cmd1 As New SqlCommand(d, strconnect)
        cmd1.ExecuteNonQuery()

        Dim cmd As New SqlDataAdapter(strLenh, strconnect)
        cmd.Fill(ds)
        close_connect()
        Return ds
    End Function

    Public Function _load_data2(ByVal strLenh As String) As DataSet
        Dim ds As New DataSet
        open_connect2()
        Dim d As String = "set dateformat dmy"
        Dim cmd1 As New SqlCommand(d, strconnect2)
        cmd1.ExecuteNonQuery()

        Dim cmd As New SqlDataAdapter(strLenh, strconnect2)
        cmd.Fill(ds)
        close_connect2()
        Return ds
    End Function

    Public Sub _Update(ByVal strLenh As String)
        open_connect()
        Dim d As String = "set dateformat dmy"
        Dim cmd1 As New SqlCommand(d, strconnect)
        cmd1.ExecuteNonQuery()

        Dim cmd As New SqlCommand(strLenh, strconnect)
        cmd.ExecuteNonQuery()
        close_connect()
    End Sub

    Public Sub _Save(ByVal strLenh As String)
        open_connect()
        Dim d As String = "set dateformat dmy"
        Dim cmd1 As New SqlCommand(d, strconnect)
        cmd1.ExecuteNonQuery()
        Dim cmd As New SqlCommand(strLenh, strconnect)
        cmd.ExecuteNonQuery()
        close_connect()
    End Sub

    Public Sub _Delete(ByVal strLenh As String)
        open_connect()
        Dim cmd As New SqlCommand(strLenh, strconnect)
        cmd.ExecuteNonQuery()
        close_connect()
    End Sub

    Public Function encryptData(ByVal data As String) As Byte()
        Dim md5Hasher As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim hashedBytes As Byte()
        Dim encoder As New System.Text.UTF8Encoding()
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data))
        Return hashedBytes
    End Function

    Public Sub ExportToExcel(ByVal dtTemp As DataTable, ByVal filepath As String)
        Dim strFileName As String = filepath
        If System.IO.File.Exists(strFileName) Then
            If (XtraMessageBox.Show("Bạn có muốn chép đè lên file đã tồn tại không?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
                System.IO.File.Delete(strFileName)
            Else
                Return
            End If

        End If
        Dim _excel As New Excel.Application
        Dim wBook As Excel.Workbook
        Dim wSheet As Excel.Worksheet

        wBook = _excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dtTemp
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        ' export the Columns 
        '  If CheckBox1.Checked Then
        For Each dc In dt.Columns
            colIndex = colIndex + 1
            wSheet.Cells(1, colIndex) = dc.ColumnName
        Next
        ' End If

        'export the rows 
        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        wSheet.Columns.AutoFit()
        wBook.SaveAs(strFileName)

        'release the objects
        ReleaseObject(wSheet)
        wBook.Close(False)
        ReleaseObject(wBook)
        _excel.Quit()
        ReleaseObject(_excel)
        ' some time Office application does not quit after automation: so i am calling GC.Collect method.
        GC.Collect()

    End Sub

    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Function GetDatatable(strLenh As String) As DataTable
        'Create the data table at runtime
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds = _load_data(strLenh)
        dt = ds.Tables(0)
        Return dt
    End Function

    Public Sub center_windows(ByVal FRM As Form)
        FRM.Top = (Screen.PrimaryScreen.Bounds.Height - FRM.Height) / 2
        FRM.Left = (Screen.PrimaryScreen.Bounds.Width - FRM.Width) / 2
    End Sub

    Public Function md5(ByVal data As String) As String
        Return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower()
    End Function
End Module
