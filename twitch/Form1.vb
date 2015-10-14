Public Class Form1

    Private appName As String
    Private pyrSpam As String
    Private pyrHeight As Integer


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        pyrSpam = Trim(TextBox1.Text) + " "
        pyrHeight = Int(TextBox2.Text)
        appName = TextBox3.Text

        AppActivate(appName)

        For i = 1 To pyrHeight
            AppActivate(appName)
            For j = 1 To i
                SendKeys.Send(pyrSpam)
            Next
            SendKeys.Send(Chr(13))
            System.Threading.Thread.Sleep(100)
        Next
        For i = pyrHeight - 1 To 1 Step -1
            AppActivate(appName)
            For j = 1 To i
                SendKeys.Send(pyrSpam)
            Next
            SendKeys.Send(Chr(13))
            System.Threading.Thread.Sleep(200)
        Next

        Button1.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
