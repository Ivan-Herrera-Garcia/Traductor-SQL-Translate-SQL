Imports System.Drawing.Color

Public Class Form1
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Dim Ejecutar As Conexion = New Conexion()
        Ejecutar.Abrir_Conexion()
        Dim a As Boolean
        a = Ejecutar.Traductor(RichTextBox1.Text) Or Ejecutar.Mostrar_datos(DataGridView1, RichTextBox1.Text)
        If (a = True) Then
            DialogResult = MessageBox.Show("Comando ejecutado correctamente", "Informacion", MessageBoxButtons.OK)
            estado.Text = "Estado: Comando ejecutado correctamente"
        Else
            MessageBox.Show("Error en el comando", "Informacion", MessageBoxButtons.OK)
            estado.ForeColor = Color.Red
            estado.Text = "Estado: Error en el Comando"


        End If
        Ejecutar.Cerrar_Conexion()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Close()

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        MessageBox.Show("CONSULTE AL DESARROLLADOR", "Ayuda", MessageBoxButtons.OK)
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.AlumnoTableAdapter.FillBy(Me.EscuelaDataSet.Alumno)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripStatusLabel7_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel7.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Ejemplo1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejemplo1ToolStripMenuItem.Click
        RichTextBox1.Text = "use Escuela Select * From Alumno"
    End Sub

    Private Sub Ejemplo2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejemplo2ToolStripMenuItem.Click
        RichTextBox1.Text = "use Escuela insert into Alumno values('Jorge',20,'M','19130539','SISTEMAS')"
    End Sub

    Private Sub Ejemplo3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejemplo3ToolStripMenuItem.Click
        RichTextBox1.Text = "use Escuela create table Materia (
                                                idmateria char(10) primary key,
                                                nombre varchar(30), 
                                                )"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("No olvide abrir conexion si es su primera vez en el programa y cambiar el Data Source en la clase Conexion", "Impotante", MessageBoxButtons.OK)
    End Sub
End Class
