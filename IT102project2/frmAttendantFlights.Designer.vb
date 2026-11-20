<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantFlights
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
        Me.lblmilesflown = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstflights = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblmilesflown
        '
        Me.lblmilesflown.AutoSize = True
        Me.lblmilesflown.Location = New System.Drawing.Point(583, 184)
        Me.lblmilesflown.Name = "lblmilesflown"
        Me.lblmilesflown.Size = New System.Drawing.Size(48, 16)
        Me.lblmilesflown.TabIndex = 5
        Me.lblmilesflown.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Miles Flown:"
        '
        'lstflights
        '
        Me.lstflights.FormattingEnabled = True
        Me.lstflights.ItemHeight = 16
        Me.lstflights.Location = New System.Drawing.Point(169, 71)
        Me.lstflights.Name = "lstflights"
        Me.lstflights.Size = New System.Drawing.Size(340, 308)
        Me.lstflights.TabIndex = 3
        '
        'frmAttendantFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblmilesflown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstflights)
        Me.Name = "frmAttendantFlights"
        Me.Text = "frmAttendantFlights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblmilesflown As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstflights As ListBox
End Class
