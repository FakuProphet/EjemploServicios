Public Class Form1

    Private miAcceso As New GestorBBDD


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miAcceso.cargarCombo(cboTipoVehiculo, "vehiculos")
        miAcceso.cargarCombo(cboClientes, "clientes")
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'A modo de aprendizaje, y por tener pocos clientes, usamos un combo para seleccionar el cliente
        'Al seleccionar un item (cliente en este caso) estaremos registrando e ID que tiene asociado
        'en la base de datos dicho cliente.


    End Sub
End Class
