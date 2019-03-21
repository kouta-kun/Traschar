<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatView
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.messageList = New System.Windows.Forms.ListBox()
        Me.msgBox = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.userBox = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'messageList
        '
        Me.messageList.FormattingEnabled = True
        Me.messageList.Location = New System.Drawing.Point(3, 3)
        Me.messageList.Name = "messageList"
        Me.messageList.Size = New System.Drawing.Size(554, 225)
        Me.messageList.TabIndex = 0
        '
        'msgBox
        '
        Me.msgBox.Location = New System.Drawing.Point(3, 270)
        Me.msgBox.Name = "msgBox"
        Me.msgBox.Size = New System.Drawing.Size(476, 20)
        Me.msgBox.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(485, 267)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(72, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Enviar"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'userBox
        '
        Me.userBox.Location = New System.Drawing.Point(3, 234)
        Me.userBox.Name = "userBox"
        Me.userBox.Size = New System.Drawing.Size(100, 20)
        Me.userBox.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(109, 232)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Agregar usuario"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ChatView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.userBox)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.msgBox)
        Me.Controls.Add(Me.messageList)
        Me.Name = "ChatView"
        Me.Size = New System.Drawing.Size(560, 300)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents messageList As ListBox
    Friend WithEvents msgBox As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents userBox As TextBox
    Friend WithEvents btnAdd As Button
End Class
