<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSelect
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
        Me.btnnewcustomer = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbopassengers = New System.Windows.Forms.ComboBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnnewcustomer
        '
        Me.btnnewcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnnewcustomer.Location = New System.Drawing.Point(639, 12)
        Me.btnnewcustomer.Name = "btnnewcustomer"
        Me.btnnewcustomer.Size = New System.Drawing.Size(149, 71)
        Me.btnnewcustomer.TabIndex = 1
        Me.btnnewcustomer.Text = "New Customer"
        Me.btnnewcustomer.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(249, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Passenger:"
        '
        'cbopassengers
        '
        Me.cbopassengers.FormattingEnabled = True
        Me.cbopassengers.Location = New System.Drawing.Point(348, 211)
        Me.cbopassengers.Name = "cbopassengers"
        Me.cbopassengers.Size = New System.Drawing.Size(167, 24)
        Me.cbopassengers.TabIndex = 51
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnsubmit.Location = New System.Drawing.Point(331, 275)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(149, 71)
        Me.btnsubmit.TabIndex = 53
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'frmCustomerSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbopassengers)
        Me.Controls.Add(Me.btnnewcustomer)
        Me.Name = "frmCustomerSelect"
        Me.Text = "frmCustomerSelect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnewcustomer As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbopassengers As ComboBox
    Friend WithEvents btnsubmit As Button
End Class
