Imports BudgetingApp.BO
Public Interface ITransaction
    Inherits ICrud(Of Transaction)
    Function GetByUserId(ByVal id As Integer) As Transaction
End Interface
