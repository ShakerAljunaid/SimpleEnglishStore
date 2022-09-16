Public Class Grammar

    Private Sub retw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retw.Click
        Words.Show()
        Me.Hide()
        Words.Stuff.Visible = False

    End Sub

    Private Sub GrammarBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrammarBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GrammarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SourceDataSet)

    End Sub

    Private Sub Grammar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.Grammar' table. You can move, or remove it, as needed.
        Me.GrammarTableAdapter.Fill(Me.SourceDataSet.Grammar)
        addgrammars.Visible = False

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        GrammarBindingSource.Filter = "GRAMMAR LIKE'%" & TextBox1.Text & "%'"

    End Sub

    Private Sub GrammarTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrammarTextBox.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addgrammars.Enter

    End Sub

    Private Sub addgrammar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addgrammar.Click
        addgrammars.Visible = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exitgrammar.Click

        addgrammars.Visible = False

    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Try

            OpenFileDialog1.Filter = "(*.bmp,.*.gif,*)|*bmp|(*.gif)|*gif)"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PicturePictureBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch
            MsgBox("You imported no picture ")
        End Try
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        PrintForm1.Print()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.GrammarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SourceDataSet)
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        addgrammars.Visible = True

    End Sub
End Class