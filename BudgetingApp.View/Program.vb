Imports BudgetingApp.BO
Imports BudgetingApp.DAL


Module Program

    Sub GetAllUser()
        Dim customerDAL As New DAL.UserDAL()
        Dim users As List(Of User) = customerDAL.GetAll()

        For Each user In users
            Console.WriteLine("{0},{1},{2},{3}", user.UserID, user.Email, user.Username, user.FullName)
        Next
    End Sub

    Sub GetAllBalance()
        Dim walletDAL As New DAL.WalletDAL()
        Dim wallets As List(Of Wallet) = walletDAL.GetAll()

        For Each wallet In wallets
            Console.WriteLine($"Wallet ID: {wallet.WalletID}, Balance: {wallet.Balance}")
        Next
    End Sub

    Sub CreateUser()
        Dim newUser As New User
        newUser.Email = "rekyan123@gmail.com"
        newUser.Username = "rekyanbayu123"
        newUser.FullName = "Rekyan Bayu 123"
        newUser.Password = "12345" ' Provide the plain text password

        ' Call the Create function
        Dim userDAL As New DAL.UserDAL()
        Dim result As Integer = userDAL.Create(newUser)

        If result = 1 Then
            Console.WriteLine("User created successfully!")
        Else
            Console.WriteLine("Error creating user.")
        End If
    End Sub

    Sub UpdateUser()
        Dim userToUpdate As New User
        userToUpdate.UserID = 123
        userToUpdate.Email = "updated_email@example.com"
        userToUpdate.Username = "updated_username"
        userToUpdate.FullName = "Updated Full Name"


        Dim userDAL As New UserDAL()


        Dim updateResult As Integer = userDAL.Update(userToUpdate)

        If updateResult = 1 Then
            Console.WriteLine("User updated successfully!")
        Else
            Console.WriteLine("Error updating user.")
        End If
    End Sub


    Sub DeleteUser()
        Dim userIdToDelete = 14
        Dim userDAL As New UserDAL()
        Dim deleteResult As Integer = UserDAL.Delete(userIdToDelete)

        If deleteResult = 1 Then
            Console.WriteLine("User deleted successfully.")
        Else
            Console.WriteLine("Error deleting user.")
        End If

    End Sub


    Sub Main(args As String())

        'GetAllUser()
        'GetAllBalance()
        'CreateUser()
        'UpdateUser()
        DeleteUser()
    End Sub
End Module
