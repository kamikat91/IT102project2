Imports System.Data.SQLite
Imports System.IO

Public Class frmUpdateAttendants
    Dim intAttendantID As Integer

    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intAttendantID = intReceivedValue
    End Sub

    Private Sub frmUpdateAttendants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            Dim strSelectAttendant As String = "SELECT * FROM TAttendants WHERE intAttendantID = @intAttendantID"
            Using cmdAttendant As New SQLiteCommand(strSelectAttendant, conn)
                cmdAttendant.Parameters.AddWithValue("@intAttendantID", intAttendantID)

                Using reader As SQLiteDataReader = cmdAttendant.ExecuteReader()
                    If reader.Read() Then
                        txtfirstname.Text = reader("strFirstName").ToString()
                        txtlastname.Text = reader("strLastName").ToString()
                        txtemployeeID.Text = reader("strEmployeeID").ToString()
                        txtdateofhire.Text = reader("dtmDateOfHire").ToString()
                        txtdateoftermination.Text = reader("dtmDateOfTermination").ToString()
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
           String.IsNullOrWhiteSpace(txtdateoftermination.Text) Then
            MessageBox.Show("All fields are required. Please fill in every box.", "Validation Error")
            Exit Sub
        End If

        Dim strFirstName As String = txtfirstname.Text
        Dim strLastName As String = txtlastname.Text
        Dim strEmployeeID As String = txtemployeeID.Text
        Dim strDateOfHire As String = txtdateofhire.Text
        Dim strDateOfTermination As String = txtdateoftermination.Text

        Dim strUpdateQuery As String =
            "UPDATE TAttendants " &
            "SET strFirstName = @strFirstName, " &
            "    strLastName = @strLastName, " &
            "    strEmployeeID = @strEmployeeID, " &
            "    dtmDateOfHire = @dtmDateOfHire, " &
            "    dtmDateOfTermination = @dtmDateOfTermination " &
            "WHERE intAttendantID = @intAttendantID"

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
                command.Parameters.AddWithValue("@intAttendantID", intAttendantID)

                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Row updated!")
    End Sub
End Class