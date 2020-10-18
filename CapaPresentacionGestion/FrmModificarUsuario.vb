Imports CapaDeNegocio

Public Class FrmModificarUsuario

    Dim rol(3) As Boolean

    Private Sub FrmModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerCedulas()
    End Sub

    Private Sub ObtenerCedulas()
        Dim LectorCedula As IDataReader
        Try
            LectorCedula = ControladorUsuario.ObtenerTodasLasCedulas()
            CargarCedulas(LectorCedula)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CargarCedulas(lector As IDataReader)
        CmbCi.Items.Clear()
        While lector.Read
            CmbCi.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbCi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCi.SelectedIndexChanged
        ObtenerDatosPersona()
        EsPaciente()
        EsMedico()
        EsAdministrativo()

    End Sub

    Private Sub ObtenerDatosPersona()
        Dim LectorDatos As IDataReader
        Try
            LectorDatos = ControladorUsuario.TraerNombreApellidoMail(CmbCi.SelectedItem.ToString())
            CargarDatos(LectorDatos)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CargarDatos(lector As IDataReader)
        While lector.Read
            TxtNombre.Text = lector(0).ToString
            TxtApellido.Text = lector(0).ToString
            TxtMail.Text = lector(0).ToString

        End While
    End Sub

    Private Sub EsPaciente()
        Try
            If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString(), 1) = 1 Then
                rol(0) = True
                ChbPaciente.Checked = True
                ObtenerDatosPaciente()
            Else
                rol(0) = False
                ChbPaciente.Checked = False

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ObtenerDatosPaciente()
        Dim LectorPaciente As IDataReader
        Try
            LectorPaciente = ControladorPaciente.ObtenerTodo(CmbCi.SelectedItem.ToString)
            CargarDatosPaciente(LectorPaciente)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CargarDatosPaciente(lector As IDataReader)
        While lector.Read
            'AdaptarFecha(lector(3).ToString)
            If lector(4).ToString = 0 Then
                RdbH.Checked = True
            Else
                RdbM.Checked = True
            End If
        End While

    End Sub

    Private Sub AdaptarFecha(Fecha As Date)

    End Sub

    Private Sub EsMedico()
        If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString, 2) = 1 Then
            rol(1) = True
            ChbMedico.Checked = True
        Else
            rol(1) = False
            ChbMedico.Checked = False
        End If

    End Sub

    Private Sub EsAdministrativo()
        If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString, 3) = 1 Then
            rol(2) = True
            ChbAdministrador.Checked = True
        Else
            rol(2) = False
            ChbAdministrador.Checked = False
        End If

    End Sub

End Class