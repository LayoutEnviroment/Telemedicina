Public Class ModeloGenera
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdDiagnostico As String
    Public IdSintoma As String
    Public IdEnfermedad As String
    Public Cedula As String

    Public Function ObtenerEnfermedadGenerada()
        Command.CommandText = "
            SELECT 
                g.id_enfermedad_compone 
            FROM 
                genera g 
                    JOIN 
                        diagnostico d 
                            ON g.id_diagnostico = d.id 
            WHERE 
                d.pertenece = " + Me.Cedula + " 
            ORDER BY 
                g.id_diagnostico DESC 
            LIMIT 1
        "
        Return Command.ExecuteScalar.ToString()

    End Function

End Class
