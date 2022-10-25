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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.factorialButton = New System.Windows.Forms.Button()
        Me.potenciaButton = New System.Windows.Forms.Button()
        Me.cuboButton = New System.Windows.Forms.Button()
        Me.cuadradoButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.textInput = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.inversaButton = New System.Windows.Forms.Button()
        Me.porcentajeButton = New System.Windows.Forms.Button()
        Me.igualButton = New System.Windows.Forms.Button()
        Me.dotButton = New System.Windows.Forms.Button()
        Me.signoButton = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.multiplicaButton = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.restaButton = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.sumaButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.backSpaceButton = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.std = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.sci = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.factorialButton)
        Me.Panel1.Controls.Add(Me.potenciaButton)
        Me.Panel1.Controls.Add(Me.cuboButton)
        Me.Panel1.Controls.Add(Me.cuadradoButton)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 399)
        Me.Panel1.TabIndex = 0
        '
        'factorialButton
        '
        Me.factorialButton.Location = New System.Drawing.Point(259, 243)
        Me.factorialButton.Name = "factorialButton"
        Me.factorialButton.Size = New System.Drawing.Size(55, 45)
        Me.factorialButton.TabIndex = 9
        Me.factorialButton.Text = "n!"
        Me.factorialButton.UseVisualStyleBackColor = True
        '
        'potenciaButton
        '
        Me.potenciaButton.Location = New System.Drawing.Point(259, 192)
        Me.potenciaButton.Name = "potenciaButton"
        Me.potenciaButton.Size = New System.Drawing.Size(55, 45)
        Me.potenciaButton.TabIndex = 8
        Me.potenciaButton.Text = "x^y"
        Me.potenciaButton.UseVisualStyleBackColor = True
        '
        'cuboButton
        '
        Me.cuboButton.Location = New System.Drawing.Point(259, 141)
        Me.cuboButton.Name = "cuboButton"
        Me.cuboButton.Size = New System.Drawing.Size(55, 45)
        Me.cuboButton.TabIndex = 7
        Me.cuboButton.Text = "x^3"
        Me.cuboButton.UseVisualStyleBackColor = True
        '
        'cuadradoButton
        '
        Me.cuadradoButton.Location = New System.Drawing.Point(259, 90)
        Me.cuadradoButton.Name = "cuadradoButton"
        Me.cuadradoButton.Size = New System.Drawing.Size(55, 45)
        Me.cuadradoButton.TabIndex = 6
        Me.cuadradoButton.Text = "x^2"
        Me.cuadradoButton.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.textInput, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.154518!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27717!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.56831!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(253, 399)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'textInput
        '
        Me.textInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textInput.Location = New System.Drawing.Point(3, 27)
        Me.textInput.Name = "textInput"
        Me.textInput.Size = New System.Drawing.Size(247, 49)
        Me.textInput.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.inversaButton, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.porcentajeButton, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.igualButton, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.dotButton, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.signoButton, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd0, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.divideButton, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd3, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd2, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.multiplicaButton, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd6, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd5, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.restaButton, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd9, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd8, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd7, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.sumaButton, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.deleteButton, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.clearButton, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.backSpaceButton, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 87)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(247, 309)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'inversaButton
        '
        Me.inversaButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inversaButton.Location = New System.Drawing.Point(64, 258)
        Me.inversaButton.Name = "inversaButton"
        Me.inversaButton.Size = New System.Drawing.Size(55, 48)
        Me.inversaButton.TabIndex = 25
        Me.inversaButton.Text = "1/x"
        Me.inversaButton.UseVisualStyleBackColor = True
        '
        'porcentajeButton
        '
        Me.porcentajeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.porcentajeButton.Location = New System.Drawing.Point(3, 258)
        Me.porcentajeButton.Name = "porcentajeButton"
        Me.porcentajeButton.Size = New System.Drawing.Size(55, 48)
        Me.porcentajeButton.TabIndex = 24
        Me.porcentajeButton.Text = "%"
        Me.porcentajeButton.UseVisualStyleBackColor = True
        '
        'igualButton
        '
        Me.igualButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.igualButton.Location = New System.Drawing.Point(186, 207)
        Me.igualButton.Name = "igualButton"
        Me.igualButton.Size = New System.Drawing.Size(58, 45)
        Me.igualButton.TabIndex = 23
        Me.igualButton.Text = "="
        Me.igualButton.UseVisualStyleBackColor = True
        '
        'dotButton
        '
        Me.dotButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dotButton.Location = New System.Drawing.Point(125, 207)
        Me.dotButton.Name = "dotButton"
        Me.dotButton.Size = New System.Drawing.Size(55, 45)
        Me.dotButton.TabIndex = 22
        Me.dotButton.Text = "."
        Me.dotButton.UseVisualStyleBackColor = True
        '
        'signoButton
        '
        Me.signoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.signoButton.Location = New System.Drawing.Point(64, 207)
        Me.signoButton.Name = "signoButton"
        Me.signoButton.Size = New System.Drawing.Size(55, 45)
        Me.signoButton.TabIndex = 21
        Me.signoButton.Text = "+/-"
        Me.signoButton.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd0.Location = New System.Drawing.Point(3, 207)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(55, 45)
        Me.cmd0.TabIndex = 20
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.divideButton.Location = New System.Drawing.Point(186, 156)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(58, 45)
        Me.divideButton.TabIndex = 18
        Me.divideButton.Text = "/"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd3.Location = New System.Drawing.Point(125, 156)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(55, 45)
        Me.cmd3.TabIndex = 17
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd2.Location = New System.Drawing.Point(64, 156)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(55, 45)
        Me.cmd2.TabIndex = 16
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd1.Location = New System.Drawing.Point(3, 156)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(55, 45)
        Me.cmd1.TabIndex = 15
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'multiplicaButton
        '
        Me.multiplicaButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.multiplicaButton.Location = New System.Drawing.Point(186, 105)
        Me.multiplicaButton.Name = "multiplicaButton"
        Me.multiplicaButton.Size = New System.Drawing.Size(58, 45)
        Me.multiplicaButton.TabIndex = 13
        Me.multiplicaButton.Text = "*"
        Me.multiplicaButton.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd6.Location = New System.Drawing.Point(125, 105)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(55, 45)
        Me.cmd6.TabIndex = 12
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd5.Location = New System.Drawing.Point(64, 105)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(55, 45)
        Me.cmd5.TabIndex = 11
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd4.Location = New System.Drawing.Point(3, 105)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(55, 45)
        Me.cmd4.TabIndex = 10
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'restaButton
        '
        Me.restaButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.restaButton.Location = New System.Drawing.Point(186, 54)
        Me.restaButton.Name = "restaButton"
        Me.restaButton.Size = New System.Drawing.Size(58, 45)
        Me.restaButton.TabIndex = 8
        Me.restaButton.Text = "-"
        Me.restaButton.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd9.Location = New System.Drawing.Point(125, 54)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(55, 45)
        Me.cmd9.TabIndex = 7
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd8.Location = New System.Drawing.Point(64, 54)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(55, 45)
        Me.cmd8.TabIndex = 6
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd7.Location = New System.Drawing.Point(3, 54)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(55, 45)
        Me.cmd7.TabIndex = 5
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'sumaButton
        '
        Me.sumaButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sumaButton.Location = New System.Drawing.Point(186, 3)
        Me.sumaButton.Name = "sumaButton"
        Me.sumaButton.Size = New System.Drawing.Size(58, 45)
        Me.sumaButton.TabIndex = 3
        Me.sumaButton.Text = "+"
        Me.sumaButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deleteButton.Location = New System.Drawing.Point(125, 3)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(55, 45)
        Me.deleteButton.TabIndex = 2
        Me.deleteButton.Text = "CE"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clearButton.Location = New System.Drawing.Point(64, 3)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(55, 45)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "C"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'backSpaceButton
        '
        Me.backSpaceButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backSpaceButton.Location = New System.Drawing.Point(3, 3)
        Me.backSpaceButton.Name = "backSpaceButton"
        Me.backSpaceButton.Size = New System.Drawing.Size(55, 45)
        Me.backSpaceButton.TabIndex = 0
        Me.backSpaceButton.Tag = ""
        Me.backSpaceButton.Text = "<-"
        Me.backSpaceButton.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.std, Me.ToolStripSeparator1, Me.sci})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(322, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'std
        '
        Me.std.Name = "std"
        Me.std.Size = New System.Drawing.Size(52, 22)
        Me.std.Text = "Estándar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'sci
        '
        Me.sci.Name = "sci"
        Me.sci.Size = New System.Drawing.Size(57, 22)
        Me.sci.Text = "Científica"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 399)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents textInput As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents inversaButton As Button
    Friend WithEvents porcentajeButton As Button
    Friend WithEvents igualButton As Button
    Friend WithEvents dotButton As Button
    Friend WithEvents signoButton As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents divideButton As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents multiplicaButton As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents restaButton As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents sumaButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents backSpaceButton As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents std As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents sci As ToolStripLabel
    Friend WithEvents factorialButton As Button
    Friend WithEvents potenciaButton As Button
    Friend WithEvents cuboButton As Button
    Friend WithEvents cuadradoButton As Button
End Class
