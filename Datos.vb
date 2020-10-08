Imports System.Data.SqlClient

Public Class Datos
    Private conexion As SqlConnection = New SqlConnection("Data Source=LAPTOP-GKDBUDPG\MSSQLSERVER01;Initial Catalog=Escuela;Integrated Security=True")
    Function Abrir_Conexion() As Boolean
        conexion.Open()
        Return True
    End Function
    Function Cerrar_Conexion() As Boolean
        conexion.Close()
        Return True
    End Function


    '----------------------------------------------------------------------------------------------------------------'
    'Conexiones'
    Function Traductor(ByVal instruccion As String)
        Try
            Dim comando As SqlCommand = New SqlCommand(instruccion, conexion)
            comando.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

End Class
