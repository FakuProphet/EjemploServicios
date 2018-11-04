


Public Class Form1

    Private miAcceso As New GestorBBDD
    Private seleccionOperacion As Operacion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        miAcceso.cargarCombo(cboTipoVehiculo, "vehiculos")
        miAcceso.cargarCombo(cboClientes, "clientes")
        getFechaHora()


    End Sub

    Private Sub setOperacion(ByVal o As Operacion)
        Select Case o
            Case Operacion.Compra
                seleccionOperacion = Operacion.Compra
            Case Operacion.Venta
                seleccionOperacion = Operacion.Venta
        End Select
    End Sub


    Private Sub getFechaHora()
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtHora.Text = DateTime.Now.ToShortTimeString()
    End Sub



    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'A modo de aprendizaje, y por tener pocos clientes, usamos un combo para seleccionar el cliente
        'Al seleccionar un item (cliente en este caso) estaremos registrando e ID que tiene asociado
        'en la base de datos dicho cliente.

        Try
            Dim nuevoServicio As New Servicio
            'usamos la estructura instanciada 
            'asignamos los datos recolectados del formulario
            nuevoServicio.cliente = cboClientes.SelectedValue
            nuevoServicio.elementoID = cboTipoVehiculo.SelectedValue

            '------------una forma de cargar este parametro-----------
            'If rbtCompra.Checked Then
            '    nuevoServicio.operacionID = 1
            'Else
            '    nuevoServicio.operacionID = 2
            'End If
            '-----------------otra forma de realizar lo mismo-----------
            'If rbtCompra.Checked Then
            '    nuevoServicio.operacionID = Operacion.Compra
            'Else
            '    nuevoServicio.operacionID = Operacion.Venta
            'End If
            '------------------------------------------------------------

            '---otra forma de cargar los atributos usando el enum--------
            nuevoServicio.operacionID = seleccionOperacion
            '------------------------------------------------------------
            nuevoServicio.fecha = txtFecha.Text
            nuevoServicio.hora = txtHora.Text


            miAcceso.RegistrarNuevoServicio(nuevoServicio)
        Catch ex As Exception
            MessageBox.Show("Error al realizar el registro: " + ex.Message)
        End Try




    End Sub

    Private Sub btnFormNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnFormNuevoCliente.Click
        Dim formAgregarCliente As Form2 = New Form2
        formAgregarCliente.ShowDialog()
        'mostrar el form en forma modal.
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Actualiza la lista de clientes, cuando agregamos uno que no existia
        'Por el momento lo trabajamos asi.
        miAcceso.cargarCombo(cboClientes, "clientes")
    End Sub

    Private Sub rbtCompra_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCompra.CheckedChanged
        setOperacion(Operacion.Compra)
    End Sub

    Private Sub rbtVenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtVenta.CheckedChanged
        setOperacion(Operacion.Venta)
    End Sub
End Class
