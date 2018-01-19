Imports SpaceReader
Imports System.Threading
Imports System.IO

Public Class Main

    Dim MassFolderSize As Double
    Public TempTable As New System.Data.DataTable
    Dim TempSize As DataColumn
    Dim TempName As DataColumn
    Dim TempPath As DataColumn
    Dim SkipSize As Double
    Dim TotalSize As Integer
    Dim TotalSizeStep As Integer
    Dim StrngPath As String
    Dim dot As String = "....."

#Region "Buttons and checkboxes"
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        FolderBrowserDialog1.ShowDialog()
        txtBrowse.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub chkUseTextPath_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseTextPathLarge.CheckedChanged
        If chkUseTextPathLarge.CheckState = CheckState.Checked Then
            txtBrowse.Text = "D:\Customers\Germany\UCE\RawData\vin\RawData\"
        End If
    End Sub

    Private Sub chkUseTextPathSmall_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseTextPathSmall.CheckedChanged
        If chkUseTextPathSmall.CheckState = CheckState.Checked Then
            txtBrowse.Text = "C:\Users\Matt.Mattrix\Desktop\test"
        End If
    End Sub
#End Region
    'Go Button
    Private Sub BtnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGo.Click
        If txtBrowse.Text = "" Then
            MsgBox("Please select a search location!")
            Exit Sub
        End If
        Cursor = Cursors.AppStarting
        GridForm.lblStartTimeVal.Text = CStr(TimeOfDay)
        Me.Hide()
        SkipSizePasser()
        LoadForm.Show()
        'LoadForm.LblPrgrss.Text = "Checking Total File Size, Please Wait"
        'TotalSize = CheckTotalSize()
        'Console.WriteLine("TotalSize" & TotalSize)
        ''''TotalSizeStep = CInt(100 \ TotalSize)
        ''''Console.WriteLine("TotalSizeStep" & TotalSizeStep)
        ''''LoadForm.ProgressBar1.Maximum = TotalSize
        'Console.WriteLine("loadform maximum: " & LoadForm.ProgressBar1.Maximum)
        'LoadForm.LblPrgrss.Text = "Total File Size: " & TotalSize
        'LoadForm.LblPrgrss.Text = "Scanning...1"
        LoadTimer.Enabled = True
        LoadTimer.Start()
        Worker1.RunWorkerAsync()
    End Sub

    Function CheckTotalSize() As Integer
        Dim SearchPath As String = txtBrowse.Text
        Dim Info As System.IO.DirectoryInfo = New IO.DirectoryInfo(SearchPath)
        Dim Files() As FileSystemInfo = Info.GetFileSystemInfos()

        Return Files.Length
    End Function


#Region "WORKER THREAD"
    Public Sub WorkerThreadFunction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Worker1.DoWork
        Dim objFileInfo As System.IO.FileInfo
        Dim objDir As System.IO.DirectoryInfo
        Dim objSubFolder As System.IO.DirectoryInfo
        Dim Size As Double
        Dim dirpath As String = txtBrowse.Text
        Dim includesubfolders As Boolean = CBool(chkSubFolders.CheckState)
        'Dim i As Integer

        objDir = New System.IO.DirectoryInfo(dirpath)
        StrngPath = objDir.ToString

        Try
            SetupTempDataTable()
            For Each objFileInfo In objDir.GetFiles
                MassFolderSize += objFileInfo.Length
                Size = CDbl(objFileInfo.Length)
                Size = Size / 1024
                Size = CDbl(FormatNumber(Size, 2, , , TriState.False))
                If Size > SkipSize Then
                    AddToTempTable(Size, objFileInfo.Name, objDir.FullName.ToString)
                End If
                'i = i + TotalSizeStep
                'Worker1.ReportProgress(i)
            Next

            If includesubfolders Then
                For Each objSubFolder In objDir.GetDirectories
                    GetSubsSize(objSubFolder)
                    'i = i + TotalSizeStep
                    'Worker1.ReportProgress(i)
                Next
            End If
        Catch NotFound As System.IO.DirectoryNotFoundException
            'MsgBox("Invalid File Path, Please select a new path")
            'Exit Sub
        Catch BadFile As System.IO.FileNotFoundException
        Catch ex As Exception
            MsgBox("***EX***  " & ex.ToString)
            Exit Sub
        Finally
            LoadTimer.Stop()
            LoadTimer.Enabled = False
            Worker1.ReportProgress(100)
            System.Threading.Thread.Sleep(1000)
        End Try
    End Sub
    'sub folders routine (part of WorkerThread)
    Public Sub GetSubsSize(ByVal objsubfolder As DirectoryInfo)
        Dim size As Double
        Dim SubFile As System.IO.FileInfo
        '       Dim Pcnt As Integer
        Try
            For Each SubFile In objsubfolder.GetFiles
                MassFolderSize += SubFile.Length
                size = CDbl(SubFile.Length)
                size = size / 1024
                size = CDbl(FormatNumber(size, 2, , , TriState.False))
                If size > SkipSize Then
                    AddToTempTable(size, SubFile.Name, objsubfolder.FullName.ToString)
                End If
            Next
            For Each objsubfolder In objsubfolder.GetDirectories
                GetSubsSize(objsubfolder)
            Next
        Catch IgnoreError As UnauthorizedAccessException
        Catch NotFound As System.IO.DirectoryNotFoundException
        Catch BadFile As System.IO.FileNotFoundException
        Catch BLAH As Exception
            MsgBox("***BLAH***  " & BLAH.ToString)
        End Try

    End Sub


    Private Sub Worker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker1.RunWorkerCompleted
        ' \ = whole number division, / = precise division
        ' Division for MassFolderSize 
        Dim Format As String
        Dim GridFormSizeWidth As Integer
        Select Case MassFolderSize
            Case 0 To 1024
                'Format is Bytes
                Format = " Bytes"
            Case 1025 To 1048575
                MassFolderSize = MassFolderSize / 1024
                Format = " KB"
            Case 1048576 To 1073741823
                MassFolderSize = MassFolderSize / 1048576
                Format = " MB"
            Case 1073741824 To 1099511627775
                MassFolderSize = MassFolderSize / 1073741824
                Format = " GB"
            Case Is > 1099511627776
                MassFolderSize = MassFolderSize / 1099511627776
                Format = " TB+"
            Case Else
                MsgBox("Incorrect Folder Size")
                Exit Sub
        End Select
        GridForm.Grid.DataSource = TempTable
        MassFolderSize = CDbl(FormatNumber(MassFolderSize, 2, , , TriState.False))
        GridForm.lblTotalSizeVal.Text = MassFolderSize & Format
        GridForm.lblFileCountVal.Text = CStr(GridForm.Grid.Rows.Count)
        MassFolderSize = Nothing
        Cursor = Cursors.Default
        LoadTimer.Stop()
        LoadTimer.Enabled = False
        'set size parameters for new grid
        GridForm.Grid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        GridForm.Grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        GridForm.Grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        GridForm.Grid.Columns(0).FillWeight = 50
        GridForm.Grid.Columns(1).FillWeight = 150
        GridForm.Grid.Columns(2).FillWeight = 300
        GridForm.Grid.AutoResizeColumn(2)

        GridFormSizeWidth = CInt(GridForm.Grid.Columns(0).FillWeight + GridForm.Grid.Columns(1).FillWeight + GridForm.Grid.Columns(2).FillWeight) + 100
        'If GridFormSizeWidth > 500 Then
        'GridForm.MaximumSize = New Size(GridFormSizeWidth, 999999)
        'Else
        'GridForm.MaximumSize = New Size(500, 999999)
        'End If
        GridForm.MinimumSize = New Size(GridForm.GroupBox1.Right + 40, GridForm.Grid.Top + 95)
        GridForm.Show()
        GridForm.lblEndTimeVal.Text = CStr(TimeOfDay)
        LoadForm.LblPrgrss.Text = "FINISHED!!"
        LoadForm.Close()
        Me.Show()
        GridForm.Focus()
    End Sub
    Public Sub SkipSizePasser()

        Select Case CmbSkipSize.Text
            Case "2 GB"
                SkipSize = 2097152
            Case "1 GB"
                SkipSize = 1048576
            Case "500 MB"
                SkipSize = 512000
            Case "250 MB"
                SkipSize = 256000
            Case "125 MB"
                SkipSize = 128000
            Case "62 MB"
                SkipSize = 63488
            Case "30 MB"
                SkipSize = 30720
            Case "15 MB"
                SkipSize = 15360
            Case "7 MB"
                SkipSize = 7168
            Case "1 MB"
                SkipSize = 1024
            Case "100 KB"
                SkipSize = 100
            Case "50 KB"
                SkipSize = 50
            Case "10 KB"
                SkipSize = 10
            Case "1 KB"
                SkipSize = 1
            Case Else
                SkipSize = 0
        End Select
    End Sub
#End Region

    Public Sub BindThreadFunction()
        GridForm.Grid.DataSource = TempTable
        'GridForm.Grid.Columns(0).Resizable = DataGridViewTriState.True
        'GridForm.Grid.Columns(1).Resizable = DataGridViewTriState.True
        'GridForm.Grid.Columns(2).Resizable = DataGridViewTriState.True
    End Sub
#Region "Setup and Add to TempTable"
    Public Sub SetupTempDataTable()
        Try
            TempSize = New DataColumn("File Size (KB)")
            TempName = New DataColumn("File Name")
            TempPath = New DataColumn("File Path")

            TempSize.DataType = System.Type.GetType("System.Double")
            TempName.DataType = System.Type.GetType("System.String")
            TempPath.DataType = System.Type.GetType("System.String")

            TempTable.Columns.Add(TempSize)
            TempTable.Columns.Add(TempName)
            TempTable.Columns.Add(TempPath)

        Catch Ignore As DuplicateNameException
            Exit Sub
        End Try
    End Sub

    Public Sub AddToTempTable(ByVal size As Double, ByVal Name As String, ByVal Folder As String)

        Try
            TempTable.Rows.Add(size, Name, Folder)
        Catch ARG As Exception
            MsgBox("Failed to add row to Temporary Table: " & (ARG.ToString))
            Exit Sub
        End Try
    End Sub
#End Region

    Private Sub Worker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Worker1.ProgressChanged
        LoadForm.ProgressBar1.Value = 250
        LoadForm.LblPrgrss.Text = "Finished Scanning. Gathering Results." & vbCrLf & "WINDOW MAY BECOME UNRESPONSIVE..."

    End Sub

    Public Sub Cancel()
        Thread.CurrentThread.Abort()
    End Sub
    Public Sub SaveToExcel(ByVal SavePath As String)
        Dim i As Integer
        Dim j As Integer

        Using sw As New System.IO.StreamWriter(SavePath)
            For i = 0 To TempTable.Rows.Count - 1
                For j = 0 To TempTable.Columns.Count - 1
                    sw.Write(TempTable.Rows(i).Item(j))
                    sw.Write(",")
                Next
                sw.Write(sw.NewLine)
            Next
        End Using
        MsgBox("File Saved Successfully to: " & vbCrLf & SavePath)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoadTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadTimer.Tick
        Dim s As String = LoadForm.LblPrgrss.Text
        Dim Format As String
        Dim TempMassFolderSize As Double = MassFolderSize

        If SpaceReader.LoadForm.ProgressBar1.Value = 250 Then
            SpaceReader.LoadForm.ProgressBar1.Value = 0
        Else
            SpaceReader.LoadForm.ProgressBar1.Value = SpaceReader.LoadForm.ProgressBar1.Value + 10
        End If
        If Worker1.IsBusy = False Then
            LoadTimer.Stop()
            LoadTimer.Enabled = False
            LoadForm.Close()
            Console.WriteLine("Worker1 is NOT busy")
        Else
  
            Select Case TempMassFolderSize
                Case 0 To 1024
                    'Format is Bytes
                    Format = " Bytes"
                Case 1025 To 1048575
                    TempMassFolderSize = TempMassFolderSize / 1024
                    Format = " KB"
                Case 1048576 To 1073741823
                    TempMassFolderSize = TempMassFolderSize / 1048576
                    Format = " MB"
                Case 1073741824 To 1099511627775
                    TempMassFolderSize = TempMassFolderSize / 1073741824
                    Format = " GB"
                Case Is > 1099511627776
                    TempMassFolderSize = TempMassFolderSize / 1099511627776
                    Format = " TB+"
                Case Else
                    MsgBox("Incorrect Folder Size")
                    Exit Sub
            End Select

            Select Case dot
                Case ""
                    dot = "."
                Case "."
                    dot = ".."
                Case ".."
                    dot = "..."
                Case "..."
                    dot = "...."
                Case "...."
                    dot = "....."
                Case Else
                    dot = ""
            End Select
            'dot = LoadForm.dot.Text
            TempMassFolderSize = CDbl(FormatNumber(TempMassFolderSize, 2, , , TriState.False))
            LoadForm.Text = "Please Wait" & dot
            LoadForm.LblPrgrss.Text = "Scanned " & TempMassFolderSize & " " & Format
        End If
    End Sub
End Class