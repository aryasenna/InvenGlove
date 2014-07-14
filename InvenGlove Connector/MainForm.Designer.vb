Imports InvenGlove.InvenGlove

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try

            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()


            End If

            If comm IsNot Nothing Then
                comm.Dispose()
            End If



        Finally

            MyBase.Dispose(disposing)

        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GroupBoxZoomArb As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TextBoxWZoom = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxHZoom = New System.Windows.Forms.NumericUpDown()
        Me.ButtonZoom = New System.Windows.Forms.Button()
        Me.LabelH = New System.Windows.Forms.Label()
        Me.LabelW = New System.Windows.Forms.Label()
        Me.ArrowLeft = New System.Windows.Forms.Button()
        Me.up = New System.Windows.Forms.Button()
        Me.ArrowRight = New System.Windows.Forms.Button()
        Me.down = New System.Windows.Forms.Button()
        Me.rotate = New System.Windows.Forms.Button()
        Me.ButtonRotateX = New System.Windows.Forms.Button()
        Me.buttonRotateY = New System.Windows.Forms.Button()
        Me.ButtonRotateZ = New System.Windows.Forms.Button()
        Me.ButtonRotbyVal = New System.Windows.Forms.Button()
        Me.RotationArrow = New System.Windows.Forms.GroupBox()
        Me.ButtonFrontPlane = New System.Windows.Forms.Button()
        Me.TextboxIncRot = New System.Windows.Forms.NumericUpDown()
        Me.LabelIncRot = New System.Windows.Forms.Label()
        Me.GroupRotate90 = New System.Windows.Forms.GroupBox()
        Me.GroupRotateCustom = New System.Windows.Forms.GroupBox()
        Me.InputZ = New System.Windows.Forms.NumericUpDown()
        Me.InputY = New System.Windows.Forms.NumericUpDown()
        Me.inputX = New System.Windows.Forms.NumericUpDown()
        Me.LabelZ = New System.Windows.Forms.Label()
        Me.LabelY = New System.Windows.Forms.Label()
        Me.LabelX = New System.Windows.Forms.Label()
        Me.CheckBoxRot = New System.Windows.Forms.CheckBox()
        Me.TextboxDebug = New System.Windows.Forms.TextBox()
        Me.tabOption = New System.Windows.Forms.TabControl()
        Me.tabRotation = New System.Windows.Forms.TabPage()
        Me.InputScalingRot = New System.Windows.Forms.NumericUpDown()
        Me.LabelScalingRotUnit = New System.Windows.Forms.Label()
        Me.LabelScalingRot = New System.Windows.Forms.Label()
        Me.TabTranslate = New System.Windows.Forms.TabPage()
        Me.InputRatioRotTrans = New System.Windows.Forms.NumericUpDown()
        Me.LabelRatioRotTrans = New System.Windows.Forms.Label()
        Me.GroupBoxTransArb = New System.Windows.Forms.GroupBox()
        Me.TextBoxMoveZ = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxMoveY = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxMoveX = New System.Windows.Forms.NumericUpDown()
        Me.LabelTransX = New System.Windows.Forms.Label()
        Me.LabelTransZ = New System.Windows.Forms.Label()
        Me.LabelTransY = New System.Windows.Forms.Label()
        Me.ButtonTranslate = New System.Windows.Forms.Button()
        Me.GroupBoxTransArrow = New System.Windows.Forms.GroupBox()
        Me.ButtonTestMoveAss = New System.Windows.Forms.Button()
        Me.ButtonDelAllMoves = New System.Windows.Forms.Button()
        Me.TextboxIncTrans = New System.Windows.Forms.NumericUpDown()
        Me.LabelIncTrans = New System.Windows.Forms.Label()
        Me.ButtonMoveZdown = New System.Windows.Forms.Button()
        Me.ButtonMoveDown = New System.Windows.Forms.Button()
        Me.ButtonMoveRight = New System.Windows.Forms.Button()
        Me.ButtonMoveZup = New System.Windows.Forms.Button()
        Me.ButtonMoveLeft = New System.Windows.Forms.Button()
        Me.ButtonMoveUp = New System.Windows.Forms.Button()
        Me.TabZoom = New System.Windows.Forms.TabPage()
        Me.CheckBoxZoomOpt = New System.Windows.Forms.CheckBox()
        Me.GroupBoxZoomControl = New System.Windows.Forms.GroupBox()
        Me.TextBoxZoomInc = New System.Windows.Forms.NumericUpDown()
        Me.LabelIncZoom = New System.Windows.Forms.Label()
        Me.ButtonZoomIn = New System.Windows.Forms.Button()
        Me.ButtonZoomOut = New System.Windows.Forms.Button()
        Me.GroupBoxDebug = New System.Windows.Forms.GroupBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabDocInfo = New System.Windows.Forms.TabPage()
        Me.TextBoxSelPart = New System.Windows.Forms.TextBox()
        Me.TextBoxFileName = New System.Windows.Forms.TextBox()
        Me.LabelSelPart = New System.Windows.Forms.Label()
        Me.LabelFileName = New System.Windows.Forms.Label()
        Me.TabDebug = New System.Windows.Forms.TabPage()
        Me.CheckBoxConnect = New System.Windows.Forms.CheckBox()
        Me.ButtonSelBody = New System.Windows.Forms.Button()
        Me.LabelNotice = New System.Windows.Forms.Label()
        Me.GroupBoxAct = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNone = New System.Windows.Forms.RadioButton()
        Me.RadioButtonZoom = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTranslation = New System.Windows.Forms.RadioButton()
        Me.RadioButtonRotation = New System.Windows.Forms.RadioButton()
        Me.LabelAbout = New System.Windows.Forms.Label()
        Me.LinkProto = New System.Windows.Forms.LinkLabel()
        Me.ToolTipProto = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxConstrain = New System.Windows.Forms.GroupBox()
        Me.CheckBoxTgX = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTgY = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTgZ = New System.Windows.Forms.CheckBox()
        Me.PictureBoxMakara = New System.Windows.Forms.PictureBox()
        Me.GaugePitch = New System.Windows.Forms.AGauge()
        Me.GaugeYaw = New System.Windows.Forms.AGauge()
        Me.GaugeRoll = New System.Windows.Forms.AGauge()
        Me.TabInfo = New System.Windows.Forms.TabPage()
        Me.GroupBoxArrowTrans = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicArrowUp = New System.Windows.Forms.PictureBox()
        Me.PicArrowLeft = New System.Windows.Forms.PictureBox()
        Me.PicArrowDown = New System.Windows.Forms.PictureBox()
        Me.PicArrowRight = New System.Windows.Forms.PictureBox()
        Me.GroupBoxActPic = New System.Windows.Forms.GroupBox()
        Me.LabelActState = New System.Windows.Forms.Label()
        Me.PicAct = New System.Windows.Forms.PictureBox()
        Me.GroupBoxFlexPic = New System.Windows.Forms.GroupBox()
        Me.LabelFlexState = New System.Windows.Forms.Label()
        Me.PicFlex = New System.Windows.Forms.PictureBox()
        Me.GroupBoxOrientation = New System.Windows.Forms.GroupBox()
        Me.PicOrientation = New System.Windows.Forms.PictureBox()
        Me.GroupBoxEuler = New System.Windows.Forms.GroupBox()
        Me.LabelPitch = New System.Windows.Forms.Label()
        Me.LabelYaw = New System.Windows.Forms.Label()
        Me.TextBoxEuX = New System.Windows.Forms.RichTextBox()
        Me.LabelRoll = New System.Windows.Forms.Label()
        Me.TextBoxEuY = New System.Windows.Forms.RichTextBox()
        Me.TextBoxEuZ = New System.Windows.Forms.RichTextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabSerial = New System.Windows.Forms.TabPage()
        Me.GroupBoxSerial = New System.Windows.Forms.GroupBox()
        Me.CheckBoxViewOutput = New System.Windows.Forms.CheckBox()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.groupBoxSerialOptions = New System.Windows.Forms.GroupBox()
        Me.labelDB = New System.Windows.Forms.Label()
        Me.cboData = New System.Windows.Forms.ComboBox()
        Me.labelSB = New System.Windows.Forms.Label()
        Me.cboStop = New System.Windows.Forms.ComboBox()
        Me.labelParity = New System.Windows.Forms.Label()
        Me.labelBaud = New System.Windows.Forms.Label()
        Me.cboParity = New System.Windows.Forms.ComboBox()
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.cboBaud = New System.Windows.Forms.ComboBox()
        Me.cboPort = New System.Windows.Forms.ComboBox()
        Me.groupBoxSerialMode = New System.Windows.Forms.GroupBox()
        Me.rdoText = New System.Windows.Forms.RadioButton()
        Me.rdoHex = New System.Windows.Forms.RadioButton()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.TabPres = New System.Windows.Forms.TabControl()
        Me.tabPPT = New System.Windows.Forms.TabPage()
        Me.NumericUpDownPPT = New System.Windows.Forms.NumericUpDown()
        Me.LabelPPTDisc = New System.Windows.Forms.Label()
        Me.LabelPPTThreshol = New System.Windows.Forms.Label()
        Me.LabelPPT = New System.Windows.Forms.Label()
        Me.GroupBoxSlidesCtrl = New System.Windows.Forms.GroupBox()
        Me.ButtoPPTStop = New System.Windows.Forms.Button()
        Me.ButtonPPTStart = New System.Windows.Forms.Button()
        Me.ButtonPPTFirst = New System.Windows.Forms.Button()
        Me.ButtonPPTPrev = New System.Windows.Forms.Button()
        Me.ButtonPPTLast = New System.Windows.Forms.Button()
        Me.ButtonPPTNext = New System.Windows.Forms.Button()
        Me.CheckBoxPPT = New System.Windows.Forms.CheckBox()
        Me.PPT = New System.Windows.Forms.Button()
        Me.GroupBoxPPT = New System.Windows.Forms.GroupBox()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonRight = New System.Windows.Forms.Button()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.ButtonLeft = New System.Windows.Forms.Button()
        Me.BackgroundWorkerConnect = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerPPT = New System.ComponentModel.BackgroundWorker()
        GroupBoxZoomArb = New System.Windows.Forms.GroupBox()
        GroupBoxZoomArb.SuspendLayout()
        CType(Me.TextBoxWZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxHZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RotationArrow.SuspendLayout()
        CType(Me.TextboxIncRot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupRotate90.SuspendLayout()
        Me.GroupRotateCustom.SuspendLayout()
        CType(Me.InputZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOption.SuspendLayout()
        Me.tabRotation.SuspendLayout()
        CType(Me.InputScalingRot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTranslate.SuspendLayout()
        CType(Me.InputRatioRotTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxTransArb.SuspendLayout()
        CType(Me.TextBoxMoveZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxMoveY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxMoveX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxTransArrow.SuspendLayout()
        CType(Me.TextboxIncTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabZoom.SuspendLayout()
        Me.GroupBoxZoomControl.SuspendLayout()
        CType(Me.TextBoxZoomInc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDebug.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabDocInfo.SuspendLayout()
        Me.TabDebug.SuspendLayout()
        Me.GroupBoxAct.SuspendLayout()
        Me.GroupBoxConstrain.SuspendLayout()
        CType(Me.PictureBoxMakara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInfo.SuspendLayout()
        Me.GroupBoxArrowTrans.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicArrowUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicArrowLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicArrowDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicArrowRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxActPic.SuspendLayout()
        CType(Me.PicAct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxFlexPic.SuspendLayout()
        CType(Me.PicFlex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOrientation.SuspendLayout()
        CType(Me.PicOrientation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxEuler.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSerial.SuspendLayout()
        Me.GroupBoxSerial.SuspendLayout()
        Me.groupBoxSerialOptions.SuspendLayout()
        Me.groupBoxSerialMode.SuspendLayout()
        Me.TabPres.SuspendLayout()
        Me.tabPPT.SuspendLayout()
        CType(Me.NumericUpDownPPT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSlidesCtrl.SuspendLayout()
        Me.GroupBoxPPT.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxZoomArb
        '
        GroupBoxZoomArb.Controls.Add(Me.TextBoxWZoom)
        GroupBoxZoomArb.Controls.Add(Me.TextBoxHZoom)
        GroupBoxZoomArb.Controls.Add(Me.ButtonZoom)
        GroupBoxZoomArb.Controls.Add(Me.LabelH)
        GroupBoxZoomArb.Controls.Add(Me.LabelW)
        GroupBoxZoomArb.Location = New System.Drawing.Point(6, 141)
        GroupBoxZoomArb.Name = "GroupBoxZoomArb"
        GroupBoxZoomArb.Size = New System.Drawing.Size(143, 103)
        GroupBoxZoomArb.TabIndex = 29
        GroupBoxZoomArb.TabStop = False
        GroupBoxZoomArb.Text = "Preset Zoom (cm)"
        '
        'TextBoxWZoom
        '
        Me.TextBoxWZoom.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TextBoxWZoom.Location = New System.Drawing.Point(69, 32)
        Me.TextBoxWZoom.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.TextBoxWZoom.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.TextBoxWZoom.Name = "TextBoxWZoom"
        Me.TextBoxWZoom.Size = New System.Drawing.Size(49, 21)
        Me.TextBoxWZoom.TabIndex = 33
        Me.ToolTipProto.SetToolTip(Me.TextBoxWZoom, "Preset Zoom values are also used when body is being (re-)selected.")
        Me.TextBoxWZoom.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'TextBoxHZoom
        '
        Me.TextBoxHZoom.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TextBoxHZoom.Location = New System.Drawing.Point(19, 32)
        Me.TextBoxHZoom.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.TextBoxHZoom.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.TextBoxHZoom.Name = "TextBoxHZoom"
        Me.TextBoxHZoom.Size = New System.Drawing.Size(49, 21)
        Me.TextBoxHZoom.TabIndex = 33
        Me.TextBoxHZoom.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'ButtonZoom
        '
        Me.ButtonZoom.Location = New System.Drawing.Point(24, 57)
        Me.ButtonZoom.Name = "ButtonZoom"
        Me.ButtonZoom.Size = New System.Drawing.Size(94, 23)
        Me.ButtonZoom.TabIndex = 2
        Me.ButtonZoom.Text = "Zoom"
        Me.ButtonZoom.UseVisualStyleBackColor = True
        '
        'LabelH
        '
        Me.LabelH.AutoSize = True
        Me.LabelH.Location = New System.Drawing.Point(40, 16)
        Me.LabelH.Name = "LabelH"
        Me.LabelH.Size = New System.Drawing.Size(14, 13)
        Me.LabelH.TabIndex = 4
        Me.LabelH.Text = "H"
        '
        'LabelW
        '
        Me.LabelW.AutoSize = True
        Me.LabelW.Location = New System.Drawing.Point(87, 16)
        Me.LabelW.Name = "LabelW"
        Me.LabelW.Size = New System.Drawing.Size(17, 13)
        Me.LabelW.TabIndex = 5
        Me.LabelW.Text = "W"
        '
        'ArrowLeft
        '
        Me.ArrowLeft.Location = New System.Drawing.Point(19, 43)
        Me.ArrowLeft.Name = "ArrowLeft"
        Me.ArrowLeft.Size = New System.Drawing.Size(30, 23)
        Me.ArrowLeft.TabIndex = 0
        Me.ArrowLeft.Text = "L"
        Me.ArrowLeft.UseVisualStyleBackColor = True
        '
        'up
        '
        Me.up.Location = New System.Drawing.Point(52, 15)
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(30, 23)
        Me.up.TabIndex = 1
        Me.up.Text = "U"
        Me.up.UseVisualStyleBackColor = True
        '
        'ArrowRight
        '
        Me.ArrowRight.Location = New System.Drawing.Point(83, 43)
        Me.ArrowRight.Name = "ArrowRight"
        Me.ArrowRight.Size = New System.Drawing.Size(30, 23)
        Me.ArrowRight.TabIndex = 2
        Me.ArrowRight.Text = "R"
        Me.ArrowRight.UseVisualStyleBackColor = True
        '
        'down
        '
        Me.down.Location = New System.Drawing.Point(52, 70)
        Me.down.Name = "down"
        Me.down.Size = New System.Drawing.Size(30, 23)
        Me.down.TabIndex = 3
        Me.down.Text = "D"
        Me.down.UseVisualStyleBackColor = True
        '
        'rotate
        '
        Me.rotate.Location = New System.Drawing.Point(52, 42)
        Me.rotate.Name = "rotate"
        Me.rotate.Size = New System.Drawing.Size(30, 23)
        Me.rotate.TabIndex = 4
        Me.rotate.Text = "⌂"
        Me.ToolTipProto.SetToolTip(Me.rotate, "Set the Camera (Orbit) View to Home")
        Me.rotate.UseVisualStyleBackColor = True
        '
        'ButtonRotateX
        '
        Me.ButtonRotateX.Location = New System.Drawing.Point(20, 17)
        Me.ButtonRotateX.Name = "ButtonRotateX"
        Me.ButtonRotateX.Size = New System.Drawing.Size(31, 23)
        Me.ButtonRotateX.TabIndex = 19
        Me.ButtonRotateX.Text = "X"
        Me.ButtonRotateX.UseVisualStyleBackColor = True
        '
        'buttonRotateY
        '
        Me.buttonRotateY.Location = New System.Drawing.Point(57, 17)
        Me.buttonRotateY.Name = "buttonRotateY"
        Me.buttonRotateY.Size = New System.Drawing.Size(31, 23)
        Me.buttonRotateY.TabIndex = 20
        Me.buttonRotateY.Text = "Y"
        Me.buttonRotateY.UseVisualStyleBackColor = True
        '
        'ButtonRotateZ
        '
        Me.ButtonRotateZ.Location = New System.Drawing.Point(95, 17)
        Me.ButtonRotateZ.Name = "ButtonRotateZ"
        Me.ButtonRotateZ.Size = New System.Drawing.Size(31, 23)
        Me.ButtonRotateZ.TabIndex = 21
        Me.ButtonRotateZ.Text = "Z"
        Me.ButtonRotateZ.UseVisualStyleBackColor = True
        '
        'ButtonRotbyVal
        '
        Me.ButtonRotbyVal.Location = New System.Drawing.Point(3, 58)
        Me.ButtonRotbyVal.Name = "ButtonRotbyVal"
        Me.ButtonRotbyVal.Size = New System.Drawing.Size(56, 22)
        Me.ButtonRotbyVal.TabIndex = 25
        Me.ButtonRotbyVal.Text = "Rotate"
        Me.ButtonRotbyVal.UseVisualStyleBackColor = True
        '
        'RotationArrow
        '
        Me.RotationArrow.Controls.Add(Me.ButtonFrontPlane)
        Me.RotationArrow.Controls.Add(Me.TextboxIncRot)
        Me.RotationArrow.Controls.Add(Me.LabelIncRot)
        Me.RotationArrow.Controls.Add(Me.down)
        Me.RotationArrow.Controls.Add(Me.ArrowRight)
        Me.RotationArrow.Controls.Add(Me.rotate)
        Me.RotationArrow.Controls.Add(Me.ArrowLeft)
        Me.RotationArrow.Controls.Add(Me.up)
        Me.RotationArrow.Location = New System.Drawing.Point(6, 4)
        Me.RotationArrow.Name = "RotationArrow"
        Me.RotationArrow.Size = New System.Drawing.Size(143, 124)
        Me.RotationArrow.TabIndex = 26
        Me.RotationArrow.TabStop = False
        Me.RotationArrow.Text = "Rotation Arrow"
        '
        'ButtonFrontPlane
        '
        Me.ButtonFrontPlane.Location = New System.Drawing.Point(112, 11)
        Me.ButtonFrontPlane.Name = "ButtonFrontPlane"
        Me.ButtonFrontPlane.Size = New System.Drawing.Size(28, 22)
        Me.ButtonFrontPlane.TabIndex = 36
        Me.ButtonFrontPlane.Text = "┴"
        Me.ToolTipProto.SetToolTip(Me.ButtonFrontPlane, "Set view to front plane and restore zoom." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Required for proper orientation and di" & _
        "rection when using Glove")
        Me.ButtonFrontPlane.UseVisualStyleBackColor = True
        '
        'TextboxIncRot
        '
        Me.TextboxIncRot.DecimalPlaces = 2
        Me.TextboxIncRot.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.TextboxIncRot.Location = New System.Drawing.Point(94, 103)
        Me.TextboxIncRot.Maximum = New Decimal(New Integer() {314, 0, 0, 131072})
        Me.TextboxIncRot.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.TextboxIncRot.Name = "TextboxIncRot"
        Me.TextboxIncRot.Size = New System.Drawing.Size(49, 21)
        Me.TextboxIncRot.TabIndex = 35
        Me.ToolTipProto.SetToolTip(Me.TextboxIncRot, "Adjust increment for smoothness")
        Me.TextboxIncRot.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'LabelIncRot
        '
        Me.LabelIncRot.AutoSize = True
        Me.LabelIncRot.Location = New System.Drawing.Point(0, 106)
        Me.LabelIncRot.Name = "LabelIncRot"
        Me.LabelIncRot.Size = New System.Drawing.Size(83, 13)
        Me.LabelIncRot.TabIndex = 34
        Me.LabelIncRot.Text = "Increment (rad)"
        '
        'GroupRotate90
        '
        Me.GroupRotate90.Controls.Add(Me.ButtonRotateX)
        Me.GroupRotate90.Controls.Add(Me.buttonRotateY)
        Me.GroupRotate90.Controls.Add(Me.ButtonRotateZ)
        Me.GroupRotate90.Location = New System.Drawing.Point(6, 130)
        Me.GroupRotate90.Name = "GroupRotate90"
        Me.GroupRotate90.Size = New System.Drawing.Size(143, 45)
        Me.GroupRotate90.TabIndex = 27
        Me.GroupRotate90.TabStop = False
        Me.GroupRotate90.Text = "Rot. by 90° along axis"
        '
        'GroupRotateCustom
        '
        Me.GroupRotateCustom.Controls.Add(Me.InputZ)
        Me.GroupRotateCustom.Controls.Add(Me.InputY)
        Me.GroupRotateCustom.Controls.Add(Me.inputX)
        Me.GroupRotateCustom.Controls.Add(Me.LabelZ)
        Me.GroupRotateCustom.Controls.Add(Me.LabelY)
        Me.GroupRotateCustom.Controls.Add(Me.LabelX)
        Me.GroupRotateCustom.Controls.Add(Me.ButtonRotbyVal)
        Me.GroupRotateCustom.Location = New System.Drawing.Point(6, 175)
        Me.GroupRotateCustom.Name = "GroupRotateCustom"
        Me.GroupRotateCustom.Size = New System.Drawing.Size(143, 85)
        Me.GroupRotateCustom.TabIndex = 28
        Me.GroupRotateCustom.TabStop = False
        Me.GroupRotateCustom.Text = "Arbitrary Rotate (Rad)"
        '
        'InputZ
        '
        Me.InputZ.DecimalPlaces = 2
        Me.InputZ.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.InputZ.Location = New System.Drawing.Point(95, 33)
        Me.InputZ.Maximum = New Decimal(New Integer() {314, 0, 0, 131072})
        Me.InputZ.Minimum = New Decimal(New Integer() {314, 0, 0, -2147352576})
        Me.InputZ.Name = "InputZ"
        Me.InputZ.Size = New System.Drawing.Size(44, 21)
        Me.InputZ.TabIndex = 29
        '
        'InputY
        '
        Me.InputY.DecimalPlaces = 2
        Me.InputY.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.InputY.Location = New System.Drawing.Point(50, 33)
        Me.InputY.Maximum = New Decimal(New Integer() {314, 0, 0, 131072})
        Me.InputY.Minimum = New Decimal(New Integer() {314, 0, 0, -2147352576})
        Me.InputY.Name = "InputY"
        Me.InputY.Size = New System.Drawing.Size(44, 21)
        Me.InputY.TabIndex = 29
        '
        'inputX
        '
        Me.inputX.DecimalPlaces = 2
        Me.inputX.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.inputX.Location = New System.Drawing.Point(7, 33)
        Me.inputX.Maximum = New Decimal(New Integer() {314, 0, 0, 131072})
        Me.inputX.Minimum = New Decimal(New Integer() {314, 0, 0, -2147352576})
        Me.inputX.Name = "inputX"
        Me.inputX.Size = New System.Drawing.Size(44, 21)
        Me.inputX.TabIndex = 29
        '
        'LabelZ
        '
        Me.LabelZ.AutoSize = True
        Me.LabelZ.Location = New System.Drawing.Point(109, 17)
        Me.LabelZ.Name = "LabelZ"
        Me.LabelZ.Size = New System.Drawing.Size(13, 13)
        Me.LabelZ.TabIndex = 28
        Me.LabelZ.Text = "Z"
        '
        'LabelY
        '
        Me.LabelY.AutoSize = True
        Me.LabelY.Location = New System.Drawing.Point(64, 17)
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Size = New System.Drawing.Size(13, 13)
        Me.LabelY.TabIndex = 27
        Me.LabelY.Text = "Y"
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Location = New System.Drawing.Point(19, 17)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(13, 13)
        Me.LabelX.TabIndex = 26
        Me.LabelX.Text = "X"
        '
        'CheckBoxRot
        '
        Me.CheckBoxRot.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBoxRot.AutoSize = True
        Me.CheckBoxRot.Checked = True
        Me.CheckBoxRot.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRot.Location = New System.Drawing.Point(7, 263)
        Me.CheckBoxRot.Name = "CheckBoxRot"
        Me.CheckBoxRot.Size = New System.Drawing.Size(112, 23)
        Me.CheckBoxRot.TabIndex = 6
        Me.CheckBoxRot.Text = "Rot. Body / Camera"
        Me.ToolTipProto.SetToolTip(Me.CheckBoxRot, "Toggle between rotating camera and rotating the actual object")
        Me.CheckBoxRot.UseVisualStyleBackColor = True
        '
        'TextboxDebug
        '
        Me.TextboxDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxDebug.Location = New System.Drawing.Point(2, 3)
        Me.TextboxDebug.Multiline = True
        Me.TextboxDebug.Name = "TextboxDebug"
        Me.TextboxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextboxDebug.Size = New System.Drawing.Size(193, 46)
        Me.TextboxDebug.TabIndex = 30
        Me.ToolTipProto.SetToolTip(Me.TextboxDebug, "Containes debugging info")
        '
        'tabOption
        '
        Me.tabOption.Controls.Add(Me.tabRotation)
        Me.tabOption.Controls.Add(Me.TabTranslate)
        Me.tabOption.Controls.Add(Me.TabZoom)
        Me.tabOption.Location = New System.Drawing.Point(5, 8)
        Me.tabOption.Name = "tabOption"
        Me.tabOption.SelectedIndex = 0
        Me.tabOption.Size = New System.Drawing.Size(165, 337)
        Me.tabOption.TabIndex = 39
        Me.ToolTipProto.SetToolTip(Me.tabOption, "Manual Control")
        '
        'tabRotation
        '
        Me.tabRotation.Controls.Add(Me.InputScalingRot)
        Me.tabRotation.Controls.Add(Me.LabelScalingRotUnit)
        Me.tabRotation.Controls.Add(Me.LabelScalingRot)
        Me.tabRotation.Controls.Add(Me.CheckBoxRot)
        Me.tabRotation.Controls.Add(Me.RotationArrow)
        Me.tabRotation.Controls.Add(Me.GroupRotateCustom)
        Me.tabRotation.Controls.Add(Me.GroupRotate90)
        Me.tabRotation.Location = New System.Drawing.Point(4, 22)
        Me.tabRotation.Name = "tabRotation"
        Me.tabRotation.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRotation.Size = New System.Drawing.Size(157, 311)
        Me.tabRotation.TabIndex = 0
        Me.tabRotation.Text = "Rotation"
        Me.tabRotation.UseVisualStyleBackColor = True
        '
        'InputScalingRot
        '
        Me.InputScalingRot.DecimalPlaces = 1
        Me.InputScalingRot.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.InputScalingRot.Location = New System.Drawing.Point(87, 289)
        Me.InputScalingRot.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.InputScalingRot.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.InputScalingRot.Name = "InputScalingRot"
        Me.InputScalingRot.Size = New System.Drawing.Size(49, 21)
        Me.InputScalingRot.TabIndex = 35
        Me.ToolTipProto.SetToolTip(Me.InputScalingRot, "Adjust the ratio of rotation of the glove and resulting rotation on screen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(e.g" & _
        " 1×scaling factor means 1 rad in glove = 1 rad on screen). " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fine tune for easie" & _
        "r or more precise rotation")
        Me.InputScalingRot.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'LabelScalingRotUnit
        '
        Me.LabelScalingRotUnit.AutoSize = True
        Me.LabelScalingRotUnit.Location = New System.Drawing.Point(135, 291)
        Me.LabelScalingRotUnit.Name = "LabelScalingRotUnit"
        Me.LabelScalingRotUnit.Size = New System.Drawing.Size(15, 13)
        Me.LabelScalingRotUnit.TabIndex = 34
        Me.LabelScalingRotUnit.Text = "×"
        '
        'LabelScalingRot
        '
        Me.LabelScalingRot.AutoSize = True
        Me.LabelScalingRot.Location = New System.Drawing.Point(6, 292)
        Me.LabelScalingRot.Name = "LabelScalingRot"
        Me.LabelScalingRot.Size = New System.Drawing.Size(74, 13)
        Me.LabelScalingRot.TabIndex = 34
        Me.LabelScalingRot.Text = "Scaling Factor"
        '
        'TabTranslate
        '
        Me.TabTranslate.Controls.Add(Me.InputRatioRotTrans)
        Me.TabTranslate.Controls.Add(Me.LabelRatioRotTrans)
        Me.TabTranslate.Controls.Add(Me.GroupBoxTransArb)
        Me.TabTranslate.Controls.Add(Me.GroupBoxTransArrow)
        Me.TabTranslate.Location = New System.Drawing.Point(4, 22)
        Me.TabTranslate.Name = "TabTranslate"
        Me.TabTranslate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTranslate.Size = New System.Drawing.Size(157, 311)
        Me.TabTranslate.TabIndex = 1
        Me.TabTranslate.Text = "Translation"
        Me.TabTranslate.UseVisualStyleBackColor = True
        '
        'InputRatioRotTrans
        '
        Me.InputRatioRotTrans.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.InputRatioRotTrans.Location = New System.Drawing.Point(107, 257)
        Me.InputRatioRotTrans.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.InputRatioRotTrans.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.InputRatioRotTrans.Name = "InputRatioRotTrans"
        Me.InputRatioRotTrans.Size = New System.Drawing.Size(49, 21)
        Me.InputRatioRotTrans.TabIndex = 37
        Me.ToolTipProto.SetToolTip(Me.InputRatioRotTrans, "Adjust Glove Rotation to Object Translation ratio for more fluid movement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Relat" & _
        "ive to part dimension)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.InputRatioRotTrans.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'LabelRatioRotTrans
        '
        Me.LabelRatioRotTrans.AutoSize = True
        Me.LabelRatioRotTrans.Location = New System.Drawing.Point(3, 260)
        Me.LabelRatioRotTrans.Name = "LabelRatioRotTrans"
        Me.LabelRatioRotTrans.Size = New System.Drawing.Size(87, 13)
        Me.LabelRatioRotTrans.TabIndex = 36
        Me.LabelRatioRotTrans.Text = "Rot:Trans. Ratio"
        '
        'GroupBoxTransArb
        '
        Me.GroupBoxTransArb.Controls.Add(Me.TextBoxMoveZ)
        Me.GroupBoxTransArb.Controls.Add(Me.TextBoxMoveY)
        Me.GroupBoxTransArb.Controls.Add(Me.TextBoxMoveX)
        Me.GroupBoxTransArb.Controls.Add(Me.LabelTransX)
        Me.GroupBoxTransArb.Controls.Add(Me.LabelTransZ)
        Me.GroupBoxTransArb.Controls.Add(Me.LabelTransY)
        Me.GroupBoxTransArb.Controls.Add(Me.ButtonTranslate)
        Me.GroupBoxTransArb.Location = New System.Drawing.Point(4, 159)
        Me.GroupBoxTransArb.Name = "GroupBoxTransArb"
        Me.GroupBoxTransArb.Size = New System.Drawing.Size(150, 95)
        Me.GroupBoxTransArb.TabIndex = 32
        Me.GroupBoxTransArb.TabStop = False
        Me.GroupBoxTransArb.Text = "Arbitrary Translate (mm)"
        '
        'TextBoxMoveZ
        '
        Me.TextBoxMoveZ.Location = New System.Drawing.Point(98, 45)
        Me.TextBoxMoveZ.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.TextBoxMoveZ.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.TextBoxMoveZ.Name = "TextBoxMoveZ"
        Me.TextBoxMoveZ.Size = New System.Drawing.Size(49, 21)
        Me.TextBoxMoveZ.TabIndex = 32
        '
        'TextBoxMoveY
        '
        Me.TextBoxMoveY.Location = New System.Drawing.Point(52, 45)
        Me.TextBoxMoveY.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.TextBoxMoveY.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.TextBoxMoveY.Name = "TextBoxMoveY"
        Me.TextBoxMoveY.Size = New System.Drawing.Size(49, 21)
        Me.TextBoxMoveY.TabIndex = 32
        '
        'TextBoxMoveX
        '
        Me.TextBoxMoveX.Location = New System.Drawing.Point(2, 45)
        Me.TextBoxMoveX.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.TextBoxMoveX.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.TextBoxMoveX.Name = "TextBoxMoveX"
        Me.TextBoxMoveX.Size = New System.Drawing.Size(49, 21)
        Me.TextBoxMoveX.TabIndex = 32
        '
        'LabelTransX
        '
        Me.LabelTransX.AutoSize = True
        Me.LabelTransX.Location = New System.Drawing.Point(26, 30)
        Me.LabelTransX.Name = "LabelTransX"
        Me.LabelTransX.Size = New System.Drawing.Size(13, 13)
        Me.LabelTransX.TabIndex = 29
        Me.LabelTransX.Text = "X"
        '
        'LabelTransZ
        '
        Me.LabelTransZ.AutoSize = True
        Me.LabelTransZ.Location = New System.Drawing.Point(101, 29)
        Me.LabelTransZ.Name = "LabelTransZ"
        Me.LabelTransZ.Size = New System.Drawing.Size(13, 13)
        Me.LabelTransZ.TabIndex = 31
        Me.LabelTransZ.Text = "Z"
        '
        'LabelTransY
        '
        Me.LabelTransY.AutoSize = True
        Me.LabelTransY.Location = New System.Drawing.Point(64, 29)
        Me.LabelTransY.Name = "LabelTransY"
        Me.LabelTransY.Size = New System.Drawing.Size(13, 13)
        Me.LabelTransY.TabIndex = 30
        Me.LabelTransY.Text = "Y"
        '
        'ButtonTranslate
        '
        Me.ButtonTranslate.Location = New System.Drawing.Point(31, 69)
        Me.ButtonTranslate.Name = "ButtonTranslate"
        Me.ButtonTranslate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTranslate.TabIndex = 4
        Me.ButtonTranslate.Text = "Translate"
        Me.ButtonTranslate.UseVisualStyleBackColor = True
        '
        'GroupBoxTransArrow
        '
        Me.GroupBoxTransArrow.Controls.Add(Me.ButtonTestMoveAss)
        Me.GroupBoxTransArrow.Controls.Add(Me.ButtonDelAllMoves)
        Me.GroupBoxTransArrow.Controls.Add(Me.TextboxIncTrans)
        Me.GroupBoxTransArrow.Controls.Add(Me.LabelIncTrans)
        Me.GroupBoxTransArrow.Controls.Add(Me.ButtonMoveZdown)
        Me.GroupBoxTransArrow.Controls.Add(Me.ButtonMoveDown)
        Me.GroupBoxTransArrow.Controls.Add(Me.ButtonMoveRight)
        Me.GroupBoxTransArrow.Controls.Add(Me.ButtonMoveZup)
        Me.GroupBoxTransArrow.Controls.Add(Me.ButtonMoveLeft)
        Me.GroupBoxTransArrow.Controls.Add(Me.ButtonMoveUp)
        Me.GroupBoxTransArrow.Location = New System.Drawing.Point(4, 5)
        Me.GroupBoxTransArrow.Name = "GroupBoxTransArrow"
        Me.GroupBoxTransArrow.Size = New System.Drawing.Size(152, 153)
        Me.GroupBoxTransArrow.TabIndex = 27
        Me.GroupBoxTransArrow.TabStop = False
        Me.GroupBoxTransArrow.Text = "Translation Arrow"
        '
        'ButtonTestMoveAss
        '
        Me.ButtonTestMoveAss.Location = New System.Drawing.Point(75, 127)
        Me.ButtonTestMoveAss.Name = "ButtonTestMoveAss"
        Me.ButtonTestMoveAss.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTestMoveAss.TabIndex = 0
        Me.ButtonTestMoveAss.Text = "Test Debug"
        Me.ButtonTestMoveAss.UseVisualStyleBackColor = True
        '
        'ButtonDelAllMoves
        '
        Me.ButtonDelAllMoves.Location = New System.Drawing.Point(41, 55)
        Me.ButtonDelAllMoves.Name = "ButtonDelAllMoves"
        Me.ButtonDelAllMoves.Size = New System.Drawing.Size(29, 23)
        Me.ButtonDelAllMoves.TabIndex = 36
        Me.ButtonDelAllMoves.Text = "⌂"
        Me.ToolTipProto.SetToolTip(Me.ButtonDelAllMoves, "Delete all Move operations, reset part(s) into its initial position and orientati" & _
        "on.")
        Me.ButtonDelAllMoves.UseVisualStyleBackColor = True
        '
        'TextboxIncTrans
        '
        Me.TextboxIncTrans.DecimalPlaces = 1
        Me.TextboxIncTrans.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.TextboxIncTrans.Location = New System.Drawing.Point(9, 127)
        Me.TextboxIncTrans.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.TextboxIncTrans.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.TextboxIncTrans.Name = "TextboxIncTrans"
        Me.TextboxIncTrans.Size = New System.Drawing.Size(49, 21)
        Me.TextboxIncTrans.TabIndex = 35
        Me.ToolTipProto.SetToolTip(Me.TextboxIncTrans, "Adjust increment for smoothness" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Relative to part dimension)")
        Me.TextboxIncTrans.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LabelIncTrans
        '
        Me.LabelIncTrans.AutoSize = True
        Me.LabelIncTrans.Location = New System.Drawing.Point(6, 111)
        Me.LabelIncTrans.Name = "LabelIncTrans"
        Me.LabelIncTrans.Size = New System.Drawing.Size(83, 13)
        Me.LabelIncTrans.TabIndex = 34
        Me.LabelIncTrans.Text = "Increment (mm)"
        '
        'ButtonMoveZdown
        '
        Me.ButtonMoveZdown.Location = New System.Drawing.Point(73, 55)
        Me.ButtonMoveZdown.Name = "ButtonMoveZdown"
        Me.ButtonMoveZdown.Size = New System.Drawing.Size(32, 23)
        Me.ButtonMoveZdown.TabIndex = 6
        Me.ButtonMoveZdown.Text = "+X"
        Me.ButtonMoveZdown.UseVisualStyleBackColor = True
        '
        'ButtonMoveDown
        '
        Me.ButtonMoveDown.Location = New System.Drawing.Point(41, 82)
        Me.ButtonMoveDown.Name = "ButtonMoveDown"
        Me.ButtonMoveDown.Size = New System.Drawing.Size(30, 23)
        Me.ButtonMoveDown.TabIndex = 3
        Me.ButtonMoveDown.Text = "-Y"
        Me.ButtonMoveDown.UseVisualStyleBackColor = True
        '
        'ButtonMoveRight
        '
        Me.ButtonMoveRight.Location = New System.Drawing.Point(114, 35)
        Me.ButtonMoveRight.Name = "ButtonMoveRight"
        Me.ButtonMoveRight.Size = New System.Drawing.Size(30, 23)
        Me.ButtonMoveRight.TabIndex = 2
        Me.ButtonMoveRight.Text = "+Z"
        Me.ButtonMoveRight.UseVisualStyleBackColor = True
        '
        'ButtonMoveZup
        '
        Me.ButtonMoveZup.Location = New System.Drawing.Point(114, 9)
        Me.ButtonMoveZup.Name = "ButtonMoveZup"
        Me.ButtonMoveZup.Size = New System.Drawing.Size(30, 23)
        Me.ButtonMoveZup.TabIndex = 4
        Me.ButtonMoveZup.Text = "-Z"
        Me.ButtonMoveZup.UseVisualStyleBackColor = True
        '
        'ButtonMoveLeft
        '
        Me.ButtonMoveLeft.Location = New System.Drawing.Point(8, 55)
        Me.ButtonMoveLeft.Name = "ButtonMoveLeft"
        Me.ButtonMoveLeft.Size = New System.Drawing.Size(30, 23)
        Me.ButtonMoveLeft.TabIndex = 0
        Me.ButtonMoveLeft.Text = "-X"
        Me.ButtonMoveLeft.UseVisualStyleBackColor = True
        '
        'ButtonMoveUp
        '
        Me.ButtonMoveUp.Location = New System.Drawing.Point(41, 26)
        Me.ButtonMoveUp.Name = "ButtonMoveUp"
        Me.ButtonMoveUp.Size = New System.Drawing.Size(30, 23)
        Me.ButtonMoveUp.TabIndex = 1
        Me.ButtonMoveUp.Text = "+Y"
        Me.ButtonMoveUp.UseVisualStyleBackColor = True
        '
        'TabZoom
        '
        Me.TabZoom.Controls.Add(Me.CheckBoxZoomOpt)
        Me.TabZoom.Controls.Add(Me.GroupBoxZoomControl)
        Me.TabZoom.Controls.Add(GroupBoxZoomArb)
        Me.TabZoom.Location = New System.Drawing.Point(4, 22)
        Me.TabZoom.Name = "TabZoom"
        Me.TabZoom.Padding = New System.Windows.Forms.Padding(3)
        Me.TabZoom.Size = New System.Drawing.Size(157, 311)
        Me.TabZoom.TabIndex = 2
        Me.TabZoom.Text = "Zoom"
        Me.ToolTipProto.SetToolTip(Me.TabZoom, "Preset Zoom values are also used when body is being (re-)selected.")
        Me.TabZoom.ToolTipText = "Preset Zoom values are also used when body is being (re-)selected."
        Me.TabZoom.UseVisualStyleBackColor = True
        '
        'CheckBoxZoomOpt
        '
        Me.CheckBoxZoomOpt.AutoSize = True
        Me.CheckBoxZoomOpt.Location = New System.Drawing.Point(6, 250)
        Me.CheckBoxZoomOpt.Name = "CheckBoxZoomOpt"
        Me.CheckBoxZoomOpt.Size = New System.Drawing.Size(111, 30)
        Me.CheckBoxZoomOpt.TabIndex = 43
        Me.CheckBoxZoomOpt.Text = "Zoom with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Up/Down Gesture"
        Me.CheckBoxZoomOpt.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolTipProto.SetToolTip(Me.CheckBoxZoomOpt, "Toggle between twisting zoom and up-down zoom")
        Me.CheckBoxZoomOpt.UseVisualStyleBackColor = True
        '
        'GroupBoxZoomControl
        '
        Me.GroupBoxZoomControl.Controls.Add(Me.TextBoxZoomInc)
        Me.GroupBoxZoomControl.Controls.Add(Me.LabelIncZoom)
        Me.GroupBoxZoomControl.Controls.Add(Me.ButtonZoomIn)
        Me.GroupBoxZoomControl.Controls.Add(Me.ButtonZoomOut)
        Me.GroupBoxZoomControl.Location = New System.Drawing.Point(6, 7)
        Me.GroupBoxZoomControl.Name = "GroupBoxZoomControl"
        Me.GroupBoxZoomControl.Size = New System.Drawing.Size(143, 127)
        Me.GroupBoxZoomControl.TabIndex = 42
        Me.GroupBoxZoomControl.TabStop = False
        Me.GroupBoxZoomControl.Text = "Zoom Control"
        '
        'TextBoxZoomInc
        '
        Me.TextBoxZoomInc.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.TextBoxZoomInc.Location = New System.Drawing.Point(7, 97)
        Me.TextBoxZoomInc.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.TextBoxZoomInc.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TextBoxZoomInc.Name = "TextBoxZoomInc"
        Me.TextBoxZoomInc.Size = New System.Drawing.Size(49, 21)
        Me.TextBoxZoomInc.TabIndex = 33
        Me.ToolTipProto.SetToolTip(Me.TextBoxZoomInc, "Adjust Zoom increment ratio for more fluid zooming operation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.TextBoxZoomInc.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'LabelIncZoom
        '
        Me.LabelIncZoom.AutoSize = True
        Me.LabelIncZoom.Location = New System.Drawing.Point(4, 81)
        Me.LabelIncZoom.Name = "LabelIncZoom"
        Me.LabelIncZoom.Size = New System.Drawing.Size(80, 13)
        Me.LabelIncZoom.TabIndex = 8
        Me.LabelIncZoom.Text = "Increment (cm)"
        '
        'ButtonZoomIn
        '
        Me.ButtonZoomIn.Location = New System.Drawing.Point(7, 20)
        Me.ButtonZoomIn.Name = "ButtonZoomIn"
        Me.ButtonZoomIn.Size = New System.Drawing.Size(97, 23)
        Me.ButtonZoomIn.TabIndex = 3
        Me.ButtonZoomIn.Text = "Zoom In [ + ]"
        Me.ButtonZoomIn.UseVisualStyleBackColor = True
        '
        'ButtonZoomOut
        '
        Me.ButtonZoomOut.Location = New System.Drawing.Point(7, 50)
        Me.ButtonZoomOut.Name = "ButtonZoomOut"
        Me.ButtonZoomOut.Size = New System.Drawing.Size(97, 23)
        Me.ButtonZoomOut.TabIndex = 6
        Me.ButtonZoomOut.Text = "Zoom Out [ - ]"
        Me.ButtonZoomOut.UseVisualStyleBackColor = True
        '
        'GroupBoxDebug
        '
        Me.GroupBoxDebug.Controls.Add(Me.TabControl)
        Me.GroupBoxDebug.Controls.Add(Me.CheckBoxConnect)
        Me.GroupBoxDebug.Controls.Add(Me.ButtonSelBody)
        Me.GroupBoxDebug.Location = New System.Drawing.Point(174, 126)
        Me.GroupBoxDebug.Name = "GroupBoxDebug"
        Me.GroupBoxDebug.Size = New System.Drawing.Size(214, 109)
        Me.GroupBoxDebug.TabIndex = 40
        Me.GroupBoxDebug.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabDocInfo)
        Me.TabControl.Controls.Add(Me.TabDebug)
        Me.TabControl.Location = New System.Drawing.Point(6, 1)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(206, 78)
        Me.TabControl.TabIndex = 39
        '
        'TabDocInfo
        '
        Me.TabDocInfo.Controls.Add(Me.TextBoxSelPart)
        Me.TabDocInfo.Controls.Add(Me.TextBoxFileName)
        Me.TabDocInfo.Controls.Add(Me.LabelSelPart)
        Me.TabDocInfo.Controls.Add(Me.LabelFileName)
        Me.TabDocInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabDocInfo.Name = "TabDocInfo"
        Me.TabDocInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDocInfo.Size = New System.Drawing.Size(198, 52)
        Me.TabDocInfo.TabIndex = 0
        Me.TabDocInfo.Text = "Document  Info"
        Me.TabDocInfo.UseVisualStyleBackColor = True
        '
        'TextBoxSelPart
        '
        Me.TextBoxSelPart.Location = New System.Drawing.Point(60, 27)
        Me.TextBoxSelPart.Name = "TextBoxSelPart"
        Me.TextBoxSelPart.ReadOnly = True
        Me.TextBoxSelPart.Size = New System.Drawing.Size(133, 21)
        Me.TextBoxSelPart.TabIndex = 2
        '
        'TextBoxFileName
        '
        Me.TextBoxFileName.Location = New System.Drawing.Point(60, 3)
        Me.TextBoxFileName.Name = "TextBoxFileName"
        Me.TextBoxFileName.ReadOnly = True
        Me.TextBoxFileName.Size = New System.Drawing.Size(133, 21)
        Me.TextBoxFileName.TabIndex = 2
        '
        'LabelSelPart
        '
        Me.LabelSelPart.AutoSize = True
        Me.LabelSelPart.Location = New System.Drawing.Point(3, 31)
        Me.LabelSelPart.Name = "LabelSelPart"
        Me.LabelSelPart.Size = New System.Drawing.Size(27, 13)
        Me.LabelSelPart.TabIndex = 1
        Me.LabelSelPart.Text = "Part"
        '
        'LabelFileName
        '
        Me.LabelFileName.AutoSize = True
        Me.LabelFileName.Location = New System.Drawing.Point(2, 7)
        Me.LabelFileName.Name = "LabelFileName"
        Me.LabelFileName.Size = New System.Drawing.Size(53, 13)
        Me.LabelFileName.TabIndex = 0
        Me.LabelFileName.Text = "File Name"
        '
        'TabDebug
        '
        Me.TabDebug.Controls.Add(Me.TextboxDebug)
        Me.TabDebug.Location = New System.Drawing.Point(4, 22)
        Me.TabDebug.Name = "TabDebug"
        Me.TabDebug.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDebug.Size = New System.Drawing.Size(198, 52)
        Me.TabDebug.TabIndex = 1
        Me.TabDebug.Text = "Debug"
        Me.TabDebug.UseVisualStyleBackColor = True
        '
        'CheckBoxConnect
        '
        Me.CheckBoxConnect.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBoxConnect.AutoSize = True
        Me.CheckBoxConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBoxConnect.Enabled = False
        Me.CheckBoxConnect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.CheckBoxConnect.Location = New System.Drawing.Point(5, 81)
        Me.CheckBoxConnect.Name = "CheckBoxConnect"
        Me.CheckBoxConnect.Size = New System.Drawing.Size(87, 23)
        Me.CheckBoxConnect.TabIndex = 38
        Me.CheckBoxConnect.Text = "Toggle Control"
        Me.ToolTipProto.SetToolTip(Me.CheckBoxConnect, "Connect/Disconnect control to Inventor")
        Me.CheckBoxConnect.UseVisualStyleBackColor = True
        '
        'ButtonSelBody
        '
        Me.ButtonSelBody.Location = New System.Drawing.Point(100, 81)
        Me.ButtonSelBody.Name = "ButtonSelBody"
        Me.ButtonSelBody.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonSelBody.Size = New System.Drawing.Size(110, 23)
        Me.ButtonSelBody.TabIndex = 37
        Me.ButtonSelBody.Text = "(Re-)Select Part"
        Me.ToolTipProto.SetToolTip(Me.ButtonSelBody, "Part needs to be reselected if current file is changed/reopened." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make sure Front" & _
        " plane correspond with →X↑Y on the axes Triad!")
        Me.ButtonSelBody.UseVisualStyleBackColor = True
        '
        'LabelNotice
        '
        Me.LabelNotice.AutoSize = True
        Me.LabelNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelNotice.ForeColor = System.Drawing.Color.Red
        Me.LabelNotice.Location = New System.Drawing.Point(168, 111)
        Me.LabelNotice.Name = "LabelNotice"
        Me.LabelNotice.Size = New System.Drawing.Size(221, 13)
        Me.LabelNotice.TabIndex = 40
        Me.LabelNotice.Text = "Open any 3D model and select a part!"
        '
        'GroupBoxAct
        '
        Me.GroupBoxAct.Controls.Add(Me.RadioButtonNone)
        Me.GroupBoxAct.Controls.Add(Me.RadioButtonZoom)
        Me.GroupBoxAct.Controls.Add(Me.RadioButtonTranslation)
        Me.GroupBoxAct.Controls.Add(Me.RadioButtonRotation)
        Me.GroupBoxAct.Enabled = False
        Me.GroupBoxAct.Location = New System.Drawing.Point(174, 239)
        Me.GroupBoxAct.Name = "GroupBoxAct"
        Me.GroupBoxAct.Size = New System.Drawing.Size(103, 104)
        Me.GroupBoxAct.TabIndex = 41
        Me.GroupBoxAct.TabStop = False
        Me.GroupBoxAct.Text = "Override Flex"
        Me.ToolTipProto.SetToolTip(Me.GroupBoxAct, "Override Flex State")
        '
        'RadioButtonNone
        '
        Me.RadioButtonNone.AutoSize = True
        Me.RadioButtonNone.Checked = True
        Me.RadioButtonNone.Location = New System.Drawing.Point(5, 83)
        Me.RadioButtonNone.Name = "RadioButtonNone"
        Me.RadioButtonNone.Size = New System.Drawing.Size(41, 17)
        Me.RadioButtonNone.TabIndex = 3
        Me.RadioButtonNone.TabStop = True
        Me.RadioButtonNone.Text = "Off"
        Me.RadioButtonNone.UseVisualStyleBackColor = True
        '
        'RadioButtonZoom
        '
        Me.RadioButtonZoom.AutoSize = True
        Me.RadioButtonZoom.Location = New System.Drawing.Point(5, 62)
        Me.RadioButtonZoom.Name = "RadioButtonZoom"
        Me.RadioButtonZoom.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonZoom.TabIndex = 5
        Me.RadioButtonZoom.TabStop = True
        Me.RadioButtonZoom.Text = "Zoom"
        Me.RadioButtonZoom.UseVisualStyleBackColor = True
        '
        'RadioButtonTranslation
        '
        Me.RadioButtonTranslation.AutoSize = True
        Me.RadioButtonTranslation.Location = New System.Drawing.Point(5, 41)
        Me.RadioButtonTranslation.Name = "RadioButtonTranslation"
        Me.RadioButtonTranslation.Size = New System.Drawing.Size(78, 17)
        Me.RadioButtonTranslation.TabIndex = 4
        Me.RadioButtonTranslation.TabStop = True
        Me.RadioButtonTranslation.Text = "Translation"
        Me.RadioButtonTranslation.UseVisualStyleBackColor = True
        '
        'RadioButtonRotation
        '
        Me.RadioButtonRotation.AutoSize = True
        Me.RadioButtonRotation.Location = New System.Drawing.Point(5, 19)
        Me.RadioButtonRotation.Name = "RadioButtonRotation"
        Me.RadioButtonRotation.Size = New System.Drawing.Size(66, 17)
        Me.RadioButtonRotation.TabIndex = 3
        Me.RadioButtonRotation.TabStop = True
        Me.RadioButtonRotation.Text = "Rotation"
        Me.RadioButtonRotation.UseVisualStyleBackColor = True
        '
        'LabelAbout
        '
        Me.LabelAbout.AutoSize = True
        Me.LabelAbout.Location = New System.Drawing.Point(172, 10)
        Me.LabelAbout.Name = "LabelAbout"
        Me.LabelAbout.Size = New System.Drawing.Size(198, 78)
        Me.LabelAbout.TabIndex = 42
        Me.LabelAbout.Text = "Universitas Indonesia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laboratory of Manufacturing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Automation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Part of Und" & _
    "ergraduate Thesis" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "© 2013-2014 Arya Senna && Albert Koto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkProto
        '
        Me.LinkProto.AutoSize = True
        Me.LinkProto.Location = New System.Drawing.Point(173, 94)
        Me.LinkProto.Name = "LinkProto"
        Me.LinkProto.Size = New System.Drawing.Size(150, 13)
        Me.LinkProto.TabIndex = 44
        Me.LinkProto.TabStop = True
        Me.LinkProto.Text = "Prototype Stage (Beta v0.70)"
        '
        'ToolTipProto
        '
        Me.ToolTipProto.AutoPopDelay = 5000
        Me.ToolTipProto.InitialDelay = 500
        Me.ToolTipProto.ReshowDelay = 100
        Me.ToolTipProto.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipProto.ToolTipTitle = "Hint"
        '
        'GroupBoxConstrain
        '
        Me.GroupBoxConstrain.Controls.Add(Me.CheckBoxTgX)
        Me.GroupBoxConstrain.Controls.Add(Me.CheckBoxTgY)
        Me.GroupBoxConstrain.Controls.Add(Me.CheckBoxTgZ)
        Me.GroupBoxConstrain.Enabled = False
        Me.GroupBoxConstrain.Location = New System.Drawing.Point(282, 239)
        Me.GroupBoxConstrain.Name = "GroupBoxConstrain"
        Me.GroupBoxConstrain.Size = New System.Drawing.Size(104, 104)
        Me.GroupBoxConstrain.TabIndex = 45
        Me.GroupBoxConstrain.TabStop = False
        Me.GroupBoxConstrain.Text = "Constrained Motion"
        '
        'CheckBoxTgX
        '
        Me.CheckBoxTgX.AutoSize = True
        Me.CheckBoxTgX.Location = New System.Drawing.Point(5, 83)
        Me.CheckBoxTgX.Name = "CheckBoxTgX"
        Me.CheckBoxTgX.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxTgX.TabIndex = 3
        Me.CheckBoxTgX.Text = "X-Axis"
        Me.CheckBoxTgX.UseVisualStyleBackColor = True
        '
        'CheckBoxTgY
        '
        Me.CheckBoxTgY.AutoSize = True
        Me.CheckBoxTgY.Location = New System.Drawing.Point(5, 60)
        Me.CheckBoxTgY.Name = "CheckBoxTgY"
        Me.CheckBoxTgY.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxTgY.TabIndex = 3
        Me.CheckBoxTgY.Text = "Y-Axis"
        Me.CheckBoxTgY.UseVisualStyleBackColor = True
        '
        'CheckBoxTgZ
        '
        Me.CheckBoxTgZ.AutoSize = True
        Me.CheckBoxTgZ.Checked = True
        Me.CheckBoxTgZ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTgZ.Location = New System.Drawing.Point(5, 37)
        Me.CheckBoxTgZ.Name = "CheckBoxTgZ"
        Me.CheckBoxTgZ.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxTgZ.TabIndex = 3
        Me.CheckBoxTgZ.Text = "2D Rot. Only"
        Me.CheckBoxTgZ.UseVisualStyleBackColor = True
        '
        'PictureBoxMakara
        '
        Me.PictureBoxMakara.Image = CType(resources.GetObject("PictureBoxMakara.Image"), System.Drawing.Image)
        Me.PictureBoxMakara.Location = New System.Drawing.Point(337, 8)
        Me.PictureBoxMakara.Name = "PictureBoxMakara"
        Me.PictureBoxMakara.Size = New System.Drawing.Size(51, 53)
        Me.PictureBoxMakara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxMakara.TabIndex = 43
        Me.PictureBoxMakara.TabStop = False
        '
        'GaugePitch
        '
        Me.GaugePitch.BackColor = System.Drawing.SystemColors.Window
        Me.GaugePitch.BaseArcColor = System.Drawing.Color.Gray
        Me.GaugePitch.BaseArcRadius = 25
        Me.GaugePitch.BaseArcStart = 135
        Me.GaugePitch.BaseArcSweep = 270
        Me.GaugePitch.BaseArcWidth = 2
        Me.GaugePitch.Center = New System.Drawing.Point(36, 40)
        Me.GaugePitch.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.GaugePitch.Location = New System.Drawing.Point(162, 59)
        Me.GaugePitch.MaxValue = 0.6!
        Me.GaugePitch.MinValue = -0.6!
        Me.GaugePitch.Name = "GaugePitch"
        Me.GaugePitch.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red
        Me.GaugePitch.NeedleColor2 = System.Drawing.Color.DimGray
        Me.GaugePitch.NeedleRadius = 20
        Me.GaugePitch.NeedleType = System.Windows.Forms.NeedleType.Simple
        Me.GaugePitch.NeedleWidth = 2
        Me.GaugePitch.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.GaugePitch.ScaleLinesInterInnerRadius = 15
        Me.GaugePitch.ScaleLinesInterOuterRadius = 25
        Me.GaugePitch.ScaleLinesInterWidth = 1
        Me.GaugePitch.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.GaugePitch.ScaleLinesMajorInnerRadius = 15
        Me.GaugePitch.ScaleLinesMajorOuterRadius = 25
        Me.GaugePitch.ScaleLinesMajorStepValue = 0.6!
        Me.GaugePitch.ScaleLinesMajorWidth = 2
        Me.GaugePitch.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.GaugePitch.ScaleLinesMinorInnerRadius = 15
        Me.GaugePitch.ScaleLinesMinorOuterRadius = 25
        Me.GaugePitch.ScaleLinesMinorTicks = 9
        Me.GaugePitch.ScaleLinesMinorWidth = 1
        Me.GaugePitch.ScaleNumbersColor = System.Drawing.Color.Black
        Me.GaugePitch.ScaleNumbersFormat = Nothing
        Me.GaugePitch.ScaleNumbersRadius = 35
        Me.GaugePitch.ScaleNumbersRotation = 0
        Me.GaugePitch.ScaleNumbersStartScaleLine = 0
        Me.GaugePitch.ScaleNumbersStepScaleLines = 1
        Me.GaugePitch.Size = New System.Drawing.Size(70, 70)
        Me.GaugePitch.TabIndex = 2
        Me.GaugePitch.Text = "GaugeRoll"
        Me.GaugePitch.Value = 0.0!
        '
        'GaugeYaw
        '
        Me.GaugeYaw.BackColor = System.Drawing.SystemColors.Window
        Me.GaugeYaw.BaseArcColor = System.Drawing.Color.Gray
        Me.GaugeYaw.BaseArcRadius = 25
        Me.GaugeYaw.BaseArcStart = 135
        Me.GaugeYaw.BaseArcSweep = 270
        Me.GaugeYaw.BaseArcWidth = 2
        Me.GaugeYaw.Center = New System.Drawing.Point(36, 40)
        Me.GaugeYaw.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.GaugeYaw.Location = New System.Drawing.Point(84, 59)
        Me.GaugeYaw.MaxValue = 0.6!
        Me.GaugeYaw.MinValue = -0.6!
        Me.GaugeYaw.Name = "GaugeYaw"
        Me.GaugeYaw.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Blue
        Me.GaugeYaw.NeedleColor2 = System.Drawing.Color.DimGray
        Me.GaugeYaw.NeedleRadius = 20
        Me.GaugeYaw.NeedleType = System.Windows.Forms.NeedleType.Simple
        Me.GaugeYaw.NeedleWidth = 2
        Me.GaugeYaw.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.GaugeYaw.ScaleLinesInterInnerRadius = 15
        Me.GaugeYaw.ScaleLinesInterOuterRadius = 25
        Me.GaugeYaw.ScaleLinesInterWidth = 1
        Me.GaugeYaw.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.GaugeYaw.ScaleLinesMajorInnerRadius = 15
        Me.GaugeYaw.ScaleLinesMajorOuterRadius = 25
        Me.GaugeYaw.ScaleLinesMajorStepValue = 0.6!
        Me.GaugeYaw.ScaleLinesMajorWidth = 2
        Me.GaugeYaw.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.GaugeYaw.ScaleLinesMinorInnerRadius = 15
        Me.GaugeYaw.ScaleLinesMinorOuterRadius = 25
        Me.GaugeYaw.ScaleLinesMinorTicks = 9
        Me.GaugeYaw.ScaleLinesMinorWidth = 1
        Me.GaugeYaw.ScaleNumbersColor = System.Drawing.Color.Black
        Me.GaugeYaw.ScaleNumbersFormat = Nothing
        Me.GaugeYaw.ScaleNumbersRadius = 35
        Me.GaugeYaw.ScaleNumbersRotation = 0
        Me.GaugeYaw.ScaleNumbersStartScaleLine = 0
        Me.GaugeYaw.ScaleNumbersStepScaleLines = 1
        Me.GaugeYaw.Size = New System.Drawing.Size(70, 70)
        Me.GaugeYaw.TabIndex = 2
        Me.GaugeYaw.Text = "GaugeRoll"
        Me.GaugeYaw.Value = 0.0!
        '
        'GaugeRoll
        '
        Me.GaugeRoll.BackColor = System.Drawing.SystemColors.Window
        Me.GaugeRoll.BaseArcColor = System.Drawing.Color.Gray
        Me.GaugeRoll.BaseArcRadius = 25
        Me.GaugeRoll.BaseArcStart = 135
        Me.GaugeRoll.BaseArcSweep = 270
        Me.GaugeRoll.BaseArcWidth = 2
        Me.GaugeRoll.Center = New System.Drawing.Point(36, 40)
        Me.GaugeRoll.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.GaugeRoll.Location = New System.Drawing.Point(5, 59)
        Me.GaugeRoll.MaxValue = 0.6!
        Me.GaugeRoll.MinValue = -0.6!
        Me.GaugeRoll.Name = "GaugeRoll"
        Me.GaugeRoll.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Green
        Me.GaugeRoll.NeedleColor2 = System.Drawing.Color.DimGray
        Me.GaugeRoll.NeedleRadius = 20
        Me.GaugeRoll.NeedleType = System.Windows.Forms.NeedleType.Simple
        Me.GaugeRoll.NeedleWidth = 2
        Me.GaugeRoll.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.GaugeRoll.ScaleLinesInterInnerRadius = 15
        Me.GaugeRoll.ScaleLinesInterOuterRadius = 25
        Me.GaugeRoll.ScaleLinesInterWidth = 1
        Me.GaugeRoll.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.GaugeRoll.ScaleLinesMajorInnerRadius = 15
        Me.GaugeRoll.ScaleLinesMajorOuterRadius = 25
        Me.GaugeRoll.ScaleLinesMajorStepValue = 0.6!
        Me.GaugeRoll.ScaleLinesMajorWidth = 2
        Me.GaugeRoll.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.GaugeRoll.ScaleLinesMinorInnerRadius = 15
        Me.GaugeRoll.ScaleLinesMinorOuterRadius = 25
        Me.GaugeRoll.ScaleLinesMinorTicks = 9
        Me.GaugeRoll.ScaleLinesMinorWidth = 1
        Me.GaugeRoll.ScaleNumbersColor = System.Drawing.Color.Black
        Me.GaugeRoll.ScaleNumbersFormat = Nothing
        Me.GaugeRoll.ScaleNumbersRadius = 35
        Me.GaugeRoll.ScaleNumbersRotation = 0
        Me.GaugeRoll.ScaleNumbersStartScaleLine = 0
        Me.GaugeRoll.ScaleNumbersStepScaleLines = 1
        Me.GaugeRoll.Size = New System.Drawing.Size(70, 70)
        Me.GaugeRoll.TabIndex = 2
        Me.GaugeRoll.Text = "GaugeRoll"
        Me.GaugeRoll.Value = 0.0!
        '
        'TabInfo
        '
        Me.TabInfo.Controls.Add(Me.GroupBoxArrowTrans)
        Me.TabInfo.Controls.Add(Me.GroupBoxActPic)
        Me.TabInfo.Controls.Add(Me.GroupBoxFlexPic)
        Me.TabInfo.Controls.Add(Me.GroupBoxOrientation)
        Me.TabInfo.Controls.Add(Me.GroupBoxEuler)
        Me.TabInfo.Controls.Add(Me.Chart1)
        Me.TabInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabInfo.Name = "TabInfo"
        Me.TabInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInfo.Size = New System.Drawing.Size(366, 311)
        Me.TabInfo.TabIndex = 1
        Me.TabInfo.Text = "Information"
        Me.TabInfo.UseVisualStyleBackColor = True
        '
        'GroupBoxArrowTrans
        '
        Me.GroupBoxArrowTrans.Controls.Add(Me.PictureBox1)
        Me.GroupBoxArrowTrans.Controls.Add(Me.PicArrowUp)
        Me.GroupBoxArrowTrans.Controls.Add(Me.PicArrowLeft)
        Me.GroupBoxArrowTrans.Controls.Add(Me.PicArrowDown)
        Me.GroupBoxArrowTrans.Controls.Add(Me.PicArrowRight)
        Me.GroupBoxArrowTrans.Location = New System.Drawing.Point(6, 141)
        Me.GroupBoxArrowTrans.Name = "GroupBoxArrowTrans"
        Me.GroupBoxArrowTrans.Size = New System.Drawing.Size(238, 165)
        Me.GroupBoxArrowTrans.TabIndex = 7
        Me.GroupBoxArrowTrans.TabStop = False
        Me.GroupBoxArrowTrans.Text = "X- Y Translation"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.InvenGlove.My.Resources.Resources.pointhand
        Me.PictureBox1.Location = New System.Drawing.Point(86, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PicArrowUp
        '
        Me.PicArrowUp.Image = CType(resources.GetObject("PicArrowUp.Image"), System.Drawing.Image)
        Me.PicArrowUp.Location = New System.Drawing.Point(95, 13)
        Me.PicArrowUp.Name = "PicArrowUp"
        Me.PicArrowUp.Size = New System.Drawing.Size(45, 45)
        Me.PicArrowUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicArrowUp.TabIndex = 0
        Me.PicArrowUp.TabStop = False
        '
        'PicArrowLeft
        '
        Me.PicArrowLeft.Image = CType(resources.GetObject("PicArrowLeft.Image"), System.Drawing.Image)
        Me.PicArrowLeft.Location = New System.Drawing.Point(39, 66)
        Me.PicArrowLeft.Name = "PicArrowLeft"
        Me.PicArrowLeft.Size = New System.Drawing.Size(45, 45)
        Me.PicArrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicArrowLeft.TabIndex = 0
        Me.PicArrowLeft.TabStop = False
        '
        'PicArrowDown
        '
        Me.PicArrowDown.Image = CType(resources.GetObject("PicArrowDown.Image"), System.Drawing.Image)
        Me.PicArrowDown.Location = New System.Drawing.Point(95, 118)
        Me.PicArrowDown.Name = "PicArrowDown"
        Me.PicArrowDown.Size = New System.Drawing.Size(45, 45)
        Me.PicArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicArrowDown.TabIndex = 0
        Me.PicArrowDown.TabStop = False
        '
        'PicArrowRight
        '
        Me.PicArrowRight.Image = CType(resources.GetObject("PicArrowRight.Image"), System.Drawing.Image)
        Me.PicArrowRight.Location = New System.Drawing.Point(149, 66)
        Me.PicArrowRight.Name = "PicArrowRight"
        Me.PicArrowRight.Size = New System.Drawing.Size(45, 45)
        Me.PicArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicArrowRight.TabIndex = 0
        Me.PicArrowRight.TabStop = False
        '
        'GroupBoxActPic
        '
        Me.GroupBoxActPic.Controls.Add(Me.LabelActState)
        Me.GroupBoxActPic.Controls.Add(Me.PicAct)
        Me.GroupBoxActPic.Location = New System.Drawing.Point(250, 80)
        Me.GroupBoxActPic.Name = "GroupBoxActPic"
        Me.GroupBoxActPic.Size = New System.Drawing.Size(113, 79)
        Me.GroupBoxActPic.TabIndex = 5
        Me.GroupBoxActPic.TabStop = False
        Me.GroupBoxActPic.Text = "Operation"
        '
        'LabelActState
        '
        Me.LabelActState.AutoSize = True
        Me.LabelActState.Location = New System.Drawing.Point(33, 60)
        Me.LabelActState.Name = "LabelActState"
        Me.LabelActState.Size = New System.Drawing.Size(42, 13)
        Me.LabelActState.TabIndex = 1
        Me.LabelActState.Text = "Neutral"
        Me.LabelActState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicAct
        '
        Me.PicAct.Image = CType(resources.GetObject("PicAct.Image"), System.Drawing.Image)
        Me.PicAct.Location = New System.Drawing.Point(35, 19)
        Me.PicAct.Name = "PicAct"
        Me.PicAct.Size = New System.Drawing.Size(35, 35)
        Me.PicAct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAct.TabIndex = 0
        Me.PicAct.TabStop = False
        '
        'GroupBoxFlexPic
        '
        Me.GroupBoxFlexPic.Controls.Add(Me.LabelFlexState)
        Me.GroupBoxFlexPic.Controls.Add(Me.PicFlex)
        Me.GroupBoxFlexPic.Location = New System.Drawing.Point(250, 165)
        Me.GroupBoxFlexPic.Name = "GroupBoxFlexPic"
        Me.GroupBoxFlexPic.Size = New System.Drawing.Size(110, 139)
        Me.GroupBoxFlexPic.TabIndex = 4
        Me.GroupBoxFlexPic.TabStop = False
        Me.GroupBoxFlexPic.Text = "Flex"
        '
        'LabelFlexState
        '
        Me.LabelFlexState.AutoSize = True
        Me.LabelFlexState.Location = New System.Drawing.Point(37, 118)
        Me.LabelFlexState.Name = "LabelFlexState"
        Me.LabelFlexState.Size = New System.Drawing.Size(33, 13)
        Me.LabelFlexState.TabIndex = 1
        Me.LabelFlexState.Text = "Open"
        '
        'PicFlex
        '
        Me.PicFlex.Image = CType(resources.GetObject("PicFlex.Image"), System.Drawing.Image)
        Me.PicFlex.Location = New System.Drawing.Point(9, 32)
        Me.PicFlex.Name = "PicFlex"
        Me.PicFlex.Size = New System.Drawing.Size(101, 79)
        Me.PicFlex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicFlex.TabIndex = 0
        Me.PicFlex.TabStop = False
        '
        'GroupBoxOrientation
        '
        Me.GroupBoxOrientation.Controls.Add(Me.PicOrientation)
        Me.GroupBoxOrientation.Location = New System.Drawing.Point(250, 6)
        Me.GroupBoxOrientation.Name = "GroupBoxOrientation"
        Me.GroupBoxOrientation.Size = New System.Drawing.Size(110, 72)
        Me.GroupBoxOrientation.TabIndex = 3
        Me.GroupBoxOrientation.TabStop = False
        Me.GroupBoxOrientation.Text = "Orientation"
        '
        'PicOrientation
        '
        Me.PicOrientation.Image = CType(resources.GetObject("PicOrientation.Image"), System.Drawing.Image)
        Me.PicOrientation.Location = New System.Drawing.Point(6, 13)
        Me.PicOrientation.Name = "PicOrientation"
        Me.PicOrientation.Size = New System.Drawing.Size(92, 55)
        Me.PicOrientation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicOrientation.TabIndex = 0
        Me.PicOrientation.TabStop = False
        '
        'GroupBoxEuler
        '
        Me.GroupBoxEuler.Controls.Add(Me.LabelPitch)
        Me.GroupBoxEuler.Controls.Add(Me.LabelYaw)
        Me.GroupBoxEuler.Controls.Add(Me.TextBoxEuX)
        Me.GroupBoxEuler.Controls.Add(Me.LabelRoll)
        Me.GroupBoxEuler.Controls.Add(Me.TextBoxEuY)
        Me.GroupBoxEuler.Controls.Add(Me.TextBoxEuZ)
        Me.GroupBoxEuler.Location = New System.Drawing.Point(6, 6)
        Me.GroupBoxEuler.Name = "GroupBoxEuler"
        Me.GroupBoxEuler.Size = New System.Drawing.Size(238, 135)
        Me.GroupBoxEuler.TabIndex = 2
        Me.GroupBoxEuler.TabStop = False
        Me.GroupBoxEuler.Text = "Angular Speed (rad/100 msec)"
        '
        'LabelPitch
        '
        Me.LabelPitch.AutoSize = True
        Me.LabelPitch.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelPitch.Location = New System.Drawing.Point(179, 19)
        Me.LabelPitch.Name = "LabelPitch"
        Me.LabelPitch.Size = New System.Drawing.Size(35, 13)
        Me.LabelPitch.TabIndex = 1
        Me.LabelPitch.Text = "Pitch"
        '
        'LabelYaw
        '
        Me.LabelYaw.AutoSize = True
        Me.LabelYaw.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelYaw.Location = New System.Drawing.Point(104, 19)
        Me.LabelYaw.Name = "LabelYaw"
        Me.LabelYaw.Size = New System.Drawing.Size(30, 13)
        Me.LabelYaw.TabIndex = 1
        Me.LabelYaw.Text = "Yaw"
        '
        'TextBoxEuX
        '
        Me.TextBoxEuX.Location = New System.Drawing.Point(5, 35)
        Me.TextBoxEuX.Name = "TextBoxEuX"
        Me.TextBoxEuX.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxEuX.TabIndex = 0
        Me.TextBoxEuX.Text = ""
        '
        'LabelRoll
        '
        Me.LabelRoll.AutoSize = True
        Me.LabelRoll.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LabelRoll.Location = New System.Drawing.Point(26, 19)
        Me.LabelRoll.Name = "LabelRoll"
        Me.LabelRoll.Size = New System.Drawing.Size(28, 13)
        Me.LabelRoll.TabIndex = 1
        Me.LabelRoll.Text = "Roll"
        '
        'TextBoxEuY
        '
        Me.TextBoxEuY.Location = New System.Drawing.Point(84, 35)
        Me.TextBoxEuY.Name = "TextBoxEuY"
        Me.TextBoxEuY.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxEuY.TabIndex = 0
        Me.TextBoxEuY.Text = ""
        '
        'TextBoxEuZ
        '
        Me.TextBoxEuZ.Location = New System.Drawing.Point(162, 35)
        Me.TextBoxEuZ.Name = "TextBoxEuZ"
        Me.TextBoxEuZ.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxEuZ.TabIndex = 0
        Me.TextBoxEuZ.Text = ""
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Me.Chart1.DataSource = Me.Chart1.Annotations
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(24, 3)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(0, 0)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TabSerial
        '
        Me.TabSerial.Controls.Add(Me.GroupBoxSerial)
        Me.TabSerial.Controls.Add(Me.groupBoxSerialOptions)
        Me.TabSerial.Controls.Add(Me.groupBoxSerialMode)
        Me.TabSerial.Location = New System.Drawing.Point(4, 22)
        Me.TabSerial.Name = "TabSerial"
        Me.TabSerial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSerial.Size = New System.Drawing.Size(366, 311)
        Me.TabSerial.TabIndex = 0
        Me.TabSerial.Text = "Serial Control"
        Me.TabSerial.UseVisualStyleBackColor = True
        '
        'GroupBoxSerial
        '
        Me.GroupBoxSerial.Controls.Add(Me.CheckBoxViewOutput)
        Me.GroupBoxSerial.Controls.Add(Me.cmdSend)
        Me.GroupBoxSerial.Controls.Add(Me.rtbDisplay)
        Me.GroupBoxSerial.Controls.Add(Me.cmdClose)
        Me.GroupBoxSerial.Controls.Add(Me.cmdOpen)
        Me.GroupBoxSerial.Location = New System.Drawing.Point(6, 3)
        Me.GroupBoxSerial.Name = "GroupBoxSerial"
        Me.GroupBoxSerial.Size = New System.Drawing.Size(262, 305)
        Me.GroupBoxSerial.TabIndex = 14
        Me.GroupBoxSerial.TabStop = False
        Me.GroupBoxSerial.Text = "Serial Port Communication"
        '
        'CheckBoxViewOutput
        '
        Me.CheckBoxViewOutput.AutoSize = True
        Me.CheckBoxViewOutput.Checked = True
        Me.CheckBoxViewOutput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxViewOutput.Location = New System.Drawing.Point(194, 271)
        Me.CheckBoxViewOutput.Name = "CheckBoxViewOutput"
        Me.CheckBoxViewOutput.Size = New System.Drawing.Size(60, 30)
        Me.CheckBoxViewOutput.TabIndex = 19
        Me.CheckBoxViewOutput.Text = "Enable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Output"
        Me.CheckBoxViewOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxViewOutput.UseVisualStyleBackColor = True
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(475, 259)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(75, 23)
        Me.cmdSend.TabIndex = 5
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDisplay.Location = New System.Drawing.Point(3, 16)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.Size = New System.Drawing.Size(253, 251)
        Me.rtbDisplay.TabIndex = 3
        Me.rtbDisplay.Text = ""
        '
        'cmdClose
        '
        Me.cmdClose.Enabled = False
        Me.cmdClose.Location = New System.Drawing.Point(3, 273)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(88, 23)
        Me.cmdClose.TabIndex = 15
        Me.cmdClose.Text = "Close Port"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(97, 273)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(86, 23)
        Me.cmdOpen.TabIndex = 18
        Me.cmdOpen.Text = "Open Port"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'groupBoxSerialOptions
        '
        Me.groupBoxSerialOptions.Controls.Add(Me.labelDB)
        Me.groupBoxSerialOptions.Controls.Add(Me.cboData)
        Me.groupBoxSerialOptions.Controls.Add(Me.labelSB)
        Me.groupBoxSerialOptions.Controls.Add(Me.cboStop)
        Me.groupBoxSerialOptions.Controls.Add(Me.labelParity)
        Me.groupBoxSerialOptions.Controls.Add(Me.labelBaud)
        Me.groupBoxSerialOptions.Controls.Add(Me.cboParity)
        Me.groupBoxSerialOptions.Controls.Add(Me.LabelPort)
        Me.groupBoxSerialOptions.Controls.Add(Me.cboBaud)
        Me.groupBoxSerialOptions.Controls.Add(Me.cboPort)
        Me.groupBoxSerialOptions.Location = New System.Drawing.Point(274, 6)
        Me.groupBoxSerialOptions.Name = "groupBoxSerialOptions"
        Me.groupBoxSerialOptions.Size = New System.Drawing.Size(96, 245)
        Me.groupBoxSerialOptions.TabIndex = 16
        Me.groupBoxSerialOptions.TabStop = False
        Me.groupBoxSerialOptions.Text = "Options"
        '
        'labelDB
        '
        Me.labelDB.AutoSize = True
        Me.labelDB.Location = New System.Drawing.Point(6, 179)
        Me.labelDB.Name = "labelDB"
        Me.labelDB.Size = New System.Drawing.Size(50, 13)
        Me.labelDB.TabIndex = 19
        Me.labelDB.Text = "Data Bits"
        '
        'cboData
        '
        Me.cboData.FormattingEnabled = True
        Me.cboData.Items.AddRange(New Object() {"7", "8", "9"})
        Me.cboData.Location = New System.Drawing.Point(9, 195)
        Me.cboData.Name = "cboData"
        Me.cboData.Size = New System.Drawing.Size(76, 21)
        Me.cboData.TabIndex = 14
        '
        'labelSB
        '
        Me.labelSB.AutoSize = True
        Me.labelSB.Location = New System.Drawing.Point(7, 139)
        Me.labelSB.Name = "labelSB"
        Me.labelSB.Size = New System.Drawing.Size(49, 13)
        Me.labelSB.TabIndex = 18
        Me.labelSB.Text = "Stop Bits"
        '
        'cboStop
        '
        Me.cboStop.FormattingEnabled = True
        Me.cboStop.Location = New System.Drawing.Point(9, 155)
        Me.cboStop.Name = "cboStop"
        Me.cboStop.Size = New System.Drawing.Size(76, 21)
        Me.cboStop.TabIndex = 13
        '
        'labelParity
        '
        Me.labelParity.AutoSize = True
        Me.labelParity.Location = New System.Drawing.Point(6, 98)
        Me.labelParity.Name = "labelParity"
        Me.labelParity.Size = New System.Drawing.Size(35, 13)
        Me.labelParity.TabIndex = 17
        Me.labelParity.Text = "Parity"
        '
        'labelBaud
        '
        Me.labelBaud.AutoSize = True
        Me.labelBaud.Location = New System.Drawing.Point(6, 59)
        Me.labelBaud.Name = "labelBaud"
        Me.labelBaud.Size = New System.Drawing.Size(57, 13)
        Me.labelBaud.TabIndex = 16
        Me.labelBaud.Text = "Baud Rate"
        '
        'cboParity
        '
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Location = New System.Drawing.Point(9, 114)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(76, 21)
        Me.cboParity.TabIndex = 12
        '
        'LabelPort
        '
        Me.LabelPort.AutoSize = True
        Me.LabelPort.Location = New System.Drawing.Point(6, 18)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(27, 13)
        Me.LabelPort.TabIndex = 15
        Me.LabelPort.Text = "Port"
        '
        'cboBaud
        '
        Me.cboBaud.FormattingEnabled = True
        Me.cboBaud.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "14400", "28800", "36000", "115000"})
        Me.cboBaud.Location = New System.Drawing.Point(9, 74)
        Me.cboBaud.Name = "cboBaud"
        Me.cboBaud.Size = New System.Drawing.Size(76, 21)
        Me.cboBaud.TabIndex = 11
        '
        'cboPort
        '
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Location = New System.Drawing.Point(9, 34)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(76, 21)
        Me.cboPort.TabIndex = 10
        '
        'groupBoxSerialMode
        '
        Me.groupBoxSerialMode.Controls.Add(Me.rdoText)
        Me.groupBoxSerialMode.Controls.Add(Me.rdoHex)
        Me.groupBoxSerialMode.Controls.Add(Me.txtSend)
        Me.groupBoxSerialMode.Location = New System.Drawing.Point(274, 250)
        Me.groupBoxSerialMode.Name = "groupBoxSerialMode"
        Me.groupBoxSerialMode.Size = New System.Drawing.Size(85, 58)
        Me.groupBoxSerialMode.TabIndex = 17
        Me.groupBoxSerialMode.TabStop = False
        Me.groupBoxSerialMode.Text = "Mode"
        '
        'rdoText
        '
        Me.rdoText.AutoSize = True
        Me.rdoText.Location = New System.Drawing.Point(6, 38)
        Me.rdoText.Name = "rdoText"
        Me.rdoText.Size = New System.Drawing.Size(47, 17)
        Me.rdoText.TabIndex = 1
        Me.rdoText.TabStop = True
        Me.rdoText.Text = "Text"
        Me.rdoText.UseVisualStyleBackColor = True
        '
        'rdoHex
        '
        Me.rdoHex.AutoSize = True
        Me.rdoHex.Location = New System.Drawing.Point(6, 16)
        Me.rdoHex.Name = "rdoHex"
        Me.rdoHex.Size = New System.Drawing.Size(44, 17)
        Me.rdoHex.TabIndex = 0
        Me.rdoHex.TabStop = True
        Me.rdoHex.Text = "Hex"
        Me.rdoHex.UseVisualStyleBackColor = True
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(59, 26)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(10, 21)
        Me.txtSend.TabIndex = 4
        Me.txtSend.Visible = False
        '
        'TabPres
        '
        Me.TabPres.Controls.Add(Me.TabSerial)
        Me.TabPres.Controls.Add(Me.TabInfo)
        Me.TabPres.Location = New System.Drawing.Point(394, 8)
        Me.TabPres.Name = "TabPres"
        Me.TabPres.SelectedIndex = 0
        Me.TabPres.Size = New System.Drawing.Size(374, 337)
        Me.TabPres.TabIndex = 39
        '
        'tabPPT
        '
        Me.tabPPT.Controls.Add(Me.NumericUpDownPPT)
        Me.tabPPT.Controls.Add(Me.LabelPPTDisc)
        Me.tabPPT.Controls.Add(Me.LabelPPTThreshol)
        Me.tabPPT.Controls.Add(Me.LabelPPT)
        Me.tabPPT.Controls.Add(Me.GroupBoxSlidesCtrl)
        Me.tabPPT.Controls.Add(Me.CheckBoxPPT)
        Me.tabPPT.Controls.Add(Me.PPT)
        Me.tabPPT.Controls.Add(Me.GroupBoxPPT)
        Me.tabPPT.Location = New System.Drawing.Point(4, 22)
        Me.tabPPT.Name = "tabPPT"
        Me.tabPPT.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPPT.Size = New System.Drawing.Size(366, 311)
        Me.tabPPT.TabIndex = 2
        Me.tabPPT.Text = "Bonus"
        Me.tabPPT.UseVisualStyleBackColor = True
        '
        'NumericUpDownPPT
        '
        Me.NumericUpDownPPT.DecimalPlaces = 2
        Me.NumericUpDownPPT.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDownPPT.Location = New System.Drawing.Point(240, 161)
        Me.NumericUpDownPPT.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownPPT.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDownPPT.Name = "NumericUpDownPPT"
        Me.NumericUpDownPPT.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDownPPT.TabIndex = 35
        Me.NumericUpDownPPT.Value = New Decimal(New Integer() {12, 0, 0, 131072})
        '
        'LabelPPTDisc
        '
        Me.LabelPPTDisc.AutoSize = True
        Me.LabelPPTDisc.ForeColor = System.Drawing.Color.Crimson
        Me.LabelPPTDisc.Location = New System.Drawing.Point(15, 29)
        Me.LabelPPTDisc.Name = "LabelPPTDisc"
        Me.LabelPPTDisc.Size = New System.Drawing.Size(206, 13)
        Me.LabelPPTDisc.TabIndex = 40
        Me.LabelPPTDisc.Text = "May or may not work. This is experimental." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelPPTThreshol
        '
        Me.LabelPPTThreshol.AutoSize = True
        Me.LabelPPTThreshol.Location = New System.Drawing.Point(237, 145)
        Me.LabelPPTThreshol.Name = "LabelPPTThreshol"
        Me.LabelPPTThreshol.Size = New System.Drawing.Size(77, 13)
        Me.LabelPPTThreshol.TabIndex = 39
        Me.LabelPPTThreshol.Text = "Min. Threshold"
        '
        'LabelPPT
        '
        Me.LabelPPT.AutoSize = True
        Me.LabelPPT.Location = New System.Drawing.Point(15, 13)
        Me.LabelPPT.Name = "LabelPPT"
        Me.LabelPPT.Size = New System.Drawing.Size(97, 13)
        Me.LabelPPT.TabIndex = 39
        Me.LabelPPT.Text = "PowerPoint Control"
        '
        'GroupBoxSlidesCtrl
        '
        Me.GroupBoxSlidesCtrl.Controls.Add(Me.ButtoPPTStop)
        Me.GroupBoxSlidesCtrl.Controls.Add(Me.ButtonPPTStart)
        Me.GroupBoxSlidesCtrl.Controls.Add(Me.ButtonPPTFirst)
        Me.GroupBoxSlidesCtrl.Controls.Add(Me.ButtonPPTPrev)
        Me.GroupBoxSlidesCtrl.Controls.Add(Me.ButtonPPTLast)
        Me.GroupBoxSlidesCtrl.Controls.Add(Me.ButtonPPTNext)
        Me.GroupBoxSlidesCtrl.Enabled = False
        Me.GroupBoxSlidesCtrl.Location = New System.Drawing.Point(18, 165)
        Me.GroupBoxSlidesCtrl.Name = "GroupBoxSlidesCtrl"
        Me.GroupBoxSlidesCtrl.Size = New System.Drawing.Size(200, 124)
        Me.GroupBoxSlidesCtrl.TabIndex = 9
        Me.GroupBoxSlidesCtrl.TabStop = False
        Me.GroupBoxSlidesCtrl.Text = "Slides Control"
        '
        'ButtoPPTStop
        '
        Me.ButtoPPTStop.Location = New System.Drawing.Point(111, 90)
        Me.ButtoPPTStop.Name = "ButtoPPTStop"
        Me.ButtoPPTStop.Size = New System.Drawing.Size(75, 23)
        Me.ButtoPPTStop.TabIndex = 10
        Me.ButtoPPTStop.Text = "Stop Pres."
        Me.ButtoPPTStop.UseVisualStyleBackColor = True
        '
        'ButtonPPTStart
        '
        Me.ButtonPPTStart.Location = New System.Drawing.Point(12, 90)
        Me.ButtonPPTStart.Name = "ButtonPPTStart"
        Me.ButtonPPTStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPPTStart.TabIndex = 9
        Me.ButtonPPTStart.Text = "Start Pres."
        Me.ButtonPPTStart.UseVisualStyleBackColor = True
        '
        'ButtonPPTFirst
        '
        Me.ButtonPPTFirst.Location = New System.Drawing.Point(12, 22)
        Me.ButtonPPTFirst.Name = "ButtonPPTFirst"
        Me.ButtonPPTFirst.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPPTFirst.TabIndex = 7
        Me.ButtonPPTFirst.Text = "First"
        Me.ButtonPPTFirst.UseVisualStyleBackColor = True
        '
        'ButtonPPTPrev
        '
        Me.ButtonPPTPrev.Location = New System.Drawing.Point(12, 57)
        Me.ButtonPPTPrev.Name = "ButtonPPTPrev"
        Me.ButtonPPTPrev.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPPTPrev.TabIndex = 6
        Me.ButtonPPTPrev.Text = "Previous"
        Me.ButtonPPTPrev.UseVisualStyleBackColor = True
        '
        'ButtonPPTLast
        '
        Me.ButtonPPTLast.Location = New System.Drawing.Point(111, 21)
        Me.ButtonPPTLast.Name = "ButtonPPTLast"
        Me.ButtonPPTLast.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPPTLast.TabIndex = 8
        Me.ButtonPPTLast.Text = "Last"
        Me.ButtonPPTLast.UseVisualStyleBackColor = True
        '
        'ButtonPPTNext
        '
        Me.ButtonPPTNext.Location = New System.Drawing.Point(111, 57)
        Me.ButtonPPTNext.Name = "ButtonPPTNext"
        Me.ButtonPPTNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPPTNext.TabIndex = 5
        Me.ButtonPPTNext.Text = "Next"
        Me.ButtonPPTNext.UseVisualStyleBackColor = True
        '
        'CheckBoxPPT
        '
        Me.CheckBoxPPT.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBoxPPT.AutoSize = True
        Me.CheckBoxPPT.Enabled = False
        Me.CheckBoxPPT.Location = New System.Drawing.Point(18, 126)
        Me.CheckBoxPPT.Name = "CheckBoxPPT"
        Me.CheckBoxPPT.Size = New System.Drawing.Size(86, 23)
        Me.CheckBoxPPT.TabIndex = 38
        Me.CheckBoxPPT.Text = "Toggle Control"
        Me.CheckBoxPPT.UseVisualStyleBackColor = True
        '
        'PPT
        '
        Me.PPT.Location = New System.Drawing.Point(111, 126)
        Me.PPT.Name = "PPT"
        Me.PPT.Size = New System.Drawing.Size(119, 23)
        Me.PPT.TabIndex = 4
        Me.PPT.Text = "Select Current Slides"
        Me.PPT.UseVisualStyleBackColor = True
        '
        'GroupBoxPPT
        '
        Me.GroupBoxPPT.Controls.Add(Me.ButtonDown)
        Me.GroupBoxPPT.Controls.Add(Me.ButtonRight)
        Me.GroupBoxPPT.Controls.Add(Me.ButtonUp)
        Me.GroupBoxPPT.Controls.Add(Me.ButtonLeft)
        Me.GroupBoxPPT.Location = New System.Drawing.Point(224, 188)
        Me.GroupBoxPPT.Name = "GroupBoxPPT"
        Me.GroupBoxPPT.Size = New System.Drawing.Size(121, 100)
        Me.GroupBoxPPT.TabIndex = 5
        Me.GroupBoxPPT.TabStop = False
        Me.GroupBoxPPT.Text = "Keyboard Navigation"
        '
        'ButtonDown
        '
        Me.ButtonDown.Location = New System.Drawing.Point(45, 68)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(30, 23)
        Me.ButtonDown.TabIndex = 3
        Me.ButtonDown.Text = "D"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonRight
        '
        Me.ButtonRight.Location = New System.Drawing.Point(72, 44)
        Me.ButtonRight.Name = "ButtonRight"
        Me.ButtonRight.Size = New System.Drawing.Size(30, 23)
        Me.ButtonRight.TabIndex = 2
        Me.ButtonRight.Text = "R"
        Me.ButtonRight.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        Me.ButtonUp.Location = New System.Drawing.Point(45, 20)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(30, 23)
        Me.ButtonUp.TabIndex = 1
        Me.ButtonUp.Text = "U"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ButtonLeft
        '
        Me.ButtonLeft.Location = New System.Drawing.Point(16, 44)
        Me.ButtonLeft.Name = "ButtonLeft"
        Me.ButtonLeft.Size = New System.Drawing.Size(30, 23)
        Me.ButtonLeft.TabIndex = 0
        Me.ButtonLeft.Text = "L"
        Me.ButtonLeft.UseVisualStyleBackColor = True
        '
        'BackgroundWorkerConnect
        '
        Me.BackgroundWorkerConnect.WorkerSupportsCancellation = True
        '
        'BackgroundWorkerPPT
        '
        Me.BackgroundWorkerPPT.WorkerSupportsCancellation = True
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(770, 348)
        Me.Controls.Add(Me.GroupBoxConstrain)
        Me.Controls.Add(Me.TabPres)
        Me.Controls.Add(Me.LinkProto)
        Me.Controls.Add(Me.PictureBoxMakara)
        Me.Controls.Add(Me.LabelAbout)
        Me.Controls.Add(Me.GroupBoxAct)
        Me.Controls.Add(Me.GroupBoxDebug)
        Me.Controls.Add(Me.LabelNotice)
        Me.Controls.Add(Me.tabOption)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventor Glove Connector - Virtual Assembly"
        GroupBoxZoomArb.ResumeLayout(False)
        GroupBoxZoomArb.PerformLayout()
        CType(Me.TextBoxWZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxHZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RotationArrow.ResumeLayout(False)
        Me.RotationArrow.PerformLayout()
        CType(Me.TextboxIncRot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupRotate90.ResumeLayout(False)
        Me.GroupRotateCustom.ResumeLayout(False)
        Me.GroupRotateCustom.PerformLayout()
        CType(Me.InputZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOption.ResumeLayout(False)
        Me.tabRotation.ResumeLayout(False)
        Me.tabRotation.PerformLayout()
        CType(Me.InputScalingRot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTranslate.ResumeLayout(False)
        Me.TabTranslate.PerformLayout()
        CType(Me.InputRatioRotTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTransArb.ResumeLayout(False)
        Me.GroupBoxTransArb.PerformLayout()
        CType(Me.TextBoxMoveZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxMoveY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxMoveX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTransArrow.ResumeLayout(False)
        Me.GroupBoxTransArrow.PerformLayout()
        CType(Me.TextboxIncTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabZoom.ResumeLayout(False)
        Me.TabZoom.PerformLayout()
        Me.GroupBoxZoomControl.ResumeLayout(False)
        Me.GroupBoxZoomControl.PerformLayout()
        CType(Me.TextBoxZoomInc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDebug.ResumeLayout(False)
        Me.GroupBoxDebug.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabDocInfo.ResumeLayout(False)
        Me.TabDocInfo.PerformLayout()
        Me.TabDebug.ResumeLayout(False)
        Me.TabDebug.PerformLayout()
        Me.GroupBoxAct.ResumeLayout(False)
        Me.GroupBoxAct.PerformLayout()
        Me.GroupBoxConstrain.ResumeLayout(False)
        Me.GroupBoxConstrain.PerformLayout()
        CType(Me.PictureBoxMakara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInfo.ResumeLayout(False)
        Me.GroupBoxArrowTrans.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicArrowUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicArrowLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicArrowDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicArrowRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxActPic.ResumeLayout(False)
        Me.GroupBoxActPic.PerformLayout()
        CType(Me.PicAct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxFlexPic.ResumeLayout(False)
        Me.GroupBoxFlexPic.PerformLayout()
        CType(Me.PicFlex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOrientation.ResumeLayout(False)
        CType(Me.PicOrientation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxEuler.ResumeLayout(False)
        Me.GroupBoxEuler.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSerial.ResumeLayout(False)
        Me.GroupBoxSerial.ResumeLayout(False)
        Me.GroupBoxSerial.PerformLayout()
        Me.groupBoxSerialOptions.ResumeLayout(False)
        Me.groupBoxSerialOptions.PerformLayout()
        Me.groupBoxSerialMode.ResumeLayout(False)
        Me.groupBoxSerialMode.PerformLayout()
        Me.TabPres.ResumeLayout(False)
        Me.tabPPT.ResumeLayout(False)
        Me.tabPPT.PerformLayout()
        CType(Me.NumericUpDownPPT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSlidesCtrl.ResumeLayout(False)
        Me.GroupBoxPPT.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArrowLeft As System.Windows.Forms.Button
    Friend WithEvents up As System.Windows.Forms.Button
    Friend WithEvents ArrowRight As System.Windows.Forms.Button
    Friend WithEvents down As System.Windows.Forms.Button
    Friend WithEvents rotate As System.Windows.Forms.Button
    Friend WithEvents ButtonRotateX As System.Windows.Forms.Button
    Friend WithEvents buttonRotateY As System.Windows.Forms.Button
    Friend WithEvents ButtonRotateZ As System.Windows.Forms.Button
    Friend WithEvents ButtonRotbyVal As System.Windows.Forms.Button
    Friend WithEvents RotationArrow As System.Windows.Forms.GroupBox
    Friend WithEvents GroupRotate90 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupRotateCustom As System.Windows.Forms.GroupBox
    Friend WithEvents LabelZ As System.Windows.Forms.Label
    Friend WithEvents LabelY As System.Windows.Forms.Label
    Friend WithEvents LabelX As System.Windows.Forms.Label
    Friend WithEvents TextboxDebug As System.Windows.Forms.TextBox
    Friend WithEvents tabOption As System.Windows.Forms.TabControl
    Friend WithEvents tabRotation As System.Windows.Forms.TabPage
    Friend WithEvents TabTranslate As System.Windows.Forms.TabPage
    Friend WithEvents GroupBoxDebug As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonTranslate As System.Windows.Forms.Button
    Friend WithEvents GroupBoxTransArrow As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonMoveDown As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveRight As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveLeft As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveUp As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveZdown As System.Windows.Forms.Button
    Friend WithEvents ButtonMoveZup As System.Windows.Forms.Button
    Friend WithEvents TabZoom As System.Windows.Forms.TabPage
    Friend WithEvents LabelW As System.Windows.Forms.Label
    Friend WithEvents LabelH As System.Windows.Forms.Label
    Friend WithEvents ButtonZoomIn As System.Windows.Forms.Button
    Friend WithEvents ButtonZoom As System.Windows.Forms.Button
    Friend WithEvents ButtonZoomOut As System.Windows.Forms.Button
    Friend WithEvents GroupBoxTransArb As System.Windows.Forms.GroupBox
    Friend WithEvents LabelTransX As System.Windows.Forms.Label
    Friend WithEvents LabelTransZ As System.Windows.Forms.Label
    Friend WithEvents LabelTransY As System.Windows.Forms.Label
    Friend WithEvents CheckBoxRot As System.Windows.Forms.CheckBox
    Friend WithEvents LabelNotice As System.Windows.Forms.Label
    Friend WithEvents GroupBoxAct As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxZoomControl As System.Windows.Forms.GroupBox
    Friend WithEvents LabelIncZoom As System.Windows.Forms.Label
    Friend WithEvents LabelAbout As System.Windows.Forms.Label
    Friend WithEvents PictureBoxMakara As System.Windows.Forms.PictureBox
    Friend WithEvents LinkProto As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTipProto As System.Windows.Forms.ToolTip
    Friend WithEvents ButtonSelBody As System.Windows.Forms.Button
    Friend WithEvents RadioButtonZoom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTranslation As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonRotation As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNone As System.Windows.Forms.RadioButton
    Friend WithEvents inputX As System.Windows.Forms.NumericUpDown
    Friend WithEvents InputZ As System.Windows.Forms.NumericUpDown
    Friend WithEvents InputY As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxWZoom As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxHZoom As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxMoveZ As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxMoveY As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxMoveX As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxZoomInc As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBoxConnect As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxZoomOpt As System.Windows.Forms.CheckBox
    Friend WithEvents TextboxIncRot As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelIncRot As System.Windows.Forms.Label
    Friend WithEvents TextboxIncTrans As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelIncTrans As System.Windows.Forms.Label
    Friend WithEvents InputRatioRotTrans As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelRatioRotTrans As System.Windows.Forms.Label
    Friend WithEvents InputScalingRot As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelScalingRotUnit As System.Windows.Forms.Label
    Friend WithEvents LabelScalingRot As System.Windows.Forms.Label
    Friend WithEvents ButtonDelAllMoves As System.Windows.Forms.Button
    Friend WithEvents ButtonFrontPlane As System.Windows.Forms.Button
    Friend WithEvents ButtonTestMoveAss As System.Windows.Forms.Button
    Friend WithEvents GroupBoxConstrain As System.Windows.Forms.GroupBox
    Friend WithEvents GaugePitch As System.Windows.Forms.AGauge
    Friend WithEvents GaugeYaw As System.Windows.Forms.AGauge
    Friend WithEvents GaugeRoll As System.Windows.Forms.AGauge
    Friend WithEvents TabInfo As System.Windows.Forms.TabPage
    Friend WithEvents GroupBoxArrowTrans As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PicArrowUp As System.Windows.Forms.PictureBox
    Friend WithEvents PicArrowLeft As System.Windows.Forms.PictureBox
    Friend WithEvents PicArrowDown As System.Windows.Forms.PictureBox
    Friend WithEvents PicArrowRight As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBoxActPic As System.Windows.Forms.GroupBox
    Friend WithEvents LabelActState As System.Windows.Forms.Label
    Friend WithEvents PicAct As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBoxFlexPic As System.Windows.Forms.GroupBox
    Friend WithEvents LabelFlexState As System.Windows.Forms.Label
    Friend WithEvents PicFlex As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBoxOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents PicOrientation As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBoxEuler As System.Windows.Forms.GroupBox
    Friend WithEvents LabelPitch As System.Windows.Forms.Label
    Friend WithEvents LabelYaw As System.Windows.Forms.Label
    Friend WithEvents TextBoxEuX As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelRoll As System.Windows.Forms.Label
    Friend WithEvents TextBoxEuY As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxEuZ As System.Windows.Forms.RichTextBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TabSerial As System.Windows.Forms.TabPage
    Private WithEvents GroupBoxSerial As System.Windows.Forms.GroupBox
    Public WithEvents CheckBoxViewOutput As System.Windows.Forms.CheckBox
    Private WithEvents cmdSend As System.Windows.Forms.Button
    Private WithEvents rtbDisplay As System.Windows.Forms.RichTextBox
    Private WithEvents cmdClose As System.Windows.Forms.Button
    Private WithEvents cmdOpen As System.Windows.Forms.Button
    Private WithEvents groupBoxSerialOptions As System.Windows.Forms.GroupBox
    Private WithEvents labelDB As System.Windows.Forms.Label
    Private WithEvents cboData As System.Windows.Forms.ComboBox
    Private WithEvents labelSB As System.Windows.Forms.Label
    Private WithEvents cboStop As System.Windows.Forms.ComboBox
    Private WithEvents labelParity As System.Windows.Forms.Label
    Private WithEvents labelBaud As System.Windows.Forms.Label
    Private WithEvents cboParity As System.Windows.Forms.ComboBox
    Private WithEvents LabelPort As System.Windows.Forms.Label
    Private WithEvents cboBaud As System.Windows.Forms.ComboBox
    Private WithEvents cboPort As System.Windows.Forms.ComboBox
    Private WithEvents groupBoxSerialMode As System.Windows.Forms.GroupBox
    Private WithEvents rdoText As System.Windows.Forms.RadioButton
    Private WithEvents rdoHex As System.Windows.Forms.RadioButton
    Private WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents TabPres As System.Windows.Forms.TabControl
    Friend WithEvents BackgroundWorkerConnect As System.ComponentModel.BackgroundWorker
    Friend WithEvents tabPPT As System.Windows.Forms.TabPage
    Friend WithEvents GroupBoxPPT As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDown As System.Windows.Forms.Button
    Friend WithEvents ButtonRight As System.Windows.Forms.Button
    Friend WithEvents PPT As System.Windows.Forms.Button
    Friend WithEvents ButtonUp As System.Windows.Forms.Button
    Friend WithEvents ButtonLeft As System.Windows.Forms.Button
    Friend WithEvents ButtonPPTPrev As System.Windows.Forms.Button
    Friend WithEvents ButtonPPTNext As System.Windows.Forms.Button
    Friend WithEvents ButtonPPTLast As System.Windows.Forms.Button
    Friend WithEvents ButtonPPTFirst As System.Windows.Forms.Button
    Friend WithEvents GroupBoxSlidesCtrl As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabDocInfo As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxFileName As System.Windows.Forms.TextBox
    Friend WithEvents LabelSelPart As System.Windows.Forms.Label
    Friend WithEvents LabelFileName As System.Windows.Forms.Label
    Friend WithEvents TabDebug As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxSelPart As System.Windows.Forms.TextBox
    Friend WithEvents ButtoPPTStop As System.Windows.Forms.Button
    Friend WithEvents ButtonPPTStart As System.Windows.Forms.Button
    Friend WithEvents CheckBoxPPT As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundWorkerPPT As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelPPTDisc As System.Windows.Forms.Label
    Friend WithEvents LabelPPT As System.Windows.Forms.Label
    Friend WithEvents CheckBoxTgX As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTgY As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTgZ As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownPPT As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelPPTThreshol As System.Windows.Forms.Label
    Private ReadOnly _inventorApi As InvenGlove.InventorAPI
    Private ReadOnly _inventorConnect As InvenGlove.InventorConnect
    Private ReadOnly _invenGlovePPT As InvenGlove.InvenGlovePPT

    Public ReadOnly Property InventorApi() As InvenGlove.InventorAPI
        Get
            Return _inventorApi
        End Get
    End Property

    Public ReadOnly Property InventorConnect() As InventorConnect
        Get
            Return _inventorConnect
        End Get
    End Property
End Class
