Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloCompone

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"

    <TestMethod()> Public Sub TestEnfermedadesPosibles()
        'CONSULTAR POR LAS DUDAS
        Dim sintomaPrueba As New List(Of String) From {
        ("Sintoma de prueba")
        }
        Dim c As New ModeloCompone(Paciente, PacPass) With {
            .IdSintomas = sintomaPrueba}
        Dim buscarInformacion As Boolean

        Try
            c.EnfermedadesPosibles()
            buscarInformacion = True

        Catch ex As Exception
            buscarInformacion = False

        End Try
        Assert.IsTrue(buscarInformacion)


    End Sub

    <TestMethod()> Public Sub TestEnfermedadesPorAproximacion()
        Dim sintomaPrueba As New List(Of String) From {
       ("Sintoma de prueba"),
       ("Diarrea"),
       ("Ronchas")
       }
        Dim C As New ModeloCompone(Paciente, PacPass) With {
            .IdSintomas = sintomaPrueba}
        Dim buscarInformacion As Boolean

        Try
            C.EnfermedadesPorAproximacion()
            buscarInformacion = True

        Catch ex As Exception
            buscarInformacion = False

        End Try
        Assert.IsTrue(buscarInformacion)
    End Sub
    'CREO QUE ESTA REPETIDO EN EL MODELOENFERMEDAD
    '<TestMethod()> Public Sub TestInsertar()

    'End Sub

    <TestMethod()> Public Sub TestObtenerSintomasEnfermedad()
        Dim c As New ModeloCompone(Admin, AdmPass) With {
      .IdEnfermedad = "5"
  }
        Dim buscarInformacion As Boolean
        Try
            c.ObtenerSintomasEnfermedad()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)
    End Sub

End Class