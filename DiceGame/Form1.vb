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

        RndInt(MIN, MAX)

        Select Case roll1
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

        Select Case roll2
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
    '********************************************************************************************
    'RndInt - return a random integer between max and min
    '
    'post: a number is returned
    '********************************************************************************************
    Function RndInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return Int((max - min + 1) * Rnd() + min)
    End Function
End Class