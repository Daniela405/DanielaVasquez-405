﻿Public Class Form1
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim itemId As Integer
        Dim itemNombre As String

        itemId = cmbEquipos.SelectedIndex
        itemNombre = cmbEquipos.SelectedItem.ToString
        Select Case itemId
            Case 0
                MsgBox(itemNombre)
            Case 1
                MsgBox(itemNombre)
            Case 2
                MsgBox(itemNombre)
            Case 3
                MsgBox(itemNombre)

            Case Else
                MsgBox("Selecciona un valor correcto")
        End Select
    End Sub
End Class
