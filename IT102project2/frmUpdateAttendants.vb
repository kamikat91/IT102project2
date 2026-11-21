Imports System.Data.SQLite
Imports System.IO

Public Class frmUpdateAttendants
    Private Sub frmUpdateAttendants_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strEmployeeID As String
        Dim strDateOfHire As String
        Dim strDateOfTermination As String
        Dim intAttendantID As Integer

        strFirstName = txtfirstname.Text
        strLastName = txtlastname.Text
        strEmployeeID = txtemployeeID.Text
        strDateOfHire = txtdateofhire.Text
        strDateOfTermination = txtdateoftermination.Text

        Dim strUpdateQuery As String =
            $"UPDATE TAttendants
            SET strFirstName = '{strFirstName}',
            strLastName = '{strLastName}',
            strEmployeeID = '{strEmployeeID}',
            dtmDateOfHire = {strDateOfHire},
            dtmDateOfTermination = {strDateOfTermination},
            WHERE intAttendantID = {intAttendantID}"

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
    End Sub
End Class