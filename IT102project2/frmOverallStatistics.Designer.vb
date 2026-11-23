<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverallStatistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltotalnumberofcustomers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstpilots = New System.Windows.Forms.ListBox()
        Me.lstattendants = New System.Windows.Forms.ListBox()
        Me.lbltotalflightstakenbyallcustomers = New System.Windows.Forms.Label()
        Me.lblaveragemilesflownforallcustomer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbltotalnumberofcustomers
        '
        Me.lbltotalnumberofcustomers.AutoSize = True
        Me.lbltotalnumberofcustomers.Location = New System.Drawing.Point(278, 63)
        Me.lbltotalnumberofcustomers.Name = "lbltotalnumberofcustomers"
        Me.lbltotalnumberofcustomers.Size = New System.Drawing.Size(48, 16)
        Me.lbltotalnumberofcustomers.TabIndex = 0
        Me.lbltotalnumberofcustomers.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total number of customers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total flights taken by all customers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Average miles flown for all customer:"
        '
        'lstpilots
        '
        Me.lstpilots.FormattingEnabled = True
        Me.lstpilots.ItemHeight = 16
        Me.lstpilots.Location = New System.Drawing.Point(101, 194)
        Me.lstpilots.Name = "lstpilots"
        Me.lstpilots.Size = New System.Drawing.Size(285, 244)
        Me.lstpilots.TabIndex = 4
        '
        'lstattendants
        '
        Me.lstattendants.FormattingEnabled = True
        Me.lstattendants.ItemHeight = 16
        Me.lstattendants.Location = New System.Drawing.Point(450, 194)
        Me.lstattendants.Name = "lstattendants"
        Me.lstattendants.Size = New System.Drawing.Size(285, 244)
        Me.lstattendants.TabIndex = 5
        '
        'lbltotalflightstakenbyallcustomers
        '
        Me.lbltotalflightstakenbyallcustomers.AutoSize = True
        Me.lbltotalflightstakenbyallcustomers.Location = New System.Drawing.Point(281, 105)
        Me.lbltotalflightstakenbyallcustomers.Name = "lbltotalflightstakenbyallcustomers"
        Me.lbltotalflightstakenbyallcustomers.Size = New System.Drawing.Size(48, 16)
        Me.lbltotalflightstakenbyallcustomers.TabIndex = 6
        Me.lbltotalflightstakenbyallcustomers.Text = "Label4"
        '
        'lblaveragemilesflownforallcustomer
        '
        Me.lblaveragemilesflownforallcustomer.AutoSize = True
        Me.lblaveragemilesflownforallcustomer.Location = New System.Drawing.Point(281, 151)
        Me.lblaveragemilesflownforallcustomer.Name = "lblaveragemilesflownforallcustomer"
        Me.lblaveragemilesflownforallcustomer.Size = New System.Drawing.Size(48, 16)
        Me.lblaveragemilesflownforallcustomer.TabIndex = 7
        Me.lblaveragemilesflownforallcustomer.Text = "Label4"
        '
        'frmOverallStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblaveragemilesflownforallcustomer)
        Me.Controls.Add(Me.lbltotalflightstakenbyallcustomers)
        Me.Controls.Add(Me.lstattendants)
        Me.Controls.Add(Me.lstpilots)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltotalnumberofcustomers)
        Me.Name = "frmOverallStatistics"
        Me.Text = "frmOverallStatistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltotalnumberofcustomers As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstpilots As ListBox
    Friend WithEvents lstattendants As ListBox
    Friend WithEvents lbltotalflightstakenbyallcustomers As Label
    Friend WithEvents lblaveragemilesflownforallcustomer As Label
End Class
