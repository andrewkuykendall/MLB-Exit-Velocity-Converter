Public Class frmMain
    Private Sub radMPH_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dlgExit As DialogResult
        MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'VARIABLES
        Dim dblExit_Velocity As Double

        Double.TryParse(txtVelocity.Text, dblExit_Velocity)
        ' Determine the variables given by user w/ units and bat type
        Select Case True
            Case radWood.Checked
                dblExit_Velocity = dblExit_Velocity + 7.4937
            Case radMetal.Checked
                dblExit_Velocity = dblExit_Velocity - 7.4937
        End Select

        lblCalculated.Text = dblExit_Velocity.ToString("n1") & " " & "MPH"



    End Sub

    Private Sub txtVelocity_TextChanged(sender As Object, e As EventArgs) Handles txtVelocity.TextChanged
        lblCalculated.Text = String.Empty

    End Sub

    Private Sub txtVelocity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVelocity.KeyPress
        If (e.KeyChar < "0" AndAlso e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVelocity_Enter(sender As Object, e As EventArgs) Handles txtVelocity.Enter
        txtVelocity.SelectAll()
    End Sub
End Class