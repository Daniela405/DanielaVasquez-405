Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim Suma As Integer

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        Suma = valor1 + valor2

        txtSuma.Text = Suma
        }
    End Sub
End Class
