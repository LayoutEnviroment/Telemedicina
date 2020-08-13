Imports CapaDeDatos

Public Module ControladorLogin

    Public Sub ExistePersona(usuario As String, contra As String)
        Dim l As New ModeloLogin With {
            .NombreUsuario = usuario,
            .ContraUsuario = contra
        }

        l.VerificarPersona()
    End Sub
End Module
