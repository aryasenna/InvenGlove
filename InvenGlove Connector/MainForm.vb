'InvenGlove Connector

'PC Connector for "InvenGlove" wireless data glove, a wearable virtual assembling tools.
'InvenGlove and Autodesk Inventor is required
'Written by Arya Senna
'Finalised on 16 Jun 2014
'V1.0.1
'Licensed under GNU GPL License v3
'--
'Part of Joint Capstone Project - Mechanical Engineering Department of Universitas Indonesia
'Arya Senna and Albert Koto
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports InvenGlove.InvenGlove
Imports Inventor
Imports System.IO
Imports Microsoft.Office.Interop.PowerPoint
Imports Path = System.IO.Path

Public Class MainForm

#Region "Form initialization"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _inventorApi = New InventorAPI(Me)
        _inventorApi = New InventorAPI(Me)
        _invenGlovePpt = New InvenGlovePPT(Me)
        _inventorConnect = New InventorConnect(Me)
        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

#Region "Serial Communication"

    Friend comm As New CommManager()
    Private transType As String = String.Empty

    Protected Friend ReadOnly Property InvenGlovePpt() As InvenGlovePPT
        Get
            Return _invenGlovePpt
        End Get
    End Property


    Private Sub cboPort_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboPort.SelectedIndexChanged
        comm.PortName = cboPort.Text()
    End Sub


    ''' <summary>
    '''     Method to initialize serial port
    '''     values to standard defaults
    ''' </summary>
    Private Sub SetDefaults()
        cboPort.SelectedIndex = 0
        cboBaud.SelectedText = "115200"
        cboParity.SelectedIndex = 0
        cboStop.SelectedIndex = 1
        cboData.SelectedIndex = 1
    End Sub


    ''' <summary>
    '''     methods to load our serial
    '''     port option values
    ''' </summary>
    Private Sub LoadValues()
        comm.SetPortNameValues(cboPort)
        comm.SetParityValues(cboParity)
        comm.SetStopBitValues(cboStop)
    End Sub


    ''' <summary>
    '''     method to set the state of controls
    '''     when the form first loads
    ''' </summary>

    Private Sub SetControlState()
        rdoText.Checked = True
        cmdSend.Enabled = False
        cmdClose.Enabled = False
    End Sub


    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClose.Click
        CheckBoxConnect.Checked = False
        comm.ClosePort()
        SetControlState()
        'SetDefaults()
        cmdOpen.Enabled = True
        CheckBoxViewOutput.Enabled = True
        CheckBoxConnect.Enabled = False
    End Sub

    Private Sub cmdOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdOpen.Click
        comm.Parity = cboParity.Text
        comm.StopBits = cboStop.Text
        comm.DataBits = cboData.Text
        comm.BaudRate = cboBaud.Text
        comm.ShowSerial = CheckBoxViewOutput.Checked
        comm.DisplayWindow = rtbDisplay
        comm.OpenPort()

        CheckBoxViewOutput.Enabled = False
        cmdOpen.Enabled = False
        cmdClose.Enabled = True
        cmdSend.Enabled = True
        CheckBoxConnect.Enabled = True
    End Sub

    Private Sub cmdSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSend.Click
        comm.Message = txtSend.Text
        comm.Type = CommManager.MessageType.Normal
        comm.WriteData(txtSend.Text)
        txtSend.Text = String.Empty
        txtSend.Focus()
    End Sub

    Private Sub rdoHex_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdoHex.CheckedChanged
        If rdoHex.Checked() Then
            comm.CurrentTransmissionType = CommManager.TransmissionType.Hex
        Else
            comm.CurrentTransmissionType = CommManager.TransmissionType.Text
        End If
    End Sub

    Private Sub cboBaud_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboBaud.SelectedIndexChanged
        comm.BaudRate = cboBaud.Text()
    End Sub

    Private Sub cboParity_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboParity.SelectedIndexChanged
        comm.Parity = cboParity.Text()
    End Sub

    Private Sub cboStop_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboStop.SelectedIndexChanged
        comm.StopBits = cboStop.Text()
    End Sub

    Private Sub cboData_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboData.SelectedIndexChanged
        comm.StopBits = cboStop.Text()
    End Sub

#End Region

#Region "Inventor Object Initialization"

    Protected Friend appInventor As Inventor.Application
    Protected Friend oCamera As Camera
    Protected Friend oTG As TransientGeometry

    ' active part document. 
    Protected Friend partDoc As PartDocument
    Protected Friend partDef As PartComponentDefinition

    'active assembly document
    Protected Friend assyDoc As AssemblyDocument

    Protected Friend assyDef As AssemblyComponentDefinition


    ' Have the user select a body. 
    Protected Friend body As SurfaceBody
    Protected Friend selOccurrence As ComponentOccurrence

    Protected Friend stopClick As Boolean = False


    Protected Friend screenX As Vector
    Protected Friend screenY As Vector
    Protected Friend screenZ As Vector


    'Bonus

    Dim oPP As Inventor.Application
    Dim value As PresentationDocument

#End Region

#Region "GUI Inventor View & Doc Handling"


    Private Sub ButtonFrontPlane_Click(sender As Object, e As EventArgs) Handles ButtonFrontPlane.Click
        InventorApi.SetFrontPlane()
        InventorApi.ZoomFixed(TextBoxHZoom.Text, TextBoxWZoom.Text)
    End Sub

    'Import win32 API in order to corectly switch window focus to inventor
    Friend NotInheritable Class UnsafeNativeMethods
        Private Sub New()
        End Sub

        <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)>
        Friend Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As Boolean
        End Function

        Friend Shared Function SetFocus(ByVal hWnd As IntPtr) As Boolean
        End Function


        'findwindowbyexe - because we can't reliably find Inventor by Windows title.. different open document, different version, different license type

        Friend Shared Function FindWindowByExe(ByVal Filename As String) As IntPtr
            Filename = Path.GetFileNameWithoutExtension(Filename)
            Dim procList() As Process = Process.GetProcesses
            For Each p As Process In procList
                If p.ProcessName.ToLower = Filename.ToLower Then
                    Return p.MainWindowHandle
                End If
            Next
            Return IntPtr.Zero
        End Function
    End Class

#End Region

#Region "GUI Rotation Operation "

    Private Sub left_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrowLeft.Click
        InventorApi.ChangeView(TextboxIncRot.Value, 0, 0)
    End Sub

    Private Sub up_Click(ByVal sender As Object, ByVal e As EventArgs) Handles up.Click
        InventorApi.ChangeView(0, TextboxIncRot.Value, 0)
    End Sub

    Private Sub right_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrowRight.Click
        InventorApi.ChangeView(-TextboxIncRot.Value, 0, 0)
    End Sub

    Private Sub down_Click(ByVal sender As Object, ByVal e As EventArgs) Handles down.Click
        InventorApi.ChangeView(0, -TextboxIncRot.Value, 0)
    End Sub

    Private Sub rotate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rotate.Click
        InventorApi.CheckOpenDocument()
        Try
            appInventor = Marshal.GetActiveObject("Inventor.Application")

            appInventor.ActiveView.GoHome()
        Catch
            MsgBox("Unable to set home")
        End Try
    End Sub

    Private Sub buttonRotateX_Click(sender As Object, e As EventArgs) Handles ButtonRotateX.Click

        InventorApi.ChangeView(1.57, 0, 0)
    End Sub

    Private Sub buttonRotateY_Click(sender As Object, e As EventArgs) Handles buttonRotateY.Click

        InventorApi.ChangeView(0, 1.57, 0)
    End Sub

    Private Sub buttonRotateZ_Click(sender As Object, e As EventArgs) Handles ButtonRotateZ.Click

        InventorApi.ChangeView(0, 0, 1.57)
    End Sub

    Private Sub buttonRotbyVal_Click(sender As Object, e As EventArgs) Handles ButtonRotbyVal.Click

        InventorApi.ChangeView(inputX.Text, InputY.Text, InputZ.Text)
    End Sub


#End Region

#Region "GUI Translation Operation "


    Private Sub ButtonDelAllMoves_Click(sender As Object, e As EventArgs) Handles ButtonDelAllMoves.Click
        Try

            If InventorApi.CheckOpenDocument() = 1 Then

                'ask for confirmation first since deleting a lot of moves feature could become very slow and might cause Inventor to hang,
                Dim result =
                        MessageBox.Show(
                            "Are you sure you want to delete ALL MoveBody operation? Depending on the number of MoveBody operations, this process could take a long time to complete. ",
                            "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then


                    ' Create a move definition. 
                    partDoc = appInventor.ActiveDocument

                    partDef = partDoc.ComponentDefinition
                    ' Dim moveDef As Inventor.MoveDefinition


                    Dim moveItem As MoveFeature

                    For Each moveItem In partDef.Features.MoveFeatures
                        moveItem.Delete()
                    Next


                End If
            ElseIf InventorApi.CheckOpenDocument() = 2 Then

                MsgBox(
                    "Delete MoveBody operation is not applicable to Assembly document. Please use the Undo button on Inventor")
            End If

        Catch ex As Exception
            TextboxDebug.Text = ex.ToString()
            ' MsgBox(ex.Message)
            MsgBox("Unable to delete moves operation")

        End Try
    End Sub


    Private Sub ButtonTranslate_Click(sender As Object, e As EventArgs) Handles ButtonTranslate.Click
        InventorApi.MoveBody(TextBoxMoveX.Text, TextBoxMoveY.Text, TextBoxMoveZ.Text)
    End Sub


    Private Sub ButtonMoveUp_Click(sender As Object, e As EventArgs) Handles ButtonMoveUp.Click
        InventorApi.MoveBody(0, TextboxIncTrans.Value, 0)
    End Sub

    Private Sub ButtonMoveLeft_Click(sender As Object, e As EventArgs) Handles ButtonMoveLeft.Click
        InventorApi.MoveBody(-TextboxIncTrans.Value, 0, 0)
    End Sub

    Private Sub ButtonMoveZup_Click(sender As Object, e As EventArgs) Handles ButtonMoveZup.Click
        InventorApi.MoveBody(0, 0, -TextboxIncTrans.Value)
    End Sub

    Private Sub ButtonMoveRight_Click(sender As Object, e As EventArgs) Handles ButtonMoveRight.Click
        InventorApi.MoveBody(0, 0, TextboxIncTrans.Value)
    End Sub

    Private Sub ButtonMoveZdown_Click(sender As Object, e As EventArgs) Handles ButtonMoveZdown.Click
        InventorApi.MoveBody(TextboxIncTrans.Value, 0, 0)
    End Sub

    Private Sub ButtonMoveDown_Click(sender As Object, e As EventArgs) Handles ButtonMoveDown.Click
        InventorApi.MoveBody(0, -TextboxIncTrans.Value, 0)
    End Sub


#End Region

#Region "GUI Connect"


    'Threading. UI will remain responsive while the task is running

    'BG worker

    Private Sub BackgroundWorkerConnect_DoWork(
                                               ByVal sender As Object,
                                               ByVal e As DoWorkEventArgs
                                               ) Handles BackgroundWorkerConnect.DoWork

        InventorConnect.Connect()
    End Sub


    Private Sub CheckBoxConnect_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConnect.CheckedChanged
        Try
            If CheckBoxConnect.Checked = True Then
                GroupBoxAct.Enabled = True
                GroupBoxConstrain.Enabled = True

                BackgroundWorkerConnect.RunWorkerAsync()

                'switch to information tab
                TabPres.SelectTab(TabInfo)

            ElseIf CheckBoxConnect.Checked = False Then

                GroupBoxAct.Enabled = False
                GroupBoxConstrain.Enabled = False


                BackgroundWorkerConnect.CancelAsync()

            End If
        Catch ex As Exception
            TextboxDebug.Text = ex.ToString()
        End Try
    End Sub


#End Region

#Region "GUI Zoom Operation"


    Private Sub ButtonZoom_Click(sender As Object, e As EventArgs) Handles ButtonZoom.Click

        InventorApi.ZoomFixed(TextBoxHZoom.Text, TextBoxWZoom.Text)
    End Sub


    Private Sub ButtonZoomIn_Click(sender As Object, e As EventArgs) Handles ButtonZoomIn.Click

        InventorApi.Zoom(-1 * TextBoxZoomInc.Text, -1 * TextBoxZoomInc.Text)
    End Sub

    Private Sub ButtonZoomOut_Click(sender As Object, e As EventArgs) Handles ButtonZoomOut.Click
        InventorApi.Zoom(TextBoxZoomInc.Text, TextBoxZoomInc.Text)
    End Sub

#End Region

#Region "GUI Interactions & Controls "

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Try
            appInventor = Marshal.GetActiveObject("Inventor.Application")

        Catch ex As Exception
            TextboxDebug.Text = ex.ToString()

            MsgBox("Inventor must be opened first!")
            System.Windows.Forms.Application.Exit()
        End Try

        InventorApi.CheckOpenDocument()
        LoadValues()
        SetDefaults()

        'CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BackgroundWorkerConnect.CancelAsync()
        BackgroundWorkerPPT.CancelAsync()
        comm.ClosePort()
        comm.Dispose()
    End Sub

    Private Sub LabelAbout_Click(sender As Object, e As EventArgs) Handles LabelAbout.Click
    End Sub

    Private Sub LinkProto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
        Handles LinkProto.LinkClicked
        Call ToolTipProto.Show("Expect a lot of things to be not working! ", LinkProto)
    End Sub


    Private Sub ButtonSelBody_Click(sender As Object, e As EventArgs) Handles ButtonSelBody.Click
        InventorApi.SelectObject()


        ' Bring back focus

        Me.Activate()

        ' Update doc info
        TextBoxFileName.Text = InventorApi.GetDocName()
        TextBoxSelPart.Text = InventorApi.GetSelPartName()
    End Sub

    Private Sub TabInfo_Enter(sender As Object, e As EventArgs) Handles TabInfo.Enter

        If Not GaugeYaw.IsHandleCreated Then


            'Load Gauge only if tab is selected.
            GroupBoxEuler.Controls.Add(GaugePitch)
            GroupBoxEuler.Controls.Add(GaugeYaw)
            GroupBoxEuler.Controls.Add(GaugeRoll)
        End If
    End Sub

#End Region

#Region "Bonus"

    Private Sub PicAct_DoubleClick(sender As Object, e As EventArgs) Handles PicAct.DoubleClick
        If Not tabPPT.IsHandleCreated Then
            Me.TabPres.Controls.Add(Me.tabPPT)
        End If
    End Sub



    Private Sub focusAndSendKey(ByVal exeName As String, ByVal key As String)
        Dim hWnd As IntPtr = UnsafeNativeMethods.FindWindowByExe(exeName)
        If Not hWnd = IntPtr.Zero Then ' found


            UnsafeNativeMethods.SetForegroundWindow(hWnd) ' bring to foreground
        End If
        ' Send the keystrokes 
        My.Computer.Keyboard.SendKeys(key, True)

    End Sub

    Private Sub ButtonUp_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click
        focusAndSendKey("POWERPNT.EXE", "{UP}")
        Me.Activate()

    End Sub

    Private Sub ButtonDown_Click(sender As Object, e As EventArgs) Handles ButtonDown.Click
        focusAndSendKey("POWERPNT.EXE", "{DOWN}")
    End Sub

    Private Sub ButtonLeft_Click(sender As Object, e As EventArgs) Handles ButtonLeft.Click
        focusAndSendKey("POWERPNT.EXE", "{LEFT}")
    End Sub

    Private Sub ButtonRight_Click(sender As Object, e As EventArgs) Handles ButtonRight.Click
        focusAndSendKey("POWERPNT.EXE", "{RIGHT}")
    End Sub


    ' Define PowerPoint Application object



    ' Define PowerPoint Application object


    Public pptApplication As Microsoft.Office.Interop.PowerPoint.Application
    ' Define Presentation object
    Public presentation As Presentation
    ' Define Slide collection
    Public slides As Slides
    Public slide As Slide

    ' Slide count
    Public slidescount As Integer
    ' slide index
    Public slideIndex As Integer
#End Region

End Class

