Public Class Form1
    Dim globalfolderdirectory As String
    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonChooseDirectory.Click
        Dim Dialog As FolderBrowserDialog = New FolderBrowserDialog
        Dim folderDirectory As String
        folderDirectory = Space$(255)
        Dialog.Description = "Choose a directory..."
        Dialog.ShowDialog(Me)
        folderDirectory = Dialog.SelectedPath
        RTrim(folderDirectory)
        textboxChosenDirectory.Text = folderDirectory
        globalfolderdirectory = folderDirectory
    End Sub
    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        Close()

    End Sub

    Private Sub buttonMakeDirectories_Click(sender As Object, e As EventArgs) Handles buttonMakeDirectories.Click
        'FOLDER CREATION SUB

        'ERROR HANDLING
        ''No directory selected
        If globalfolderdirectory = "" Then
            MsgBox("Please select a directory")
            ''Nothing entered in box
        ElseIf textboxNumber.Text = "" Then
            MsgBox("Please input a number greater than 0")
        Else

            'Folder creation loop varable declarations
            Dim userinput As Integer = Convert.ToInt64(textboxNumber.Text)
            Dim foldername As String
            Dim paddingstring As String
            Dim counterstringlength As Integer
            Dim counter As Integer = 1
            Dim foldernumber As Integer
            Dim vardiff As Integer = 0
            'MAIN LOOP
            Do While counter < userinput
                foldernumber = counter
                'Equal length = yes
                If checkboxZeroPad.CheckState = 1 Then
                    counterstringlength = counter.ToString.Length
                    vardiff = userinput.ToString.Length - counterstringlength
                    'to check if this is the last loop
                    If foldernumber.ToString.Length < userinput.ToString.Length Then
                        'padding length
                        paddingstring = ""
                        For x As Integer = 1 To vardiff
                            paddingstring += "0"
                        Next
                        'Padded Concatination
                        foldername = globalfolderdirectory.ToString + "\" + paddingstring + foldernumber.ToString
                        My.Computer.FileSystem.CreateDirectory(foldername)

                    Else
                        'Concatination without padding
                        foldername = globalfolderdirectory.ToString + "\" + foldernumber.ToString
                        My.Computer.FileSystem.CreateDirectory(foldername)


                    End If
                Else
                    'Equal length = no
                    foldername = globalfolderdirectory.ToString + "\" + foldernumber.ToString
                    My.Computer.FileSystem.CreateDirectory(foldername)
                End If
                counter += 1
            Loop
            foldername = globalfolderdirectory.ToString + "\" + userinput.ToString
            My.Computer.FileSystem.CreateDirectory(foldername)
            labelNumberOfFolder.Text = userinput.ToString + " Folders were created in " + globalfolderdirectory.ToString + "\"
        End If
        Process.Start(globalfolderdirectory.ToString)
    End Sub

    Private Sub textboxNumber_TextChanged(sender As Object, e As EventArgs) Handles textboxNumber.TextChanged

        'User input validation
        Dim Mystring As String = textboxNumber.Text
        If CheckForAlphaCharacters(Mystring) Then
            MsgBox("Please enter an intager greater than 0")
            textboxNumber.Text = ""
        End If
    End Sub


End Class
