
Public Class OutPut
    Private Record As New DataClasses1DataContext
    Private Sub OutPut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim input1 As Integer
        input1 = DataEntry.ComboBox1.SelectedValue
        Dim input2 As Date
        input2 = DataEntry.DateTimePicker1.Value


        Dim rec = Record.StoredProcedure2(input1, input2)

        DataGridView1.DataSource = rec



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContactHours.Show()
        Me.Hide()
    End Sub

    
End Class