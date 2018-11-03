Imports System.Data
Imports System.Data.OleDb


Public Class GestorBBDD

    Dim conexion As New OleDbConnection
    Dim comando As New OleDbCommand
    Dim dReader As OleDbDataReader
    Private cadenaDeConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Prophet\Desktop\clon Servicios\EjemploServicios\Database2.accdb"



    Public Sub conectar()
        Try
            'indicamos o asignamos cual es la cadena de conexion a usar
            conexion.ConnectionString = cadenaDeConexion
            'Abrir conexion mediante los valores asignados en el punto anterior
            conexion.Open()
            'obtiene o establece la conexion mediante una instancia de OLDBCommand
            comando.Connection = conexion
            'Especifica como se interpretra una cadena de comando
            comando.CommandType = CommandType.Text
            MessageBox.Show("Conexión exitosa...")
        Catch ex As Exception
            MessageBox.Show("Error en la conexión: " + ex.ToString)
        End Try

    End Sub


    Public Sub cerrarConexion()

        Try
            'cierro a conexion actual y libero recursos
            conexion.Close()
            conexion.Dispose()
            MessageBox.Show("Conexión cerrada exitosamente...")
        Catch ex As Exception
            MessageBox.Show("Error al cerrar la conexión: " + ex.ToString)
        End Try


    End Sub

End Class
