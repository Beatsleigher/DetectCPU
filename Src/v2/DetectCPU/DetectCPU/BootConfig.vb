Imports SysLib
Imports System.ComponentModel
Imports System.Diagnostics.Process

Public Class BootConfig

    Private WithEvents worker As BackgroundWorker = New BackgroundWorker
    Private bc As GetInfo.BootConfig = New GetInfo.BootConfig

    Private Sub BootConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data.Show()
        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles worker.DoWork
        Me.Invoke(Sub() Label1.Text = bc.GetBootDir())
        Me.Invoke(Sub() Label2.Text = bc.GetConfigPath())
        Me.Invoke(Sub() Label3.Text = bc.GetLastDrive())
        Me.Invoke(Sub() Label4.Text = bc.GetScratchDir())
        Me.Invoke(Sub() Label5.Text = bc.GetTempDir())
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