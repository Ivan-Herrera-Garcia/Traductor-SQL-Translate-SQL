Imports System.Data.SqlClient

Public Class Datos
    Private conexion As SqlConnection = New SqlConnection("Data Source=LAPTOP-GKDBUDPG\MSSQLSERVER01;Initial Catalog=Escuela;Integrated Security=True")
    'Para la conexion se necesita el nombre del servidor'
    'Tambien se necesitara tener existente la base de datos a usar, en este caso sera 'Escuela'
    Function Abrir_Conexion() As Boolean
        conexion.Open() 'Abre conexion
        Return True
    End Function
    Function Cerrar_Conexion() As Boolean
        conexion.Close() 'Cierra conexion
        Return True
    End Function


    '----------------------------------------------------------------------------------------------------------------'
    'Conexiones'
    Function Traductor(ByVal instruccion As String) 'Envia una cadena en la cual va la sentencia SQL
        Try
            Dim comando As SqlCommand = New SqlCommand(instruccion, conexion) 'La instruccion y la conexion para poder abrir un canal a SQL
            comando.ExecuteNonQuery()
            Return True
        Catch
            Return False
        End Try
    End Function

End Class
