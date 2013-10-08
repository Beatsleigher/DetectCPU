Imports SysLib
Imports System.ComponentModel
Imports System.Diagnostics.Process

Public Class Battery

    Dim WithEvents worker As BackgroundWorker = New BackgroundWorker
    Dim bat As GetInfo.Battery = New GetInfo.Battery

    Private Sub Battery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data.Show()
        worker.WorkerReportsProgress = True
        worker.WorkerSupportsCancellation = True

        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles worker.DoWork
        Me.Invoke(Sub() Label1.Text = bat.GetBatteryLife())
        Me.Invoke(Sub() Label2.Text = bat.GetBatteryStatus())
        Me.Invoke(Sub() Label3.Text = bat.GetChemistry())
        Me.Invoke(Sub() Label4.Text = bat.GetDesignCapacity())
        Me.Invoke(Sub() Label5.Text = bat.GetDesignVoltage())
        Me.Invoke(Sub() Label6.Text = bat.GetDeviceID())
        Me.Invoke(Sub() Label7.Text = bat.GetExpectedLife())
        Me.Invoke(Sub() Label8.Text = bat.GetFullChargeCapacity())
        Me.Invoke(Sub() Label9.Text = bat.GetInstallDate())
        Me.Invoke(Sub() Label10.Text = bat.GetMaxRechargeTime())
        Me.Invoke(Sub() Label11.Text = bat.GetPNPDeviceID())
        Me.Invoke(Sub() Label12.Text = bat.GetRechargeTime())
        Me.Invoke(Sub() Label13.Text = bat.GetRemainingCharge())
        Me.Invoke(Sub() Label14.Text = bat.GetRunTime())
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