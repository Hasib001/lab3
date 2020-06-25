Option Strict On

Public Class Form1

    Dim employeeUnitsShipped(2, 6) As Integer
    Dim index As Integer = 0
    Dim runningTotal As Integer = 0
    Dim averageE1 As Double
    Dim averageE2 As Double
    Dim averageE3 As Double
    Dim totalAverage As Double
    Dim outterloop As Integer = 0
    Dim innerloop As Integer = 0
    Dim validation As Boolean = True


    ''' <summary>
    ''' executes when enter button presses
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        ReDim employeeUnitsShipped(2, 6)

        validation = Int32.TryParse(inputTextBox.Text, employeeUnitsShipped(outterloop, innerloop))

        '' If index < 6 Then
        If validation Then

            If employeeUnitsShipped(outterloop, innerloop) <= 5000 And employeeUnitsShipped(outterloop, innerloop) >= 0 Then


                runningTotal += employeeUnitsShipped(outterloop, innerloop)


                If outterloop <= 0 And innerloop <= 6 Then

                    unitsShowTextBox.Text += employeeUnitsShipped(outterloop, innerloop).ToString + Environment.NewLine
                    innerloop += 1
                    index += 1
                    days.Text = (innerloop + 1).ToString
                    inputTextBox.Clear()
                    If index >= 7 Then
                        averageE1 = runningTotal / 7

                        averageE1Textbox.Text = "Average is: " + Math.Round(averageE1, 2).ToString
                        totalAverage += averageE1
                        Label3.Font = New Font(Label3.Font, FontStyle.Regular)
                        runningTotal = 0
                        outterloop += 1
                        innerloop = 0
                        index = 0 ''reset index
                        days.Text = (innerloop + 1).ToString
                        Label4.Font = New Font(Label4.Font, FontStyle.Bold)
                    End If

                ElseIf outterloop <= 1 And innerloop <= 6 Then

                    unitsShowTextBox2.Text += employeeUnitsShipped(outterloop, innerloop).ToString + Environment.NewLine
                    innerloop += 1
                    index += 1
                    days.Text = (innerloop + 1).ToString
                    inputTextBox.Clear()
                    If index >= 7 Then
                        averageE2 = runningTotal / 7
                        averageE2Textbox.Text = "Average is: " + Math.Round(averageE2, 2).ToString
                        totalAverage += averageE2
                        runningTotal = 0
                        outterloop += 1
                        innerloop = 0
                        index = 0
                        days.Text = (innerloop + 1).ToString
                        Label4.Font = New Font(Label4.Font, FontStyle.Regular)
                        Label5.Font = New Font(Label5.Font, FontStyle.Bold)
                    End If

                ElseIf outterloop <= 2 And innerloop <= 6 Then
                    unitsShowTextBox3.Text += employeeUnitsShipped(outterloop, innerloop).ToString + Environment.NewLine
                    innerloop += 1
                    index += 1
                    days.Text = (innerloop + 1).ToString
                    inputTextBox.Clear()
                    If index >= 7 Then
                        averageE3 = runningTotal / 7
                        averageE3Textbox.Text = "Average is: " + Math.Round(averageE3, 2).ToString
                        runningTotal = 0
                        Label1.Text = "Done"
                        days.Visible = False
                        totalAverage = (averageE1 + averageE2 + averageE3) / 3
                        totalAverageTextBox.Text = "Average per day: " + Math.Round(totalAverage, 2).ToString

                        enterButton.Enabled = False
                        inputTextBox.ReadOnly = True
                        innerloop = 0




                    End If








                End If
            Else
                errorToolTip.Show("Please enter the number Within 0 and 5000!", inputTextBox)
                inputTextBox.Clear()

            End If
        Else
            errorToolTip.Show("Please Enter a valid number!", inputTextBox)
            inputTextBox.Clear()
        End If



        '' End If


    End Sub
    ''' <summary>
    ''' executes when user press exit button 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        inputTextBox.ReadOnly = False
        Label1.Text = "Day"
        days.Visible = True
        enterButton.Enabled = True

        unitsShowTextBox.Clear()
        unitsShowTextBox2.Clear()
        unitsShowTextBox3.Clear()
        averageE1Textbox.Clear()
        outterloop = 0
        innerloop = 0
        averageE1 = 0
        index = 0
        days.Text = (innerloop + 1).ToString
        averageE2Textbox.Clear()
        averageE2 = 0
        averageE3Textbox.Clear()
        averageE3 = 0
        totalAverageTextBox.Clear()
        totalAverage = 0
        runningTotal = 0
        Label4.Font = New Font(Label4.Font, FontStyle.Regular)
        Label5.Font = New Font(Label5.Font, FontStyle.Regular)
        Label3.Font = New Font(Label3.Font, FontStyle.Bold)
        inputTextBox.Clear()

        ''



    End Sub
End Class
