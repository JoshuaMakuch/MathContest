'Joshua Makuch
'RCET 0265
'Spring 2023
'Math Contest
'https://github.com/JoshuaMakuch/MathContest.git

Option Strict On
Option Explicit On

Public Class MathContestForm

    'Exit Button
    Private Sub ExitButton_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text = "" Then
            NameTextBox.BackColor = Color.LightPink
        Else
            NameTextBox.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        If AgeTextBox.Text = "" Then
            AgeTextBox.BackColor = Color.LightPink
        Else
            Try
                If CDbl(AgeTextBox.Text) < 7 Or CDbl(AgeTextBox.Text) > 11 Then
                    AgeTextBox.BackColor = Color.LightPink
                Else
                    AgeTextBox.BackColor = Color.LightGreen
                End If
            Catch ex As Exception
                AgeTextBox.BackColor = Color.LightPink
            End Try
        End If
    End Sub

    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        If GradeTextBox.Text = "" Then
            GradeTextBox.BackColor = Color.LightPink
        Else
            Try
                If CDbl(GradeTextBox.Text) < 1 Or CDbl(GradeTextBox.Text) > 4 Then
                    GradeTextBox.BackColor = Color.LightPink
                Else
                    GradeTextBox.BackColor = Color.LightGreen
                End If
            Catch ex As Exception
                GradeTextBox.BackColor = Color.LightPink
            End Try
        End If
    End Sub

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameTextBox.BackColor = Color.LightPink
        AgeTextBox.BackColor = Color.LightPink
        GradeTextBox.BackColor = Color.LightPink
        SubmitButton.Enabled = False
    End Sub
End Class
