namespace Rename
{
    partial class RenameForm
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
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.btnApplyRename = new System.Windows.Forms.Button();
            this.btnCancelRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewName
            // 
            this.tbNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewName.Location = new System.Drawing.Point(12, 12);
            this.tbNewName.Multiline = true;
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(231, 35);
            this.tbNewName.TabIndex = 0;
            // 
            // btnApplyRename
            // 
            this.btnApplyRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyRename.Location = new System.Drawing.Point(12, 74);
            this.btnApplyRename.Name = "btnApplyRename";
            this.btnApplyRename.Size = new System.Drawing.Size(102, 41);
            this.btnApplyRename.TabIndex = 1;
            this.btnApplyRename.Text = "Apply";
            this.btnApplyRename.UseVisualStyleBackColor = true;
            this.btnApplyRename.Click += new System.EventHandler(this.btnApplyRename_Click);
            // 
            // btnCancelRename
            // 
            this.btnCancelRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelRename.Location = new System.Drawing.Point(141, 74);
            this.btnCancelRename.Name = "btnCancelRename";
            this.btnCancelRename.Size = new System.Drawing.Size(102, 41);
            this.btnCancelRename.TabIndex = 2;
            this.btnCancelRename.Text = "Cancel";
            this.btnCancelRename.UseVisualStyleBackColor = true;
            this.btnCancelRename.Click += new System.EventHandler(this.button2_Click);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 135);
            this.Controls.Add(this.btnCancelRename);
            this.Controls.Add(this.btnApplyRename);
            this.Controls.Add(this.tbNewName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameForm";
            this.ShowIcon = false;
            this.Text = "RenameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApplyRename;
        private System.Windows.Forms.Button btnCancelRename;
        public System.Windows.Forms.TextBox tbNewName;
    }
}