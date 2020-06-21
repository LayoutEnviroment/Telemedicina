Imports CapaDeDatos

Public Module ControladorLogin

    Public Function Login(Credenciales() As String)
        Dim DB As ModeloBaseDeDatos
        DB.Uid = Credenciales(1)
        DB.Pwd = Credenciales(2)

        Return DB.Connect
    End Function
End Module
