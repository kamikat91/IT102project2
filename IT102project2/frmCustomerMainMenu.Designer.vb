<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerMainMenu
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
        Me.btnupdatecustomers = New System.Windows.Forms.Button()
        Me.btnaddcustomerflight = New System.Windows.Forms.Button()
        Me.btnshowcustomerflights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnupdatecustomers
        '
        Me.btnupdatecustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnupdatecustomers.Location = New System.Drawing.Point(122, 192)
        Me.btnupdatecustomers.Name = "btnupdatecustomers"
        Me.btnupdatecustomers.Size = New System.Drawing.Size(149, 71)
        Me.btnupdatecustomers.TabIndex = 54
        Me.btnupdatecustomers.Text = "Update Customers"
        Me.btnupdatecustomers.UseVisualStyleBackColor = True
        '
        'btnaddcustomerflight
        '
        Me.btnaddcustomerflight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnaddcustomerflight.Location = New System.Drawing.Point(332, 192)
        Me.btnaddcustomerflight.Name = "btnaddcustomerflight"
        Me.btnaddcustomerflight.Size = New System.Drawing.Size(149, 71)
        Me.btnaddcustomerflight.TabIndex = 55
        Me.btnaddcustomerflight.Text = "Add Customer Flight"
        Me.btnaddcustomerflight.UseVisualStyleBackColor = True
        '
        'btnshowcustomerflights
        '
        Me.btnshowcustomerflights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnshowcustomerflights.Location = New System.Drawing.Point(545, 192)
        Me.btnshowcustomerflights.Name = "btnshowcustomerflights"
        Me.btnshowcustomerflights.Size = New System.Drawing.Size(149, 71)
        Me.btnshowcustomerflights.TabIndex = 56
        Me.btnshowcustomerflights.Text = "Show Customer Flights"
        Me.btnshowcustomerflights.UseVisualStyleBackColor = True
        '
        'frmCustomerMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnshowcustomerflights)
        Me.Controls.Add(Me.btnaddcustomerflight)
        Me.Controls.Add(Me.btnupdatecustomers)
        Me.Name = "frmCustomerMainMenu"
        Me.Text = "frmCustomerMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnupdatecustomers As Button
    Friend WithEvents btnaddcustomerflight As Button
    Friend WithEvents btnshowcustomerflights As Button
End Class
