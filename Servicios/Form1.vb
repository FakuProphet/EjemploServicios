Public Class Form1

    Private miAcceso As New GestorBBDD


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miAcceso.cargarCombo(cboTipoVehiculo)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
