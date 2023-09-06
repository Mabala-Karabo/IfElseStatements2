Public Class Form1
    Private Sub txtSmallBio_Click(sender As Object, e As EventArgs) Handles txtSmallBio.Click
        Dim Name As String
        Dim Surname As String
        Dim Year As Integer
        Dim Tribe As String
        Dim Gender As String
        Dim yourGender As String
        Dim Age As Integer
        Dim Greetings As String

        Name = txtName.Text
        Surname = txtSurname.Text
        Year = txtYear.Text
        Tribe = txtTribe.Text.ToLower
        Gender = txtGender.Text.ToLower
        Age = 2023 - Year
        If Tribe = "english" Or Tribe = "white" Then
            Greetings = "Hello"
        ElseIf Tribe = "Isizulu" Then
            Greetings = "Sawubona"
        ElseIf Tribe = "sepedi" Or Tribe = "tswana" Then
            Greetings = "Dumela"
        ElseIf Tribe = "venda" Then
            Greetings = "Ndaa!"
        ElseIf Tribe = "tsonga" Then
            Greetings = "Avuxeni"
        ElseIf Tribe = "xhosa" Then
            Greetings = "molo"
        Else
            Greetings = "Your language is not specified"
        End If
        If Gender = "male" Then
            yourGender = "gentleman"
        ElseIf Gender = "female" Then
            yourGender = "lady"
        Else
            yourGender = "not specified"

        End If
        MsgBox(Greetings & " " & Name & " " & Surname & ", You are a " & Age & " years old " & yourGender & " Who speaks " & Tribe)
    End Sub
End Class
