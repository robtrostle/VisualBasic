﻿Public Class Form1

    Sub TurnLightOn()
        'Display the "Light On" image.
        picLightOn.Visible = True
        'Hide the "light off image. 
        picLightOff.Visible = False

        'Change the label text 
        lblLightState.Text = "ON"
    End Sub

    Sub TurnLightOff()
        'Display the "light off" image
        picLightOff.Visible = True

        'Hide the "light on" image
        picLightOn.Visible = False

        'Change the label text. 
        lblLightState.Text = "OFF"
    End Sub

    Private Sub btnSwitchLight_Click(sender As Object, e As EventArgs) Handles btnSwitchLight.Click
        'Reverse the state of the light. 
        If picLightOn.Visible = True Then
            TurnLightOff()
        Else
            TurnLightOn()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
