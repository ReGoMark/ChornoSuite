Imports System.IO
Imports NAudio.Wave


Public Class Form7
    Private waveOut As WaveOutEvent
    Private audioFileReader As AudioFileReader


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 指定音乐文件路径
        Dim filePath As String = Form1.path5.Text

        ' 创建 WaveOutEvent 对象用于播放声音
        waveOut = New WaveOutEvent()

        ' 创建 AudioFileReader 对象读取音频文件
        audioFileReader = New AudioFileReader(filePath)

        ' 将音频文件连接到播放设备
        waveOut.Init(audioFileReader)

        ' 添加事件处理器，当播放结束时重新播放音频
        AddHandler waveOut.PlaybackStopped, AddressOf OnPlaybackStopped

        ' 播放音频
        If Form1.sound5.Checked = True Then
            waveOut.Play()
        End If
        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width
        Me.Top = My.Computer.Screen.WorkingArea.Height - Me.Height
    End Sub

    ' 当播放结束时调用此方法
    Private Sub OnPlaybackStopped(sender As Object, e As StoppedEventArgs)
        If waveOut IsNot Nothing AndAlso waveOut.PlaybackState = PlaybackState.Stopped Then
            ' 重置音频文件到开头
            audioFileReader.Position = 0
            ' 重新播放音频
            waveOut.Play()
        End If
    End Sub

    ' 控制音量的方法
    Public Sub SetVolume(isMuted As Boolean)
        If waveOut IsNot Nothing Then
            waveOut.Volume = If(isMuted, 0, 1) ' 静音或恢复音量
        End If
    End Sub

    ' 确保程序退出时停止播放并释放资源
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        ' 停止播放
        If waveOut IsNot Nothing Then
            waveOut.Stop()
        End If
        MyBase.OnFormClosing(e)
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        ' 释放资源
        If waveOut IsNot Nothing Then
            waveOut.Dispose()
            waveOut = Nothing
        End If

        If audioFileReader IsNot Nothing Then
            audioFileReader.Dispose()
            audioFileReader = Nothing
        End If

        MyBase.OnFormClosed(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close
        Form1.armc3.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub
End Class

