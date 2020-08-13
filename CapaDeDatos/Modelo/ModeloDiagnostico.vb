Public Class ModeloDiagnostico
    Inherits ModeloBaseDeDatos


    Private Sub Nuevo()
        Command.CommandText = "
            INSERT INTO Diagnostico
        "
    End Sub


End Class
