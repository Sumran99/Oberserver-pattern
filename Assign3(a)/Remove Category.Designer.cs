
namespace Assign3_a_
{
    partial class Remove_Category
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
            this.txt_removeCat = new System.Windows.Forms.TextBox();
            this.btn_removeOK = new System.Windows.Forms.Button();
            this.btn_catClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove Category";
            // 
            // txt_removeCat
            // 
            this.txt_removeCat.Location = new System.Drawing.Point(41, 44);
            this.txt_removeCat.Name = "txt_removeCat";
            this.txt_removeCat.Size = new System.Drawing.Size(100, 20);
            this.txt_removeCat.TabIndex = 1;
            // 
            // btn_removeOK
            // 
            this.btn_removeOK.Location = new System.Drawing.Point(12, 85);
            this.btn_removeOK.Name = "btn_removeOK";
            this.btn_removeOK.Size = new System.Drawing.Size(75, 23);
            this.btn_removeOK.TabIndex = 2;
            this.btn_removeOK.Text = "Remove";
            this.btn_removeOK.UseVisualStyleBackColor = true;
            this.btn_removeOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_catClear
            // 
            this.btn_catClear.Location = new System.Drawing.Point(106, 85);
            this.btn_catClear.Name = "btn_catClear";
            this.btn_catClear.Size = new System.Drawing.Size(75, 23);
            this.btn_catClear.TabIndex = 3;
            this.btn_catClear.Text = "Clear";
            this.btn_catClear.UseVisualStyleBackColor = true;
            this.btn_catClear.Click += new System.EventHandler(this.btn_catClear_Click);
            // 
            // Remove_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 129);
            this.Controls.Add(this.btn_catClear);
            this.Controls.Add(this.btn_removeOK);
            this.Controls.Add(this.txt_removeCat);
            this.Controls.Add(this.label1);
            this.Name = "Remove_Category";
            this.Text = "Remove_Category";
            this.Load += new System.EventHandler(this.Remove_Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_removeCat;
        private System.Windows.Forms.Button btn_removeOK;
        private System.Windows.Forms.Button btn_catClear;
    }
}