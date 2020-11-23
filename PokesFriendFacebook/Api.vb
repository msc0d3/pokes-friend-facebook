Imports xNet
Imports Newtonsoft.Json.Linq
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class Api
    Public Shared richtxt As RichTextBox
    Public Shared isstop As Boolean
    Public Shared Function GetFriendList()
        Try
            Dim http As HttpExtension = New HttpExtension(PokesInfo.Cookie, PokesInfo.UserAgent)
            Dim response As String = http.RequestGet(PokesInfo.Apiurl & PokesInfo.Token).ToString()
            If Not response.Contains("data") Then
                Return "die"
            End If
            Dim ObjectFriend As JObject = JObject.Parse(response)
            Dim FriendCount As Integer = ObjectFriend("data").Count
            PokesInfo.NumFriend = FriendCount.ToString()
            For i As Integer = 0 To FriendCount - 1
                PokesInfo.ListFriend.Add(ObjectFriend("data")(i)("name").ToString() & "|" & ObjectFriend("data")(i)("id").ToString())
            Next
            Return "success"
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Public Shared Function GetTokenFacebook()
        Try
            Dim http As HttpExtension = New HttpExtension(PokesInfo.Cookie, PokesInfo.UserAgent)
            Dim response As String = http.RequestGet(PokesInfo.TokenUrl).ToString()
            If Not response.Contains("accessToken") Then
                Return "die"
            End If
            response = response.Replace("\", "")
            PokesInfo.Token = Regex.Match(response, """accessToken"":""(.*?)""").Groups(1).Value
            Return "success"
        Catch ex As Exception
            Return "error"
        End Try
    End Function
    Public Shared Sub WriteLog(txt As RichTextBox, message As String, type As Integer)
        Dim datetimestr As String = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
        If type = 1 Then
            txt.SelectionColor = Color.Lime
        End If
        If type = 2 Then
            txt.SelectionColor = Color.FromArgb(255, 65, 0)
        End If
        If type = 3 Then
            txt.SelectionColor = Color.FromArgb(224, 224, 224)
        End If
        txt.Invoke(Sub()
                       txt.AppendText(datetimestr & " ==> " & message & vbCrLf)
                       txt.ScrollToCaret()
                   End Sub)
    End Sub
    Public Shared Sub Pokes()
        Try
            Dim http As HttpExtension = New HttpExtension(PokesInfo.Cookie, PokesInfo.UserAgent)
            Dim response As String = ""
            For Each NameFb As String In PokesInfo.ListFriend
                If isstop = True Then
                    WriteLog(richtxt, "đã dừng chạy...", 3)
                    Exit For
                End If
                Dim IDFB As String = NameFb.Split("|")(1).ToString()
                NameFb = NameFb.Split("|")(0)
                Try
                    response = http.RequestGet(PokesInfo.PokesUrl & NameFb).ToString()
                    Dim PokesLink As String = "https://mbasic.facebook.com/pokes/inline/" & Regex.Match(response, "<a href=""/pokes/inline/(.*?)""").Groups(1).Value.Replace("amp;", "")
                    response = http.RequestGet(PokesLink).ToString()
                    Thread.Sleep(TimeSpan.FromSeconds(PokesInfo.TimeSleep))
                    WriteLog(richtxt, "chọc thành công : " & NameFb, 1)
                    PokesInfo.NumSuccess += 1
                Catch ex As Exception
                    PokesInfo.NumFail += 1
                    WriteLog(richtxt, "chọc thất bại : " & NameFb, 2)
                End Try
            Next
            WriteLog(richtxt, "đã chọc thành công ! " & PokesInfo.NumSuccess.ToString() & " bạn / " & PokesInfo.NumFriend.ToString() & " bạn ! ==> thất bại : " & PokesInfo.NumFail.ToString(), 3)
        Catch ex As Exception
            WriteLog(richtxt, "lỗi không xác định...", 2)
        End Try
    End Sub
End Class
