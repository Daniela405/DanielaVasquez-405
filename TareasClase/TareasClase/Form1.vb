﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Integer
        valor = InputBox("Ingrese un numero", "Ingreso")
        txtValor.Text = valor
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma, resta, multiplicacion, valor As Integer
        Dim division As Double
        valor = Val(txtValor.Text)
        For i = 1 To 10 Step 1
            suma = valor + 1
            resta = valor - 1
            multiplicacion = valor * 1
            division = Format((valor / i).ToString, 2)
            cmbSuma.Items.Add(valor & " + " & i & "=" & suma)
            cmbResta.Items.Add(valor & " - " & i & "=" & resta)
            cmbMultiplicacion.Items.Add(valor & " * " & i & "=" & multiplicacion)
            cmbDivision.Items.Add(valor & " / " & i & "=" & division)
        Next
    End Sub
End Class
