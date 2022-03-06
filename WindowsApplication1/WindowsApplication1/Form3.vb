Public Class Form3

    

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("You may now choose your area ", MsgBoxStyle.Information, "DEAR USER")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Form4.RadioButton1.Checked = True
            Form4.Show()
            Me.Hide()
            
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        MsgBox("STILL UNDER MAINTENANCE", MsgBoxStyle.Exclamation, "WE ARE VERY SORRY")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form11.RadioButton1.Checked = True
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Close()
        Form1.TextBox1.Focus()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
    End Sub
End Class