namespace BooksManagement.Controls
{
    partial class BookControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookControl));
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReadBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchBook = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBookName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBook
            // 
            this.pbBook.BackColor = System.Drawing.Color.Transparent;
            this.pbBook.ContextMenuStrip = this.contextMenuStrip;
            this.pbBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBook.Image = ((System.Drawing.Image)(resources.GetObject("pbBook.Image")));
            this.pbBook.Location = new System.Drawing.Point(5, 3);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(110, 150);
            this.pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBook.TabIndex = 0;
            this.pbBook.TabStop = false;
            this.pbBook.Click += new System.EventHandler(this.pbBook_Click);
            this.pbBook.MouseLeave += new System.EventHandler(this.Book_MouseLeave);
            this.pbBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReadBook,
            this.tsmiSearchBook});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmiReadBook
            // 
            this.tsmiReadBook.Image = global::BooksManagement.Properties.Resources.book_2;
            this.tsmiReadBook.Name = "tsmiReadBook";
            this.tsmiReadBook.Size = new System.Drawing.Size(152, 22);
            this.tsmiReadBook.Text = "阅读";
            this.tsmiReadBook.Click += new System.EventHandler(this.pbBook_Click);
            // 
            // tsmiSearchBook
            // 
            this.tsmiSearchBook.Image = global::BooksManagement.Properties.Resources.search_2;
            this.tsmiSearchBook.Name = "tsmiSearchBook";
            this.tsmiSearchBook.Size = new System.Drawing.Size(152, 22);
            this.tsmiSearchBook.Text = "查询书籍信息";
            this.tsmiSearchBook.Click += new System.EventHandler(this.lblBookName_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.ContextMenuStrip = this.contextMenuStrip;
            this.lblBookName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(5, 153);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(110, 46);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "写在人生边上";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookName.Click += new System.EventHandler(this.lblBookName_Click);
            this.lblBookName.MouseLeave += new System.EventHandler(this.Book_MouseLeave);
            this.lblBookName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            // 
            // BookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pbBook);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookControl";
            this.Size = new System.Drawing.Size(120, 200);
            this.Load += new System.EventHandler(this.BookControl_Load);
            this.MouseLeave += new System.EventHandler(this.Book_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiReadBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchBook;
    }
}
