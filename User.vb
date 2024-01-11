' User.vb
Public Class User
    Public Property Username As String
    Public Property Email As String

    Public Sub New(username As String, email As String)
        Me.Username = username
        Me.Email = email
    End Sub
End Class
