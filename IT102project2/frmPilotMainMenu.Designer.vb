<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotMainMenu
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
        Me.btnshowpilotflights = New System.Windows.Forms.Button()
        Me.btnupdatepilots = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnshowpilotflights
        '
        Me.btnshowpilotflights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnshowpilotflights.Location = New System.Drawing.Point(464, 190)
        Me.btnshowpilotflights.Name = "btnshowpilotflights"
        Me.btnshowpilotflights.Size = New System.Drawing.Size(149, 71)
        Me.btnshowpilotflights.TabIndex = 60
        Me.btnshowpilotflights.Text = "Show Pilot Flights"
        Me.btnshowpilotflights.UseVisualStyleBackColor = True
        '
        'btnupdatepilots
        '
        Me.btnupdatepilots.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnupdatepilots.Location = New System.Drawing.Point(188, 190)
        Me.btnupdatepilots.Name = "btnupdatepilots"
        Me.btnupdatepilots.Size = New System.Drawing.Size(149, 71)
        Me.btnupdatepilots.TabIndex = 59
        Me.btnupdatepilots.Text = "Update Pilots"
        Me.btnupdatepilots.UseVisualStyleBackColor = True
        '
        'frmPilotMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnshowpilotflights)
        Me.Controls.Add(Me.btnupdatepilots)
        Me.Name = "frmPilotMainMenu"
        Me.Text = "frmPilotMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnshowpilotflights As Button
    Friend WithEvents btnupdatepilots As Button
End Class
