<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectDest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRestroom = New System.Windows.Forms.Button()
        Me.btnShop = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnShowResult = New System.Windows.Forms.Button()
        Me.btnCancelSelect = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnGate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(100, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(639, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select where you would like to go."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(100, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1332, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "If more than one destionation is selected, a route will be shown in the order of " &
    "selection."
        '
        'btnRestroom
        '
        Me.btnRestroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnRestroom.Location = New System.Drawing.Point(107, 341)
        Me.btnRestroom.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestroom.Name = "btnRestroom"
        Me.btnRestroom.Size = New System.Drawing.Size(602, 133)
        Me.btnRestroom.TabIndex = 2
        Me.btnRestroom.Text = "Restroom"
        Me.btnRestroom.UseVisualStyleBackColor = True
        '
        'btnShop
        '
        Me.btnShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnShop.Location = New System.Drawing.Point(107, 482)
        Me.btnShop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShop.Name = "btnShop"
        Me.btnShop.Size = New System.Drawing.Size(603, 133)
        Me.btnShop.TabIndex = 3
        Me.btnShop.Text = "Shop"
        Me.btnShop.UseVisualStyleBackColor = True
        '
        'btnFood
        '
        Me.btnFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnFood.Location = New System.Drawing.Point(107, 623)
        Me.btnFood.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(603, 132)
        Me.btnFood.TabIndex = 4
        Me.btnFood.Text = "Food"
        Me.btnFood.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.btnInfo.Location = New System.Drawing.Point(108, 763)
        Me.btnInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(603, 129)
        Me.btnInfo.TabIndex = 5
        Me.btnInfo.Text = "Information Desk"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnShowResult
        '
        Me.btnShowResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.btnShowResult.Location = New System.Drawing.Point(1101, 287)
        Me.btnShowResult.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowResult.Name = "btnShowResult"
        Me.btnShowResult.Size = New System.Drawing.Size(663, 190)
        Me.btnShowResult.TabIndex = 6
        Me.btnShowResult.Text = "Show route"
        Me.btnShowResult.UseVisualStyleBackColor = True
        '
        'btnCancelSelect
        '
        Me.btnCancelSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.btnCancelSelect.Location = New System.Drawing.Point(1101, 570)
        Me.btnCancelSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelSelect.Name = "btnCancelSelect"
        Me.btnCancelSelect.Size = New System.Drawing.Size(663, 190)
        Me.btnCancelSelect.TabIndex = 7
        Me.btnCancelSelect.Text = "Cancel selection"
        Me.btnCancelSelect.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'BtnGate
        '
        Me.BtnGate.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGate.Location = New System.Drawing.Point(107, 201)
        Me.BtnGate.Name = "BtnGate"
        Me.BtnGate.Size = New System.Drawing.Size(602, 133)
        Me.BtnGate.TabIndex = 10
        Me.BtnGate.Text = "Gate"
        Me.BtnGate.UseVisualStyleBackColor = True
        '
        'SelectDest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 994)
        Me.Controls.Add(Me.BtnGate)
        Me.Controls.Add(Me.btnCancelSelect)
        Me.Controls.Add(Me.btnShowResult)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnFood)
        Me.Controls.Add(Me.btnShop)
        Me.Controls.Add(Me.btnRestroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SelectDest"
        Me.Text = "SelectDest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRestroom As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnShowResult As Button
    Friend WithEvents btnCancelSelect As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnGate As Button
End Class
