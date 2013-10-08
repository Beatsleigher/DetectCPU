Imports SysLib
Imports System.ComponentModel
Imports System.Diagnostics.Process

Public Class ComputerSys

    Private WithEvents worker As BackgroundWorker = New BackgroundWorker
    Private cs As GetInfo.ComputerSystem = New GetInfo.ComputerSystem

    Private Sub ComputerSys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data.Show()
        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles worker.DoWork
        Me.Invoke(Sub() Label1.Text = "Automatic Reset: " & cs.AutomaticResetBootOption().ToString())
        Me.Invoke(Sub() Label2.Text = "Automatic Reset Boot: " & cs.AutomaticResetCapability().ToString())
        Me.Invoke(Sub() Label3.Text = cs.GetAdminPasswordStatus().ToString())
        Me.Invoke(Sub() Label4.Text = cs.GetBootupState().ToString())
        Me.Invoke(Sub() Label5.Text = cs.GetDNSHostName().ToString())
        Me.Invoke(Sub() Label6.Text = cs.GetDomain().ToString())
        Me.Invoke(Sub() Label7.Text = cs.GetDomainRole().ToString())
        Me.Invoke(Sub() Label8.Text = cs.GetFrontPanelResetStatus().ToString())
        Me.Invoke(Sub() Label9.Text = cs.GetInitialLoadInfo().ToString())
        Me.Invoke(Sub() Label10.Text = cs.GetInstallDate().ToString())
        Me.Invoke(Sub() Label11.Text = cs.GetKeyboardPassStatus().ToString())
        Me.Invoke(Sub() Label12.Text = cs.GetLastLoadInfo().ToString())
        Me.Invoke(Sub() Label13.Text = cs.GetManufacturer().ToString())
        Me.Invoke(Sub() Label14.Text = cs.GetModel().ToString())
        Me.Invoke(Sub() Label15.Text = cs.GetNameFormat().ToString())
        Me.Invoke(Sub() Label16.Text = cs.GetOwnerContact().ToString())
        Me.Invoke(Sub() Label17.Text = cs.GetOwnerName().ToString())
        Me.Invoke(Sub() Label18.Text = cs.GetPCSystemType().ToString())
        Me.Invoke(Sub() Label19.Text = cs.GetPowerOnPasswordStatus().ToString())
        Me.Invoke(Sub() Label20.Text = cs.GetPowerState().ToString())
        Me.Invoke(Sub() Label21.Text = cs.GetPowerSupplyState().ToString())
        Me.Invoke(Sub() Label22.Text = cs.GetResetCount().ToString())
        Me.Invoke(Sub() Label23.Text = cs.GetStatus().ToString())
        Me.Invoke(Sub() Label24.Text = cs.GetSysType().ToString())
        Me.Invoke(Sub() Label25.Text = cs.GetThermalState().ToString())
        Me.Invoke(Sub() Label26.Text = cs.GetUserName().ToString())
        Me.Invoke(Sub() Label27.Text = "Boot ROM Supported: " & cs.IsBootROMSupported().ToString())
        Me.Invoke(Sub() Label28.Text = "Daylight Saving Active: " & cs.IsDaylightSavingActive().ToString())
        Me.Invoke(Sub() Label29.Text = "Infrarad Supported: " & cs.IsInfraredSupported().ToString())
        Me.Invoke(Sub() Label30.Text = "Network Server Mode Enabled: " & cs.IsNetworkServerModeEnabled().ToString())
        Me.Invoke(Sub() Label31.Text = "Pagefile Atuo-Managed: " & cs.IsPagefileAutoManaged().ToString())
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
End Class