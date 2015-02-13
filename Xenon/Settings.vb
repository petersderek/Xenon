Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        History.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Search_Providers.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Themes.ShowDialog()
    End Sub
End Class