Public Class frmAttendantMainMenu
    Dim intAttendantID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intAttendantID = intReceivedValue
    End Sub
    Private Sub frmAttendantMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnupdateattendants_Click(sender As Object, e As EventArgs) Handles btnupdateattendants.Click
        Dim frmupdateattendantsdisplay As New frmUpdateAttendants(intAttendantID)
        frmupdateattendantsdisplay.ShowDialog()
    End Sub

    Private Sub btnshowattendantflights_Click(sender As Object, e As EventArgs) Handles btnshowattendantflights.Click
        Dim frmattendantflightsdisplay As New frmAttendantFlights(intAttendantID)
        frmattendantflightsdisplay.ShowDialog()
    End Sub
End Class