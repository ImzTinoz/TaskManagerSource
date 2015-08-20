Imports System.Net

Public Class More
    Private Sub MysticButton2_Click(sender As Object, e As EventArgs) Handles MysticButton2.Click
        Using wc As New WebClient()
            MessageBox.Show(wc.DownloadString("http://imztinoz.pw/TM/v.txt"))
        End Using
    End Sub

    Private Sub MysticButton1_Click(sender As Object, e As EventArgs) Handles MysticButton1.Click
        Features.Show()
    End Sub

    Private Sub MysticButton3_Click(sender As Object, e As EventArgs) Handles MysticButton3.Click
        Dim webAddress As String = "http://www.imztinoz.pw/TM/TaskManager.exe"
        Process.Start(webAddress)
    End Sub
End Class