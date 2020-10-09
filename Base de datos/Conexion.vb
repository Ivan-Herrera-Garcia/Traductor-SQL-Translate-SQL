Imports System.Data.SqlClient


Public Class Conexion
    'Private conexion As SqlConnection = New SqlConnection("Data Source=LAPTOP-GKDBUDPG\MSSQLSERVER01;Initial Catalog=Escuela;Integrated Security=True")
    Private conexion As SqlConnection = New SqlConnection("Data Source=LAPTOP-GKDBUDPG\MSSQLSERVER01;Integrated Security=True")
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
        Catch ex As Exception

            Return False
        End Try
    End Function

    Function Mostrar_datos(ByVal tabla As DataGridView, ByVal instruccion As String)
        Try
            Dim dt As DataTable
            Dim comando As SqlDataAdapter = New SqlDataAdapter(instruccion, conexion)
            dt = New DataTable
            comando.Fill(dt)
            tabla.DataSource = dt
        Catch ex As Exception
            'MessageBox.Show("No se lleno la tabla debido a:" + ex.ToString)
        End Try
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
End Class
