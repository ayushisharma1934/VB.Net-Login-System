Imports Microsoft.Data.SqlClient


Public Class Form1

    ' Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"c
    End Sub

    ' Login Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check empty fields
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Enter username and password")
            Return
        End If

        ' Corrected: SqlConnection (was SqlConection)
        Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=user;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        ' SQL Command
        Dim cmd As New SqlCommand("SELECT * FROM ASK WHERE username=@v1 AND pass=@v2", con)
        cmd.Parameters.AddWithValue("@v1", TextBox1.Text)
            cmd.Parameters.AddWithValue("@v2", TextBox2.Text)

            ' Open connection
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            MessageBox.Show("Login Successful!")
            con.Close()
            billing.Show() ' Opens the billing form
            Me.Hide() ' Optional: hide login form
        Else
            MessageBox.Show("Login Failed")
        End If
    End Sub

    ' Signup Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        signupform.Show()
    End Sub

End Class
