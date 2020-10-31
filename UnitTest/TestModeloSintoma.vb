Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloSintoma

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Diagnostico As String = "5"

    Private Function Random()
        Dim rdm As New Random()
        Dim Letras() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray()
        Dim Sintoma As String = ""

        For i As Integer = 0 To 8
            Sintoma += Letras(rdm.Next(0, Letras.Length))
        Next
        Return Sintoma
    End Function

    <TestMethod()> Public Sub TestListar()

        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
           .Nombre = "Tos"
       }

        Try
            s.Listar()
            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestListarNombreSintomaActivo()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass)

        Try
            s.ListarNombreSintomaActivo()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    '<TestMethod()> Public Sub TestListarTodo()
    '    Dim resultado As Boolean
    '    Dim s As New ModeloSintoma("11112223", "Admin123")

    '    Try
    '        s.ListarTodo()
    '        resultado = True

    '    Catch ex As Exception
    '        resultado = False

    '    End Try

    '    Assert.IsTrue(resultado)

    'End Sub

    <TestMethod()> Public Sub TestInsertar()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = Random()
        }

        Try
            s.Insertar()
            resultado = True

        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestModificar()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = "Espinillas negras",
            .IdSintoma = "11"
        }

        Try
            s.Modificar()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub
    'EL METODO NO ESTA CAMBIANDO NADA
    '<TestMethod()> Public Sub TestModificarConNombre()
    '    Dim resultado As Boolean
    '    Dim s As New ModeloSintoma("11112223", "Admin123") With {
    '        .Nombre = "Protuberancias Diminutas"
    '    }

    '    Try
    '        s.Modificar()
    '        resultado = True

    '    Catch ex As Exception
    '        resultado = False

    '    End Try

    '    Assert.IsTrue(resultado)

    'End Sub

    <TestMethod()> Public Sub TestEliminar()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .IdSintoma = "27"
        }

        Try
            s.Eliminar()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestListarNombreSintomaInactivo()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass)

        Try
            s.ListarNombreSintomaInactivo()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerExistencia()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = "Quistes"
        }

        Try
            s.ObtenerExistencia()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEstaInactivo()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = "Quistes"
        }

        Try
            s.EstaInactivo()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerId()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .Nombre = "Ronchas"
        }

        Try
            s.ObtenerId()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestActivarSintoma()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma(Admin, AdmPass) With {
            .IdSintoma = "10"
        }

        Try
            s.ActivarSintoma()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    '<TestMethod()> Public Sub TestEliminarConNombre()
    '    Dim resultado As Boolean
    '    Dim sintomapruebas = "Quistes"
    '    Dim s As New ModeloSintoma("11112223", "Admin123") With {
    '        .Nombre = sintomapruebas
    '    }

    '    Try
    '        s.Eliminar(sintomapruebas)
    '        resultado = True

    '    Catch ex As Exception
    '        resultado = False

    '    End Try

    '    Assert.IsTrue(resultado)
    'End Sub

End Class