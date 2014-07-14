' InventorAPI Class
' Various geometric manipulation of Inventor part in subroutines and functions
' Also handle document type checking and view settings.


'Written by Arya Senna
'Finalised on 16 Jun 2014
'V1.0.1
'Licensed under GNU GPL License v3
'--
'Part of Joint Capstone Project - Mechanical Engineering Department of Universitas Indonesia
'Arya Senna and Albert Koto


Imports Inventor



Namespace InvenGlove
    Public Class InventorAPI
        Private _mainForm As MainForm

        Sub New(ByVal mainForm1 As MainForm)
            _mainForm = mainForm1
        End Sub

        Protected Friend Function CheckOpenDocument()
            Try
                If _mainForm.appInventor.ActiveDocumentType.Equals(DocumentTypeEnum.kPartDocumentObject) Then

                    'set Active Part Document
                    _mainForm.partDoc = _mainForm.appInventor.ActiveDocument
                    _mainForm.partDef = _mainForm.partDoc.ComponentDefinition

                    Return 1 ' part = 1

                ElseIf _mainForm.appInventor.ActiveDocumentType.Equals(DocumentTypeEnum.kAssemblyDocumentObject) Then
                    'set Active Assembly Document
                    _mainForm.assyDoc = _mainForm.appInventor.ActiveDocument
                    _mainForm.assyDef = _mainForm.assyDoc.ComponentDefinition

                    Return 2 ' assembly = 2
                Else
                    MsgBox("Please open part (ipt) or assembly (iam) file first!")
                    Return 0 'unknown/other document


                End If

            Catch ex As Exception
                _mainForm.TextboxDebug.Text = ex.ToString()
                MsgBox("failed to check current open document")
                Return 0
            End Try
        End Function

        Protected Friend Function GetDocName()
            Try
                If _mainForm.InventorApi.CheckOpenDocument() = 1 Then
                    Return _mainForm.partDoc.DisplayName
                ElseIf _mainForm.InventorApi.CheckOpenDocument() = 2 Then
                    Return _mainForm.assyDoc.DisplayName
                Else : Return "<unknown>"
                End If
            Catch ex As Exception
                _mainForm.TextboxDebug.Text = ex.ToString()

                Return "<unknown>"
            End Try
        End Function

        Protected Friend Sub SelectObject()
            Try

                Dim hWnd As IntPtr = MainForm.UnsafeNativeMethods.FindWindowByExe("Inventor.exe")
                If Not hWnd = IntPtr.Zero Then ' found
                    MainForm.UnsafeNativeMethods.SetForegroundWindow(hWnd) ' bring to foreground
                    'Else
                    '   Process.Start("Inventor.exe")
                End If
                'set to xy plane, because otherwise the rotation/translation orientations are going to be messed up.
                SetFrontPlane()
                'set preset zoom
                ZoomFixed(_mainForm.TextBoxHZoom.Text, _mainForm.TextBoxWZoom.Text)


                If _mainForm.InventorApi.CheckOpenDocument() = 1 Then

                    _mainForm.body = _mainForm.appInventor.CommandManager.Pick(SelectionFilterEnum.kPartBodyFilter, "Select the body to move.")


                ElseIf _mainForm.InventorApi.CheckOpenDocument() = 2 Then


                    _mainForm.selOccurrence = _mainForm.appInventor.CommandManager.Pick(SelectionFilterEnum.kAssemblyOccurrenceFilter,
                                                                                        "Select the part/subassembly to move.")
                End If


            Catch ex As Exception
                _mainForm.TextboxDebug.Text = ex.ToString()
                MsgBox(ex.Message)
                MsgBox("Error on selecting body")


            End Try
        End Sub

        Protected Friend Function GetSelPartName()
            Try
                If _mainForm.InventorApi.CheckOpenDocument() = 1 Then
                    Return _mainForm.body.Name

                ElseIf _mainForm.InventorApi.CheckOpenDocument() = 2 Then
                    Return _mainForm.selOccurrence.Name
                Else : Return "<unknown>"
                End If

            Catch ex As Exception
                _mainForm.TextboxDebug.Text = ex.ToString()


                Return "<unknown>"
            End Try
        End Function

        Protected Friend Sub SetFrontPlane()

            _mainForm.oTG = _mainForm.appInventor.TransientGeometry
            _mainForm.oCamera = _mainForm.appInventor.ActiveView.Camera
            _mainForm.oCamera.ViewOrientationType = ViewOrientationTypeEnum.kFrontViewOrientation
            _mainForm.oCamera.ApplyWithoutTransition()
        End Sub

        Protected Friend Sub ChangeView(ByVal gyroX As Double, ByVal gyroY As Double, ByVal gyroZ As Double)


            Try

                If _mainForm.CheckBoxRot.Checked = False Then

                    _mainForm.oCamera = _mainForm.appInventor.ActiveView.Camera
                    _mainForm.oTG = _mainForm.appInventor.TransientGeometry

                    ' Get screen vectors

                    If _mainForm.screenX Is Nothing Then
                        _mainForm.screenZ = _mainForm.oCamera.Target.VectorTo(_mainForm.oCamera.Eye)
                        _mainForm.screenZ.Normalize()

                        _mainForm.screenY = _mainForm.oCamera.UpVector.AsVector

                        _mainForm.screenX = _mainForm.screenY.CrossProduct(_mainForm.screenZ)
                    End If

                    ' Transform around those axes


                    Dim rotX As Matrix = _mainForm.oTG.CreateMatrix
                    rotX.SetToRotation(gyroX, _mainForm.screenX, _mainForm.oCamera.Target)

                    Dim rotY As Matrix = _mainForm.oTG.CreateMatrix
                    rotY.SetToRotation(gyroY, _mainForm.screenY, _mainForm.oCamera.Target)

                    Dim rotZ As Matrix = _mainForm.oTG.CreateMatrix
                    rotZ.SetToRotation(gyroZ, _mainForm.screenZ, _mainForm.oCamera.Target)

                    Dim rot As Matrix = _mainForm.oTG.CreateMatrix
                    rot = rotX
                    rot.PostMultiplyBy(rotY)
                    rot.PostMultiplyBy(rotZ)

                    Dim newEye As Inventor.Point = _mainForm.oCamera.Eye
                    newEye.TransformBy(rot)

                    Dim newUp As UnitVector = _mainForm.oCamera.UpVector
                    newUp.TransformBy(rot)

                    _mainForm.oCamera.Eye = newEye
                    _mainForm.oCamera.UpVector = newUp
                    _mainForm.oCamera.ApplyWithoutTransition()

                Else
                    RotateBody(-gyroX, -gyroY, -gyroZ)
                End If

            Catch
                MsgBox("Error on rotation operation!")

            End Try
        End Sub

        Protected Friend Sub RotateBody(ByVal euX As Double, ByVal euY As Double, ByVal euZ As Double)
            Try


                _mainForm.InventorApi.CheckOpenDocument()


                If _mainForm.InventorApi.CheckOpenDocument() = 1 Then


                    If _mainForm.body Is Nothing Then
                        MsgBox("Select Body on Inventor first!" & vbCrLf & "Click OK then go to Inventor to select a body")
                        SelectObject()
                    End If

                    Dim bodyCollection As ObjectCollection
                    bodyCollection = _mainForm.appInventor.
                        TransientObjects.CreateObjectCollection

                    Call bodyCollection.Add(_mainForm.body)
                    _mainForm.partDoc = _mainForm.appInventor.ActiveDocument

                    _mainForm.partDef = _mainForm.partDoc.ComponentDefinition

                    ' Create a move definition. 
                    Dim moveDef As MoveDefinition
                    moveDef = _mainForm.partDef.Features.MoveFeatures.CreateMoveDefinition(bodyCollection)


                    ' Define a rotate, move, and free drag. 
                    Call moveDef.AddRotateAboutAxis(_mainForm.partDef.WorkAxes.Item(1), True, -1 * euX)
                    Call moveDef.AddRotateAboutAxis(_mainForm.partDef.WorkAxes.Item(2), True, -1 * euY)
                    Call moveDef.AddRotateAboutAxis(_mainForm.partDef.WorkAxes.Item(3), True, -1 * euZ)


                    ' Create the move feature. 
                    Dim move As MoveFeature
                    move = _mainForm.partDef.Features.MoveFeatures _
                        .Add(moveDef)

                End If


                If _mainForm.InventorApi.CheckOpenDocument() = 2 Then 'assembly


                    _mainForm.assyDoc = _mainForm.appInventor.ActiveDocument

                    _mainForm.assyDef = _mainForm.assyDoc.ComponentDefinition

                    If _mainForm.selOccurrence Is Nothing Then
                        MsgBox(
                            "Select Part/SubAssembly on Inventor first!" & vbCrLf &
                            "Click OK then go to Inventor to select a body")
                        SelectObject()

                    End If
                    Dim occurrenceList As New Microsoft.VisualBasic.Collection
                    Call occurrenceList.Add(_mainForm.selOccurrence)
                    Dim oOccurrence As ComponentOccurrence
                    oOccurrence = occurrenceList.Item(1) 'selected item, just the last one selected for now


                    ' Get the current transformation matrix from the occurrence.

                    Dim oMatrix As Matrix
                    oMatrix = oOccurrence.Transformation

                    'get current center point

                    Dim OccCenter As Inventor.Point = _mainForm.appInventor.TransientGeometry.CreatePoint(oMatrix.Cell(1, 4),
                                                                                                          oMatrix.Cell(2, 4),
                                                                                                          oMatrix.Cell(3, 4))


                    'rotation matrix
                    Dim oTransformMatrixX As Matrix = _mainForm.appInventor.TransientGeometry.CreateMatrix
                    Dim oTransformMatrixY As Matrix = _mainForm.appInventor.TransientGeometry.CreateMatrix
                    Dim oTransformMatrixZ As Matrix = _mainForm.appInventor.TransientGeometry.CreateMatrix

                    Dim oTransformMatrix As Matrix = _mainForm.appInventor.TransientGeometry.CreateMatrix


                    'borrow some properties from camera

                    _mainForm.oCamera = _mainForm.appInventor.ActiveView.Camera
                    _mainForm.oTG = _mainForm.appInventor.TransientGeometry


                    'create rotation matrix
                    oTransformMatrixX.SetToRotation(-euX, _mainForm.oTG.CreateVector(1, 0, 0), OccCenter)
                    oTransformMatrixY.SetToRotation(-euY, _mainForm.oTG.CreateVector(0, 1, 0), OccCenter)
                    oTransformMatrixZ.SetToRotation(-euZ, _mainForm.oTG.CreateVector(0, 0, 1), OccCenter)
                    'post multiply to combine rotation on every axes
                    oTransformMatrix = oTransformMatrixX
                    oTransformMatrix.PostMultiplyBy(oTransformMatrixY)
                    oTransformMatrix.PostMultiplyBy(oTransformMatrixZ)


                    'do Transformation using aboce matrix to the part.

                    oMatrix.TransformBy(oTransformMatrix)
                    oOccurrence.Transformation = oMatrix


                End If


            Catch
                MsgBox("Error on rotation operation")
            End Try
        End Sub

        Protected Friend Sub MoveBody(ByVal mX As Double, ByVal mY As Double, ByVal mZ As Double)
            Try

                _mainForm.InventorApi.CheckOpenDocument()

                'For part
                If _mainForm.InventorApi.CheckOpenDocument() = 1 Then


                    If _
                        (_mainForm.InventorApi.CheckOpenDocument() = 1 AndAlso (_mainForm.body Is Nothing)) OrElse (_mainForm.InventorApi.CheckOpenDocument() = 2 AndAlso (_mainForm.selOccurrence Is Nothing)) Then
                        MsgBox(
                            "Select Part/Subassembly on Inventor first!" & vbCrLf &
                            "Click OK, then switch to Inventor to select a body")
                        SelectObject()

                    End If
                    ' Create a collection containing the body to move. 
                    Dim bodyCollection As ObjectCollection
                    bodyCollection = _mainForm.appInventor.
                        TransientObjects.CreateObjectCollection

                    Call bodyCollection.Add(_mainForm.body)

                    ' Create a move definition. 
                    _mainForm.partDoc = _mainForm.appInventor.ActiveDocument

                    _mainForm.partDef = _mainForm.partDoc.ComponentDefinition
                    Dim moveDef As MoveDefinition
                    moveDef = _mainForm.partDef.Features.MoveFeatures.CreateMoveDefinition(bodyCollection)

                    ' Define a rotate, move, and free drag. 

                    Call moveDef.AddFreeDrag(mX, mY, mZ)

                    ' Create the move feature. 
                    Dim move As MoveFeature
                    move = _mainForm.partDef.Features.MoveFeatures.Add(moveDef)


                End If

                'for Assembly
                If _mainForm.InventorApi.CheckOpenDocument() = 2 Then

                    _mainForm.assyDoc = _mainForm.appInventor.ActiveDocument

                    _mainForm.assyDef = _mainForm.assyDoc.ComponentDefinition

                    If _mainForm.selOccurrence Is Nothing Then
                        MsgBox(
                            "Select Part/SubAssembly on Inventor first!" & vbCrLf &
                            "Click OK then go to Inventor to select a body")
                        SelectObject()

                    End If
                    Dim occurrenceList As New Microsoft.VisualBasic.Collection
                    Call occurrenceList.Add(_mainForm.selOccurrence)
                    Dim oOccurrence As ComponentOccurrence
                    oOccurrence = occurrenceList.Item(1) 'selected item, just the last one selected for now


                    'become translation matrix
                    Dim oTransformMatrix As Matrix = _mainForm.appInventor.TransientGeometry.CreateMatrix

                    oTransformMatrix.Cell(1, 4) = mX 'originX
                    oTransformMatrix.Cell(2, 4) = mY 'originY
                    oTransformMatrix.Cell(3, 4) = mZ 'originZ

                    'do Transformation using aboce matrix to the part.
                    Dim oMatrix As Matrix
                    oMatrix = oOccurrence.Transformation
                    oMatrix.TransformBy(oTransformMatrix)
                    oOccurrence.Transformation = oMatrix

                End If
            Catch ex As Exception
                _mainForm.TextboxDebug.Text = ex.ToString()
                MsgBox("Error on moving operation")
                'MsgBox(ex.Message)
            End Try
        End Sub

        Protected Friend Sub ZoomFixed(ByVal HZoom As Double, WZoom As Double)
            Try

                Dim cam As Camera
                cam = _mainForm.appInventor.ActiveView.Camera
                cam.SetExtents(HZoom, WZoom)
                cam.ApplyWithoutTransition()

            Catch
                MsgBox("Unable to set zoom")
            End Try
        End Sub

        Protected Friend Sub Zoom(ByVal zW As Double, ByVal zH As Double)
            Try
                Dim cam As Camera = _mainForm.appInventor.ActiveView.Camera
                Dim currentW As Double, currentH As Double
                Dim setZoomValW As Double, setZoomValH As Double
                cam.GetExtents(currentW, currentH)
                setZoomValW = currentW + zW
                setZoomValH = currentH + zH
                If setZoomValH > 2 OrElse setZoomValW > 2 Then
                    cam.SetExtents(setZoomValW, setZoomValH)
                    cam.ApplyWithoutTransition()
                Else
                    cam.SetExtents(2, 2)
                    cam.ApplyWithoutTransition()

                End If
                ' TextboxDebug.Text = setZoomValH
            Catch
                MsgBox("Unable to set zoom")
            End Try
        End Sub
    End Class
End Namespace