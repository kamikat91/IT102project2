Public Class frmPilotMainMenu

    Dim intPilotID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPilotID = intReceivedValue
    End Sub
    Private Sub frmPilotMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnupdatepilots_Click(sender As Object, e As EventArgs) Handles btnupdatepilots.Click
        Dim frmupdatepilotdisplay As New frmUpdatePilots(intPilotID)
        frmupdatepilotdisplay.ShowDialog()
    End Sub

    Private Sub btnshowpilotflights_Click(sender As Object, e As EventArgs) Handles btnshowpilotflights.Click
        Dim frmpilotflightsdisplay As New frmPilotFlights(intPilotID)
        frmpilotflightsdisplay.ShowDialog()
    End Sub
End Class