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
    Dim random As New Random()
    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim totalCorrect As Integer
    Dim totalAnswered As Integer

    'Exit Button
    Private Sub ExitButton_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Tells the name if the correct input is placed
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        correctName = False
        MathProblemTypeGroupbox.Enabled = False

        'Changes the back color if correct
        If NameTextBox.Text = "" Then
            NameTextBox.BackColor = Color.LightPink
        Else
            NameTextBox.BackColor = Color.LightGreen
            correctName = True
        End If

        'Sets the math problem type groupbox to enabled and generates a new number (in case clear was hit) only if all fields are filled
        If correctName And correctAge And correctGrade Then
            MathProblemTypeGroupbox.Enabled = True
            GenerateNumber()
        End If

    End Sub

    'Tells the age if the correct input is placed
    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        correctAge = False
        MathProblemTypeGroupbox.Enabled = False

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

        'Sets the math problem type groupbox to enabled and generates a new number (in case clear was hit) only if all fields are filled
        If correctName And correctAge And correctGrade Then
            MathProblemTypeGroupbox.Enabled = True
            GenerateNumber()
        End If

    End Sub

    'Tells the grade if the correct input is placed
    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        correctGrade = False
        MathProblemTypeGroupbox.Enabled = False

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

        'Sets the math problem type groupbox to enabled and generates a new number (in case clear was hit) only if all fields are filled
        If correctName And correctAge And correctGrade Then
            MathProblemTypeGroupbox.Enabled = True
            GenerateNumber()
        End If

    End Sub

    'Runs some code on load (mostly setting everything that needs to be off, to off
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameTextBox.BackColor = Color.LightPink
        AgeTextBox.BackColor = Color.LightPink
        GradeTextBox.BackColor = Color.LightPink
        MathProblemTypeGroupbox.Enabled = False
        AddRadioButton.Checked() = True
        FirstNumberTextBox.Enabled = False
        SecondNumberTextBox.Enabled = False
        GenerateNumber()
    End Sub

    'Runs a large set of code when the submit button is pressed
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        If Not correctName Or Not correctAge Or Not correctGrade Then
            'Tells the user what is wrong and sets the focus to the wrong box
            MathProblemTypeGroupbox.Enabled = False
            MessageBox.Show($"The Name is {correctName}{vbCrLf}The Age is {correctAge}{vbCrLf}The Grade is {correctGrade}{vbCrLf}Please fix before continuing.")
            If Not correctName Then
                Me.NameTextBox.Focus()
            ElseIf Not correctAge Then
                Me.AgeTextBox.Focus()
            ElseIf Not correctGrade Then
                Me.GradeTextBox.Focus()
            End If
        Else
            'Continues on with the submission if the user input the correct info but also validates the student's answer
            Try
                'Checks the radio buttons before procceding
                If AddRadioButton.Checked Then 'Addition
                    If CInt(StudentAnswerTextBox.Text) = firstNumber + secondNumber Then
                        MessageBox.Show("That is correct, congratulations!")
                        totalCorrect += 1
                        totalAnswered += 1
                    Else
                        MessageBox.Show($"Sorry, the correct answer is {firstNumber + secondNumber}")
                        totalAnswered += 1
                    End If

                ElseIf SubtractRadioButton.Checked Then 'Subtraction
                    If CInt(StudentAnswerTextBox.Text) = firstNumber - secondNumber Then
                        MessageBox.Show("That is correct, congratulations!")
                        totalCorrect += 1
                        totalAnswered += 1
                    Else
                        MessageBox.Show($"Sorry, the correct answer is {firstNumber - secondNumber}")
                        totalAnswered += 1
                    End If

                ElseIf MultiplyRadioButton.Checked Then 'Multiplication
                    If CInt(StudentAnswerTextBox.Text) = firstNumber * secondNumber Then
                        MessageBox.Show("That is correct, congratulations!")
                        totalCorrect += 1
                        totalAnswered += 1
                    Else
                        MessageBox.Show($"Sorry, the correct answer is {firstNumber * secondNumber}")
                        totalAnswered += 1
                    End If

                ElseIf DivideRadioButton.Checked Then 'Division
                    If CInt(StudentAnswerTextBox.Text) = CInt(firstNumber / secondNumber) Then
                        MessageBox.Show("That is correct, congratulations!")
                        totalCorrect += 1
                        totalAnswered += 1
                    Else
                        MessageBox.Show($"Sorry, the correct answer is {CInt(firstNumber / secondNumber)}")
                        totalAnswered += 1
                    End If

                End If
            Catch ex As Exception
                'if there is an error with the user input it tells the user to change it
                MessageBox.Show("Please input a valid number.")
            End Try

            'Generates a new set of numbers for the next run and displays them
            GenerateNumber()
        End If

    End Sub

    'Clears all variables and textboxes when this button is clicked
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        correctName = False
        correctAge = False
        correctGrade = False
        AddRadioButton.Checked() = True
        totalCorrect = 0
        totalAnswered = 0
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

        'Displays the correct to total count
        MessageBox.Show($"{NameTextBox.Text} has gotten {totalCorrect} out of {totalAnswered} questions correct.")

    End Sub

    'Due to a number needing to be generated so often and at multiple different points, this was created
    Sub GenerateNumber()
        firstNumber = random.Next(0, 10) 'Allows divisions of 0,
        secondNumber = random.Next(1, 10) 'but not divided by 0
        FirstNumberTextBox.Text = CStr(firstNumber)
        SecondNumberTextBox.Text = CStr(secondNumber)
    End Sub

End Class
