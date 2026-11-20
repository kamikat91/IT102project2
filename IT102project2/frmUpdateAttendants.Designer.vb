<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateAttendants
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtemployeeID = New System.Windows.Forms.TextBox()
        Me.txtdateofhire = New System.Windows.Forms.TextBox()
        Me.txtdateoftermination = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(264, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Date Of Termination:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Date Of Hire:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Employee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "First Name:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(420, 107)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(100, 22)
        Me.txtfirstname.TabIndex = 37
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(420, 145)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 22)
        Me.txtlastname.TabIndex = 36
        '
        'txtemployeeID
        '
        Me.txtemployeeID.Location = New System.Drawing.Point(420, 184)
        Me.txtemployeeID.Name = "txtemployeeID"
        Me.txtemployeeID.Size = New System.Drawing.Size(100, 22)
        Me.txtemployeeID.TabIndex = 35
        '
        'txtdateofhire
        '
        Me.txtdateofhire.Location = New System.Drawing.Point(420, 222)
        Me.txtdateofhire.Name = "txtdateofhire"
        Me.txtdateofhire.Size = New System.Drawing.Size(100, 22)
        Me.txtdateofhire.TabIndex = 34
        '
        'txtdateoftermination
        '
        Me.txtdateoftermination.Location = New System.Drawing.Point(420, 260)
        Me.txtdateoftermination.Name = "txtdateoftermination"
        Me.txtdateoftermination.Size = New System.Drawing.Size(100, 22)
        Me.txtdateoftermination.TabIndex = 33
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(376, 331)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 30
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'frmUpdateAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtemployeeID)
        Me.Controls.Add(Me.txtdateofhire)
        Me.Controls.Add(Me.txtdateoftermination)
        Me.Controls.Add(Me.btnsubmit)
        Me.Name = "frmUpdateAttendants"
        Me.Text = "frmUpdateAttendants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtemployeeID As TextBox
    Friend WithEvents txtdateofhire As TextBox
    Friend WithEvents txtdateoftermination As TextBox
    Friend WithEvents btnsubmit As Button
End Class
