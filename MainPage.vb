Public Class MainPage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm2 As New Login
        MyForm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm2 As New SignUp
        MyForm2.Show()
        Me.Hide()
    End Sub
End Class