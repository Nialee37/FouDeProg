Imports MySql.Data.MySqlClient

Module modUtil

    Public MaCxionMySql As New MySqlConnection()
    'base en localhost

    Public BaseUtile As String = "Server=192.168.1.19; port = 8889; user id=Slam_FunBulles_2019; Password=Slam_2019;Database=funenbulles_2019;"

    Public MonReader As MySqlDataReader
    'il faut doubles les \ pour en conserver un en sql !
    Public cheminImage As String = "C:\\Images_FunEnBulles\\"

    Public Erreur As Integer = 0
    Public MsgErreur As String

    'connexion à la base de données
    Public Sub Connexion()
        MaCxionMySql.ConnectionString = BaseUtile
        'on ouvre la connexion au serveur avec les paramètres spécifiés 
        Try
            MaCxionMySql.Open()
        Catch ex As Exception
            Erreur = 1
            MsgErreur = "code_erreur " + ex.Message
        End Try

    End Sub

    'deconnexion 
    Public Sub Deconnexion()
        MaCxionMySql.Close()
    End Sub

End Module


