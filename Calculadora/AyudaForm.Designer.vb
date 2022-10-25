<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AyudaForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxHelp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxHelp
        '
        Me.TextBoxHelp.Enabled = False
        Me.TextBoxHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHelp.Location = New System.Drawing.Point(11, 11)
        Me.TextBoxHelp.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHelp.Multiline = True
        Me.TextBoxHelp.Name = "TextBoxHelp"
        Me.TextBoxHelp.ReadOnly = True
        Me.TextBoxHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxHelp.Size = New System.Drawing.Size(353, 293)
        Me.TextBoxHelp.TabIndex = 3
        '
        'AyudaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 318)
        Me.Controls.Add(Me.TextBoxHelp)
        Me.Name = "AyudaForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxHelp As TextBox
End Class
