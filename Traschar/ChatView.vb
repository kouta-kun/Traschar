Public Class ChatView
    Private group As Integer
    Private lastMsg As Integer = -1
    Public timer As Timer
    Public Sub New(group As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.group = group
        UpdateBox()
        timer = New Timer
        timer.Interval = 1500
        AddHandler timer.Tick, Sub(o As Object, e As EventArgs) UpdateBox()
        timer.Enabled = True
    End Sub

    Private Sub UpdateBox()
        If ChatDB.GetInstance.Ready AndAlso lastMsg <> ChatDB.GetInstance().LastMessage(group) Then
            lastMsg = ChatDB.GetInstance().LastMessage(group)
            Me.messageList.Items.Clear()
            Me.messageList.Items.AddRange(ChatDB.GetInstance.GetMessages(group).Reverse.ToArray)
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        ChatDB.GetInstance.SendMessage(group, msgBox.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ChatDB.GetInstance.AddUserGroup(group, userBox.Text)
    End Sub
End Class
