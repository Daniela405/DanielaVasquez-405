Public Class Form1
    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        'Try Catch
        'ValidateChildren  Botton
        'Validating     Cajas de texto
        Try
            'Si las casillas estan sin  ningun valor
            'Aplique a todos los elementos>  Producto sea diferente de vacio, precio sea diferente de vacio, Cantidad sea un valor entero
            If Me.ValidateChildren And txtProducto.Text <> String.Empty And txtPrecio.Text <> String.Empty And Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
                MessageBox.Show("Producto Ingresado", "Formulario Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un número entero")
        End If
    End Sub

    Private Sub txtProducto_MouseHover(sender As Object, e As EventArgs) Handles txtProducto.MouseHover
        Windows.Forms.ToolTip.SetToolTip(txtProducto, "Ingrese un producto")
        Windows.Forms.ToolTip.ToolTipTitle = "Producto"
        Windows.Forms.ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        Windows.Forms.ToolTip.SetToolTip(txtPrecio, "Ingrese el precio")
        Windows.Forms.ToolTip.ToolTipTitle = "Precio"
        Windows.Forms.ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        Windows.Forms.ToolTip.SetToolTip(txtCantidad, "Ingrese la cantidad (entero)")
        Windows.Forms.ToolTip.ToolTipTitle = "Cantidad"
        Windows.Forms.ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        Windows.Forms.ToolTip.SetToolTip(txtDescripcion, "Ingrese una descripcion")
        Windows.Forms.ToolTip.ToolTipTitle = "Descripcion"
        Windows.Forms.ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
