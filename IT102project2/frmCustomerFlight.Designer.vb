<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerFlight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstflights = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmilesflown = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstflights
        '
        Me.lstflights.FormattingEnabled = True
        Me.lstflights.ItemHeight = 16
        Me.lstflights.Location = New System.Drawing.Point(210, 60)
        Me.lstflights.Name = "lstflights"
        Me.lstflights.Size = New System.Drawing.Size(340, 308)
        Me.lstflights.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(569, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Miles Flown:"
        '
        'lblmilesflown
        '
        Me.lblmilesflown.AutoSize = True
        Me.lblmilesflown.Location = New System.Drawing.Point(624, 173)
        Me.lblmilesflown.Name = "lblmilesflown"
        Me.lblmilesflown.Size = New System.Drawing.Size(48, 16)
        Me.lblmilesflown.TabIndex = 2
        Me.lblmilesflown.Text = "Label2"
        '
        'frmCustomerFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblmilesflown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstflights)
        Me.Name = "frmCustomerFlight"
        Me.Text = "frmCustomerFlight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstflights As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblmilesflown As Label
End Class
