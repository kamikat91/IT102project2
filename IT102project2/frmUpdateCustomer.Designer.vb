<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateCustomer
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtphonenumber = New System.Windows.Forms.TextBox()
        Me.cbostate = New System.Windows.Forms.ComboBox()
        Me.txtzipcode = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(279, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Email:"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(372, 170)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(146, 22)
        Me.txtemail.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(262, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Phone Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 16)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "State:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "City:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "First Name:"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(372, 59)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(146, 22)
        Me.txtfirstname.TabIndex = 56
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(372, 97)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(146, 22)
        Me.txtlastname.TabIndex = 55
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(372, 203)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(146, 22)
        Me.txtaddress.TabIndex = 54
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(372, 240)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(146, 22)
        Me.txtcity.TabIndex = 53
        '
        'txtphonenumber
        '
        Me.txtphonenumber.Location = New System.Drawing.Point(372, 136)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(146, 22)
        Me.txtphonenumber.TabIndex = 52
        '
        'cbostate
        '
        Me.cbostate.FormattingEnabled = True
        Me.cbostate.Location = New System.Drawing.Point(372, 319)
        Me.cbostate.Name = "cbostate"
        Me.cbostate.Size = New System.Drawing.Size(167, 24)
        Me.cbostate.TabIndex = 51
        '
        'txtzipcode
        '
        Me.txtzipcode.Location = New System.Drawing.Point(372, 279)
        Me.txtzipcode.Name = "txtzipcode"
        Me.txtzipcode.Size = New System.Drawing.Size(146, 22)
        Me.txtzipcode.TabIndex = 50
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(331, 368)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 49
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'frmUpdateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtphonenumber)
        Me.Controls.Add(Me.cbostate)
        Me.Controls.Add(Me.txtzipcode)
        Me.Controls.Add(Me.btnsubmit)
        Me.Name = "frmUpdateCustomer"
        Me.Text = "frmUpdateCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtcity As TextBox
    Friend WithEvents txtphonenumber As TextBox
    Friend WithEvents cbostate As ComboBox
    Friend WithEvents txtzipcode As TextBox
    Friend WithEvents btnsubmit As Button
End Class
