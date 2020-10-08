Public Class ModeloUsuario
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub


    Public TipoDeUsuario(3) As Boolean
    Public Nombre As String
    Public Apellido As String
    Public CI As String
    Public Mail As String
    Public FechaNacimiento As String
    Public Sexo As String
    Public EnfermedadCronica As List(Of String)
    Public Medicacion As List(Of String)
    Public Password As String


    Public Sub NuevaPersona()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Try

                Command.CommandText = "
                    INSERT INTO 
                        persona (ci, nombre, apellido, mail, activo)
                    VALUES
                        ('" + Me.CI + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')
                    "
                Command.ExecuteNonQuery()

                '' Creacion de un administrador
                If Me.TipoDeUsuario(3) = True Then
                    Try
                        Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'localhost' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        INSERT INTO 
                            administrativo (ci_persona)
                        VALUES
                            ('" + Me.CI + "')
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, usuario, rol)
                        VALUES
                            ('" + Me.CI + "','" + Me.Mail + "', 3)
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
                           ALL
                        ON
                            *.*
                        TO
                            '" + Me.CI + "'@'localhost' WITH GRANT OPTION
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "FLUSH PRIVILEGES"
                        Command.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al crear admin " + ex.ToString)
                        Command.CommandText = "ROLLBACK"
                        Command.ExecuteNonQuery()
                    End Try


                End If

                '' Creacion de un medico
                If Me.TipoDeUsuario(2) = True Then
                    Try
                        Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'%' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        INSERT INTO 
                            medico (ci_persona)
                        VALUES
                            ('" + Me.CI + "')
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, usuario, rol)
                        VALUES
                            ('" + Me.CI + "', '" + Me.Mail + "', 2)"
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.roles 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.sintoma 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT 
	                        SELECT 
                        ON 
                            bd_led.enfermedad 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT 
	                        SELECT 
                        ON 
                            bd_led.compone 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT 
	                        SELECT 
                        ON 
                            bd_led.medico 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.paciente 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.persona 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.enfermedades_cronicas 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.medicaciones 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = " 
                        GRANT
	                        SELECT, INSERT, UPDATE 
                        ON 
                            bd_led.atiende 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "FLUSH PRIVILEGES"
                        Command.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Error al crear medico" + ex.ToString)
                        Command.CommandText = "ROLLBACK"
                        Command.ExecuteNonQuery()
                    End Try

                End If

                ''Creacion de un paciente
                If Me.TipoDeUsuario(1) = True Then
                    Try
                        Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'%' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        INSERT INTO 
                            paciente (ci_persona, sexo, fecha_nac, activo)
                        VALUES
                            ('" + Me.CI + "','" + Me.Sexo + "','" + Me.FechaNacimiento + "',1)
                        "
                        Command.ExecuteNonQuery()

                        For Each Enfermedad In EnfermedadCronica
                            Command.CommandText = "
                            INSERT INTO 
                                enfermedades_cronicas (ci_persona_paciente, enfermedad)
                            VALUES
                                ('" + Me.CI + "','" + Enfermedad + "')
                            "
                            Command.ExecuteNonQuery()

                        Next

                        For Each Medicamento In Medicacion
                            Command.CommandText = "
                            INSERT INTO 
                                medicaciones (ci_persona_paciente, medicacion)
                            VALUES
                                ('" + Me.CI + "','" + Medicamento + "')
                            "
                            Command.ExecuteNonQuery()

                        Next

                        Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, usuario, rol)
                        VALUES
                            ('" + Me.CI + "','" + Me.Mail + "', 1)
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT 
	                        SELECT 
                        ON 
                            bd_led.roles 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.sintoma 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.enfermedad 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.compone 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT 
                        ON 
                            bd_led.medico 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT, INSERT 
                        ON 
                            bd_led.genera 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT, INSERT 
                        ON 
                            bd_led.diagnostico 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT, INSERT 
                        ON 
                            bd_led.padece 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT, UPDATE 
                        ON 
                            bd_led.paciente 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT, UPDATE 
                        ON 
                            bd_led.persona 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT, INSERT, DELETE 
                        ON 
                            bd_led.enfermedades_cronicas 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "    
                        GRANT
	                        SELECT, INSERT, DELETE 
                        ON 
                            bd_led.medicaciones 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "
                        GRANT
	                        SELECT, INSERT, UPDATE 
                        ON 
                            bd_led.atiende 
                        TO 
                            '" + Me.CI + "'@'%'
                        "
                        Command.ExecuteNonQuery()

                        Command.CommandText = "FLUSH PRIVILEGES"
                        Command.ExecuteNonQuery()
                    Catch ex As Exception
                        Command.CommandText = "ROLLBACK"
                        Command.ExecuteNonQuery()
                    End Try

                End If
                Command.CommandText = "COMMIT"
                Command.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)
                Command.CommandText = "ROLLBACK"
                Command.ExecuteNonQuery()

            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()

        End Try
    End Sub


    Public Function ObtenerCorreo()
        Command.CommandText = "
            SELECT
                mail
            FROM
                persona
            WHERE
                ci = " + Me.CI + "
        "
        Return Command.ExecuteScalar.ToString()
    End Function

    Public Function ObtenerNombre()
        MsgBox(Me.CI)
        Command.CommandText = "
            SELECT
                nombre
            FROM
                persona
            WHERE
                ci = " + Me.CI + "
        "
        Return Command.ExecuteScalar.ToString
    End Function

    Public Function ObtenerNombreApellido()
        Command.CommandText = "
            SELECT 
               nombre,
               apellido
            FROM 
                persona
            WHERE
                ci = " + Me.CI + "
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerNombreApellidoCedula()
        Command.CommandText = "
            SELECT
                nombre,
                apellido,
                ci
            FROM
                persona
            WHERE
                ci = " + Me.CI + "
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerCiMedico()
        Command.CommandText = "         
            SELECT
                ci_persona
            FROM
                medico
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader


    End Function
    Public Function ObtenerCiAdministrador()
        Command.CommandText = "         
            SELECT
                ci_persona
            FROM
                administrativo
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function TraerDatosDoctor()
        Command.CommandText = "SELECT nombre, apellido, mail 
                                FROM persona
                                WHERE ci = '" + Me.CI + "'"
        Reader = Command.ExecuteReader
        Return Reader
    End Function
End Class
