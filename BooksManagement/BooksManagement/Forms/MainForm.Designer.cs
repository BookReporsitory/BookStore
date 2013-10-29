namespace BooksManagement.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.tsmiShowBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowList = new System.Windows.Forms.ToolStripMenuItem();
            this.pBasePanel = new System.Windows.Forms.Panel();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Athor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Words = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBookList = new System.Windows.Forms.Panel();
            this.tsmiAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindByBookName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindByDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecentlyRead = new System.Windows.Forms.ToolStripMenuItem();
            this.timsBookCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMainForm.SuspendLayout();
            this.pBasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStripMainForm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowBooks,
            this.tsmiImportBooks,
            this.tsmiDeleteBook,
            this.tsmiBookCategory,
            this.tsmiFindBook,
            this.tsmiShowBook,
            this.tsmiShowList});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripMainForm.Size = new System.Drawing.Size(864, 29);
            this.menuStripMainForm.TabIndex = 0;
            this.menuStripMainForm.Text = "menuStrip1";
            // 
            // tsmiShowBooks
            // 
            this.tsmiShowBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecentlyRead,
            this.timsBookCategory});
            this.tsmiShowBooks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiShowBooks.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowBooks.Image")));
            this.tsmiShowBooks.Name = "tsmiShowBooks";
            this.tsmiShowBooks.Size = new System.Drawing.Size(97, 23);
            this.tsmiShowBooks.Text = "显示方式";
            // 
            // tsmiImportBooks
            // 
            this.tsmiImportBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectFiles,
            this.tsmiSelectFolder});
            this.tsmiImportBooks.Image = ((System.Drawing.Image)(resources.GetObject("tsmiImportBooks.Image")));
            this.tsmiImportBooks.Name = "tsmiImportBooks";
            this.tsmiImportBooks.Size = new System.Drawing.Size(92, 23);
            this.tsmiImportBooks.Text = "导入图书";
            // 
            // tsmiSelectFiles
            // 
            this.tsmiSelectFiles.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSelectFiles.Image")));
            this.tsmiSelectFiles.Name = "tsmiSelectFiles";
            this.tsmiSelectFiles.Size = new System.Drawing.Size(152, 22);
            this.tsmiSelectFiles.Text = "选择文件";
            this.tsmiSelectFiles.Click += new System.EventHandler(this.tsmiSelectFiles_Click);
            // 
            // tsmiSelectFolder
            // 
            this.tsmiSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSelectFolder.Image")));
            this.tsmiSelectFolder.Name = "tsmiSelectFolder";
            this.tsmiSelectFolder.Size = new System.Drawing.Size(152, 22);
            this.tsmiSelectFolder.Text = "选择文件夹";
            this.tsmiSelectFolder.Click += new System.EventHandler(this.tsmiSelectFolder_Click);
            // 
            // tsmiDeleteBook
            // 
            this.tsmiDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteBook.Image")));
            this.tsmiDeleteBook.Name = "tsmiDeleteBook";
            this.tsmiDeleteBook.Size = new System.Drawing.Size(92, 23);
            this.tsmiDeleteBook.Text = "删除图书";
            // 
            // tsmiBookCategory
            // 
            this.tsmiBookCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddCategory,
            this.tsmiDeleteCategory});
            this.tsmiBookCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBookCategory.Image")));
            this.tsmiBookCategory.Name = "tsmiBookCategory";
            this.tsmiBookCategory.Size = new System.Drawing.Size(92, 23);
            this.tsmiBookCategory.Text = "图书分类";
            // 
            // tsmiFindBook
            // 
            this.tsmiFindBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFindByBookName,
            this.tsmiFindByDetail});
            this.tsmiFindBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFindBook.Image")));
            this.tsmiFindBook.Name = "tsmiFindBook";
            this.tsmiFindBook.Size = new System.Drawing.Size(92, 23);
            this.tsmiFindBook.Text = "查找图书";
            // 
            // tsmiShowBook
            // 
            this.tsmiShowBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiShowBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowBook.Image")));
            this.tsmiShowBook.Name = "tsmiShowBook";
            this.tsmiShowBook.Size = new System.Drawing.Size(28, 23);
            this.tsmiShowBook.Text = "图标显示";
            this.tsmiShowBook.Click += new System.EventHandler(this.tsmiShowBook_Click);
            // 
            // tsmiShowList
            // 
            this.tsmiShowList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiShowList.Image = ((System.Drawing.Image)(resources.GetObject("tsmiShowList.Image")));
            this.tsmiShowList.Name = "tsmiShowList";
            this.tsmiShowList.Size = new System.Drawing.Size(28, 23);
            this.tsmiShowList.Text = "列表显示";
            this.tsmiShowList.Click += new System.EventHandler(this.tsmiShowList_Click);
            // 
            // pBasePanel
            // 
            this.pBasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBasePanel.Controls.Add(this.dgvBooks);
            this.pBasePanel.Controls.Add(this.pBookList);
            this.pBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBasePanel.Location = new System.Drawing.Point(0, 29);
            this.pBasePanel.Name = "pBasePanel";
            this.pBasePanel.Size = new System.Drawing.Size(864, 497);
            this.pBasePanel.TabIndex = 1;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BookName,
            this.CategoryName,
            this.Athor,
            this.Translator,
            this.Words,
            this.Publisher,
            this.PublishDate,
            this.ISBN,
            this.Laber});
            this.dgvBooks.Location = new System.Drawing.Point(0, 20);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.ShowCellErrors = false;
            this.dgvBooks.ShowEditingIcon = false;
            this.dgvBooks.Size = new System.Drawing.Size(864, 497);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "bookname";
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "分类";
            this.CategoryName.Name = "CategoryName";
            // 
            // Athor
            // 
            this.Athor.DataPropertyName = "author";
            this.Athor.HeaderText = "作者";
            this.Athor.Name = "Athor";
            // 
            // Translator
            // 
            this.Translator.DataPropertyName = "translator";
            this.Translator.HeaderText = "译者";
            this.Translator.Name = "Translator";
            // 
            // Words
            // 
            this.Words.DataPropertyName = "words";
            this.Words.HeaderText = "字数";
            this.Words.Name = "Words";
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "publisher";
            this.Publisher.HeaderText = "出版社";
            this.Publisher.Name = "Publisher";
            // 
            // PublishDate
            // 
            this.PublishDate.DataPropertyName = "publishdate";
            this.PublishDate.HeaderText = "出版日期";
            this.PublishDate.Name = "PublishDate";
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Laber
            // 
            this.Laber.DataPropertyName = "label";
            this.Laber.HeaderText = "标签";
            this.Laber.Name = "Laber";
            // 
            // pBookList
            // 
            this.pBookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBookList.AutoScroll = true;
            this.pBookList.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBookList.Location = new System.Drawing.Point(0, 0);
            this.pBookList.Name = "pBookList";
            this.pBookList.Size = new System.Drawing.Size(864, 497);
            this.pBookList.TabIndex = 1;
            // 
            // tsmiAddCategory
            // 
            this.tsmiAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddCategory.Image")));
            this.tsmiAddCategory.Name = "tsmiAddCategory";
            this.tsmiAddCategory.Size = new System.Drawing.Size(152, 22);
            this.tsmiAddCategory.Text = "添加分类";
            this.tsmiAddCategory.Click += new System.EventHandler(this.tsmiAddCategory_Click);
            // 
            // tsmiDeleteCategory
            // 
            this.tsmiDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeleteCategory.Image")));
            this.tsmiDeleteCategory.Name = "tsmiDeleteCategory";
            this.tsmiDeleteCategory.Size = new System.Drawing.Size(152, 22);
            this.tsmiDeleteCategory.Text = "删除分类";
            this.tsmiDeleteCategory.Click += new System.EventHandler(this.tsmiDeleteCategory_Click);
            // 
            // tsmiFindByBookName
            // 
            this.tsmiFindByBookName.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFindByBookName.Image")));
            this.tsmiFindByBookName.Name = "tsmiFindByBookName";
            this.tsmiFindByBookName.Size = new System.Drawing.Size(152, 22);
            this.tsmiFindByBookName.Text = "书名查找";
            // 
            // tsmiFindByDetail
            // 
            this.tsmiFindByDetail.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFindByDetail.Image")));
            this.tsmiFindByDetail.Name = "tsmiFindByDetail";
            this.tsmiFindByDetail.Size = new System.Drawing.Size(152, 22);
            this.tsmiFindByDetail.Text = "高级查找";
            // 
            // tsmiRecentlyRead
            // 
            this.tsmiRecentlyRead.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRecentlyRead.Image")));
            this.tsmiRecentlyRead.Name = "tsmiRecentlyRead";
            this.tsmiRecentlyRead.Size = new System.Drawing.Size(152, 24);
            this.tsmiRecentlyRead.Text = "最近阅读";
            // 
            // timsBookCategory
            // 
            this.timsBookCategory.Image = ((System.Drawing.Image)(resources.GetObject("timsBookCategory.Image")));
            this.timsBookCategory.Name = "timsBookCategory";
            this.timsBookCategory.Size = new System.Drawing.Size(152, 24);
            this.timsBookCategory.Text = "分类显示";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 526);
            this.Controls.Add(this.pBasePanel);
            this.Controls.Add(this.menuStripMainForm);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "电子书管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.pBasePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowList;
        private System.Windows.Forms.Panel pBasePanel;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel pBookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Athor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Words;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laber;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectFiles;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectFolder;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecentlyRead;
        private System.Windows.Forms.ToolStripMenuItem timsBookCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindByBookName;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindByDetail;

    }
}

