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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSetUpTheApplication = New System.Windows.Forms.Button()
        Me.btnCaptureTheData = New System.Windows.Forms.Button()
        Me.btnFindASolution = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(737, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome Supa Nova Cool Kidz  Coding Club Member"
        '
        'btnSetUpTheApplication
        '
        Me.btnSetUpTheApplication.Location = New System.Drawing.Point(16, 44)
        Me.btnSetUpTheApplication.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSetUpTheApplication.Name = "btnSetUpTheApplication"
        Me.btnSetUpTheApplication.Size = New System.Drawing.Size(128, 38)
        Me.btnSetUpTheApplication.TabIndex = 1
        Me.btnSetUpTheApplication.Text = "SetUp"
        Me.btnSetUpTheApplication.UseVisualStyleBackColor = True
        '
        'btnCaptureTheData
        '
        Me.btnCaptureTheData.Location = New System.Drawing.Point(16, 101)
        Me.btnCaptureTheData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCaptureTheData.Name = "btnCaptureTheData"
        Me.btnCaptureTheData.Size = New System.Drawing.Size(128, 38)
        Me.btnCaptureTheData.TabIndex = 2
        Me.btnCaptureTheData.Text = "Capture Data"
        Me.btnCaptureTheData.UseVisualStyleBackColor = True
        '
        'btnFindASolution
        '
        Me.btnFindASolution.Location = New System.Drawing.Point(16, 164)
        Me.btnFindASolution.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFindASolution.Name = "btnFindASolution"
        Me.btnFindASolution.Size = New System.Drawing.Size(128, 38)
        Me.btnFindASolution.TabIndex = 3
        Me.btnFindASolution.Text = "Solution"
        Me.btnFindASolution.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(152, 44)
        Me.txtDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(631, 328)
        Me.txtDisplay.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 382)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnFindASolution)
        Me.Controls.Add(Me.btnCaptureTheData)
        Me.Controls.Add(Me.btnSetUpTheApplication)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSetUpTheApplication As Button
    Friend WithEvents btnCaptureTheData As Button
    Friend WithEvents btnFindASolution As Button
    Friend WithEvents txtDisplay As TextBox
End Class
