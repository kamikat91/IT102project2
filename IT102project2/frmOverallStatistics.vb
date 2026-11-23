Imports System.Data.SQLite
Imports System.IO

Public Class frmOverallStatistics
    Private Sub frmOverallStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
            Path.GetFullPath(Path.Combine(Application.StartupPath,
                     "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
            "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            Dim strTotalCustomersQuery As String = "SELECT COUNT(*) FROM TPassengers"
            Using cmd As New SQLiteCommand(strTotalCustomersQuery, conn)
                Dim intTotalCustomers As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lbltotalnumberofcustomers.Text = intTotalCustomers.ToString("N0")
            End Using

            Dim strTotalFlightsQuery As String = "SELECT COUNT(*) FROM TFlightPassengers"
            Using cmd As New SQLiteCommand(strTotalFlightsQuery, conn)
                Dim intTotalFlights As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                lbltotalflightstakenbyallcustomers.Text = intTotalFlights.ToString("N0")
            End Using

            Dim strAvgMilesQuery As String = "SELECT COALESCE(AVG(TFlights.intMilesFlown), 0) " &
                                             "FROM TFlightPassengers " &
                                             "INNER JOIN TFlights ON TFlightPassengers.intFlightID = TFlights.intFlightID"
            Using cmd As New SQLiteCommand(strAvgMilesQuery, conn)
                Dim dblAvgMiles As Double = Convert.ToDouble(cmd.ExecuteScalar())
                lblaveragemilesflownforallcustomer.Text = dblAvgMiles.ToString("N2") & " miles"
            End Using

            Dim strPilotsQuery As String = "SELECT " &
                                           "  TPilots.strFirstName || ' ' || TPilots.strLastName || ' - ' || " &
                                           "  COALESCE(SUM(TFlights.intMilesFlown), 0) || ' miles' AS PilotStats " &
                                           "FROM TPilots " &
                                           "LEFT JOIN TPilotFlights ON TPilots.intPilotID = TPilotFlights.intPilotID " &
                                           "LEFT JOIN TFlights ON TPilotFlights.intFlightID = TFlights.intFlightID " &
                                           "GROUP BY TPilots.intPilotID, TPilots.strFirstName, TPilots.strLastName " &
                                           "ORDER BY TPilots.strLastName, TPilots.strFirstName"

            Using cmd As New SQLiteCommand(strPilotsQuery, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    lstpilots.Items.Clear()
                    While reader.Read()
                        lstpilots.Items.Add(reader("PilotStats").ToString())
                    End While
                End Using
            End Using

            Dim strAttendantsQuery As String = "SELECT " &
                                               "  TAttendants.strFirstName || ' ' || TAttendants.strLastName || ' - ' || " &
                                               "  COALESCE(SUM(TFlights.intMilesFlown), 0) || ' miles' AS AttendantStats " &
                                               "FROM TAttendants " &
                                               "LEFT JOIN TAttendantFlights ON TAttendants.intAttendantID = TAttendantFlights.intAttendantID " &
                                               "LEFT JOIN TFlights ON TAttendantFlights.intFlightID = TFlights.intFlightID " &
                                               "GROUP BY TAttendants.intAttendantID, TAttendants.strFirstName, TAttendants.strLastName " &
                                               "ORDER BY TAttendants.strLastName, TAttendants.strFirstName"

            Using cmd As New SQLiteCommand(strAttendantsQuery, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    lstattendants.Items.Clear()
                    While reader.Read()
                        lstattendants.Items.Add(reader("AttendantStats").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class