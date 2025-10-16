Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim astFruits(4) As String

        astFruits(0) = "Banana"
        astFruits(1) = "Orange"
        astFruits(2) = "Pineapple"
        astFruits(3) = "Strawberry"
        astFruits(4) = "Mango"

        Dim i As Integer

        For i = 0 To 4
            MsgBox(astFruits(i))
        Next
    End Sub

    'Exercise 1: Output each item in a separate message box one after another'
    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click
        Dim aiCount(4) As Integer

        aiCount(0) = 5
        aiCount(1) = 7
        aiCount(2) = 33
        aiCount(3) = 22
        aiCount(4) = 8

        Dim i As Integer

        For i = 0 To aiCount.Length - 1
            MsgBox(aiCount(i))
        Next
    End Sub
    'Exercise 2: Output all of the items in the same message box on separate lines'
    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click
        Dim aiCount(4) As Integer

        aiCount(0) = 5
        aiCount(1) = 7
        aiCount(2) = 33
        aiCount(3) = 22
        aiCount(4) = 8

        MsgBox(aiCount(0) & vbNewLine & aiCount(1) & vbNewLine & aiCount(2) & vbNewLine & aiCount(3) & vbNewLine & aiCount(4))

        'Answer:
        'Dim i As Integer
        'Dim stOut As String
        'For i = 0 To 4
        '    stOut = stOut & aiCount(i) & vbNewLine
        'Next

    End Sub
    'Exercise 3: Add up all of the items then output the total in a message box'
    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click
        Dim aiCount(4) As Integer

        aiCount(0) = 5
        aiCount(1) = 7
        aiCount(2) = 33
        aiCount(3) = 22
        aiCount(4) = 8

        Dim i As Integer
        Dim total As Integer

        For i = 0 To aiCount.Length - 1
            total += aiCount(i)
        Next

        MsgBox("The total is " & total)

    End Sub
    'Exercise 4: Calculate the average of the items then output it in a message box'
    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click
        Dim aiCount(4) As Integer

        aiCount(0) = 5
        aiCount(1) = 7
        aiCount(2) = 33
        aiCount(3) = 22
        aiCount(4) = 8

        Dim i As Integer
        Dim total As Integer

        For i = 0 To aiCount.Length - 1
            total += aiCount(i)
        Next

        Dim average As Integer
        average = total / aiCount.Length

        MsgBox("The average is " & average)

    End Sub
    'Exercise 5: Add up the items greater than 20 then output the result in a message box'
    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click
        Dim aiCount(4) As Integer

        aiCount(0) = 5
        aiCount(1) = 7
        aiCount(2) = 33
        aiCount(3) = 22
        aiCount(4) = 8

        Dim i As Integer
        Dim total As Integer

        For i = 0 To aiCount.Length - 1
            If aiCount(i) > 20 Then
                total += aiCount(i)
            End If
        Next

        MsgBox("The total of the items bigger than 20 is " & total)

    End Sub
    'Exercise 6: Find the largest item then output it in a message box'
    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click
        Dim aiCount(4) As Integer

        aiCount(0) = 5
        aiCount(1) = 7
        aiCount(2) = 33
        aiCount(3) = 22
        aiCount(4) = 8

        Dim i As Integer
        Dim iLargest As Integer

        For i = 0 To aiCount.Length - 1
            If aiCount(i) > iLargest Then
                iLargest = aiCount(i)
            End If
        Next

        MsgBox("The largest item is " & iLargest)

    End Sub
    'Exercise 7: Find the smallest item then output it in a message box'
    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click
        Dim aiCount(4) As Integer

        aiCount(0) = 5
        aiCount(1) = 7
        aiCount(2) = 33
        aiCount(3) = 22
        aiCount(4) = 8

        Dim i As Integer
        Dim iSmallest As Integer

        iSmallest = aiCount.Min

        'Answer:
        'iSmallest = 10000
        'For i = 0 To 4
        '    If aiCount(i) < iSmallest Then
        '        iSmallest = aiCount(i)
        '    End If
        'Next

        MsgBox("The smallest item is " & iSmallest)

    End Sub
    'Exercise 8: Replace each item in the array with a new value that is twice as big then ouput the new values'
    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click
        Dim aiCount(4) As Integer

        aiCount(0) = 5
        aiCount(1) = 7
        aiCount(2) = 33
        aiCount(3) = 22
        aiCount(4) = 8

        Dim i As Integer

        For i = 0 To aiCount.Length - 1
            aiCount(i) = aiCount(i) * 2
        Next

        'MsgBox(aiCount(0) & vbNewLine & aiCount(1) & vbNewLine & aiCount(2) & vbNewLine & aiCount(3) & vbNewLine & aiCount(4))

        'Answer:
        'Dim stOut As String
        'For i = 0 To aiCount.Length - 1
        '    stOut = stOut & aiCount(i) & vbNewLine
        'Next
        'MsgBox(stOut)

    End Sub

End Class
