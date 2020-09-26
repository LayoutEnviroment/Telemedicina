Imports CapaDeDatos

Public Module ControladorGenera

    Public Function ObtenerIdEnfermedadGenerada()
        Dim g As New ModeloGenera(ControladorSesion.User, ControladorSesion.Pass) With {
            .Cedula = ControladorSesion.Cedula
        }

        Return g.ObtenerEnfermedadGenerada()
    End Function

End Module
