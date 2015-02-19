<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.TaskWorker = New System.ComponentModel.BackgroundWorker()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartBtn
        '
        Me.StartBtn.Location = New System.Drawing.Point(197, 54)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartBtn.TabIndex = 3
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 25)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(260, 23)
        Me.ProgressBar.TabIndex = 1
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(12, 9)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 13)
        Me.StatusLabel.TabIndex = 0
        '
        'TaskWorker
        '
        Me.TaskWorker.WorkerReportsProgress = True
        Me.TaskWorker.WorkerSupportsCancellation = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Enabled = False
        Me.CancelBtn.Location = New System.Drawing.Point(116, 54)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 89)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.StartBtn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartBtn As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents TaskWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents CancelBtn As System.Windows.Forms.Button

End Class
