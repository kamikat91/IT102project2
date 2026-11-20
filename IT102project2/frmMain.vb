Public Class frmMain
    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        Dim frmcustomerselectdisplay As New frmCustomerSelect
        frmcustomerselectdisplay.ShowDialog()
    End Sub

    Private Sub btnpilots_Click(sender As Object, e As EventArgs) Handles btnpilots.Click
        Dim frmpilotselectdisplay As New frmPilotSelect
        frmpilotselectdisplay.ShowDialog()
    End Sub

    Private Sub btnattendants_Click(sender As Object, e As EventArgs) Handles btnattendants.Click
        Dim frmattendantsselectdisplay As New frmAttendantSelect
        frmattendantsselectdisplay.ShowDialog()
    End Sub

    Private Sub btnstatistics_Click(sender As Object, e As EventArgs) Handles btnstatistics.Click
        Dim frmoverallstatisticsdisplay As New frmOverallStatistics
        frmoverallstatisticsdisplay.ShowDialog()
    End Sub
End Class
