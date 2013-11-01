namespace BooksManagement.Controls
{
    partial class CategoryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbCategory = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReadBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchBook = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCategoryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCategory
            // 
            this.pbCategory.BackColor = System.Drawing.Color.Transparent;
            this.pbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCategory.Image = global::BooksManagement.Properties.Resources._803;
            this.pbCategory.Location = new System.Drawing.Point(5, 3);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(110, 150);
            this.pbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCategory.TabIndex = 0;
            this.pbCategory.TabStop = false;
            this.pbCategory.Click += new System.EventHandler(this.pbCategory_Click);
            this.pbCategory.MouseLeave += new System.EventHandler(this.Category_MouseLeave);
            this.pbCategory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Category_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReadBook,
            this.tsmiSearchBook});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // tsmiReadBook
            // 
            this.tsmiReadBook.Image = global::BooksManagement.Properties.Resources.book_2;
            this.tsmiReadBook.Name = "tsmiReadBook";
            this.tsmiReadBook.Size = new System.Drawing.Size(148, 22);
            this.tsmiReadBook.Text = "阅读";
            this.tsmiReadBook.Click += new System.EventHandler(this.pbCategory_Click);
            // 
            // tsmiSearchBook
            // 
            this.tsmiSearchBook.Image = global::BooksManagement.Properties.Resources.search_2;
            this.tsmiSearchBook.Name = "tsmiSearchBook";
            this.tsmiSearchBook.Size = new System.Drawing.Size(148, 22);
            this.tsmiSearchBook.Text = "查询书籍信息";
            this.tsmiSearchBook.Click += new System.EventHandler(this.lblCategoryName_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCategoryName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(5, 153);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(110, 46);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "分类";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCategoryName.Click += new System.EventHandler(this.lblCategoryName_Click);
            this.lblCategoryName.MouseLeave += new System.EventHandler(this.Category_MouseLeave);
            this.lblCategoryName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Category_MouseMove);
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.pbCategory);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(120, 200);
            this.Load += new System.EventHandler(this.CategoryControl_Load);
            this.MouseLeave += new System.EventHandler(this.Category_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Category_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiReadBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchBook;
    }
}
