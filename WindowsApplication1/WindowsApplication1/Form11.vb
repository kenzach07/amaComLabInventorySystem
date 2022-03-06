Public Class Form11

    Private Sub MACLABBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.MACLABBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MACLABDataSet)

    End Sub

    Private Sub Form11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MACLABDataSet.MACLAB' table. You can move, or remove it, as needed.
        Me.MACLABTableAdapter.Fill(Me.MACLABDataSet.MACLAB)
        PRODUCT_CODETextBox.Enabled = False
        MANUFACTURERTextBox.Enabled = False
        PRICETextBox.Enabled = False

        DATE_ADDEDTextBox.Enabled = False
        PRODUCTTextBox.Enabled = False
        STATUSTextBox.Enabled = False


        DATE_ADDEDTextBox.Hide()
        AcceptButton = Button1

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

    Private Sub Button5_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button5.MouseHover
        Button5.BackColor = Color.Firebrick
    End Sub

    Private Sub Button5_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.Red
    End Sub







    Private Sub Button4_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button4.MouseHover
        Button4.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button4_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.RoyalBlue
    End Sub


    Private Sub Button1_MouseHover1(sender As Object, e As System.EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.SteelBlue
    End Sub


    Private Sub Button1_MouseLeave1(sender As Object, e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.RoyalBlue
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            DATE_ADDEDTextBox.Text = Date.Now.ToShortDateString
            TextBox1.Enabled = True
            DATE_ADDEDTextBox.Text = Date.Now.ToShortDateString
            MACLABDataGridView.Enabled = False
            PRODUCT_CODETextBox.Enabled = True
            MANUFACTURERTextBox.Enabled = True
            PRODUCTTextBox.Enabled = True
            PRICETextBox.Enabled = True

            DATE_ADDEDTextBox.Enabled = True
            STATUSTextBox.Enabled = True




            MACLABBindingSource.AddNew()


        Catch ex As Exception
            MessageBox.Show("The Product ID  #" & PRODUCT_CODETextBox.Text & " already exists please change the value of ID")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            TextBox1.Enabled = True
            MACLABDataGridView.Enabled = True
            PRODUCT_CODETextBox.Enabled = False
            MANUFACTURERTextBox.Enabled = False
            PRICETextBox.Enabled = False

            DATE_ADDEDTextBox.Enabled = False
            PRODUCTTextBox.Enabled = False
            STATUSTextBox.Enabled = False
            Dim bm As BindingManagerBase = MACLABDataGridView.BindingContext(MACLABDataGridView.DataSource, MACLABDataGridView.DataMember)
            bm.CancelCurrentEdit()
        Catch ex As Exception
            Dim bm As BindingManagerBase = MACLABDataGridView.BindingContext(MACLABDataGridView.DataSource, MACLABDataGridView.DataMember)
            bm.CancelCurrentEdit()
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            MACLABDataGridView.Enabled = True
            PRODUCT_CODETextBox.Enabled = False
            MANUFACTURERTextBox.Enabled = False
            PRODUCTTextBox.Enabled = False
            PRICETextBox.Enabled = False

            DATE_ADDEDTextBox.Enabled = False
            MACLABBindingSource.EndEdit()
            MACLABTableAdapter.Update(MACLABDataSet.MACLAB)
            MsgBox("Data Saved", MsgBoxStyle.Information, "DEAR USER")

        Catch ex As Exception
            MessageBox.Show("ERROR saving data please try again")
        End Try
    End Sub
    Private Sub PRICETextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PRICETextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 44 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

   

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If RadioButton1.Checked Then
            Me.MACLABBindingSource.Filter = "PRODUCT_CODE like '%" & TextBox1.Text & "%'"
        End If
        If RadioButton2.Checked Then
            Me.MACLABBindingSource.Filter = "MANUFACTURER like '%" & TextBox1.Text & "%'"
        End If
        If RadioButton3.Checked Then
            Me.MACLABBindingSource.Filter = "PRODUCT like '%" & TextBox1.Text & "%'"
        End If

        If RadioButton4.Checked Then
            Me.MACLABBindingSource.Filter = "STATUS like '%" & TextBox1.Text & "%'"
        End If
    End Sub
    Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
        AcceptButton = Button11
        TextBox1.ForeColor = Color.Black
        If TextBox1.Text = "SEARCH HERE" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus
        MACLABBindingSource.RemoveFilter()
        If TextBox1.Text = "" Then
            TextBox1.ForeColor = Color.DimGray
            TextBox1.Text = "SEARCH HERE"
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Form13.RadioButton1.Checked = True
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Form1.Show()
        Me.Close()
        Form1.TextBox1.Focus()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim peaceout As String
        peaceout = MsgBox("Are you sure you want to leave?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DEAR STAFF")
        If peaceout = vbYes Then

            Application.Exit()
        ElseIf peaceout = vbNo Then
            Me.Show()
            MsgBox("Welcome Back", MsgBoxStyle.Information, " DEAR STAFF")
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        TextBox1.Clear()
        MACLABBindingSource.RemoveFilter()
    End Sub
End Class