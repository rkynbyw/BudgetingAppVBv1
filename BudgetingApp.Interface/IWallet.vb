Imports BudgetingApp.BO

Public Interface IWallet
    Inherits ICrud(Of Wallet)

    Function GetWalletByUserID() As List(Of Wallet)
End Interface
