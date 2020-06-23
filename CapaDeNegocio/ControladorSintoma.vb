Imports CapaDeDatos

Public Module ControladorSintoma

    Public Function ListarSintoma(Sintoma As String)
        Dim s As New ModeloSintoma With {
            .Nombre = Sintoma
        }

        Return s.Listar()
    End Function

    Public Function ListarSintoma()
        Dim s As New ModeloSintoma

        Return s.ListarTodo()
    End Function


    Public Sub CrearSintoma(nombre As String)
        Dim s As New ModeloSintoma

        s.Nombre = nombre
        s.Insertar()

    End Sub

    Public Sub CambiarNombreDeSintoma(idSintoma As String, nombre As String)
        Dim s As New ModeloSintoma

        s.IdSintoma = idSintoma
        s.Nombre = nombre

        s.Modificar()
    End Sub

    Public Sub EliminarSintoma(id As String)
        Dim s As New ModeloSintoma
        s.IdSintoma = id

        s.Eliminar()
    End Sub
End Module

