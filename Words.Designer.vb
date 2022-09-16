<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Words
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
        Dim VerbLabel As System.Windows.Forms.Label
        Dim NounLabel As System.Windows.Forms.Label
        Dim AdjectiveLabel As System.Windows.Forms.Label
        Dim DefinitionLabel As System.Windows.Forms.Label
        Dim Example_of_verbLabel As System.Windows.Forms.Label
        Dim Example_of_NounLabel As System.Windows.Forms.Label
        Dim Example_of_AdjectiveLabel As System.Windows.Forms.Label
        Dim AdverbLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim More_infoLabel As System.Windows.Forms.Label
        Dim Written_dateLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Words))
        Me.Stuff = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Others = New System.Windows.Forms.Button()
        Me.WordsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.WordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDataSet = New English.SourceDataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Addnewwords = New System.Windows.Forms.GroupBox()
        Me.Exitwords = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.VerbTextBox = New System.Windows.Forms.TextBox()
        Me.NounTextBox = New System.Windows.Forms.TextBox()
        Me.AdjectiveTextBox = New System.Windows.Forms.TextBox()
        Me.DefinitionTextBox = New System.Windows.Forms.TextBox()
        Me.SynonymTextBox = New System.Windows.Forms.TextBox()
        Me.OppositeTextBox = New System.Windows.Forms.TextBox()
        Me.Example_of_verbTextBox = New System.Windows.Forms.TextBox()
        Me.Example_of_NounTextBox = New System.Windows.Forms.TextBox()
        Me.Example_of_AdjectiveTextBox = New System.Windows.Forms.TextBox()
        Me.AdverbTextBox = New System.Windows.Forms.TextBox()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.More_infoTextBox = New System.Windows.Forms.TextBox()
        Me.Written_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.WordsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.WordsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.WordsTableAdapter = New English.SourceDataSetTableAdapters.WordsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        VerbLabel = New System.Windows.Forms.Label()
        NounLabel = New System.Windows.Forms.Label()
        AdjectiveLabel = New System.Windows.Forms.Label()
        DefinitionLabel = New System.Windows.Forms.Label()
        Example_of_verbLabel = New System.Windows.Forms.Label()
        Example_of_NounLabel = New System.Windows.Forms.Label()
        Example_of_AdjectiveLabel = New System.Windows.Forms.Label()
        AdverbLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        More_infoLabel = New System.Windows.Forms.Label()
        Written_dateLabel = New System.Windows.Forms.Label()
        PictureLabel = New System.Windows.Forms.Label()
        Me.Stuff.SuspendLayout()
        CType(Me.WordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Addnewwords.SuspendLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WordsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WordsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(205, 44)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(22, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'VerbLabel
        '
        VerbLabel.AutoSize = True
        VerbLabel.Location = New System.Drawing.Point(205, 124)
        VerbLabel.Name = "VerbLabel"
        VerbLabel.Size = New System.Drawing.Size(33, 13)
        VerbLabel.TabIndex = 3
        VerbLabel.Text = "Verb:"
        '
        'NounLabel
        '
        NounLabel.AutoSize = True
        NounLabel.Location = New System.Drawing.Point(205, 150)
        NounLabel.Name = "NounLabel"
        NounLabel.Size = New System.Drawing.Size(36, 13)
        NounLabel.TabIndex = 5
        NounLabel.Text = "Noun:"
        '
        'AdjectiveLabel
        '
        AdjectiveLabel.AutoSize = True
        AdjectiveLabel.Location = New System.Drawing.Point(205, 176)
        AdjectiveLabel.Name = "AdjectiveLabel"
        AdjectiveLabel.Size = New System.Drawing.Size(56, 13)
        AdjectiveLabel.TabIndex = 7
        AdjectiveLabel.Text = "Adjective:"
        '
        'DefinitionLabel
        '
        DefinitionLabel.AutoSize = True
        DefinitionLabel.Location = New System.Drawing.Point(205, 202)
        DefinitionLabel.Name = "DefinitionLabel"
        DefinitionLabel.Size = New System.Drawing.Size(56, 13)
        DefinitionLabel.TabIndex = 9
        DefinitionLabel.Text = "Definition:"
        '
        'Example_of_verbLabel
        '
        Example_of_verbLabel.AutoSize = True
        Example_of_verbLabel.Location = New System.Drawing.Point(205, 357)
        Example_of_verbLabel.Name = "Example_of_verbLabel"
        Example_of_verbLabel.Size = New System.Drawing.Size(89, 13)
        Example_of_verbLabel.TabIndex = 15
        Example_of_verbLabel.Text = "Example of verb:"
        '
        'Example_of_NounLabel
        '
        Example_of_NounLabel.AutoSize = True
        Example_of_NounLabel.Location = New System.Drawing.Point(214, 433)
        Example_of_NounLabel.Name = "Example_of_NounLabel"
        Example_of_NounLabel.Size = New System.Drawing.Size(92, 13)
        Example_of_NounLabel.TabIndex = 17
        Example_of_NounLabel.Text = "Example of Noun:"
        '
        'Example_of_AdjectiveLabel
        '
        Example_of_AdjectiveLabel.AutoSize = True
        Example_of_AdjectiveLabel.Location = New System.Drawing.Point(205, 489)
        Example_of_AdjectiveLabel.Name = "Example_of_AdjectiveLabel"
        Example_of_AdjectiveLabel.Size = New System.Drawing.Size(112, 13)
        Example_of_AdjectiveLabel.TabIndex = 19
        Example_of_AdjectiveLabel.Text = "Example of Adjective:"
        '
        'AdverbLabel
        '
        AdverbLabel.AutoSize = True
        AdverbLabel.Location = New System.Drawing.Point(662, 199)
        AdverbLabel.Name = "AdverbLabel"
        AdverbLabel.Size = New System.Drawing.Size(46, 13)
        AdverbLabel.TabIndex = 21
        AdverbLabel.Text = "Adverb:"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(662, 246)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(56, 13)
        CommentLabel.TabIndex = 23
        CommentLabel.Text = "Comment:"
        '
        'More_infoLabel
        '
        More_infoLabel.AutoSize = True
        More_infoLabel.Location = New System.Drawing.Point(662, 378)
        More_infoLabel.Name = "More_infoLabel"
        More_infoLabel.Size = New System.Drawing.Size(56, 13)
        More_infoLabel.TabIndex = 25
        More_infoLabel.Text = "More info:"
        '
        'Written_dateLabel
        '
        Written_dateLabel.AutoSize = True
        Written_dateLabel.Location = New System.Drawing.Point(990, 169)
        Written_dateLabel.Name = "Written_dateLabel"
        Written_dateLabel.Size = New System.Drawing.Size(72, 13)
        Written_dateLabel.TabIndex = 27
        Written_dateLabel.Text = "Written date:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Location = New System.Drawing.Point(990, 191)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(44, 13)
        PictureLabel.TabIndex = 29
        PictureLabel.Text = "Picture:"
        '
        'Stuff
        '
        Me.Stuff.BackgroundImage = CType(resources.GetObject("Stuff.BackgroundImage"), System.Drawing.Image)
        Me.Stuff.Controls.Add(Me.Button3)
        Me.Stuff.Controls.Add(Me.Button2)
        Me.Stuff.Controls.Add(Me.Button1)
        Me.Stuff.Location = New System.Drawing.Point(2, 60)
        Me.Stuff.Name = "Stuff"
        Me.Stuff.Size = New System.Drawing.Size(1350, 650)
        Me.Stuff.TabIndex = 0
        Me.Stuff.TabStop = False
        Me.Stuff.Text = "Add new"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(922, 434)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(58, 57)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.Location = New System.Drawing.Point(371, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(511, 166)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Tips"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Bisque
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Button1.Location = New System.Drawing.Point(371, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(498, 156)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Grammar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Others
        '
        Me.Others.Location = New System.Drawing.Point(434, 27)
        Me.Others.Name = "Others"
        Me.Others.Size = New System.Drawing.Size(156, 27)
        Me.Others.TabIndex = 1
        Me.Others.Text = "Other stuff"
        Me.Others.UseVisualStyleBackColor = True
        '
        'WordsDataGridView
        '
        Me.WordsDataGridView.AutoGenerateColumns = False
        Me.WordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewImageColumn1})
        Me.WordsDataGridView.DataSource = Me.WordsBindingSource
        Me.WordsDataGridView.Location = New System.Drawing.Point(2, 69)
        Me.WordsDataGridView.Name = "WordsDataGridView"
        Me.WordsDataGridView.Size = New System.Drawing.Size(1556, 680)
        Me.WordsDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Verb"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Verb"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Noun"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Noun"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Adjective"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Adjective"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Definition"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Definition"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Synonym"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Synonym"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Opposite"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Opposite"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Example of verb"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Example of verb"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Example of Noun"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Example of Noun"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Example of Adjective"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Example of Adjective"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Adverb"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Adverb"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "More info"
        Me.DataGridViewTextBoxColumn13.HeaderText = "More info"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Written date"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Written date"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Picture"
        Me.DataGridViewImageColumn1.HeaderText = "Picture"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'WordsBindingSource
        '
        Me.WordsBindingSource.DataMember = "Words"
        Me.WordsBindingSource.DataSource = Me.SourceDataSet
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "SourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(635, 27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(156, 27)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Add new word"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Addnewwords
        '
        Me.Addnewwords.BackgroundImage = CType(resources.GetObject("Addnewwords.BackgroundImage"), System.Drawing.Image)
        Me.Addnewwords.Controls.Add(Me.Exitwords)
        Me.Addnewwords.Controls.Add(IDLabel)
        Me.Addnewwords.Controls.Add(Me.IDTextBox)
        Me.Addnewwords.Controls.Add(VerbLabel)
        Me.Addnewwords.Controls.Add(Me.VerbTextBox)
        Me.Addnewwords.Controls.Add(NounLabel)
        Me.Addnewwords.Controls.Add(Me.NounTextBox)
        Me.Addnewwords.Controls.Add(AdjectiveLabel)
        Me.Addnewwords.Controls.Add(Me.AdjectiveTextBox)
        Me.Addnewwords.Controls.Add(DefinitionLabel)
        Me.Addnewwords.Controls.Add(Me.DefinitionTextBox)
        Me.Addnewwords.Controls.Add(Me.SynonymTextBox)
        Me.Addnewwords.Controls.Add(Me.OppositeTextBox)
        Me.Addnewwords.Controls.Add(Example_of_verbLabel)
        Me.Addnewwords.Controls.Add(Me.Example_of_verbTextBox)
        Me.Addnewwords.Controls.Add(Example_of_NounLabel)
        Me.Addnewwords.Controls.Add(Me.Example_of_NounTextBox)
        Me.Addnewwords.Controls.Add(Example_of_AdjectiveLabel)
        Me.Addnewwords.Controls.Add(Me.Example_of_AdjectiveTextBox)
        Me.Addnewwords.Controls.Add(AdverbLabel)
        Me.Addnewwords.Controls.Add(Me.AdverbTextBox)
        Me.Addnewwords.Controls.Add(CommentLabel)
        Me.Addnewwords.Controls.Add(Me.CommentTextBox)
        Me.Addnewwords.Controls.Add(More_infoLabel)
        Me.Addnewwords.Controls.Add(Me.More_infoTextBox)
        Me.Addnewwords.Controls.Add(Written_dateLabel)
        Me.Addnewwords.Controls.Add(Me.Written_dateDateTimePicker)
        Me.Addnewwords.Controls.Add(PictureLabel)
        Me.Addnewwords.Controls.Add(Me.PicturePictureBox)
        Me.Addnewwords.Location = New System.Drawing.Point(2, 27)
        Me.Addnewwords.Name = "Addnewwords"
        Me.Addnewwords.Size = New System.Drawing.Size(1370, 722)
        Me.Addnewwords.TabIndex = 5
        Me.Addnewwords.TabStop = False
        Me.Addnewwords.Text = "Add new word"
        '
        'Exitwords
        '
        Me.Exitwords.Image = CType(resources.GetObject("Exitwords.Image"), System.Drawing.Image)
        Me.Exitwords.Location = New System.Drawing.Point(1097, 449)
        Me.Exitwords.Name = "Exitwords"
        Me.Exitwords.Size = New System.Drawing.Size(58, 53)
        Me.Exitwords.TabIndex = 31
        Me.Exitwords.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(323, 41)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(36, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'VerbTextBox
        '
        Me.VerbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Verb", True))
        Me.VerbTextBox.Location = New System.Drawing.Point(323, 121)
        Me.VerbTextBox.Name = "VerbTextBox"
        Me.VerbTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VerbTextBox.TabIndex = 4
        '
        'NounTextBox
        '
        Me.NounTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Noun", True))
        Me.NounTextBox.Location = New System.Drawing.Point(323, 147)
        Me.NounTextBox.Name = "NounTextBox"
        Me.NounTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NounTextBox.TabIndex = 6
        '
        'AdjectiveTextBox
        '
        Me.AdjectiveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Adjective", True))
        Me.AdjectiveTextBox.Location = New System.Drawing.Point(323, 173)
        Me.AdjectiveTextBox.Name = "AdjectiveTextBox"
        Me.AdjectiveTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AdjectiveTextBox.TabIndex = 8
        '
        'DefinitionTextBox
        '
        Me.DefinitionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Definition", True))
        Me.DefinitionTextBox.Location = New System.Drawing.Point(323, 199)
        Me.DefinitionTextBox.Multiline = True
        Me.DefinitionTextBox.Name = "DefinitionTextBox"
        Me.DefinitionTextBox.Size = New System.Drawing.Size(275, 142)
        Me.DefinitionTextBox.TabIndex = 10
        '
        'SynonymTextBox
        '
        Me.SynonymTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Synonym", True))
        Me.SynonymTextBox.Location = New System.Drawing.Point(591, 119)
        Me.SynonymTextBox.Name = "SynonymTextBox"
        Me.SynonymTextBox.Size = New System.Drawing.Size(96, 20)
        Me.SynonymTextBox.TabIndex = 12
        '
        'OppositeTextBox
        '
        Me.OppositeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Opposite", True))
        Me.OppositeTextBox.Location = New System.Drawing.Point(732, 117)
        Me.OppositeTextBox.Name = "OppositeTextBox"
        Me.OppositeTextBox.Size = New System.Drawing.Size(96, 20)
        Me.OppositeTextBox.TabIndex = 14
        '
        'Example_of_verbTextBox
        '
        Me.Example_of_verbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Example of verb", True))
        Me.Example_of_verbTextBox.Location = New System.Drawing.Point(323, 354)
        Me.Example_of_verbTextBox.Multiline = True
        Me.Example_of_verbTextBox.Name = "Example_of_verbTextBox"
        Me.Example_of_verbTextBox.Size = New System.Drawing.Size(275, 60)
        Me.Example_of_verbTextBox.TabIndex = 16
        '
        'Example_of_NounTextBox
        '
        Me.Example_of_NounTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Example of Noun", True))
        Me.Example_of_NounTextBox.Location = New System.Drawing.Point(323, 420)
        Me.Example_of_NounTextBox.Multiline = True
        Me.Example_of_NounTextBox.Name = "Example_of_NounTextBox"
        Me.Example_of_NounTextBox.Size = New System.Drawing.Size(275, 60)
        Me.Example_of_NounTextBox.TabIndex = 18
        '
        'Example_of_AdjectiveTextBox
        '
        Me.Example_of_AdjectiveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Example of Adjective", True))
        Me.Example_of_AdjectiveTextBox.Location = New System.Drawing.Point(323, 486)
        Me.Example_of_AdjectiveTextBox.Multiline = True
        Me.Example_of_AdjectiveTextBox.Name = "Example_of_AdjectiveTextBox"
        Me.Example_of_AdjectiveTextBox.Size = New System.Drawing.Size(275, 60)
        Me.Example_of_AdjectiveTextBox.TabIndex = 20
        '
        'AdverbTextBox
        '
        Me.AdverbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Adverb", True))
        Me.AdverbTextBox.Location = New System.Drawing.Point(780, 196)
        Me.AdverbTextBox.Name = "AdverbTextBox"
        Me.AdverbTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AdverbTextBox.TabIndex = 22
        '
        'CommentTextBox
        '
        Me.CommentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "Comment", True))
        Me.CommentTextBox.Location = New System.Drawing.Point(780, 243)
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(254, 116)
        Me.CommentTextBox.TabIndex = 24
        '
        'More_infoTextBox
        '
        Me.More_infoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WordsBindingSource, "More info", True))
        Me.More_infoTextBox.Location = New System.Drawing.Point(780, 375)
        Me.More_infoTextBox.Multiline = True
        Me.More_infoTextBox.Name = "More_infoTextBox"
        Me.More_infoTextBox.Size = New System.Drawing.Size(264, 116)
        Me.More_infoTextBox.TabIndex = 26
        '
        'Written_dateDateTimePicker
        '
        Me.Written_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WordsBindingSource, "Written date", True))
        Me.Written_dateDateTimePicker.Location = New System.Drawing.Point(1108, 165)
        Me.Written_dateDateTimePicker.Name = "Written_dateDateTimePicker"
        Me.Written_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Written_dateDateTimePicker.TabIndex = 28
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.WordsBindingSource, "Picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(1108, 191)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(200, 154)
        Me.PicturePictureBox.TabIndex = 30
        Me.PicturePictureBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(890, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 20)
        Me.TextBox1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(843, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'WordsBindingNavigatorSaveItem
        '
        Me.WordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WordsBindingNavigatorSaveItem.Image = CType(resources.GetObject("WordsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WordsBindingNavigatorSaveItem.Name = "WordsBindingNavigatorSaveItem"
        Me.WordsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WordsBindingNavigatorSaveItem.Text = "Save Data"
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
        'WordsBindingNavigator
        '
        Me.WordsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WordsBindingNavigator.BindingSource = Me.WordsBindingSource
        Me.WordsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WordsBindingNavigator.DeleteItem = Nothing
        Me.WordsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.WordsBindingNavigatorSaveItem, Me.NewToolStripButton, Me.OpenToolStripButton, Me.PrintToolStripButton})
        Me.WordsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WordsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WordsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WordsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WordsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WordsBindingNavigator.Name = "WordsBindingNavigator"
        Me.WordsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WordsBindingNavigator.Size = New System.Drawing.Size(1558, 25)
        Me.WordsBindingNavigator.TabIndex = 2
        Me.WordsBindingNavigator.Text = "BindingNavigator1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'WordsTableAdapter
        '
        Me.WordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GrammarTableAdapter = Nothing
        Me.TableAdapterManager.TipsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WordsTableAdapter = Me.WordsTableAdapter
        '
        'Words
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Addnewwords)
        Me.Controls.Add(Me.Stuff)
        Me.Controls.Add(Me.WordsDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.WordsBindingNavigator)
        Me.Controls.Add(Me.Others)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Words"
        Me.Text = "Words"
        Me.Stuff.ResumeLayout(False)
        CType(Me.WordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Addnewwords.ResumeLayout(False)
        Me.Addnewwords.PerformLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WordsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WordsBindingNavigator.ResumeLayout(False)
        Me.WordsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Stuff As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Others As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SourceDataSet As English.SourceDataSet
    Friend WithEvents WordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WordsTableAdapter As English.SourceDataSetTableAdapters.WordsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.SourceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WordsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Addnewwords As System.Windows.Forms.GroupBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VerbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NounTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdjectiveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefinitionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SynonymTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OppositeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Example_of_verbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Example_of_NounTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Example_of_AdjectiveTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdverbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents More_infoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Written_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Exitwords As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents WordsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents WordsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
