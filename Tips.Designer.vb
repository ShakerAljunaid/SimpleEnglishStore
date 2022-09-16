<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tips
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim TipLabel As System.Windows.Forms.Label
        Dim ExampleLabel As System.Windows.Forms.Label
        Dim More_infoLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tips))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.addtips = New System.Windows.Forms.Button()
        Me.SourceDataSet = New English.SourceDataSet()
        Me.TipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipsTableAdapter = New English.SourceDataSetTableAdapters.TipsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager()
        Me.TipsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TipsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TipsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.addnewtips = New System.Windows.Forms.GroupBox()
        Me.Exittips = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TipTextBox = New System.Windows.Forms.TextBox()
        Me.ExampleTextBox = New System.Windows.Forms.TextBox()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.More_infoTextBox = New System.Windows.Forms.TextBox()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        IDLabel = New System.Windows.Forms.Label()
        TipLabel = New System.Windows.Forms.Label()
        ExampleLabel = New System.Windows.Forms.Label()
        More_infoLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TipsBindingNavigator.SuspendLayout()
        CType(Me.TipsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addnewtips.SuspendLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(82, 46)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(22, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'TipLabel
        '
        TipLabel.AutoSize = True
        TipLabel.Location = New System.Drawing.Point(82, 84)
        TipLabel.Name = "TipLabel"
        TipLabel.Size = New System.Drawing.Size(25, 13)
        TipLabel.TabIndex = 2
        TipLabel.Text = "Tip:"
        '
        'ExampleLabel
        '
        ExampleLabel.AutoSize = True
        ExampleLabel.Location = New System.Drawing.Point(82, 250)
        ExampleLabel.Name = "ExampleLabel"
        ExampleLabel.Size = New System.Drawing.Size(51, 13)
        ExampleLabel.TabIndex = 4
        ExampleLabel.Text = "Example:"
        '
        'More_infoLabel
        '
        More_infoLabel.AutoSize = True
        More_infoLabel.Location = New System.Drawing.Point(477, 120)
        More_infoLabel.Name = "More_infoLabel"
        More_infoLabel.Size = New System.Drawing.Size(56, 13)
        More_infoLabel.TabIndex = 6
        More_infoLabel.Text = "More info:"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(477, 246)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(56, 13)
        CommentLabel.TabIndex = 8
        CommentLabel.Text = "Comment:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(947, 139)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(44, 13)
        PictureLabel.TabIndex = 10
        PictureLabel.Text = "Picture:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Return to words"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'addtips
        '
        Me.addtips.Location = New System.Drawing.Point(661, 39)
        Me.addtips.Name = "addtips"
        Me.addtips.Size = New System.Drawing.Size(147, 25)
        Me.addtips.TabIndex = 1
        Me.addtips.Text = "Add new tip "
        Me.addtips.UseVisualStyleBackColor = True
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "SourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipsBindingSource
        '
        Me.TipsBindingSource.DataMember = "Tips"
        Me.TipsBindingSource.DataSource = Me.SourceDataSet
        '
        'TipsTableAdapter
        '
        Me.TipsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GrammarTableAdapter = Nothing
        Me.TableAdapterManager.TipsTableAdapter = Me.TipsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WordsTableAdapter = Nothing
        '
        'TipsBindingNavigator
        '
        Me.TipsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TipsBindingNavigator.BindingSource = Me.TipsBindingSource
        Me.TipsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TipsBindingNavigator.DeleteItem = Nothing
        Me.TipsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.TipsBindingNavigatorSaveItem, Me.NewToolStripButton, Me.OpenToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.toolStripSeparator1})
        Me.TipsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TipsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TipsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TipsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TipsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TipsBindingNavigator.Name = "TipsBindingNavigator"
        Me.TipsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TipsBindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.TipsBindingNavigator.TabIndex = 2
        Me.TipsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TipsBindingNavigatorSaveItem
        '
        Me.TipsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TipsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TipsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TipsBindingNavigatorSaveItem.Name = "TipsBindingNavigatorSaveItem"
        Me.TipsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TipsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TipsDataGridView
        '
        Me.TipsDataGridView.AutoGenerateColumns = False
        Me.TipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TipsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewImageColumn1})
        Me.TipsDataGridView.DataSource = Me.TipsBindingSource
        Me.TipsDataGridView.Location = New System.Drawing.Point(0, 71)
        Me.TipsDataGridView.Name = "TipsDataGridView"
        Me.TipsDataGridView.Size = New System.Drawing.Size(1370, 676)
        Me.TipsDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tip"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tip"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 600
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Example"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Example"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "More info"
        Me.DataGridViewTextBoxColumn4.HeaderText = "More info"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Picture"
        Me.DataGridViewImageColumn1.HeaderText = "Picture"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'addnewtips
        '
        Me.addnewtips.BackgroundImage = CType(resources.GetObject("addnewtips.BackgroundImage"), System.Drawing.Image)
        Me.addnewtips.Controls.Add(Me.Exittips)
        Me.addnewtips.Controls.Add(IDLabel)
        Me.addnewtips.Controls.Add(Me.IDTextBox)
        Me.addnewtips.Controls.Add(TipLabel)
        Me.addnewtips.Controls.Add(Me.TipTextBox)
        Me.addnewtips.Controls.Add(ExampleLabel)
        Me.addnewtips.Controls.Add(Me.ExampleTextBox)
        Me.addnewtips.Controls.Add(More_infoLabel)
        Me.addnewtips.Controls.Add(CommentLabel)
        Me.addnewtips.Controls.Add(PictureLabel)
        Me.addnewtips.Controls.Add(Me.PicturePictureBox)
        Me.addnewtips.Controls.Add(Me.More_infoTextBox)
        Me.addnewtips.Controls.Add(Me.CommentTextBox)
        Me.addnewtips.Location = New System.Drawing.Point(0, 67)
        Me.addnewtips.Name = "addnewtips"
        Me.addnewtips.Size = New System.Drawing.Size(1406, 680)
        Me.addnewtips.TabIndex = 4
        Me.addnewtips.TabStop = False
        Me.addnewtips.Text = "Add tips"
        '
        'Exittips
        '
        Me.Exittips.Image = CType(resources.GetObject("Exittips.Image"), System.Drawing.Image)
        Me.Exittips.Location = New System.Drawing.Point(950, 337)
        Me.Exittips.Name = "Exittips"
        Me.Exittips.Size = New System.Drawing.Size(62, 50)
        Me.Exittips.TabIndex = 12
        Me.Exittips.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(144, 43)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'TipTextBox
        '
        Me.TipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipsBindingSource, "Tip", True))
        Me.TipTextBox.Location = New System.Drawing.Point(144, 81)
        Me.TipTextBox.Multiline = True
        Me.TipTextBox.Name = "TipTextBox"
        Me.TipTextBox.Size = New System.Drawing.Size(273, 150)
        Me.TipTextBox.TabIndex = 3
        '
        'ExampleTextBox
        '
        Me.ExampleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipsBindingSource, "Example", True))
        Me.ExampleTextBox.Location = New System.Drawing.Point(144, 247)
        Me.ExampleTextBox.Multiline = True
        Me.ExampleTextBox.Name = "ExampleTextBox"
        Me.ExampleTextBox.Size = New System.Drawing.Size(273, 72)
        Me.ExampleTextBox.TabIndex = 5
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TipsBindingSource, "Picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(1009, 139)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(216, 166)
        Me.PicturePictureBox.TabIndex = 11
        Me.PicturePictureBox.TabStop = False
        '
        'More_infoTextBox
        '
        Me.More_infoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipsBindingSource, "More info", True))
        Me.More_infoTextBox.Location = New System.Drawing.Point(539, 117)
        Me.More_infoTextBox.Multiline = True
        Me.More_infoTextBox.Name = "More_infoTextBox"
        Me.More_infoTextBox.Size = New System.Drawing.Size(250, 98)
        Me.More_infoTextBox.TabIndex = 7
        '
        'CommentTextBox
        '
        Me.CommentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipsBindingSource, "Comment", True))
        Me.CommentTextBox.Location = New System.Drawing.Point(539, 243)
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(250, 98)
        Me.CommentTextBox.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(950, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 19)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(990, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(218, 20)
        Me.TextBox1.TabIndex = 6
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.addnewtips)
        Me.Controls.Add(Me.TipsDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TipsBindingNavigator)
        Me.Controls.Add(Me.addtips)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tips"
        Me.Text = "Tips"
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TipsBindingNavigator.ResumeLayout(False)
        Me.TipsBindingNavigator.PerformLayout()
        CType(Me.TipsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addnewtips.ResumeLayout(False)
        Me.addnewtips.PerformLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents addtips As System.Windows.Forms.Button
    Friend WithEvents SourceDataSet As English.SourceDataSet
    Friend WithEvents TipsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipsTableAdapter As English.SourceDataSetTableAdapters.TipsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TipsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TipsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TipsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents addnewtips As System.Windows.Forms.GroupBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExampleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents More_infoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Exittips As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
