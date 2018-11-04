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
        Me.cboTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtCompra = New System.Windows.Forms.RadioButton()
        Me.rbtVenta = New System.Windows.Forms.RadioButton()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.btnFormNuevoCliente = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoVehiculo.FormattingEnabled = True
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(167, 146)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(174, 21)
        Me.cboTipoVehiculo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Vehiculo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipo de servicio"
        '
        'rbtCompra
        '
        Me.rbtCompra.AutoSize = True
        Me.rbtCompra.Checked = True
        Me.rbtCompra.Location = New System.Drawing.Point(168, 116)
        Me.rbtCompra.Name = "rbtCompra"
        Me.rbtCompra.Size = New System.Drawing.Size(61, 17)
        Me.rbtCompra.TabIndex = 5
        Me.rbtCompra.TabStop = True
        Me.rbtCompra.Text = "Compra"
        Me.rbtCompra.UseVisualStyleBackColor = True
        '
        'rbtVenta
        '
        Me.rbtVenta.AutoSize = True
        Me.rbtVenta.Location = New System.Drawing.Point(288, 116)
        Me.rbtVenta.Name = "rbtVenta"
        Me.rbtVenta.Size = New System.Drawing.Size(53, 17)
        Me.rbtVenta.TabIndex = 6
        Me.rbtVenta.Text = "Venta"
        Me.rbtVenta.UseVisualStyleBackColor = True
        '
        'txtHora
        '
        Me.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHora.Enabled = False
        Me.txtHora.Location = New System.Drawing.Point(39, 31)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(72, 13)
        Me.txtHora.TabIndex = 7
        '
        'txtFecha
        '
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(39, 12)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(72, 13)
        Me.txtFecha.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cliente"
        '
        'cboClientes
        '
        Me.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(167, 82)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(174, 21)
        Me.cboClientes.TabIndex = 10
        '
        'btnFormNuevoCliente
        '
        Me.btnFormNuevoCliente.Location = New System.Drawing.Point(95, 226)
        Me.btnFormNuevoCliente.Name = "btnFormNuevoCliente"
        Me.btnFormNuevoCliente.Size = New System.Drawing.Size(138, 23)
        Me.btnFormNuevoCliente.TabIndex = 11
        Me.btnFormNuevoCliente.Text = "&Nuevo Cliente"
        Me.btnFormNuevoCliente.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(250, 226)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(91, 23)
        Me.btnRegistrar.TabIndex = 12
        Me.btnRegistrar.Text = "&Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(347, 81)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 23)
        Me.btnActualizar.TabIndex = 13
        Me.btnActualizar.Text = "&Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 281)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnFormNuevoCliente)
        Me.Controls.Add(Me.cboClientes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.rbtVenta)
        Me.Controls.Add(Me.rbtCompra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTipoVehiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboTipoVehiculo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbtCompra As RadioButton
    Friend WithEvents rbtVenta As RadioButton
    Friend WithEvents txtHora As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboClientes As ComboBox
    Friend WithEvents btnFormNuevoCliente As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnActualizar As Button
End Class
