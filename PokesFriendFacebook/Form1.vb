Imports System.Threading
Public Class Form1
    ''' <summary>
    ''' Copyright @2020 By Nguyen Dac Tai
    ''' https://tienichmmo.net
    ''' FAM Software
    ''' Copy xin vui lòng để nguồn ! mình xin cảm ơn !
    ''' </summary>
    Sub New()
        Control.CheckForIllegalCrossThreadCalls = False
        InitializeComponent()
    End Sub
    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        If txtcookie.Text.Length < 2 Then
            MsgBox("chưa có cookie !", MsgBoxStyle.Exclamation, "thiếu cookie rồi má")
            Return
        End If
        If txtuseragent.Text.Length < 2 Then
            PokesInfo.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36"
        Else
            PokesInfo.UserAgent = txtuseragent.Text
        End If
        Api.isstop = False
        btnstart.Enabled = False
        btnstop.Enabled = True
        My.Settings.cookie = txtcookie.Text
        My.Settings.useragent = PokesInfo.UserAgent
        My.Settings.Save()
        PokesInfo.Cookie = txtcookie.Text
        Api.WriteLog(txtlogs, "đang lấy danh sách bạn bè...", 3)
        Dim IsLiveFb As String = Api.GetTokenFacebook()
        If IsLiveFb = "die" Or IsLiveFb = "error" Then
            Api.WriteLog(txtlogs, "Cookie die !", 2)
            Return
        End If
        Api.richtxt = txtlogs
        PokesInfo.TimeSleep = numsleep.Value
        Call (New Thread(Sub()
                             Api.GetFriendList()
                             Api.WriteLog(txtlogs, "tìm thấy " & PokesInfo.NumFriend.ToString() & " bạn bè", 3)
                             Api.Pokes()
                         End Sub)).Start()

    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        Try
            Api.isstop = True
            btnstart.Enabled = True
            btnstop.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtcookie.Text = My.Settings.cookie
            txtuseragent.Text = My.Settings.useragent
        Catch ex As Exception

        End Try
    End Sub
End Class
