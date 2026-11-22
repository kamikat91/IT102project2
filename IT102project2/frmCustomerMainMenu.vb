Public Class frmCustomerMainMenu

    Dim intPassengerID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intPassengerID = intReceivedValue
    End Sub

    Private Sub frmCustomerMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnupdatecustomers_Click(sender As Object, e As EventArgs) Handles btnupdatecustomers.Click
        Dim frmupdatecustomerdisplay As New frmUpdateCustomer(intPassengerID)
        frmupdatecustomerdisplay.ShowDialog()
    End Sub

    Private Sub btnaddcustomerflight_Click(sender As Object, e As EventArgs) Handles btnaddcustomerflight.Click
        Dim frmupdatecustomerdisplay As New frmAddCustomerFlight(intPassengerID)
        frmupdatecustomerdisplay.ShowDialog()
    End Sub

    Private Sub btnshowcustomerflights_Click(sender As Object, e As EventArgs) Handles btnshowcustomerflights.Click
        Dim frmupdatecustomerdisplay As New frmCustomerFlight(intPassengerID)
        frmupdatecustomerdisplay.ShowDialog()
    End Sub
End Class