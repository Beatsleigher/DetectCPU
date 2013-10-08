Imports System.Management

Public Class HDDInfo

    ''' <summary>
    ''' Gets all info about hard disk (If available) from WMI and displays it via the labels.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub HDDInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_DiskDrive")

            For Each query As ManagementObject In searcher.Get()

                If Not CStr(query("Availability")) = Nothing Then
                    Label1.Text = "Hard Disk Availability: " & CStr(query("Availability"))
                Else
                    Label1.Text = "Hard Disk Availability: Information not available..."
                End If

                If Not CStr(query("BytesPerSector")) = Nothing Then
                    Label2.Text = "Bytes Per Sector: " & CStr(query("BytesPerSector"))
                Else
                    Label2.Text = "Bytes Per Sector: Information not available..."
                End If

                'If Not CStr(query("Capabilities")) = Nothing Then
                'Dim arrCap As UInt16()
                'arrCap = CType(query("Capabilities"), UShort())
                'For Each Array As UInt16 In arrCap
                'Label3.Text = "Capabilities: " & Array
                'Next
                '   Else
                Label3.Text = "Capabilities: Information not Available..."
                ' End If

                If query("CapabilityDescriptions") Is Nothing Then
                    Label4.Text = "Capability Descriptions: Information not Available..."
                Else
                    Dim arrCapabilityDescriptions As String()
                    arrCapabilityDescriptions = CType(query("CapabilityDescriptions"), String())
                    For Each arrValue As String In arrCapabilityDescriptions
                        Label4.Text = "Capability Descriptions: " & arrValue
                    Next
                End If

                If Not CStr(query("Caption")) = Nothing Then
                    Label5.Text = "Caption: " & CStr(query("Caption"))
                Else
                    Label5.Text = "Caption: Information Not Available..."
                End If

                If Not CStr(query("CompressionMethod")) = Nothing Then
                    Label6.Text = "Compression Method: " & CStr(query("CompressionMethod"))
                Else
                    Label6.Text = "Compression Method: Information not Available..."
                End If

                If Not CStr(query("ConfigManagerErrorCode")) = Nothing Then
                    Label7.Text = "Config Manager Error Code: " & CStr(query("ConfigManagerErrorCode"))
                Else
                    Label7.Text = "Config Manager Error Code: Information not Available..."
                End If

                If Not CStr(query("ConfigManagerUserConfig")) = Nothing Then
                    Label8.Text = "Config Manager User Config: " & CStr(query("ConfigManagerUserConfig"))
                Else
                    Label8.Text = "Config Manager User Config: Information not Available..."
                End If

                If Not CStr(query("CreationClassName")) = Nothing Then
                    Label9.Text = "Creation Class Name: " & CStr(query("CreationClassName"))
                Else
                    Label9.Text = "Creation Class Name: Information not Available..."
                End If

                If Not CStr(query("DefaultBlockSize")) = Nothing Then
                    Label10.Text = "Default Block Size: " & CStr(query("DefaultBlockSize"))
                Else
                    Label10.Text = "Default Block Size: Information not Available..."
                End If

                If Not CStr(query("Description")) = Nothing Then
                    Label11.Text = "Description: " & CStr(query("Description"))
                Else
                    Label11.Text = "Description: Information not Available..."
                End If

                If Not CStr(query("DeviceID")) = Nothing Then
                    Label12.Text = "Device ID: " & CStr(query("DeviceID"))
                Else
                    Label12.Text = "Device ID: Information not Available..."
                End If

                If Not CStr(query("ErrorCleared")) = Nothing Then
                    Label13.Text = "Error Cleared: " & CStr(query("ErrorCleared"))
                Else
                    Label13.Text = "Error Cleared: Information not Available..."
                End If

                If Not CStr(query("ErrorDescription")) = Nothing Then
                    Label14.Text = "Error Description: " & CStr(query("ErrorDescription"))
                Else
                    Label14.Text = "Error Description: Information not Available..."
                End If

                If Not CStr(query("ErrorMethodology")) = Nothing Then
                    Label15.Text = "Error Methodology: " & CStr(query("ErrorMethodology"))
                Else
                    Label15.Text = "Error Methodology: Information not Available..."
                End If

                If Not CStr(query("FirmwareRevision")) = Nothing Then
                    Label16.Text = "Firmware Revision: " & CStr(query("FirmwareRevision"))
                Else
                    Label16.Text = "Firmware Revision: Information not Available..."
                End If

                If Not CStr(query("Index")) = Nothing Then
                    Label17.Text = "Index: " & CStr(query("Index"))
                Else
                    Label17.Text = "Index: Information not Available..."
                End If

                If Not CStr(query("InstallDate")) = Nothing Then
                    Label18.Text = "Install Date: " & CStr(query("InstallDate"))
                Else
                    Label18.Text = "Install Date: Information not Available..."
                End If

                If Not CStr(query("InterfaceType")) = Nothing Then
                    Label19.Text = "Interface Type: " & CStr(query("InterfaceType"))
                Else
                    Label19.Text = "Interface Type: INformation not Available..."
                End If

                If Not CStr(query("LastErrorCode")) = Nothing Then
                    Label20.Text = "Last Error Code: " & CStr(query("LastErrorCode"))
                Else
                    Label20.Text = "Last Error Code: Information not Available..."
                End If

                If Not CStr(query("Manufacturer")) = Nothing Then
                    Label21.Text = "Manufacturer: " & CStr(query("Manufacturer"))
                Else
                    Label21.Text = "Manufacturer: Information not Available..."
                End If

                If Not CStr(query("MaxBlockSize")) = Nothing Then
                    Label22.Text = "Max Block Size: " & CStr(query("MaxBlockSize"))
                Else
                    Label22.Text = "Max Block Size: Information not Available..."
                End If

                If Not CStr(query("MaxMediaSize")) = Nothing Then
                    Label23.Text = "Max Media Size: " & CStr(query("MaxMediaSize"))
                Else
                    Label23.Text = "Max Media Size: Information not Available..."
                End If

                If Not CStr(query("MediaLoaded")) = Nothing Then
                    Label24.Text = "Media Loaded: " & CStr(query("MediaLoaded"))
                Else
                    Label24.Text = "Media Loaded: Information not Available..."
                End If

                If Not CStr(query("MediaType")) = Nothing Then
                    Label25.Text = "Media Type: " & CStr(query("MediaType"))
                Else
                    Label25.Text = "Media Type: Information not Available..."
                End If

                If Not CStr(query("MinBlockSize")) = Nothing Then
                    Label26.Text = "Min Block Size: " & CStr(query("MinBlockSize"))
                Else
                    Label26.Text = "Min Block Size: Information not Available..."
                End If

                If Not CStr(query("Model")) = Nothing Then
                    Label27.Text = "Model: " & CStr(query("Model"))
                Else
                    Label27.Text = "Model: Information not Available..."
                End If

                If Not CStr(query("Name")) = Nothing Then
                    Label28.Text = "Name: " & CStr(query("Name"))
                Else
                    Label28.Text = "Name: Information not Available..."
                End If

                If Not CStr(query("NeedsCleaning")) = Nothing Then
                    Label29.Text = "Needs Cleaning: " & CStr(query("NeedsCleaning"))
                Else
                    Label29.Text = "Needs Cleaning: Information not Available..."
                End If

                If Not CStr(query("NumberOfMediaSupported")) = Nothing Then
                    Label30.Text = "Number of Media Supported: " & CStr(query("NumberOfMediaSupported"))
                Else
                    Label30.Text = "Number of Media Supported: Information not Available..."
                End If

                If Not CStr(query("Partitions")) = Nothing Then
                    Label31.Text = "Partitions: " & CStr(query("Partitions"))
                Else
                    Label31.Text = "Partitions: Information not Available..."
                End If

                If Not CStr(query("PNPDeviceID")) = Nothing Then
                    Label32.Text = "PNP Device ID: " & CStr(query("PNPDeviceID"))
                Else
                    Label32.Text = "PNP Device ID: Information not Available..."
                End If

                If query("PowerManagementCapabilities") Is Nothing Then
                    Label32.Text = "Power Management Capabilities: Information not Available..."
                Else
                    Dim arr As UInt16()
                    arr = CType(query("PowerManagementCapabilities"), UShort())
                    For Each arrVal As UInt16 In arr
                        Label32.Text = "Power Management Capabilities: " & arrVal
                    Next
                End If

                If Not CStr(query("PowerManagementSupported")) = Nothing Then
                    Label33.Text = "PowerManagementSupported: " & CStr(query("PowerManagementSupported"))
                Else
                    Label33.Text = "Power Management Supported: Information not Available..."
                End If

                If Not CStr(query("SCSIBus")) = Nothing Then
                    Label34.Text = "SCSI Bus: " & CStr(query("SCSIBus"))
                Else
                    Label34.Text = "SCSI Bus: Information not Available..."
                End If

                If Not CStr(query("SCSILogicalUnit")) = Nothing Then
                    Label35.Text = "SCSI Logical Unit: " & CStr(query("SCSILogicalUnit"))
                Else
                    Label35.Text = "SCSI Logical Unit: Information not Available..."
                End If

                If Not CStr(query("SCSIPort")) = Nothing Then
                    Label36.Text = "SCSI Port: " & CStr(query("SCSIPort"))
                Else
                    Label36.Text = "SCSI Port: Information not Available..."
                End If

                If Not CStr(query("SCSITargetId")) = Nothing Then
                    Label37.Text = "SCSI Target ID: " & CStr(query("SCSITargetId"))
                Else
                    Label37.Text = "SCSI Target ID: Information not Available..."
                End If

                If Not CStr(query("SectorsPerTrack")) = Nothing Then
                    Label38.Text = "Sectors Per Track: " & CStr(query("SectorsPerTrack"))
                Else
                    Label38.Text = "Sectors Per Track: Information Unavailable..."
                End If

                If Not CStr(query("SerialNumber")) = Nothing Then
                    Label39.Text = "Serial Number: " & CStr(query("SerialNumber"))
                Else
                    Label39.Text = "Serial Number: Information not Available..."
                End If

                If Not CStr(query("Signature")) = Nothing Then
                    Label40.Text = "Signature: " & CStr(query("Signature"))
                Else
                    Label40.Text = "Signature: Information not Available..."
                End If

                If Not CStr(query("Size")) = Nothing Then
                    Dim size As String = CStr(query("Size"))
                    Dim size2 As Int64 = Int64.Parse(size)
                    Dim gb As Int64 = size2 \ 1024 \ 1024
                    Label41.Text = "Size: " & gb & "MB"
                Else
                    Label41.Text = "Size: Information not Available..."
                End If

                If Not CStr(query("Status")) = Nothing Then
                    Label42.Text = "Status: " & CStr(query("Status"))
                Else
                    Label42.Text = "Status: Information not Available..."
                End If

                If Not CStr(query("StatusInfo")) = Nothing Then
                    Label43.Text = "Status Info: " & CStr(query("StatusInfo"))
                Else
                    Label43.Text = "Status Info: Information not Available..."
                End If

                If Not CStr(query("SystemCreationClassName")) = Nothing Then
                    Label44.Text = "System Creation Class Name: " & CStr(query("SystemCreationClassName"))
                Else
                    Label44.Text = "System Creation Class Name: Information not Available..."
                End If

                If Not CStr(query("SystemName")) = Nothing Then
                    Label45.Text = "System Name: " & CStr(query("SystemName"))
                Else
                    Label45.Text = "System Name: Information not Available..."
                End If

                If Not CStr(query("TotalCylinders")) = Nothing Then
                    Label46.Text = "Total Cylinders: " & CStr(query("TotalCylinders"))
                Else
                    Label46.Text = "Total Cylinders: Information not Available..."
                End If

                If Not CStr(query("TotalHeads")) = Nothing Then
                    Label47.Text = "Total Heads: " & CStr(query("TotalHeads"))
                Else
                    Label47.Text = "Total Heads: Information not Available..."
                End If

                If Not CStr(query("TotalSectors")) = Nothing Then
                    Label48.Text = "Total Sectors: " & CStr(query("TotalSectors"))
                Else
                    Label48.Text = "Total Sectors: Information not Available..."
                End If

                If Not CStr(query("TotalTracks")) = Nothing Then
                    Label49.Text = "Total Tracks: " & CStr(query("TotalTracks"))
                Else
                    Label49.Text = "Total Tracks: Information not Available..."
                End If

                If Not CStr(query("TracksPerCylinder")) = Nothing Then
                    Label50.Text = "Tracks per Cylinder: " & CStr(query("TracksPerCylinder"))
                Else
                    Label50.Text = "Tracks per Cylinder: Information not Available..."
                End If

            Next
        Catch ex As Exception
            MessageBox.Show("Oops! There was an error while trying to fetch the requested information! Please try again!", "DetectCPU - HDD Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class