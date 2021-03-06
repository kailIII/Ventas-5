﻿Public Class frmDetalleModeloSucursal

    Private Actual As DetalleModeloSucursal
    Private Detallesucursal As DetalleModeloSucursal
    Private campos_faltan As String
    Private idsucursal As Integer = modPrincipal.UsuarioLogeado.Empleado.Sucursal.Codigo

    Private Sub frmDetalleSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listar()
        listarmodelos()
    End Sub

    Sub listarmodelos()
        Dim rn As New RNModelo
        Dim Modelo As List(Of Modelo)

        Try
            Modelo = rn.Listar(idsucursal)
            modFunciones.ListarComboBox(Me.cmbModelo, Modelo, "Codigo", "NombreCompletoProducto")

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            rn = Nothing
        End Try
    End Sub
    Sub listar()
        Dim rn As New RNDetalleModeloSucursal
        Dim DetalleSucursal As List(Of DetalleModeloSucursal)

        Try
            DetalleSucursal = rn.ListarDetalle(idsucursal)
            modFunciones.EnlazarDatagridView(Me.dgvDetalle, DetalleSucursal)
            Me.dgvDetalle.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        listar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim rn As RNDetalleModeloSucursal
        Dim DS As DetalleModeloSucursal
        campos_faltan = ""
        If CamposCompletos() = True Then
            If Me.ValidateChildren = True Then
                DS = New DetalleModeloSucursal
                DS.Modelo = DirectCast(Me.cmbModelo.SelectedItem, Modelo)
                DS.PrecioVenta = CDbl(txtPrecio.Text)
                DS.Cantidad = CInt(txtCantidad.Text)

                rn = New RNDetalleModeloSucursal
                Try
                    If Me.Actual Is Nothing Then
                        rn.Registrar(DS, idsucursal)
                        MessageBox.Show("Se Registro el Precio de Modelo con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        limpiar()
                        listar()
                        controles(True)
                    Else
                        If (MessageBox.Show("¿Esta seguro de Modificar los datos de los precios?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                            DS.Modelo.Codigo = Me.Actual.Modelo.Codigo
                            rn.Actualizar(DS, idsucursal)
                            limpiar()
                            listar()
                            listarmodelos()
                        Else
                            ' Me.ActivarControles(True)
                        End If
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    rn = Nothing
                    DS = Nothing
                End Try
            End If
        Else
            MessageBox.Show(Me, "Es necesario completar todos los campos" & vbNewLine & campos_faltan, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Function CamposCompletos() As Boolean
        Dim Completo As Boolean = True
        If cmbModelo.Text = "" Then
            campos_faltan = campos_faltan & "  - Modelo(Falta seleccionar)." & vbNewLine
            Completo = False
        End If
        If txtCantidad.Text = "" Then
            campos_faltan = campos_faltan & "  - Cantidad( falta completar)." & vbNewLine
            Completo = False
        End If
        If txtPrecio.Text = "" Then
            campos_faltan = campos_faltan & "  - Celular ( 9 digitos de celular)." & vbNewLine

        End If
        Return Completo
    End Function


    Sub limpiar()
        txtPrecio.Clear()
        txtCantidad.Clear()
        cmbModelo.SelectedIndex = -1
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        listarmodelos()
        listar()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dgvDetalle.CurrentRow IsNot Nothing Then
            Me.Actual = DirectCast(Me.dgvDetalle.CurrentRow.DataBoundItem, DetalleModeloSucursal)
            Me.presentardatos()
        Else
            MessageBox.Show("Debe seleccionar un modelo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub presentardatos()
        Dim rn As New RNDetalleModeloSucursal

        Try
            Me.Actual = rn.Leer(Me.Actual, idsucursal)
            If Me.Actual IsNot Nothing Then
                With Me.Actual
                    Me.txtPrecio.Text = .PrecioVenta
                    cmbModelo.Items.Add(.Modelo.Descripcion)
                    Me.txtCantidad.Text = .Cantidad
                End With

            Else
                MessageBox.Show("No se encontró el modelo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub controles(ByVal val As Boolean)
        btnNuevo.Enabled = val
        tblistado.Enabled = val

    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress, txtCantidad.KeyPress
        teclear(e, False)
    End Sub

    Sub teclear(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal val As Boolean)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = val
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = val
        ElseIf Char.IsSymbol(e.KeyChar) And val = True Then
            e.Handled = val
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = Not val
        Else
            e.Handled = Not val
        End If
    End Sub


End Class