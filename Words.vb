Public Class Words

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Grammar.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Tips.Show()
        Me.Hide()




    End Sub

    Private Sub Others_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Others.Click
        Stuff.Visible = True


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.Words' table. You can move, or remove it, as needed.
        Me.WordsTableAdapter.Fill(Me.SourceDataSet.Words)
        Stuff.Visible = False
        Addnewwords.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Stuff.Visible = False

    End Sub

    Private Sub WordsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SourceDataSet)

    End Sub

    Private Sub Stuff_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Stuff.Enter

    End Sub

    Private Sub WordsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles WordsDataGridView.CellContentClick

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Addnewwords.Visible = True
    End Sub

    Private Sub SynonymTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SynonymTextBox.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        WordsBindingSource.Filter = "NOUN LIKE '%" & TextBox1.Text & "%'"

    End Sub

    Private Sub Addnewwords_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addnewwords.Enter

    End Sub

    Private Sub Exitwords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exitwords.Click

        Addnewwords.Visible = False
        
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.WordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SourceDataSet)
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        PrintForm1.Print()

    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Try

            OpenFileDialog1.Filter = "(*.bmp,*.gif,*)|*bmp|(*.gif)|*gif)"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PicturePictureBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)

            End If
        Catch
            MsgBox("You imported no picture ")
        End Try
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Addnewwords.Visible = True

    End Sub

    Private Sub WordsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordsBindingNavigator.RefreshItems

    End Sub
End Class
