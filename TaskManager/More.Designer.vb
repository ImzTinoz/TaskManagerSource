<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class More
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
        Me.MysticTextBox1 = New TaskManager.MysticTextBox()
        Me.MysticButton3 = New TaskManager.MysticButton()
        Me.MysticButton2 = New TaskManager.MysticButton()
        Me.MysticButton1 = New TaskManager.MysticButton()
        Me.MysticClose1 = New TaskManager.MysticClose()
        Me.MysticTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Controls.Add(Me.MysticTextBox1)
        Me.MysticTheme1.Controls.Add(Me.MysticButton3)
        Me.MysticTheme1.Controls.Add(Me.MysticButton2)
        Me.MysticTheme1.Controls.Add(Me.MysticButton1)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(284, 261)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "More Features"
        '
        'MysticTextBox1
        '
        Me.MysticTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.MysticTextBox1.Location = New System.Drawing.Point(13, 207)
        Me.MysticTextBox1.MaxLength = 32767
        Me.MysticTextBox1.Multiline = False
        Me.MysticTextBox1.Name = "MysticTextBox1"
        Me.MysticTextBox1.ReadOnly = True
        Me.MysticTextBox1.Size = New System.Drawing.Size(258, 27)
        Me.MysticTextBox1.TabIndex = 3
        Me.MysticTextBox1.Text = "Current Version 1.0.0.1"
        Me.MysticTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MysticTextBox1.UseSystemPasswordChar = False
        '
        'MysticButton3
        '
        Me.MysticButton3.Location = New System.Drawing.Point(13, 140)
        Me.MysticButton3.Name = "MysticButton3"
        Me.MysticButton3.Size = New System.Drawing.Size(259, 40)
        Me.MysticButton3.TabIndex = 2
        Me.MysticButton3.Text = "Download If Newer"
        '
        'MysticButton2
        '
        Me.MysticButton2.Location = New System.Drawing.Point(13, 94)
        Me.MysticButton2.Name = "MysticButton2"
        Me.MysticButton2.Size = New System.Drawing.Size(259, 40)
        Me.MysticButton2.TabIndex = 1
        Me.MysticButton2.Text = "Check For Updates"
        '
        'MysticButton1
        '
        Me.MysticButton1.Location = New System.Drawing.Point(12, 48)
        Me.MysticButton1.Name = "MysticButton1"
        Me.MysticButton1.Size = New System.Drawing.Size(259, 40)
        Me.MysticButton1.TabIndex = 0
        Me.MysticButton1.Text = "Statistics"
        '
        'MysticClose1
        '
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Location = New System.Drawing.Point(260, 12)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(12, 12)
        Me.MysticClose1.TabIndex = 4
        Me.MysticClose1.Text = "MysticClose1"
        '
        'More
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "More"
        Me.Text = "More"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MysticTheme1 As MysticTheme
    Friend WithEvents MysticButton1 As MysticButton
    Friend WithEvents MysticTextBox1 As MysticTextBox
    Friend WithEvents MysticButton3 As MysticButton
    Friend WithEvents MysticButton2 As MysticButton
    Friend WithEvents MysticClose1 As MysticClose
End Class
