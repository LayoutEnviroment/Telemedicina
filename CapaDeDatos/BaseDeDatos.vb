Imports System.Data.Odbc

Public MustInherit Class ModeloBaseDeDatos

    Public Command As New OdbcCommand
    Public Reader As OdbcDataReader

    Public Sub New(user As String, pass As String)
        Dim Driver As String = "Mysql ODBC 8.0 Unicode Driver"
        Dim Uid As String = user
        Dim Pwd As String = pass
        Dim Port As String = "3306"
        Dim DatabaseName As String = "bd_led"
        Dim Host As String = "localhost"

        Dim Connect As New OdbcConnection(
        "DRIVER=" + Driver +
        ";UID=" + Uid +
        ";PWD=" + Pwd +
        ";PORT=" + Port +
        ";DATABASE=" + DatabaseName +
        ";SERVER=" + Host
    )

        Connect.Open()
        Command.Connection = Connect
    End Sub


End Class
