Public Class Form6

    Private Sub CL1ReportsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CL1ReportsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CL1REPORTDataSet)

    End Sub

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CL1REPORTDataSet.CL1Reports' table. You can move, or remove it, as needed.
        Me.CL1ReportsTableAdapter.Fill(Me.CL1REPORTDataSet.CL1Reports)
        AcceptButton = Button1

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Try
            CL1ReportsBindingSource.EndEdit()
            CL1ReportsTableAdapter.Update(CL1REPORTDataSet.CL1Reports)
            MsgBox("Data Saved", MsgBoxStyle.Information, "DEAR ADMIN")
            Dim bm As BindingManagerBase = CL1ReportsDataGridView.BindingContext(CL1ReportsDataGridView.DataSource, CL1ReportsDataGridView.DataMember)
            bm.CancelCurrentEdit()
        Catch ex As Exception
            MessageBox.Show("ERROR saving data please try again")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try





            CL1ReportsBindingSource.AddNew()


        Catch ex As Exception

            MessageBox.Show("The Product ID  #" & PRODUCT_CODETextBox.Text & " already exists please change the value of ID")
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            CL1ReportsBindingSource.EndEdit()
            CL1ReportsTableAdapter.Update(CL1REPORTDataSet.CL1Reports)
            MsgBox("Data Updated", MsgBoxStyle.Information, "DEAR ADMIN")
            Dim bm As BindingManagerBase = CL1ReportsDataGridView.BindingContext(CL1ReportsDataGridView.DataSource, CL1ReportsDataGridView.DataMember)
            bm.CancelCurrentEdit()
        Catch ex As Exception
            MsgBox("Error occured while updating data. Please Try again", MsgBoxStyle.Exclamation, "DEAR ADMIN")
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        CL1ReportsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            CL1ReportsBindingSource.EndEdit()
            CL1ReportsTableAdapter.Update(CL1REPORTDataSet.CL1Reports)
            MsgBox("Data Saved", MsgBoxStyle.Information, "DEAR ADMIN")
            Dim bm As BindingManagerBase = CL1ReportsDataGridView.BindingContext(CL1ReportsDataGridView.DataSource, CL1ReportsDataGridView.DataMember)
            bm.CancelCurrentEdit()
        Catch ex As Exception
            MsgBox("Error occured while saving data. Please Try again", MsgBoxStyle.Exclamation, "DEAR ADMIN")
        End Try
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click

        Dim ppd As New PrintPreviewDialog
        ppd.Document = PrintDocument1
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        CL1ReportsDataGridView.Sort(CL1ReportsDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        Try
            Dim mRow As Integer = 0
            Dim newpage As Boolean = True
            With CL1ReportsDataGridView
                Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
                fmt.LineAlignment = StringAlignment.Center
                fmt.Trimming = StringTrimming.EllipsisCharacter
                Dim y As Single = e.MarginBounds.Top
                Do While mRow < .RowCount
                    Dim row As DataGridViewRow = .Rows(mRow)
                    Dim x As Single = e.MarginBounds.Left
                    Dim h As Single = 0
                    For Each cell As DataGridViewCell In row.Cells
                        Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                        If (newpage) Then
                            e.Graphics.DrawString(CL1ReportsDataGridView.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                        Else
                            e.Graphics.DrawString(CL1ReportsDataGridView.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                        End If
                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    Next
                    If newpage Then
                        newpage = False
                    Else
                        mRow += 1
                    End If
                    y += h
                    If y + h > e.MarginBounds.Bottom Then
                        e.HasMorePages = True
                        mRow -= 1
                        newpage = True
                        Exit Sub
                    End If
                Loop
                mRow = 0
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub printdata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_QueryPageSettings(ByVal sender As Object, ByVal e As System.Drawing.Printing.QueryPageSettingsEventArgs) Handles PrintDocument1.QueryPageSettings
        e.PageSettings.Landscape = True
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

    Private Sub Button8_MouseHover(sender As Object, e As System.EventArgs) Handles Button8.MouseHover
        Button8.BackColor = Color.SteelBlue
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As System.EventArgs) Handles Button8.MouseLeave
        Button8.BackColor = Color.RoyalBlue
    End Sub
    Private Sub QUANTITYTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles QUANTITYTextBox.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False

        Else
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If RadioButton1.Checked Then
            Me.CL1ReportsBindingSource.Filter = "PRODUCT_CODE like '%" & TextBox1.Text & "%'"
        End If
        If RadioButton2.Checked Then
            Me.CL1ReportsBindingSource.Filter = "MANUFACTURER like '%" & TextBox1.Text & "%'"
        End If
        If RadioButton3.Checked Then
            Me.CL1ReportsBindingSource.Filter = "PRODUCT like '%" & TextBox1.Text & "%'"
        End If

       
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Form7.RadioButton1.Checked = True
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Form2.Show()
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
        peaceout = MsgBox("Are you sure you want to leave?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DEAR ADMIN")
        If peaceout = vbYes Then

            Application.Exit()
        ElseIf peaceout = vbNo Then
            Me.Show()
            MsgBox("Welcome Back", MsgBoxStyle.Information, " DEAR ADMIN")
        End If
    End Sub

    Private Sub CL1ReportsDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CL1ReportsDataGridView.CellClick
        Dim bm As BindingManagerBase = CL1ReportsDataGridView.BindingContext(CL1ReportsDataGridView.DataSource, CL1ReportsDataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub CL1ReportsDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CL1ReportsDataGridView.CellContentClick
        Dim bm As BindingManagerBase = CL1ReportsDataGridView.BindingContext(CL1ReportsDataGridView.DataSource, CL1ReportsDataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub CL1ReportsDataGridView_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CL1ReportsDataGridView.CellContentDoubleClick
        Dim bm As BindingManagerBase = CL1ReportsDataGridView.BindingContext(CL1ReportsDataGridView.DataSource, CL1ReportsDataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub CL1ReportsDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles CL1ReportsDataGridView.DataError
        Dim bm As BindingManagerBase = CL1ReportsDataGridView.BindingContext(CL1ReportsDataGridView.DataSource, CL1ReportsDataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub CL1ReportsDataGridView_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles CL1ReportsDataGridView.MouseClick
        Dim bm As BindingManagerBase = CL1ReportsDataGridView.BindingContext(CL1ReportsDataGridView.DataSource, CL1ReportsDataGridView.DataMember)
        bm.CancelCurrentEdit()
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles TextBox1.GotFocus
        AcceptButton = Button11
        TextBox1.ForeColor = Color.Black
        If TextBox1.Text = "SEARCH HERE" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TextBox1.LostFocus
        CL1ReportsBindingSource.RemoveFilter()
        If TextBox1.Text = "" Then
            TextBox1.ForeColor = Color.DimGray
            TextBox1.Text = "SEARCH HERE"
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        TextBox1.Clear()
        CL1ReportsBindingSource.RemoveFilter()
    End Sub
End Class