<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 35)
        Label1.TabIndex = 0
        Label1.Text = "00:00:00"
        ' 
        ' Button1
        ' 
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(350, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(35, 35)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(309, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(35, 35)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ButtonHighlight
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(15, 63)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(369, 93)
        TextBox1.TabIndex = 4
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 170)
        ControlBox = False
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        Text = "ChronSuite | 定时"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
