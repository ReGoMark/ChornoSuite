<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.nudMinutes = New System.Windows.Forms.NumericUpDown()
        Me.nudSeconds = New System.Windows.Forms.NumericUpDown()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.nudHours = New System.Windows.Forms.NumericUpDown()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudMinutes
        '
        Me.nudMinutes.Location = New System.Drawing.Point(138, 30)
        Me.nudMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMinutes.Name = "nudMinutes"
        Me.nudMinutes.Size = New System.Drawing.Size(120, 25)
        Me.nudMinutes.TabIndex = 1
        '
        'nudSeconds
        '
        Me.nudSeconds.Location = New System.Drawing.Point(264, 30)
        Me.nudSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSeconds.Name = "nudSeconds"
        Me.nudSeconds.Size = New System.Drawing.Size(120, 25)
        Me.nudSeconds.TabIndex = 2
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 61)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Location = New System.Drawing.Point(174, 61)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(9, 12)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(71, 15)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "00:00:00"
        '
        'nudHours
        '
        Me.nudHours.Location = New System.Drawing.Point(12, 30)
        Me.nudHours.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudHours.Name = "nudHours"
        Me.nudHours.Size = New System.Drawing.Size(120, 25)
        Me.nudHours.TabIndex = 8
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(228, 61)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        Me.btnStop.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(86, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(298, 15)
        Me.ProgressBar1.TabIndex = 10
        '
        'btnPause
        '
        Me.btnPause.Enabled = False
        Me.btnPause.Location = New System.Drawing.Point(93, 61)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 11
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Location = New System.Drawing.Point(309, 61)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(75, 23)
        Me.btnZero.TabIndex = 12
        Me.btnZero.Text = "Cls"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 96)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.nudHours)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.nudSeconds)
        Me.Controls.Add(Me.nudMinutes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ready..."
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudMinutes As NumericUpDown
    Friend WithEvents nudSeconds As NumericUpDown
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents nudHours As NumericUpDown
    Friend WithEvents btnStop As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnPause As Button
    Friend WithEvents btnZero As Button
End Class
