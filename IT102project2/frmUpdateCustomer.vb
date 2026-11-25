Imports System.Data.SQLite
Imports System.IO

Public Class frmUpdateCustomer
    Dim intPassengerID As Integer

    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPassengerID = intReceivedValue
    End Sub

    Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            Dim strQuery As String = "SELECT intStateID, strState FROM TStates"
            Using command As New SQLiteCommand(strQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cbostate.DataSource = dataTable
                cbostate.DisplayMember = "strState"
                cbostate.ValueMember = "intStateID"
            End Using

            Dim strSelectCustomer As String = "SELECT * FROM TPassengers WHERE intPassengerID = @intPassengerID"
            Using cmdCustomer As New SQLiteCommand(strSelectCustomer, conn)
                cmdCustomer.Parameters.AddWithValue("@intPassengerID", intPassengerID)

                Using reader As SQLiteDataReader = cmdCustomer.ExecuteReader()
                    If reader.Read() Then
                        txtfirstname.Text = reader("strFirstName").ToString()
                        txtlastname.Text = reader("strLastName").ToString()
                        txtaddress.Text = reader("strAddress").ToString()
                        txtcity.Text = reader("strCity").ToString()
                        cbostate.SelectedValue = Convert.ToInt32(reader("intStateID"))
                        txtzipcode.Text = reader("strZip").ToString()
                        txtphonenumber.Text = reader("strPhoneNumber").ToString()
                        txtemail.Text = reader("strEmail").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
           String.IsNullOrWhiteSpace(txtlastname.Text) OrElse
           String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtcity.Text) OrElse
           cbostate.SelectedValue Is Nothing OrElse
           String.IsNullOrWhiteSpace(txtzipcode.Text) OrElse
           String.IsNullOrWhiteSpace(txtphonenumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtemail.Text) Then
            MessageBox.Show("All fields are required. Please fill in every box.", "Validation Error")
            Exit Sub
        End If

        Dim strFirstName As String
        Dim strLastName As String
        Dim strPhoneNumber As String
        Dim strEmail As String
        Dim strAddress As String
        Dim strCity As String
        Dim strZip As String
        Dim intStateID As Integer

        strFirstName = txtfirstname.Text
        strLastName = txtlastname.Text
        strPhoneNumber = txtphonenumber.Text
        strEmail = txtemail.Text
        strAddress = txtaddress.Text
        strCity = txtcity.Text
        strZip = txtzipcode.Text
        intStateID = Convert.ToInt32(cbostate.SelectedValue)

        Dim strUpdateQuery As String =
            "UPDATE TPassengers " &
            "SET strFirstName = @strFirstName, " &
            "    strLastName = @strLastName, " &
            "    strAddress = @strAddress, " &
            "    strCity = @strCity, " &
            "    intStateID = @intStateID, " &
            "    strZip = @strZip, " &
            "    strPhoneNumber = @strPhoneNumber, " &
            "    strEmail = @strEmail " &
            "WHERE intPassengerID = @intPassengerID"

        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strUpdateQuery, conn)
                command.Parameters.AddWithValue("@strFirstName", strFirstName)
                command.Parameters.AddWithValue("@strLastName", strLastName)
                command.Parameters.AddWithValue("@strAddress", strAddress)
                command.Parameters.AddWithValue("@strCity", strCity)
                command.Parameters.AddWithValue("@intStateID", intStateID)
                command.Parameters.AddWithValue("@strZip", strZip)
                command.Parameters.AddWithValue("@strPhoneNumber", strPhoneNumber)
                command.Parameters.AddWithValue("@strEmail", strEmail)
                command.Parameters.AddWithValue("@intPassengerID", intPassengerID)

                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Row updated!")
    End Sub
End Class