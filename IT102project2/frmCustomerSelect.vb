Imports System.Data.SQLite
Imports System.IO

Public Class frmCustomerSelect
    Private Sub btnnewcustomer_Click(sender As Object, e As EventArgs) Handles btnnewcustomer.Click
        Dim frmaddcustomerdisplay As New frmAddCustomer
        frmaddcustomerdisplay.ShowDialog()
    End Sub

    Private Sub frmCustomerSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strPassengerQuery As String = "SELECT intPassengerID, strFirstName || ' ' || strLastName AS strFullName FROM TPassengers"

            Using command As New SQLiteCommand(strPassengerQuery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cbopassengers.DataSource = dataTable
                cbopassengers.DisplayMember = "strFullName"
                cbopassengers.ValueMember = "intPassengerID"
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim frmcustomermainmenudisplay As New frmCustomerMainMenu(cbopassengers.SelectedValue)
        frmcustomermainmenudisplay.ShowDialog()
    End Sub
End Class