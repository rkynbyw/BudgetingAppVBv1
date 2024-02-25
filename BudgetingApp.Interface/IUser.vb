
Imports BudgetingApp.BO

Public Interface IUser
    Inherits ICrud(Of User)

    Function GetByEmail() As List(Of User)
    Function UpdateUserPassword(ByVal UserID As Integer, OldPassword As String, NewPassword As String) As Integer
End Interface
'Dim customerDALas As New DAL.UserDAL()
'Dim customers As List(Of User) = customerDALas.GetAll()

'For Each customer In customers
'    Console.WriteLine("{0},{1},{2},{3}", customer.UserID, customer.Email, customer.Username, customer.FullName)
'Next