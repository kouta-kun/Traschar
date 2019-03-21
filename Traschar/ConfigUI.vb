Imports MySql.Data.MySqlClient
Public Class ConfigUI
    Public Shared Function OpenDatabase() As MySqlConnection
        Dim cUI As New ConfigUI
        cUI.ShowDialog(Nothing)
        Dim t As String = "datasource=" + cUI.hostTxt.Text + ";port=" + cUI.portNum.Value.ToString + ";username=" + cUI.unameTxt.Text + ";password=" + cUI.passTxt.Text + ";database=tscr"
        Return New MySqlConnection(t)
    End Function
End Class