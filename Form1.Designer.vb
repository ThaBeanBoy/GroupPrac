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
        Me.txtDisplay = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Disease Control Center"
        '
        'btnSetUpTheApplication
        '
        Me.btnSetUpTheApplication.Location = New System.Drawing.Point(8, 45)
        Me.btnSetUpTheApplication.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSetUpTheApplication.Name = "btnSetUpTheApplication"
        Me.btnSetUpTheApplication.Size = New System.Drawing.Size(128, 38)
        Me.btnSetUpTheApplication.TabIndex = 1
        Me.btnSetUpTheApplication.Text = "Set Up"
        Me.btnSetUpTheApplication.UseVisualStyleBackColor = True
        '
        'btnCaptureTheData
        '
        Me.btnCaptureTheData.Location = New System.Drawing.Point(8, 91)
        Me.btnCaptureTheData.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCaptureTheData.Name = "btnCaptureTheData"
        Me.btnCaptureTheData.Size = New System.Drawing.Size(128, 38)
        Me.btnCaptureTheData.TabIndex = 2
        Me.btnCaptureTheData.Text = "Capture Data"
        Me.btnCaptureTheData.UseVisualStyleBackColor = True
        '
        'btnFindASolution
        '
        Me.btnFindASolution.Location = New System.Drawing.Point(8, 137)
        Me.btnFindASolution.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFindASolution.Name = "btnFindASolution"
        Me.btnFindASolution.Size = New System.Drawing.Size(128, 38)
        Me.btnFindASolution.TabIndex = 3
        Me.btnFindASolution.Text = "Solution"
        Me.btnFindASolution.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(143, 45)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(645, 325)
        Me.txtDisplay.TabIndex = 5
        Me.txtDisplay.Text = ""
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
    Friend WithEvents txtDisplay As RichTextBox
End Class
