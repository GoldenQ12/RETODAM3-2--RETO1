Public Class CRUDEmpleados
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AdminPanel.Show()
        Me.Close()

    End Sub

    Private Sub CRUDEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        GetEmpleados()
    End Sub

    Public Sub GetEmpleados()
        Try
            Dim query As String = "SELECT * FROM Empleados"
            Dim adapter As New SqlClient.SqlDataAdapter(query, connection)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet, "Empleados")
            dataEmpleados.DataSource = dataSet.Tables("Empleados")
            dataEmpleados.Font = New Font("Arial", 14)
            dataEmpleados.AutoResizeColumns()
            dataEmpleados.AutoSize = True
        Catch ex As Exception
            MsgBox("Error al obtener los empleados: " & ex.Message)
        End Try
    End Sub

End Class