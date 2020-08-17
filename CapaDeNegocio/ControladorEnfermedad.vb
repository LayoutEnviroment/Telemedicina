Imports CapaDeDatos

Public Module ControladorEnfermedad

    Public Function ListarEnfermedad()
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass)

        Return e.Listar()
    End Function

    Public Function ListarNombre()
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass)

        Return e.ListarNombreEnfermedad()
    End Function

    Public Sub CrearEnfermedad(nombre As String, descripcion As String, prioridad As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre,
            .Descripcion = descripcion,
            .Prioridad = prioridad
        }

        e.Insertar()
    End Sub

    Public Sub CambiarNombreDeEnfermedad(idEnfermedad As String, nombre As String, descripcion As String, prioridad As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdEnfermedad = idEnfermedad,
            .Nombre = nombre,
            .Descripcion = descripcion,
            .Prioridad = prioridad
        }

        e.Modificar()
    End Sub

    Public Sub EliminarEnfermedad(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdEnfermedad = id
        }

        e.Eliminar()
    End Sub
End Module
