<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Features
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
        Me.MysticTheme1 = New TaskManager.MysticTheme()
        Me.LblCpu = New System.Windows.Forms.Label()
        Me.lblRam = New System.Windows.Forms.Label()
        Me.BtnCheckRamCpu = New TaskManager.MysticButton()
        Me.MysticClose1 = New TaskManager.MysticClose()
        Me.MysticTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Controls.Add(Me.LblCpu)
        Me.MysticTheme1.Controls.Add(Me.lblRam)
        Me.MysticTheme1.Controls.Add(Me.BtnCheckRamCpu)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(284, 261)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "Statistics"
        '
        'LblCpu
        '
        Me.LblCpu.AutoSize = True
        Me.LblCpu.Location = New System.Drawing.Point(9, 152)
        Me.LblCpu.Name = "LblCpu"
        Me.LblCpu.Size = New System.Drawing.Size(39, 13)
        Me.LblCpu.TabIndex = 4
        Me.LblCpu.Text = "Label1"
        '
        'lblRam
        '
        Me.lblRam.AutoSize = True
        Me.lblRam.Location = New System.Drawing.Point(9, 114)
        Me.lblRam.Name = "lblRam"
        Me.lblRam.Size = New System.Drawing.Size(39, 13)
        Me.lblRam.TabIndex = 3
        Me.lblRam.Text = "Label1"
        '
        'BtnCheckRamCpu
        '
        Me.BtnCheckRamCpu.Location = New System.Drawing.Point(12, 46)
        Me.BtnCheckRamCpu.Name = "BtnCheckRamCpu"
        Me.BtnCheckRamCpu.Size = New System.Drawing.Size(100, 40)
        Me.BtnCheckRamCpu.TabIndex = 0
        Me.BtnCheckRamCpu.Text = "Start"
        '
        'MysticClose1
        '
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Location = New System.Drawing.Point(260, 12)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(12, 12)
        Me.MysticClose1.TabIndex = 5
        Me.MysticClose1.Text = "MysticClose1"
        '
        'Features
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Features"
        Me.Text = "Features"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        Me.MysticTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MysticTheme1 As MysticTheme
    Friend WithEvents BtnCheckRamCpu As MysticButton
    Friend WithEvents lblRam As Label
    Friend WithEvents LblCpu As Label
    Friend WithEvents MysticClose1 As MysticClose
End Class
