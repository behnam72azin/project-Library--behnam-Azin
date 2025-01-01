namespace Library_Management
{
    partial class books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.information = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mozoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.entesharatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numchapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tozihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new Library_Management.LibraryDataSet1();
            this.libraryDataSet = new Library_Management.LibraryDataSet();
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Library_Management.LibraryDataSetTableAdapters.usersTableAdapter();
            this.booksTableAdapter = new Library_Management.LibraryDataSet1TableAdapters.booksTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbookDataGridViewTextBoxColumn,
            this.presentDataGridViewCheckBoxColumn,
            this.namebookDataGridViewTextBoxColumn,
            this.nevbookDataGridViewTextBoxColumn,
            this.information,
            this.edit,
            this.delete,
            this.mozoDataGridViewTextBoxColumn,
            this.entesharatDataGridViewTextBoxColumn,
            this.numchapDataGridViewTextBoxColumn,
            this.motbookDataGridViewTextBoxColumn,
            this.tozihDataGridViewTextBoxColumn,
            this.khbookDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.addressbookDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(784, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idbookDataGridViewTextBoxColumn
            // 
            this.idbookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idbookDataGridViewTextBoxColumn.DataPropertyName = "Id_book";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.idbookDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idbookDataGridViewTextBoxColumn.HeaderText = "شناسه کتاب";
            this.idbookDataGridViewTextBoxColumn.Name = "idbookDataGridViewTextBoxColumn";
            this.idbookDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbookDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idbookDataGridViewTextBoxColumn.Width = 91;
            // 
            // presentDataGridViewCheckBoxColumn
            // 
            this.presentDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.presentDataGridViewCheckBoxColumn.DataPropertyName = "present";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.presentDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.presentDataGridViewCheckBoxColumn.HeaderText = "شناسه کاربر امانت گیرنده";
            this.presentDataGridViewCheckBoxColumn.Name = "presentDataGridViewCheckBoxColumn";
            this.presentDataGridViewCheckBoxColumn.ReadOnly = true;
            this.presentDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.presentDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.presentDataGridViewCheckBoxColumn.Width = 130;
            // 
            // namebookDataGridViewTextBoxColumn
            // 
            this.namebookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namebookDataGridViewTextBoxColumn.DataPropertyName = "name_book";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.namebookDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.namebookDataGridViewTextBoxColumn.HeaderText = "نام کتاب";
            this.namebookDataGridViewTextBoxColumn.Name = "namebookDataGridViewTextBoxColumn";
            this.namebookDataGridViewTextBoxColumn.Width = 69;
            // 
            // nevbookDataGridViewTextBoxColumn
            // 
            this.nevbookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nevbookDataGridViewTextBoxColumn.DataPropertyName = "nev_book";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.nevbookDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nevbookDataGridViewTextBoxColumn.HeaderText = "نام نویسنده";
            this.nevbookDataGridViewTextBoxColumn.Name = "nevbookDataGridViewTextBoxColumn";
            this.nevbookDataGridViewTextBoxColumn.Width = 86;
            // 
            // information
            // 
            this.information.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.information.HeaderText = "";
            this.information.Name = "information";
            this.information.Text = "اطلاعات کامل";
            this.information.ToolTipText = "اطلاعات کامل";
            this.information.UseColumnTextForButtonValue = true;
            this.information.Width = 5;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "ویرایش کتاب";
            this.edit.Name = "edit";
            this.edit.Text = "ثبت تغییرات";
            this.edit.ToolTipText = "ثبت تغییرات";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 70;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.Text = "حذف کتاب";
            this.delete.ToolTipText = "حذف کتاب";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 5;
            // 
            // mozoDataGridViewTextBoxColumn
            // 
            this.mozoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mozoDataGridViewTextBoxColumn.DataPropertyName = "mozo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mozoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.mozoDataGridViewTextBoxColumn.HeaderText = "موضوع";
            this.mozoDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "رمان",
            "پزشکی",
            "تاریخی",
            "اجتماعی و سیاسی",
            "کودکان",
            "علمی دانشگاهی",
            "کتاب درسی",
            "کامپیوتر",
            "زبان خارجی",
            "مذهبی",
            "ادبیات و شعر",
            "ورزشی",
            "هنر",
            "جغرافیا و نقشه",
            "نقد و بررسی",
            "فیلم نامه و نمایش نامه",
            "فلسفه و منطق",
            "متفرقه ..."});
            this.mozoDataGridViewTextBoxColumn.Name = "mozoDataGridViewTextBoxColumn";
            this.mozoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mozoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mozoDataGridViewTextBoxColumn.Width = 64;
            // 
            // entesharatDataGridViewTextBoxColumn
            // 
            this.entesharatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.entesharatDataGridViewTextBoxColumn.DataPropertyName = "entesharat";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.entesharatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.entesharatDataGridViewTextBoxColumn.HeaderText = "نام انتشارات";
            this.entesharatDataGridViewTextBoxColumn.Name = "entesharatDataGridViewTextBoxColumn";
            this.entesharatDataGridViewTextBoxColumn.Width = 89;
            // 
            // numchapDataGridViewTextBoxColumn
            // 
            this.numchapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numchapDataGridViewTextBoxColumn.DataPropertyName = "num_chap";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F);
            this.numchapDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.numchapDataGridViewTextBoxColumn.HeaderText = "شماره چاپ";
            this.numchapDataGridViewTextBoxColumn.Name = "numchapDataGridViewTextBoxColumn";
            this.numchapDataGridViewTextBoxColumn.Width = 84;
            // 
            // motbookDataGridViewTextBoxColumn
            // 
            this.motbookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.motbookDataGridViewTextBoxColumn.DataPropertyName = "mot_book";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F);
            this.motbookDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.motbookDataGridViewTextBoxColumn.HeaderText = "نام مترجم";
            this.motbookDataGridViewTextBoxColumn.Name = "motbookDataGridViewTextBoxColumn";
            this.motbookDataGridViewTextBoxColumn.Width = 78;
            // 
            // tozihDataGridViewTextBoxColumn
            // 
            this.tozihDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tozihDataGridViewTextBoxColumn.DataPropertyName = "tozih";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tozihDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.tozihDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.tozihDataGridViewTextBoxColumn.Name = "tozihDataGridViewTextBoxColumn";
            this.tozihDataGridViewTextBoxColumn.Width = 72;
            // 
            // khbookDataGridViewTextBoxColumn
            // 
            this.khbookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.khbookDataGridViewTextBoxColumn.DataPropertyName = "kh_book";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.khbookDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.khbookDataGridViewTextBoxColumn.HeaderText = "خلاصه کتاب";
            this.khbookDataGridViewTextBoxColumn.Name = "khbookDataGridViewTextBoxColumn";
            this.khbookDataGridViewTextBoxColumn.Width = 86;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.isbnDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.Width = 51;
            // 
            // addressbookDataGridViewTextBoxColumn
            // 
            this.addressbookDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressbookDataGridViewTextBoxColumn.DataPropertyName = "address_book";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9F);
            this.addressbookDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.addressbookDataGridViewTextBoxColumn.HeaderText = "آدرس قفسه کتاب";
            this.addressbookDataGridViewTextBoxColumn.Name = "addressbookDataGridViewTextBoxColumn";
            this.addressbookDataGridViewTextBoxColumn.Width = 113;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.libraryDataSetBindingSource;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(254, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "توصیه 3 : فیلد وضعیت کتاب شامل شناسه کاربری شخصی است که کتاب را به امانت گرفته اس" +
    "ت ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(309, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "توصیه 2 : جستجو آنلاین است و بر اساس نام کتاب نام مترجم موضوع کتاب و .. میباشد ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(302, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "توصیه 1 : بعد از تغییر مقدار هر فیلد جهت اعمال تغییرات دکمه ثبت تغییرات را کلیک ن" +
    "مایید ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(17, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(172, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "برای جستجو عبارت مورد نظر را وارد کنید ";
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست کتاب ها";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.books_FormClosed);
            this.Load += new System.EventHandler(this.books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LibraryDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSet1TableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn information;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewComboBoxColumn mozoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entesharatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numchapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tozihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressbookDataGridViewTextBoxColumn;
    }
}