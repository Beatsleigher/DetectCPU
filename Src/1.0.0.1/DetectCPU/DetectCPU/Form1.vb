Imports System.Management
Imports System
Public Class Form1
#Region "Licensing"
    ' Note: This program is
    ' licensed under the GNU
    ' General Public License 
    ' (GPL) 3.0.
    ' Therefore, you may use this 
    ' program and/or its code in
    ' your own program/s as long
    ' as you mention me in the 
    ' credits and link up the original 
    ' thread. Please also note;
    ' that this program will occasionally 
    ' get an update, which adds new features.
    ' Of course, you may also implement these.
#End Region

#Region "Main stuff"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")
        For Each queryObj As ManagementObject In searcher.Get()
            Label1.Text = "CPU name: " & queryObj("Name").ToString
            Label2.Text = "Address width: " & queryObj("AddressWidth").ToString
            Label3.Text = "Architecture: " & queryObj("Architecture").ToString
            Label4.Text = "Availability: " & queryObj("Availability").ToString
            Label5.Text = "Caption: " & queryObj("Caption").ToString
            Label6.Text = "Config manager error code: " & "Not available." 'queryObj("ConfigManagerErrorCode").ToString
            Label7.Text = "Config manager user config: " & "Not available." 'queryObj("ConfigManagerUserConfig").ToString
            Label8.Text = "Status: " & queryObj("CpuStatus").ToString
            Label9.Text = "Creation class name: " & queryObj("CreationClassName").ToString
            Label10.Text = "Current clock speed: " & queryObj("CurrentClockSpeed").ToString
            Label11.Text = "Current voltage: " & queryObj("CurrentVoltage").ToString
            Label12.Text = "Ddata width: " & queryObj("DataWidth").ToString
            Label13.Text = "Cescription: " & queryObj("Description").ToString
            Label14.Text = "Device ID: " & queryObj("DeviceID").ToString
            Label15.Text = "Error cleared: " & "Not available" 'queryObj("ErrorCleared").ToString
            Label16.Text = "Error description: " & "Not available" 'queryObj("ErrorDescription").ToString
            Label17.Text = "Ext. clock: " & queryObj("ExtClock").ToString
            Label18.Text = "Family: " & queryObj("Family").ToString
            Label19.Text = "Install date: " & "Not available." 'queryObj("InstallDate").ToString
            Label20.Text = "L2 cache size" & queryObj("L2CacheSize").ToString
            Label21.Text = "L2 cache speed: " & queryObj("L2CacheSpeed").ToString
            Label22.Text = "L3 cache size: " & queryObj("L3CacheSize").ToString
            Label23.Text = "L3 cache speed: " & queryObj("L3CacheSpeed").ToString
            Label24.Text = "Last error code: " & "Not available." 'queryObj("LastErrorCode").ToString
            Label25.Text = "Level: " & queryObj("Level").ToString
            Label26.Text = "Load percentage: " & queryObj("LoadPercentage").ToString
            Label27.Text = "Manufacturer: " & queryObj("Manufacturer").ToString
            Label28.Text = "Virtualization firmware enabled: " & "Not available." 'queryObj("VirtualizationFirmwareEnabled").ToString
            Label29.Text = "Version: " & queryObj("Version").ToString
            Label30.Text = "Upgrade method: " & queryObj("UpgradeMethod").ToString
            Label31.Text = "Unique ID: " & "Not available." 'queryObj("UniqueId").ToString
            Label32.Text = "System name: " & queryObj("SystemName").ToString
            Label33.Text = "System creation class name: " & queryObj("SystemCreationClassName").ToString
            Label34.Text = "Stepping: " & queryObj("Stepping").ToString
            Label35.Text = "Status info: " & queryObj("StatusInfo").ToString
            Label36.Text = "Socket designation: " & queryObj("SocketDesignation").ToString
            Label37.Text = "Second level address translations: " & "Not available." 'queryObj("SecondLevelAddressTranslationExtensions").ToString
            Label38.Text = "Role: " & queryObj("Role").ToString
            Label39.Text = "Revision: " & queryObj("Revision").ToString
            Label40.Text = "Processor type: " & queryObj("ProcessorType").ToString
            Label41.Text = "Processor ID: " & queryObj("ProcessorId").ToString
            Label42.Text = "Power management supported: " & queryObj("PowerManagementSupported").ToString
            Label43.Text = "PNP device ID: " & "Not available." 'queryObj("PNPDeviceID").ToString
            Label44.Text = "Other family description: " & "Not available." 'queryObj("OtherFamilyDescription").ToString
            Label45.Text = "Number of logical processors: " & queryObj("NumberOfLogicalProcessors").ToString
            Label46.Text = "Number of cores: " & queryObj("NumberOfCores").ToString
            Label47.Text = "Max clock speed: " & queryObj("MaxClockSpeed").ToString
        Next
    End Sub

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WinFo.Show()
        Me.Hide()
    End Sub

End Class
