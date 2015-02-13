Public Class Form1
    Dim int As Integer = 0
     Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
    End Sub
    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        TabControl1.SelectedTab.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        ComboBox1.Text = CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("www.google.com")
    End Sub
    Private Sub AddTabToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddTabToolStripMenuItem.Click
        Dim Browser As New WebBrowser
        TabControl1.TabPages.Add("New Page")
        TabControl1.SelectTab(int)
        Browser.Name = "Web Browser"
        Browser.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(Browser)
        AddHandler Browser.ProgressChanged, AddressOf Loading
        AddHandler Browser.DocumentCompleted, AddressOf Done
        int = int + 1
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub
    Private Sub RemoveTabToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveTabToolStripMenuItem.Click
        If Not TabControl1.TabPages.Count = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
            int = int - 1
        End If
    End Sub
    Private Sub WebsiteProperitesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPropertiesDialog()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Stop()
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub
    Private Sub ComboBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(ComboBox1.Text)
        End If
    End Sub
    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Cut", False, vbNull)
    End Sub
    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Copy", False, vbNull)
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Document.ExecCommand("Paste", False, vbNull)
    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PreviewToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
    End Sub
    Private Sub PageSetupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetupToolStripMenuItem.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPageSetupDialog()
    End Sub
    Private Sub PrintToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintDialog()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Bookmarks.ShowDialog()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = ("browser:settings") Then Settings.ShowDialog()
        If ComboBox1.Text = ("browser:bookmarks") Then Bookmarks.ShowDialog()
        If ComboBox1.Text = ("browser:print") Then CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).ShowPrintPreviewDialog()
        If ComboBox1.Text = ("browser:about") Then AboutBox1.ShowDialog()
        If ComboBox1.Text = ("browser:help") Then Help.ShowDialog()
        If ComboBox1.Text = ("browser:searchproviders") Then Search_Providers.ShowDialog()
        If ComboBox1.Text = ("browser:themes") Then Themes.ShowDialog()
        If ComboBox1.Text = ("browser:history") Then History.ShowDialog()
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.google.com/?gws_rd=ssl#q=" & ComboBox1.Text)
    End Sub
    Private Sub ViewBookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBookmarksToolStripMenuItem.Click
        Bookmarks.ShowDialog()
    End Sub
    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        History.ShowDialog()
    End Sub
    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        Help.ShowDialog()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
