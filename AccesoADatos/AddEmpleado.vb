Public Class AddEmpleado
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.CenterToScreen()
        Me.Close()
        CRUDEmpleados.Show()
    End Sub
End Class