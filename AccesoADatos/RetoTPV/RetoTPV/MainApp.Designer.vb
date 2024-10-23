<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainApp
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
        Me.dataArticulos = New System.Windows.Forms.DataGridView()
        Me.pictureBoxArticulo = New System.Windows.Forms.PictureBox()
        CType(Me.dataArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataArticulos
        '
        Me.dataArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataArticulos.Location = New System.Drawing.Point(12, 21)
        Me.dataArticulos.Name = "dataArticulos"
        Me.dataArticulos.RowHeadersWidth = 51
        Me.dataArticulos.RowTemplate.Height = 24
        Me.dataArticulos.Size = New System.Drawing.Size(768, 315)
        Me.dataArticulos.TabIndex = 0
        '
        'pictureBoxArticulo
        '
        Me.pictureBoxArticulo.Location = New System.Drawing.Point(21, 33)
        Me.pictureBoxArticulo.Name = "pictureBoxArticulo"
        Me.pictureBoxArticulo.Size = New System.Drawing.Size(100, 50)
        Me.pictureBoxArticulo.TabIndex = 1
        Me.pictureBoxArticulo.TabStop = False
        '
        'MainApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pictureBoxArticulo)
        Me.Controls.Add(Me.dataArticulos)
        Me.Name = "MainApp"
        Me.Text = "TPV"
        CType(Me.dataArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dataArticulos As DataGridView
    Friend WithEvents pictureBoxArticulo As PictureBox
End Class
