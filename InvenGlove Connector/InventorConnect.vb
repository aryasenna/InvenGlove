' InventorConnect Class
' Main Subroutine - Serial Data Parsing, Gesture translation and Inventor API actuation


'Written by Arya Senna
'Finalised on 16 Jun 2014
'V1.0.1
'Licensed under GNU GPL License v3
'--
'Part of Joint Capstone Project - Mechanical Engineering Department of Universitas Indonesia
'Arya Senna and Albert Koto

Imports System.IO
Imports System.ComponentModel

Namespace InvenGlove
    Public Class InventorConnect
        Private _mainForm As MainForm

        Sub New(ByVal mainForm1 As MainForm)
            _mainForm = mainForm1
        End Sub


        'Global variable
        Dim serialData As String
        Dim EulerX As Double = 0
        Dim EulerY As Double = 0
        Dim EulerZ As Double = 0
        Dim isUpward As Boolean
        Dim isClosed As Boolean
        Dim isHalf As Boolean
        Dim isTwist As Boolean
        Dim isOpen As Boolean
        Dim isUnknown As Boolean
        Dim isOverriden As Boolean
        Dim SetRotX As Double
        Dim SetRotY As Double
        Dim SetRotZ As Double
        Dim isConstraintX As Boolean
        Dim isConstraintY As Boolean
        Dim FullComma As Integer = 7



        Protected Friend Sub Connect()


            While Not String.IsNullOrEmpty(_mainForm.comm.Message) AndAlso _mainForm.CheckBoxConnect.Checked = True
                Try


                    'exit loop if background worker is cancelled

                    If _mainForm.BackgroundWorkerConnect.CancellationPending Then
                        Exit While
                    End If


                    If CheckSerialComplete(_mainForm.comm.Message) Then

                        Try

                            ParseSerialData(_mainForm.comm.Message)

                            'Update Overidden state from GUI
                            If _mainForm.RadioButtonNone.Checked = True Then
                                isOverriden = False
                            Else
                                isOverriden = True
                                isOpen = False
                                isHalf = False
                                isClosed = False
                                isTwist = False
                            End If


                            'Set rotation value from the parsed serial (see ParseSerialData()
                            'Constrained motion, (only x and y mapped to the push buttons)

                            If _mainForm.CheckBoxTgX.Checked = True OrElse isConstraintX Then
                                SetRotX = 0
                            Else
                                'SetRotX = -EulerX 'mirror -> original orientation
                                SetRotX = EulerX '-> reversed orientation (latest aclyric box)
                            End If

                            If _mainForm.CheckBoxTgY.Checked = True OrElse isConstraintY Then
                                SetRotY = 0
                            Else
                                SetRotY = EulerY
                            End If

                            '  If _mainForm.CheckBoxTgZ.Checked And (isHalf Or _mainForm.RadioButtonRotation.Checked) Then
                            'SetRotZ = 0
                            '2D mode, no rotation in X and y, only Z
                            '    SetRotX = 0
                            '   SetRotY = 0
                            '  SetRotZ = -EulerZ
                            ' Else
                            'SetRotZ = EulerZ 'original orientation
                            '    SetRotZ = -EulerZ 'reversed orientation (latest aclyric box)
                            ' End If

                            'Update information tab

                            updateGUIControl()


                            'Gesture recognition 
                            'Rotation Control, half open gesture

                            If isHalf = True OrElse _mainForm.RadioButtonRotation.Checked Then
                                _mainForm.InventorApi.ChangeView(SetRotX * _mainForm.InputScalingRot.Value, SetRotY * _mainForm.InputScalingRot.Value,
                                                                  SetRotZ * _mainForm.InputScalingRot.Value)

                                _mainForm.screenX = Nothing
                                _mainForm.screenY = Nothing
                                _mainForm.screenZ = Nothing


                                'Translation Control, closed gesture

                            ElseIf isClosed = True OrElse _mainForm.RadioButtonTranslation.Checked Then
                                If isUpward Then _
                                    'need to be upward so x-y orientation won't be messed up!
                                    'add some min threshold, due to gyro sensitivity 
                                    If _
                                        (SetRotY > 0.05 OrElse SetRotY < -0.01) OrElse
                                        (SetRotX > 0.01 OrElse SetRotX < -0.01) Then
                                        'Hand can't be possibly rotate more than pi radian
                                        If _
                                            (SetRotY > -3.14 AndAlso SetRotY < 3.14) AndAlso
                                            (SetRotX > -3.14 AndAlso SetRotX < 3.14) _
                                            Then


                                            _mainForm.InventorApi.MoveBody(SetRotY * _mainForm.InputRatioRotTrans.Value,
                                                                           -SetRotX * _mainForm.InputRatioRotTrans.Value, 0)
                                        End If
                                    End If
                                End If


                                'Zoom Control, key-turning gesture or up and down

                            ElseIf isTwist = True OrElse _mainForm.RadioButtonZoom.Checked Then
                                If _mainForm.CheckBoxZoomOpt.CheckState = True Then
                                    If SetRotY > 0 OrElse SetRotY < 0 Then
                                        Dim SetZoom As Double
                                        SetZoom = SetRotY * _mainForm.TextBoxZoomInc.Value
                                        _mainForm.InventorApi.Zoom(SetZoom, SetZoom)
                                    End If
                                Else
                                    Dim SetZoom As Double
                                    SetZoom = SetRotX * _mainForm.TextBoxZoomInc.Value
                                    _mainForm.InventorApi.Zoom(SetZoom, SetZoom)
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

                    Else
                        'zero all Euler value
                        SetRotX = 0
                        SetRotY = 0
                        SetRotZ = 0
                    End If


                Catch ex As Exception
                    _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = ex.ToString())
                    MsgBox("Error on activating control, check serial port settings and whether Inventor is started")
                    Continue While
                End Try
            End While
        End Sub


        Friend Sub updateGUIControl()


            'orientation

            If isUpward Then _mainForm.PicOrientation.Image = My.Resources.upward
            If Not isUpward Then _mainForm.PicOrientation.Image = My.Resources.downward

            'flex state 
            If isOpen Then
                _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.open)
                _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Open")
            ElseIf isHalf Then
                _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.half)
                _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Half-Open")
            ElseIf isClosed Then
                _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.closed)
                _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Closed")
            ElseIf isTwist Then
                _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.turn)
                _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Twist")
            ElseIf isUnknown Then
                _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.open)
                _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Unknown")
            ElseIf isOverriden = True Then
                _mainForm.PicFlex.Invoke(Sub() _mainForm.PicFlex.Image = My.Resources.disabled)
                _mainForm.LabelFlexState.Invoke(Sub() _mainForm.LabelFlexState.Text = "Overriden")
            End If

            'Gauge and TextBox

            'update info tab
            'adjusted to MPU coordinate system, ROLL = z, Yaw = Y, Pitch = X
            _mainForm.TextBoxEuX.Invoke(Sub() _mainForm.TextBoxEuX.Text = SetRotZ)
            _mainForm.GaugeRoll.Invoke(Sub() _mainForm.GaugeRoll.Value = SetRotZ)
            _mainForm.TextBoxEuY.Invoke(Sub() _mainForm.TextBoxEuY.Text = SetRotY)
            _mainForm.GaugeYaw.Invoke(Sub() _mainForm.GaugeYaw.Value = SetRotY)
            _mainForm.TextBoxEuZ.Invoke(Sub() _mainForm.TextBoxEuZ.Text = SetRotX)
            _mainForm.GaugePitch.Invoke(Sub() _mainForm.GaugePitch.Value = SetRotX)

            'Arrow

            ' add some min threshold, due to gyro sensitivity 

            Dim arrowThreshold As Double = 0.03
            If SetRotY < -arrowThreshold Then
                _mainForm.PicArrowLeft.Invoke(Sub() _mainForm.PicArrowLeft.Image = My.Resources.left)
            ElseIf SetRotY > arrowThreshold Then
                _mainForm.PicArrowRight.Invoke(Sub() _mainForm.PicArrowRight.Image = My.Resources.right)
            Else
                _mainForm.PicArrowLeft.Invoke(Sub() _mainForm.PicArrowLeft.Image = My.Resources.leftbw)
                _mainForm.PicArrowRight.Invoke(Sub() _mainForm.PicArrowRight.Image = My.Resources.rightbw)
            End If


            If SetRotX < -arrowThreshold Then
                _mainForm.PicArrowUp.Invoke(Sub() _mainForm.PicArrowUp.Image = My.Resources.up)
            ElseIf SetRotX > arrowThreshold Then
                _mainForm.PicArrowDown.Invoke(Sub() _mainForm.PicArrowDown.Image = My.Resources.down)

            Else
                _mainForm.PicArrowDown.Invoke(Sub() _mainForm.PicArrowDown.Image = My.Resources.downbw)
                _mainForm.PicArrowUp.Invoke(Sub() _mainForm.PicArrowUp.Image = My.Resources.upbw)
            End If


            'Operation

            If isHalf = True OrElse _mainForm.RadioButtonRotation.Checked Then
                _mainForm.PicAct.Invoke(Sub() _mainForm.PicAct.Image = My.Resources.rotate)
                _mainForm.LabelActState.Invoke(Sub() _mainForm.LabelActState.Text = "Rotate")
               
                'Translation Control, closed gesture

            ElseIf isClosed = True OrElse _mainForm.RadioButtonTranslation.Checked Then
                _mainForm.PicAct.Invoke(Sub() _mainForm.PicAct.Image = My.Resources.move)
                _mainForm.LabelActState.Invoke(Sub() _mainForm.LabelActState.Text = "Move")

                'Zoom Control, key-turning gesture or up and down

            ElseIf isTwist = True OrElse _mainForm.RadioButtonZoom.Checked Then
                _mainForm.PicAct.Invoke(Sub() _mainForm.PicAct.Image = My.Resources.zoom)
                _mainForm.LabelActState.Invoke(Sub() _mainForm.LabelActState.Text = "Zoom")
               
            Else
                _mainForm.PicAct.Invoke(Sub() _mainForm.PicAct.Image = My.Resources.neutral)
                _mainForm.LabelActState.Invoke(Sub() _mainForm.LabelActState.Text = "Neutral")
            End If

        End Sub


        Friend Sub ParseSerialData(ByVal _serialData As String)
            Dim serialDataParsed As String()
            Dim SerialDataPacket As String

            Dim sr As StringReader = New StringReader(_serialData)
            SerialDataPacket = sr.ReadLine()
            serialDataParsed = Split(_serialData, ",")

            Dim serialDataFlex As String = serialDataParsed(0)
            Dim serialDataX As String = serialDataParsed(1)
            Dim serialDataY As String = serialDataParsed(3)
            Dim serialDataZ As String = serialDataParsed(2)
            Dim serialDataOrientation As String = serialDataParsed(4)
            Dim serialDataConstraintX As String = serialDataParsed(5)
            Dim serialDataConstraintY As String = serialDataParsed(6)


            'Parse Flex State


            If serialDataFlex = "o" Then
                isOpen = True
                isHalf = False
                isClosed = False
                isTwist = False
            ElseIf serialDataFlex = "h" Then
                isOpen = False
                isHalf = True
                isClosed = False
                isTwist = False
            ElseIf serialDataFlex = "c" Then
                isOpen = False
                isHalf = False
                isClosed = True
                isTwist = False
            ElseIf serialDataFlex = "t" Then
                isOpen = False
                isHalf = False
                isClosed = False
                isTwist = True
            ElseIf serialDataFlex = "u" Then
                isUnknown = True
                isOpen = False
                isHalf = False
                isClosed = False
                isTwist = False
            End If


            'Parsing into double from String

            'WARNING IN MPU 9150 COORDINATE SYSTEM
            ' PITCH/X = cEU(3), ROLL/Y = cEU(2), & YAW/Z = CeU(1) 

            

            EulerY = Double.Parse(serialDataY) / 100 'pitch
            EulerZ = Double.Parse(serialDataZ) / 100 'roll
            EulerX = Double.Parse(serialDataX) / 100  'yaw

            'orientation

            If serialDataOrientation = "u" Then isUpward = True
            If serialDataOrientation = "d" Then isUpward = False

            'constraint movement
            If serialDataConstraintX = "1" Then
                isConstraintX = True
            ElseIf serialDataConstraintX = "0" Then
                isConstraintX = False
            End If

            If serialDataConstraintY = "1" Then
                isConstraintY = True
            ElseIf serialDataConstraintY = "0" Then
                isConstraintY = False
            End If


        End Sub


        Friend Function CheckSerialComplete(ByVal _serialData As String) As Boolean

            If _serialData.StartsWith("V") Then 'check if diagnostic mode is activated.


                MsgBox(
                    "Diagnostic mode is activated, program cannot continue." & vbCrLf &
                    "Please check the serial output")
                _mainForm.CheckBoxConnect.Checked = False
                _mainForm.GroupBoxAct.Enabled = False
                _mainForm.TextboxDebug.Invoke(Sub() _mainForm.TextboxDebug.Text = "Deactivate diagnotic mode on the Glove module in order to continue.")
                _mainForm.BackgroundWorkerConnect.CancelAsync()
                Return False
            End If


            'ensure whole packet is retrieved, by counting the no. of comma  (most reliable)


            Dim Comma As Integer
            Dim srCheckComma As StringReader = New StringReader(_serialData)

            Comma = srCheckComma.ReadLine.Split(",").Length - 1
            If Comma = FullComma Then
                Return True
            Else
                Return False
            End If

        End Function
    End Class
End Namespace