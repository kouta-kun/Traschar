Public Class MainForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not ChatDB.GetInstance.Login(unameTxt.Text, pwdTxt.Text) Then
            MsgBox("Incorrect username/password")
        Else
            groupList.Items.Clear()
            groupList.Items.AddRange(ChatDB.GetInstance.GetGroups.Select(Of String)(Function(x) x.Item2.ToString + "#" + x.Item1).ToArray)
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ChatDB.GetInstance.CreateGroup(groupBox.Text)
        groupList.Items.Clear()
        groupList.Items.AddRange(ChatDB.GetInstance.GetGroups.Select(Of String)(Function(x) x.Item2.ToString + "#" + x.Item1).ToArray)
    End Sub

    Private Sub groupList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles groupList.SelectedIndexChanged
        If groupList.SelectedItem IsNot Nothing Then
            chatPanel.Controls.Clear()
            chatPanel.Controls.Add(New ChatView(Integer.Parse(CType(groupList.SelectedItem, String).Split("#")(0))))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ChatDB.Register(unameTxt.Text, pwdTxt.Text) Then
            MsgBox("Registro con éxito!")
        Else
            MsgBox("Algún problema al registrar")
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChatDB.GetInstance()
    End Sub
End Class
