Imports System.Management
Imports System.Configuration
Public Class WinFo

    Private Sub WinFo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBaseBoard_Motherboard_Info()
        Load_BIOS_Info()
        Load_BootConfig()
        Load_ComputerSystem_Info()
    End Sub

    Private Sub WinFo_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

    End Sub

#Region "Baseboard/Motherboard"
    Public Sub LoadBaseBoard_Motherboard_Info()
        Dim Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BaseBoard")
        For Each Obj As ManagementObject In Searcher.Get()
            If Not IsNothing(CStr(Obj("Caption"))) Then
                Label1.Text = "Baseboard caption: " & Obj("Caption").ToString
            Else
                Label1.Text = "Basboard caption is not available."
            End If
            '###
            Try
                If Not IsNothing(CStr(Obj("ConfigurationOptions"))) Then
                    Label2.Text = "Baseboard configuration options: " & Obj("ConfigurationOptions").ToString
                Else
                    Label2.Text = "Baseboard configuration options are not available."
                End If
            Catch ex1 As Exception
                Label2.Text = "Baseboard configuration options are not available."
            End Try
            '###
            If Not IsNothing(CStr(Obj("CreationClassName"))) Then
                Label3.Text = "Baseboard creation class name: " & Obj("CreationClassName").ToString
            Else
                Label3.Text = "Baseboard creation class name is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("Depth"))) Then
                Label4.Text = "Baseboard depth: " & Obj("Depth").ToString
            Else
                Label4.Text = "Baseboard depth is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("Description"))) Then
                Label5.Text = "Baseboard description: " & Obj("Description").ToString
            Else
                Label5.Text = "Baseboard description is not available."
            End If
            If Not IsNothing(CStr(Obj("Height"))) Then
                Label6.Text = "Baseboard height: " & Obj("Height").ToString
            Else
                Label6.Text = "Baseboard height is not available"
            End If
            '###
            If Not IsNothing(CStr(Obj("HostingBoard"))) Then
                Label7.Text = "Baseboard is hosting board: " & Obj("HostingBoard").ToString
            Else
                Label7.Text = "Cannot determine whether baseboard is hosting board."
            End If
            '###
            If Not IsNothing(CStr(Obj("HotSwappable"))) Then
                Label8.Text = "Baseboard is hot swappable: " & Obj("HotSwappable").ToString
            Else
                Label8.Text = "Cannot determine if baseboard is hot swappable"
            End If
            '###
            If Not IsNothing(CStr(Obj("InstallDate"))) Then
                Label9.Text = "Baseboard install date: " & Obj("InstallDate").ToString
            Else
                Label9.Text = "Baseboard install date is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("Manufacturer"))) Then
                Label10.Text = "Baseboard manufacturer: " & Obj("Manufacturer").ToString
            Else
                Label10.Text = "Baseboard manufacturer can not be determined."
            End If
            '###
            If Not IsNothing(CStr(Obj("Model"))) Then
                Label11.Text = "Baseboard model: " & Obj("Model").ToString
            Else
                Label11.Text = "Baseboard model is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("Name"))) Then
                Label12.Text = "Baseboard name: " & Obj("Name").ToString
            Else
                Label12.Text = "Baseboard name is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("OtherIdentifyingInfo"))) Then
                Label13.Text = "Other identifying information: " & Obj("OtherIdentifyingInfo").ToString
            Else
                Label13.Text = "Other identifying information could not be found."
            End If
            '###
            If Not IsNothing(CStr(Obj("PartNumber"))) Then
                Label14.Text = "Baseboard part number: " & Obj("PartNumber").ToString
            Else
                Label14.Text = "Baseboard part number is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("PoweredOn"))) Then
                Label15.Text = "Baseboard is powered on: " & Obj("PoweredOn").ToString
            Else
                Label15.Text = "Could not detect if baseboard is powered on."
            End If
            '###
            If Not IsNothing(CStr(Obj("Product"))) Then
                Label16.Text = "Baseboard product: " & Obj("Product").ToString
            Else
                Label16.Text = "Baseboard product is not available."
            End If
            '###
            Try
                If Not IsNothing(CStr(Obj("Removeable"))) Then
                    Label17.Text = "Baseboard is removeable: " & Obj("Removeable").ToString
                Else
                    Label17.Text = "Could not determine if baseboard is removeable."
                End If
            Catch ex2 As Exception
                Label17.Text = "Could not determine if baseboard is removeable."
            End Try
            '###
            If Not IsNothing(CStr(Obj("Replaceable"))) Then
                Label18.Text = "Baseboard is replaceable: " & Obj("Replaceable").ToString
            Else
                Label18.Text = "Could not determine if baseboard is replaceable."
            End If
            '###
            If Not IsNothing(CStr(Obj("RequirementsDescription"))) Then
                Label19.Text = "Baseboard requirements description: " & Obj("RequirementsDescription").ToString
            Else
                Label19.Text = "Baseboard requirements descriptions are not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("RequiresDaughterBoard"))) Then
                Label20.Text = "Baseboard requires daughter-board: " & Obj("RequiresDaughterBoard").ToString
            Else
                Label20.Text = "Could not determine if baseboard requires daughter-board."
            End If
            '###
            If Not IsNothing(CStr(Obj("SerialNumber"))) Then
                Label21.Text = "Baseboard serial number: " & Obj("SerialNumber").ToString
            Else
                Label21.Text = "Baseboard serial number is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("SKU"))) Then
                Label22.Text = "Baseboard SKU: " & Obj("SKU").ToString
            Else
                Label22.Text = "Baseboard SKU could not be determined."
            End If
            '###
            If Not IsNothing(CStr(Obj("SlotLayout"))) Then
                Label23.Text = "Slot layout: " & Obj("SlotLayout").ToString
            Else
                Label23.Text = "Slot layout could not be determined."
            End If
            '###
            If Not IsNothing(CStr(Obj("SpecialRequirements"))) Then
                Label24.Text = "Special requirements: " & Obj("SpecialRequirements").ToString
            Else
                Label24.Text = "Could not determine special requirements."
            End If
            '###
            If Not IsNothing(CStr(Obj("Status"))) Then
                Label25.Text = "Baseboard status: " & Obj("Status").ToString
            Else
                Label25.Text = "Baseboard status is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("Tag"))) Then
                Label26.Text = "Baseboard tag: " & Obj("Tag").ToString
            Else
                Label26.Text = "Baseboard tag is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("Version"))) Then
                Label27.Text = "Baseboard version: " & Obj("Version").ToString
            Else
                Label27.Text = "Baseboard version is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("Weight"))) Then
                Label28.Text = "Baseboard weight: " & Obj("Weight").ToString
            Else
                Label28.Text = "Baseboard weight is not available."
            End If
            '###
            If Not IsNothing(CStr(Obj("Width"))) Then
                Label30.Text = "Baseboard width: " & Obj("Width").ToString
            Else
                Label30.Text = "Baseboard width is not available."
            End If
            '###
        Next
    End Sub
#End Region

#Region "BIOS"
    Public Sub Load_BIOS_Info()
        Dim Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BIOS")
        For Each Query As ManagementObject In Searcher.Get()
            BIOS1.Text = "BIOS version:" & CStr(Query("Version"))
            BIOS2.Text = "Current language: " & CStr(Query("CurrentLanguage"))
            BIOS3.Text = "BIOS description/version" & CStr(Query("Description"))
            BIOS4.Text = "Installable languages: " & CStr(Query("InstallableLanguages"))
            BIOS5.Text = "BIOS' manufacturer" & CStr(Query("Manufacturer"))
            BIOS6.Text = "Is primary BIOS: " & CStr(Query("PrimaryBIOS"))
            BIOS7.Text = "Release date: " & CStr(Query("ReleaseDate"))
            BIOS8.Text = "BIOS' serial number: " & CStr(Query("SerialNumber"))
            BIOS9.Text = "BIOS status: " & CStr(Query("Status"))
        Next
    End Sub
#End Region

#Region "Boot config"
    Public Sub Load_BootConfig()
        Dim Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_BootConfiguration")
        For Each Query As ManagementObject In Searcher.Get()
            Boot1.Text = "Boot directory: " & CStr(Query("BootDirectory"))
            Boot2.Text = "Configuration path: " & CStr(Query("ConfigurationPath"))
            Boot3.Text = "Scratch directory: " & vbNewLine & CStr(Query("ScratchDirectory"))
            Boot4.Text = "Temporary directory: " & vbNewLine & CStr(Query("TempDirectory"))
        Next
    End Sub
#End Region

#Region "Computer System"
    Public Sub Load_ComputerSystem_Info()
        Dim Searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_ComputerSystem")
        For Each Query As ManagementObject In Searcher.Get()
            Comp1.Text = "Automatic managed pagefile/s: " & CStr(Query("AutomaticManagedPagefile"))
            Comp2.Text = "Automatic reset boot option: " & CStr(Query("AutomaticResetBootOption"))
            Comp3.Text = "Automatic reset capability: " & CStr(Query("AutomaticResetCapability"))
            Comp4.Text = "Boot-ROM supported: " & CStr(Query("BootROMSupported"))
            Comp5.Text = "Bootup-state: " & CStr(Query("BootupState"))
            Comp6.Text = "Chassis bootup-state: " & CStr(Query("ChassisBootupState"))
            Comp7.Text = "Creation class name: " & CStr(Query("CreationClassName"))
            Comp8.Text = "Current timezone: " & CStr(Query("CurrentTimeZone"))
            Comp9.Text = "Description: " & CStr(Query("Description"))
            Comp10.Text = "Domain name: " & CStr(Query("Domain"))
            Comp11.Text = "Enable daylight savings time: " & CStr(Query("EnableDaylightSavingsTime"))
            Comp12.Text = "Front panel reset status: " & CStr(Query("FrontPanelResetStatus"))
            Comp13.Text = "Infrared supported: " & CStr(Query("InfraredSupported"))
            Comp14.Text = "Manufacturer: " & CStr(Query("Manufacturer"))
            Comp15.Text = "Model: " & CStr(Query("Model"))
            Comp16.Text = "Network server mode enabled: " & CStr(Query("NetworkServerModeEnabled"))
            Comp17.Text = "Part of domain: " & CStr(Query("PartOfDomain"))
            Comp18.Text = "Primary owner's name: " & CStr(Query("PrimaryOwnerName"))
            Comp19.Text = "Roles: " & Query("Roles").ToString
            Comp20.Text = "Status: " & CStr(Query("Status"))
            Comp21.Text = "System type: " & CStr(Query("SystemType"))
            Dim TotalMemory As Long = CLng(Query("TotalPhysicalMemory"))
            Comp22.Text = "Total physical memory: " & TotalMemory \ 1024 \ 1024 & "MB"
            Comp23.Text = "Current username: " & CStr(Query("Username"))
        Next
    End Sub
#End Region

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoadBaseBoard_Motherboard_Info()
        Load_BIOS_Info()
        Load_BootConfig()
        Load_ComputerSystem_Info()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        HDDInfo.Show()
    End Sub
End Class