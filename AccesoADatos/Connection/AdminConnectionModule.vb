Imports System.Data.SqlClient

Module AdminConnectionModule
    Const DATABASE_NAME = "RETO"
    Const DATABASE_SERVER = "GOLDEN-DESKTOP"
    'TODO Implement Merge Database from Desktop to Laptop
    Const DATABASE_SERVER2 = "GOLDEN\MSSQLSERVER04"
    Const CONNECTION_STRING = "Data Source=" & DATABASE_SERVER2 & ";Initial Catalog=" & DATABASE_NAME & ";Integrated Security=True"

    Public connection As New SqlConnection(CONNECTION_STRING)

    Public Sub OpenConnection()
        Try
            If connection.State = 1 Then
                connection.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            If connection.State = 1 Then
                connection.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Module
