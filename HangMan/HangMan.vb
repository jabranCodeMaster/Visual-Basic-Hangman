Imports System.IO
Public Class HangMan
    'Jabran Khan
    '6/4/13
    Public strWord As String
    Public blnPic1, blnPic2, blnPic3, blnPic4, blnPic5, blnPic6, blnPic7, blnPic8 As Boolean
    Public blnLet1, blnLet2, blnLet3, blnLet4, blnLet5, blnLet6, blnLet7, blnLet8 As Boolean

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        'Makes sure the user doesn't try to get a new word :)
        'btnStart.Enabled = False

        'Makes the parts of the hangman disappear to start the next round
        PictureBox1.Visible = False
        blnPic1 = False
        blnPic2 = False
        'Randomly choosing a word when the user clicks the start button
        Randomize()
        Dim intWord As Integer
        intWord = CInt(Int((5 * Rnd()) + 1))
        Select Case intWord
            Case 1
                strWord = "Anime"
            Case 2
                strWord = "Chess"
            Case 3
                strWord = "Manga"
            Case 4
                strWord = "Tennis"
            Case 5
                strWord = "Football"
            Case 6
                strWord = ""
            Case 7
                strWord = ""
            Case 8
                strWord = ""
            Case 9
                strWord = ""
            Case 10
                strWord = ""
            Case 11
                strWord = ""
            Case 12
                strWord = ""
            Case 13
                strWord = ""
            Case 14
                strWord = ""
            Case 15
                strWord = ""
            Case 16
                strWord = ""
            Case 17
                strWord = ""
            Case 18
                strWord = ""
            Case 19
                strWord = ""
            Case 20
                strWord = ""
            Case 21
                strWord = ""
            Case 22
                strWord = ""
            Case 23
                strWord = ""
            Case 24
                strWord = ""
            Case 25
                strWord = ""
        End Select
        Label9.Text = strWord

        'The amount of blank lines that show up
        'to tell the user how many letters are there
        Dim intChar As Integer
        intChar = strWord.Length
        If intChar = 3 Then
            lblChar1.Visible = True
            lblChar2.Visible = True
            lblChar3.Visible = True
            lblChar4.Visible = False
            lblChar5.Visible = False
            lblChar6.Visible = False
            lblChar7.Visible = False
            lblChar8.Visible = False
        End If
        If intChar = 4 Then
            lblChar1.Visible = True
            lblChar2.Visible = True
            lblChar3.Visible = True
            lblChar4.Visible = True
            lblChar5.Visible = False
            lblChar6.Visible = False
            lblChar7.Visible = False
            lblChar8.Visible = False
        End If
        If intChar = 5 Then
            lblChar1.Visible = True
            lblChar2.Visible = True
            lblChar3.Visible = True
            lblChar4.Visible = True
            lblChar5.Visible = True
            lblChar6.Visible = False
            lblChar7.Visible = False
            lblChar8.Visible = False
        End If
        If intChar = 6 Then
            lblChar1.Visible = True
            lblChar2.Visible = True
            lblChar3.Visible = True
            lblChar4.Visible = True
            lblChar5.Visible = True
            lblChar6.Visible = True
            lblChar7.Visible = False
            lblChar8.Visible = False
        End If
        If intChar = 7 Then
            lblChar1.Visible = True
            lblChar2.Visible = True
            lblChar3.Visible = True
            lblChar4.Visible = True
            lblChar5.Visible = True
            lblChar6.Visible = True
            lblChar7.Visible = True
            lblChar8.Visible = False
        End If
        If intChar = 8 Then
            lblChar1.Visible = True
            lblChar2.Visible = True
            lblChar3.Visible = True
            lblChar4.Visible = True
            lblChar5.Visible = True
            lblChar6.Visible = True
            lblChar7.Visible = True
            lblChar8.Visible = True
        End If
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        'Check the letters and whether they are in the word or not
        'If they are, then do the following:
        Dim strLetter As String
        Dim i, intTally, intlength, oneLet, twoLet As Integer
        intTally = 0 'How many of that letter are there in the word
        strLetter = txtEnter.Text
        intlength = strWord.Length + 1
        For i = 0 To strWord.Length - 1
            If strWord.Substring(i, 1) = strLetter Then
                intTally = intTally + 1
            End If
        Next

        'If the word has one of that letter
        If intTally = 1 Then
            oneLet = strWord.IndexOf(strLetter)
        End If
        'If the word has two of that letter
        If intTally = 2 Then
            oneLet = strWord.IndexOf(strLetter)
            twoLet = strWord.IndexOf(strLetter, oneLet + 1)
        End If

        'Display the letter in the blanks
        'In the first blank
        If oneLet = 1 Or twoLet = 1 Then
            lblChar1.Text = strLetter
            blnLet1 = True
        End If
        'In the second blank
        If oneLet = 2 Or twoLet = 2 Then
            lblChar2.Text = strLetter
            blnLet2 = True
        End If
        'In the third blank
        If oneLet = 3 Or twoLet = 3 Then
            lblChar4.Text = strLetter
            blnLet3 = True
        End If
        'In the fourth blank
        If oneLet = 4 Or twoLet = 4 Then
            lblChar4.Text = strLetter
            blnLet4 = True
        End If
        'In the fifth blank
        If oneLet = 5 Or twoLet = 5 Then
            lblChar5.Text = strLetter
            blnLet5 = True
        End If
        'In the sixth blank
        If oneLet = 6 Or twoLet = 6 Then
            lblChar6.Text = strLetter
            blnLet6 = True
        End If
        'In the seventh blank
        If oneLet = 7 Or twoLet = 7 Then
            lblChar7.Text = strLetter
            blnLet7 = True
        End If
        'In the eighth blank
        If oneLet = 8 Or twoLet = 8 Then
            lblChar8.Text = strLetter
            blnLet8 = True
        End If
    End Sub
End Class
