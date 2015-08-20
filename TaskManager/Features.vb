Public Class Features
    Protected cpuCounter As System.Diagnostics.PerformanceCounter
    Protected ramCounter As System.Diagnostics.PerformanceCounter
    Protected tmr As System.Timers.Timer
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        tmr = New System.Timers.Timer(500)
        AddHandler tmr.Elapsed, AddressOf Me.tmr_Elapsed

        ' Add any initialization after the InitializeComponent() call.
        cpuCounter = New System.Diagnostics.PerformanceCounter()
        cpuCounter.CategoryName = "Processor"
        cpuCounter.CounterName = "% Processor Time"
        cpuCounter.InstanceName = "_Total"
        ramCounter = New System.Diagnostics.PerformanceCounter("Memory", "Available MBytes")
        'init cpu counter 
        Dim tmp As Single = cpuCounter.NextValue()

    End Sub
    Private Sub btnCheckRamCpu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheckRamCpu.Click
        tmr.Enabled = Not tmr.Enabled
        If tmr.Enabled Then
            BtnCheckRamCpu.Text = "Stop monitor ram cpu"
        Else
            BtnCheckRamCpu.Text = "Start monitor ram cpu"
        End If
    End Sub

    Private Delegate Sub dlgUpdateUI(ByVal ctl As Control, ByVal text As String)

    Private Sub tmr_Elapsed(ByVal sender As Object, ByVal e As Timers.ElapsedEventArgs)
        Dim cpumsg As String = "Cpu usage: " & cpuCounter.NextValue().ToString("#0") + "%"
        Dim rammsg As String = "Ram usage: " & ramCounter.NextValue().ToString("###,###,##0") + " Mb"
        If Me.InvokeRequired Then
            Dim d As New dlgUpdateUI(AddressOf SetLblText)
            Me.Invoke(d, LblCpu, cpumsg)
            Me.Invoke(d, lblRam, rammsg)
        Else

            SetLblText(LblCpu, cpumsg)

            SetLblText(lblRam, rammsg)
        End If
    End Sub

    Private Sub frmWinCounter_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        tmr.Enabled = False
    End Sub

    Private Sub SetLblText(ByVal lbl As Label, ByVal sText As String)
        lbl.Text = sText
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCheckRamCpu_Click_1(sender As Object, e As EventArgs) Handles BtnCheckRamCpu.Click

    End Sub

    Private Sub lblRam_Click(sender As Object, e As EventArgs) Handles lblRam.Click

    End Sub

    Private Sub LblCpu_Click(sender As Object, e As EventArgs) Handles LblCpu.Click

    End Sub
End Class