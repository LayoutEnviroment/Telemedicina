Imports CapaDeDatos
Public Module ControladorDiagnostico

    Public Sub Nuevo(sintomas As List(Of String), enfermedad As String)
        Dim d As New ModeloDiagnostico With {
            .IdSintomas = sintomas,
            .IdEnfermedad = enfermedad
        }
        d.Nuevo()

    End Sub

End Module
