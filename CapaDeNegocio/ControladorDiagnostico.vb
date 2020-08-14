Imports CapaDeDatos
Public Module ControladorDiagnostico

    Public Sub Nuevo(sintomas As List(Of String), enfermedad As String)
        Dim d As New ModeloDiagnostico(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdSintomas = sintomas,
            .IdEnfermedad = enfermedad
        }
        d.Nuevo()

    End Sub

    Public Function ObtenerID()
        Dim d As New ModeloDiagnostico(ControladorSesion.User, ControladorSesion.Pass)

        Return d.ObtenerId()
    End Function
End Module
