<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantMainMenu
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
        Me.btnshowattendantflights = New System.Windows.Forms.Button()
        Me.btnupdateattendants = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnshowattendantflights
        '
        Me.btnshowattendantflights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnshowattendantflights.Location = New System.Drawing.Point(449, 188)
        Me.btnshowattendantflights.Name = "btnshowattendantflights"
        Me.btnshowattendantflights.Size = New System.Drawing.Size(149, 71)
        Me.btnshowattendantflights.TabIndex = 58
        Me.btnshowattendantflights.Text = "Show Attendant Flights"
        Me.btnshowattendantflights.UseVisualStyleBackColor = True
        '
        'btnupdateattendants
        '
        Me.btnupdateattendants.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnupdateattendants.Location = New System.Drawing.Point(173, 188)
        Me.btnupdateattendants.Name = "btnupdateattendants"
        Me.btnupdateattendants.Size = New System.Drawing.Size(149, 71)
        Me.btnupdateattendants.TabIndex = 57
        Me.btnupdateattendants.Text = "Update Attendants"
        Me.btnupdateattendants.UseVisualStyleBackColor = True
        '
        'frmAttendantMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnshowattendantflights)
        Me.Controls.Add(Me.btnupdateattendants)
        Me.Name = "frmAttendantMainMenu"
        Me.Text = "frmAttendantMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnshowattendantflights As Button
    Friend WithEvents btnupdateattendants As Button
End Class
