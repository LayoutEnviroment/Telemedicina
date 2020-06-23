Imports CapaDeDatos

Public Module ControladorCompone

    Public Function EnfermedadesPosibles(Sintomas As List(Of String))
        Dim c As New ModeloCompone With {
            .IdSintomas = Sintomas
        }

        Return c.EnfermedadesPosibles()
    End Function

    Public Sub Insertar(Sintomas As List(Of String), Enfermedad As String)
        Dim c As New ModeloCompone With {
            .IdSintomas = Sintomas,
            .IdEnfermedad = Enfermedad
        }

        c.Insertar()
    End Sub

End Module
