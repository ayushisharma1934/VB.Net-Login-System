Imports Microsoft.Data.SqlClient
Public Class signupform

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Corrected: SqlConnection (was SqlConection)
        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=user;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        ' SQL Command
        Dim cmd As New SqlCommand("INSERT INTO ASK (username,pass)values(@v1,@v2)", con)
        cmd.Parameters.AddWithValue("@v1", TextBox1.Text)
        cmd.Parameters.AddWithValue("@v2", TextBox2.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("registered")
        ' Open connection

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("All fields are required")

        ElseIf TextBox2.Text <> TextBox3.Text Then
            MessageBox.Show("Passwords do not match")

        Else
            Dim a, b As String

            a = TextBox1.Text
            b = TextBox2.Text
            MessageBox.Show("Signup Successful")
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class