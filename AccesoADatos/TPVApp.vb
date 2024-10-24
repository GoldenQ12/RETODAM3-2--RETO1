Imports AccesoADatos
Public Class TPVApp

    Private Sub TPVApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblName.Text = AccesoADatos.Login.txtUser.Text
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim res = MessageBox.Show("Estas seguro que deseas cerrar sesion?", "Advertencia", MessageBoxButtons.OKCancel)
        If res = DialogResult.OK Then
            Me.Close()
            AccesoADatos.Login.txtUser.Text = ""
            AccesoADatos.Login.txtPassword.Text = ""
            Login.Show()
        End If
    End Sub


End Class