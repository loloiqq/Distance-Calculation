<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DistanceForm
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
        Me.DistanceCalculationLabel = New System.Windows.Forms.Label()
        Me.DepartureLabel = New System.Windows.Forms.Label()
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.DepartureComboBox = New System.Windows.Forms.ComboBox()
        Me.DestinationComboBox = New System.Windows.Forms.ComboBox()
        Me.DistanceTextBox = New System.Windows.Forms.TextBox()
        Me.LookUpButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DistanceCalculationLabel
        '
        Me.DistanceCalculationLabel.AutoSize = True
        Me.DistanceCalculationLabel.Location = New System.Drawing.Point(62, 175)
        Me.DistanceCalculationLabel.Name = "DistanceCalculationLabel"
        Me.DistanceCalculationLabel.Size = New System.Drawing.Size(90, 13)
        Me.DistanceCalculationLabel.TabIndex = 0
        Me.DistanceCalculationLabel.Text = "Distance in Miles:"
        '
        'DepartureLabel
        '
        Me.DepartureLabel.AutoSize = True
        Me.DepartureLabel.Location = New System.Drawing.Point(31, 58)
        Me.DepartureLabel.Name = "DepartureLabel"
        Me.DepartureLabel.Size = New System.Drawing.Size(57, 13)
        Me.DepartureLabel.TabIndex = 1
        Me.DepartureLabel.Text = "Departure:"
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.Location = New System.Drawing.Point(220, 58)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(63, 13)
        Me.DestinationLabel.TabIndex = 2
        Me.DestinationLabel.Text = "Destination:"
        '
        'DepartureComboBox
        '
        Me.DepartureComboBox.FormattingEnabled = True
        Me.DepartureComboBox.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"})
        Me.DepartureComboBox.Location = New System.Drawing.Point(34, 85)
        Me.DepartureComboBox.Name = "DepartureComboBox"
        Me.DepartureComboBox.Size = New System.Drawing.Size(132, 21)
        Me.DepartureComboBox.TabIndex = 3
        '
        'DestinationComboBox
        '
        Me.DestinationComboBox.FormattingEnabled = True
        Me.DestinationComboBox.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"})
        Me.DestinationComboBox.Location = New System.Drawing.Point(223, 85)
        Me.DestinationComboBox.Name = "DestinationComboBox"
        Me.DestinationComboBox.Size = New System.Drawing.Size(138, 21)
        Me.DestinationComboBox.TabIndex = 4
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.Location = New System.Drawing.Point(158, 172)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.ReadOnly = True
        Me.DistanceTextBox.Size = New System.Drawing.Size(134, 20)
        Me.DistanceTextBox.TabIndex = 5
        '
        'LookUpButton
        '
        Me.LookUpButton.Location = New System.Drawing.Point(34, 254)
        Me.LookUpButton.Name = "LookUpButton"
        Me.LookUpButton.Size = New System.Drawing.Size(91, 29)
        Me.LookUpButton.TabIndex = 6
        Me.LookUpButton.Text = "LookUp"
        Me.LookUpButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(154, 254)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(91, 29)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(279, 254)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(91, 29)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DistanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 336)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.LookUpButton)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(Me.DestinationComboBox)
        Me.Controls.Add(Me.DepartureComboBox)
        Me.Controls.Add(Me.DestinationLabel)
        Me.Controls.Add(Me.DepartureLabel)
        Me.Controls.Add(Me.DistanceCalculationLabel)
        Me.Name = "DistanceForm"
        Me.Text = "Distance Calculation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DistanceCalculationLabel As Label
    Friend WithEvents DepartureLabel As Label
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents DepartureComboBox As ComboBox
    Friend WithEvents DestinationComboBox As ComboBox
    Friend WithEvents DistanceTextBox As TextBox
    Friend WithEvents LookUpButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
End Class
