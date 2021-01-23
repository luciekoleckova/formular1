
Option Explicit On
Option Strict On
Option Infer On
Imports System.Windows.Forms
Module module1

    Public progressMax As Integer
    Sub Main()

        Dim fr As New btHlavni

        progressMax = CInt(Val(InputBox("Zadejte počet sekund, větší než 5: ")))

        If IsNumeric(progressMax) And progressMax > 5 Then
            fr.ShowDialog()
        Else
            MsgBox("Chyba! Zadali jste špatnou hodnotu.")
        End If



    End Sub

End Module
