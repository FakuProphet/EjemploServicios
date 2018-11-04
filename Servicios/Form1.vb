Public Class Form1

    Private miAcceso As New GestorBBDD


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        miAcceso.cargarCombo(cboTipoVehiculo, "vehiculos")
        miAcceso.cargarCombo(cboClientes, "clientes")
        getFechaHora()

    End Sub


    Private Sub getFechaHora()
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtHora.Text = DateTime.Now.ToShortTimeString()
    End Sub



    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'A modo de aprendizaje, y por tener pocos clientes, usamos un combo para seleccionar el cliente
        'Al seleccionar un item (cliente en este caso) estaremos registrando e ID que tiene asociado
        'en la base de datos dicho cliente.


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
End Class
