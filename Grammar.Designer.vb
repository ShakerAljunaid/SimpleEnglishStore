<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grammar
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
        Dim GrammarLabel As System.Windows.Forms.Label
        Dim ExamplesLabel As System.Windows.Forms.Label
        Dim More_infoLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grammar))
        Me.retw = New System.Windows.Forms.Button()
        Me.SourceDataSet = New English.SourceDataSet()
        Me.GrammarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrammarTableAdapter = New English.SourceDataSetTableAdapters.GrammarTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager()
        Me.GrammarBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GrammarBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GrammarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.addgrammar = New System.Windows.Forms.Button()
        Me.addgrammars = New System.Windows.Forms.GroupBox()
        Me.Exitgrammar = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.GrammarTextBox = New System.Windows.Forms.TextBox()
        Me.ExamplesTextBox = New System.Windows.Forms.TextBox()
        Me.More_infoTextBox = New System.Windows.Forms.TextBox()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        IDLabel = New System.Windows.Forms.Label()
        GrammarLabel = New System.Windows.Forms.Label()
        ExamplesLabel = New System.Windows.Forms.Label()
        More_infoLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrammarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrammarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrammarBindingNavigator.SuspendLayout()
        CType(Me.GrammarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addgrammars.SuspendLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(35, 22)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(22, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'GrammarLabel
        '
        GrammarLabel.AutoSize = True
        GrammarLabel.Location = New System.Drawing.Point(35, 71)
        GrammarLabel.Name = "GrammarLabel"
        GrammarLabel.Size = New System.Drawing.Size(54, 13)
        GrammarLabel.TabIndex = 2
        GrammarLabel.Text = "Grammar:"
        '
        'ExamplesLabel
        '
        ExamplesLabel.AutoSize = True
        ExamplesLabel.Location = New System.Drawing.Point(35, 274)
        ExamplesLabel.Name = "ExamplesLabel"
        ExamplesLabel.Size = New System.Drawing.Size(56, 13)
        ExamplesLabel.TabIndex = 4
        ExamplesLabel.Text = "Examples:"
        '
        'More_infoLabel
        '
        More_infoLabel.AutoSize = True
        More_infoLabel.Location = New System.Drawing.Point(413, 220)
        More_infoLabel.Name = "More_infoLabel"
        More_infoLabel.Size = New System.Drawing.Size(56, 13)
        More_infoLabel.TabIndex = 6
        More_infoLabel.Text = "More info:"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(413, 100)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(56, 13)
        CommentLabel.TabIndex = 8
        CommentLabel.Text = "Comment:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(790, 68)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(44, 13)
        PictureLabel.TabIndex = 10
        PictureLabel.Text = "Picture:"
        '
        'retw
        '
        Me.retw.Location = New System.Drawing.Point(283, 41)
        Me.retw.Name = "retw"
        Me.retw.Size = New System.Drawing.Size(123, 22)
        Me.retw.TabIndex = 0
        Me.retw.Text = "Return to words"
        Me.retw.UseVisualStyleBackColor = True
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "SourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrammarBindingSource
        '
        Me.GrammarBindingSource.DataMember = "Grammar"
        Me.GrammarBindingSource.DataSource = Me.SourceDataSet
        '
        'GrammarTableAdapter
        '
        Me.GrammarTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GrammarTableAdapter = Me.GrammarTableAdapter
        Me.TableAdapterManager.TipsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WordsTableAdapter = Nothing
        '
        'GrammarBindingNavigator
        '
        Me.GrammarBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GrammarBindingNavigator.BindingSource = Me.GrammarBindingSource
        Me.GrammarBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GrammarBindingNavigator.DeleteItem = Nothing
        Me.GrammarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.GrammarBindingNavigatorSaveItem, Me.NewToolStripButton, Me.OpenToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.toolStripSeparator1})
        Me.GrammarBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GrammarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GrammarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GrammarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GrammarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GrammarBindingNavigator.Name = "GrammarBindingNavigator"
        Me.GrammarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GrammarBindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.GrammarBindingNavigator.TabIndex = 1
        Me.GrammarBindingNavigator.Text = "BindingNavigator1"
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
        'GrammarBindingNavigatorSaveItem
        '
        Me.GrammarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GrammarBindingNavigatorSaveItem.Image = CType(resources.GetObject("GrammarBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GrammarBindingNavigatorSaveItem.Name = "GrammarBindingNavigatorSaveItem"
        Me.GrammarBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GrammarBindingNavigatorSaveItem.Text = "Save Data"
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
        'GrammarDataGridView
        '
        Me.GrammarDataGridView.AutoGenerateColumns = False
        Me.GrammarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrammarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewImageColumn1})
        Me.GrammarDataGridView.DataSource = Me.GrammarBindingSource
        Me.GrammarDataGridView.Location = New System.Drawing.Point(0, 79)
        Me.GrammarDataGridView.Name = "GrammarDataGridView"
        Me.GrammarDataGridView.Size = New System.Drawing.Size(1370, 671)
        Me.GrammarDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Grammar"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Grammar"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 600
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Examples"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Examples"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(759, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(812, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 20)
        Me.TextBox1.TabIndex = 4
        '
        'addgrammar
        '
        Me.addgrammar.Location = New System.Drawing.Point(493, 38)
        Me.addgrammar.Name = "addgrammar"
        Me.addgrammar.Size = New System.Drawing.Size(123, 24)
        Me.addgrammar.TabIndex = 5
        Me.addgrammar.Text = "Add new grammar"
        Me.addgrammar.UseVisualStyleBackColor = True
        '
        'addgrammars
        '
        Me.addgrammars.BackgroundImage = CType(resources.GetObject("addgrammars.BackgroundImage"), System.Drawing.Image)
        Me.addgrammars.Controls.Add(Me.Exitgrammar)
        Me.addgrammars.Controls.Add(IDLabel)
        Me.addgrammars.Controls.Add(Me.IDTextBox)
        Me.addgrammars.Controls.Add(GrammarLabel)
        Me.addgrammars.Controls.Add(Me.GrammarTextBox)
        Me.addgrammars.Controls.Add(ExamplesLabel)
        Me.addgrammars.Controls.Add(Me.ExamplesTextBox)
        Me.addgrammars.Controls.Add(More_infoLabel)
        Me.addgrammars.Controls.Add(Me.More_infoTextBox)
        Me.addgrammars.Controls.Add(CommentLabel)
        Me.addgrammars.Controls.Add(Me.CommentTextBox)
        Me.addgrammars.Controls.Add(PictureLabel)
        Me.addgrammars.Controls.Add(Me.PicturePictureBox)
        Me.addgrammars.Location = New System.Drawing.Point(0, 68)
        Me.addgrammars.Name = "addgrammars"
        Me.addgrammars.Size = New System.Drawing.Size(1485, 724)
        Me.addgrammars.TabIndex = 6
        Me.addgrammars.TabStop = False
        Me.addgrammars.Text = "Add new"
        '
        'Exitgrammar
        '
        Me.Exitgrammar.BackColor = System.Drawing.Color.Transparent
        Me.Exitgrammar.Image = CType(resources.GetObject("Exitgrammar.Image"), System.Drawing.Image)
        Me.Exitgrammar.Location = New System.Drawing.Point(778, 431)
        Me.Exitgrammar.Name = "Exitgrammar"
        Me.Exitgrammar.Size = New System.Drawing.Size(56, 51)
        Me.Exitgrammar.TabIndex = 12
        Me.Exitgrammar.UseVisualStyleBackColor = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GrammarBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(97, 19)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(48, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'GrammarTextBox
        '
        Me.GrammarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GrammarBindingSource, "Grammar", True))
        Me.GrammarTextBox.Location = New System.Drawing.Point(97, 65)
        Me.GrammarTextBox.Multiline = True
        Me.GrammarTextBox.Name = "GrammarTextBox"
        Me.GrammarTextBox.Size = New System.Drawing.Size(300, 165)
        Me.GrammarTextBox.TabIndex = 3
        '
        'ExamplesTextBox
        '
        Me.ExamplesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GrammarBindingSource, "Examples", True))
        Me.ExamplesTextBox.Location = New System.Drawing.Point(97, 271)
        Me.ExamplesTextBox.Multiline = True
        Me.ExamplesTextBox.Name = "ExamplesTextBox"
        Me.ExamplesTextBox.Size = New System.Drawing.Size(300, 79)
        Me.ExamplesTextBox.TabIndex = 5
        '
        'More_infoTextBox
        '
        Me.More_infoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GrammarBindingSource, "More info", True))
        Me.More_infoTextBox.Location = New System.Drawing.Point(475, 217)
        Me.More_infoTextBox.Multiline = True
        Me.More_infoTextBox.Name = "More_infoTextBox"
        Me.More_infoTextBox.Size = New System.Drawing.Size(258, 104)
        Me.More_infoTextBox.TabIndex = 7
        '
        'CommentTextBox
        '
        Me.CommentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GrammarBindingSource, "Comment", True))
        Me.CommentTextBox.Location = New System.Drawing.Point(475, 97)
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(258, 104)
        Me.CommentTextBox.TabIndex = 9
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.GrammarBindingSource, "Picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(852, 68)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(271, 219)
        Me.PicturePictureBox.TabIndex = 11
        Me.PicturePictureBox.TabStop = False
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
        'Grammar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.addgrammars)
        Me.Controls.Add(Me.addgrammar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GrammarDataGridView)
        Me.Controls.Add(Me.GrammarBindingNavigator)
        Me.Controls.Add(Me.retw)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Grammar"
        Me.Text = "Grammar"
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrammarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrammarBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrammarBindingNavigator.ResumeLayout(False)
        Me.GrammarBindingNavigator.PerformLayout()
        CType(Me.GrammarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addgrammars.ResumeLayout(False)
        Me.addgrammars.PerformLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents retw As System.Windows.Forms.Button
    Friend WithEvents SourceDataSet As English.SourceDataSet
    Friend WithEvents GrammarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrammarTableAdapter As English.SourceDataSetTableAdapters.GrammarTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GrammarBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents GrammarBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GrammarDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents addgrammar As System.Windows.Forms.Button
    Friend WithEvents addgrammars As System.Windows.Forms.GroupBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrammarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExamplesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents More_infoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Exitgrammar As System.Windows.Forms.Button
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
