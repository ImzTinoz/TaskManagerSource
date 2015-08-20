<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MysticTheme1 = New TaskManager.MysticTheme()
        Me.MysticButton6 = New TaskManager.MysticButton()
        Me.MysticButton5 = New TaskManager.MysticButton()
        Me.MysticButton4 = New TaskManager.MysticButton()
        Me.MysticButton3 = New TaskManager.MysticButton()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.MysticClose1 = New TaskManager.MysticClose()
        Me.MysticTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.MysticButton6)
        Me.MysticTheme1.Controls.Add(Me.MysticButton5)
        Me.MysticTheme1.Controls.Add(Me.MysticButton4)
        Me.MysticTheme1.Controls.Add(Me.MysticButton3)
        Me.MysticTheme1.Controls.Add(Me.ListBox2)
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(284, 261)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "Task Manager"
        '
        'MysticButton6
        '
        Me.MysticButton6.Location = New System.Drawing.Point(172, 138)
        Me.MysticButton6.Name = "MysticButton6"
        Me.MysticButton6.Size = New System.Drawing.Size(100, 40)
        Me.MysticButton6.TabIndex = 5
        Me.MysticButton6.Text = "Test Process"
        '
        'MysticButton5
        '
        Me.MysticButton5.Location = New System.Drawing.Point(172, 184)
        Me.MysticButton5.Name = "MysticButton5"
        Me.MysticButton5.Size = New System.Drawing.Size(100, 40)
        Me.MysticButton5.TabIndex = 4
        Me.MysticButton5.Text = "More"
        '
        'MysticButton4
        '
        Me.MysticButton4.Location = New System.Drawing.Point(172, 92)
        Me.MysticButton4.Name = "MysticButton4"
        Me.MysticButton4.Size = New System.Drawing.Size(100, 40)
        Me.MysticButton4.TabIndex = 3
        Me.MysticButton4.Text = "Kill Processes"
        '
        'MysticButton3
        '
        Me.MysticButton3.Location = New System.Drawing.Point(172, 46)
        Me.MysticButton3.Name = "MysticButton3"
        Me.MysticButton3.Size = New System.Drawing.Size(100, 40)
        Me.MysticButton3.TabIndex = 2
        Me.MysticButton3.Text = "Get Processes"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 46)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(147, 199)
        Me.ListBox2.TabIndex = 1
        '
        'MysticClose1
        '
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Location = New System.Drawing.Point(12, 12)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(12, 12)
        Me.MysticClose1.TabIndex = 0
        Me.MysticClose1.Text = "MysticClose1"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub MysticTheme1_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents MysticButton2 As MysticButton
    Friend WithEvents MysticButton1 As MysticButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MysticTheme1 As MysticTheme
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents MysticClose1 As MysticClose
    Friend WithEvents MysticButton4 As MysticButton
    Friend WithEvents MysticButton3 As MysticButton
    Friend WithEvents MysticButton6 As MysticButton
    Friend WithEvents MysticButton5 As MysticButton
End Class
