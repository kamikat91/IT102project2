<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomerFlight
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.cboflights = New System.Windows.Forms.ComboBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seat:"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(492, 213)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(100, 22)
        Me.txtinput.TabIndex = 4
        '
        'cboflights
        '
        Me.cboflights.FormattingEnabled = True
        Me.cboflights.Location = New System.Drawing.Point(62, 208)
        Me.cboflights.Name = "cboflights"
        Me.cboflights.Size = New System.Drawing.Size(254, 24)
        Me.cboflights.TabIndex = 3
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnsubmit.Location = New System.Drawing.Point(320, 276)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(149, 71)
        Me.btnsubmit.TabIndex = 55
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'frmAddCustomerFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.cboflights)
        Me.Name = "frmAddCustomerFlight"
        Me.Text = "frmAddCustomerFlight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtinput As TextBox
    Friend WithEvents cboflights As ComboBox
    Friend WithEvents btnsubmit As Button
End Class
