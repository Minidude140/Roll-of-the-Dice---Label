'Zachary Christensen
'RCET 2265
'Fall 2023
'Roll of the Dice - Label
'https://github.com/Minidude140/Roll-of-the-Dice---Label.git

'TODO:
'[~]Import Roll of the dice methods (small enough will copy - paste)
'[~]Convert Methods without console commands
'[~]Convert Methods with console commands to update string (create display string) Next time use accumulate message function
'[~]Change DrawDiceRolls sub name to something more accurate(UpdateDisplayString) 
'[~]Convert Methods into the event handlers from console statement tree (ROll actions, clear actions, update display)

Public Class RollOfTheDiceLabelForm
    Dim diceOne As Integer
    Dim diceTwo As Integer
    Dim diceTotal As Integer
    Dim diceRollTally() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim numberOfRolls As Integer = 0
    Dim display As String = ""
    Dim newDisplay As String = ""

    'Custom Methods
    ''' <summary>
    ''' Returns a Random Number 1-6
    ''' </summary>
    ''' <returns></returns>
    Function DiceRoll() As Integer
        Dim randomNumber As Integer
        Randomize()
        randomNumber = CInt((Rnd() * (6 - 1)) + 1)
        Return randomNumber
    End Function

    ''' <summary>
    ''' adds two numbers And returns the total
    ''' </summary>
    ''' <param name="numberOne"></param>
    ''' <param name="numberTwo"></param>
    ''' <returns></returns>
    Function AddTwoIntegers(numberOne As Integer, numberTwo As Integer) As Integer
        Dim summation As Integer
        summation = numberOne + numberTwo
        Return summation
    End Function

    ''' <summary>
    '''Evaluates diceTotal and increments corresponding array element
    ''' </summary>
    ''' <param name="diceTotal"></param>
    Sub EvaluateTotal(diceTotal As Integer)
        Select Case diceTotal
            Case = 2
                diceRollTally(0) += 1
            Case = 3
                diceRollTally(1) += 1
            Case = 4
                diceRollTally(2) += 1
            Case = 5
                diceRollTally(3) += 1
            Case = 6
                diceRollTally(4) += 1
            Case = 7
                diceRollTally(5) += 1
            Case = 8
                diceRollTally(6) += 1
            Case = 9
                diceRollTally(7) += 1
            Case = 10
                diceRollTally(8) += 1
            Case = 11
                diceRollTally(9) += 1
            Case = 12
                diceRollTally(10) += 1
        End Select
    End Sub

    ''' <summary>
    ''' Updates display string with given array data
    ''' </summary>
    ''' <param name="diceRollTally"></param>
    Sub UpdateDisplayString(diceRollTally() As Integer)
        'create header with possible rolls
        Dim header = New String() {"2  |", "3  |", "4  |", "5  |", "6  |", "7  |", "8  |", "9  |", "10  |", "11  |", "12  |"}
        'Draw out top border and header
        newDisplay = StrDup(88, "-") & vbCrLf & "|"
        display = display & newDisplay
        For i = LBound(header) To UBound(header)
            newDisplay = header(i).PadLeft(7)
            display = display & newDisplay
        Next
        'Draw out diceRollTally() with borders
        newDisplay = vbCrLf & StrDup(88, "-") & vbCrLf & "|"
        display = display & newDisplay
        For i = LBound(diceRollTally) To UBound(diceRollTally)
            Dim currentTotal As String
            currentTotal = CStr(diceRollTally(i) & "  |")
            newDisplay = currentTotal.PadLeft(7)
            display = display & newDisplay
        Next
        newDisplay = vbCrLf & StrDup(88, "-") & vbCrLf
        display = display & newDisplay
        'Reports the total number of rolls after array is drawn
        If numberOfRolls = 0 Then
            newDisplay = vbCrLf & "Total Rolls: 0" & vbCrLf
            display = display & newDisplay
        Else
            newDisplay = vbCrLf & $"Total Rolls: {numberOfRolls},000" & vbCrLf
            display = display & newDisplay
        End If
    End Sub

    ''' <summary>
    ''' Roll dice 1,000 times and update display string
    ''' </summary>
    Sub RollDice()
        For i = 1 To 1000
            'Rolls two dice and adds them together
            diceOne = DiceRoll()
            diceTwo = DiceRoll()
            diceTotal = AddTwoIntegers(diceOne, diceTwo)
            'evaluates diceTotal and increments corresponding array element
            EvaluateTotal(diceTotal)
        Next
        'updates display string with new Array elements and header counts total rolls
        numberOfRolls += 1
        display = ""
        newDisplay = ""
        UpdateDisplayString(diceRollTally)

    End Sub

    ''' <summary>
    ''' Clears any previous total counts and number of rolls
    ''' </summary>
    Sub ClearRolls()
        display = ""
        newDisplay = ""
        ReDim diceRollTally(10)
        numberOfRolls = 0
    End Sub

    ''' <summary>
    ''' makes the text in the listbox the Display string
    ''' </summary>
    Sub UpdateLabel()
        'DisplayLabel.Text = ""
        DisplayLabel.Text = display
    End Sub

    'Event Handlers
    Private Sub RollOfTheDiceForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateDisplayString(diceRollTally)
        UpdateLabel()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearRolls()
        UpdateDisplayString(diceRollTally)
        UpdateLabel()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollDice()
        UpdateLabel()
    End Sub

End Class
