<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.unitsShowTextBox = New System.Windows.Forms.TextBox()
        Me.days = New System.Windows.Forms.Label()
        Me.averageE1Textbox = New System.Windows.Forms.TextBox()
        Me.totalAverageTextBox = New System.Windows.Forms.TextBox()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.unitsShowTextBox2 = New System.Windows.Forms.TextBox()
        Me.averageE2Textbox = New System.Windows.Forms.TextBox()
        Me.unitsShowTextBox3 = New System.Windows.Forms.TextBox()
        Me.averageE3Textbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.errorToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Day"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Units:"
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(66, 46)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(100, 22)
        Me.inputTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Employee 1"
        '
        'unitsShowTextBox
        '
        Me.unitsShowTextBox.Location = New System.Drawing.Point(19, 135)
        Me.unitsShowTextBox.Multiline = True
        Me.unitsShowTextBox.Name = "unitsShowTextBox"
        Me.unitsShowTextBox.ReadOnly = True
        Me.unitsShowTextBox.Size = New System.Drawing.Size(125, 184)
        Me.unitsShowTextBox.TabIndex = 4
        '
        'days
        '
        Me.days.AutoSize = True
        Me.days.Location = New System.Drawing.Point(44, 13)
        Me.days.Name = "days"
        Me.days.Size = New System.Drawing.Size(16, 17)
        Me.days.TabIndex = 5
        Me.days.Text = "1"
        '
        'averageE1Textbox
        '
        Me.averageE1Textbox.Location = New System.Drawing.Point(19, 325)
        Me.averageE1Textbox.Name = "averageE1Textbox"
        Me.averageE1Textbox.ReadOnly = True
        Me.averageE1Textbox.Size = New System.Drawing.Size(125, 22)
        Me.averageE1Textbox.TabIndex = 6
        '
        'totalAverageTextBox
        '
        Me.totalAverageTextBox.Location = New System.Drawing.Point(19, 354)
        Me.totalAverageTextBox.Name = "totalAverageTextBox"
        Me.totalAverageTextBox.ReadOnly = True
        Me.totalAverageTextBox.Size = New System.Drawing.Size(448, 22)
        Me.totalAverageTextBox.TabIndex = 7
        Me.totalAverageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(19, 382)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(125, 33)
        Me.enterButton.TabIndex = 8
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'unitsShowTextBox2
        '
        Me.unitsShowTextBox2.Location = New System.Drawing.Point(176, 135)
        Me.unitsShowTextBox2.Multiline = True
        Me.unitsShowTextBox2.Name = "unitsShowTextBox2"
        Me.unitsShowTextBox2.ReadOnly = True
        Me.unitsShowTextBox2.Size = New System.Drawing.Size(131, 184)
        Me.unitsShowTextBox2.TabIndex = 9
        '
        'averageE2Textbox
        '
        Me.averageE2Textbox.Location = New System.Drawing.Point(176, 326)
        Me.averageE2Textbox.Name = "averageE2Textbox"
        Me.averageE2Textbox.ReadOnly = True
        Me.averageE2Textbox.Size = New System.Drawing.Size(131, 22)
        Me.averageE2Textbox.TabIndex = 10
        '
        'unitsShowTextBox3
        '
        Me.unitsShowTextBox3.Location = New System.Drawing.Point(338, 135)
        Me.unitsShowTextBox3.Multiline = True
        Me.unitsShowTextBox3.Name = "unitsShowTextBox3"
        Me.unitsShowTextBox3.ReadOnly = True
        Me.unitsShowTextBox3.Size = New System.Drawing.Size(129, 184)
        Me.unitsShowTextBox3.TabIndex = 11
        '
        'averageE3Textbox
        '
        Me.averageE3Textbox.Location = New System.Drawing.Point(338, 325)
        Me.averageE3Textbox.Name = "averageE3Textbox"
        Me.averageE3Textbox.ReadOnly = True
        Me.averageE3Textbox.Size = New System.Drawing.Size(129, 22)
        Me.averageE3Textbox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Employee 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Employee 3"
        '
        'errorToolTip
        '
        Me.errorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(182, 382)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(125, 32)
        Me.resetButton.TabIndex = 15
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(338, 382)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(129, 31)
        Me.exitButton.TabIndex = 16
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.enterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 427)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.averageE3Textbox)
        Me.Controls.Add(Me.unitsShowTextBox3)
        Me.Controls.Add(Me.averageE2Textbox)
        Me.Controls.Add(Me.unitsShowTextBox2)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.totalAverageTextBox)
        Me.Controls.Add(Me.averageE1Textbox)
        Me.Controls.Add(Me.days)
        Me.Controls.Add(Me.unitsShowTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Average Units Shipped By Employee "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inputTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents unitsShowTextBox As TextBox
    Friend WithEvents days As Label
    Friend WithEvents averageE1Textbox As TextBox
    Friend WithEvents totalAverageTextBox As TextBox
    Friend WithEvents enterButton As Button
    Friend WithEvents unitsShowTextBox2 As TextBox
    Friend WithEvents averageE2Textbox As TextBox
    Friend WithEvents unitsShowTextBox3 As TextBox
    Friend WithEvents averageE3Textbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents errorToolTip As ToolTip
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
End Class
