Public Class frmPilotFlights
    Dim intPilotID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPilotID = intReceivedValue
    End Sub
    Private Sub frmPilotFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class