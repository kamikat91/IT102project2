Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO

Public Class frmAddCustomerFlight
    Dim intPassengerID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPassengerID = intReceivedValue
    End Sub
    Private Sub frmAddCustomerFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strquery As String = "SELECT intFlightID, strFlightNumber FROM TFlights"

            Using command As New SQLiteCommand(strquery, conn)
                Dim adapter As New SQLiteDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                cboflights.DataSource = dataTable
                cboflights.DisplayMember = "strFlightNumber"
                cboflights.ValueMember = "intFlightID"
            End Using
        End Using
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim cboflightchosen As String
        Dim strseatchosen As String

        cboflightchosen = cboflights.SelectedValue
        strseatchosen = txtinput.Text

        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strInsertQuery As String = "INSERT INTO TFlightPassengers (intFlightID, intPassengerID, strSeat) " &
                                 "VALUES (@intFlightID, @intPassengerID, @strSeat)"

            Using command As New SQLiteCommand(strInsertQuery, conn)
                command.Parameters.AddWithValue("@intFlightID", cboflightchosen)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class