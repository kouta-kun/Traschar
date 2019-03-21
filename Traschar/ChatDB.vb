Imports MySql.Data.MySqlClient
Public Class ChatDB
    Public uname As String
    Public pwd As String
    Public logged As Boolean = False
    Private dbCon As MySqlConnection
    Private Shared cdb As ChatDB
    Public Shared Function GetInstance() As ChatDB
        If cdb Is Nothing Then
            cdb = New ChatDB
        End If
        Return cdb
    End Function
    Public Function Ready() As Boolean
        Return dbCon.State = ConnectionState.Closed
    End Function
    Private Sub New()
        dbCon = ConfigUI.OpenDatabase
    End Sub

    Public Sub SendMessage(groupId As Integer, message As String)
        Dim cmd As New MySqlCommand("insert into messages(userid, message, groupid) values ('" + uname + "', '" + message + "', " + groupId.ToString + ");", dbCon)
        dbCon.Open()
        cmd.ExecuteNonQuery()
        dbCon.Close()
    End Sub

    Public Function GetMessages(groupId As Integer, Optional pageId As Integer = 0) As String()
        If Not logged Then
            Return Nothing
        End If
        Dim iP As Integer = pageId * 15
        Dim cmdStr As String = "select userid, message from messages where groupid=" + groupId.ToString + " order by messageid desc limit " + iP.ToString + ", 15;"
        Dim cmd As New MySqlCommand(cmdStr, dbCon)
        dbCon.Open()
        Dim r As MySqlDataReader = cmd.ExecuteReader()
        Dim lsMsg As New List(Of String)
        While r.Read
            lsMsg.Add(r.Item(0) + ": " + r.Item(1))
        End While
        dbCon.Close()
        Return lsMsg.ToArray
    End Function

    Public Function LastMessage(groupId As Integer) As Integer
        Dim cmd As New MySqlCommand("select messageid from messages where groupid=" + groupId.ToString + " order by messageid desc limit 1;", dbCon)
        Try
            dbCon.Open()
            Dim r As Integer = cmd.ExecuteScalar()
            dbCon.Close()
            Return r
        Catch
            Return -1
        End Try
    End Function

    Public Function CreateGroup(groupName As String) As Boolean
        Dim cmd As New MySqlCommand("insert into chatgroup(name) values ('" + groupName + "');", dbCon)
        dbCon.Open()
        Dim res As Boolean = False
        If cmd.ExecuteNonQuery() = 1 Then
            Dim fcmd As New MySqlCommand("select chatgroup.groupid from chatgroup where chatgroup.name like '" + groupName + "';", dbCon)
            Dim groupid As Integer = CType(fcmd.ExecuteScalar(), Integer)
            fcmd = New MySqlCommand("insert into isInGroup(groupid, userId) values (" + CType(groupid, Integer).ToString + ", '" + uname + "');", dbCon)
            If fcmd.ExecuteNonQuery() = 1 Then
                res = True
            End If
        End If
        dbCon.Close()
        Return res
    End Function

    Public Function AddUserGroup(group As Integer, user As String) As Boolean
        If logged Then
            Dim cd As New MySqlCommand("select count(*) from isInGroup where isInGroup.userId like '" + uname + "' and isInGroup.groupid=" + group.ToString + ";", dbCon)
            dbCon.Open()
            Dim t = cd.ExecuteScalar
            If t = 1 Then
                cd = New MySqlCommand("insert into isInGroup(groupid, userId) values (" + CType(group, Integer).ToString + ", '" + user + "');", dbCon)
                cd.ExecuteNonQuery()
            End If
            dbCon.Close()
            Return True
        End If
        Return False
    End Function

    Public Shared Function Register(uName As String, pwd As String) As Boolean
        Dim cmd As New MySqlCommand("insert into users(username, password) values('" + uName + "', '" + pwd + "');", GetInstance.dbCon)
        GetInstance.dbCon.Open()
        Dim res As Boolean = cmd.ExecuteNonQuery() > 0
        GetInstance.dbCon.Close()
        Return res
    End Function

    Public Function MessagesIn(group As Integer) As String()
        If logged Then
            Dim cd As New MySqlCommand("select count(*) from isInGroup where isInGroup.userId like '" + uname + "' and isInGroup.groupid=" + group.ToString + ";", dbCon)
            dbCon.Open()
            Dim fdata As New List(Of String)
            If cd.ExecuteScalar() > 0 Then
                cd = New MySqlCommand("select userid, message from messages where messages.groupid=" + group.ToString + " order by messageid;", dbCon)
                Dim data As MySqlDataReader = cd.ExecuteReader()
                While data.Read()
                    fdata.Add(data.Item(0) + ": " + data.Item(1))
                End While
            End If
            dbCon.Close()
            Return fdata.ToArray
        Else
            Return Nothing
        End If
    End Function

    Public Function GetGroups() As Tuple(Of String, Integer)()
        If logged Then
            Dim ad As New MySqlDataAdapter("select chatgroup.name, chatgroup.groupid from chatgroup, isInGroup where chatgroup.groupid=isInGroup.groupid and isInGroup.userId like '" + uname + "';", dbCon)
            dbCon.Open()
            Dim info As New DataSet
            ad.Fill(info, "datos")
            dbCon.Close()
            Dim str As New List(Of Tuple(Of String, Integer))
            For Each i As DataRow In info.Tables("datos").Rows
                str.Add(New Tuple(Of String, Integer)(i.Item(0), i.Item(1)))
            Next
            Return str.ToArray
        Else
            Return Nothing
        End If
    End Function
    Public Function Login(uname As String, pwd As String) As Boolean
        Dim ad As New MySqlDataAdapter("select username from users where username like '" + uname + "' and password like '" + pwd + "';", dbCon)
        dbCon.Open()
        Dim info As New DataSet
        ad.Fill(info, "datos")
        dbCon.Close()
        If info.Tables("datos").Rows.Count = 1 Then
            logged = True
            Me.uname = uname
            Me.pwd = pwd
        Else
            logged = False
        End If
        Return logged
    End Function
End Class
