Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblNumber1 As Double
        Dim dblNumber2 As Double

        Dim iResult As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        iResult = dblNumber1 + dblNumber2
        MsgBox(iResult)

        iResult = dblNumber1 - dblNumber2
        MsgBox(iResult)

        iResult = dblNumber1 * dblNumber2
        MsgBox(iResult)

        iResult = dblNumber1 / dblNumber2
        MsgBox(iResult)

        iResult = dblNumber1 ^ dblNumber2
        MsgBox(iResult)

        iResult = dblNumber1 \ dblNumber2
        MsgBox(iResult)

        iResult = dblNumber1 Mod dblNumber2
        MsgBox(iResult)


    End Sub
End Class
