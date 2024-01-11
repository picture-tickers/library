' MainModule.vb
Module MainModule
    Sub Main()
        ' Create books
        Dim book1 As New Book("The Catcher in the Rye", "J.D. Salinger")
        Dim book2 As New Book("To Kill a Mockingbird", "Harper Lee")

        ' Create users
        Dim user1 As New User("john_doe", "john@example.com")
        Dim user2 As New User("jane_doe", "jane@example.com")

        ' Create a library and add books/users
        Dim library As New Library()
        library.AddBook(book1)
        library.AddBook(book2)
        library.AddUser(user1)
        library.AddUser(user2)

        ' Display books and users in the library
        library.DisplayBooks()
        Console.WriteLine()
        library.DisplayUsers()
    End Sub
End Module
