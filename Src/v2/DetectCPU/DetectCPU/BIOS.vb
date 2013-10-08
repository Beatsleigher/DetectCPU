Imports SysLib
Imports System.ComponentModel
Imports System.Diagnostics.Process

Public Class BIOS

    Dim WithEvents worker As BackgroundWorker = New BackgroundWorker
    Dim bios As GetInfo.BIOS

    Private Sub BIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data.Show()
        worker.WorkerReportsProgress = True
        worker.WorkerSupportsCancellation = True
    End Sub

    Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles worker.DoWork
        Me.Invoke(Sub() Label1.Text = bios.GetBIOSVer())
        Me.Invoke(Sub() Label2.Text = bios.GetBuildNo())
        Me.Invoke(Sub() Label3.Text = bios.GetCodeSet())
        Me.Invoke(Sub() Label4.Text = bios.GetCurrentLang())
        Me.Invoke(Sub() Label5.Text = bios.getIdentCode())
        Me.Invoke(Sub() Label6.Text = bios.GetInstallableLangs())
        Me.Invoke(Sub() Label7.Text = bios.GetInstallDate())
        Me.Invoke(Sub() Label8.Text = bios.GetLangEdition())
        Me.Invoke(Sub() Label9.Text = bios.GetManufacturer())
        Me.Invoke(Sub() Label10.Text = bios.GetOtherTargetOS())
        Me.Invoke(Sub() Label11.Text = bios.GetReleaseDate())
        Me.Invoke(Sub() Label12.Text = bios.GetSerialNumber())
        Me.Invoke(Sub() Label13.Text = "Is Primary BIOS: " & bios.IsPrimaryBIOS.ToString())
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
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
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Start("http://gofundme.com/NewPC")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Load_Data.Show()
        worker.RunWorkerAsync()
    End Sub
End Class