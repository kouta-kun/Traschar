<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.pwdTxt = New System.Windows.Forms.TextBox()
        Me.unameTxt = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.groupList = New System.Windows.Forms.ListBox()
        Me.groupBox = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.chatPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pwdTxt
        '
        Me.pwdTxt.Location = New System.Drawing.Point(370, 12)
        Me.pwdTxt.Name = "pwdTxt"
        Me.pwdTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwdTxt.Size = New System.Drawing.Size(100, 20)
        Me.pwdTxt.TabIndex = 1
        '
        'unameTxt
        '
        Me.unameTxt.Location = New System.Drawing.Point(264, 12)
        Me.unameTxt.Name = "unameTxt"
        Me.unameTxt.Size = New System.Drawing.Size(100, 20)
        Me.unameTxt.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(183, 10)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Ingresar"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'groupList
        '
        Me.groupList.FormattingEnabled = True
        Me.groupList.Location = New System.Drawing.Point(12, 12)
        Me.groupList.Name = "groupList"
        Me.groupList.Size = New System.Drawing.Size(93, 264)
        Me.groupList.TabIndex = 3
        '
        'groupBox
        '
        Me.groupBox.Location = New System.Drawing.Point(12, 282)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(93, 20)
        Me.groupBox.TabIndex = 4
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 308)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(93, 23)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Crear grupo"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'chatPanel
        '
        Me.chatPanel.Location = New System.Drawing.Point(111, 39)
        Me.chatPanel.Name = "chatPanel"
        Me.chatPanel.Size = New System.Drawing.Size(560, 300)
        Me.chatPanel.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(476, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 348)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chatPanel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.groupList)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.unameTxt)
        Me.Controls.Add(Me.pwdTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.Text = "TSCR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pwdTxt As TextBox
    Friend WithEvents unameTxt As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents groupList As ListBox
    Friend WithEvents groupBox As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents chatPanel As Panel
    Friend WithEvents Button1 As Button
End Class
