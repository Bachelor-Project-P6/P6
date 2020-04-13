<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetLocationMap
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
        Me.MapWithNodes = New System.Windows.Forms.PictureBox()
        Me.lblInstructionSet = New System.Windows.Forms.Label()
        Me.btnCancelNode = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.MapWithNodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MapWithNodes
        '
        Me.MapWithNodes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MapWithNodes.Location = New System.Drawing.Point(16, 15)
        Me.MapWithNodes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MapWithNodes.Name = "MapWithNodes"
        Me.MapWithNodes.Size = New System.Drawing.Size(1833, 594)
        Me.MapWithNodes.TabIndex = 2
        Me.MapWithNodes.TabStop = False
        '
        'lblInstructionSet
        '
        Me.lblInstructionSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblInstructionSet.AutoSize = True
        Me.lblInstructionSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lblInstructionSet.Location = New System.Drawing.Point(396, 650)
        Me.lblInstructionSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstructionSet.Name = "lblInstructionSet"
        Me.lblInstructionSet.Size = New System.Drawing.Size(993, 48)
        Me.lblInstructionSet.TabIndex = 3
        Me.lblInstructionSet.Text = "Please select the location for this device on the map."
        '
        'btnCancelNode
        '
        Me.btnCancelNode.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelNode.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.btnCancelNode.Location = New System.Drawing.Point(624, 802)
        Me.btnCancelNode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelNode.Name = "btnCancelNode"
        Me.btnCancelNode.Size = New System.Drawing.Size(616, 159)
        Me.btnCancelNode.TabIndex = 4
        Me.btnCancelNode.Text = "CANCEL"
        Me.btnCancelNode.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'SetLocationMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1865, 1013)
        Me.Controls.Add(Me.btnCancelNode)
        Me.Controls.Add(Me.lblInstructionSet)
        Me.Controls.Add(Me.MapWithNodes)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SetLocationMap"
        Me.Text = "SetLocationMap"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MapWithNodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MapWithNodes As PictureBox
    Friend WithEvents lblInstructionSet As Label
    Friend WithEvents btnCancelNode As Button
    Friend WithEvents Timer1 As Timer
End Class
