﻿Imports CapaDeDatos
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

    Public Function TodosMisDiagnosticos()
        Dim d As New ModeloDiagnostico(ControladorSesion.User, ControladorSesion.Pass)

        Return d.TodosMisDiagnosticos()
    End Function

    Public Function SintomasEnfermedadDiagnosticada(id As String)
        Dim d As New ModeloDiagnostico(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return d.SintomasEnfermedadDiagnosticada()
    End Function

    Public Function EnfermedadDiagnosticada(id As String)
        Dim d As New ModeloDiagnostico(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return d.EnfermedadDiagnosticada()
    End Function

    Public Function MedicoDiagnostico(id As String)
        Dim d As New ModeloDiagnostico(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return d.MedicoDiagnostico()
    End Function

    Public Function ExistenMensajes(id As String)
        Dim d As New ModeloDiagnostico(ControladorSesion.User, ControladorSesion.Pass) With {
            .Id = id
        }

        Return d.ExistenMensajes()
    End Function
End Module
