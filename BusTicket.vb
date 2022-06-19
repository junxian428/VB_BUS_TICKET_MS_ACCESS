Imports System.Data.OleDb

Public Class BusTicket


    Dim dbProvider As String
    Dim dbSource As String
    Dim con As New OleDb.OleDbConnection
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim Reader As OleDb.OleDbDataReader
    Dim Command As OleDb.OleDbCommand
    Public TripDate As String
    Public Pax As String

    Public fee As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm2 As New AboutUs
        MyForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TripDate = DateTimePicker1.Value.ToString("M/dd/yyyy")
        'MessageBox.Show(TripDate)


        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" ' MDB
        'dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'ACCDB
        dbSource = "Data Source=C:\Users\USer\Downloads\DatabaseForVB.mdb;  Persist Security Info= False;"
        con.ConnectionString = dbProvider & dbSource
        'Staff_ID_Box Staff_Name_Box Staff_Age_Box Staff_Salary_Box
        Dim cmdString As String = "Select * from Bus_Schedule WHERE Date = '" + TripDate + "';"
        Try

            Using myconnection As New OleDbConnection(con.ConnectionString)
                myconnection.Open()
                Dim TheCommand As OleDbCommand = New OleDbCommand(cmdString, myconnection)
                TheCommand.CommandType = CommandType.Text
                Dim TheDataReader As OleDbDataReader = TheCommand.ExecuteReader()
                While TheDataReader.Read()
                    'Console.WriteLine(TheDataReader("").ToString())
                    'Staff_ID_Box Staff_Name_Box Staff_Age_Box Staff_Salary_Box
                    'Staff_ID_Box.Text = TheDataReader("ID").ToString()
                    'Staff_Name_Box.Text = TheDataReader("Staff_Name").ToString()
                    'Staff_Age_Box.Text = TheDataReader("Staff_Age").ToString()
                    'Staff_Salary_Box.Text = TheDataReader("Staff_Salary").ToString()
                    ComboBox1.Items.Add(TheDataReader("From").ToString())
                    ComboBox2.Items.Add(TheDataReader("To").ToString())
                    ComboBox3.Items.Add(TheDataReader("Operator").ToString())
                    ComboBox4.Items.Add(TheDataReader("Time").ToString())



                End While
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



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Adult As String
        Dim Children As String
        Adult = TextBox1.Text
        Children = TextBox2.Text
        Pax = (CInt(TextBox1.Text) + CInt(TextBox2.Text)).ToString
        fee = (CInt(Adult) * 30 + CInt(Children) * 5).ToString
        MessageBox.Show(fee)
        Dim MyForm2 As New Seat
        MyForm2.Show()
        Me.Hide()

    End Sub
End Class