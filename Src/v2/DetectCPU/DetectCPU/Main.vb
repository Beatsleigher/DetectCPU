Imports SysLib.GetInfo
Imports System.ComponentModel
Imports System.Diagnostics.Process

Public Class Main

    Dim cpu As CPU = New CPU
    Dim WithEvents worker As BackgroundWorker = New BackgroundWorker

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data.Show()
        worker.WorkerReportsProgress = True
        worker.WorkerSupportsCancellation = False
        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles worker.DoWork
        Me.Invoke(Sub() Label1.Text = cpu.GetAddressWidth())
        Me.Invoke(Sub() Label2.Text = cpu.GetArchitecture())
        Me.Invoke(Sub() Label3.Text = cpu.GetAvailability())
        Me.Invoke(Sub() Label4.Text = cpu.GetCaption())
        Me.Invoke(Sub() Label5.Text = cpu.GetConfigManagerErrorCode())
        Me.Invoke(Sub() Label6.Text = cpu.GetConfigManagerUserConfig())
        Me.Invoke(Sub() Label7.Text = cpu.GetCpuRev())
        Me.Invoke(Sub() Label8.Text = cpu.GetCpuRole())
        Me.Invoke(Sub() Label9.Text = cpu.GetCpuStatus())
        Me.Invoke(Sub() Label10.Text = cpu.GetCpuType())
        Me.Invoke(Sub() Label11.Text = cpu.GetCurrentClockSpeed())
        Me.Invoke(Sub() Label12.Text = cpu.GetCurrentVoltage())
        Me.Invoke(Sub() Label13.Text = cpu.GetDataWidth())
        Me.Invoke(Sub() Label14.Text = cpu.GetDescription())
        Me.Invoke(Sub() Label15.Text = cpu.GetDeviceID())
        Me.Invoke(Sub() Label16.Text = cpu.GetErrorCleared())
        Me.Invoke(Sub() Label17.Text = cpu.GetErrorDescription())
        Me.Invoke(Sub() Label18.Text = cpu.GetExtClock())
        Me.Invoke(Sub() Label19.Text = cpu.GetFamily())
        Me.Invoke(Sub() Label20.Text = cpu.GetInstallDate())
        Me.Invoke(Sub() Label21.Text = cpu.GetL2CacheSize())
        Me.Invoke(Sub() Label22.Text = cpu.GetL2CacheSpeed())
        Me.Invoke(Sub() Label23.Text = cpu.GetL3CacheSize())
        Me.Invoke(Sub() Label24.Text = cpu.GetL3CacheSpeed())
        Me.Invoke(Sub() Label25.Text = cpu.GetLastErrorCode())
        Me.Invoke(Sub() Label26.Text = cpu.GetLevel())
        Me.Invoke(Sub() Label27.Text = cpu.GetLoadPercentage())
        Me.Invoke(Sub() Label28.Text = cpu.GetManufacturer())
        Me.Invoke(Sub() Label29.Text = cpu.GetMaxClockSpeed())
        Me.Invoke(Sub() Label30.Text = cpu.GetName())
        Me.Invoke(Sub() Label31.Text = cpu.GetNumOfCores())
        Me.Invoke(Sub() Label32.Text = cpu.getNumOfThread())
        Me.Invoke(Sub() Label33.Text = cpu.GetOtherFamDescription())
        Me.Invoke(Sub() Label34.Text = cpu.GetPNPDeviceID())
        Me.Invoke(Sub() Label35.Text = cpu.GetPowerMgmtSupported())
        Me.Invoke(Sub() Label36.Text = cpu.GetSocDesignation())
        Me.Invoke(Sub() Label37.Text = cpu.GetStatus())
        Me.Invoke(Sub() Label38.Text = cpu.GetStepping())
        Me.Invoke(Sub() Label39.Text = cpu.GetVersion())
        Me.Invoke(Sub() Label40.Text = cpu.GetVoltageCaps())
        Me.Invoke(Sub() Load_Data.Close())
    End Sub

    ''' <summary>
    ''' Beatsleigher's PayPal donation link.
    ''' 
    ''' You are NOT permitted to change or otherwise modify these values!
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=AXUCHVG5YRX4A")
    End Sub

    ''' <summary>
    ''' Beatsleigher's GoFundMe donation link.
    ''' 
    ''' You are NOT permitted to change or otherwise modify these values!
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Start("http://gofundme.com/NewPC")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Load_Data.Show()
        worker.RunWorkerAsync()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BaseBoard.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Battery.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BIOS.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BootConfig.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CDROMDrive.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComputerSys.Show()
    End Sub
End Class