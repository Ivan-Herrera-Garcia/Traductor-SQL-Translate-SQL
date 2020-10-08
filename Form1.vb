Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Reflection.Emit
Imports System.Text
Imports System.Timers

Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cadena As String = "La base de datos cuenta con los siguentes atributos: nombre_completo varchar(30), edad int, exo Char(3) null default 'M', id Char(8) primary key, carrera varchar(30)"


        MessageBox.Show(cadena, "Informacion", MessageBoxButtons.OK)


    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

        Dim Ejecutar As Datos = New Datos()
        Ejecutar.Abrir_Conexion()
        Dim a As Boolean
        a = Ejecutar.Traductor(RichTextBox1.Text)
        If (a = True) Then
            DialogResult = MessageBox.Show("Comando ejecutado correctamente, ¿desea eliminar los datos en el campo?", "Informacion", MessageBoxButtons.YesNo)
            If (DialogResult.Yes) Then
                RichTextBox1.Clear()
            End If
        Else
            MessageBox.Show("Error en el comando", "Informacion", MessageBoxButtons.OK)
        End If
        Ejecutar.Cerrar_Conexion()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        MessageBox.Show("CONSULTE AL DESARROLLADOR", "Ayuda", MessageBoxButtons.OK)
    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        Close()

    End Sub
End Class
