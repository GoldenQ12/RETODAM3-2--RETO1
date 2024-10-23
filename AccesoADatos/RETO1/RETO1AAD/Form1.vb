Imports ComponenteItem

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim component As New UserControl1()
        component.Size = New Size(100, 100)
        component.Location = New Point(100, 100)
        Me.Controls.Add(component)
    End Sub
End Class
