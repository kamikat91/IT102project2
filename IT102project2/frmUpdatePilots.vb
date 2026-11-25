Imports System.Data.SQLite
Imports System.IO

Public Class frmUpdatePilots
    Dim intPilotID As Integer

    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPilotID = intReceivedValue
    End Sub

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

            Dim strSelectPilot As String = "SELECT * FROM TPilots WHERE intPilotID = @intPilotID"
            Using cmdPilot As New SQLiteCommand(strSelectPilot, conn)
                cmdPilot.Parameters.AddWithValue("@intPilotID", intPilotID)

                Using reader As SQLiteDataReader = cmdPilot.ExecuteReader()
                    If reader.Read() Then
                        txtfirstname.Text = reader("strFirstName").ToString()
                        txtlastname.Text = reader("strLastName").ToString()
                        txtemployeeID.Text = reader("strEmployeeID").ToString()
                        txtdateofhire.Text = reader("dtmDateOfHire").ToString()
                        txtdateoftermination.Text = reader("dtmDateOfTermination").ToString()
                        txtdateoflicense.Text = reader("dtmDateOfLicense").ToString()
                        cbopilotroles.SelectedValue = Convert.ToInt32(reader("intPilotRoleID"))
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
           String.IsNullOrWhiteSpace(txtlastname.Text) OrElse
           String.IsNullOrWhiteSpace(txtemployeeID.Text) OrElse
           String.IsNullOrWhiteSpace(txtdateofhire.Text) OrElse
           String.IsNullOrWhiteSpace(txtdateoftermination.Text) OrElse
           String.IsNullOrWhiteSpace(txtdateoflicense.Text) OrElse
           cbopilotroles.SelectedValue Is Nothing Then
            MessageBox.Show("All fields are required. Please fill in every box.", "Validation Error")
            Exit Sub
        End If

        Dim strFirstName As String = txtfirstname.Text
        Dim strLastName As String = txtlastname.Text
        Dim strEmployeeID As String = txtemployeeID.Text
        Dim strDateOfHire As String = txtdateofhire.Text
        Dim strDateOfTermination As String = txtdateoftermination.Text
        Dim strDateOfLicense As String = txtdateoflicense.Text
        Dim intPilotRoleID As Integer = Convert.ToInt32(cbopilotroles.SelectedValue)

        Dim strUpdateQuery As String =
            "UPDATE TPilots " &
            "SET strFirstName = @strFirstName, " &
            "    strLastName = @strLastName, " &
            "    strEmployeeID = @strEmployeeID, " &
            "    dtmDateOfHire = @dtmDateOfHire, " &
            "    dtmDateOfTermination = @dtmDateOfTermination, " &
            "    dtmDateOfLicense = @dtmDateOfLicense, " &
            "    intPilotRoleID = @intPilotRoleID " &
            "WHERE intPilotID = @intPilotID"

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
                command.Parameters.AddWithValue("@strEmployeeID", strEmployeeID)
                command.Parameters.AddWithValue("@dtmDateOfHire", strDateOfHire)
                command.Parameters.AddWithValue("@dtmDateOfTermination", strDateOfTermination)
                command.Parameters.AddWithValue("@dtmDateOfLicense", strDateOfLicense)
                command.Parameters.AddWithValue("@intPilotRoleID", intPilotRoleID)
                command.Parameters.AddWithValue("@intPilotID", intPilotID)

                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Row updated!")
    End Sub
End Class