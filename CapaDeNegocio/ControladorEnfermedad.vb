Imports CapaDeDatos

Public Module ControladorEnfermedad

    Public Function ListarEnfermedad()
        Dim e As New ModeloEnfermedad

        Return e.Listar()
    End Function
    Public Function ListarNombre()
        Dim e As New ModeloEnfermedad
        Return e.ListarNombreEnfermedad()

    End Function

    Public Sub CrearEnfermedad(nombre As String, descripcion As String, prioridad As String)
        Dim e As New ModeloEnfermedad

        e.Nombre = nombre
        e.Descripcion = descripcion
        e.Prioridad = prioridad
        e.Insertar()

    End Sub

    Public Sub CambiarNombreDeEnfermedad(idEnfermedad As String, nombre As String, descripcion As String, prioridad As String)
        Dim e As New ModeloEnfermedad

        e.IdEnfermedad = idEnfermedad
        e.Nombre = nombre
        e.Descripcion = descripcion
        e.Prioridad = prioridad

        e.Modificar()
    End Sub

    Public Sub EliminarEnfermedad(id As String)
        Dim e As New ModeloEnfermedad
        e.IdEnfermedad = id

        e.Eliminar()
    End Sub
End Module
