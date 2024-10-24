Imports System.IO

Public Class CRUDEmpleados
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AdminPanel.Show()
        Me.Close()

    End Sub

    Private Sub CRUDEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpleadosTableAdapter.Fill(Me.RETODataSet.Empleados)
        Me.CenterToScreen()
        GetEmpleados()
        AddIconColumns()
    End Sub

    Public Sub GetEmpleados()
        Try
            Dim query As String = "SELECT * FROM Empleados"
            Dim adapter As New SqlClient.SqlDataAdapter(query, connection)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet, "Empleados")
            dataEmpleados.DataSource = dataSet.Tables("Empleados")
            dataEmpleados.Font = New Font("Arial", 14)
            dataEmpleados.AutoSize = True
        Catch ex As Exception
            MsgBox("Error al obtener los empleados: " & ex.Message)
        End Try
    End Sub

    'Añade opciones para borrado y editar
    Private Sub AddIconColumns()
        Dim deleteColumn As New DataGridViewImageColumn()
        Try
            deleteColumn.Image = Image.FromFile(Path.GetFullPath("src/articulos.png"))
            deleteColumn.Name = "deleteDataColumn"
            dataEmpleados.Columns.Add(deleteColumn)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        Dim updateColumn As New DataGridViewImageColumn()
        Try
            updateColumn.Image = Image.FromFile(Path.GetFullPath("src/articulos.png"))
            updateColumn.Name = "updateDataColumn"
            dataEmpleados.Columns.Add(updateColumn)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub DataEmpleados_CellContentClick(sender As Object, data As DataGridViewCellEventArgs) Handles dataEmpleados.CellContentClick

        If data.RowIndex >= 0 Then
            If data.ColumnIndex = dataEmpleados.Columns("deleteDataColumn").Index Then

                Dim diag As DialogResult = MessageBox.Show("Estas seguro que quieres borrar a este empleado?", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                If diag = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM Empleados WHERE codemp = " & dataEmpleados.Rows(data.RowIndex).Cells("codemp").Value
                    Dim command As New SqlClient.SqlCommand(query, connection)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()
                    Catch ex As Exception
                        MsgBox("Error al eliminar el empleado: " & ex.Message)
                    End Try
                    GetEmpleados()
                End If
            ElseIf data.ColumnIndex = dataEmpleados.Columns("updateDataColumn").Index Then
                lblCod.Text = dataEmpleados.Rows(data.RowIndex).Cells("codemp").Value
                lblNombre.Text = dataEmpleados.Rows(data.RowIndex).Cells("nombre").Value
                lblCategoria.Text = dataEmpleados.Rows(data.RowIndex).Cells("categoria").Value
                lblFechaNac.Text = dataEmpleados.Rows(data.RowIndex).Cells("fechanac").Value
                lblEdad.Text = dataEmpleados.Rows(data.RowIndex).Cells("edad").Value
                lblContrasena.Text = dataEmpleados.Rows(data.RowIndex).Cells("contrasena").Value
                connection.Close()
                Me.Hide()
                UpdateEmpleado.Show()
                'TODO We have to implement the update Form, 
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        AddEmpleado.Show()
    End Sub

    'TODO We can implement functions of the Queries, instead of Force Coding inside the click of the cell on IF

End Class
