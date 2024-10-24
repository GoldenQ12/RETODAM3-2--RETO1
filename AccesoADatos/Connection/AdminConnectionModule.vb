Imports System.Data.SqlClient

Module AdminConnectionModule
    Const DATABASE_NAME = "RETO"
    Const DATABASE_SERVER = "GOLDEN-DESKTOP"
    Const DATABASE_SERVER2 = "GOLDEN\MSSQLSERVER04"
    'Consideration: DATABASE_SERVER Refers to My Desktop While DATABASE_SERVER2 Refers to My Laptop
    'UNABLE TO EDIT THE DATABASE_SERVER NAME BECAUSE OF ON INIT ALREADY DONE BY THAT ( ALIAS CAN'T BE IMPLEMENTED ) 
    Const CONNECTION_STRING = "Data Source=" & DATABASE_SERVER & ";Initial Catalog=" & DATABASE_NAME & ";Integrated Security=True"

    Public connection As New SqlConnection(CONNECTION_STRING)

    Public Sub OpenConnection()
        Try
            connection.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            connection.Close()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Module
