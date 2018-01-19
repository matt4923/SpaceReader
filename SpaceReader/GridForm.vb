Public Class GridForm
    Public Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main.TempTable.Clear()
        Me.Close()
    End Sub

    Private Sub GridForm_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Button1.Location = New Point(Grid.Right - 100, Grid.Bottom + 7)
        btnSave.Location = New Point(Button1.Left - 90, Grid.Bottom + 7)
        btnHelp.Location = New Point(btnSave.Left - 50, Grid.Bottom + 7)
        'lblINFO.Location = New Point(Grid.Left + 50, Grid.Bottom + 7)
        'add resizing for the 3rd column
    End Sub


    Private Sub Grid_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentDoubleClick
        If Grid.CurrentCell.ColumnIndex = 2 Then
            Dim CellVal As String = Grid.CurrentCell.Value.ToString
            System.Diagnostics.Process.Start("Explorer.exe", CellVal)
        ElseIf Grid.CurrentCell.ColumnIndex = 0 Then
            Dim CellValInt As Integer = CInt(Grid.CurrentCell.Value)
            Dim format As String
            Select Case CellValInt
                Case 0 To 1024
                    format = " KB"
                Case 1025 To 1048575
                    CellValInt = CInt(CDbl(CellValInt) / 1024)
                    format = " MB"
                Case 1048576 To 1073741823
                    CellValInt = CInt(CDbl(CellValInt) / 1048576)
                    format = " GB"
                Case Is > 1073741824
                    CellValInt = CInt(CDbl(CellValInt) / 1073741824)
                    format = " TB+"
                Case Else
                    MsgBox("Incorrect Folder Size")
                    Exit Sub
            End Select
            lblINFO.Text = "Selected File Size: " & CellValInt & " " & format
            lblINFO.Visible = True
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        HelpForm.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim SaveFileDialog1 As SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        With SaveFileDialog1
            .DefaultExt = ".csv"
            .Filter = "Comma Delimited|*.csv"
            SaveFileDialog1.ShowDialog()
        End With
        If SaveFileDialog1.FileName = Nothing Then
            Exit Sub
        End If
        Main.SaveToExcel(SaveFileDialog1.FileName.ToString())
    End Sub
End Class