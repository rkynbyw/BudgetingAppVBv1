Imports BudgetingApp.BO


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
    Sub Main(args As String())

        GetAllUser()
        GetAllBalance()

    End Sub
End Module
