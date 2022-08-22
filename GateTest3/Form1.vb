Public Class Form1
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserTest.DocumentCompleted
        WebBrowserTest.ScriptErrorsSuppressed = True

    End Sub

    Private Sub btn06Refresh_Click(sender As Object, e As EventArgs) Handles btnTestRefresh.Click
        WebBrowserTest.Refresh()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTestRemote.Click
        WebBrowserTest.Navigate("Http://192.168.225.133#remote")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnG04Remote.Click
        WebBrowserG04.Navigate("Http://192.168.224.42#remote")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserG04.DocumentCompleted
        WebBrowserG04.ScriptErrorsSuppressed = True

    End Sub

    Private Sub btnG04Refresh_Click(sender As Object, e As EventArgs) Handles btnG04Refresh.Click
        WebBrowserG04.Refresh()
    End Sub
End Class
