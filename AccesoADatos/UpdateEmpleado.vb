
Public Class UpdateEmpleado
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        CRUDEmpleados.Show()
    End Sub

    Private Sub UpdateEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = CRUDEmpleados.lblNombre.Text
        txtCategoria.Text = CRUDEmpleados.lblCategoria.Text
        txtFechaNac.Text = CRUDEmpleados.lblFechaNac.Text
        txtEdad.Text = CRUDEmpleados.lblEdad.Text
        txtContrasena.Text = CRUDEmpleados.lblContrasena.Text
        txtCod.Text = CRUDEmpleados.lblCod.Text
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ActualizarDatosEmpleado()
    End Sub

    Private Sub ActualizarDatosEmpleado()
        Dim query As String = "UPDATE Empleados SET nombre = '" & txtNombre.Text & "', categoria = '" & txtCategoria.Text & "', fechanac = '" & txtFechaNac.Text & "', edad = '" & txtEdad.Text & "', contrasena = '" & txtContrasena.Text & "' WHERE codemp = " & CRUDEmpleados.lblCod.Text
        Dim command As New SqlClient.SqlCommand(query, connection)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            Else
                connection.Close()
            End If
            command.ExecuteNonQuery()
            CRUDEmpleados.GetEmpleados()
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
End Class