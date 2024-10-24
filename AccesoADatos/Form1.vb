Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        OpenConnection()
        MsgBox("Conexión establecida correctamente")
    End Sub

    
End Class
