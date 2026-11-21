Imports System.Data.SQLite
Imports System.IO

Public Class frmUpdatePilots
    Private Sub frmUpdatePilots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"
            Using command As New SQLiteCommand(strQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cbopilotroles.DataSource = dataTable
                cbopilotroles.DisplayMember = "strPilotRole"
                cbopilotroles.ValueMember = "intPilotRoleID"
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strEmployeeID As String
        Dim strDateOfHire As String
        Dim strDateOfTermination As String
        Dim strDateOfLicense As String
        Dim intPilotRoleID As Integer
        Dim intPilotID As Integer

        strFirstName = txtfirstname.Text
        strLastName = txtlastname.Text
        strEmployeeID = txtemployeeID.Text
        strDateOfHire = txtdateofhire.Text
        strDateOfTermination = txtdateoftermination.Text
        strDateOfLicense = txtdateoflicense.Text
        intPilotRoleID = cbopilotroles.SelectedValue

        Dim strUpdateQuery As String =
            $"UPDATE TPilots
            SET strFirstName = '{strFirstName}',
            strLastName = '{strLastName}',
            strEmployeeID = '{strEmployeeID}',
            dtmDateOfHire = {strDateOfHire},
            dtmDateOfTermination = {strDateOfTermination},
            dtmDateOfLicense = {strDateOfLicense},
            intPilotRoleID = {intPilotRoleID}
            WHERE intPilotID = {intPilotID}"

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