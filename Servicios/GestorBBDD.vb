Imports System.Data
Imports System.Data.OleDb


Public Class GestorBBDD

    'Declaración de variables
    Dim conexion As New OleDbConnection
    Dim comando As New OleDbCommand
    Dim dReader As OleDbDataReader
    Dim dTable As DataTable
    'Es privada porque solo hacemos uso interno, solo dentro del ambiente de la clase
    Private cadenaDeConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Prophet\Desktop\clon Servicios\EjemploServicios\Concesionaria.accdb"



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
            MessageBox.Show("Error al abrir la conexión: " + ex.ToString)
        End Try
    End Sub


    Public Sub cerrarConexion()
        Try
            'cierro a conexion actual y libero recursos
            conexion.Close()
            conexion.Dispose()
            '  MessageBox.Show("Conexión cerrada exitosamente...")
        Catch ex As Exception
            MessageBox.Show("Error al cerrar la conexión: " + ex.ToString)
        End Try
    End Sub


    'UN DATATABLE REPRESENTA UNA  TABLA CON DATOS EN MEMORIA
    'NOS FACILITA AL MOMENTO DE REALIZR UNA CONSULTA A UNA TABLA ESPECIFICA
    'TAMBIEN PUEDE REALIZAR Y ALMACENAR UNA CONSULTA CON MAS TABLAS
    'EN TAL CASO DEBEREMOS AJUSTAR EL METODO
    Public Function consutarTabla(ByVal tabla As String)

        'Creamos una funcion porque necesitamos que el metodo nos devuelva
        'una coleccion de datos

        'Se instancia la clase, cada vez q se ejecuta el metodo
        dTable = New DataTable

        'Abrir una conexion mediante el metodo creado
        conectar()

        'Pasamos el comando a ejecutar
        comando.CommandText = "SELECT * FROM " + tabla

        'Cargamos en un datatable el resultado de la consulta
        dTable.Load(comando.ExecuteReader)

        'cerramos la conexion
        cerrarConexion()

        'Por ultimo retornamos el datatable con los datos de la consulta

        Return dTable
    End Function

    Public Sub cargarCombo(ByVal miCombo As ComboBox, ByVal tabla As String)
        Try
            'instanciar una clase datatable
            dTable = New DataTable

            'cargamos el datatable con una consulta a una tabla
            'usando el metodo creado en la clase
            dTable = consutarTabla(tabla)

            'El origen de datos del combo box, le decimos que sera
            'con lo recolectado en el datatable
            miCombo.DataSource = dTable

            'le indicamos que el value member de cada item del combo
            'sera el id o clave primaria que arrastre de cada registro de 
            'la tabla indicada en el metodo consultar tabla
            'este es el valor que se va a guardar, cuando se haya seleccionado
            'un item del combobox
            miCombo.ValueMember = dTable.Columns(0).ColumnName

            'Indicamos que en pantalla se va a mostrar la descripcion 
            'de cada registro
            miCombo.DisplayMember = dTable.Columns(1).ColumnName

        Catch ex As Exception
            MessageBox.Show("Error al cargar combo: " + ex.ToString)
        Finally
            conexion.Close()
        End Try

    End Sub

    Public Sub RegistrarNuevoServicio(ByVal servicio As Object)
        Dim miServicio As Servicio
        miServicio = CType(servicio, Servicio)
        'incompleto
    End Sub


End Class
