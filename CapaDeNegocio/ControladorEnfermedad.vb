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
            .Id = idEnfermedad,
            .Nombre = nombre,
            .Descripcion = descripcion,
            .Prioridad = prioridad
        }

        e.Modificar()
    End Sub

    Public Sub EliminarEnfermedad(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        e.Eliminar()
    End Sub

    Public Function ObtenerId()
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass)

        Return e.ObtenerIdConDiagnostico()
    End Function

    Public Function ObtenerId(nombre As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre
        }

        Return e.ObtenerId()
    End Function

    Public Function ObtenerPrioridad(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return e.ObtenerPrioridad()

    End Function

    Public Function ObtenerDescripcion(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return e.ObtenerDescripcion()

    End Function

    Public Function ObtenerTodo(id As String)
        Dim e As New ModeloEnfermedad(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return e.ObtenerTodo()
    End Function
End Module
