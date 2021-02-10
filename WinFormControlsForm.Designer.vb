<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinFormControlsForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(581, 278)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(115, 67)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(441, 278)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(134, 67)
        Me.SubmitButton.TabIndex = 4
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(130, 43)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(211, 26)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(130, 107)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(211, 26)
        Me.AgeTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(130, 75)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(211, 26)
        Me.LastNameTextBox.TabIndex = 1
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(130, 139)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(211, 26)
        Me.NumberTextBox.TabIndex = 3
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(12, 43)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(86, 20)
        Me.FirstNameLabel.TabIndex = 6
        Me.FirstNameLabel.Text = "First Name"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(12, 75)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(86, 20)
        Me.LastNameLabel.TabIndex = 7
        Me.LastNameLabel.Text = "Last Name"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(12, 107)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 8
        Me.AgeLabel.Text = "Age"
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(12, 139)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(110, 20)
        Me.NumberLabel.TabIndex = 9
        Me.NumberLabel.Text = "Lucky Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(377, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 250)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(6, 25)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(193, 26)
        Me.TextBox5.TabIndex = 0
        Me.TextBox5.TabStop = False
        '
        'WinFormControlsForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(708, 366)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NumberLabel)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "WinFormControlsForm"
        Me.Text = "Form Controls"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents NumberLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
End Class
