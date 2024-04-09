Imports System.Data.SqlClient
Public Class checkOut
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = "SELECT Customer_Id, Customer_Name, Gender, Email_Address, Address, No_Of_Adults, No_Of_Children, Phone_No, Checked_Out FROM tbl_guest WHERE Customer_Name LIKE '%" & txtSearchCheckOut.Text & "%'"

        Using cmd = New SqlCommand(query, con)
            ' Execute the query and retrieve the results
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable
                    da.Fill(dt)
                    dgvCheckOut.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub checkOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcheckout()
    End Sub

    Public Sub loadcheckout()
        Dim query As String = "Select Customer_Id, Customer_Name, Gender, Email_Address, Address, No_Of_Adults, No_Of_Children, Phone_No, Checked_Out from tbl_guest"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            Using da As New SqlDataAdapter
                da.SelectCommand = cmd
                Using dt As New DataTable()
                    da.Fill(dt)
                    dgvCheckOut.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

End Class