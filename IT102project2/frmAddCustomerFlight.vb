Public Class frmAddCustomerFlight
    Dim intPassengerID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPassengerID = intReceivedValue
    End Sub
    Private Sub frmAddCustomerFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class