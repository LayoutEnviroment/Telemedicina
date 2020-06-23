Imports System.Data.Odbc

Public MustInherit Class ModeloBaseDeDatos

    Public Driver As String = "Mysql ODBC 8.0 Unicode Driver"
    Public Uid As String = "gestor"
    Public Pwd As String = "gestor"
    Public Port As String = "3306"
    Public DatabaseName As String = "probando"
    Public Host As String = "localhost"

    Public Connect As New OdbcConnection(
        "DRIVER=" + Me.Driver +
        ";UID=" + Me.Uid +
        ";PWD=" + Me.Pwd +
        ";PORT=" + Me.Port +
        ";DATABASE=" + Me.DatabaseName +
        ";SERVER=" + Me.Host
    )


    Public Command As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New()
        Me.Connect.Open()
        Me.Command.Connection = Me.Connect
    End Sub


End Class
