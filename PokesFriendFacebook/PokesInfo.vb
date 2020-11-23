Public Class PokesInfo
    Public Shared Property TimeSleep As Integer
    Public Shared Property NumFriend As String = 0
    Public Shared Property NumSuccess As String = 0
    Public Shared Property NumFail As String = 0
    Public Shared Property UserAgent As String
    Public Shared Property Cookie As String
    Public Shared Property Token As String
    Public Shared Property Apiurl As String = "https://graph.facebook.com/me/friends?limit=5000&fields=id,name&access_token="
    Public Shared Property PokesUrl As String = "https://mbasic.facebook.com/pokes/friend_search/?query="
    Public Shared Property PokesedUrl As String = "https://mbasic.facebook.com/pokes/?show_outgoing=1"
    Public Shared Property TokenUrl As String = "https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed"
    Public Shared Property ListFriend As New List(Of String)

End Class
