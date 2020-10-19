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
    Public Rol As String

    Public Sub NuevoPaciente()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'%' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    INSERT INTO 
                        persona (ci, nombre, apellido, mail, activo)
                    VALUES
                        (" + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, rol)
                        VALUES
                            (" + Me.CI + ", 1)
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            paciente (ci_persona, sexo, fecha_nac)
                        VALUES
                            (" + Me.CI + ", " + Me.Sexo + ", '" + Me.FechaNacimiento + "')
                        "
            Command.ExecuteNonQuery()

            For Each Enfermedad In EnfermedadCronica
                Command.CommandText = "
                            INSERT INTO 
                                enfermedades_cronicas (ci_persona_paciente, enfermedad)
                            VALUES
                                (" + Me.CI + ",'" + Enfermedad + "')
                            "
                Command.ExecuteNonQuery()

            Next

            For Each Medicamento In Medicacion
                Command.CommandText = "
                            INSERT INTO 
                                medicaciones (ci_persona_paciente, medicacion)
                            VALUES
                                (" + Me.CI + ",'" + Medicamento + "')
                            "
                Command.ExecuteNonQuery()

            Next

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

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()

        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub NuevoMedico()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'%' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    INSERT INTO 
                        persona (ci, nombre, apellido, mail, activo)
                    VALUES
                        (" + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    INSERT INTO 
                        roles (ci_persona, rol)
                    VALUES
                        ('" + Me.CI + "', 2)
                "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            medico (ci_persona)
                        VALUES
                            (" + Me.CI + ")
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

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()
            'Return True
        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()
            MsgBox(ex.HResult)
            'Return ex.HResult.ToString
        End Try

    End Sub

    Public Sub NuevoAdministrativo()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'localhost' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    INSERT INTO 
                        persona (ci, nombre, apellido, mail, activo)
                    VALUES
                        (" + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, rol)
                        VALUES
                            (" + Me.CI + ", 3)
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            administrativo (ci_persona)
                        VALUES
                            (" + Me.CI + ")
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

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()

        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Sub NuevoPacienteMedico()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'%' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    INSERT INTO 
                        persona (ci, nombre, apellido, mail, activo)
                    VALUES
                        (" + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, rol)
                        VALUES
                            (" + Me.CI + ", 2),
                            (" + Me.CI + ", 1)
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            medico (ci_persona)
                        VALUES
                            (" + Me.CI + ")
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            paciente (ci_persona, sexo, fecha_nac)
                        VALUES
                            (" + Me.CI + ", " + Me.Sexo + ", '" + Me.FechaNacimiento + "')
                        "
            Command.ExecuteNonQuery()

            For Each Enfermedad In EnfermedadCronica
                Command.CommandText = "
                            INSERT INTO 
                                enfermedades_cronicas (ci_persona_paciente, enfermedad)
                            VALUES
                                (" + Me.CI + ",'" + Enfermedad + "')
                            "
                Command.ExecuteNonQuery()

            Next

            For Each Medicamento In Medicacion
                Command.CommandText = "
                            INSERT INTO 
                                medicaciones (ci_persona_paciente, medicacion)
                            VALUES
                                (" + Me.CI + ",'" + Medicamento + "')
                            "
                Command.ExecuteNonQuery()

            Next

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

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()

        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()

        End Try
    End Sub

    Public Sub NuevoPacienteAdmin()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'%' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'localhost' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    INSERT INTO 
                        persona (ci, nombre, apellido, mail, activo)
                    VALUES
                        (" + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, rol)
                        VALUES
                            (" + Me.CI + ", 3),
                            (" + Me.CI + ", 1)
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            administrativo (ci_persona)
                        VALUES
                            (" + Me.CI + ")
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            paciente (ci_persona, sexo, fecha_nac)
                        VALUES
                            (" + Me.CI + ", " + Me.Sexo + ", '" + Me.FechaNacimiento + "')
                        "
            Command.ExecuteNonQuery()

            For Each Enfermedad In EnfermedadCronica
                Command.CommandText = "
                            INSERT INTO 
                                enfermedades_cronicas (ci_persona_paciente, enfermedad)
                            VALUES
                                (" + Me.CI + ",'" + Enfermedad + "')
                            "
                Command.ExecuteNonQuery()

            Next

            For Each Medicamento In Medicacion
                Command.CommandText = "
                            INSERT INTO 
                                medicaciones (ci_persona_paciente, medicacion)
                            VALUES
                                (" + Me.CI + ",'" + Medicamento + "')
                            "
                Command.ExecuteNonQuery()

            Next

            Command.CommandText = "
                        GRANT
                           ALL
                        ON
                            *.*
                        TO
                            '" + Me.CI + "'@'localhost' WITH GRANT OPTION
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

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()

        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()
            MsgBox("error")

        End Try
    End Sub

    Public Sub NuevoMedicoAdmin()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'localhost' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'%' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    INSERT INTO 
                        persona (ci, nombre, apellido, mail, activo)
                    VALUES
                        (" + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, rol)
                        VALUES
                            (" + Me.CI + ", 3),
                            (" + Me.CI + ", 2)
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            administrativo (ci_persona)
                        VALUES
                            (" + Me.CI + ")
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            medico (ci_persona)
                        VALUES
                            (" + Me.CI + ")
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

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()

        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()

        End Try
    End Sub

    Public Sub NuevoPacienteMedicoAdmin()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'%' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    CREATE USER 
                        '" + Me.CI + "'@'localhost' 
                    IDENTIFIED BY
                        '" + Me.Password + "'
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                    INSERT INTO 
                        persona (ci, nombre, apellido, mail, activo)
                    VALUES
                        (" + Me.CI + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')
                    "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            roles (ci_persona, rol)
                        VALUES
                            (" + Me.CI + ", 3),
                            (" + Me.CI + ", 2),
                            (" + Me.CI + ", 1)
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            administrativo (ci_persona)
                        VALUES
                            (" + Me.CI + ")
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            medico (ci_persona)
                        VALUES
                            (" + Me.CI + ")
                        "
            Command.ExecuteNonQuery()

            Command.CommandText = "
                        INSERT INTO 
                            paciente (ci_persona, sexo, fecha_nac)
                        VALUES
                            (" + Me.CI + ", " + Me.Sexo + ", '" + Me.FechaNacimiento + "')
                        "
            Command.ExecuteNonQuery()

            For Each Enfermedad In EnfermedadCronica
                Command.CommandText = "
                            INSERT INTO 
                                enfermedades_cronicas (ci_persona_paciente, enfermedad)
                            VALUES
                                (" + Me.CI + ",'" + Enfermedad + "')
                            "
                Command.ExecuteNonQuery()

            Next

            For Each Medicamento In Medicacion
                Command.CommandText = "
                            INSERT INTO 
                                medicaciones (ci_persona_paciente, medicacion)
                            VALUES
                                (" + Me.CI + ",'" + Medicamento + "')
                            "
                Command.ExecuteNonQuery()

            Next

            Command.CommandText = "
                        GRANT
                           ALL
                        ON
                            *.*
                        TO
                            '" + Me.CI + "'@'localhost' WITH GRANT OPTION
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

            Command.CommandText = "COMMIT"
            Command.ExecuteNonQuery()

        Catch ex As Exception
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()
            MsgBox("error")

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

    Public Function TraerNombreApellidoMail()
        Command.CommandText = "
            SELECT 
                nombre, 
                apellido, 
                mail                         
            FROM 
                persona
            WHERE 
                ci = '" + Me.CI + "'"
        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Function ObtenerTodasLasCedulas()
        Command.CommandText = "
            SELECT
                ci
            FROM
                persona
        "

        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Function ExisteRol()
        Command.CommandText = "
            SELECT
                COUNT(ci_persona)
            FROM
                roles
            WHERE
                ci_persona = " + Me.CI + " 
                AND
                    rol = " + Me.Rol + "> 0
            "
        Return Command.ExecuteScalar.ToString()

    End Function

    Public Sub ModificarPersona()
        Command.CommandText = "
            UPDATE
                persona
            SET
                nombre = '" + Me.Nombre + "',
                apellido = '" + Me.Apellido + "',
                mail = '" + Me.Mail + "'
            WHERE
                ci = " + Me.CI + "
            "
        Command.ExecuteNonQuery()

    End Sub

    Public Function Eliminar()
        Try
            Command.CommandText = "UPDATE persona
                                   SET activo = 0
                                   WHERE id = " + Me.CI + ""
            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
