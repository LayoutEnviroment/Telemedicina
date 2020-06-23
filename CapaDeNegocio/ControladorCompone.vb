Imports CapaDeDatos

Public Module ControladorCompone

    Public Function EnfermedadesPosibles(Sintomas As List(Of String))
        Dim c As New ModeloCompone With {
            .IdSintomas = Sintomas
        }

        Return c.EnfermedadesPosibles()
    End Function

End Module
