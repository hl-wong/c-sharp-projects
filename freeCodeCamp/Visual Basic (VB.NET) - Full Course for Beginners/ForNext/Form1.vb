Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer
        Dim stOut As String

        For iCount = 50 To 0 Step -5
            stOut = stOut & iCount & vbNewLine
        Next

        MsgBox(stOut)
    End Sub

    'Practice For Next Loops & If Block
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim iCount As Integer
        Dim iMax As String
        Dim strOption As String

        iMax = InputBox("What number do you want to count up to?")
        strOption = InputBox("Do you want odd numbers or even numbers")

        If strOption = "even" Then
            For iCount = 0 To iMax
                If iCount Mod 2 = 0 Then
                    MsgBox(iCount)
                End If
            Next
        ElseIf strOption = "odd" Then
            For iCount = 0 To iMax
                If iCount Mod 2 = 1 Then
                    MsgBox(iCount)
                End If
            Next
        End If
    End Sub
End Class
