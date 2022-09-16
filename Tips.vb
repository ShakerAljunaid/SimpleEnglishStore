Public Class Tips

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Words.Show()
        Me.Hide()
        Words.Stuff.Visible = False


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtips.Click
        addnewtips.Visible = True

    End Sub

    Private Sub TipsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TipsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SourceDataSet)

    End Sub

    Private Sub Tips_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.Tips' table. You can move, or remove it, as needed.
        Me.TipsTableAdapter.Fill(Me.SourceDataSet.Tips)
        addnewtips.Visible = False

    End Sub

    Private Sub Exittips_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exittips.Click
        addnewtips.Visible = False

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TipsBindingSource.Filter = "tip like'%" & TextBox1.Text & "%'"

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

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.Validate()
        Me.TipsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SourceDataSet)
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        PrintForm1.Print()

    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        addnewtips.Visible = True
    End Sub

    Private Sub TipsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipsBindingNavigator.RefreshItems

    End Sub


End Class