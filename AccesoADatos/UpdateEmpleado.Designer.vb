<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateEmpleado))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1203, 609)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(317, 115)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(332, 22)
        Me.txtNombre.TabIndex = 15
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(317, 158)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(332, 22)
        Me.txtCategoria.TabIndex = 16
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(317, 201)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(332, 22)
        Me.txtContrasena.TabIndex = 17
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Location = New System.Drawing.Point(317, 243)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(332, 22)
        Me.txtFechaNac.TabIndex = 18
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(326, 290)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(332, 22)
        Me.txtEdad.TabIndex = 19
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(317, 343)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(331, 82)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Button1"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(316, 69)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(332, 22)
        Me.txtCod.TabIndex = 21
        Me.txtCod.Visible = False
        '
        'UpdateEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1355, 744)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UpdateEmpleado"
        Me.Text = "Actualizar Empleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtFechaNac As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtCod As TextBox
End Class
