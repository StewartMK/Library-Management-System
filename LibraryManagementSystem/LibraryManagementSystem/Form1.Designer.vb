<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Book_IDLabel As System.Windows.Forms.Label
        Dim Book_Name_Label As System.Windows.Forms.Label
        Dim Book_Author_Label As System.Windows.Forms.Label
        Dim Year_Published_Label As System.Windows.Forms.Label
        Dim Date_BorrowedLabel As System.Windows.Forms.Label
        Dim Due_DateLabel As System.Windows.Forms.Label
        Dim Date_ReturnedLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LibraryTableDataSet = New LibraryManagementSystem.LibraryTableDataSet()
        Me.LibraryTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryTableTableAdapter = New LibraryManagementSystem.LibraryTableDataSetTableAdapters.LibraryTableTableAdapter()
        Me.TableAdapterManager = New LibraryManagementSystem.LibraryTableDataSetTableAdapters.TableAdapterManager()
        Me.LibraryTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LibraryTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.Book_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Book_Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Book_Author_TextBox = New System.Windows.Forms.TextBox()
        Me.Year_Published_TextBox = New System.Windows.Forms.TextBox()
        Me.Date_BorrowedTextBox = New System.Windows.Forms.TextBox()
        Me.Due_DateTextBox = New System.Windows.Forms.TextBox()
        Me.Date_ReturnedTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonNew = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookAuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearPublishedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBorrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Book_IDLabel = New System.Windows.Forms.Label()
        Book_Name_Label = New System.Windows.Forms.Label()
        Book_Author_Label = New System.Windows.Forms.Label()
        Year_Published_Label = New System.Windows.Forms.Label()
        Date_BorrowedLabel = New System.Windows.Forms.Label()
        Due_DateLabel = New System.Windows.Forms.Label()
        Date_ReturnedLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.LibraryTableDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibraryTableBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.Orange
        IDLabel.Location = New System.Drawing.Point(42, 141)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(165, 28)
        IDLabel.TabIndex = 1
        IDLabel.Text = "Student Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.ForeColor = System.Drawing.Color.Orange
        Student_IDLabel.Location = New System.Drawing.Point(42, 192)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(108, 26)
        Student_IDLabel.TabIndex = 3
        Student_IDLabel.Text = "Student ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.ForeColor = System.Drawing.Color.Orange
        First_NameLabel.Location = New System.Drawing.Point(48, 245)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(110, 26)
        First_NameLabel.TabIndex = 5
        First_NameLabel.Text = "First Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.ForeColor = System.Drawing.Color.Orange
        SurnameLabel.Location = New System.Drawing.Point(48, 295)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(91, 26)
        SurnameLabel.TabIndex = 7
        SurnameLabel.Text = "Surname:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.ForeColor = System.Drawing.Color.Orange
        GenderLabel.Location = New System.Drawing.Point(48, 347)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(78, 26)
        GenderLabel.TabIndex = 9
        GenderLabel.Text = "Gender:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.ForeColor = System.Drawing.Color.Orange
        DOBLabel.Location = New System.Drawing.Point(48, 398)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(59, 26)
        DOBLabel.TabIndex = 11
        DOBLabel.Text = "DOB:"
        '
        'Book_IDLabel
        '
        Book_IDLabel.AutoSize = True
        Book_IDLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_IDLabel.ForeColor = System.Drawing.Color.Orange
        Book_IDLabel.Location = New System.Drawing.Point(417, 192)
        Book_IDLabel.Name = "Book_IDLabel"
        Book_IDLabel.Size = New System.Drawing.Size(87, 26)
        Book_IDLabel.TabIndex = 13
        Book_IDLabel.Text = "Book ID:"
        '
        'Book_Name_Label
        '
        Book_Name_Label.AutoSize = True
        Book_Name_Label.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_Name_Label.ForeColor = System.Drawing.Color.Orange
        Book_Name_Label.Location = New System.Drawing.Point(417, 245)
        Book_Name_Label.Name = "Book_Name_Label"
        Book_Name_Label.Size = New System.Drawing.Size(121, 26)
        Book_Name_Label.TabIndex = 15
        Book_Name_Label.Text = "Book Name :"
        '
        'Book_Author_Label
        '
        Book_Author_Label.AutoSize = True
        Book_Author_Label.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Book_Author_Label.ForeColor = System.Drawing.Color.Orange
        Book_Author_Label.Location = New System.Drawing.Point(417, 295)
        Book_Author_Label.Name = "Book_Author_Label"
        Book_Author_Label.Size = New System.Drawing.Size(128, 26)
        Book_Author_Label.TabIndex = 17
        Book_Author_Label.Text = "Book Author :"
        '
        'Year_Published_Label
        '
        Year_Published_Label.AutoSize = True
        Year_Published_Label.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Year_Published_Label.ForeColor = System.Drawing.Color.Orange
        Year_Published_Label.Location = New System.Drawing.Point(417, 347)
        Year_Published_Label.Name = "Year_Published_Label"
        Year_Published_Label.Size = New System.Drawing.Size(147, 26)
        Year_Published_Label.TabIndex = 19
        Year_Published_Label.Text = "Year Published :"
        '
        'Date_BorrowedLabel
        '
        Date_BorrowedLabel.AutoSize = True
        Date_BorrowedLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_BorrowedLabel.ForeColor = System.Drawing.Color.Orange
        Date_BorrowedLabel.Location = New System.Drawing.Point(810, 192)
        Date_BorrowedLabel.Name = "Date_BorrowedLabel"
        Date_BorrowedLabel.Size = New System.Drawing.Size(143, 26)
        Date_BorrowedLabel.TabIndex = 21
        Date_BorrowedLabel.Text = "Date Borrowed:"
        '
        'Due_DateLabel
        '
        Due_DateLabel.AutoSize = True
        Due_DateLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Due_DateLabel.ForeColor = System.Drawing.Color.Orange
        Due_DateLabel.Location = New System.Drawing.Point(810, 242)
        Due_DateLabel.Name = "Due_DateLabel"
        Due_DateLabel.Size = New System.Drawing.Size(96, 26)
        Due_DateLabel.TabIndex = 23
        Due_DateLabel.Text = "Due Date:"
        '
        'Date_ReturnedLabel
        '
        Date_ReturnedLabel.AutoSize = True
        Date_ReturnedLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_ReturnedLabel.ForeColor = System.Drawing.Color.Orange
        Date_ReturnedLabel.Location = New System.Drawing.Point(810, 291)
        Date_ReturnedLabel.Name = "Date_ReturnedLabel"
        Date_ReturnedLabel.Size = New System.Drawing.Size(138, 26)
        Date_ReturnedLabel.TabIndex = 25
        Date_ReturnedLabel.Text = "Date Returned:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Orange
        Label2.Location = New System.Drawing.Point(417, 141)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(137, 28)
        Label2.TabIndex = 28
        Label2.Text = "Book Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Orange
        Label3.Location = New System.Drawing.Point(810, 141)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(109, 28)
        Label3.TabIndex = 29
        Label3.Text = "Loan Info" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LibraryTableDataSet
        '
        Me.LibraryTableDataSet.DataSetName = "LibraryTableDataSet"
        Me.LibraryTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryTableBindingSource
        '
        Me.LibraryTableBindingSource.DataMember = "LibraryTable"
        Me.LibraryTableBindingSource.DataSource = Me.LibraryTableDataSet
        '
        'LibraryTableTableAdapter
        '
        Me.LibraryTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LibraryTableTableAdapter = Me.LibraryTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = LibraryManagementSystem.LibraryTableDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LibraryTableBindingNavigator
        '
        Me.LibraryTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LibraryTableBindingNavigator.BindingSource = Me.LibraryTableBindingSource
        Me.LibraryTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LibraryTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LibraryTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LibraryTableBindingNavigatorSaveItem})
        Me.LibraryTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LibraryTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LibraryTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LibraryTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LibraryTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LibraryTableBindingNavigator.Name = "LibraryTableBindingNavigator"
        Me.LibraryTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LibraryTableBindingNavigator.Size = New System.Drawing.Size(1142, 25)
        Me.LibraryTableBindingNavigator.TabIndex = 0
        Me.LibraryTableBindingNavigator.Text = "BindingNavigator1"
        Me.LibraryTableBindingNavigator.Visible = False
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'LibraryTableBindingNavigatorSaveItem
        '
        Me.LibraryTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibraryTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("LibraryTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LibraryTableBindingNavigatorSaveItem.Name = "LibraryTableBindingNavigatorSaveItem"
        Me.LibraryTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LibraryTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Student ID", True))
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(176, 192)
        Me.Student_IDTextBox.Multiline = True
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(166, 26)
        Me.Student_IDTextBox.TabIndex = 4
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(176, 245)
        Me.First_NameTextBox.Multiline = True
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(166, 26)
        Me.First_NameTextBox.TabIndex = 6
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(176, 295)
        Me.SurnameTextBox.Multiline = True
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(166, 26)
        Me.SurnameTextBox.TabIndex = 8
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(176, 347)
        Me.GenderTextBox.Multiline = True
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(166, 26)
        Me.GenderTextBox.TabIndex = 10
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "DOB", True))
        Me.DOBTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBTextBox.Location = New System.Drawing.Point(176, 395)
        Me.DOBTextBox.Multiline = True
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(166, 29)
        Me.DOBTextBox.TabIndex = 12
        '
        'Book_IDTextBox
        '
        Me.Book_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Book ID", True))
        Me.Book_IDTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_IDTextBox.Location = New System.Drawing.Point(570, 189)
        Me.Book_IDTextBox.Multiline = True
        Me.Book_IDTextBox.Name = "Book_IDTextBox"
        Me.Book_IDTextBox.Size = New System.Drawing.Size(177, 26)
        Me.Book_IDTextBox.TabIndex = 14
        '
        'Book_Name_TextBox
        '
        Me.Book_Name_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Book Name ", True))
        Me.Book_Name_TextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_Name_TextBox.Location = New System.Drawing.Point(570, 244)
        Me.Book_Name_TextBox.Multiline = True
        Me.Book_Name_TextBox.Name = "Book_Name_TextBox"
        Me.Book_Name_TextBox.Size = New System.Drawing.Size(177, 26)
        Me.Book_Name_TextBox.TabIndex = 16
        '
        'Book_Author_TextBox
        '
        Me.Book_Author_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Book Author ", True))
        Me.Book_Author_TextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_Author_TextBox.Location = New System.Drawing.Point(570, 291)
        Me.Book_Author_TextBox.Multiline = True
        Me.Book_Author_TextBox.Name = "Book_Author_TextBox"
        Me.Book_Author_TextBox.Size = New System.Drawing.Size(177, 28)
        Me.Book_Author_TextBox.TabIndex = 18
        '
        'Year_Published_TextBox
        '
        Me.Year_Published_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Year Published ", True))
        Me.Year_Published_TextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year_Published_TextBox.Location = New System.Drawing.Point(570, 344)
        Me.Year_Published_TextBox.Multiline = True
        Me.Year_Published_TextBox.Name = "Year_Published_TextBox"
        Me.Year_Published_TextBox.Size = New System.Drawing.Size(177, 29)
        Me.Year_Published_TextBox.TabIndex = 20
        '
        'Date_BorrowedTextBox
        '
        Me.Date_BorrowedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Date Borrowed", True))
        Me.Date_BorrowedTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_BorrowedTextBox.Location = New System.Drawing.Point(959, 189)
        Me.Date_BorrowedTextBox.Multiline = True
        Me.Date_BorrowedTextBox.Name = "Date_BorrowedTextBox"
        Me.Date_BorrowedTextBox.Size = New System.Drawing.Size(145, 26)
        Me.Date_BorrowedTextBox.TabIndex = 22
        '
        'Due_DateTextBox
        '
        Me.Due_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Due Date", True))
        Me.Due_DateTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Due_DateTextBox.Location = New System.Drawing.Point(959, 242)
        Me.Due_DateTextBox.Multiline = True
        Me.Due_DateTextBox.Name = "Due_DateTextBox"
        Me.Due_DateTextBox.Size = New System.Drawing.Size(145, 26)
        Me.Due_DateTextBox.TabIndex = 24
        '
        'Date_ReturnedTextBox
        '
        Me.Date_ReturnedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTableBindingSource, "Date Returned", True))
        Me.Date_ReturnedTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_ReturnedTextBox.Location = New System.Drawing.Point(959, 290)
        Me.Date_ReturnedTextBox.Multiline = True
        Me.Date_ReturnedTextBox.Name = "Date_ReturnedTextBox"
        Me.Date_ReturnedTextBox.Size = New System.Drawing.Size(145, 27)
        Me.Date_ReturnedTextBox.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("News701 BT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(244, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(662, 39)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Dz 1 High Library Management System"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.Color.Green
        Me.ButtonAdd.Location = New System.Drawing.Point(61, 461)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(122, 29)
        Me.ButtonAdd.TabIndex = 30
        Me.ButtonAdd.Text = "Add Student"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.Red
        Me.ButtonDelete.Location = New System.Drawing.Point(189, 461)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(151, 29)
        Me.ButtonDelete.TabIndex = 31
        Me.ButtonDelete.Text = "Delete Student"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonNew
        '
        Me.ButtonNew.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNew.ForeColor = System.Drawing.Color.Blue
        Me.ButtonNew.Location = New System.Drawing.Point(131, 552)
        Me.ButtonNew.Name = "ButtonNew"
        Me.ButtonNew.Size = New System.Drawing.Size(122, 29)
        Me.ButtonNew.TabIndex = 32
        Me.ButtonNew.Text = "New"
        Me.ButtonNew.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Button3.Location = New System.Drawing.Point(199, 509)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 37)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Button4.Location = New System.Drawing.Point(144, 509)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 37)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.BookIDDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.BookAuthorDataGridViewTextBoxColumn, Me.YearPublishedDataGridViewTextBoxColumn, Me.DateBorrowedDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn, Me.DateReturnedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LibraryTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(422, 399)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(682, 202)
        Me.DataGridView1.TabIndex = 35
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name "
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "Book Name "
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        '
        'BookAuthorDataGridViewTextBoxColumn
        '
        Me.BookAuthorDataGridViewTextBoxColumn.DataPropertyName = "Book Author "
        Me.BookAuthorDataGridViewTextBoxColumn.HeaderText = "Book Author "
        Me.BookAuthorDataGridViewTextBoxColumn.Name = "BookAuthorDataGridViewTextBoxColumn"
        '
        'YearPublishedDataGridViewTextBoxColumn
        '
        Me.YearPublishedDataGridViewTextBoxColumn.DataPropertyName = "Year Published "
        Me.YearPublishedDataGridViewTextBoxColumn.HeaderText = "Year Published "
        Me.YearPublishedDataGridViewTextBoxColumn.Name = "YearPublishedDataGridViewTextBoxColumn"
        '
        'DateBorrowedDataGridViewTextBoxColumn
        '
        Me.DateBorrowedDataGridViewTextBoxColumn.DataPropertyName = "Date Borrowed"
        Me.DateBorrowedDataGridViewTextBoxColumn.HeaderText = "Date Borrowed"
        Me.DateBorrowedDataGridViewTextBoxColumn.Name = "DateBorrowedDataGridViewTextBoxColumn"
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "Due Date"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "Due Date"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        '
        'DateReturnedDataGridViewTextBoxColumn
        '
        Me.DateReturnedDataGridViewTextBoxColumn.DataPropertyName = "Date Returned"
        Me.DateReturnedDataGridViewTextBoxColumn.HeaderText = "Date Returned"
        Me.DateReturnedDataGridViewTextBoxColumn.Name = "DateReturnedDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1142, 613)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonNew)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBTextBox)
        Me.Controls.Add(Book_IDLabel)
        Me.Controls.Add(Me.Book_IDTextBox)
        Me.Controls.Add(Book_Name_Label)
        Me.Controls.Add(Me.Book_Name_TextBox)
        Me.Controls.Add(Book_Author_Label)
        Me.Controls.Add(Me.Book_Author_TextBox)
        Me.Controls.Add(Year_Published_Label)
        Me.Controls.Add(Me.Year_Published_TextBox)
        Me.Controls.Add(Date_BorrowedLabel)
        Me.Controls.Add(Me.Date_BorrowedTextBox)
        Me.Controls.Add(Due_DateLabel)
        Me.Controls.Add(Me.Due_DateTextBox)
        Me.Controls.Add(Date_ReturnedLabel)
        Me.Controls.Add(Me.Date_ReturnedTextBox)
        Me.Controls.Add(Me.LibraryTableBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dz 1 High LIbrary Management System"
        CType(Me.LibraryTableDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibraryTableBindingNavigator.ResumeLayout(False)
        Me.LibraryTableBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LibraryTableDataSet As LibraryTableDataSet
    Friend WithEvents LibraryTableBindingSource As BindingSource
    Friend WithEvents LibraryTableTableAdapter As LibraryTableDataSetTableAdapters.LibraryTableTableAdapter
    Friend WithEvents TableAdapterManager As LibraryTableDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibraryTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LibraryTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents DOBTextBox As TextBox
    Friend WithEvents Book_IDTextBox As TextBox
    Friend WithEvents Book_Name_TextBox As TextBox
    Friend WithEvents Book_Author_TextBox As TextBox
    Friend WithEvents Year_Published_TextBox As TextBox
    Friend WithEvents Date_BorrowedTextBox As TextBox
    Friend WithEvents Due_DateTextBox As TextBox
    Friend WithEvents Date_ReturnedTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonNew As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookAuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearPublishedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateBorrowedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReturnedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
