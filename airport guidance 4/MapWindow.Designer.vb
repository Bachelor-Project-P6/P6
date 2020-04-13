<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapWindow
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
        Me.btnSelectDest = New System.Windows.Forms.Button()
        Me.MapPic = New System.Windows.Forms.PictureBox()
        Me.btnPassword = New System.Windows.Forms.Button()
        CType(Me.MapPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectDest
        '
        Me.btnSelectDest.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSelectDest.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.btnSelectDest.Location = New System.Drawing.Point(507, 664)
        Me.btnSelectDest.Name = "btnSelectDest"
        Me.btnSelectDest.Size = New System.Drawing.Size(464, 170)
        Me.btnSelectDest.TabIndex = 0
        Me.btnSelectDest.Text = "HOW DO I GET THERE"
        Me.btnSelectDest.UseVisualStyleBackColor = True
        '
        'MapPic
        '
        Me.MapPic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MapPic.Location = New System.Drawing.Point(12, 12)
        Me.MapPic.Name = "MapPic"
        Me.MapPic.Size = New System.Drawing.Size(1452, 473)
        Me.MapPic.TabIndex = 1
        Me.MapPic.TabStop = False
        '
        'btnPassword
        '
        Me.btnPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPassword.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPassword.Location = New System.Drawing.Point(12, 815)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(19, 19)
        Me.btnPassword.TabIndex = 2
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'MapWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 846)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.MapPic)
        Me.Controls.Add(Me.btnSelectDest)
        Me.Name = "MapWindow"
        Me.Text = "MainWindow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MapPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelectDest As Button
    Friend WithEvents MapPic As PictureBox
    Friend WithEvents btnPassword As Button
End Class
