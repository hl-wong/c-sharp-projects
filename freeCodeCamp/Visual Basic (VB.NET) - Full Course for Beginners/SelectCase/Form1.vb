Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)

        Dim iWIndSpeed As Integer
        iWIndSpeed = 30

        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
                MsgBox("Water will freeze")
                MsgBox("and you can go skating")
            Case Is < 0
                MsgBox("Sub zero")
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select

    End Sub
End Class
