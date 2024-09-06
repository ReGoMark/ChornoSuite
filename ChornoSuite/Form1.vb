
Public Class Form1
    Private countdownTime As Integer ' 存储倒计时总秒数
    Private remainingTime As Integer ' 存储剩余时间
    Private isPaused As Boolean = False ' 判断是否处于暂停状态

    '码表的秒数等
    Dim sec As Integer
    Dim min As Integer
    Dim hnr As Integer

    '补全定时页面的0
    Dim clph As String
    Dim clpm As String
    Dim clps As String

    Dim i As String '存储开启的闹钟个数

    '存储三个闹钟状态
    Dim chk1 As String
    Dim chk2 As String
    Dim chk3 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '初始化程序
        sec = 0
        min = 0
        hnr = 0
        Timer1.Enabled = False
        TextBox1.Text = ""
        ComboBox1.SelectedIndex = 0
        'Me.Width = 365

        '遮挡
        Panel1.Location = New Point(0, 161)
        Panel1.BackColor = Color.WhiteSmoke

        '输出，仅显示
        Label3.Text = Application.StartupPath

    End Sub

    Private Sub st1_Click(sender As Object, e As EventArgs) Handles st1.Click
        Timer1.Enabled = True
        st1.Visible = False
        pa1.Visible = True
        cls1.Enabled = True

        Form2.st4.Visible = False
        Form2.pa4.Visible = True
        Form2.cls4.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec += 1
        If sec >= 60 Then
            sec = 0
            min += 1
        End If
        If min >= 60 Then
            min = 0
            hnr += 1
        End If
    End Sub

    Private Sub pa1_Click(sender As Object, e As EventArgs) Handles pa1.Click
        Timer1.Enabled = False
        pa1.Visible = False
        ct1.Visible = True

        Form2.pa4.Visible = False
        Form2.ct4.Visible = True
    End Sub

    Private Sub ct1_Click(sender As Object, e As EventArgs) Handles ct1.Click
        Timer1.Enabled = True
        ct1.Visible = False
        pa1.Visible = True

        Form2.pa4.Visible = True
        Form2.ct4.Visible = False
    End Sub

    Private Sub cls1_Click(sender As Object, e As EventArgs) Handles cls1.Click
        sec = 0
        min = 0
        hnr = 0
        Timer1.Enabled = False
        st1.Visible = True
        ct1.Visible = False
        cls1.Enabled = False

        Form2.st4.Visible = True

        Form2.ct4.Visible = False
        Form2.cls4.Enabled = False
    End Sub

    Private Sub judg_Tick(sender As Object, e As EventArgs) Handles judg.Tick
        s1.Text = CStr(sec)
        stop1.Text = h0.Text & ":" & m0.Text & ":" & s0.Text
        Form2.stop4.Text = stop1.Text

        systime0.Text = Now.Hour & ":" & Now.Minute
        systime1.Text = "系统时间:" & systime0.Text

        autoprt.Interval = CInt(prtitvl.Value * 100)

        If title.Checked = True Then
            Me.Text = stop1.Text
        Else
            Me.Text = "ChronoSuite"
        End If

        If Form2.title4.Checked = True Then
            Form2.Text = stop1.Text
        Else
            Form2.Text = "ChnSuit"
        End If

        If nudHours.Value < 10 Then
            clph = "0"
        Else
            clph = ""
        End If
        If nudMinutes.Value < 10 Then
            clpm = "0"
        Else
            clpm = ""
        End If
        If nudSeconds.Value < 10 Then
            clps = "0"
        Else
            clps = ""
        End If

        tick0.Text = clph & nudHours.Value & ":" & clpm & nudMinutes.Value & ":" & clps & nudSeconds.Value

        If lbl0.Checked = True Then
            Form3.TextBox1.Text = text0.Text
            text0.Enabled = True
            Form3.Size = New Size(417, 217)
            Form3.TextBox1.Visible = True
        Else
            Form3.Size = New Size(417, 105)
            Form3.TextBox1.Visible = False
            text0.Enabled = False
        End If
        Form3.Label1.Text = tick0.Text
        Form3.Text = "ChnSuit-定时：" & "" & tick0.Text & "，" & text0.Text

        i = CStr(armc1.CheckState) + CStr(armc2.CheckState) + CStr(armc3.CheckState)

        TextBox2.Text = i
        If TextBox2.Text = "000" Then
            armstate.ImageIndex = 0
        Else
            If TextBox2.Text = "100" Or TextBox2.Text = "010" Or TextBox2.Text = "001" Then
                armstate.ImageIndex = 1
            Else
                If TextBox2.Text = "110" Or TextBox2.Text = "101" Or TextBox2.Text = "011" Then
                    armstate.ImageIndex = 2
                Else
                    If TextBox2.Text = "111" Then
                        armstate.ImageIndex = 3
                    End If
                End If
            End If
        End If

        armc1.Text = "√ " & armt1.Text
        armc2.Text = "√ " & armt2.Text
        armc3.Text = "√ " & armt3.Text
    End Sub

    Private Sub s1_TextChanged(sender As Object, e As EventArgs) Handles s1.TextChanged
        If sec < 10 Then
            s0.Text = "0" & sec
        Else
            s0.Text = CStr(sec)
        End If
        If min < 10 Then
            m0.Text = "0" & min
        Else
            m0.Text = CStr(min)
        End If
        If hnr < 10 Then
            h0.Text = "0" & hnr
        Else
            h0.Text = CStr(hnr)
        End If
    End Sub

    Private Sub prt_Click(sender As Object, e As EventArgs) Handles prt.Click
        TextBox1.Text = stop1.Text & vbCrLf & TextBox1.Text
    End Sub

    Private Sub cln_Click(sender As Object, e As EventArgs) Handles cln.Click
        TextBox1.Text = ""
    End Sub

    Private Sub topdsp_CheckStateChanged(sender As Object, e As EventArgs) Handles topdsp.CheckStateChanged
        If topdsp.Checked = True Then
            Me.TopMost = True
            NotifyIcon1.ShowBalloonTip(0, "置顶", "程序置顶显示，再次点击按钮取消。", ToolTipIcon.None)
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub notify_Click(sender As Object, e As EventArgs) Handles notify.Click
        Me.Visible = False
        NotifyIcon1.ShowBalloonTip(0, "挂起", "程序已置托盘挂起，右键图标唤醒。", ToolTipIcon.None)
    End Sub

    Private Sub mini_Click(sender As Object, e As EventArgs) Handles mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub jane_CheckStateChanged(sender As Object, e As EventArgs) Handles jane.CheckStateChanged
        If jane.Checked = True Then
            Form2.Show()
            Me.Hide()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub trans_TextChanged(sender As Object, e As EventArgs) Handles trans.TextChanged
        If trans.Text = "0" Then
            sec = 0
            min = 0
            hnr = 0
            Timer1.Enabled = False
            trans.Text = "1"
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub autoprt_Tick(sender As Object, e As EventArgs) Handles autoprt.Tick
        TextBox1.Text = stop1.Text & vbCrLf & TextBox1.Text
    End Sub

    Private Sub chkautoprt_CheckStateChanged(sender As Object, e As EventArgs) Handles chkautoprt.CheckStateChanged
        If chkautoprt.Checked = True Then
            autoprt.Enabled = True
        Else
            autoprt.Enabled = False
        End If
    End Sub

    ' 启动倒计时按钮点击事件
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Not isPaused Then
            countdownTime = CInt(nudHours.Value) * 3600 + CInt(nudMinutes.Value) * 60 + CInt(nudSeconds.Value)
            remainingTime = countdownTime
            ProgressBar1.Maximum = countdownTime
        End If
        lblTime.Text = tick0.Text
        If remainingTime > 0 Then
            Timer2.Start()
            ProgressBar1.Value = remainingTime
            btnStart.Visible = False
            btnResume.Visible = False
            btnPause.Visible = True
            btnPause.Enabled = True
            'btnStop.Enabled = True
            btnReset.Enabled = True
            isPaused = False
            'tick0.Visible = False

            nudHours.Enabled = False
            nudMinutes.Enabled = False
            nudSeconds.Enabled = False
            ComboBox1.Enabled = False
            'TextBox2.Enabled = False
        End If

        'tick0.Visible = False
        lblTime.Visible = True
    End Sub

    ' 暂停倒计时按钮点击事件
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        Timer2.Stop()
        btnResume.Visible = True
        btnPause.Visible = False
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
        lblPercent.Text = "100"
        btnStart.Visible = True
        'btnPause.Enabled = False
        'btnStop.Enabled = False
        'btnReset.Enabled = False
        isPaused = False
        'tick0.Visible = True

        nudHours.Enabled = True
        nudMinutes.Enabled = True
        nudSeconds.Enabled = True
        ComboBox1.Enabled = True
        text0.Enabled = True
    End Sub

    ' 归零按钮点击事件
    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        Timer2.Stop()
        remainingTime = 0
        countdownTime = 0
        nudHours.Value = 0
        nudMinutes.Value = 0
        nudSeconds.Value = 0

        UpdateTimeDisplay()
        ProgressBar1.Value = 0
        lblPercent.Text = "100"
        btnStart.Visible = True
        'tick0.Visible = True
        'lblTime.Visible = False
        'btnPause.Enabled = False
        'btnStop.Enabled = False
        'btnReset.Enabled = False
        'btnZero.Enabled = False
        isPaused = False

        nudHours.Enabled = True
        nudMinutes.Enabled = True
        nudSeconds.Enabled = True
        ComboBox1.Enabled = True
        text0.Enabled = True

    End Sub

    ' Timer 控件的 Tick 事件，用于每秒更新倒计时
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If remainingTime > 0 Then
            remainingTime -= 1
            UpdateTimeDisplay()
            ProgressBar1.Value = remainingTime
            lblPercent.Text = CStr(Int(remainingTime / countdownTime * 100))
            lblPro1.Width = CInt(lblPro0.Width * remainingTime / countdownTime)
        Else
            Timer2.Stop()

            Form3.Show()

            btnStart.Enabled = True
            btnStart.Visible = True
            'tick0.Visible = True
            btnPause.Enabled = False
            btnStop.Enabled = False
            'btnReset.Enabled = False
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

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        If remainingTime > 0 Then
            Timer2.Start()
            ProgressBar1.Value = remainingTime
            btnPause.Visible = True
            btnResume.Visible = False
            isPaused = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            nudHours.Value = 0
            nudMinutes.Value = 0
            nudSeconds.Value = 0
        End If
        If ComboBox1.SelectedIndex = 1 Then
            nudHours.Value = 0
            nudMinutes.Value = 0
            nudSeconds.Value = 5
        End If
        If ComboBox1.SelectedIndex = 2 Then
            nudHours.Value = 0
            nudMinutes.Value = 0
            nudSeconds.Value = 30
        End If
        If ComboBox1.SelectedIndex = 3 Then
            nudHours.Value = 0
            nudMinutes.Value = 1
            nudSeconds.Value = 0
        End If
        If ComboBox1.SelectedIndex = 4 Then
            nudHours.Value = 0
            nudMinutes.Value = 5
            nudSeconds.Value = 0
        End If
        If ComboBox1.SelectedIndex = 5 Then
            nudHours.Value = 0
            nudMinutes.Value = 10
            nudSeconds.Value = 0
        End If
        If ComboBox1.SelectedIndex = 6 Then
            nudHours.Value = 0
            nudMinutes.Value = 30
            nudSeconds.Value = 0
        End If
        If ComboBox1.SelectedIndex = 7 Then
            nudHours.Value = 99
            nudMinutes.Value = 59
            nudSeconds.Value = 59
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl2.SelectedIndex = 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl2.SelectedIndex = 2
    End Sub

    Private Sub armc1_CheckStateChanged(sender As Object, e As EventArgs) Handles armc1.CheckStateChanged
        If armc1.Checked = True Then
            arml1.Enabled = True
            Button3.ForeColor = Color.Black
        Else
            arml1.Enabled = False
            Button3.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub armc2_CheckStateChanged(sender As Object, e As EventArgs) Handles armc2.CheckStateChanged
        If armc2.Checked = True Then
            arml2.Enabled = True
            Button4.ForeColor = Color.Black
        Else
            arml2.Enabled = False
            Button4.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub armc3_CheckStateChanged(sender As Object, e As EventArgs) Handles armc3.CheckStateChanged
        If armc3.Checked = True Then
            arml3.Enabled = True
            Button5.ForeColor = Color.Black
        Else
            arml3.Enabled = False
            Button5.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub armc1_MouseHover(sender As Object, e As EventArgs) Handles armc1.MouseHover
        If armc1.Checked = True Then
            chk1 = "[1,启用]"
        Else
            chk1 = "[1,禁用]"
        End If
        ToolTip2.ToolTipTitle = chk1
        ToolTip2.SetToolTip(Me.armc1, armt1.Text)
    End Sub

    Private Sub armc2_MouseHover(sender As Object, e As EventArgs) Handles armc2.MouseHover
        If armc2.Checked = True Then
            chk2 = "[2,启用]"
        Else
            chk2 = "[2,禁用]"
        End If
        ToolTip3.ToolTipTitle = chk2
        ToolTip3.SetToolTip(Me.armc2, armt2.Text)
    End Sub

    Private Sub armc3_MouseHover(sender As Object, e As EventArgs) Handles armc3.MouseHover
        If armc3.Checked = True Then
            chk3 = "[3,启用]"
        Else
            chk3 = "[3,禁用]"
        End If
        ToolTip4.ToolTipTitle = chk3
        ToolTip4.SetToolTip(Me.armc3, armt3.Text)
    End Sub
End Class
