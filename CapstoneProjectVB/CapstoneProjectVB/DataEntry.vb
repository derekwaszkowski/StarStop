Imports System.Data.SqlClient

Public Class DataEntry

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim input1 As Integer
        Dim send As Integer

        If ComboBox1.SelectedIndex = 0 Then
            input1 = 16
        ElseIf ComboBox1.SelectedIndex = 1 Then
            input1 = 6
        ElseIf ComboBox1.SelectedIndex = 2 Then
            input1 = 6
        ElseIf ComboBox1.SelectedIndex = 3 Then
            input1 = 16
        ElseIf ComboBox1.SelectedIndex = 4 Then
            input1 = 6
        ElseIf ComboBox1.SelectedIndex = 5 Then
            input1 = 6
        ElseIf ComboBox1.SelectedIndex = 6 Then
            input1 = 10
        ElseIf ComboBox1.SelectedIndex = 7 Then
            input1 = 8
        ElseIf ComboBox1.SelectedIndex = 9 Then
            input1 = 8
        ElseIf ComboBox1.SelectedIndex = 10 Then
            input1 = 5
        ElseIf ComboBox1.SelectedIndex = 11 Then
            input1 = 5
        ElseIf ComboBox1.SelectedIndex = 12 Then
            input1 = 4
        End If


        Return

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dateSelected As Date
        dateSelected = DateTimePicker1.Value
        Return

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        OutPut.Show()
    End Sub
End Class