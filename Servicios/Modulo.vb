Module Modulo

    'funciónes o procedimientos que lo quieres 
    'llamar desde cualquier parte del programa 
    Private miAcceso As New GestorBBDD

    Friend Structure Servicio
        Public elementoID As Byte 'Guardo el ID
        Public operacionID As Byte 'Guardo el ID
        Public cliente As Byte    'Guardo el ID
        Public telefono As String
        Public fecha As String
        Public hora As String
    End Structure

    Public Enum Operacion As Integer
        Compra = 1
        Venta = 2
    End Enum


End Module
