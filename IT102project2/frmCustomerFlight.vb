Imports System.Data.SQLite
Imports System.IO

Public Class frmCustomerFlight
    Dim intPassengerID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPassengerID = intReceivedValue
    End Sub
    Private Sub frmCustomerFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim databasePath As String =
        Path.GetFullPath(Path.Combine(Application.StartupPath,
                 "..\..\..\flyme2themoon.db"))

        Dim connectionString As String =
        "Data Source=" & databasePath & ";Version=3;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT COALESCE (SUM(TFlights.intMilesFlown), 0) " &
                             "FROM TFlights " &
                             "JOIN TFlightPassengers ON TFlights.intFlightID = TFlightPassengers.intFlightID " &
                             "WHERE TFlightPassengers.intPassengerID = @intPassengerID"

            Using command As New SQLiteCommand(strQuery, conn)
                command.Parameters.AddWithValue("@intPassengerID", intPassengerID)

                Dim intTotalMiles As Integer = Convert.ToInt32(command.ExecuteScalar())
                lblmilesflown.Text = intTotalMiles.ToString("N0") & " miles"
            End Using


            Dim strFlightsQuery As String = "SELECT TFlights.strFlightNumber " &
                                            "FROM TFlights " &
                                            "INNER JOIN TFlightPassengers ON TFlights.intFlightID = TFlightPassengers.intFlightID " &
                                            "WHERE TFlightPassengers.intPassengerID = @intPassengerID " &
                                            "ORDER BY TFlights.strFlightNumber"

            Using command As New SQLiteCommand(strFlightsQuery, conn)
                command.Parameters.AddWithValue("@intPassengerID", intPassengerID)

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