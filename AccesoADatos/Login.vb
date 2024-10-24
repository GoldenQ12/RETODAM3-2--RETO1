Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txtUser.Text = ""
        txtPassword.Text = ""
        OpenConnection()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        CloseConnection()
        Me.Close()
    End Sub

    Public Sub LoginEmpleado()
        Try
            Dim query As String = "SELECT * FROM Empleados WHERE nombre = '" & txtUser.Text & "' AND contrasena = '" & txtPassword.Text & "'"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet, "Empleados")
            If dataSet.Tables("Empleados").Rows.Count > 0 Then
                If dataSet.Tables("Empleados").Rows(0)("categoria").Equals("Camarero") Then
                    MsgBox("Acceso concedido. Bienvenido" & dataSet.Tables("Empleados").Rows(0)("nombre").ToString)
                    TPVApp.Show()
                    Me.Hide()
                ElseIf dataSet.Tables("Empleados").Rows(0)("categoria").Equals("Gerente") Then
                    MsgBox("Acceso concedido. Bienvenido" & dataSet.Tables("Empleados").Rows(0)("nombre").ToString)
                    AdminPanel.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Usuario o contraseña incorrectos")
            End If
        Catch ex As Exception
            MsgBox("Error al obtener los empleados: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginEmpleado()
        CloseConnection()
    End Sub

    Private Sub ckPasswordChar_CheckedChanged(sender As Object, e As EventArgs) Handles ckPasswordChar.CheckedChanged
        If ckPasswordChar.Checked Then
            txtPassword.PasswordChar = ChrW(0)
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim res = MessageBox.Show("Estas seguro que deseas salir?", "Advertencia", MessageBoxButtons.OKCancel)
        If res = DialogResult.OK Then
            Me.Close()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Acceso concedido. Bienvenido, Camarero!")
        TPVApp.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Acceso concedido. Bienvenido, Gerente!")
        AdminPanel.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
