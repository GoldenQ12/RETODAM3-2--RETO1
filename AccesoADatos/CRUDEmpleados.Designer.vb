<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUDEmpleados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDEmpleados))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dataEmpleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RETODataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RETODataSet = New AccesoADatos.RETODataSet()
        Me.EmpleadosTableAdapter = New AccesoADatos.RETODataSetTableAdapters.EmpleadosTableAdapter()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechanac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contrasena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RETODataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RETODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1251, 565)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'dataEmpleados
        '
        Me.dataEmpleados.AllowUserToAddRows = False
        Me.dataEmpleados.AllowUserToDeleteRows = False
        Me.dataEmpleados.AutoGenerateColumns = False
        Me.dataEmpleados.BackgroundColor = System.Drawing.Color.White
        Me.dataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.fechanac, Me.categoria, Me.edad, Me.contrasena, Me.codemp})
        Me.dataEmpleados.DataSource = Me.EmpleadosBindingSource
        Me.dataEmpleados.Location = New System.Drawing.Point(75, 26)
        Me.dataEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.dataEmpleados.Name = "dataEmpleados"
        Me.dataEmpleados.ReadOnly = True
        Me.dataEmpleados.RowHeadersWidth = 51
        Me.dataEmpleados.Size = New System.Drawing.Size(842, 596)
        Me.dataEmpleados.TabIndex = 14
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.RETODataSetBindingSource
        '
        'RETODataSetBindingSource
        '
        Me.RETODataSetBindingSource.DataSource = Me.RETODataSet
        Me.RETODataSetBindingSource.Position = 0
        '
        'RETODataSet
        '
        Me.RETODataSet.DataSetName = "RETODataSet"
        Me.RETODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(1343, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(48, 16)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Label1"
        Me.lblNombre.Visible = False
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Location = New System.Drawing.Point(1343, 34)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(48, 16)
        Me.lblFechaNac.TabIndex = 16
        Me.lblFechaNac.Text = "Label2"
        Me.lblFechaNac.Visible = False
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(1343, 73)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(48, 16)
        Me.lblCategoria.TabIndex = 17
        Me.lblCategoria.Text = "Label3"
        Me.lblCategoria.Visible = False
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(1343, 105)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(48, 16)
        Me.lblEdad.TabIndex = 18
        Me.lblEdad.Text = "Label4"
        Me.lblEdad.Visible = False
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(1343, 142)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(48, 16)
        Me.lblContrasena.TabIndex = 19
        Me.lblContrasena.Text = "Label5"
        Me.lblContrasena.Visible = False
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(1343, 169)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(48, 16)
        Me.lblCod.TabIndex = 20
        Me.lblCod.Text = "Label6"
        Me.lblCod.Visible = False
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 82
        '
        'fechanac
        '
        Me.fechanac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.fechanac.DataPropertyName = "fechanac"
        Me.fechanac.HeaderText = "fechanac"
        Me.fechanac.MinimumWidth = 6
        Me.fechanac.Name = "fechanac"
        Me.fechanac.ReadOnly = True
        Me.fechanac.Width = 91
        '
        'categoria
        '
        Me.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.categoria.DataPropertyName = "categoria"
        Me.categoria.HeaderText = "categoria"
        Me.categoria.MinimumWidth = 6
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Width = 93
        '
        'edad
        '
        Me.edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.edad.DataPropertyName = "edad"
        Me.edad.HeaderText = "edad"
        Me.edad.MinimumWidth = 6
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        Me.edad.Width = 68
        '
        'contrasena
        '
        Me.contrasena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.contrasena.DataPropertyName = "contrasena"
        Me.contrasena.HeaderText = "contrasena"
        Me.contrasena.MinimumWidth = 6
        Me.contrasena.Name = "contrasena"
        Me.contrasena.ReadOnly = True
        Me.contrasena.Visible = False
        Me.contrasena.Width = 103
        '
        'codemp
        '
        Me.codemp.DataPropertyName = "codemp"
        Me.codemp.HeaderText = "codemp"
        Me.codemp.MinimumWidth = 6
        Me.codemp.Name = "codemp"
        Me.codemp.ReadOnly = True
        Me.codemp.Visible = False
        Me.codemp.Width = 125
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1037, 565)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 122)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'CRUDEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1403, 700)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.dataEmpleados)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CRUDEmpleados"
        Me.Text = "CRUDEmpleados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RETODataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RETODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dataEmpleados As DataGridView
    Friend WithEvents RETODataSetBindingSource As BindingSource
    Friend WithEvents RETODataSet As RETODataSet
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As RETODataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents fechanac As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
    Friend WithEvents contrasena As DataGridViewTextBoxColumn
    Friend WithEvents codemp As DataGridViewTextBoxColumn
    Public WithEvents lblNombre As Label
    Public WithEvents lblFechaNac As Label
    Public WithEvents lblCategoria As Label
    Public WithEvents lblEdad As Label
    Public WithEvents lblContrasena As Label
    Public WithEvents lblCod As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
