Imports System.Data.SQLite
Imports System.IO

Public Class frmAttendantSelect
    Private Sub frmAttendantSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
    Path.GetFullPath(Path.Combine(Application.StartupPath,
             "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strPassengerQuery As String = "SELECT intAttendantID, strFirstName || ' ' || strLastName AS strFullName FROM TAttendants"

            Using command As New SQLiteCommand(strPassengerQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cboattendants.DataSource = dataTable
                cboattendants.DisplayMember = "strFullName"
                cboattendants.ValueMember = "intAttendantID"
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim frmattendantmainmenudisplay As New frmAttendantMainMenu(cboattendants.SelectedValue)
        frmattendantmainmenudisplay.ShowDialog()
    End Sub
End Class