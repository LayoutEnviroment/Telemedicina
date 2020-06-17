Imports CapaDeDatos

Public Module ControladorSintoma

    Public Function ListarSintoma(Sintoma As String)
        Dim p As New ModeloSintoma With {
            .Nombre = Sintoma
        }

        Return p.Listar()
    End Function
End Module
