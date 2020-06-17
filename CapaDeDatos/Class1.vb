Imports System.Data.Odbc

Public MustInherit Class ModeloBaseDeDatos

    Public Driver As String = ""
    Public Uid As String = ""
    Public Pwd As String = ""
    Public Port As String = ""
    Public DatabaseName As String = ""
    Public Host As String = ""

    Public Connect As New OdbcConnection("
        DRIVER=" + Me.Driver +
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
