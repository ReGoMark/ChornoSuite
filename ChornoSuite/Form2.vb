Public Class Form2
    Private Sub st4_Click(sender As Object, e As EventArgs) Handles st4.Click
        Form1.Timer1.Enabled = True
        Form1.st1.Visible = False
        Form1.pa1.Visible = True
        Form1.cls1.Enabled = True

        st4.Visible = False
        pa4.Visible = True
        cls4.Enabled = True
    End Sub

    Private Sub pa4_Click(sender As Object, e As EventArgs) Handles pa4.Click
        Form1.Timer1.Enabled = False
        Form1.pa1.Visible = False
        Form1.ct1.Visible = True

        pa4.Visible = False
        ct4.Visible = True
    End Sub

    Private Sub ct4_Click(sender As Object, e As EventArgs) Handles ct4.Click
        Form1.Timer1.Enabled = True
        Form1.pa1.Visible = True
        Form1.ct1.Visible = False

        pa4.Visible = True
        ct4.Visible = False
    End Sub

    Private Sub cls4_Click(sender As Object, e As EventArgs) Handles cls4.Click
        Form1.trans.Text = "0"
        Form1.st1.Visible = True
        Form1.ct1.Visible = False
        Form1.cls1.Enabled = False

        stop4.Text = "00:00:00"
        st4.Visible = True
        ct4.Visible = False
        cls4.Enabled = False
    End Sub
    Private Sub stop4_DoubleClick(sender As Object, e As EventArgs) Handles stop4.DoubleClick
        Me.CenterToScreen()
    End Sub
    Private Sub Form2_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        If Me.Right > My.Computer.Screen.WorkingArea.Right Then
            Me.Left = CInt(My.Computer.Screen.WorkingArea.Right - Me.Width * 0.3555)
        End If
    End Sub

    Private Sub mini4_Click(sender As Object, e As EventArgs) Handles mini4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub top4_CheckStateChanged(sender As Object, e As EventArgs) Handles top4.CheckStateChanged
        If top4.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
        Form1.jane.Checked = False
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.ct1.Visible = True Then
            ct4.Visible = True
            st4.Visible = False
            pa4.Visible = False
        Else
            If Form1.Timer1.Enabled = True Then
                st4.Visible = False
                pa4.Visible = True
            End If
        End If
    End Sub

End Class