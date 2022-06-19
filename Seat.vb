Public Class Seat


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm2 As New BusTicket
        MyForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim MyForm2 As New Pay
        MyForm2.Show()
        Me.Hide()
    End Sub
End Class