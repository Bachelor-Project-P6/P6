<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BadPassword
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
        Me.lblBadPassword = New System.Windows.Forms.Label()
        Me.btnCloseBadPass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBadPassword
        '
        Me.lblBadPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBadPassword.AutoSize = True
        Me.lblBadPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblBadPassword.Location = New System.Drawing.Point(97, 31)
        Me.lblBadPassword.Name = "lblBadPassword"
        Me.lblBadPassword.Size = New System.Drawing.Size(315, 46)
        Me.lblBadPassword.TabIndex = 0
        Me.lblBadPassword.Text = "Invalid password"
        '
        'btnCloseBadPass
        '
        Me.btnCloseBadPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.btnCloseBadPass.Location = New System.Drawing.Point(105, 102)
        Me.btnCloseBadPass.Name = "btnCloseBadPass"
        Me.btnCloseBadPass.Size = New System.Drawing.Size(307, 82)
        Me.btnCloseBadPass.TabIndex = 1
        Me.btnCloseBadPass.Text = "OK"
        Me.btnCloseBadPass.UseVisualStyleBackColor = True
        '
        'BadPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 225)
        Me.Controls.Add(Me.btnCloseBadPass)
        Me.Controls.Add(Me.lblBadPassword)
        Me.Name = "BadPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invalid password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBadPassword As Label
    Friend WithEvents btnCloseBadPass As Button
End Class
