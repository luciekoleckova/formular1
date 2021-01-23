Option Explicit On
Option Strict Off
Imports System.Windows.Forms


Public Class btHlavni
    Dim PuvFont, NovyFont As System.Drawing.Font
    Dim FontStyle As System.Drawing.FontStyle
    Dim retez As String = ""

    Private Sub btEsc_Click(sender As Object, e As EventArgs) Handles btEsc.Click
        Me.Close()
    End Sub
    'timer
    Private Sub frMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.progBar.Maximum = progressMax * 1000
        Me.Timer1.Start()
        Me.Timer2.Start()

        PuvFont = Me.lbSoucet.Font
        NovyFont = New System.Drawing.Font(lbSoucet.Font.SystemFontName, 9, FontStyle.Bold)


    End Sub
    Public DayTimeNow As DateTime
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.progBar.Value += Me.Timer1.Interval
        If Me.progBar.Value = Me.progBar.Maximum Then Me.Timer1.Stop()

        Dim Progress As Integer
        Progress = progressMax
        Progress -= Me.progBar.Value / 1000
        lbProgress.Text = "Instalace probíhá, čekejte... " + Progress.ToString
    End Sub
    'Hodiny
    '---------------------------------------------------------------------------
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.DayTimeNow = System.DateTime.Now
        Me.lbTime.Text = "Aktuální čas: " + DayTimeNow.ToString("HH:mm:ss")
    End Sub

    'TrackBar
    Private Sub track_ValueChanged(sender As Object, e As EventArgs) Handles track.ValueChanged
        Dim pos As Integer
        pos = track.Value
        ' lbTrack.Text = pos.ToString
        hodnotPosuv.Text = pos.ToString
    End Sub



    Private Sub icon2_Click(sender As Object, e As EventArgs) Handles icon2.Click
        btEsc.Image = icon2.Image
    End Sub

    Private Sub icon3_Click(sender As Object, e As EventArgs) Handles icon3.Click
        btEsc.Image = icon3.Image
    End Sub

    Private Sub icon1_Click(sender As Object, e As EventArgs) Handles icon1.Click
        btEsc.Image = icon1.Image
    End Sub

    Private Sub NápovědaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NápovědaToolStripMenuItem.Click
        MsgBox("Zde najdete nápovědu")
    End Sub

    Private Sub OtevřítToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtevřítToolStripMenuItem.Click

        Dim dialog As DialogResult
        Dim vysledek As String
        dialog = openFile.ShowDialog()
        If dialog.Equals(DialogResult.OK) Then
            FileOpen(1, openFile.FileName, OpenMode.Input)
            TextBox.Clear()
            Try
                vysledek = openFile.FileName
            Finally
                FileClose(1)
                TextBox.Text = My.Computer.FileSystem.ReadAllText(vysledek)
            End Try
        End If
    End Sub

    Private Sub UložitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UložitToolStripMenuItem.Click
        saveFile.ShowDialog()
        FileOpen(1, saveFile.FileName, OpenMode.Output)
        Write(1, TextBox.Text)
        FileClose(1)
    End Sub


    Sub Secti()
        Dim A As Integer
        Dim B As Integer
        Dim S As Integer

        A = CInt(Val(cislo1.Text))
        B = CInt(Val(cislo2.Text))
        S = A + B

        lbSoucet.Text = S.ToString
        If S > 0 Then
            lbSoucet.Font = NovyFont
        Else
            lbSoucet.Font = PuvFont
        End If

    End Sub


    Private Sub btSecti_Click(sender As Object, e As EventArgs) Handles btSecti.Click
        Secti()
    End Sub

    'retezec Combobox typ výrobku
    '---------------------------------------------------------------------------
    Private Sub combo_TextChanged(sender As Object, e As EventArgs) Handles combo.TextChanged
        typ.Text = combo.Text
        If (typ.Text = "") Then
            typ.Text = "typ - nezadáno"
        End If
        retez = typ.Text + ", " + lbMaterial.Text + ", " + lbPovrch.Text + ", " + lbKs.Text
        retezec.Text = retez

    End Sub

    Private Sub combo_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo.SelectedValueChanged
        typ.Text = combo.Text
        If (typ.Text = "") Then
            typ.Text = "typ - nezadáno"
        End If
        retez = typ.Text + ", " + lbMaterial.Text + ", " + lbPovrch.Text + ", " + lbKs.Text
        retezec.Text = retez

    End Sub

    'Radiobuttons
    '---------------------------------------------------------------------------
    Private Sub rbKov_CheckedChanged(sender As Object, e As EventArgs) Handles rbKov.CheckedChanged
        If rbKov.Checked Then lbMaterial.Text = "materiál: kov"
        retez = typ.Text + ", " + lbMaterial.Text + ", " + lbPovrch.Text + ", " + lbKs.Text
        retezec.Text = retez
    End Sub

    Private Sub rbDrevo_CheckedChanged(sender As Object, e As EventArgs) Handles rbDrevo.CheckedChanged
        If rbDrevo.Checked Then lbMaterial.Text = "materiál: dřevo"
        retez = typ.Text + ", " + lbMaterial.Text + ", " + lbPovrch.Text + ", " + lbKs.Text
        retezec.Text = retez
    End Sub

    Private Sub rbPlast_CheckedChanged(sender As Object, e As EventArgs) Handles rbPlast.CheckedChanged
        If rbPlast.Checked Then lbMaterial.Text = "materiál: plast"
        retez = typ.Text + ", " + lbMaterial.Text + ", " + lbPovrch.Text + ", " + lbKs.Text
        retezec.Text = retez
    End Sub

    'Lesklý checkbox
    '---------------------------------------------------------------------------
    Private Sub volba_CheckedChanged(sender As Object, e As EventArgs) Handles volba.CheckedChanged
        lbPovrch.Text = "matný povrch"
        If volba.Checked Then lbPovrch.Text = "lesklý povrch"
        retez = typ.Text + ", " + lbMaterial.Text + ", " + lbPovrch.Text + ", " + lbKs.Text
        retezec.Text = retez
    End Sub

    'NumUpDown Kusy

    Private Sub numer_ValueChanged(sender As Object, e As EventArgs) Handles numer.ValueChanged
        lbKs.Text = numer.Value.ToString + " ks"
        retez = typ.Text + ", " + lbMaterial.Text + ", " + lbPovrch.Text + ", " + lbKs.Text
        retezec.Text = retez

    End Sub


End Class