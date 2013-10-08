Imports System.ComponentModel
Imports SysLib
Imports System.Diagnostics.Process

Public Class BaseBoard

    Dim board As GetInfo.BaseBoard = New GetInfo.BaseBoard
    Dim WithEvents worker As BackgroundWorker = New BackgroundWorker

    Private Sub BaseBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data.Show()
        worker.WorkerReportsProgress = True
        worker.WorkerSupportsCancellation = True

        worker.RunWorkerAsync()
    End Sub

    Private Sub worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles worker.DoWork
        Me.Invoke(Sub() Label1.Text = board.getDepth())
        Me.Invoke(Sub() Label2.Text = board.GetHeight())
        Me.Invoke(Sub() Label3.Text = board.GetInstallDate())
        Me.Invoke(Sub() Label4.Text = board.GetManufacturer())
        Me.Invoke(Sub() Label5.Text = board.GetModel())
        Me.Invoke(Sub() Label6.Text = board.GetName())
        Me.Invoke(Sub() Label7.Text = board.GetOtherIdentInfo())
        Me.Invoke(Sub() Label8.Text = board.GetPartNo())
        Me.Invoke(Sub() Label9.Text = board.GetProduct())
        Me.Invoke(Sub() Label10.Text = board.GetSerialNo())
        Me.Invoke(Sub() Label11.Text = board.GetSKU())
        Me.Invoke(Sub() Label12.Text = board.GetSlotLayout())
        Me.Invoke(Sub() Label13.Text = board.GetSpecialRequirements())
        Me.Invoke(Sub() Label14.Text = board.GetStatus())
        Me.Invoke(Sub() Label15.Text = board.GetVersion())
        Me.Invoke(Sub() Label16.Text = "Is Hosting Board: " & board.IsHostingBoard.ToString())
        Me.Invoke(Sub() Label17.Text = "Is Hotspwappable" & board.IsHotSwappable.ToString())
        Me.Invoke(Sub() Label18.Text = "Is Powered on: " & board.IsPoweredOn.ToString())
        Me.Invoke(Sub() Label19.Text = "Is Removable: " & board.IsRemovable())
        Me.Invoke(Sub() Label20.Text = "Is Replaceable: " & board.IsReplaceable.ToString())
        Me.Invoke(Sub() Label21.Text = "Requires Daughterboard: " & board.RequiresDaughterBoard.ToString())
        Me.Invoke(Sub() Load_Data.Close())
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Load_Data.Show()
        worker.RunWorkerAsync()
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
End Class