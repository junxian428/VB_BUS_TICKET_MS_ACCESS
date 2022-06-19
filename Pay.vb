Public Class Pay
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MyForm2 As New Seat
        MyForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm2 As New Card
        MyForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm2 As New Cash
        MyForm2.Show()
        Me.Hide()
    End Sub
End Class