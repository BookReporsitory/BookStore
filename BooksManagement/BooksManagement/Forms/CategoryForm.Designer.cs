namespace BooksManagement.Forms
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tvCategoryTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteNode = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnAddSubCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnChangeNode = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "分类结构:";
            // 
            // tvCategoryTree
            // 
            this.tvCategoryTree.ContextMenuStrip = this.contextMenuStrip;
            this.tvCategoryTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvCategoryTree.ImageIndex = 0;
            this.tvCategoryTree.ImageList = this.imageList;
            this.tvCategoryTree.Location = new System.Drawing.Point(8, 31);
            this.tvCategoryTree.Name = "tvCategoryTree";
            this.tvCategoryTree.SelectedImageIndex = 1;
            this.tvCategoryTree.Size = new System.Drawing.Size(349, 371);
            this.tvCategoryTree.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNode,
            this.tsmiChangeNode,
            this.tsmiDeleteNode});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // tsmiAddNode
            // 
            this.tsmiAddNode.Image = global::BooksManagement.Properties.Resources.add;
            this.tsmiAddNode.Name = "tsmiAddNode";
            this.tsmiAddNode.Size = new System.Drawing.Size(152, 22);
            this.tsmiAddNode.Text = "添加";
            this.tsmiAddNode.Click += new System.EventHandler(this.btnAddSubCategory_Click);
            // 
            // tsmiChangeNode
            // 
            this.tsmiChangeNode.Image = global::BooksManagement.Properties.Resources.pen;
            this.tsmiChangeNode.Name = "tsmiChangeNode";
            this.tsmiChangeNode.Size = new System.Drawing.Size(152, 22);
            this.tsmiChangeNode.Text = "修改";
            this.tsmiChangeNode.Click += new System.EventHandler(this.btnChangeNode_Click);
            // 
            // tsmiDeleteNode
            // 
            this.tsmiDeleteNode.Image = global::BooksManagement.Properties.Resources.remove;
            this.tsmiDeleteNode.Name = "tsmiDeleteNode";
            this.tsmiDeleteNode.Size = new System.Drawing.Size(152, 22);
            this.tsmiDeleteNode.Text = "删除";
            this.tsmiDeleteNode.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "database_active.png");
            this.imageList.Images.SetKeyName(1, "swipely-img-31.png");
            // 
            // btnAddSubCategory
            // 
            this.btnAddSubCategory.Location = new System.Drawing.Point(14, 411);
            this.btnAddSubCategory.Name = "btnAddSubCategory";
            this.btnAddSubCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubCategory.TabIndex = 2;
            this.btnAddSubCategory.Text = "添 加";
            this.btnAddSubCategory.UseVisualStyleBackColor = true;
            this.btnAddSubCategory.Click += new System.EventHandler(this.btnAddSubCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(188, 411);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 3;
            this.btnDeleteCategory.Text = "删 除";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(275, 411);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnChangeNode
            // 
            this.btnChangeNode.Location = new System.Drawing.Point(101, 411);
            this.btnChangeNode.Name = "btnChangeNode";
            this.btnChangeNode.Size = new System.Drawing.Size(75, 23);
            this.btnChangeNode.TabIndex = 2;
            this.btnChangeNode.Text = "修 改";
            this.btnChangeNode.UseVisualStyleBackColor = true;
            this.btnChangeNode.Click += new System.EventHandler(this.btnChangeNode_Click);
            // 
            // CategoryForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 446);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnChangeNode);
            this.Controls.Add(this.btnAddSubCategory);
            this.Controls.Add(this.tvCategoryTree);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "分类管理";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvCategoryTree;
        private System.Windows.Forms.Button btnAddSubCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNode;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeNode;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteNode;
        private System.Windows.Forms.Button btnChangeNode;
    }
}