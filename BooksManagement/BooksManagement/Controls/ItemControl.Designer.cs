namespace BooksManagement.Controls
{
    partial class ItemControl
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
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReadBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchBook = new System.Windows.Forms.ToolStripMenuItem();
            this.lblItmeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbItem
            // 
            this.pbItem.BackColor = System.Drawing.Color.Transparent;
            this.pbItem.ContextMenuStrip = this.contextMenuStrip;
            this.pbItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbItem.Image = global::BooksManagement.Properties.Resources.book__2_;
            this.pbItem.Location = new System.Drawing.Point(5, 3);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(110, 150);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            this.pbItem.Click += new System.EventHandler(this.pbItem_Click);
            this.pbItem.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            this.pbItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
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
            this.tsmiReadBook.Click += new System.EventHandler(this.pbItem_Click);
            // 
            // tsmiSearchBook
            // 
            this.tsmiSearchBook.Image = global::BooksManagement.Properties.Resources.search_2;
            this.tsmiSearchBook.Name = "tsmiSearchBook";
            this.tsmiSearchBook.Size = new System.Drawing.Size(148, 22);
            this.tsmiSearchBook.Text = "查询书籍信息";
            this.tsmiSearchBook.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // lblItmeName
            // 
            this.lblItmeName.BackColor = System.Drawing.Color.Transparent;
            this.lblItmeName.ContextMenuStrip = this.contextMenuStrip;
            this.lblItmeName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblItmeName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItmeName.Location = new System.Drawing.Point(5, 153);
            this.lblItmeName.Name = "lblItmeName";
            this.lblItmeName.Size = new System.Drawing.Size(110, 46);
            this.lblItmeName.TabIndex = 2;
            this.lblItmeName.Text = "写在人生边上";
            this.lblItmeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItmeName.Click += new System.EventHandler(this.lblItemName_Click);
            this.lblItmeName.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            this.lblItmeName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblItmeName);
            this.Controls.Add(this.pbItem);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(120, 200);
            this.Load += new System.EventHandler(this.ItemControl_Load);
            this.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Label lblItmeName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiReadBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchBook;
    }
}
