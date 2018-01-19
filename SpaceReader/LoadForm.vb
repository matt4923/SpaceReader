
Public Class LoadForm

    Public Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        SpaceReader.Main.Cancel()
    End Sub
End Class