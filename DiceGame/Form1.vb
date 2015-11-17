'Patricia Hanus
'151117
'Dice Game
'_____________________________________________________________________________
Public Class Form1

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Const MIN As Integer = 1
        Const MAX As Integer = 6
        Dim roll1 As Integer = RndInt(1, 6)
        Dim roll2 As Integer = RndInt(1, 6)
        Dim risk As Integer = Val(Me.txtRisk.Text)
        Static totalPoints As Integer = 1000

        RndInt(MIN, MAX)
        FirstDie(roll1)
        SecondDie(roll2)

        If (roll1 + roll2) Mod 2 = 0 Then
            totalPoints -= risk
        Else
            totalPoints += (risk * 2)
        End If

        Me.lblOutcome.Text = "Total points = " & totalPoints

    End Sub
    '********************************************************************************************
    'RndInt - return a random integer between max and min
    '
    'post: a number is returned
    '********************************************************************************************
    Function RndInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return Int((max - min + 1) * Rnd() + min)
    End Function
    '********************************************************************************************
    'FirstDie 
    'Uses Select Case statement to figure out the appropriate picture to return
    'pre: a random number was choosen
    'post: number is used to assign appropriate picutre to Dice1
    '********************************************************************************************
    Sub FirstDie(ByVal roll As Integer)
        Select Case roll
            Case Is = 1
                Me.picDice1.Image = My.Resources.ResourceManager.GetObject("die1")
            Case Is = 2
                Me.picDice1.Image = My.Resources.ResourceManager.GetObject("die2")
            Case Is = 3
                Me.picDice1.Image = My.Resources.ResourceManager.GetObject("die3")
            Case Is = 4
                Me.picDice1.Image = My.Resources.ResourceManager.GetObject("die4")
            Case Is = 5
                Me.picDice1.Image = My.Resources.ResourceManager.GetObject("die5")
            Case Is = 6
                Me.picDice1.Image = My.Resources.ResourceManager.GetObject("die6")
        End Select
    End Sub
    '********************************************************************************************
    'SecondDie 
    'Uses Select Case statement to figure out the appropriate picture to return
    'pre: a random number was choosen
    'post: number is used to assign appropriate picutre to Dice2
    '********************************************************************************************
    Sub SecondDie(ByVal roll As Integer)
        Select Case roll
            Case Is = 1
                Me.picDice2.Image = My.Resources.ResourceManager.GetObject("die1")
            Case Is = 2
                Me.picDice2.Image = My.Resources.ResourceManager.GetObject("die2")
            Case Is = 3
                Me.picDice2.Image = My.Resources.ResourceManager.GetObject("die3")
            Case Is = 4
                Me.picDice2.Image = My.Resources.ResourceManager.GetObject("die4")
            Case Is = 5
                Me.picDice2.Image = My.Resources.ResourceManager.GetObject("die5")
            Case Is = 6
                Me.picDice2.Image = My.Resources.ResourceManager.GetObject("die6")
        End Select
    End Sub
End Class