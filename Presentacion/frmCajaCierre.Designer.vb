﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaCierre

    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajaCierre))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabCerrar = New MetroFramework.Controls.MetroTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelarCierre = New System.Windows.Forms.Button()
        Me.btnGuardarCierre = New System.Windows.Forms.Button()
        Me.gbCierreCaja = New System.Windows.Forms.GroupBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtObservacion = New MetroFramework.Controls.MetroTextBox()
        Me.txtMontoCierre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.dgbCaja = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtNumCaja = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabCerrar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbCierreCaja.SuspendLayout()
        CType(Me.dgbCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 8)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 57)
        Me.Button6.TabIndex = 159
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.AutoSize = True
        Me.MetroTile2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Location = New System.Drawing.Point(0, 1)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(516, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 158
        Me.MetroTile2.Text = "CIERRE DE CAJA"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseStyleColors = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.AllowDrop = True
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl1.Controls.Add(Me.tabCerrar)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 71)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(516, 283)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabCerrar
        '
        Me.tabCerrar.Controls.Add(Me.Panel3)
        Me.tabCerrar.Controls.Add(Me.gbCierreCaja)
        Me.tabCerrar.HorizontalScrollbarBarColor = True
        Me.tabCerrar.HorizontalScrollbarHighlightOnWheel = False
        Me.tabCerrar.HorizontalScrollbarSize = 10
        Me.tabCerrar.Location = New System.Drawing.Point(4, 41)
        Me.tabCerrar.Name = "tabCerrar"
        Me.tabCerrar.Size = New System.Drawing.Size(508, 238)
        Me.tabCerrar.TabIndex = 1
        Me.tabCerrar.Text = "Cerrar Caja"
        Me.tabCerrar.VerticalScrollbarBarColor = True
        Me.tabCerrar.VerticalScrollbarHighlightOnWheel = False
        Me.tabCerrar.VerticalScrollbarSize = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.btnCancelarCierre)
        Me.Panel3.Controls.Add(Me.btnGuardarCierre)
        Me.Panel3.Location = New System.Drawing.Point(3, 169)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 68)
        Me.Panel3.TabIndex = 176
        '
        'btnCancelarCierre
        '
        Me.btnCancelarCierre.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelarCierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelarCierre.FlatAppearance.BorderSize = 0
        Me.btnCancelarCierre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelarCierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCancelarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarCierre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCierre.ForeColor = System.Drawing.Color.White
        Me.btnCancelarCierre.Image = CType(resources.GetObject("btnCancelarCierre.Image"), System.Drawing.Image)
        Me.btnCancelarCierre.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelarCierre.Location = New System.Drawing.Point(428, -2)
        Me.btnCancelarCierre.Name = "btnCancelarCierre"
        Me.btnCancelarCierre.Size = New System.Drawing.Size(72, 72)
        Me.btnCancelarCierre.TabIndex = 1
        Me.btnCancelarCierre.Text = "Cancelar"
        Me.btnCancelarCierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelarCierre.UseVisualStyleBackColor = False
        '
        'btnGuardarCierre
        '
        Me.btnGuardarCierre.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarCierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarCierre.FlatAppearance.BorderSize = 0
        Me.btnGuardarCierre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGuardarCierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGuardarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCierre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCierre.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCierre.Image = CType(resources.GetObject("btnGuardarCierre.Image"), System.Drawing.Image)
        Me.btnGuardarCierre.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardarCierre.Location = New System.Drawing.Point(279, -2)
        Me.btnGuardarCierre.Name = "btnGuardarCierre"
        Me.btnGuardarCierre.Size = New System.Drawing.Size(143, 72)
        Me.btnGuardarCierre.TabIndex = 0
        Me.btnGuardarCierre.Text = "Guardar Cierre de Caja"
        Me.btnGuardarCierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarCierre.UseVisualStyleBackColor = False
        '
        'gbCierreCaja
        '
        Me.gbCierreCaja.BackColor = System.Drawing.Color.White
        Me.gbCierreCaja.Controls.Add(Me.txtNumCaja)
        Me.gbCierreCaja.Controls.Add(Me.MetroLabel5)
        Me.gbCierreCaja.Controls.Add(Me.MetroLabel1)
        Me.gbCierreCaja.Controls.Add(Me.txtObservacion)
        Me.gbCierreCaja.Controls.Add(Me.txtMontoCierre)
        Me.gbCierreCaja.Controls.Add(Me.MetroLabel8)
        Me.gbCierreCaja.Location = New System.Drawing.Point(3, 3)
        Me.gbCierreCaja.Name = "gbCierreCaja"
        Me.gbCierreCaja.Size = New System.Drawing.Size(500, 160)
        Me.gbCierreCaja.TabIndex = 2
        Me.gbCierreCaja.TabStop = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(27, 25)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel5.TabIndex = 189
        Me.MetroLabel5.Text = "NÚMERO DE CAJA"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(27, 113)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 186
        Me.MetroLabel1.Text = "OBSERVACIONES"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Lines = New String(-1) {}
        Me.txtObservacion.Location = New System.Drawing.Point(161, 113)
        Me.txtObservacion.MaxLength = 25
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObservacion.SelectedText = ""
        Me.txtObservacion.Size = New System.Drawing.Size(320, 23)
        Me.txtObservacion.TabIndex = 4
        Me.txtObservacion.UseSelectable = True
        '
        'txtMontoCierre
        '
        Me.txtMontoCierre.Lines = New String(-1) {}
        Me.txtMontoCierre.Location = New System.Drawing.Point(161, 70)
        Me.txtMontoCierre.MaxLength = 32767
        Me.txtMontoCierre.Name = "txtMontoCierre"
        Me.txtMontoCierre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontoCierre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontoCierre.SelectedText = ""
        Me.txtMontoCierre.Size = New System.Drawing.Size(137, 23)
        Me.txtMontoCierre.TabIndex = 1
        Me.txtMontoCierre.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(27, 70)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel8.TabIndex = 182
        Me.MetroLabel8.Text = "MONTO CIERRE"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        Me.MetroLabel8.UseStyleColors = True
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(161, 89)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.Size = New System.Drawing.Size(98, 23)
        Me.MetroTextBox3.TabIndex = 178
        Me.MetroTextBox3.UseSelectable = True
        '
        'MetroTextBox4
        '
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(161, 132)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.Size = New System.Drawing.Size(98, 23)
        Me.MetroTextBox4.TabIndex = 179
        Me.MetroTextBox4.UseSelectable = True
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTextBox2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(143, 47)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.Size = New System.Drawing.Size(285, 23)
        Me.MetroTextBox2.TabIndex = 160
        Me.MetroTextBox2.UseSelectable = True
        '
        'dgbCaja
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgbCaja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgbCaja.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgbCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgbCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbCaja.Location = New System.Drawing.Point(3, 90)
        Me.dgbCaja.Name = "dgbCaja"
        Me.dgbCaja.Size = New System.Drawing.Size(442, 180)
        Me.dgbCaja.TabIndex = 162
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(338, -2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 72)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Guardar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtNumCaja
        '
        Me.txtNumCaja.Enabled = False
        Me.txtNumCaja.Lines = New String(-1) {}
        Me.txtNumCaja.Location = New System.Drawing.Point(161, 25)
        Me.txtNumCaja.MaxLength = 32767
        Me.txtNumCaja.Name = "txtNumCaja"
        Me.txtNumCaja.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCaja.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumCaja.SelectedText = ""
        Me.txtNumCaja.Size = New System.Drawing.Size(137, 23)
        Me.txtNumCaja.TabIndex = 190
        Me.txtNumCaja.UseSelectable = True
        '
        'frmCajaCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 358)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmCajaCierre"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabCerrar.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.gbCierreCaja.ResumeLayout(False)
        Me.gbCierreCaja.PerformLayout()
        CType(Me.dgbCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgbCaja As System.Windows.Forms.DataGridView
    Friend WithEvents tabCerrar As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gbCierreCaja As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontoCierre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarCierre As System.Windows.Forms.Button
    Friend WithEvents btnGuardarCierre As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtNumCaja As MetroFramework.Controls.MetroTextBox
End Class
