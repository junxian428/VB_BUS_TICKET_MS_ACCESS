Imports System.Data.OleDb

Public Class SignUp

    Dim dbProvider As String
    Dim dbSource As String
    Dim con As New OleDb.OleDbConnection
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim Reader As OleDb.OleDbDataReader
    Dim Command As OleDb.OleDbCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" ' MDB
        'dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'ACCDB
        dbSource = "Data Source=C:\Users\USer\Downloads\DatabaseForVB.mdb;  Persist Security Info= False;"
        con.ConnectionString = dbProvider & dbSource
        'Staff_ID_Box Staff_Name_Box Staff_Age_Box Staff_Salary_Box

        Try
            MessageBox.Show("Database is Opened")
            Using myconnection As New OleDbConnection(con.ConnectionString)
                myconnection.Open()
                'Dim sqlQry As String = "INSERT INTO [tbl_user] ([username], [password]) VALUES (@usernme, @passwrd)"
                con.Open()
                sql = "INSERT INTO User_Table (FullName, ICNumber, ContactNumber, Address, Email, Password) VALUES ('" + FullName.Text + "','" + ICNumber.Text + "','" + ContactNumber.Text + "','" + Address.Text + "','" + Email.Text + "','" + Password.Text + "');"
                da = New OleDb.OleDbDataAdapter(sql, con)
                Using cmd As New OleDbCommand(sql, myconnection)
                    cmd.ExecuteNonQuery()
                End Using
                myconnection.Close()
            End Using



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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm2 As New MainPage
        MyForm2.Show()
        Me.Hide()
    End Sub


End Class