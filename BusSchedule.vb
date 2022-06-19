Imports System.Data.OleDb

Public Class BusSchedule

    Dim dbProvider As String
    Dim dbSource As String
    Dim con As New OleDb.OleDbConnection
    Dim sql As String
    Dim da As OleDb.OleDbDataAdapter
    Dim Reader As OleDb.OleDbDataReader
    Dim Command As OleDb.OleDbCommand
    Public BusOperator As String

    Public BusTime As String

    Private Sub BusSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("ALISAN")
        ListBox1.Items.Add("ARWAN")
        ListBox1.Items.Add("BILLIONSTAR")
        ListBox1.Items.Add("CITYEXPRESS")
        ListBox1.Items.Add("FIVESTAR")
        ListBox1.Items.Add("KKKL")


        ListBox2.Items.Add("JB")
        ListBox2.Items.Add("KL")
        ListBox2.Items.Add("PH")
        ListBox2.Items.Add("SG")
        ListBox2.Items.Add("SR")

        ListBox3.Items.Add("JB")
        ListBox3.Items.Add("KL")
        ListBox3.Items.Add("PH")
        ListBox3.Items.Add("SG")
        ListBox3.Items.Add("SR")


        ListBox4.Items.Add("11:00AM")
        ListBox4.Items.Add("12:00AM")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Staff_ID_Box Staff_Name_Box Staff_Age_Box Staff_Salary_Box

        'MessageBox.Show(ListBox1.SelectedItem.ToString)
        'MessageBox.Show(ListBox4.SelectedItem.ToString)
        BusOperator = ListBox1.SelectedItem.ToString
        BusTime = ListBox4.SelectedItem.ToString
        'MessageBox.Show(BusTime)
        Dim MyForm5 As New Result
        MyForm5.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm5 As New AboutUs
        MyForm5.Show()
        Me.Hide()
    End Sub
End Class