Imports System.Data.SQLite
Imports System.IO

Public Class frmAttendantFlights
    Dim intAttendantID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intAttendantID = intReceivedValue
    End Sub
    Private Sub frmAttendantFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
        Path.GetFullPath(Path.Combine(Application.StartupPath,
                 "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
        "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT COALESCE (SUM(TFlights.intMilesFlown), 0) " &
                             "FROM TFlights " &
                             "JOIN TAttendantFlights ON TFlights.intFlightID = TAttendantFlights.intFlightID " &
                             "WHERE TAttendantFlights.intAttendantID = @intAttendantID"

            Using command As New SQLiteCommand(strQuery, conn)
                command.Parameters.AddWithValue("@intAttendantID", intAttendantID)

                Dim intTotalMiles As Integer = Convert.ToInt32(command.ExecuteScalar())
                lblmilesflown.Text = intTotalMiles.ToString("N0") & " miles"
            End Using


            Dim strFlightsQuery As String = "SELECT TFlights.strFlightNumber " &
                                            "FROM TFlights " &
                                            "INNER JOIN TAttendantFlights ON TFlights.intFlightID = TAttendantFlights.intFlightID " &
                                            "WHERE TAttendantFlights.intAttendantID = @intAttendantID " &
                                            "ORDER BY TFlights.strFlightNumber"

            Using command As New SQLiteCommand(strFlightsQuery, conn)
                command.Parameters.AddWithValue("@intAttendantID", intAttendantID)

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    lstflights.Items.Clear()

                    While reader.Read()
                        lstflights.Items.Add(reader("strFlightNumber").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class