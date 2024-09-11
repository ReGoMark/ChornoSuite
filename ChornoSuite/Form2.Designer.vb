<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        stop4 = New Label()
        st4 = New Button()
        pa4 = New Button()
        ct4 = New Button()
        cls4 = New Button()
        title4 = New CheckBox()
        mini4 = New Button()
        Timer1 = New Timer(components)
        ToolTip1 = New ToolTip(components)
        top4 = New CheckBox()
        SuspendLayout()
        ' 
        ' stop4
        ' 
        stop4.AutoSize = True
        stop4.Font = New Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        stop4.Location = New Point(12, 11)
        stop4.Name = "stop4"
        stop4.Size = New Size(78, 24)
        stop4.TabIndex = 0
        stop4.Text = "00:00:00"
        ToolTip1.SetToolTip(stop4, "双击居中显示")
        ' 
        ' st4
        ' 
        st4.Image = CType(resources.GetObject("st4.Image"), Image)
        st4.Location = New Point(98, 9)
        st4.Name = "st4"
        st4.Size = New Size(30, 30)
        st4.TabIndex = 1
        ToolTip1.SetToolTip(st4, "开始")
        st4.UseVisualStyleBackColor = True
        ' 
        ' pa4
        ' 
        pa4.Image = CType(resources.GetObject("pa4.Image"), Image)
        pa4.Location = New Point(98, 9)
        pa4.Name = "pa4"
        pa4.Size = New Size(30, 30)
        pa4.TabIndex = 2
        ToolTip1.SetToolTip(pa4, "暂停")
        pa4.UseVisualStyleBackColor = True
        pa4.Visible = False
        ' 
        ' ct4
        ' 
        ct4.Image = CType(resources.GetObject("ct4.Image"), Image)
        ct4.Location = New Point(98, 9)
        ct4.Name = "ct4"
        ct4.Size = New Size(30, 30)
        ct4.TabIndex = 3
        ToolTip1.SetToolTip(ct4, "继续")
        ct4.UseVisualStyleBackColor = True
        ct4.Visible = False
        ' 
        ' cls4
        ' 
        cls4.Image = CType(resources.GetObject("cls4.Image"), Image)
        cls4.Location = New Point(134, 9)
        cls4.Name = "cls4"
        cls4.Size = New Size(30, 30)
        cls4.TabIndex = 4
        ToolTip1.SetToolTip(cls4, "归零")
        cls4.UseVisualStyleBackColor = True
        ' 
        ' title4
        ' 
        title4.Appearance = Appearance.Button
        title4.Image = CType(resources.GetObject("title4.Image"), Image)
        title4.ImageAlign = ContentAlignment.BottomCenter
        title4.Location = New Point(170, 9)
        title4.Name = "title4"
        title4.Size = New Size(30, 30)
        title4.TabIndex = 5
        ToolTip1.SetToolTip(title4, "标题同步")
        title4.UseVisualStyleBackColor = True
        ' 
        ' mini4
        ' 
        mini4.Image = CType(resources.GetObject("mini4.Image"), Image)
        mini4.Location = New Point(242, 9)
        mini4.Name = "mini4"
        mini4.Size = New Size(30, 30)
        mini4.TabIndex = 6
        ToolTip1.SetToolTip(mini4, "最小化")
        mini4.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 2000
        ' 
        ' top4
        ' 
        top4.Appearance = Appearance.Button
        top4.Checked = True
        top4.CheckState = CheckState.Checked
        top4.Image = CType(resources.GetObject("top4.Image"), Image)
        top4.Location = New Point(206, 9)
        top4.Name = "top4"
        top4.Size = New Size(30, 30)
        top4.TabIndex = 7
        ToolTip1.SetToolTip(top4, "置顶显示")
        top4.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        ClientSize = New Size(282, 48)
        Controls.Add(top4)
        Controls.Add(mini4)
        Controls.Add(title4)
        Controls.Add(cls4)
        Controls.Add(stop4)
        Controls.Add(st4)
        Controls.Add(pa4)
        Controls.Add(ct4)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChnSuit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents stop4 As Label
    Friend WithEvents st4 As Button
    Friend WithEvents pa4 As Button
    Friend WithEvents ct4 As Button
    Friend WithEvents cls4 As Button
    Friend WithEvents title4 As CheckBox
    Friend WithEvents mini4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents top4 As CheckBox
End Class
