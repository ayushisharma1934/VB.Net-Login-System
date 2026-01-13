
Public Class billing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As Integer
        s = 0
        If CheckBox1.Checked Then
            s = s + 200
        End If
        If CheckBox2.Checked Then
            s = s + 20
        End If
        If CheckBox3.Checked Then
            s = s + 80
        End If
        If CheckBox4.Checked Then
            s = s + 20
        End If
        If CheckBox5.Checked Then
            s = s + 50
        End If

        If CheckBox6.Checked Then
            s = s + 25
        End If
        RichTextBox1.Text = s






    End Sub
End Class