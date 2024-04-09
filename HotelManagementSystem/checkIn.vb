Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class checkIn

    Public selectedRoomType As String

    Private Sub checkIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadComboBoxRoomType()
        txtNumber.Text = "09"
    End Sub

    Public Sub loadComboBoxRoomType()
        Dim uniqueValues As New List(Of String)

        con.Open()

        ' Retrieve unique values from the Room_Type column
        Dim query As String = "SELECT DISTINCT Room_Type FROM tbl_Rooms"
        Using cmd As SqlCommand = New SqlCommand(query, con)
            ' Execute the query and retrieve the unique values
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                uniqueValues.Add(reader("Room_Type").ToString())
            End While

            con.Close()
        End Using

        ' Bind the List to the ComboBox's DataSource property
        cmbRoomType.DataSource = uniqueValues
    End Sub

    Public Sub loadComboBoxRoomNo()
        Dim uniqueValues As New List(Of String)

        con.Open()

        ' Retrieve unique values from the Room_No column
        Dim query As String = "SELECT DISTINCT Room_No FROM tbl_Rooms WHERE Room_Type = @Room_Type AND Guest_name IS NULL"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Room_Type", selectedRoomType)

            ' Execute the query and retrieve the unique values
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                uniqueValues.Add(reader("Room_No").ToString())
            End While
            con.Close()

            ' Bind the List to the ComboBox's DataSource property
            cmbRoomNo.DataSource = uniqueValues
        End Using
    End Sub

    Private Sub cmbRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoomType.SelectedIndexChanged
        selectedRoomType = cmbRoomType.SelectedItem.ToString()
        loadComboBoxRoomNo()

        Dim query As String = "SELECT Room_Rate FROM tbl_Rooms WHERE Room_Type = @Room_Type"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Room_Type", selectedRoomType)

            con.Open()
            Dim roomRate As Object = cmd.ExecuteScalar()
            con.Close()

            ' Display the Room_Rate value in the label
            If roomRate IsNot Nothing Then
                lblRoomRate.Text = roomRate.ToString()
            Else
                lblRoomRate.Text = "N/A"
            End If
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.TextLength = 0 Or txtAddress.TextLength = 0 Or txtEmail.TextLength = 0 Or txtNumber.TextLength <= 10 Or drpGender.SelectedIndex = -1 Or dudAdult.Value = 0  Or cmbRoomNo.SelectedIndex = -1 Then
            MessageBox.Show("Please fill up the Check-In form Correctly", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Customer_Name As String = txtName.Text
            Dim Phone_No As String = txtNumber.Text
            Dim Email As String = txtEmail.Text
            Dim Address As String = txtAddress.Text
            Dim No_Of_Adults As String = dudAdult.Text
            Dim No_Of_Children As String = dudChildren.Text
            Dim Gender As String = drpGender.Text
            Dim Check_In As String = dtpCheckIn.Text
            Dim Check_Out As String = dtpCheckOut.Text
            Dim Room_No As String = cmbRoomNo.Text

            ' Query for Guest
            Dim queryGuest As String = "INSERT INTO tbl_guest (Customer_Name, Gender, Email_Address, Address, No_Of_Adults, No_Of_Children, Phone_No, Checked_In) " & "VALUES (@Customer_Name, @Gender, @Email_Address, @Address, @No_Of_Adults, @No_Of_Children, @Phone_No, @Checked_In)"

            Using cmd As SqlCommand = New SqlCommand(queryGuest, con)
                cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
                cmd.Parameters.AddWithValue("@Gender", Gender)
                cmd.Parameters.AddWithValue("@Email_Address", Email)
                cmd.Parameters.AddWithValue("@Address", Address)
                cmd.Parameters.AddWithValue("@No_Of_Adults", No_Of_Adults)
                cmd.Parameters.AddWithValue("@No_Of_Children", No_Of_Children)
                cmd.Parameters.AddWithValue("@Phone_No", Phone_No)
                cmd.Parameters.AddWithValue("@Checked_In", Check_In)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                txtName.Clear()
                txtNumber.Clear()
                txtEmail.Clear()
                txtAddress.Clear()
            End Using

            ' Query for Room
            Dim fixqueryRoom As String = "Update tbl_rooms Set Guest_Name = @Customer_Name, Phone_No = @Phone_No Where Room_No = @Room_No"
            Using cmd As SqlCommand = New SqlCommand(fixqueryRoom, con)
                cmd.Parameters.AddWithValue("@Room_No", Room_No)
                cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
                cmd.Parameters.AddWithValue("@Phone_No", Phone_No)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MsgBox("Succeed")
            loadComboBoxRoomNo()
        End If
    End Sub

    Private Sub tmrCheckIn_Tick(sender As Object, e As EventArgs) Handles tmrCheckIn.Tick
        Dim now As DateTime = DateTime.Now

        dtpCheckIn.Value = now
    End Sub

    ' Condition to Each Text

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If txtName.TextLength >= 24 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            Exit Sub
        End If

        ' Only allow periods as special characters
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If txtNumber.TextLength >= 11 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Back) AndAlso txtNumber.TextLength <= 2 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"
        Dim emailRegex As New Regex(emailPattern)

        If Not emailRegex.IsMatch(txtEmail.Text) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
            txtEmail.Clear()
        End If
    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        If txtAddress.TextLength >= 75 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            Exit Sub
        End If

        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class