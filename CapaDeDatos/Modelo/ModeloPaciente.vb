Public Class ModeloPaciente
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Function ObtenerNombre()
        Command.CommandText = "
            SELECT
                nombre
            FROM
                persona
            WHERE ci = " + Me.Pwd + "
        "
        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerPersonaSexoNacimineto()
        Command.CommandText = "
            SELECT
                p.ci,
                p.nombre,
                p.apellido,
                p.mail,
                pa.sexo,
                pa.fecha_nac
            FROM
                persona p
                    JOIN
                        paciente pa
                            ON 
                                p.ci = pa.ci_persona
            WHERE
                p.ci = " + Me.Pwd + "
            "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerMedicaciones()
        Command.CommandText = "
            SELECT
                medicacion
            FROM
                medicaciones
            WHERE
                ci_persona_paciente = " + Me.Pwd + "
        "

        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerEnfermedades()
        Command.CommandText = "
            SELECT
                enfermedad
            FROM
                enfermedades_cronicas
            WHERE
                ci_persona_paciente = " + Me.Pwd + "
        "

        Reader = Command.ExecuteReader()
        Return Reader
    End Function
End Class
