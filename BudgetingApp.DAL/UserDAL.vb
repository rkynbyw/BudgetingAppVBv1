﻿Imports System.Data
Imports System.Data.SqlClient
Imports BudgetingApp.BO
Imports BudgetingApp.Interface
Public Class UserDAL
    Implements IUser

    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        strConn = "Server=.\BSISqlExpress; Database=BudgetingApp; Trusted_Connection=True"
        conn = New SqlConnection(strConn)

    End Sub

    Public Function GetAll() As List(Of User) Implements ICrud(Of User).GetAll
        Dim Users As New List(Of User)
        Try
            Dim strSql = "SELECT * FROM Users order by UserID"

            conn = New SqlConnection(strConn)
            cmd = New SqlCommand(strSql, conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    Dim user1 As New User
                    user1.UserID = CInt(dr("UserID"))
                    user1.Email = dr("Email").ToString()
                    user1.Username = dr("Username").ToString()
                    user1.FullName = dr("FullName").ToString()
                    user1.HashedPassword = dr("HashedPassword").ToString()
                    Users.Add(user1)
                End While
            End If
            dr.Close()

            Return Users

        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function Create(obj As User) As Integer Implements ICrud(Of User).Create

        Try
            Dim strSP = "usp_CreateUser"
            cmd = New SqlCommand(strSP, conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@email", obj.Email)
            cmd.Parameters.AddWithValue("@username", obj.Username)
            cmd.Parameters.AddWithValue("@fullname", obj.FullName)
            cmd.Parameters.AddWithValue("@password", obj.HashedPassword)
            cmd.Parameters.AddWithValue("@password", obj.Salt)

            conn.Open()
            Dim result = cmd.ExecuteNonQuery
            If result <> 1 Then
                Throw New ArgumentException("Customer not Created")
            End If
            Return result
        Catch sqlex As SqlException
            Throw New ArgumentException(sqlex.Message & " " & sqlex.Number)
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try


    End Function





    Public Function GetById(id As Integer) As User Implements ICrud(Of User).GetById
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As User) As Integer Implements ICrud(Of User).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of User).Delete
        Throw New NotImplementedException()
    End Function

    Public Function GetByEmail() As List(Of User) Implements IUser.GetByEmail
        Throw New NotImplementedException()
    End Function
End Class
