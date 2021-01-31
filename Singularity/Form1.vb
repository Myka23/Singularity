Public Class frmMain

    ' Create a Random object called randomizer 
    ' to generate random numbers.
    Private randomizer As New Random

    ' These integer variables store the numbers 
    ' for the addition problem. 
    Private addend1 As Integer
    Private addend2 As Integer
    Private subend1 As Integer
    Private subend2 As Integer
    Private mulend1 As Integer
    Private mulend2 As Integer
    Private divend1 As Integer
    Private divend2 As Integer
    Private addValue As Integer
    Private subValue As Integer
    Private mulValue As Integer
    Private divValue As Integer

    Private addAi As Integer
    Private subAI As Integer
    Private mulAI As Integer
    Private divAi As Integer

    Private menschScore As Integer
    Private aiScore As Integer

    Dim worksheetcell As Integer


    ' This integer variable keeps track of the 
    ' remaining time.
    Private timeLeft As Integer = 0



    ''' <summary>
    ''' Start the quiz by filling in all of the problems
    ''' and starting the timer.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub StartTheQuiz()
        ' Fill in the addition problem.
        ' Generate two random numbers to add.
        ' Store the values in the variables 'addend1' and 'addend2'.
        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)
        subend1 = randomizer.Next(25, 51)
        subend2 = randomizer.Next(24)
        mulend1 = randomizer.Next(2, 12)
        mulend2 = randomizer.Next(2, 9)
        divend1 = 25
        divend2 = 5
        ' Convert the two randomly generated numbers
        ' into strings so that they can be displayed
        ' in the label controls.
        plusLeftlbl.Text = addend1.ToString()
        plusRightlbl.Text = addend2.ToString()
        minLeftlbl.Text = subend1.ToString()
        minRightlbl.Text = subend2.ToString()
        mulLeftlbl.Text = mulend1.ToString()
        mulRightlbl.Text = mulend2.ToString()
        divLeftlbl.Text = divend1.ToString()
        divRightlbl.Text = divend2.ToString()

        aisum1.Text = plusLeftlbl.Text
        aisum2.Text = plusRightlbl.Text
        aimin1.Text = minLeftlbl.Text
        aimin2.Text = minRightlbl.Text
        aimul1.Text = mulLeftlbl.Text
        aimul2.Text = mulRightlbl.Text
        aidiv1.Text = divLeftlbl.Text
        aidiv2.Text = divRightlbl.Text





    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        endBtn.Enabled = False

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click

        StartTheQuiz()
        startBtn.Enabled = False
        Timer1.Enabled = True
        menschScore = 0
        aiScore = 0

        If timeLeft = 1 Then
            aisum.Text = CInt(aisum1.Text) + CInt(aisum2.Text)
            aisum.BackColor = Color.Green
        End If

        If timeLeft = 2 Then
            aimin.Text = CInt(aimin1.Text) - CInt(aimin2.Text)
            aimin.BackColor = Color.Green
        End If

        If timeLeft = 3 Then
            aimul.Text = CInt(aimul1.Text) * CInt(aimul2.Text)
            aimul.BackColor = Color.Green
        End If

        If timeLeft = 4 Then
            aidiv.Text = CInt(aidiv1.Text) / CInt(aidiv2.Text)
            aidiv.BackColor = Color.Green
        End If

        endBtn.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        timeLeft += 1
        timeLbl.Text = timeLeft & " seconds"

        If timeLeft = 1 Then
            aisum.Text = CInt(aisum1.Text) + CInt(aisum2.Text)
            aisum.BackColor = Color.Green
            aiScore += 1
        End If

        If timeLeft = 2 Then
            aimin.Text = CInt(aimin1.Text) - CInt(aimin2.Text)
            aimin.BackColor = Color.Green
            aiScore += 1
        End If

        If timeLeft = 3 Then
            aimul.Text = CInt(aimul1.Text) * CInt(aimul2.Text)
            aimul.BackColor = Color.Green
            aiScore += 1
        End If

        If timeLeft = 4 Then
            aidiv.Text = CInt(aidiv1.Text) / CInt(aidiv2.Text)
            aidiv.BackColor = Color.Green
            aiScore += 1
            aitime.Text = timeLbl.Text
        End If

    End Sub

    Private Sub endBtn_Click(sender As Object, e As EventArgs) Handles endBtn.Click
        sum.Text = Val(sum.Text)
        min.Text = Val(min.Text)
        mul.Text = Val(mul.Text)
        div.Text = Val(div.Text)


        Timer1.Enabled = False
        addValue = addend1 + addend2
        subValue = subend1 - subend2
        mulValue = mulend1 * mulend2
        divValue = divend1 / divend2

        If addValue = sum.Text Then
            sum.BackColor = Color.Green
            menschScore += 1
        Else
            sum.BackColor = Color.Red

        End If

        If subValue = min.Text Then
            min.BackColor = Color.Green
            menschScore += 1
        Else
            min.BackColor = Color.Red

        End If

        If mulValue = mul.Text Then
            mul.BackColor = Color.Green
            menschScore += 1
        Else
            mul.BackColor = Color.Red

        End If

        If divValue = div.Text Then
            div.BackColor = Color.Green
            menschScore += 1
        Else
            div.BackColor = Color.Red

        End If

        menschtime.Text = timeLbl.Text



        Dim xlsWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlsWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim xls As New Microsoft.Office.Interop.Excel.Application

        Dim resourcesFolder = IO.Path.GetFullPath("C:\Users\User\Desktop\")
        Dim fileName = "Singularity.xlsx"

        xlsWorkBook = xls.Workbooks.Open(resourcesFolder & fileName)
        xlsWorkSheet = xlsWorkBook.Sheets("Sheet1")



        xlsWorkSheet.Cells(1, 1) = timeLbl.Text
        xlsWorkSheet.Cells(1, 2) = menschScore
        xlsWorkSheet.Cells(1, 3) = aiScore

        xlsWorkBook.Close()
        xls.Quit()



    End Sub
End Class
