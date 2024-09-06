Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private countdownTime As Integer ' 用于存储倒计时总秒数
    Private remainingTime As Integer ' 用于存储剩余时间
    Private isPaused As Boolean = False ' 用于判断是否处于暂停状态

    ' 启动倒计时按钮点击事件
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Not isPaused Then
            countdownTime = CInt(nudHours.Value) * 3600 + CInt(nudMinutes.Value) * 60 + CInt(nudSeconds.Value)
            remainingTime = countdownTime
            ProgressBar1.Maximum = countdownTime
        End If

        If remainingTime > 0 Then
            Timer2.Start()
            ProgressBar1.Value = remainingTime
            btnStart.Enabled = False
            btnPause.Enabled = True
            btnStop.Enabled = True
            btnReset.Enabled = True
            isPaused = False
        End If
    End Sub

    ' 暂停倒计时按钮点击事件
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        Timer2.Stop()
        btnStart.Enabled = True
        btnPause.Enabled = False
        isPaused = True
    End Sub

    ' 停止倒计时按钮点击事件
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer2.Stop()
        btnStart.Enabled = True
        btnPause.Enabled = False
        btnStop.Enabled = False
        isPaused = False
    End Sub

    ' 重置倒计时按钮点击事件
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Timer2.Stop()
        remainingTime = countdownTime
        UpdateTimeDisplay()
        ProgressBar1.Value = remainingTime
        btnStart.Enabled = True
        btnPause.Enabled = False
        btnStop.Enabled = False
        btnReset.Enabled = False
        isPaused = False
    End Sub

    ' 归零按钮点击事件
    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        Timer2.Stop()
        remainingTime = 0
        UpdateTimeDisplay()
        ProgressBar1.Value = 0
        btnStart.Enabled = True
        btnPause.Enabled = False
        btnStop.Enabled = False
        btnReset.Enabled = False
        'btnZero.Enabled = False
        isPaused = False
    End Sub

    ' Timer 控件的 Tick 事件，用于每秒更新倒计时
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If remainingTime > 0 Then
            remainingTime -= 1
            UpdateTimeDisplay()
            ProgressBar1.Value = remainingTime
        Else
            Timer2.Stop()
            'MessageBox.Show("时间到！", "倒计时")
            Form2.Show()
            btnStart.Enabled = True
            btnPause.Enabled = False
            btnStop.Enabled = False
            btnReset.Enabled = False
            'btnZero.Enabled = False
        End If
    End Sub

    ' 更新显示的时间
    Private Sub UpdateTimeDisplay()
        Dim hours As Integer = remainingTime \ 3600
        Dim minutes As Integer = (remainingTime Mod 3600) \ 60
        Dim seconds As Integer = remainingTime Mod 60
        lblTime.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds)
    End Sub
End Class
