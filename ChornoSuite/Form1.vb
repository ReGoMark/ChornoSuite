
Imports System.ComponentModel
Imports System.Diagnostics
Imports System
Imports System.IO

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

    Dim alh1 As String
    Dim alm1 As String
    Dim alh2 As String
    Dim alm2 As String
    Dim alh3 As String
    Dim alm3 As String




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '初始化程序
        sec = 0
        min = 0
        hnr = 0
        Timer1.Enabled = False
        TextBox1.Text = ""
        ComboBox1.SelectedIndex = 0
        Me.Width = 365
        alh1 = "00"
        alh2 = "00"
        alh3 = "00"
        alm1 = "00"
        alm2 = "00"
        alm3 = "00"

        '遮挡
        Panel1.Location = New Point(1, 145)
        Panel1.BackColor = Color.WhiteSmoke

        '输出，仅显示
        Label3.Text = Application.StartupPath
        path3.Text = Application.StartupPath & "alarm0.wav"
        path4.Text = Application.StartupPath & "alarm1.wav"
        path5.Text = Application.StartupPath & "alarm2.wav"

        OpenFileDialog1.InitialDirectory = Application.StartupPath
        OpenFileDialog1.Filter = "波形声音文件(*.wav)|*.wav|压缩标准音频文件 (*.mp3)|*.mp3|通用音频文件|*.*"
        OpenFileDialog1.Title = "选择文件"


        OpenFileDialog2.InitialDirectory = Application.StartupPath
        OpenFileDialog1.Filter = "波形声音文件(*.wav)|*.wav|压缩标准音频文件 (*.mp3)|*.mp3|通用音频文件|*.*"
        OpenFileDialog2.Title = "选择文件"

        OpenFileDialog3.InitialDirectory = Application.StartupPath
        OpenFileDialog1.Filter = "波形声音文件(*.wav)|*.wav|压缩标准音频文件 (*.mp3)|*.mp3|通用音频文件|*.*"
        OpenFileDialog3.Title = "选择文件"

        If System.IO.File.Exists(Application.StartupPath & "alarm0.wav") = False Then
            MsgBox("闹钟1 的音频文件未就绪，可能会导致程序崩溃，请检查文件目录。" & vbCrLf & “详细信息请阅读说明文档。”,, "警告")
        End If

        If System.IO.File.Exists(Application.StartupPath & "alarm1.wav") = False Then
            MsgBox（"闹钟2 的音频文件未就绪，可能会导致程序崩溃， 请检查文件目录。" & vbCrLf & “详细信息请阅读说明文档。”,, "警告"）
        End If

        If System.IO.File.Exists(Application.StartupPath & "alarm2.wav") = False Then
            MsgBox（"闹钟3 的音频文件未就绪，可能会导致程序崩溃， 请检查文件目录。" & vbCrLf & “详细信息请阅读说明文档。”,, "警告"）
        End If

        If System.IO.File.Exists(Application.StartupPath & "ringtone0.wav") = False Then
            MsgBox（"定时 的音频文件未就绪，可能会导致程序崩溃， 请检查文件目录。" & vbCrLf & “详细信息请阅读说明文档。”,, "警告"）
        End If

        If System.IO.File.Exists(Application.StartupPath & "readme.pdf") = False Then
            MsgBox（"说明文档未找到， 请重新安装程序。",, "警告"）
            Me.Close()
        End If
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

        systime0.Text = String.Format("{0:D2}:{1:D2}", Now.Hour, Now.Minute)
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
        Form3.Text = "ChronoSuite | 定时"

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

        arml1.Text = alh1 & ":" & alm1
        arml2.Text = alh2 & ":" & alm2
        arml3.Text = alh3 & ":" & alm3
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
            btnReset.Enabled = True
            isPaused = False

            nudHours.Enabled = False
            nudMinutes.Enabled = False
            nudSeconds.Enabled = False
            ComboBox1.Enabled = False
        End If

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
        isPaused = False
        lblPro1.Width = lblPro0.Width

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
        lblPro1.Width = lblPro0.Width

        UpdateTimeDisplay()
        ProgressBar1.Value = 0
        lblPercent.Text = "100"
        btnStart.Visible = True
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
            btnPause.Enabled = False
            btnStop.Enabled = False

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
            Timer5.Enabled = True

            nh3.Enabled = False
            nm3.Enabled = False

            path3.Enabled = False
            add3.Enabled = False
            dft3.Enabled = False

        Else
            arml1.Enabled = False
            Button3.ForeColor = Color.DarkGray
            Timer5.Enabled = False

            nh3.Enabled = True
            nm3.Enabled = True

            path3.Enabled = True

            add3.Enabled = True
            dft3.Enabled = True


        End If
    End Sub

    Private Sub armc2_CheckStateChanged(sender As Object, e As EventArgs) Handles armc2.CheckStateChanged
        If armc2.Checked = True Then
            arml2.Enabled = True
            Button4.ForeColor = Color.Black
            Timer6.Enabled = True

            nh4.Enabled = False
            nm4.Enabled = False

            path4.Enabled = False

            add4.Enabled = False
            dft4.Enabled = False

        Else
            arml2.Enabled = False
            Button4.ForeColor = Color.DarkGray
            Timer6.Enabled = False

            nh4.Enabled = True
            nm4.Enabled = True

            path4.Enabled = True

            add4.Enabled = True
            dft4.Enabled = True


        End If
    End Sub

    Private Sub armc3_CheckStateChanged(sender As Object, e As EventArgs) Handles armc3.CheckStateChanged
        If armc3.Checked = True Then
            arml3.Enabled = True
            Button5.ForeColor = Color.Black
            Timer7.Enabled = True

            nh5.Enabled = False
            nm5.Enabled = False

            path5.Enabled = False

            add5.Enabled = False
            dft5.Enabled = False

        Else
            arml3.Enabled = False
            Button5.ForeColor = Color.DarkGray
            Timer7.Enabled = False

            nh5.Enabled = True
            nm5.Enabled = True

            path5.Enabled = True

            add5.Enabled = True
            dft5.Enabled = True

        End If
    End Sub

    Private Sub nh3_ValueChanged(sender As Object, e As EventArgs) Handles nh3.ValueChanged
        If nh3.Value < 10 Then
            alh1 = "0" & nh3.Value
        Else
            alh1 = CStr(nh3.Value)
        End If
    End Sub

    Private Sub nm3_ValueChanged(sender As Object, e As EventArgs) Handles nm3.ValueChanged
        If nm3.Value < 10 Then
            alm1 = "0" & nm3.Value
        Else
            alm1 = CStr(nm3.Value)
        End If
    End Sub

    Private Sub nh4_ValueChanged(sender As Object, e As EventArgs) Handles nh4.ValueChanged
        If nh4.Value < 10 Then
            alh2 = "0" & nh4.Value
        Else
            alh2 = CStr(nh4.Value)
        End If
    End Sub

    Private Sub nm4_ValueChanged(sender As Object, e As EventArgs) Handles nm4.ValueChanged
        If nm4.Value < 10 Then
            alm2 = "0" & nm4.Value
        Else
            alm2 = CStr(nm4.Value)
        End If
    End Sub

    Private Sub nh5_ValueChanged(sender As Object, e As EventArgs) Handles nh5.ValueChanged
        If nh5.Value < 10 Then
            alh3 = "0" & nh5.Value
        Else
            alh3 = CStr(nh5.Value)
        End If
    End Sub

    Private Sub nm5_ValueChanged(sender As Object, e As EventArgs) Handles nm5.ValueChanged
        If nm5.Value < 10 Then
            alm3 = "0" & nm5.Value
        Else
            alm3 = CStr(nm5.Value)
        End If
    End Sub

    Private Sub CheckBox2_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckStateChanged
        If CheckBox2.Checked = False Then
            Me.Size = New Size(752, 581)
        Else
            Me.Size = New Size(365, 581)
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If armc1.Checked = True Then
            If arml1.Text = systime0.Text Then
                Form5.Show()
            End If
            Form5.TextBox1.Text = armt1.Text
            Form5.Label1.Text = arml1.Text
        End If

    End Sub


    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If Now.Minute + 1 > 60 Then
            nm3.Value = Now.Minute + 1

        End If
        If Now.Minute = 59 Then
            nh3.Value = Now.Hour + 1
            nm3.Value = 0
        End If
        If Now.Minute >= 0 Then
            nh3.Value = Now.Hour
            nm3.Value = Now.Minute + 1
        End If
    End Sub

    Private Sub pre2_Click(sender As Object, e As EventArgs) Handles pre2.Click
        If Now.Minute + 1 > 60 Then
            nm4.Value = Now.Minute + 1

        End If
        If Now.Minute = 59 Then
            nh4.Value = Now.Hour + 1
            nm4.Value = 0
        End If
        If Now.Minute >= 0 Then
            nh4.Value = Now.Hour
            nm4.Value = Now.Minute + 1
        End If
    End Sub

    Private Sub pre3_Click(sender As Object, e As EventArgs) Handles pre3.Click
        If Now.Minute + 1 > 60 Then
            nm5.Value = Now.Minute + 1

        End If
        If Now.Minute = 59 Then
            nh5.Value = Now.Hour + 1
            nm5.Value = 0
        End If
        If Now.Minute >= 0 Then
            nh5.Value = Now.Hour
            nm5.Value = Now.Minute + 1
        End If
    End Sub

    Private Sub cls3_Click(sender As Object, e As EventArgs) Handles cls3.Click
        nh3.Value = 0
        nm3.Value = 0
        armc1.Checked = False
    End Sub

    Private Sub cls4_Click(sender As Object, e As EventArgs) Handles cls4.Click
        nh4.Value = 0
        nm4.Value = 0
        armc2.Checked = False
    End Sub

    Private Sub cls5_Click(sender As Object, e As EventArgs) Handles cls5.Click
        nh5.Value = 0
        nm5.Value = 0
        armc3.Checked = False
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        TabControl2.SelectedIndex = 1
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        TabControl2.SelectedIndex = 2
    End Sub

    Private Sub cln3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cln3.LinkClicked
        armt1.Text = ""
    End Sub

    Private Sub cln4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cln4.LinkClicked
        armt2.Text = ""
    End Sub

    Private Sub cln5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cln5.LinkClicked
        armt3.Text = ""
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If armc2.Checked = True Then
            If arml2.Text = systime0.Text Then
                Form6.Show()
            End If
            Form6.TextBox1.Text = armt2.Text
            Form6.Label1.Text = arml2.Text
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If armc3.Checked = True Then
            If arml3.Text = systime0.Text Then
                Form7.Show()
            End If
            Form7.TextBox1.Text = armt3.Text
            Form7.Label1.Text = arml3.Text
        End If
    End Sub

    Private Sub add3_Click(sender As Object, e As EventArgs) Handles add3.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub dft3_Click(sender As Object, e As EventArgs) Handles dft3.Click
        path3.Text = Application.StartupPath & "alarm0.wav"
    End Sub

    Private Sub dft4_Click(sender As Object, e As EventArgs) Handles dft4.Click
        path4.Text = Application.StartupPath & "alarm1.wav"
    End Sub

    Private Sub dft5_Click(sender As Object, e As EventArgs) Handles dft5.Click
        path5.Text = Application.StartupPath & "alarm2.wav"
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk
        path3.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog2.FileOk
        path4.Text = OpenFileDialog2.FileName
    End Sub

    Private Sub OpenFileDialog3_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog3.FileOk
        path5.Text = OpenFileDialog3.FileName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form8.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Process1.StartInfo.UseShellExecute = True
        Process1.StartInfo.FileName = Application.StartupPath & "readme.pdf"
        Process1.Start()
    End Sub

    Private Sub prtitvl_MouseDown(sender As Object, e As MouseEventArgs) Handles prtitvl.MouseDown
        If e.Button = MouseButtons.Middle Then
            prtitvl.Value = 10
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        text0.Text = ""
    End Sub
End Class
