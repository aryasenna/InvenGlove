' InvenGlovePPT Class
' Experimental PPT slide control

'Written by Arya Senna
'Finalised on 16 Jun 2014
'V1.0.1
'Licensed under GNU GPL License v3
'--


Imports System.Runtime.InteropServices
Imports System.IO

Namespace InvenGlove
    Public Class InvenGlovePPT
        Private _mainForm As MainForm

        Sub New(ByVal mainForm1 As MainForm)
            _mainForm = mainForm1
        End Sub

        Public Sub focusAndSendKey(ByVal exeName As String, ByVal key As String)
            Dim hWnd As IntPtr = MainForm.UnsafeNativeMethods.FindWindowByExe(exeName)
            If Not hWnd = IntPtr.Zero Then ' found


                MainForm.UnsafeNativeMethods.SetForegroundWindow(hWnd) ' bring to foreground
            End If
            ' Send the keystrokes 
            My.Computer.Keyboard.SendKeys(key, True)

        End Sub



        Public Sub SelectPPT()

            Try

                Try
                    ' Get Running PowerPoint Application object 
                    _mainForm.pptApplication = TryCast(Marshal.GetActiveObject("PowerPoint.Application"), Microsoft.Office.Interop.PowerPoint.Application)
                Catch
                    MessageBox.Show("Please Run PowerPoint First", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
                If _mainForm.pptApplication IsNot Nothing Then


                    ' Get Presentation Object 
                    _mainForm.presentation = _mainForm.pptApplication.ActivePresentation
                    ' Get Slide collection object 
                    _mainForm.slides = _mainForm.presentation.Slides
                    ' Update file name
                    _mainForm.TextBoxFileName.Text = _mainForm.presentation.Name
                    ' Get Slide count 
                    _mainForm.slidescount = _mainForm.slides.Count
                    'enable buttons
                    _mainForm.GroupBoxSlidesCtrl.Enabled = True
                    ' Get current selected slide  
                    Try
                        ' Get selected slide object in normal view 
                        _mainForm.slide = _mainForm.slides(_mainForm.pptApplication.ActiveWindow.Selection.SlideRange.SlideNumber)
                    Catch



                        ' Get selected slide object in reading view 
                        _mainForm.slide = _mainForm.pptApplication.SlideShowWindows(1).View.Slide

                    End Try
                End If
                'update slide name
                _mainForm.TextBoxSelPart.Invoke(Sub() _mainForm.TextBoxSelPart.Text = "Slide " + _mainForm.slide.SlideIndex.ToString())
            Catch ex As Exception
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())


            End Try


        End Sub

        Public Sub NextSlide()
            Try
                _mainForm.slideIndex = _mainForm.slide.SlideIndex + 1
                If _mainForm.slideIndex > _mainForm.slidescount Then
                    ' MessageBox.Show("It is already last page")
                Else
                    Try
                        _mainForm.slide = _mainForm.slides(_mainForm.slideIndex)
                        _mainForm.slides(_mainForm.slideIndex).[Select]()
                    Catch
                        _mainForm.pptApplication.SlideShowWindows(1).View.[Next]()
                        _mainForm.slide = _mainForm.pptApplication.SlideShowWindows(1).View.Slide
                    End Try
                End If
                'update slide name
                _mainForm.TextBoxSelPart.Invoke(Sub() _mainForm.TextBoxSelPart.Text = "Slide " + _mainForm.slide.SlideIndex.ToString())
            Catch ex As Exception
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())


            End Try
        End Sub

        Public Sub PrevSlide()
            Try
                _mainForm.slideIndex = _mainForm.slide.SlideIndex - 1
                If _mainForm.slideIndex >= 1 Then
                    Try
                        _mainForm.slide = _mainForm.slides(_mainForm.slideIndex)
                        _mainForm.slides(_mainForm.slideIndex).[Select]()
                    Catch
                        _mainForm.pptApplication.SlideShowWindows(1).View.Previous()
                        _mainForm.slide = _mainForm.pptApplication.SlideShowWindows(1).View.Slide
                    End Try
                Else
                    'MessageBox.Show("It is already Fist Page")
                End If
                'update slide name
                _mainForm.TextBoxSelPart.Invoke(Sub() _mainForm.TextBoxSelPart.Text = "Slide " + _mainForm.slide.SlideIndex.ToString())
            Catch ex As Exception
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())


            End Try
        End Sub

        Public Sub FirstSlide()
            Try
                Try
                    ' Call Select method to select first slide in normal view
                    _mainForm.slides(1).[Select]()
                    _mainForm.slide = _mainForm.slides(1)
                Catch
                    ' Transform to first page in reading view
                    _mainForm.pptApplication.SlideShowWindows(1).View.First()
                    _mainForm.slide = _mainForm.pptApplication.SlideShowWindows(1).View.Slide

                End Try
                'update slide name
                _mainForm.TextBoxSelPart.Invoke(Sub() _mainForm.TextBoxSelPart.Text = "Slide " + _mainForm.slide.SlideIndex.ToString())
            Catch ex As Exception
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())

            End Try
        End Sub

        Public Sub LastSlide()
            Try

                Try
                    _mainForm.slides(_mainForm.slidescount).[Select]()
                    _mainForm.slide = _mainForm.slides(_mainForm.slidescount)
                Catch
                    _mainForm.pptApplication.SlideShowWindows(1).View.Last()
                    _mainForm.slide = _mainForm.pptApplication.SlideShowWindows(1).View.Slide
                End Try
                'update slide name
                _mainForm.TextBoxSelPart.Invoke(Sub() _mainForm.TextBoxSelPart.Text = "Slide " + _mainForm.slide.SlideIndex.ToString())
            Catch ex As Exception
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())

            End Try

        End Sub

        Public Sub StartPres()
            Try
                If _mainForm.pptApplication.SlideShowWindows.Count < 1 Then


                    _mainForm.presentation.SlideShowSettings.Run()
                    _mainForm.Activate()
                End If
            Catch ex As Exception
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())

            End Try
        End Sub

        Public Sub StopPres()
            Try
                If _mainForm.pptApplication.SlideShowWindows.Count > 0 Then


                    _mainForm.presentation.SlideShowWindow.View.Exit()
                    _mainForm.Activate()
                End If
            Catch ex As Exception
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())

            End Try
        End Sub



        Public Sub ConnectPPT()



            Dim CurrentEuler As String()
            Dim FullComma As Integer
            Dim ParsedEulerX As Double = 0
            Dim ParsedEulerY As Double = 0
            Dim ParsedEulerZ As Double = 0
            Dim EulerX As Double = 0
            Dim EulerY As Double = 0
            Dim EulerZ As Double = 0
            Dim isUpward As Boolean
            Dim isClosed As Boolean
            Dim isHalf As Boolean
            Dim isTwist As Boolean
            Dim isOpen As Boolean
            Dim CurrentPacket As String
            Dim SetRotX As Double
            Dim SetRotY As Double
            Dim SetRotZ As Double



            While Not String.IsNullOrEmpty(_mainForm.comm.Message) AndAlso _mainForm.CheckBoxPPT.Checked = True
                Try

                    'exit loop if background worker is cancelled

                    If _mainForm.BackgroundWorkerPPT.CancellationPending Then
                        Exit While
                    End If

                    EulerX = 0
                    EulerY = 0
                    EulerZ = 0

                    'There are 8 different variables delimeted by comma





                    'ensure whole packet is retrieved,
                    Dim srCheckComma As StringReader = New StringReader(_mainForm.comm.Message)

                    Dim sr As StringReader = New StringReader(_mainForm.comm.Message)
                    FullComma = srCheckComma.ReadLine.Split(",").Length - 1


                    If _mainForm.comm.Message.StartsWith("V") Then 'check if diagnostic mode is activated.


                        MsgBox(
                            "Diagnostic mode is activated, program cannot continue." & vbCrLf &
                            "Please check the serial output")
                        _mainForm.CheckBoxConnect.Checked = False
                        _mainForm.GroupBoxAct.Enabled = False
                        _mainForm.TextboxDebug.Text = "Deactivate diagnotic mode on the Glove module in order to continue."
                        Exit While

                    End If


                    If FullComma = 7 Then


                        Try


                            CurrentPacket = sr.ReadLine()


                            CurrentEuler = Split(CurrentPacket, ",")


                            'Update Flex State
                            If _mainForm.RadioButtonNone.Checked = True Then

                                If CurrentEuler(0) = "o" Then
                                    isOpen = True
                                    isHalf = False
                                    isClosed = False
                                    isTwist = False
                                    _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.open)
                                    _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Open")
                                ElseIf CurrentEuler(0) = "h" Then
                                    _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.half)
                                    _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Half-Open")
                                    isOpen = False
                                    isHalf = True
                                    isClosed = False
                                    isTwist = False
                                ElseIf CurrentEuler(0) = "c" Then
                                    _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.closed)
                                    _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Closed")
                                    isOpen = False
                                    isHalf = False
                                    isClosed = True
                                    isTwist = False
                                ElseIf CurrentEuler(0) = "t" Then
                                    _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.turn)
                                    _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Twist")
                                    isOpen = False
                                    isHalf = False
                                    isClosed = False
                                    isTwist = True
                                ElseIf CurrentEuler(0) = "u" Then
                                    _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.open)
                                    _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Unknown")
                                    isOpen = True
                                    isHalf = False
                                    isClosed = False
                                    isTwist = False
                                End If
                            Else
                                _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.disabled)
                                _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Overriden")


                            End If


                            'WARNING IN MPU 9150 COORDINATE SYSTEM
                            ' PITCH/X = cEU(3), ROLL/Y = cEU(2), & YAW/Z = CeU(1) 


                            'Parsing


                            ParsedEulerY = Double.Parse(CurrentEuler(3)) 'pitch
                            ParsedEulerZ = Double.Parse(CurrentEuler(2)) 'roll
                            ParsedEulerX = Double.Parse(CurrentEuler(1))  'yaw


                            If CurrentEuler(4) = "u" Then isUpward = True
                            If CurrentEuler(4) = "d" Then isUpward = False

                            EulerY = ParsedEulerY / 100
                            EulerZ = ParsedEulerZ / 100
                            EulerX = ParsedEulerX / 100


                            'constrained motion, (only x and y mapped to the push buttons)


                            If _mainForm.CheckBoxTgX.Checked = True OrElse CurrentEuler(5) = 1 Then
                                SetRotX = 0
                            Else
                                'SetRotX = -EulerX 'mirror ->original orientation
                                SetRotX = EulerX 'reversed orientation (latest aclyric box)
                            End If

                            If _mainForm.CheckBoxTgY.Checked = True OrElse CurrentEuler(6) = 1 Then
                                SetRotY = 0
                            Else
                                SetRotY = EulerY
                            End If


                            If _mainForm.CheckBoxTgZ.Checked = True Then
                                SetRotZ = 0
                            Else
                                'SetRotZ = EulerZ 'original orientation
                                SetRotZ = -EulerZ 'reversed orientation (latest aclyric box)
                            End If





                            ''Update information tab
                            ''update orientation
                            If isUpward Then _mainForm.PicOrientation.Image = My.Resources.upward
                            If Not isUpward Then _mainForm.PicOrientation.Image = My.Resources.downward

                            'update info tab
                            'adjusted to MPU coordinate system, ROLL = z, Yaw = Y, Pitch = X
                            _mainForm.TextBoxEuX.Invoke(Sub() _mainForm.TextBoxEuX.Text = SetRotZ)
                            _mainForm.GaugeRoll.Invoke(Sub() _mainForm.GaugeRoll.Value = SetRotZ)
                            _mainForm.TextBoxEuY.Invoke(Sub() _mainForm.TextBoxEuY.Text = SetRotY)
                            _mainForm.GaugeYaw.Invoke(Sub() _mainForm.GaugeYaw.Value = SetRotY)
                            _mainForm.TextBoxEuZ.Invoke(Sub() _mainForm.TextBoxEuZ.Text = SetRotX)
                            _mainForm.GaugePitch.Invoke(Sub() _mainForm.GaugePitch.Value = SetRotX)

                            'arrow
                            If SetRotY < -0.03 Then
                                _mainForm.PicArrowLeft.Invoke(Sub() _mainForm.PicArrowLeft.Image = My.Resources.left)
                            ElseIf SetRotY > 0.03 Then
                                _mainForm.PicArrowRight.Invoke(Sub() _mainForm.PicArrowRight.Image = My.Resources.right)
                            Else
                                _mainForm.PicArrowLeft.Invoke(Sub() _mainForm.PicArrowLeft.Image = My.Resources.leftbw)
                                _mainForm.PicArrowRight.Invoke(Sub() _mainForm.PicArrowRight.Image = My.Resources.rightbw)
                            End If


                            If SetRotX < -0.03 Then
                                _mainForm.PicArrowUp.Invoke(Sub() _mainForm.PicArrowUp.Image = My.Resources.up)
                            ElseIf SetRotX > 0.03 Then
                                _mainForm.PicArrowDown.Invoke(Sub() _mainForm.PicArrowDown.Image = My.Resources.down)

                            Else
                                _mainForm.PicArrowDown.Invoke(Sub() _mainForm.PicArrowDown.Image = My.Resources.downbw)
                                _mainForm.PicArrowUp.Invoke(Sub() _mainForm.PicArrowUp.Image = My.Resources.upbw)
                            End If

                            If _mainForm.RadioButtonNone.Checked = False Then
                                isOpen = False
                                isHalf = False
                                isClosed = False
                                isTwist = False
                            End If

                            ''invoke changeview() with change of euler angle as arguments
                            ' TextBoxDebug.Text = SetRotX

                            If isHalf = True OrElse _mainForm.RadioButtonRotation.Checked Then
                                _mainForm.PicAct.Invoke(Sub() _mainForm.PicAct.Image = My.Resources.rotate)
                                _mainForm.LabelActState.Invoke(Sub() _mainForm.LabelActState.Text = "Rotate")



                                'Zoom Control, key-turning gesture or up and down

                            ElseIf isTwist = True OrElse _mainForm.RadioButtonZoom.Checked Then
                                _mainForm.PicAct.Invoke(Sub() _mainForm.PicAct.Image = My.Resources.zoom)
                                _mainForm.LabelActState.Invoke(Sub() _mainForm.LabelActState.Text = "Zoom")


                                'Trasnlation Control, key-turning gesture

                            ElseIf isClosed = True OrElse _mainForm.RadioButtonTranslation.Checked Then
                                _mainForm.PicAct.Invoke(Sub() _mainForm.PicAct.Image = My.Resources.move)
                                _mainForm.LabelActState.Invoke(Sub() _mainForm.LabelActState.Text = "Move")


                                If SetRotY < -_mainForm.NumericUpDownPPT.Text Then
                                    PrevSlide()
                                ElseIf SetRotY > _mainForm.NumericUpDownPPT.Text Then
                                    NextSlide()


                                End If



                            Else
                                _mainForm.PicAct.Invoke(Sub() _mainForm.PicAct.Image = My.Resources.neutral)
                                _mainForm.LabelActState.Invoke(Sub() _mainForm.LabelActState.Text = "Neutral")
                            End If


                        Catch ex As Exception
                            _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())
                            'MsgBox(ex.Message)
                            ' Exit While
                        End Try
                    End If
                Catch ex As Exception
                    _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())
                    MsgBox("Error on activating control, check serial port settings and whether Inventor is started")
                    Continue While
                End Try

            End While


        End Sub
    End Class
End Namespace