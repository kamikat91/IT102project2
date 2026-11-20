Public Class frmAttendantMainMenu

    Dim intAttendantID As Integer
    Public Sub New(ByVal intReceivedValue As Integer)
        InitializeComponent()
        intAttendantID = intReceivedValue
    End Sub
    Private Sub frmAttendantMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class