Imports CapaDeDatos

Public Module ControladorSintoma

    Public Function ListarSintoma(Sintoma As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Sintoma
        }

        Return s.Listar()
    End Function

    Public Function ListarSintoma()
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass)

        Return s.ListarTodo()
    End Function

    Public Function ListarNombre()
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass)
        Return s.ListarNombreSintoma()

    End Function

    Public Sub CrearSintoma(nombre As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre
        }

        s.Insertar()
    End Sub

    Public Sub CambiarNombreDeSintoma(idSintoma As String, nombre As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdSintoma = idSintoma,
            .Nombre = nombre
        }
        s.Modificar()

    End Sub

    Public Sub EliminarSintoma(id As String)
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdSintoma = id
        }

        s.Eliminar()
    End Sub

    Public Sub GuardarSintomasPadecidos(ListaSintoma As List(Of String))
        Dim s As New ModeloSintoma(ControladorSesion.User, ControladorSesion.Pass) With {
            .ListadoSintomas = ListaSintoma
        }

        s.GuardarPadecimientos()
    End Sub

End Module

