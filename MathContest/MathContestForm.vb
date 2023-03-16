'Joshua Makuch
'RCET 0265
'Spring 2023
'Math Contest
'https://github.com/JoshuaMakuch/MathContest.git

Option Strict On
Option Explicit On

Public Class MathContestForm

    Dim correctName As Boolean
    Dim correctAge As Boolean
    Dim correctGrade As Boolean

    'Exit Button
    Private Sub ExitButton_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Tells the name if the correct input is placed
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        correctName = False

        'Changes the back color if correct
        If NameTextBox.Text = "" Then
            NameTextBox.BackColor = Color.LightPink
        Else
            NameTextBox.BackColor = Color.LightGreen
            correctName = True
        End If

    End Sub

    'Tells the age if the correct input is placed
    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        correctAge = False

        'Changes the back color if correct
        If AgeTextBox.Text = "" Then
            AgeTextBox.BackColor = Color.LightPink
        Else
            Try
                If CDbl(AgeTextBox.Text) < 7 Or CDbl(AgeTextBox.Text) > 11 Then
                    AgeTextBox.BackColor = Color.LightPink
                Else
                    AgeTextBox.BackColor = Color.LightGreen
                    correctAge = True
                End If
            Catch ex As Exception
                AgeTextBox.BackColor = Color.LightPink
            End Try
        End If
    End Sub

    'Tells the grade if the correct input is placed
    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        correctGrade = False

        'Changes the back color if correct
        If GradeTextBox.Text = "" Then
            GradeTextBox.BackColor = Color.LightPink
        Else
            Try
                If CDbl(GradeTextBox.Text) < 1 Or CDbl(GradeTextBox.Text) > 4 Then
                    GradeTextBox.BackColor = Color.LightPink
                Else
                    GradeTextBox.BackColor = Color.LightGreen
                    correctGrade = True
                End If
            Catch ex As Exception
                GradeTextBox.BackColor = Color.LightPink
            End Try
        End If

    End Sub

    'Runs some code on load
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameTextBox.BackColor = Color.LightPink
        AgeTextBox.BackColor = Color.LightPink
        GradeTextBox.BackColor = Color.LightPink
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click


        If Not correctName Or Not correctAge Or Not correctGrade Then
            'Tells the user what is wrong and sets the focus to the wrong box
            MessageBox.Show($"The Name is {correctName}{vbCrLf}The Age is {correctAge}{vbCrLf}The Grade is {correctGrade}{vbCrLf}Please fix before continuing.")
            If Not correctName Then
                Me.NameTextBox.Focus()
            ElseIf Not correctAge Then
                Me.AgeTextBox.Focus()
            ElseIf Not correctGrade Then
                Me.GradeTextBox.Focus()
            End If
        Else
            'Continues on with the submission if the user input the correct info

        End If

    End Sub

End Class
