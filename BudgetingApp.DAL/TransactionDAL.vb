Imports BudgetingApp.BO
Imports BudgetingApp.Interface


Public Class TransactionDAL
    Implements ITransaction

    Public Function GetByUserId(id As Integer) As Transaction Implements ITransaction.GetByUserId
        Throw New NotImplementedException()
    End Function

    Public Function Create(obj As Transaction) As Integer Implements ICrud(Of Transaction).Create
        Throw New NotImplementedException()
    End Function

    Public Function GetAll() As List(Of Transaction) Implements ICrud(Of Transaction).GetAll
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As Integer) As Transaction Implements ICrud(Of Transaction).GetById
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Transaction) As Integer Implements ICrud(Of Transaction).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Transaction).Delete
        Throw New NotImplementedException()
    End Function
End Class
