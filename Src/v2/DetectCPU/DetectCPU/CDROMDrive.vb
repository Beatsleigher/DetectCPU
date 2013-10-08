Imports SysLib
Imports System.ComponentModel
Imports System.Diagnostics.Process

Public Class CDROMDrive

    Private WithEvents worker As BackgroundWorker = New BackgroundWorker
    Private cd As GetInfo.CDROMDrive = New GetInfo.CDROMDrive

    Private Sub CDROMDrive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data.Show()
        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles worker.DoWork
        Me.Invoke(Sub() Label1.Text = cd.GetCompressionMethod())
        Me.Invoke(Sub() Label2.Text = cd.GetDefBlockSize())
        Me.Invoke(Sub() Label3.Text = cd.GetDeviceID())
        Me.Invoke(Sub() Label4.Text = cd.GetDriveLetter())
        Me.Invoke(Sub() Label5.Text = cd.GetInstallDate())
        Me.Invoke(Sub() Label6.Text = cd.GetManufacturer())
        Me.Invoke(Sub() Label7.Text = cd.GetMaxBlockSize())
        Me.Invoke(Sub() Label8.Text = cd.GetMaxComponentLength())
        Me.Invoke(Sub() Label9.Text = cd.GetMaxMediaSize())
        Me.Invoke(Sub() Label10.Text = cd.GetMediaType())
        Me.Invoke(Sub() Label11.Text = cd.GetMfrAssignedRevLevel())
        Me.Invoke(Sub() Label12.Text = cd.GetMinBlockSize())
        Me.Invoke(Sub() Label13.Text = cd.GetNoOfMediaSupported())
        Me.Invoke(Sub() Label14.Text = "Media Loaded: " & cd.IsMediaLoaded.ToString())
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