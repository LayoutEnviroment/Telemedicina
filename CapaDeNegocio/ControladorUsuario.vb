Imports CapaDeDatos

Public Module ControladorUsuario

    Public Sub NuevoPaciente(cedula As String,
                             nombre As String,
                             apellido As String,
                             mail As String,
                             fechaNacimineto As String,
                             sexo As String,
                             enfermedades As List(Of String),
                             medicaciones As List(Of String),
                             contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = mail,
            .FechaNacimiento = fechaNacimineto,
            .Sexo = sexo,
            .EnfermedadCronica = enfermedades,
            .Medicacion = medicaciones,
            .Password = contra
        }

        u.NuevoPaciente()

    End Sub

    Public Sub NuevoMedico(cedula As String,
                           nombre As String,
                           apellido As String,
                           mail As String,
                           contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = mail,
            .Password = contra
        }

        u.NuevoMedico()

    End Sub

    Public Sub NuevoAdministrativo(cedula As String,
                                    nombre As String,
                                    apellido As String,
                                    mail As String,
                                    contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = mail,
            .Password = contra
        }

        u.NuevoAdministrativo()

    End Sub

    Public Sub NuevoPacienteMedico(cedula As String,
                             nombre As String,
                             apellido As String,
                             mail As String,
                             fechaNacimineto As String,
                             sexo As String,
                             enfermedades As List(Of String),
                             medicaciones As List(Of String),
                             contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = mail,
            .FechaNacimiento = fechaNacimineto,
            .Sexo = sexo,
            .EnfermedadCronica = enfermedades,
            .Medicacion = medicaciones,
            .Password = contra
        }

        u.NuevoPacienteMedico()

    End Sub

    Public Sub NuevoPacienteAdmin(cedula As String,
                             nombre As String,
                             apellido As String,
                             mail As String,
                             fechaNacimineto As String,
                             sexo As String,
                             enfermedades As List(Of String),
                             medicaciones As List(Of String),
                             contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = mail,
            .FechaNacimiento = fechaNacimineto,
            .Sexo = sexo,
            .EnfermedadCronica = enfermedades,
            .Medicacion = medicaciones,
            .Password = contra
        }

        u.NuevoPacienteAdmin()

    End Sub

    Public Sub NuevoPacienteMedicoAdmin(Nombre As String,
                                        Apellido As String,
                                        CI As String,
                                        Mail As String,
                                        FechaNacimiento As String,
                                        Sexo As String,
                                        EnfermedadesCronicas As List(Of String),
                                        Medicamentos As List(Of String),
                                        Contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre,
            .Apellido = Apellido,
            .CI = CI,
            .Mail = Mail,
            .FechaNacimiento = FechaNacimiento,
            .Sexo = Sexo,
            .Medicacion = Medicamentos,
            .EnfermedadCronica = EnfermedadesCronicas,
            .Password = Contra
        }
        u.NuevoPacienteMedicoAdmin()

    End Sub

    Public Sub NuevoMedicoAdmin(cedula As String,
                                nombre As String,
                                apellido As String,
                                mail As String,
                                contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = mail,
            .Password = contra
        }

        u.NuevoMedicoAdmin()

    End Sub

    Public Function ObtenerCorreo()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }
        Return u.ObtenerCorreo()

    End Function

    Public Function ObtenerNombreApellidoCedula()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }
        Return u.ObtenerNombreApellidoCedula

    End Function

    Public Function ObtenerCedulaMedico()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        Return u.ObtenerCiMedico()

    End Function

    Public Function ObtenerCedulaAdministrativo()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        Return u.ObtenerCiAdministrador()

    End Function

    Public Function ObtenerNombre()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }
        Return u.ObtenerNombre()

    End Function

    Public Function TraerNombreApellidoMail(ci As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ci
        }
        Return u.TraerNombreApellidoMail()

    End Function

    Public Function ObtenerTodasLasCedulas()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)

        Return u.ObtenerTodasLasCedulas()
    End Function

    Public Function ExisteRol(cedula As String, rol As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = cedula,
            .Rol = rol
        }

        Return u.ExisteRol()
    End Function

    Private Sub ExisteMedico(cedula As String)

    End Sub

    Public Sub ModificarPersona(nombre As String,
                                apellido As String,
                                mail As String,
                                ci As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = mail,
            .CI = ci
        }

        u.ModificarPersona()
    End Sub

    Public Function EliminarPersona(CI As String)
        Dim p As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)

        p.CI = CI

        Return p.Eliminar()

    End Function

    Public Function ChequearPaciente(ci_persona As String)
        Dim p As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)

        p.CI = ci_persona
        Return p.CheckPaciente()

    End Function

    Public Function ChequearMedico(ci_persona As String)
        Dim p As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)

        p.CI = ci_persona
        Return p.CheckMedico()

    End Function

    Public Function ChequearAdministrativo(ci_persona As String)
        Dim p As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)

        p.CI = ci_persona
        Return p.CheckAdministrativo()

    End Function
End Module
