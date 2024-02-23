Imports System.Data
Imports System.Data.SqlClient
Imports BudgetingApp.BO
Imports BudgetingApp.Interface


Public Class WalletDAL
    Implements IWallet

    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        strConn = "Server=.\BSISqlExpress; Database=BudgetingApp; Trusted_Connection=True"
        conn = New SqlConnection(strConn)
    End Sub

    Public Function GetAll() As List(Of Wallet) Implements ICrud(Of Wallet).GetAll
        Dim wallets As New List(Of Wallet)

        Try
            conn.Open()

            Dim strSP As String = "UserBalanceOnly"
            Using cmd As New SqlCommand(strSP, conn)
                cmd.CommandType = CommandType.StoredProcedure

                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        wallets.Add(New Wallet With {
                            .WalletID = CInt(dr("WalletID")),
                            .WalletTypeID = CInt(dr("WalletTypeID")),
                            .Balance = CInt(dr("Balance")),
                            .UserID = CInt(dr("UserID"))
                        })
                    End While
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return wallets
    End Function

    Public Function Create(obj As Wallet) As Integer Implements ICrud(Of Wallet).Create
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As Integer) As Wallet Implements ICrud(Of Wallet).GetById
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Wallet) As Integer Implements ICrud(Of Wallet).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Wallet).Delete
        Throw New NotImplementedException()
    End Function

    Public Function GetWalletByUserID() As List(Of Wallet) Implements IWallet.GetWalletByUserID
        Throw New NotImplementedException()
    End Function
End Class