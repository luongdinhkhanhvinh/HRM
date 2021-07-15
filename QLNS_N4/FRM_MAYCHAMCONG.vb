Imports System.Threading
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.BandedGrid
Public Class FRM_MAYCHAMCONG

    Public axCZKEM1 As New zkemkeeper.CZKEM
    Private Sub FRM_MAYCHAMCONG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Update("update tbl_maychamcong set tinhtrang='',noidung=''")
        loadMayChamCong()
    End Sub

    Public Sub loadMayChamCong()
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_maychamcong order by stt")
        dgvMayChamCong.DataSource = ds.Tables(0)
        lblIP.DataBindings.Clear()
        lblIP.DataBindings.Add("text", ds.Tables(0), "ip")
    End Sub

    Public bIsConnected As Boolean = False 'the boolean value identifies whether the device is connected
    Private iMachineNumber As Integer 'the
    Public Sub Ketnoi_Maychamcong(ByVal ip As String)
        '  Dim idwErrorCode As Integer
        bIsConnected = axCZKEM1.Connect_Net(ip, Convert.ToInt32(4370))
        If bIsConnected = True Then


            iMachineNumber = 1 'In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
            axCZKEM1.RegEvent(iMachineNumber, 65535) 'Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
        Else
            'axCZKEM1.GetLastError(idwErrorCode)
            'XtraMessageBox.Show("Unable to connect the device,ErrorCode=" & idwErrorCode & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            _Update("update tbl_maychamcong set tinhtrang=N'Không thành công' where ip='" & ip & "'")
        End If
        Cursor = Cursors.Default
    End Sub

    Dim iDemso As Integer
    Public Sub loadDemsoQuetthe(ByVal ip As String)
        Ketnoi_Maychamcong(ip)
        ' Dim idwErrorCode As Integer
        Dim iValue = 0

        axCZKEM1.EnableDevice(iMachineNumber, False) 'disable the device
        If axCZKEM1.GetDeviceStatus(iMachineNumber, 6, iValue) = True Then 'Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
            iDemso = iValue
            'MsgBox("The count of the AttLogs in the device is " + iValue.ToString(), MsgBoxStyle.Information, "Success")
            'Else
            '    axCZKEM1.GetLastError(idwErrorCode)
            '    MsgBox("Operation failed,ErrorCode=" & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
        End If
        axCZKEM1.EnableDevice(iMachineNumber, True) 'enable the device
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_maychamcong where chon=1 order by stt")
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            loadDemsoQuetthe(dr("ip"))
            If iDemso > 0 Then
                loadTaiDuLieu(dr("ip"))
            End If
            iGLCount = 0
        Next
        loadMayChamCong()
        Me.Text = "Đã tải hoàn tất..."
    End Sub

    Dim iGLCount = 0
    Public Sub loadTaiDuLieu(ByVal ip As String)

        Ketnoi_Maychamcong(ip)

        Dim idwTMachineNumber As Integer
        Dim idwEnrollNumber As Integer
        Dim idwEMachineNumber As Integer
        Dim idwVerifyMode As Integer
        Dim idwInOutMode As Integer
        Dim idwYear As Integer
        Dim idwMonth As Integer
        Dim idwDay As Integer
        Dim idwHour As Integer
        Dim idwMinute As Integer

        '   Dim idwErrorCode As Integer


        axCZKEM1.EnableDevice(iMachineNumber, False) 'disable the device
        If axCZKEM1.ReadGeneralLogData(iMachineNumber) Then 'read all the attendance records to the memory
            'get records from the memory
            While axCZKEM1.GetGeneralLogData(iMachineNumber, idwTMachineNumber, idwEnrollNumber, idwEMachineNumber, idwVerifyMode, idwInOutMode, idwYear, idwMonth, idwDay, idwHour, idwMinute)
                iGLCount += 1
                Dim strNgayThang, strGio, strPhut As String
                strNgayThang = idwDay & "/" & idwMonth & "/" & idwYear
                If idwHour < 10 Then
                    strGio = "0" & idwHour
                Else
                    strGio = idwHour
                End If
                If idwMinute < 10 Then
                    strPhut = "0" & idwMinute
                Else
                    strPhut = idwMinute
                End If
                Me.Text = idwEnrollNumber

                'kiem tra du lieu, neu tai roi khong luu nua
                If _kiemtra("select count(*) from tbl_nhanvien where MaNhanVien='" & idwEnrollNumber & "'") > 0 Then
                    If _kiemtra("set dateformat dmy select count(*) from tbl_NhatKy_QuetThe where MaNhanVien='" & idwEnrollNumber & "' and ngayquetthe='" & strNgayThang & "' and gio='" & idwHour & "' and phut='" & idwMinute & "'") = 0 Then
                        _Save("insert into tbl_NhatKy_QuetThe(MaNhanVien,NgayQuetThe,Gio,Phut,ThoiGian,IP) values ('" & idwEnrollNumber & "','" & strNgayThang & "','" & idwHour & "','" & idwMinute & "','" & strGio & ":" & strPhut & "','" & ip & "')")
                    End If
                End If
            End While
            If iGLCount > 0 Then
                _Update("update tbl_maychamcong set tinhtrang=N'Thành công',noidung=N'Đã tải được " & iGLCount & " dòng.' where ip='" & ip & "'")
            Else
                _Update("update tbl_maychamcong set tinhtrang=N'Không thành công',noidung=N'Đã tải được " & iGLCount & " dòng.' where ip='" & ip & "'")
            End If

        Else
            'axCZKEM1.GetLastError(idwErrorCode)
            'If idwErrorCode <> 0 Then
            '    MsgBox("Reading data from terminal failed,ErrorCode: " & idwErrorCode, MsgBoxStyle.Exclamation, "Error")
            'Else
            '    XtraMessageBox.Show("Không tồn tại dữ liệu trong máy chấm công.")
            'End If

        End If

        axCZKEM1.EnableDevice(iMachineNumber, True) 'enable the device
        Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa thiết bị có IP " & lblIP.Text & " này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dgrResult = Windows.Forms.DialogResult.Yes Then
            _Delete("delete from tbl_maychamcong where ip='" & lblIP.Text & "'")
            loadMayChamCong()
        End If
    End Sub

    Public Sub XoaDuLieu_ChamCong()
        Ketnoi_Maychamcong(lblIP.Text)
        Dim idwErrorCode As Integer

        axCZKEM1.EnableDevice(iMachineNumber, False) 'disable the device
        If axCZKEM1.ClearGLog(iMachineNumber) = True Then
            axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
            XtraMessageBox.Show("Dữ liệu trên máy chấm công " & lblIP.Text & " Đã xóa")
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            XtraMessageBox.Show("Operation failed,ErrorCode=" & idwErrorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        axCZKEM1.EnableDevice(iMachineNumber, True) 'enable the device
    End Sub

    Dim strTGHienTaiThietBi As String
    Public Sub loadLayThoiGianHienTai()
        Dim idwErrorCode As Integer

        Dim idwYear As Integer
        Dim idwMonth As Integer
        Dim idwDay As Integer
        Dim idwHour As Integer
        Dim idwMinute As Integer
        Dim idwSecond As Integer

        Cursor = Cursors.WaitCursor
        If axCZKEM1.GetDeviceTime(iMachineNumber, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond) = True Then
            axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
            strTGHienTaiThietBi = idwDay.ToString() + "/" + idwMonth.ToString() + "/" + idwYear.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString()
        Else
            axCZKEM1.GetLastError(idwErrorCode)
            MsgBox("Operation failed,ErrorCode=" & idwErrorCode.ToString(), MsgBoxStyle.Exclamation, "Error")
        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_maychamcong where chon=1 order by stt")
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            bIsConnected = axCZKEM1.Connect_Net(dr("ip"), Convert.ToInt32(4370))
            If bIsConnected = True Then
                iMachineNumber = 1
                axCZKEM1.RegEvent(iMachineNumber, 65535)
                loadLayThoiGianHienTai()
                _Update("update tbl_maychamcong set tinhtrang=N'Đã kết nối...' where ip='" & dr("ip") & "'")
            Else
                _Update("update tbl_maychamcong set tinhtrang=N'Không kết nối...' where ip='" & dr("ip") & "'")
            End If

        Next
        loadMayChamCong()
    End Sub

    Private Sub AdvBandedGridView1_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles AdvBandedGridView1.ValidatingEditor
        lblIP.Focus()
        Dim view As AdvBandedGridView = sender
        Dim i As Integer = view.FocusedRowHandle
        If view.FocusedColumn.FieldName = "chon" Then
            If e.Value = True Then
                _Update("update tbl_maychamcong set chon=1 where ip='" & lblIP.Text & "'")
            Else
                _Update("update tbl_maychamcong set chon=0 where ip='" & lblIP.Text & "'")
            End If
        End If
    End Sub

    Public Sub LoadDongBoThoiGian()
        Cursor = Cursors.WaitCursor
        If axCZKEM1.SetDeviceTime(iMachineNumber) = True Then
            axCZKEM1.RefreshData(iMachineNumber) 'the data in the device should be refreshed
            '  MsgBox("Successfully set the time of the machine and the terminal to sync PC!", MsgBoxStyle.Information, "Success")
            Dim idwYear As Integer
            Dim idwMonth As Integer
            Dim idwDay As Integer
            Dim idwHour As Integer
            Dim idwMinute As Integer
            Dim idwSecond As Integer
            If axCZKEM1.GetDeviceTime(iMachineNumber, idwYear, idwMonth, idwDay, idwHour, idwMinute, idwSecond) Then 'show the time
                strTGHienTaiThietBi = idwDay.ToString() + "/" + idwMonth.ToString() + "/" + idwYear.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString()
            End If
        Else
            '  axCZKEM1.GetLastError(idwErrorCode)
            XtraMessageBox.Show("Đồng bộ thời gian bị lỗi, vui lòng thử lại sau.")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Dim ds As New DataSet
        ds = _load_data("select * from tbl_maychamcong where chon=1 order by stt")
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            bIsConnected = axCZKEM1.Connect_Net(dr("ip"), Convert.ToInt32(4370))
            If bIsConnected = True Then
                iMachineNumber = 1
                axCZKEM1.RegEvent(iMachineNumber, 65535)
                LoadDongBoThoiGian()
            Else
                _Update("update tbl_maychamcong set tinhtrang=N'Không kết nối...' where ip='" & dr("ip") & "'")
            End If
        Next
        loadMayChamCong()
        XtraMessageBox.Show("Hệ thống đã được đồng bộ.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#Region "XuLy"
    Public Delegate Sub process_data()
    Dim th_NhanDuLieu As Thread
    Public Sub XuLy()
        Try
            While True
                If start = True Then
                    Me.BeginInvoke(New process_data(AddressOf loadMayChamCong))
                End If
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

    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        'start_thearing()
        'Dim f As New FRM_ADD_MAYCHAMCONG
        'f.Show()
    End Sub

    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Dim dgrResult As DialogResult = XtraMessageBox.Show("Bạn có muốn xóa dữ liệu máy chấm công " & lblIP.Text & " này không?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If dgrResult = Windows.Forms.DialogResult.Yes Then

            XoaDuLieu_ChamCong()

        End If
    End Sub
End Class