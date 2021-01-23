<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btHlavni
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(btHlavni))
        Me.rbKov = New System.Windows.Forms.RadioButton()
        Me.rbDrevo = New System.Windows.Forms.RadioButton()
        Me.rbPlast = New System.Windows.Forms.RadioButton()
        Me.group = New System.Windows.Forms.GroupBox()
        Me.volba = New System.Windows.Forms.CheckBox()
        Me.cislo1 = New System.Windows.Forms.TextBox()
        Me.cislo2 = New System.Windows.Forms.TextBox()
        Me.btSecti = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbSoucet = New System.Windows.Forms.Label()
        Me.numer = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.track = New System.Windows.Forms.TrackBar()
        Me.btEsc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.progBar = New System.Windows.Forms.ProgressBar()
        Me.lbVystup = New System.Windows.Forms.Label()
        Me.combo = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NápovědaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SouborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtevřítToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UložitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbProgress = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbTyp = New System.Windows.Forms.Label()
        Me.lbMaterial = New System.Windows.Forms.Label()
        Me.lbPovrch = New System.Windows.Forms.Label()
        Me.lbKs = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.icon1 = New System.Windows.Forms.ToolStripButton()
        Me.icon2 = New System.Windows.Forms.ToolStripButton()
        Me.icon3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.retezec = New System.Windows.Forms.Label()
        Me.typ = New System.Windows.Forms.Label()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.konec = New System.Windows.Forms.Label()
        Me.kalk = New System.Windows.Forms.Label()
        Me.hodnota = New System.Windows.Forms.Label()
        Me.hodnotPosuv = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.group.SuspendLayout()
        CType(Me.numer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbKov
        '
        Me.rbKov.AutoSize = True
        Me.rbKov.Location = New System.Drawing.Point(29, 29)
        Me.rbKov.Name = "rbKov"
        Me.rbKov.Size = New System.Drawing.Size(47, 17)
        Me.rbKov.TabIndex = 0
        Me.rbKov.TabStop = True
        Me.rbKov.Text = "KOV"
        Me.rbKov.UseVisualStyleBackColor = True
        '
        'rbDrevo
        '
        Me.rbDrevo.AutoSize = True
        Me.rbDrevo.Location = New System.Drawing.Point(29, 61)
        Me.rbDrevo.Name = "rbDrevo"
        Me.rbDrevo.Size = New System.Drawing.Size(63, 17)
        Me.rbDrevo.TabIndex = 1
        Me.rbDrevo.TabStop = True
        Me.rbDrevo.Text = "DŘEVO"
        Me.rbDrevo.UseVisualStyleBackColor = True
        '
        'rbPlast
        '
        Me.rbPlast.AutoSize = True
        Me.rbPlast.Location = New System.Drawing.Point(29, 93)
        Me.rbPlast.Name = "rbPlast"
        Me.rbPlast.Size = New System.Drawing.Size(59, 17)
        Me.rbPlast.TabIndex = 2
        Me.rbPlast.TabStop = True
        Me.rbPlast.Text = "PLAST"
        Me.rbPlast.UseVisualStyleBackColor = True
        '
        'group
        '
        Me.group.Controls.Add(Me.rbKov)
        Me.group.Controls.Add(Me.rbPlast)
        Me.group.Controls.Add(Me.rbDrevo)
        Me.group.Location = New System.Drawing.Point(232, 127)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(111, 141)
        Me.group.TabIndex = 3
        Me.group.TabStop = False
        Me.group.Text = "Zvolte materiál"
        '
        'volba
        '
        Me.volba.AutoSize = True
        Me.volba.Location = New System.Drawing.Point(362, 157)
        Me.volba.Name = "volba"
        Me.volba.Size = New System.Drawing.Size(98, 17)
        Me.volba.TabIndex = 4
        Me.volba.Text = "Lesklý povrch?"
        Me.volba.UseVisualStyleBackColor = True
        '
        'cislo1
        '
        Me.cislo1.Location = New System.Drawing.Point(423, 76)
        Me.cislo1.Name = "cislo1"
        Me.cislo1.Size = New System.Drawing.Size(51, 20)
        Me.cislo1.TabIndex = 5
        '
        'cislo2
        '
        Me.cislo2.Location = New System.Drawing.Point(522, 77)
        Me.cislo2.Name = "cislo2"
        Me.cislo2.Size = New System.Drawing.Size(51, 20)
        Me.cislo2.TabIndex = 6
        '
        'btSecti
        '
        Me.btSecti.Location = New System.Drawing.Point(596, 73)
        Me.btSecti.Name = "btSecti"
        Me.btSecti.Size = New System.Drawing.Size(37, 23)
        Me.btSecti.TabIndex = 7
        Me.btSecti.Text = "="
        Me.btSecti.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(490, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "+"
        '
        'lbSoucet
        '
        Me.lbSoucet.AutoSize = True
        Me.lbSoucet.Location = New System.Drawing.Point(652, 79)
        Me.lbSoucet.Name = "lbSoucet"
        Me.lbSoucet.Size = New System.Drawing.Size(49, 13)
        Me.lbSoucet.TabIndex = 9
        Me.lbSoucet.Text = "výsledek"
        '
        'numer
        '
        Me.numer.Location = New System.Drawing.Point(362, 180)
        Me.numer.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numer.Name = "numer"
        Me.numer.Size = New System.Drawing.Size(43, 20)
        Me.numer.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Kolik kusů? (max 3)"
        '
        'track
        '
        Me.track.Location = New System.Drawing.Point(579, 160)
        Me.track.Name = "track"
        Me.track.Size = New System.Drawing.Size(170, 45)
        Me.track.TabIndex = 12
        '
        'btEsc
        '
        Me.btEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btEsc.Image = CType(resources.GetObject("btEsc.Image"), System.Drawing.Image)
        Me.btEsc.Location = New System.Drawing.Point(68, 61)
        Me.btEsc.Name = "btEsc"
        Me.btEsc.Size = New System.Drawing.Size(63, 48)
        Me.btEsc.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btEsc, "Klikněte pro ukončení programu")
        Me.btEsc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tlačítko pro ukončení nebo stiskni ESC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Zvolte typ výrobku:"
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(407, 308)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox.Size = New System.Drawing.Size(255, 223)
        Me.TextBox.TabIndex = 17
        Me.TextBox.WordWrap = False
        '
        'progBar
        '
        Me.progBar.Location = New System.Drawing.Point(39, 446)
        Me.progBar.Name = "progBar"
        Me.progBar.Size = New System.Drawing.Size(244, 29)
        Me.progBar.TabIndex = 18
        '
        'lbVystup
        '
        Me.lbVystup.AutoSize = True
        Me.lbVystup.Location = New System.Drawing.Point(33, 374)
        Me.lbVystup.Name = "lbVystup"
        Me.lbVystup.Size = New System.Drawing.Size(0, 13)
        Me.lbVystup.TabIndex = 19
        '
        'combo
        '
        Me.combo.FormattingEnabled = True
        Me.combo.Items.AddRange(New Object() {"židle", "skříň", "police", "stůl", "postel", "křeslo", "pohovka"})
        Me.combo.Location = New System.Drawing.Point(39, 195)
        Me.combo.Name = "combo"
        Me.combo.Size = New System.Drawing.Size(121, 21)
        Me.combo.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NápovědaToolStripMenuItem, Me.SouborToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NápovědaToolStripMenuItem
        '
        Me.NápovědaToolStripMenuItem.Name = "NápovědaToolStripMenuItem"
        Me.NápovědaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.NápovědaToolStripMenuItem.Text = "Nápověda"
        '
        'SouborToolStripMenuItem
        '
        Me.SouborToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtevřítToolStripMenuItem, Me.UložitToolStripMenuItem})
        Me.SouborToolStripMenuItem.Name = "SouborToolStripMenuItem"
        Me.SouborToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SouborToolStripMenuItem.Text = "Soubor"
        '
        'OtevřítToolStripMenuItem
        '
        Me.OtevřítToolStripMenuItem.Name = "OtevřítToolStripMenuItem"
        Me.OtevřítToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OtevřítToolStripMenuItem.Text = "Otevřít"
        '
        'UložitToolStripMenuItem
        '
        Me.UložitToolStripMenuItem.Name = "UložitToolStripMenuItem"
        Me.UložitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.UložitToolStripMenuItem.Text = "Uložit"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'lbProgress
        '
        Me.lbProgress.AutoSize = True
        Me.lbProgress.Location = New System.Drawing.Point(42, 478)
        Me.lbProgress.Name = "lbProgress"
        Me.lbProgress.Size = New System.Drawing.Size(140, 13)
        Me.lbProgress.TabIndex = 25
        Me.lbProgress.Text = "Instalace probíhá, čekejte..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 560)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 26
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbTime
        '
        Me.lbTime.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(74, 17)
        Me.lbTime.Text = "Aktuální čas:"
        '
        'lbTyp
        '
        Me.lbTyp.AutoSize = True
        Me.lbTyp.Image = CType(resources.GetObject("lbTyp.Image"), System.Drawing.Image)
        Me.lbTyp.Location = New System.Drawing.Point(239, 281)
        Me.lbTyp.Name = "lbTyp"
        Me.lbTyp.Size = New System.Drawing.Size(0, 13)
        Me.lbTyp.TabIndex = 27
        Me.lbTyp.Visible = False
        '
        'lbMaterial
        '
        Me.lbMaterial.AutoSize = True
        Me.lbMaterial.Location = New System.Drawing.Point(42, 267)
        Me.lbMaterial.Name = "lbMaterial"
        Me.lbMaterial.Size = New System.Drawing.Size(44, 13)
        Me.lbMaterial.TabIndex = 28
        Me.lbMaterial.Text = "Materiál"
        Me.lbMaterial.Visible = False
        '
        'lbPovrch
        '
        Me.lbPovrch.AutoSize = True
        Me.lbPovrch.Location = New System.Drawing.Point(33, 281)
        Me.lbPovrch.Name = "lbPovrch"
        Me.lbPovrch.Size = New System.Drawing.Size(77, 13)
        Me.lbPovrch.TabIndex = 29
        Me.lbPovrch.Text = "povrch - matný"
        Me.lbPovrch.Visible = False
        '
        'lbKs
        '
        Me.lbKs.AutoSize = True
        Me.lbKs.Location = New System.Drawing.Point(42, 294)
        Me.lbKs.Name = "lbKs"
        Me.lbKs.Size = New System.Drawing.Size(27, 13)
        Me.lbKs.TabIndex = 30
        Me.lbKs.Text = "0 ks"
        Me.lbKs.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.icon1, Me.icon2, Me.icon3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'icon1
        '
        Me.icon1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon1.Image = CType(resources.GetObject("icon1.Image"), System.Drawing.Image)
        Me.icon1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon1.Name = "icon1"
        Me.icon1.Size = New System.Drawing.Size(23, 22)
        Me.icon1.Text = "ToolStripButton1"
        Me.icon1.ToolTipText = "Změň obrázek na tlačítku ESC"
        '
        'icon2
        '
        Me.icon2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon2.Image = CType(resources.GetObject("icon2.Image"), System.Drawing.Image)
        Me.icon2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon2.Name = "icon2"
        Me.icon2.Size = New System.Drawing.Size(23, 22)
        Me.icon2.Text = "ToolStripButton2"
        Me.icon2.ToolTipText = "Změň obrázek na tlačítku ESC"
        '
        'icon3
        '
        Me.icon3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon3.Image = CType(resources.GetObject("icon3.Image"), System.Drawing.Image)
        Me.icon3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon3.Name = "icon3"
        Me.icon3.Size = New System.Drawing.Size(23, 22)
        Me.icon3.Text = "ToolStripButton3"
        Me.icon3.ToolTipText = "Změň obrázek na tlačítku ESC"
        '
        'openFile
        '
        Me.openFile.FileName = "OpenFileDialog1"
        '
        'retezec
        '
        Me.retezec.AutoSize = True
        Me.retezec.Location = New System.Drawing.Point(36, 345)
        Me.retezec.Name = "retezec"
        Me.retezec.Size = New System.Drawing.Size(50, 13)
        Me.retezec.TabIndex = 32
        Me.retezec.Text = "Nábytek:"
        '
        'typ
        '
        Me.typ.AutoSize = True
        Me.typ.Location = New System.Drawing.Point(42, 254)
        Me.typ.Name = "typ"
        Me.typ.Size = New System.Drawing.Size(77, 13)
        Me.typ.TabIndex = 33
        Me.typ.Text = "typ - nezadáno"
        Me.typ.Visible = False
        '
        'konec
        '
        Me.konec.AutoSize = True
        Me.konec.Location = New System.Drawing.Point(36, 321)
        Me.konec.Name = "konec"
        Me.konec.Size = New System.Drawing.Size(112, 13)
        Me.konec.TabIndex = 34
        Me.konec.Text = "Výsledná objednávka:"
        '
        'kalk
        '
        Me.kalk.AutoSize = True
        Me.kalk.Location = New System.Drawing.Point(513, 49)
        Me.kalk.Name = "kalk"
        Me.kalk.Size = New System.Drawing.Size(60, 13)
        Me.kalk.TabIndex = 35
        Me.kalk.Text = "Kalkulačka"
        '
        'hodnota
        '
        Me.hodnota.AutoSize = True
        Me.hodnota.Location = New System.Drawing.Point(593, 198)
        Me.hodnota.Name = "hodnota"
        Me.hodnota.Size = New System.Drawing.Size(105, 13)
        Me.hodnota.TabIndex = 36
        Me.hodnota.Text = "Hodnota posuvníku:"
        '
        'hodnotPosuv
        '
        Me.hodnotPosuv.AutoSize = True
        Me.hodnotPosuv.Location = New System.Drawing.Point(704, 198)
        Me.hodnotPosuv.Name = "hodnotPosuv"
        Me.hodnotPosuv.Size = New System.Drawing.Size(13, 13)
        Me.hodnotPosuv.TabIndex = 37
        Me.hodnotPosuv.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Textové pole pro otevření, úpravu a uložení souborů"
        '
        'btHlavni
        '
        Me.AcceptButton = Me.btSecti
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btEsc
        Me.ClientSize = New System.Drawing.Size(800, 582)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hodnotPosuv)
        Me.Controls.Add(Me.hodnota)
        Me.Controls.Add(Me.kalk)
        Me.Controls.Add(Me.konec)
        Me.Controls.Add(Me.typ)
        Me.Controls.Add(Me.retezec)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbKs)
        Me.Controls.Add(Me.lbPovrch)
        Me.Controls.Add(Me.lbMaterial)
        Me.Controls.Add(Me.lbTyp)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbProgress)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.combo)
        Me.Controls.Add(Me.lbVystup)
        Me.Controls.Add(Me.progBar)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btEsc)
        Me.Controls.Add(Me.track)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numer)
        Me.Controls.Add(Me.lbSoucet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSecti)
        Me.Controls.Add(Me.cislo2)
        Me.Controls.Add(Me.cislo1)
        Me.Controls.Add(Me.volba)
        Me.Controls.Add(Me.group)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "btHlavni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Nábytek"
        Me.group.ResumeLayout(False)
        Me.group.PerformLayout()
        CType(Me.numer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbKov As Windows.Forms.RadioButton
    Friend WithEvents rbDrevo As Windows.Forms.RadioButton
    Friend WithEvents rbPlast As Windows.Forms.RadioButton
    Friend WithEvents group As Windows.Forms.GroupBox
    Friend WithEvents volba As Windows.Forms.CheckBox
    Friend WithEvents cislo1 As Windows.Forms.TextBox
    Friend WithEvents cislo2 As Windows.Forms.TextBox
    Friend WithEvents btSecti As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lbSoucet As Windows.Forms.Label
    Friend WithEvents numer As Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents track As Windows.Forms.TrackBar
    Friend WithEvents btEsc As Windows.Forms.Button
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents TextBox As Windows.Forms.TextBox
    Friend WithEvents progBar As Windows.Forms.ProgressBar
    Friend WithEvents lbVystup As Windows.Forms.Label
    Friend WithEvents combo As Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents NápovědaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SouborToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtevřítToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UložitToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents Timer2 As Windows.Forms.Timer
    Friend WithEvents lbProgress As Windows.Forms.Label
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents lbTime As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbTyp As Windows.Forms.Label
    Friend WithEvents lbMaterial As Windows.Forms.Label
    Friend WithEvents lbPovrch As Windows.Forms.Label
    Friend WithEvents lbKs As Windows.Forms.Label
    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents icon1 As Windows.Forms.ToolStripButton
    Friend WithEvents icon2 As Windows.Forms.ToolStripButton
    Friend WithEvents icon3 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents openFile As Windows.Forms.OpenFileDialog
    Friend WithEvents retezec As Windows.Forms.Label
    Friend WithEvents typ As Windows.Forms.Label
    Friend WithEvents saveFile As Windows.Forms.SaveFileDialog
    Friend WithEvents konec As Windows.Forms.Label
    Friend WithEvents kalk As Windows.Forms.Label
    Friend WithEvents hodnota As Windows.Forms.Label
    Friend WithEvents hodnotPosuv As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
