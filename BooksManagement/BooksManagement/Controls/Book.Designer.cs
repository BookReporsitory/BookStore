namespace BooksManagement.Controls
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lbLook = new System.Windows.Forms.LinkLabel();
            this.lbRead = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.pbBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBook
            // 
            this.pbBook.BackColor = System.Drawing.Color.Transparent;
            this.pbBook.Controls.Add(this.lblBookName);
            this.pbBook.Image = ((System.Drawing.Image)(resources.GetObject("pbBook.Image")));
            this.pbBook.Location = new System.Drawing.Point(0, 0);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(100, 120);
            this.pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBook.TabIndex = 0;
            this.pbBook.TabStop = false;
            this.pbBook.MouseLeave += new System.EventHandler(this.Book_MouseLeave);
            this.pbBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            // 
            // lblBookName
            // 
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(0, 92);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(100, 28);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "写在人生边上";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookName.MouseLeave += new System.EventHandler(this.Book_MouseLeave);
            this.lblBookName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            // 
            // lbLook
            // 
            this.lbLook.AutoSize = true;
            this.lbLook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLook.Location = new System.Drawing.Point(20, 123);
            this.lbLook.Name = "lbLook";
            this.lbLook.Size = new System.Drawing.Size(31, 13);
            this.lbLook.TabIndex = 1;
            this.lbLook.TabStop = true;
            this.lbLook.Text = "简介";
            this.lbLook.MouseLeave += new System.EventHandler(this.Book_MouseLeave);
            this.lbLook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            // 
            // lbRead
            // 
            this.lbRead.AutoSize = true;
            this.lbRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRead.Location = new System.Drawing.Point(49, 123);
            this.lbRead.Name = "lbRead";
            this.lbRead.Size = new System.Drawing.Size(31, 13);
            this.lbRead.TabIndex = 1;
            this.lbRead.TabStop = true;
            this.lbRead.Text = "阅读";
            this.lbRead.MouseLeave += new System.EventHandler(this.Book_MouseLeave);
            this.lbRead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbRead);
            this.Controls.Add(this.lbLook);
            this.Controls.Add(this.pbBook);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Book";
            this.Size = new System.Drawing.Size(102, 142);
            this.MouseLeave += new System.EventHandler(this.Book_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.pbBook.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.LinkLabel lbLook;
        private System.Windows.Forms.LinkLabel lbRead;
        private System.Windows.Forms.Label lblBookName;
    }
}
