Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As String
        cadena = txtcadena.Text
        txtlongitud.Text = cadena.Length
        txtultimo.Text = cadena.Substring(cadena.Length - 1, 1)
        txtprimero.Text = cadena.Substring(0, 1)
        txtro.Text = cadena.Substring(2, 7)
        txtposicion.Text = cadena.IndexOf("B", 0) + 1

        txtmayuscula.Text = cadena.ToUpper
        txtminuscula.Text = cadena.ToLower
        txtborrar.Text = cadena.Replace(" ", "")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
