
namespace Assign3_a_
{
    partial class New_Category
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_newCategory = new System.Windows.Forms.TextBox();
            this.btn_newSubmit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Category";
            // 
            // txt_newCategory
            // 
            this.txt_newCategory.Location = new System.Drawing.Point(73, 60);
            this.txt_newCategory.Name = "txt_newCategory";
            this.txt_newCategory.Size = new System.Drawing.Size(100, 20);
            this.txt_newCategory.TabIndex = 1;
            // 
            // btn_newSubmit
            // 
            this.btn_newSubmit.Location = new System.Drawing.Point(40, 104);
            this.btn_newSubmit.Name = "btn_newSubmit";
            this.btn_newSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_newSubmit.TabIndex = 2;
            this.btn_newSubmit.Text = "Add";
            this.btn_newSubmit.UseVisualStyleBackColor = true;
            this.btn_newSubmit.Click += new System.EventHandler(this.btn_newSubmit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(121, 104);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // New_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 139);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_newSubmit);
            this.Controls.Add(this.txt_newCategory);
            this.Controls.Add(this.label1);
            this.Name = "New_Category";
            this.Text = "New_Category";
            this.Load += new System.EventHandler(this.New_Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newCategory;
        private System.Windows.Forms.Button btn_newSubmit;
        private System.Windows.Forms.Button btn_clear;
    }
}