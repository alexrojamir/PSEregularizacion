<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regularizacionPSE
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txEmpresa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txRuta = New System.Windows.Forms.TextBox()
        Me.txSerie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbComprobante = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txNumero = New System.Windows.Forms.TextBox()
        Me.btRegularizar = New System.Windows.Forms.Button()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.txRespuesta = New System.Windows.Forms.TextBox()
        Me.btExplorar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa: "
        '
        'txEmpresa
        '
        Me.txEmpresa.Location = New System.Drawing.Point(74, 42)
        Me.txEmpresa.Name = "txEmpresa"
        Me.txEmpresa.ReadOnly = True
        Me.txEmpresa.Size = New System.Drawing.Size(475, 20)
        Me.txEmpresa.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ruta:"
        '
        'txRuta
        '
        Me.txRuta.Location = New System.Drawing.Point(74, 77)
        Me.txRuta.Name = "txRuta"
        Me.txRuta.ReadOnly = True
        Me.txRuta.Size = New System.Drawing.Size(441, 20)
        Me.txRuta.TabIndex = 3
        '
        'txSerie
        '
        Me.txSerie.Location = New System.Drawing.Point(273, 113)
        Me.txSerie.Name = "txSerie"
        Me.txSerie.ReadOnly = True
        Me.txSerie.Size = New System.Drawing.Size(68, 20)
        Me.txSerie.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo Comprobante:"
        '
        'cbComprobante
        '
        Me.cbComprobante.FormattingEnabled = True
        Me.cbComprobante.Items.AddRange(New Object() {"Seleccione", "BOLETA", "FACTURA"})
        Me.cbComprobante.Location = New System.Drawing.Point(117, 113)
        Me.cbComprobante.Name = "cbComprobante"
        Me.cbComprobante.Size = New System.Drawing.Size(101, 21)
        Me.cbComprobante.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Serie:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(361, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Número:"
        '
        'txNumero
        '
        Me.txNumero.Location = New System.Drawing.Point(414, 113)
        Me.txNumero.Name = "txNumero"
        Me.txNumero.Size = New System.Drawing.Size(68, 20)
        Me.txNumero.TabIndex = 8
        '
        'btRegularizar
        '
        Me.btRegularizar.Location = New System.Drawing.Point(17, 144)
        Me.btRegularizar.Name = "btRegularizar"
        Me.btRegularizar.Size = New System.Drawing.Size(532, 23)
        Me.btRegularizar.TabIndex = 10
        Me.btRegularizar.Text = "Regularizar"
        Me.btRegularizar.UseVisualStyleBackColor = True
        '
        'btNuevo
        '
        Me.btNuevo.Location = New System.Drawing.Point(17, 12)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(532, 23)
        Me.btNuevo.TabIndex = 11
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'txRespuesta
        '
        Me.txRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRespuesta.Location = New System.Drawing.Point(17, 173)
        Me.txRespuesta.Multiline = True
        Me.txRespuesta.Name = "txRespuesta"
        Me.txRespuesta.ReadOnly = True
        Me.txRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txRespuesta.Size = New System.Drawing.Size(532, 198)
        Me.txRespuesta.TabIndex = 12
        '
        'btExplorar
        '
        Me.btExplorar.Location = New System.Drawing.Point(521, 77)
        Me.btExplorar.Name = "btExplorar"
        Me.btExplorar.Size = New System.Drawing.Size(28, 21)
        Me.btExplorar.TabIndex = 13
        Me.btExplorar.Text = "..."
        Me.btExplorar.UseVisualStyleBackColor = True
        '
        'regularizacionPSE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 383)
        Me.Controls.Add(Me.btExplorar)
        Me.Controls.Add(Me.txRespuesta)
        Me.Controls.Add(Me.btNuevo)
        Me.Controls.Add(Me.btRegularizar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txNumero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbComprobante)
        Me.Controls.Add(Me.txSerie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txRuta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txEmpresa)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "regularizacionPSE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regularización PSE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txEmpresa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txRuta As TextBox
    Friend WithEvents txSerie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbComprobante As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txNumero As TextBox
    Friend WithEvents btRegularizar As Button
    Friend WithEvents btNuevo As Button
    Friend WithEvents txRespuesta As TextBox
    Friend WithEvents btExplorar As Button
End Class
