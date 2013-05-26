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
        Try
            For Each queryObj As ManagementObject In searcher.Get()
                Try
                    Label1.Text = "CPU name: " & queryObj("Name").ToString
                Catch ex1 As Exception
                    Label1.Text = "CPU name: Not available."
                End Try

                Try
                    Label2.Text = "Address width: " & queryObj("AddressWidth").ToString
                Catch ex2 As Exception
                    Label2.Text = "Address width: Not available."
                End Try

                Try
                    Label3.Text = "Architecture: " & queryObj("Architecture").ToString
                Catch ex3 As Exception
                    Label3.Text = "Architecture: Not available"
                End Try

                Try
                    Label4.Text = "Availability: " & queryObj("Availability").ToString
                Catch ex4 As Exception
                    Label5.Text = "Availability: Not available."
                End Try

                Try
                    Label5.Text = "Caption: " & queryObj("Caption").ToString
                Catch ex5 As Exception

                End Try

                Try
                    Label6.Text = "Config manager error code: " & queryObj("ConfigManagerErrorCode").ToString
                Catch ex6 As Exception
                    Label6.Text = "Config manager error code: Not available."
                End Try

                Try
                    Label7.Text = "Config manager user config: " & queryObj("ConfigManagerUserConfig").ToString
                Catch ex7 As Exception
                    Label7.Text = "Config manager user code: Not available."
                End Try

                Try
                    Label8.Text = "Status: " & queryObj("CpuStatus").ToString
                Catch ex8 As Exception
                    Label8.Text = "Status: Not available."
                End Try

                Try
                    Label9.Text = "Creation class name: " & queryObj("CreationClassName").ToString
                Catch ex9 As Exception
                    Label9.Text = "Creation class name: Not available."
                End Try

                Try
                    Label10.Text = "Current clock speed: " & queryObj("CurrentClockSpeed").ToString
                Catch ex10 As Exception
                    Label10.Text = "Current clock speed: Not available"
                End Try

                Try
                    Label11.Text = "Current voltage: " & queryObj("CurrentVoltage").ToString
                Catch ex11 As Exception
                    Label11.Text = "Current voltage: Not available."
                End Try

                Try
                    Label12.Text = "Data width: " & queryObj("DataWidth").ToString
                Catch ex12 As Exception
                    Label12.Text = "Data width: Not available."
                End Try

                Try
                    Label13.Text = "Description: " & queryObj("Description").ToString
                Catch ex13 As Exception
                    Label13.Text = "Description: Not available."
                End Try

                Try
                    Label14.Text = "Device ID: " & queryObj("DeviceID").ToString
                Catch ex14 As Exception
                    Label14.Text = "Device ID: Not available."
                End Try

                Try
                    Label15.Text = "Error cleared: " & queryObj("ErrorCleared").ToString
                Catch ex15 As Exception
                    Label15.Text = "Error cleared: Not available."
                End Try

                Try
                    Label16.Text = "Error description: " & queryObj("ErrorDescription").ToString
                Catch ex16 As Exception
                    Label16.Text = "Error description: Not available."
                End Try

                Try
                    Label17.Text = "Ext. clock (Front Side Bus clock speed): " & queryObj("ExtClock").ToString
                Catch ex17 As Exception
                    Label17.Text = "Ext. clock (Front Side Bus clock speed): Not available."
                End Try

                Try
                    Label18.Text = "Family: " & queryObj("Family").ToString
                Catch ex18 As Exception
                    Label18.Text = "Family: Not available."
                End Try

                Try
                    Label19.Text = "Install date: " & queryObj("InstallDate").ToString
                Catch ex19 As Exception
                    Label19.Text = "Install date: Not available."
                End Try

                Try
                    Label20.Text = "L2 cache size: " & queryObj("L2CacheSize").ToString
                Catch ex20 As Exception
                    Label20.Text = "L2 cache size: Not available."
                End Try

                Try
                    Label21.Text = "L2 cache speed: " & queryObj("L2CacheSpeed").ToString
                Catch ex21 As Exception
                    Label21.Text = "L2 cache speed: Not available."
                End Try

                Try
                    Label22.Text = "L3 cache size: " & queryObj("L3CacheSize").ToString
                Catch ex22 As Exception
                    Label22.Text = "L3 cache size: Not available."
                End Try

                Try
                    Label23.Text = "L3 cache speed: " & queryObj("L3CacheSpeed").ToString
                Catch ex23 As Exception
                    Label23.Text = "L3 cache speed: Not available."
                End Try

                Try
                    Label24.Text = "Last error code: " & queryObj("LastErrorCode").ToString
                Catch ex24 As Exception
                    Label24.Text = "Last error code: Not available."
                End Try

                Try
                    Label25.Text = "Level: " & queryObj("Level").ToString
                Catch ex25 As Exception
                    Label25.Text = "Level: Not available."
                End Try

                Try
                    Label26.Text = "Load percentage: " & queryObj("LoadPercentage").ToString
                Catch ex26 As Exception
                    Label26.Text = "Load percentage: Not available."
                End Try

                Try
                    Label27.Text = "Manufacturer: " & queryObj("Manufacturer").ToString
                Catch ex27 As Exception
                    Label27.Text = "Manufacturer: Not available."
                End Try

                Try
                    Label28.Text = "Virtualization firmware enabled: " & queryObj("VirtualizationFirmwareEnabled").ToString
                Catch ex28 As Exception
                    Label28.Text = "Virtualization firmware enabled: Not available."
                End Try

                Try
                    Label29.Text = "Version: " & queryObj("Version").ToString
                Catch ex29 As Exception
                    Label29.Text = "Version: Not available."
                End Try

                Try
                    Label30.Text = "Upgrade method: " & queryObj("UpgradeMethod").ToString
                Catch ex30 As Exception
                    Label30.Text = "Upgrade method: Not available."
                End Try

                Try
                    Label31.Text = "Unique ID: " & queryObj("UniqueId").ToString
                Catch ex31 As Exception
                    Label31.Text = "Unique ID: Not available."
                End Try

                Try
                    Label32.Text = "System name: " & queryObj("SystemName").ToString
                Catch ex32 As Exception
                    Label32.Text = "System name: Not available."
                End Try

                Try
                    Label33.Text = "System creation class name: " & queryObj("SystemCreationClassName").ToString
                Catch ex33 As Exception
                    Label33.Text = "System creation class name: Not available."
                End Try

                Try
                    Label34.Text = "Stepping: " & queryObj("Stepping").ToString
                Catch ex34 As Exception
                    Label34.Text = "Stepping: Not available."
                End Try

                Try
                    Label35.Text = "Status info: " & queryObj("StatusInfo").ToString
                Catch ex35 As Exception
                    Label35.Text = "Status info: Not available."
                End Try

                Try
                    Label36.Text = "Socket designation: " & queryObj("SocketDesignation").ToString
                Catch ex36 As Exception
                    Label36.Text = "Socket designation: Not available."
                End Try

                Try
                    Label37.Text = "Second level address translations: " & queryObj("SecondLevelAddressTranslationExtensions").ToString
                Catch ex37 As Exception
                    Label37.Text = "Second level address translations: Not available."
                End Try

                Try
                    Label38.Text = "Role: " & queryObj("Role").ToString
                Catch ex38 As Exception
                    Label38.Text = "Role: Not available."
                End Try

                Try
                    Label39.Text = "Revision: " & queryObj("Revision").ToString
                Catch ex39 As Exception
                    Label39.Text = "Revision: Not available."
                End Try

                Try
                    Label40.Text = "Processor type: " & queryObj("ProcessorType").ToString
                Catch ex40 As Exception
                    Label40.Text = "Processor type: Not available."
                End Try

                Try
                    Label41.Text = "Processor ID: " & queryObj("ProcessorId").ToString
                Catch ex41 As Exception
                    Label41.Text = "Processor ID: Not available."
                End Try

                Try
                    Label42.Text = "Power management supported: " & queryObj("PowerManagementSupported").ToString
                Catch ex42 As Exception
                    Label42.Text = "Power management supported: Not available."
                End Try

                Try
                    Label43.Text = "PNP device ID: " & queryObj("PNPDeviceID").ToString
                Catch ex43 As Exception
                    Label43.Text = "PNP device ID: Not available."
                End Try

                Try
                    Label44.Text = "Other family description: " & queryObj("OtherFamilyDescription").ToString
                Catch ex44 As Exception
                    Label44.Text = "Other family description: Not available."
                End Try

                Try
                    Label45.Text = "Number of logical processors: " & queryObj("NumberOfLogicalProcessors").ToString
                Catch ex45 As Exception
                    Label45.Text = "Number of logical processors: Not available."
                End Try

                Try
                    Label46.Text = "Number of cores: " & queryObj("NumberOfCores").ToString
                Catch ex46 As Exception
                    Label46.Text = "Number of cores: Not available."
                End Try

                Try
                    Label47.Text = "Max clock speed: " & queryObj("MaxClockSpeed").ToString
                Catch ex47 As Exception
                    Label47.Text = "Max clock speed: Not available."
                End Try
            Next
        Catch ex As Exception
            MessageBox.Show("Oops! Something went wrong while trying to gather some of the information!" & vbNewLine & "This is the exception that was thrown: " & vbNewLine & ex.ToString, "DetectCPU", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WinFo.Show()
        Me.Hide()
    End Sub

End Class
