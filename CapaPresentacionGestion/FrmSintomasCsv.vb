Imports CapaDeNegocio

Public Class FrmSintomasCsv

    Public Sintomas As New List(Of String)
    Public Posicion As New List(Of Integer)

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        OfdSeleccionarCsv.ShowDialog()
        TxtRuta.Text = OfdSeleccionarCsv.FileName.ToString()

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Using Archivo As New Microsoft.VisualBasic.FileIO.TextFieldParser(TxtRuta.Text)
            Archivo.TextFieldType = FileIO.FieldType.Delimited
            Archivo.SetDelimiters(",")

            Dim Fila As String()
            While Not Archivo.EndOfData
                Try
                    Fila = Archivo.ReadFields()
                    Dim Campo As String
                    For Each Campo In Fila
                        Sintomas.Add(Campo)
                        ControladorSintoma.CrearSintoma(Campo)
                    Next
                Catch ex As Exception

                End Try

            End While

        End Using

    End Sub

End Class