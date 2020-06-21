Imports CapaDeDatos

Public Module ControladorSintoma

    Public Function ListarSintoma(Sintoma As String)
        Dim s As New ModeloSintoma With {
            .Nombre = Sintoma
        }

        Return s.Listar()
    End Function

    Public Sub CrearSintoma(nombre As String)
        Dim s As New ModeloSintoma

        s.Nombre = nombre
        s.Insertar()

    End Sub
End Module
