<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.startBtn = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTimeBox = New System.Windows.Forms.Label()
        Me.plusLeftlbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plusRightlbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.TextBox()
        Me.min = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.minRightlbl = New System.Windows.Forms.Label()
        Me.minLbl = New System.Windows.Forms.Label()
        Me.minLeftlbl = New System.Windows.Forms.Label()
        Me.mul = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mulRightlbl = New System.Windows.Forms.Label()
        Me.mulLbl = New System.Windows.Forms.Label()
        Me.mulLeftlbl = New System.Windows.Forms.Label()
        Me.div = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.divRightlbl = New System.Windows.Forms.Label()
        Me.divLbl = New System.Windows.Forms.Label()
        Me.divLeftlbl = New System.Windows.Forms.Label()
        Me.aidiv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.aidiv2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.aidiv1 = New System.Windows.Forms.Label()
        Me.aimul = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.aimul2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.aimul1 = New System.Windows.Forms.Label()
        Me.aimin = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.aimin2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.aimin1 = New System.Windows.Forms.Label()
        Me.aisum = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.aisum2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.aisum1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.endBtn = New System.Windows.Forms.Button()
        Me.aitime = New System.Windows.Forms.Label()
        Me.menschtime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'startBtn
        '
        Me.startBtn.Location = New System.Drawing.Point(515, 322)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(180, 48)
        Me.startBtn.TabIndex = 1
        Me.startBtn.Text = "Test Starten"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(515, 8)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(200, 30)
        Me.lblTime.TabIndex = 2
        '
        'lblTimeBox
        '
        Me.lblTimeBox.AutoSize = True
        Me.lblTimeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeBox.Location = New System.Drawing.Point(414, 9)
        Me.lblTimeBox.Name = "lblTimeBox"
        Me.lblTimeBox.Size = New System.Drawing.Size(48, 25)
        Me.lblTimeBox.TabIndex = 3
        Me.lblTimeBox.Text = "Zeit"
        '
        'plusLeftlbl
        '
        Me.plusLeftlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusLeftlbl.Location = New System.Drawing.Point(21, 75)
        Me.plusLeftlbl.Name = "plusLeftlbl"
        Me.plusLeftlbl.Size = New System.Drawing.Size(60, 50)
        Me.plusLeftlbl.TabIndex = 4
        Me.plusLeftlbl.Text = "?"
        Me.plusLeftlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 50)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "+"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'plusRightlbl
        '
        Me.plusRightlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusRightlbl.Location = New System.Drawing.Point(185, 75)
        Me.plusRightlbl.Name = "plusRightlbl"
        Me.plusRightlbl.Size = New System.Drawing.Size(60, 50)
        Me.plusRightlbl.TabIndex = 6
        Me.plusRightlbl.Text = "?"
        Me.plusRightlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 50)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "="
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sum
        '
        Me.sum.Location = New System.Drawing.Point(362, 95)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(100, 20)
        Me.sum.TabIndex = 8
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(362, 158)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(100, 20)
        Me.min.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 50)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "="
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minRightlbl
        '
        Me.minRightlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minRightlbl.Location = New System.Drawing.Point(185, 138)
        Me.minRightlbl.Name = "minRightlbl"
        Me.minRightlbl.Size = New System.Drawing.Size(60, 50)
        Me.minRightlbl.TabIndex = 11
        Me.minRightlbl.Text = "?"
        Me.minRightlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minLbl
        '
        Me.minLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minLbl.Location = New System.Drawing.Point(102, 138)
        Me.minLbl.Name = "minLbl"
        Me.minLbl.Size = New System.Drawing.Size(60, 50)
        Me.minLbl.TabIndex = 10
        Me.minLbl.Text = "-"
        Me.minLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minLeftlbl
        '
        Me.minLeftlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minLeftlbl.Location = New System.Drawing.Point(21, 138)
        Me.minLeftlbl.Name = "minLeftlbl"
        Me.minLeftlbl.Size = New System.Drawing.Size(60, 50)
        Me.minLeftlbl.TabIndex = 9
        Me.minLeftlbl.Text = "?"
        Me.minLeftlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mul
        '
        Me.mul.Location = New System.Drawing.Point(362, 218)
        Me.mul.Name = "mul"
        Me.mul.Size = New System.Drawing.Size(100, 20)
        Me.mul.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 50)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "="
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mulRightlbl
        '
        Me.mulRightlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mulRightlbl.Location = New System.Drawing.Point(185, 198)
        Me.mulRightlbl.Name = "mulRightlbl"
        Me.mulRightlbl.Size = New System.Drawing.Size(60, 50)
        Me.mulRightlbl.TabIndex = 16
        Me.mulRightlbl.Text = "?"
        Me.mulRightlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mulLbl
        '
        Me.mulLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mulLbl.Location = New System.Drawing.Point(102, 198)
        Me.mulLbl.Name = "mulLbl"
        Me.mulLbl.Size = New System.Drawing.Size(60, 50)
        Me.mulLbl.TabIndex = 15
        Me.mulLbl.Text = "x"
        Me.mulLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mulLeftlbl
        '
        Me.mulLeftlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mulLeftlbl.Location = New System.Drawing.Point(21, 198)
        Me.mulLeftlbl.Name = "mulLeftlbl"
        Me.mulLeftlbl.Size = New System.Drawing.Size(60, 50)
        Me.mulLeftlbl.TabIndex = 14
        Me.mulLeftlbl.Text = "?"
        Me.mulLeftlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'div
        '
        Me.div.Location = New System.Drawing.Point(362, 277)
        Me.div.Name = "div"
        Me.div.Size = New System.Drawing.Size(100, 20)
        Me.div.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 257)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 50)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "="
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'divRightlbl
        '
        Me.divRightlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divRightlbl.Location = New System.Drawing.Point(185, 257)
        Me.divRightlbl.Name = "divRightlbl"
        Me.divRightlbl.Size = New System.Drawing.Size(60, 50)
        Me.divRightlbl.TabIndex = 21
        Me.divRightlbl.Text = "?"
        Me.divRightlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'divLbl
        '
        Me.divLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divLbl.Location = New System.Drawing.Point(102, 257)
        Me.divLbl.Name = "divLbl"
        Me.divLbl.Size = New System.Drawing.Size(60, 50)
        Me.divLbl.TabIndex = 20
        Me.divLbl.Text = "/"
        Me.divLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'divLeftlbl
        '
        Me.divLeftlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divLeftlbl.Location = New System.Drawing.Point(21, 257)
        Me.divLeftlbl.Name = "divLeftlbl"
        Me.divLeftlbl.Size = New System.Drawing.Size(60, 50)
        Me.divLeftlbl.TabIndex = 19
        Me.divLeftlbl.Text = "?"
        Me.divLeftlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aidiv
        '
        Me.aidiv.Location = New System.Drawing.Point(1076, 277)
        Me.aidiv.Name = "aidiv"
        Me.aidiv.Size = New System.Drawing.Size(100, 20)
        Me.aidiv.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(998, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 50)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "="
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aidiv2
        '
        Me.aidiv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aidiv2.Location = New System.Drawing.Point(899, 257)
        Me.aidiv2.Name = "aidiv2"
        Me.aidiv2.Size = New System.Drawing.Size(60, 50)
        Me.aidiv2.TabIndex = 41
        Me.aidiv2.Text = "?"
        Me.aidiv2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(816, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 50)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "/"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aidiv1
        '
        Me.aidiv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aidiv1.Location = New System.Drawing.Point(735, 257)
        Me.aidiv1.Name = "aidiv1"
        Me.aidiv1.Size = New System.Drawing.Size(60, 50)
        Me.aidiv1.TabIndex = 39
        Me.aidiv1.Text = "?"
        Me.aidiv1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aimul
        '
        Me.aimul.Location = New System.Drawing.Point(1076, 218)
        Me.aimul.Name = "aimul"
        Me.aimul.Size = New System.Drawing.Size(100, 20)
        Me.aimul.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(998, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 50)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "="
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aimul2
        '
        Me.aimul2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aimul2.Location = New System.Drawing.Point(899, 198)
        Me.aimul2.Name = "aimul2"
        Me.aimul2.Size = New System.Drawing.Size(60, 50)
        Me.aimul2.TabIndex = 36
        Me.aimul2.Text = "?"
        Me.aimul2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(816, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 50)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "x"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aimul1
        '
        Me.aimul1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aimul1.Location = New System.Drawing.Point(735, 198)
        Me.aimul1.Name = "aimul1"
        Me.aimul1.Size = New System.Drawing.Size(60, 50)
        Me.aimul1.TabIndex = 34
        Me.aimul1.Text = "?"
        Me.aimul1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aimin
        '
        Me.aimin.Location = New System.Drawing.Point(1076, 158)
        Me.aimin.Name = "aimin"
        Me.aimin.Size = New System.Drawing.Size(100, 20)
        Me.aimin.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(998, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 50)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "="
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aimin2
        '
        Me.aimin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aimin2.Location = New System.Drawing.Point(899, 138)
        Me.aimin2.Name = "aimin2"
        Me.aimin2.Size = New System.Drawing.Size(60, 50)
        Me.aimin2.TabIndex = 31
        Me.aimin2.Text = "?"
        Me.aimin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(816, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 50)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "-"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aimin1
        '
        Me.aimin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aimin1.Location = New System.Drawing.Point(735, 138)
        Me.aimin1.Name = "aimin1"
        Me.aimin1.Size = New System.Drawing.Size(60, 50)
        Me.aimin1.TabIndex = 29
        Me.aimin1.Text = "?"
        Me.aimin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aisum
        '
        Me.aisum.Location = New System.Drawing.Point(1076, 95)
        Me.aisum.Name = "aisum"
        Me.aisum.Size = New System.Drawing.Size(100, 20)
        Me.aisum.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(998, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 50)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "="
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aisum2
        '
        Me.aisum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aisum2.Location = New System.Drawing.Point(899, 75)
        Me.aisum2.Name = "aisum2"
        Me.aisum2.Size = New System.Drawing.Size(60, 50)
        Me.aisum2.TabIndex = 26
        Me.aisum2.Text = "?"
        Me.aisum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(816, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 50)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "+"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aisum1
        '
        Me.aisum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aisum1.Location = New System.Drawing.Point(735, 75)
        Me.aisum1.Name = "aisum1"
        Me.aisum1.Size = New System.Drawing.Size(60, 50)
        Me.aisum1.TabIndex = 24
        Me.aisum1.Text = "?"
        Me.aisum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(187, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Mensch"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(917, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(17, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "AI"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.Location = New System.Drawing.Point(608, 18)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(0, 13)
        Me.timeLbl.TabIndex = 46
        '
        'endBtn
        '
        Me.endBtn.Location = New System.Drawing.Point(515, 390)
        Me.endBtn.Name = "endBtn"
        Me.endBtn.Size = New System.Drawing.Size(180, 48)
        Me.endBtn.TabIndex = 47
        Me.endBtn.Text = "Test Beenden"
        Me.endBtn.UseVisualStyleBackColor = True
        '
        'aitime
        '
        Me.aitime.AutoSize = True
        Me.aitime.Location = New System.Drawing.Point(945, 366)
        Me.aitime.Name = "aitime"
        Me.aitime.Size = New System.Drawing.Size(0, 13)
        Me.aitime.TabIndex = 48
        '
        'menschtime
        '
        Me.menschtime.AutoSize = True
        Me.menschtime.Location = New System.Drawing.Point(205, 366)
        Me.menschtime.Name = "menschtime"
        Me.menschtime.Size = New System.Drawing.Size(0, 13)
        Me.menschtime.TabIndex = 49
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 450)
        Me.Controls.Add(Me.menschtime)
        Me.Controls.Add(Me.aitime)
        Me.Controls.Add(Me.endBtn)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.aidiv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.aidiv2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.aidiv1)
        Me.Controls.Add(Me.aimul)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.aimul2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.aimul1)
        Me.Controls.Add(Me.aimin)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.aimin2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.aimin1)
        Me.Controls.Add(Me.aisum)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.aisum2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.aisum1)
        Me.Controls.Add(Me.div)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.divRightlbl)
        Me.Controls.Add(Me.divLbl)
        Me.Controls.Add(Me.divLeftlbl)
        Me.Controls.Add(Me.mul)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mulRightlbl)
        Me.Controls.Add(Me.mulLbl)
        Me.Controls.Add(Me.mulLeftlbl)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.minRightlbl)
        Me.Controls.Add(Me.minLbl)
        Me.Controls.Add(Me.minLeftlbl)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.plusRightlbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plusLeftlbl)
        Me.Controls.Add(Me.lblTimeBox)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.startBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Math"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startBtn As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblTimeBox As Label
    Friend WithEvents plusLeftlbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents plusRightlbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sum As TextBox
    Friend WithEvents min As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents minRightlbl As Label
    Friend WithEvents minLbl As Label
    Friend WithEvents minLeftlbl As Label
    Friend WithEvents mul As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mulRightlbl As Label
    Friend WithEvents mulLbl As Label
    Friend WithEvents mulLeftlbl As Label
    Friend WithEvents div As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents divRightlbl As Label
    Friend WithEvents divLbl As Label
    Friend WithEvents divLeftlbl As Label
    Friend WithEvents aidiv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents aidiv2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents aidiv1 As Label
    Friend WithEvents aimul As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents aimul2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents aimul1 As Label
    Friend WithEvents aimin As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents aimin2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents aimin1 As Label
    Friend WithEvents aisum As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents aisum2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents aisum1 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeLbl As Label
    Friend WithEvents endBtn As Button
    Friend WithEvents aitime As Label
    Friend WithEvents menschtime As Label
End Class
