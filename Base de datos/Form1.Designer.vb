<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.barradown = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.barraup = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.AlumnoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AlumnoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Ejemplo1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejemplo2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejemplo3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.estado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EscuelaDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EscuelaDataSet = New Base_de_datos.EscuelaDataSet()
        Me.AlumnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnoTableAdapter = New Base_de_datos.EscuelaDataSetTableAdapters.AlumnoTableAdapter()
        Me.EscuelaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.barradown.SuspendLayout()
        Me.barraup.SuspendLayout()
        CType(Me.AlumnoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.EscuelaDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscuelaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EscuelaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barradown
        '
        Me.barradown.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6})
        Me.barradown.Location = New System.Drawing.Point(0, 545)
        Me.barradown.Name = "barradown"
        Me.barradown.Size = New System.Drawing.Size(620, 22)
        Me.barradown.TabIndex = 0
        Me.barradown.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(143, 17)
        Me.ToolStripStatusLabel4.Text = "Autor: Ivan Herrera Garcia"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(337, 17)
        Me.ToolStripStatusLabel5.Spring = True
        Me.ToolStripStatusLabel5.Text = "Instituto Tecnologico de la Laguna"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(125, 17)
        Me.ToolStripStatusLabel6.Text = "Taller de base de datos"
        '
        'barraup
        '
        Me.barraup.Dock = System.Windows.Forms.DockStyle.Top
        Me.barraup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.barraup.Location = New System.Drawing.Point(0, 0)
        Me.barraup.Name = "barraup"
        Me.barraup.Size = New System.Drawing.Size(620, 22)
        Me.barraup.TabIndex = 1
        Me.barraup.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel7.Text = "Borrar"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabel1.Text = "Ejecutar"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel2.Text = "Ayuda"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(29, 17)
        Me.ToolStripStatusLabel3.Text = "Salir"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(620, 284)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'AlumnoBindingSource1
        '
        Me.AlumnoBindingSource1.DataMember = "Alumno"
        Me.AlumnoBindingSource1.DataSource = Me.EscuelaDataSetBindingSource1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 315)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(620, 227)
        Me.DataGridView1.TabIndex = 3
        '
        'AlumnoBindingSource2
        '
        Me.AlumnoBindingSource2.DataMember = "Alumno"
        Me.AlumnoBindingSource2.DataSource = Me.EscuelaDataSetBindingSource1
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejemplo1ToolStripMenuItem, Me.Ejemplo2ToolStripMenuItem, Me.Ejemplo3ToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "Ejemplos"
        '
        'Ejemplo1ToolStripMenuItem
        '
        Me.Ejemplo1ToolStripMenuItem.Name = "Ejemplo1ToolStripMenuItem"
        Me.Ejemplo1ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.Ejemplo1ToolStripMenuItem.Text = "Ejemplo 1"
        '
        'Ejemplo2ToolStripMenuItem
        '
        Me.Ejemplo2ToolStripMenuItem.Name = "Ejemplo2ToolStripMenuItem"
        Me.Ejemplo2ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.Ejemplo2ToolStripMenuItem.Text = "Ejemplo 2"
        '
        'Ejemplo3ToolStripMenuItem
        '
        Me.Ejemplo3ToolStripMenuItem.Name = "Ejemplo3ToolStripMenuItem"
        Me.Ejemplo3ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.Ejemplo3ToolStripMenuItem.Text = "Ejemplo 3"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.estado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 523)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(620, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'estado
        '
        Me.estado.ForeColor = System.Drawing.Color.ForestGreen
        Me.estado.LinkColor = System.Drawing.Color.White
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(45, 17)
        Me.estado.Text = "Estado:"
        '
        'EscuelaDataSetBindingSource1
        '
        Me.EscuelaDataSetBindingSource1.DataSource = Me.EscuelaDataSet
        Me.EscuelaDataSetBindingSource1.Position = 0
        '
        'EscuelaDataSet
        '
        Me.EscuelaDataSet.DataSetName = "EscuelaDataSet"
        Me.EscuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnoBindingSource
        '
        Me.AlumnoBindingSource.DataMember = "Alumno"
        Me.AlumnoBindingSource.DataSource = Me.EscuelaDataSet
        '
        'AlumnoTableAdapter
        '
        Me.AlumnoTableAdapter.ClearBeforeFill = True
        '
        'EscuelaDataSetBindingSource
        '
        Me.EscuelaDataSetBindingSource.DataSource = Me.EscuelaDataSet
        Me.EscuelaDataSetBindingSource.Position = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(620, 567)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.barraup)
        Me.Controls.Add(Me.barradown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Traductor SQL-Visual Basic"
        Me.barradown.ResumeLayout(False)
        Me.barradown.PerformLayout()
        Me.barraup.ResumeLayout(False)
        Me.barraup.PerformLayout()
        CType(Me.AlumnoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.EscuelaDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscuelaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EscuelaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barradown As StatusStrip
    Friend WithEvents barraup As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents EscuelaDataSet As EscuelaDataSet
    Friend WithEvents AlumnoBindingSource As BindingSource
    Friend WithEvents AlumnoTableAdapter As EscuelaDataSetTableAdapters.AlumnoTableAdapter
    Friend WithEvents EscuelaDataSetBindingSource As BindingSource
    Friend WithEvents EscuelaDataSetBindingSource1 As BindingSource
    Friend WithEvents AlumnoBindingSource1 As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AlumnoBindingSource2 As BindingSource
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents Ejemplo1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejemplo2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejemplo3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents estado As ToolStripStatusLabel
End Class
