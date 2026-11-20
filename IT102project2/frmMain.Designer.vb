<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btncustomer = New System.Windows.Forms.Button()
        Me.btnpilots = New System.Windows.Forms.Button()
        Me.btnattendants = New System.Windows.Forms.Button()
        Me.btnadministration = New System.Windows.Forms.Button()
        Me.btnstatistics = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btncustomer
        '
        Me.btncustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btncustomer.Location = New System.Drawing.Point(170, 79)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(149, 71)
        Me.btncustomer.TabIndex = 0
        Me.btncustomer.Text = "Customer"
        Me.btncustomer.UseVisualStyleBackColor = True
        '
        'btnpilots
        '
        Me.btnpilots.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnpilots.Location = New System.Drawing.Point(421, 79)
        Me.btnpilots.Name = "btnpilots"
        Me.btnpilots.Size = New System.Drawing.Size(149, 71)
        Me.btnpilots.TabIndex = 1
        Me.btnpilots.Text = "Pilots"
        Me.btnpilots.UseVisualStyleBackColor = True
        '
        'btnattendants
        '
        Me.btnattendants.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnattendants.Location = New System.Drawing.Point(293, 185)
        Me.btnattendants.Name = "btnattendants"
        Me.btnattendants.Size = New System.Drawing.Size(149, 71)
        Me.btnattendants.TabIndex = 2
        Me.btnattendants.Text = "Attendants"
        Me.btnattendants.UseVisualStyleBackColor = True
        '
        'btnadministration
        '
        Me.btnadministration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnadministration.Location = New System.Drawing.Point(170, 308)
        Me.btnadministration.Name = "btnadministration"
        Me.btnadministration.Size = New System.Drawing.Size(149, 71)
        Me.btnadministration.TabIndex = 3
        Me.btnadministration.Text = "Administration"
        Me.btnadministration.UseVisualStyleBackColor = True
        '
        'btnstatistics
        '
        Me.btnstatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnstatistics.Location = New System.Drawing.Point(421, 308)
        Me.btnstatistics.Name = "btnstatistics"
        Me.btnstatistics.Size = New System.Drawing.Size(149, 71)
        Me.btnstatistics.TabIndex = 4
        Me.btnstatistics.Text = "Statistics"
        Me.btnstatistics.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnstatistics)
        Me.Controls.Add(Me.btnadministration)
        Me.Controls.Add(Me.btnattendants)
        Me.Controls.Add(Me.btnpilots)
        Me.Controls.Add(Me.btncustomer)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btncustomer As Button
    Friend WithEvents btnpilots As Button
    Friend WithEvents btnattendants As Button
    Friend WithEvents btnadministration As Button
    Friend WithEvents btnstatistics As Button
End Class
