Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "csc" And TextBox2.Text = "password" Then
            DataEntry.Show()
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If

        TextBox1.Clear()
        TextBox2.Clear()

        DataEntry.ComboBox1.Items.Clear()
        DataEntry.ComboBox1.Items.Add("Fall Semester 16 Weeks")
        DataEntry.ComboBox1.Items.Add("Fall Mini-Mester 1")
        DataEntry.ComboBox1.Items.Add("Fall Mini-Mester 2")
        DataEntry.ComboBox1.Items.Add("Spring Semester 16 Weeks")
        DataEntry.ComboBox1.Items.Add("Spring Mini-Mester 1")
        DataEntry.ComboBox1.Items.Add("Spring Mini-Mester 2")
        DataEntry.ComboBox1.Items.Add("Summer Semester 10 Weeks")
        DataEntry.ComboBox1.Items.Add("Summer 8 Week Session 1")
        DataEntry.ComboBox1.Items.Add("Summer 8 Week Session 2")
        DataEntry.ComboBox1.Items.Add("Summer 5 Week Session 1")
        DataEntry.ComboBox1.Items.Add("Summer 5 Week Session 2")
        DataEntry.ComboBox1.Items.Add("Summer 4 Week Boot Camp")

        Me.Hide()

    End Sub
End Class
