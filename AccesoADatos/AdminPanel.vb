Imports System.Data.SqlClient
Imports AccesoADatos

Public Class AdminPanel
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim res = MessageBox.Show("Estas seguro que deseas cerrar sesion?", "Advertencia", MessageBoxButtons.OKCancel)
        If res = DialogResult.OK Then
            AccesoADatos.Login.txtUser.Text = ""
            AccesoADatos.Login.txtPassword.Text = ""
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblName.Text = AccesoADatos.Login.txtUser.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CRUDEmpleados.Show()
    End Sub

End Class