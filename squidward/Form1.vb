Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Shell("control.exe /name Microsoft.Personalization /page pageWallpaper", 1)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Shell("control.exe /name Microsoft.Personalization /page pageColorization", 1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Shell("control /name Microsoft.TaskbarAndStartMenu", 1)
    End Sub
End Class
