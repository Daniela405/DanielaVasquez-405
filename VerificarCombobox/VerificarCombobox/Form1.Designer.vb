<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmbEquipos = New System.Windows.Forms.ComboBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbEquipos
        '
        Me.cmbEquipos.FormattingEnabled = True
        Me.cmbEquipos.Items.AddRange(New Object() {"Motagua", "Real Madrid", "Olimpia"})
        Me.cmbEquipos.Location = New System.Drawing.Point(93, 83)
        Me.cmbEquipos.Name = "cmbEquipos"
        Me.cmbEquipos.Size = New System.Drawing.Size(121, 28)
        Me.cmbEquipos.TabIndex = 3
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(109, 141)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(92, 36)
        Me.btnVerificar.TabIndex = 2
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(313, 271)
        Me.Controls.Add(Me.cmbEquipos)
        Me.Controls.Add(Me.btnVerificar)
        Me.Name = "Form1"
        Me.Text = "Verificar Combobox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbEquipos As ComboBox
    Friend WithEvents btnVerificar As Button
End Class
