namespace Rename
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRename = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lwShowInfoWin1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDir_C_Win1 = new System.Windows.Forms.Button();
            this.btnDir_D_Win1 = new System.Windows.Forms.Button();
            this.lblPathWin1 = new System.Windows.Forms.Label();
            this.btnBackFolderWin1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteFilesFolders = new System.Windows.Forms.Button();
            this.btnDir_E_Win1 = new System.Windows.Forms.Button();
            this.lwShowInfoWin2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDir_E_Win2 = new System.Windows.Forms.Button();
            this.btnBackFolderWin2 = new System.Windows.Forms.Button();
            this.btnDir_D_Win2 = new System.Windows.Forms.Button();
            this.btnDir_C_Win2 = new System.Windows.Forms.Button();
            this.lblPathWin2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRename.Location = new System.Drawing.Point(12, 411);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(150, 52);
            this.btnRename.TabIndex = 1;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            // 
            // lwShowInfoWin1
            // 
            this.lwShowInfoWin1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lwShowInfoWin1.LargeImageList = this.imageList1;
            this.lwShowInfoWin1.Location = new System.Drawing.Point(139, 79);
            this.lwShowInfoWin1.Name = "lwShowInfoWin1";
            this.lwShowInfoWin1.Size = new System.Drawing.Size(526, 324);
            this.lwShowInfoWin1.SmallImageList = this.imageList1;
            this.lwShowInfoWin1.TabIndex = 3;
            this.lwShowInfoWin1.UseCompatibleStateImageBehavior = false;
            this.lwShowInfoWin1.View = System.Windows.Forms.View.Details;
            this.lwShowInfoWin1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lwShowInfo_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 306;
            // 
            // btnDir_C_Win1
            // 
            this.btnDir_C_Win1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDir_C_Win1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDir_C_Win1.Location = new System.Drawing.Point(12, 12);
            this.btnDir_C_Win1.Name = "btnDir_C_Win1";
            this.btnDir_C_Win1.Size = new System.Drawing.Size(48, 29);
            this.btnDir_C_Win1.TabIndex = 6;
            this.btnDir_C_Win1.Text = "C:\\";
            this.btnDir_C_Win1.UseVisualStyleBackColor = true;
            this.btnDir_C_Win1.Click += new System.EventHandler(this.btnDir_C_Click);
            // 
            // btnDir_D_Win1
            // 
            this.btnDir_D_Win1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDir_D_Win1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDir_D_Win1.Location = new System.Drawing.Point(66, 12);
            this.btnDir_D_Win1.Name = "btnDir_D_Win1";
            this.btnDir_D_Win1.Size = new System.Drawing.Size(48, 29);
            this.btnDir_D_Win1.TabIndex = 7;
            this.btnDir_D_Win1.Text = "D:\\";
            this.btnDir_D_Win1.UseVisualStyleBackColor = true;
            this.btnDir_D_Win1.Click += new System.EventHandler(this.btnDir_D_Click);
            // 
            // lblPathWin1
            // 
            this.lblPathWin1.AutoSize = true;
            this.lblPathWin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathWin1.Location = new System.Drawing.Point(15, 44);
            this.lblPathWin1.Name = "lblPathWin1";
            this.lblPathWin1.Size = new System.Drawing.Size(0, 20);
            this.lblPathWin1.TabIndex = 8;
            // 
            // btnBackFolderWin1
            // 
            this.btnBackFolderWin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackFolderWin1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackFolderWin1.Location = new System.Drawing.Point(174, 12);
            this.btnBackFolderWin1.Name = "btnBackFolderWin1";
            this.btnBackFolderWin1.Size = new System.Drawing.Size(96, 29);
            this.btnBackFolderWin1.TabIndex = 9;
            this.btnBackFolderWin1.Text = "Back";
            this.btnBackFolderWin1.UseVisualStyleBackColor = true;
            this.btnBackFolderWin1.Click += new System.EventHandler(this.btnBackFolder_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(197, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFilesFolders
            // 
            this.btnDeleteFilesFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteFilesFolders.Location = new System.Drawing.Point(388, 411);
            this.btnDeleteFilesFolders.Name = "btnDeleteFilesFolders";
            this.btnDeleteFilesFolders.Size = new System.Drawing.Size(150, 52);
            this.btnDeleteFilesFolders.TabIndex = 11;
            this.btnDeleteFilesFolders.Text = "Delete";
            this.btnDeleteFilesFolders.UseVisualStyleBackColor = true;
            this.btnDeleteFilesFolders.Click += new System.EventHandler(this.btnDeleteFilesFolders_Click);
            // 
            // btnDir_E_Win1
            // 
            this.btnDir_E_Win1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDir_E_Win1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDir_E_Win1.Location = new System.Drawing.Point(120, 12);
            this.btnDir_E_Win1.Name = "btnDir_E_Win1";
            this.btnDir_E_Win1.Size = new System.Drawing.Size(48, 29);
            this.btnDir_E_Win1.TabIndex = 12;
            this.btnDir_E_Win1.Text = "E:\\";
            this.btnDir_E_Win1.UseVisualStyleBackColor = true;
            this.btnDir_E_Win1.Click += new System.EventHandler(this.btnDir_E_Click);
            // 
            // lwShowInfoWin2
            // 
            this.lwShowInfoWin2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lwShowInfoWin2.LargeImageList = this.imageList1;
            this.lwShowInfoWin2.Location = new System.Drawing.Point(711, 79);
            this.lwShowInfoWin2.Name = "lwShowInfoWin2";
            this.lwShowInfoWin2.Size = new System.Drawing.Size(526, 324);
            this.lwShowInfoWin2.SmallImageList = this.imageList1;
            this.lwShowInfoWin2.TabIndex = 13;
            this.lwShowInfoWin2.UseCompatibleStateImageBehavior = false;
            this.lwShowInfoWin2.View = System.Windows.Forms.View.Details;
            this.lwShowInfoWin2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lwShowInfoWin2_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 306;
            // 
            // btnDir_E_Win2
            // 
            this.btnDir_E_Win2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDir_E_Win2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDir_E_Win2.Location = new System.Drawing.Point(819, 8);
            this.btnDir_E_Win2.Name = "btnDir_E_Win2";
            this.btnDir_E_Win2.Size = new System.Drawing.Size(48, 29);
            this.btnDir_E_Win2.TabIndex = 17;
            this.btnDir_E_Win2.Text = "E:\\";
            this.btnDir_E_Win2.UseVisualStyleBackColor = true;
            this.btnDir_E_Win2.Click += new System.EventHandler(this.btnDir_E_Win2_Click);
            // 
            // btnBackFolderWin2
            // 
            this.btnBackFolderWin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackFolderWin2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackFolderWin2.Location = new System.Drawing.Point(873, 8);
            this.btnBackFolderWin2.Name = "btnBackFolderWin2";
            this.btnBackFolderWin2.Size = new System.Drawing.Size(96, 29);
            this.btnBackFolderWin2.TabIndex = 16;
            this.btnBackFolderWin2.Text = "Back";
            this.btnBackFolderWin2.UseVisualStyleBackColor = true;
            this.btnBackFolderWin2.Click += new System.EventHandler(this.btnBackFolderWin2_Click);
            // 
            // btnDir_D_Win2
            // 
            this.btnDir_D_Win2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDir_D_Win2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDir_D_Win2.Location = new System.Drawing.Point(765, 8);
            this.btnDir_D_Win2.Name = "btnDir_D_Win2";
            this.btnDir_D_Win2.Size = new System.Drawing.Size(48, 29);
            this.btnDir_D_Win2.TabIndex = 15;
            this.btnDir_D_Win2.Text = "D:\\";
            this.btnDir_D_Win2.UseVisualStyleBackColor = true;
            this.btnDir_D_Win2.Click += new System.EventHandler(this.btnDir_D_Win2_Click);
            // 
            // btnDir_C_Win2
            // 
            this.btnDir_C_Win2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDir_C_Win2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDir_C_Win2.Location = new System.Drawing.Point(711, 8);
            this.btnDir_C_Win2.Name = "btnDir_C_Win2";
            this.btnDir_C_Win2.Size = new System.Drawing.Size(48, 29);
            this.btnDir_C_Win2.TabIndex = 14;
            this.btnDir_C_Win2.Text = "C:\\";
            this.btnDir_C_Win2.UseVisualStyleBackColor = true;
            this.btnDir_C_Win2.Click += new System.EventHandler(this.btnDir_C_Win2_Click);
            // 
            // lblPathWin2
            // 
            this.lblPathWin2.AutoSize = true;
            this.lblPathWin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathWin2.Location = new System.Drawing.Point(707, 40);
            this.lblPathWin2.Name = "lblPathWin2";
            this.lblPathWin2.Size = new System.Drawing.Size(0, 20);
            this.lblPathWin2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 79);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(121, 324);
            this.treeView1.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 475);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPathWin2);
            this.Controls.Add(this.btnDir_E_Win2);
            this.Controls.Add(this.btnBackFolderWin2);
            this.Controls.Add(this.btnDir_D_Win2);
            this.Controls.Add(this.btnDir_C_Win2);
            this.Controls.Add(this.lwShowInfoWin2);
            this.Controls.Add(this.btnDir_E_Win1);
            this.Controls.Add(this.btnDeleteFilesFolders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBackFolderWin1);
            this.Controls.Add(this.lblPathWin1);
            this.Controls.Add(this.btnDir_D_Win1);
            this.Controls.Add(this.btnDir_C_Win1);
            this.Controls.Add(this.lwShowInfoWin1);
            this.Controls.Add(this.btnRename);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Rename";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lwShowInfoWin1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnDir_C_Win1;
        private System.Windows.Forms.Button btnDir_D_Win1;
        private System.Windows.Forms.Label lblPathWin1;
        private System.Windows.Forms.Button btnBackFolderWin1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteFilesFolders;
        private System.Windows.Forms.Button btnDir_E_Win1;
        private System.Windows.Forms.ListView lwShowInfoWin2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnDir_E_Win2;
        private System.Windows.Forms.Button btnBackFolderWin2;
        private System.Windows.Forms.Button btnDir_D_Win2;
        private System.Windows.Forms.Button btnDir_C_Win2;
        private System.Windows.Forms.Label lblPathWin2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

