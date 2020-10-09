Imports System.Data.SqlClient

Public Class Datos
    Private conexion As SqlConnection = New SqlConnection("Data Source=LAPTOP-GKDBUDPG\MSSQLSERVER01;Integrated Security=True")
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
    
    Function Mostrar_datos(ByVal tabla As DataGridView, ByVal instruccion As String)'Recibe una tabla del tipo DataGridView y una cadena de texto
        Try
            Dim dt As DataTable                                                     'Se crea una tabla de datos
            Dim comando As SqlDataAdapter = New SqlDataAdapter(instruccion, conexion) 
            'Se crea el metodo recibiendo la instruccion (String) y la conexion
            dt = New DataTable
            comando.Fill(dt)
            tabla.DataSource = dt 
        Catch ex As Exception
            'MessageBox.Show("No se lleno la tabla debido a:" + ex.ToString)
        End Try
End Class
