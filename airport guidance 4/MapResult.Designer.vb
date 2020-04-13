<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapResult
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSelectDest = New System.Windows.Forms.Button()
        Me.MapWRoute = New System.Windows.Forms.PictureBox()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.lblTimeToDest = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.MapWRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectDest
        '
        Me.btnSelectDest.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSelectDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.btnSelectDest.Location = New System.Drawing.Point(669, 793)
        Me.btnSelectDest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectDest.Name = "btnSelectDest"
        Me.btnSelectDest.Size = New System.Drawing.Size(619, 209)
        Me.btnSelectDest.TabIndex = 1
        Me.btnSelectDest.Text = "HOW DO I GET THERE"
        Me.btnSelectDest.UseVisualStyleBackColor = True
        '
        'MapWRoute
        '
        Me.MapWRoute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MapWRoute.Location = New System.Drawing.Point(16, 15)
        Me.MapWRoute.Margin = New System.Windows.Forms.Padding(4)
        Me.MapWRoute.Name = "MapWRoute"
        Me.MapWRoute.Size = New System.Drawing.Size(1925, 700)
        Me.MapWRoute.TabIndex = 2
        Me.MapWRoute.TabStop = False
        '
        'btnPassword
        '
        Me.btnPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPassword.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPassword.Location = New System.Drawing.Point(16, 978)
        Me.btnPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(25, 23)
        Me.btnPassword.TabIndex = 3
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'lblTimeToDest
        '
        Me.lblTimeToDest.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTimeToDest.AutoSize = True
        Me.lblTimeToDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblTimeToDest.Location = New System.Drawing.Point(492, 740)
        Me.lblTimeToDest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeToDest.Name = "lblTimeToDest"
        Me.lblTimeToDest.Size = New System.Drawing.Size(483, 36)
        Me.lblTimeToDest.TabIndex = 4
        Me.lblTimeToDest.Text = "Estimated time to reach destination:"
        '
        'Timer1
        '
        '
        'MapResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1017)
        Me.Controls.Add(Me.lblTimeToDest)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.MapWRoute)
        Me.Controls.Add(Me.btnSelectDest)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MapResult"
        Me.Text = "MapResult"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MapWRoute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelectDest As Button
    Friend WithEvents MapWRoute As PictureBox
    Friend WithEvents btnPassword As Button
    Friend WithEvents lblTimeToDest As Label
    Friend WithEvents Timer1 As Timer
End Class
