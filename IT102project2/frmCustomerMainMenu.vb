Public Class frmCustomerMainMenu

    Dim cbopassengers.SelectedValue As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        cbopassengers.SelectedValue = intReceivedValue
    End Sub

    Private Sub frmCustomerMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class