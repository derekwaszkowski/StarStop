
Public Class OutPut
    Private Record As New DataClasses1DataContext
    Private Sub OutPut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim input1 As Integer
        Dim input2 As Date

        Dim rec = Record.StoredProcedure1(input1, input2)

        DataGridView1.DataSource = rec



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContactHours.Show()
        Me.Hide()
    End Sub

    
End Class