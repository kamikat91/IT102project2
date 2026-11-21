Imports System.Data.SQLite
Imports System.IO

Public Class frmUpdateCustomer
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
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strPhoneNumber As String
        Dim strEmail As String
        Dim strAddress As String
        Dim strCity As String
        Dim strZip As Integer
        Dim intStateID As Integer
        Dim intPassengerID As Integer

        strFirstName = txtfirstname.Text
        strLastName = txtlastname.Text
        strPhoneNumber = txtphonenumber.Text
        strEmail = txtemail.Text
        strAddress = txtaddress.Text
        strCity = txtcity.Text
        strZip = txtzipcode.Text
        intStateID = cbostate.SelectedValue

        Dim strUpdateQuery As String =
            $"UPDATE TPassengers
            SET strFirstName = '{strFirstName}',
            strLastName = '{strLastName}',
            strAddress = '{strAddress}',
            strCity = '{strCity}',
            intStateID = {intStateID},
            strZip = '{strZip}',
            strPhoneNumber = '{strPhoneNumber}',
            strEmail = '{strEmail}'
            WHERE intPassengerID = {intPassengerID}"

        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using command As New SQLiteCommand(strUpdateQuery, conn)
                command.ExecuteNonQuery()

            End Using
        End Using

        MessageBox.Show("Row updated!")
    End Sub
End Class