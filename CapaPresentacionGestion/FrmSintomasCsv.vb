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
            Sintomas.Clear()
            Posicion.Clear()
            Dim Fila As String()
            While Not Archivo.EndOfData
                Try
                    Fila = Archivo.ReadFields()
                    Dim Campo As String
                    For Each Campo In Fila
                        Sintomas.Add(Campo)
                        ControladorSintoma.CrearSintoma(Campo)
                        Posicion.Add(1)
                    Next
                Catch ex As Exception
                    Posicion.Add(0)
                End Try

            End While
            MsgBox(Posicion.Count)
            MostrarSintomasRepetidos(Sintomas, Posicion)
        End Using

    End Sub

    Private Sub MostrarSintomasRepetidos(sintomas As List(Of String), posicion As List(Of Integer))
        For x = 0 To posicion.Count() - 1
            MsgBox(posicion(x).ToString)
        Next
        sintomas.Clear()
        posicion.Clear()
        Console.WriteLine("Count: {0}", posicion.Count)
    End Sub
End Class