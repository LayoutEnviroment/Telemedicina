Imports CapaDeDatos

Public Module ControladorSintoma

    Public Function ListarSintoma(Sintoma As String)
        Dim s As New ModeloSintoma With {
            .Nombre = Sintoma
        }

        Return s.Listar()
    End Function

    Public Function ObtenerId(Sintoma As String)
        Dim s As New ModeloSintoma With {
            .Nombre = Sintoma
        }

        Return s.ObtenerId()
    End Function
End Module

