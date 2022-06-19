Imports System.Data.OleDb

Public Class Login
    Dim dbProvider As String
    Dim dbSource As String
    Dim con As New OleDb.OleDbConnection
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim Reader As OleDb.OleDbDataReader
    Dim Command As OleDb.OleDbCommand


    Dim ACCESS As Boolean



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" ' MDB
        'dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'ACCDB
        dbSource = "Data Source=C:\Users\USer\Downloads\DatabaseForVB.mdb;  Persist Security Info= False;"
        con.ConnectionString = dbProvider & dbSource
        'Staff_ID_Box Staff_Name_Box Staff_Age_Box Staff_Salary_Box
        Dim cmdString As String = "Select * from User_Table WHERE FullName = '" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "';"
        Try

            Using myconnection As New OleDbConnection(con.ConnectionString)
                myconnection.Open()
                Dim TheCommand As OleDbCommand = New OleDbCommand(cmdString, myconnection)
                TheCommand.CommandType = CommandType.Text
                Dim TheDataReader As OleDbDataReader = TheCommand.ExecuteReader()
                While TheDataReader.Read()
                    Console.WriteLine(TheDataReader("FullName").ToString())
                    'MessageBox.Show("Hello")
                    ACCESS = True
                End While
                myconnection.Close()
            End Using

            If ACCESS Then
                Dim MyForm2 As New AboutUs
                MyForm2.Show()
                Me.Hide()

            End If


        Catch ex As Exception
            ' Show the exception's message.
            MessageBox.Show(ex.Message)
            ' Show the stack trace, which is a list of methods
            ' that are currently executing.
            MessageBox.Show("Stack Trace: " & vbCrLf & ex.StackTrace)
        Finally
            ' This line executes whether or not the exception occurs.
            MessageBox.Show("Operation is Done")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm2 As New MainPage
        MyForm2.Show()
        Me.Hide()
    End Sub
End Class