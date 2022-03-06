Public Class Form1


    Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.ForeColor = Color.Black
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.ForeColor = Color.DimGray
            TextBox1.Text = "Username"
        End If
    End Sub
    Private Sub TextBox2_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.UseSystemPasswordChar = True
        TextBox2.ForeColor = Color.Black
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""



        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox2.LostFocus

        If TextBox2.Text = "" Then

            TextBox2.ForeColor = Color.DimGray

            TextBox2.Text = "Password"
        End If
    End Sub



    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TextBox1.Focus()


    End Sub



    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click


        If TextBox1.Text = "12345" And TextBox2.Text = "123" Then

            Call Admin()
        ElseIf TextBox1.Text = My.Settings.Useruser And TextBox2.Text = My.Settings.Userpass Then

            Call User()



        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Please fill the textbox", MsgBoxStyle.Exclamation, "ERROR")
            TextBox1.Focus()
        ElseIf TextBox1.Text <> My.Settings.Adminuser And TextBox1.Text <> My.Settings.Useruser Then

            MsgBox("Username is INCORRECT", MsgBoxStyle.Exclamation, "ERROR")
            Return
        Else

            MsgBox("Password is INCORRECT", MsgBoxStyle.Exclamation, "ERROR")


        End If
    End Sub

    Private Sub Admin()
       
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub User()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Dim peaceout As String
        peaceout = MsgBox("Are you sure you want to leave?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "All System Out")
        If peaceout = vbYes Then

            Application.Exit()
        ElseIf peaceout = vbNo Then
            MsgBox("Welcome Back", MsgBoxStyle.Information, "DEAR USER")
        End If
    End Sub

    Private Sub btnLogin_GotFocus(sender As Object, e As System.EventArgs) Handles btnLogin.GotFocus

    End Sub















    Private Sub btnLogin_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnLogin.MouseHover
        btnLogin.BackColor = Color.SteelBlue
    End Sub

  

  
    Private Sub btnLogin_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.DodgerBlue
    End Sub



   

   

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim peaceout As String
        peaceout = MsgBox("Are you sure you want to leave?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DEAR USER")
        If peaceout = vbYes Then

            Application.Exit()
        ElseIf peaceout = vbNo Then
            Me.Show()
            MsgBox("Welcome Back", MsgBoxStyle.Information, " DEAR USER")
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.DodgerBlue
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
