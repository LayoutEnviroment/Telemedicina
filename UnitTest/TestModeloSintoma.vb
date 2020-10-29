Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloSintoma

    <TestMethod()> Public Sub TestListar()

        Dim resultado As Boolean
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
           .Nombre = "Tos"
       }

        Try
            s.Listar()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestListarNombreSintomaActivo()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma("11112223", "Admin123")

        Try
            s.ListarNombreSintomaActivo()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestListarTodo()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma("11112223", "Admin123")

        Try
            s.ListarTodo()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestInsertar()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
            .Nombre = "Ardor de estomago"
        }

        Try
            s.Insertar()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestModificar()
        Dim resultado As Boolean
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
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
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
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
        Dim s As New ModeloSintoma("11112223", "Admin123")

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
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
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
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
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
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
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
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
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

    <TestMethod()> Public Sub TestEliminarConNombre()
        Dim resultado As Boolean
        Dim sintomapruebas = "Quistes"
        Dim s As New ModeloSintoma("11112223", "Admin123") With {
            .Nombre = sintomapruebas
        }

        Try
            s.Eliminar(sintomapruebas)
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

End Class