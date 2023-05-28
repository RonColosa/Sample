Public Class Form2
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'admin
        If My.Settings.SerialKey = TextBox2.Text Then
            My.Settings.AppStat = "Full Version"
            My.Settings.Save()
            Me.Close()
        End If
        Dim Username As String
        Dim Password As String
        Username = TextBox1.Text
        Password = TextBox2.Text
        If (Username.Equals("admin") And Password.Equals("admin")) Then
            MessageBox.Show("Login Success!", "information", MessageBoxButtons.OK)
        Else
            MessageBox.Show("ERROR!", "information", MessageBoxButtons.OK)
        End If
    End Sub
End Class