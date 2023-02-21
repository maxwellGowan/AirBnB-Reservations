Public Class frmAirBnB


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub lblNightlyCost_Click(sender As Object, e As EventArgs) Handles lblNightlyCost.Click

    End Sub

    Private Sub lblCalcCost_Click(sender As Object, e As EventArgs) Handles lblCalcCost.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNights_TextChanged(sender As Object, e As EventArgs) Handles txtNights.TextChanged

    End Sub

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click

        Const _cdecCostPerNight As Decimal = 79D
        Dim strEnterNumberOfNights As String
        Dim intEnterNumberOfNights As Integer
        Dim decTotalCostOfStay As Decimal

        strEnterNumberOfNights = txtNights.Text
        intEnterNumberOfNights = Convert.ToInt32(strEnterNumberOfNights)
        decTotalCostOfStay = intEnterNumberOfNights * _cdecCostPerNight
        lblCalcCost.Text = decTotalCostOfStay.ToString("C")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        lblCalcCost.Text = ""
        txtNights.Focus()
    End Sub
End Class
