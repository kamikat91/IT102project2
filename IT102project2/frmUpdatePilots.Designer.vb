<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePilots
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.cbopilotroles = New System.Windows.Forms.ComboBox()
        Me.txtdateoflicense = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(308, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Pilot Role:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Date Of Licence:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Date Of Termination:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(308, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Date Of Hire:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Employee ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "First Name:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(418, 68)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(100, 22)
        Me.txtfirstname.TabIndex = 37
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(418, 106)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 22)
        Me.txtlastname.TabIndex = 36
        '
        'txtemployeeID
        '
        Me.txtemployeeID.Location = New System.Drawing.Point(418, 145)
        Me.txtemployeeID.Name = "txtemployeeID"
        Me.txtemployeeID.Size = New System.Drawing.Size(100, 22)
        Me.txtemployeeID.TabIndex = 35
        '
        'txtdateofhire
        '
        Me.txtdateofhire.Location = New System.Drawing.Point(418, 183)
        Me.txtdateofhire.Name = "txtdateofhire"
        Me.txtdateofhire.Size = New System.Drawing.Size(100, 22)
        Me.txtdateofhire.TabIndex = 34
        '
        'txtdateoftermination
        '
        Me.txtdateoftermination.Location = New System.Drawing.Point(418, 221)
        Me.txtdateoftermination.Name = "txtdateoftermination"
        Me.txtdateoftermination.Size = New System.Drawing.Size(100, 22)
        Me.txtdateoftermination.TabIndex = 33
        '
        'cbopilotroles
        '
        Me.cbopilotroles.FormattingEnabled = True
        Me.cbopilotroles.Location = New System.Drawing.Point(418, 298)
        Me.cbopilotroles.Name = "cbopilotroles"
        Me.cbopilotroles.Size = New System.Drawing.Size(121, 24)
        Me.cbopilotroles.TabIndex = 32
        '
        'txtdateoflicense
        '
        Me.txtdateoflicense.Location = New System.Drawing.Point(418, 258)
        Me.txtdateoflicense.Name = "txtdateoflicense"
        Me.txtdateoflicense.Size = New System.Drawing.Size(100, 22)
        Me.txtdateoflicense.TabIndex = 31
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(377, 359)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 30
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'frmUpdatePilots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.cbopilotroles)
        Me.Controls.Add(Me.txtdateoflicense)
        Me.Controls.Add(Me.btnsubmit)
        Me.Name = "frmUpdatePilots"
        Me.Text = "frmUpdatePilots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
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
    Friend WithEvents cbopilotroles As ComboBox
    Friend WithEvents txtdateoflicense As TextBox
    Friend WithEvents btnsubmit As Button
End Class
