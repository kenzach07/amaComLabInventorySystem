Public Class Form4

    Private Sub COMLAB1BindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.COMLAB1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FUCKTHISSHIT1DataSet)

    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FUCKTHISSHIT1DataSet.COMLAB1' table. You can move, or remove it, as needed.

        Me.COMLAB1TableAdapter.Fill(Me.FUCKTHISSHIT1DataSet.COMLAB1)
        Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
        bm.CancelCurrentEdit()
        Label2.Hide()
        DATE_ADDEDTextBox.Hide()
    End Sub

    Private Sub PRICETextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PRICETextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
       
        Try

            DATE_ADDEDTextBox.Text = Date.Now.ToShortDateString
            PRODUCT_CODETextBox.Enabled = True
            MANUFACTURERTextBox.Enabled = True
            PRODUCTTextBox.Enabled = True
            PRICETextBox.Enabled = True
            QUANTITYTextBox.Enabled = True
            DATE_ADDEDTextBox.Enabled = True


            COMLAB1BindingSource.AddNew()


        Catch ex As Exception
            
            MessageBox.Show("The Product ID  #" & PRODUCT_CODETextBox.Text & " already exists please change the value of ID")
        End Try


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            COMLAB1BindingSource.EndEdit()
            COMLAB1TableAdapter.Update(FUCKTHISSHIT1DataSet.COMLAB1)
            MsgBox("Data Updated", MsgBoxStyle.Information, "DEAR ADMIN")
            Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
            bm.CancelCurrentEdit()
        Catch ex As Exception
            MsgBox("Error occured while updating data. Please Try again", MsgBoxStyle.Exclamation, "DEAR ADMIN")
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        COMLAB1BindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            COMLAB1BindingSource.EndEdit()
            COMLAB1TableAdapter.Update(FUCKTHISSHIT1DataSet.COMLAB1)
            MsgBox("Data Saved", MsgBoxStyle.Information, "DEAR ADMIN")
            Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
            bm.CancelCurrentEdit()
        Catch ex As Exception
            MessageBox.Show("ERROR saving data please try again")
        End Try
    End Sub

    Private Sub DATE_ADDEDTextBox_DoubleClick(sender As Object, e As System.EventArgs) Handles DATE_ADDEDTextBox.DoubleClick
        DATE_ADDEDTextBox.Text = Date.Now.ToString("MM/dd/yy")
    End Sub
    Private Sub DATE_ADDEDTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DATE_ADDEDTextBox.KeyPress

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 47 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub



    Private Sub PRICETextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PRICETextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub QUANTITYTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles QUANTITYTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

  

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs)





    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button11_Click_1(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If CheckBox1.Checked Then
            Me.COMLAB1BindingSource.Filter = "PRODUCT_CODE like '%" & TextBox1.Text & "%'"
        End If
        If CheckBox3.Checked Then
            Me.COMLAB1BindingSource.Filter = "MANUFACTURER like '%" & TextBox1.Text & "%'"
        End If
        If CheckBox2.Checked Then
            Me.COMLAB1BindingSource.Filter = "PRODUCT like '%" & TextBox1.Text & "%'"
        End If
        If CheckBox4.Checked Then
            Me.COMLAB1BindingSource.Filter = "QUANTITY = '" & TextBox1.Text & "'"
        End If
     
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click

        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Form1.Show()
        Me.Hide()
        Form1.TextBox1.Focus()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        Dim peaceout As String
        peaceout = MsgBox("Are you sure you want to leave?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DEAR ADMIN")
        If peaceout = vbYes Then

            Application.Exit()
        ElseIf peaceout = vbNo Then
            MsgBox("Welcome Back", MsgBoxStyle.Information, "DEAR ADMIN")
        End If
    End Sub

    Private Sub DATE_ADDEDTextBox_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DATE_ADDEDTextBox.MouseClick

    End Sub

    Private Sub DATE_ADDEDTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DATE_ADDEDTextBox.TextChanged

    End Sub

    Private Sub COMLAB1DataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles COMLAB1DataGridView.CellContentClick
        Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub Button1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Button1.KeyPress

    End Sub

    Private Sub DATE_ADDEDTextBox_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles DATE_ADDEDTextBox.MouseDoubleClick
        DATE_ADDEDTextBox.Text = Date.Now.ToString("MM/dd/yy")
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.CheckState = CheckState.Checked Then
            CheckBox2.Enabled = False
            CheckBox1.Enabled = False
            CheckBox4.Enabled = False
        ElseIf CheckBox3.CheckState = CheckState.Unchecked Then
            CheckBox2.Enabled = True
            CheckBox1.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        TextBox1.Clear()
        COMLAB1BindingSource.RemoveFilter()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox2.Enabled = False

            CheckBox3.Enabled = False

            CheckBox4.Enabled = False

        ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
        ElseIf CheckBox2.CheckState = CheckState.Unchecked Then
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.CheckState = CheckState.Checked Then
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox1.Enabled = False
        ElseIf CheckBox4.CheckState = CheckState.Unchecked Then
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub Button6_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.Red
    End Sub

    Private Sub Button6_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button6.MouseHover
        Button6.BackColor = Color.Firebrick
    End Sub

    Private Sub Button7_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button7.MouseHover
        Button7.BackColor = Color.Firebrick
    End Sub

    Private Sub Button7_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button7.MouseLeave
        Button7.BackColor = Color.Red
    End Sub

    Private Sub Button9_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button9.MouseHover
        Button9.BackColor = Color.Firebrick
    End Sub

    Private Sub Button9_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button9.MouseLeave
        Button9.BackColor = Color.Red
    End Sub

    Private Sub Button10_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button10.MouseHover
        Button10.BackColor = Color.Firebrick
    End Sub

    Private Sub Button10_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button10.MouseLeave
        Button10.BackColor = Color.Red
    End Sub

    



    Private Sub Button1_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button2_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button3_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button4_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button4.MouseHover
        Button4.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button4_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.RoyalBlue
    End Sub



    Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
        AcceptButton = Button11
        TextBox1.ForeColor = Color.Black
        If TextBox1.Text = "SEARCH HERE" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus
        AcceptButton = Button1
        If TextBox1.Text = "" Then
            TextBox1.ForeColor = Color.DimGray
            TextBox1.Text = "SEARCH HERE"
        End If
    End Sub

    Private Sub COMLAB1DataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles COMLAB1DataGridView.CellClick
        Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub COMLAB1DataGridView_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles COMLAB1DataGridView.CellContentDoubleClick
        Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub COMLAB1DataGridView_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles COMLAB1DataGridView.CellMouseClick
        Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub COMLAB1DataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles COMLAB1DataGridView.CellMouseDoubleClick
        Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

   
    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim peaceout As String
        peaceout = MsgBox("Are you sure you want to leave?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DEAR USER")
        If peaceout = vbYes Then

            Application.Exit()
        ElseIf peaceout = vbNo Then
            Me.ShowDialog()
            MsgBox("Welcome Back", MsgBoxStyle.Information, " DEAR USER")
        End If
    End Sub

    Private Sub COMLAB1DataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles COMLAB1DataGridView.CellEndEdit

        Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub COMLAB1DataGridView_Click(sender As System.Object, e As System.EventArgs) Handles COMLAB1DataGridView.Click
        Try
            Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
            bm.CancelCurrentEdit()
        Catch ex As Exception
            Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
            bm.CancelCurrentEdit()
        End Try
    End Sub

    Private Sub COMLAB1DataGridView_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles COMLAB1DataGridView.MouseClick
        Try
            Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
            bm.CancelCurrentEdit()
        Catch ex As Exception
            Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
            bm.CancelCurrentEdit()
        End Try
    End Sub

    Private Sub COMLAB1DataGridView_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles COMLAB1DataGridView.RowsAdded
   


    End Sub

    Private Sub Button1_Validated(sender As System.Object, e As System.EventArgs) Handles Button1.Validated
        
    End Sub

    Private Sub Form4_MouseHover(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseHover

    End Sub

    Private Sub COMLAB1DataGridView_DataBindingComplete(sender As System.Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles COMLAB1DataGridView.DataBindingComplete
   
    End Sub

    Private Sub COMLAB1DataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles COMLAB1DataGridView.DataError
        Dim bm As BindingManagerBase = COMLAB1DataGridView.BindingContext(COMLAB1DataGridView.DataSource, COMLAB1DataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub
End Class