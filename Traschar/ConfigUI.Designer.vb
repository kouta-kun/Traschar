<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigUI
    Inherits System.Windows.Forms.Form

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
        Me.hostTxt = New System.Windows.Forms.TextBox()
        Me.unameTxt = New System.Windows.Forms.TextBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.portNum = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenButton = New System.Windows.Forms.Button()
        CType(Me.portNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hostTxt
        '
        Me.hostTxt.Location = New System.Drawing.Point(12, 12)
        Me.hostTxt.Name = "hostTxt"
        Me.hostTxt.Size = New System.Drawing.Size(100, 20)
        Me.hostTxt.TabIndex = 0
        '
        'unameTxt
        '
        Me.unameTxt.Location = New System.Drawing.Point(12, 38)
        Me.unameTxt.Name = "unameTxt"
        Me.unameTxt.Size = New System.Drawing.Size(100, 20)
        Me.unameTxt.TabIndex = 1
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(12, 64)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(100, 20)
        Me.passTxt.TabIndex = 2
        '
        'portNum
        '
        Me.portNum.Location = New System.Drawing.Point(12, 90)
        Me.portNum.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.portNum.Name = "portNum"
        Me.portNum.Size = New System.Drawing.Size(100, 20)
        Me.portNum.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DB Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Port"
        '
        'OpenButton
        '
        Me.OpenButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OpenButton.Location = New System.Drawing.Point(295, 10)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenButton.TabIndex = 8
        Me.OpenButton.Text = "Abrir"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'ConfigUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 139)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.portNum)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.unameTxt)
        Me.Controls.Add(Me.hostTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ConfigUI"
        Me.Text = "ConfigUI"
        CType(Me.portNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hostTxt As TextBox
    Friend WithEvents unameTxt As TextBox
    Friend WithEvents passTxt As TextBox
    Friend WithEvents portNum As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenButton As Button
End Class
