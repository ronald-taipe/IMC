Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim peso, altura, IMC As Double
        peso = Val(TextBox1.Text)
        altura = Val(TextBox2.Text)

        If peso > 0 And altura > 0 Then
            IMC = Math.Round((peso / (altura * altura)), 1)
            TextBox3.Text = (IMC)
            If IMC < 18.5 Then
                TextBox4.Text = ("RIESGO")
            ElseIf 18.5 < IMC And IMC < 24.9 Then
                TextBox4.Text = ("Promedio")
            ElseIf 25 < IMC And IMC < 29.9 Then
                TextBox4.Text = ("Aumentado")
            ElseIf 30 < IMC And IMC < 34.9 Then
                TextBox4.Text = ("Moderado")
            ElseIf 35 < IMC And IMC < 39.9 Then
                TextBox4.Text = ("Severo")
            ElseIf 40 <= IMC Then
                TextBox4.Text = ("Muy severo")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
