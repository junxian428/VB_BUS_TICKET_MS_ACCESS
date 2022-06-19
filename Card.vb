Public Class Card
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm2 As New AboutUs
        MyForm2.Show()
        Me.Hide()
    End Sub
End Class