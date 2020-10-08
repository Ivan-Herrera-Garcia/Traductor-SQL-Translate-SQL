Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Reflection.Emit
Imports System.Text

Public Class Form1
    'En este Form se mostraba un RichText para la escritura
    
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim Ejecutar As Datos = New Datos()         'Se crea un objeto del tipo Datos (Conexion con SQL)
        Ejecutar.Abrir_Conexion()                   'Se abre la conexion con SQL
        Dim a As Boolean                
        a = Ejecutar.Traductor(RichTextBox1.Text)   'Se envia la cadena de texto para ejecutar la sentencia, si hay algun error en la sintaxis o error en los datos regresara un
        If (a = True) Then                          'falso, enviara un mensaje el cual nos dira que ocurrio un error.
            DialogResult = MessageBox.Show("Comando ejecutado correctamente, ¿desea eliminar los datos en el campo?", "Informacion", MessageBoxButtons.YesNo)
            If (DialogResult.Yes) Then
                RichTextBox1.Clear()
            End If
        Else
            MessageBox.Show("Error en el comando", "Informacion", MessageBoxButtons.OK)
        End If
        Ejecutar.Cerrar_Conexion()                  'Se cierra la conexion
    End Sub
End Class


'Si no se cierra la conexion puede haber perdida de datos o que ocurra un error inesperado con SQL lo que nos podria colapsar todo el programa
