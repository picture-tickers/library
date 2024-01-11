' Library.vb
Public Class Library
    Private books As List(Of Book)
    Private users As List(Of User)

    Public Sub New()
        books = New List(Of Book)
        users = New List(Of User)
    End Sub

    Public Sub AddBook(book As Book)
        books.Add(book)
    End Sub

    Public Sub AddUser(user As User)
        users.Add(user)
    End Sub

    Public Sub DisplayBooks()
        Console.WriteLine("Books in the Library:")
        For Each book As Book In books
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}")
        Next
    End Sub

    Public Sub DisplayUsers()
        Console.WriteLine("Library Users:")
        For Each user As User In users
            Console.WriteLine($"Username: {user.Username}, Email: {user.Email}")
        Next
    End Sub
End Class
