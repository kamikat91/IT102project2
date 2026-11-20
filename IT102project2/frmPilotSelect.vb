Imports System.Data.SQLite
Imports System.IO

Public Class frmPilotSelect
    Private Sub frmPilotSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            '' get primary key, first name, and last name from tpilots
            Dim strPilotQuery As String = "SELECT intPilotID, strFirstName || ' ' || strLastName AS strFullName FROM TPilots"

            Using command As New SQLiteCommand(strPilotQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cbopilots.DataSource = dataTable
                cbopilots.DisplayMember = "strFullName"
                cbopilots.ValueMember = "intPilotID"
            End Using

        End Using
    End Sub
End Class