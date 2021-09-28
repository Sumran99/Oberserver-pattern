
namespace Assign3_a_
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_removeCat = new System.Windows.Forms.Button();
            this.btn_newAd = new System.Windows.Forms.Button();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.txt_productPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pType = new System.Windows.Forms.Label();
            this.rb_Used = new System.Windows.Forms.RadioButton();
            this.rb_new = new System.Windows.Forms.RadioButton();
            this.catValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_userWarning = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.btn_userCreate = new System.Windows.Forms.Button();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.lbl_catSelect = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_display = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_removeCat);
            this.tabPage1.Controls.Add(this.btn_newAd);
            this.tabPage1.Controls.Add(this.lbl_warning);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btn_post);
            this.tabPage1.Controls.Add(this.txt_productPrice);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_pName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lbl_pType);
            this.tabPage1.Controls.Add(this.rb_Used);
            this.tabPage1.Controls.Add(this.rb_new);
            this.tabPage1.Controls.Add(this.catValue);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Ads";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_removeCat
            // 
            this.btn_removeCat.Location = new System.Drawing.Point(492, 267);
            this.btn_removeCat.Name = "btn_removeCat";
            this.btn_removeCat.Size = new System.Drawing.Size(113, 23);
            this.btn_removeCat.TabIndex = 16;
            this.btn_removeCat.Text = "Remove Category";
            this.btn_removeCat.UseVisualStyleBackColor = true;
            this.btn_removeCat.Click += new System.EventHandler(this.btn_removeCat_Click);
            // 
            // btn_newAd
            // 
            this.btn_newAd.Location = new System.Drawing.Point(611, 267);
            this.btn_newAd.Name = "btn_newAd";
            this.btn_newAd.Size = new System.Drawing.Size(115, 23);
            this.btn_newAd.TabIndex = 15;
            this.btn_newAd.Text = "Add New Category";
            this.btn_newAd.UseVisualStyleBackColor = true;
            this.btn_newAd.Click += new System.EventHandler(this.btn_newAd_Click);
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Location = new System.Drawing.Point(89, 350);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(13, 13);
            this.lbl_warning.TabIndex = 14;
            this.lbl_warning.Text = ">";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Ads";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_post
            // 
            this.btn_post.Location = new System.Drawing.Point(89, 268);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 23);
            this.btn_post.TabIndex = 12;
            this.btn_post.Text = "Post Ad";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.Location = new System.Drawing.Point(108, 219);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_productPrice.TabIndex = 11;
            this.txt_productPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_productPrice_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // txt_pName
            // 
            this.txt_pName.Location = new System.Drawing.Point(128, 187);
            this.txt_pName.Name = "txt_pName";
            this.txt_pName.Size = new System.Drawing.Size(100, 20);
            this.txt_pName.TabIndex = 9;
            this.txt_pName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_pName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Name";
            // 
            // lbl_pType
            // 
            this.lbl_pType.AutoSize = true;
            this.lbl_pType.Location = new System.Drawing.Point(37, 155);
            this.lbl_pType.Name = "lbl_pType";
            this.lbl_pType.Size = new System.Drawing.Size(51, 13);
            this.lbl_pType.TabIndex = 7;
            this.lbl_pType.Text = "Condition";
            this.lbl_pType.Validating += new System.ComponentModel.CancelEventHandler(this.lbl_pType_Validating);
            // 
            // rb_Used
            // 
            this.rb_Used.AutoSize = true;
            this.rb_Used.Location = new System.Drawing.Point(178, 153);
            this.rb_Used.Name = "rb_Used";
            this.rb_Used.Size = new System.Drawing.Size(50, 17);
            this.rb_Used.TabIndex = 6;
            this.rb_Used.TabStop = true;
            this.rb_Used.Text = "Used";
            this.rb_Used.UseVisualStyleBackColor = true;
            // 
            // rb_new
            // 
            this.rb_new.AutoSize = true;
            this.rb_new.Location = new System.Drawing.Point(125, 153);
            this.rb_new.Name = "rb_new";
            this.rb_new.Size = new System.Drawing.Size(47, 17);
            this.rb_new.TabIndex = 5;
            this.rb_new.TabStop = true;
            this.rb_new.Text = "New";
            this.rb_new.UseVisualStyleBackColor = true;
            // 
            // catValue
            // 
            this.catValue.AutoSize = true;
            this.catValue.Location = new System.Drawing.Point(155, 109);
            this.catValue.Name = "catValue";
            this.catValue.Size = new System.Drawing.Size(13, 13);
            this.catValue.TabIndex = 4;
            this.catValue.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Car",
            "Household item",
            "Property",
            "Electronics"});
            this.comboBox1.Location = new System.Drawing.Point(125, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Post an Ad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.lbl_userWarning);
            this.tabPage2.Controls.Add(this.txt_location);
            this.tabPage2.Controls.Add(this.btn_userCreate);
            this.tabPage2.Controls.Add(this.txt_userName);
            this.tabPage2.Controls.Add(this.txt_contact);
            this.tabPage2.Controls.Add(this.lbl_catSelect);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbl_userWarning
            // 
            this.lbl_userWarning.AutoSize = true;
            this.lbl_userWarning.Location = new System.Drawing.Point(63, 366);
            this.lbl_userWarning.Name = "lbl_userWarning";
            this.lbl_userWarning.Size = new System.Drawing.Size(13, 13);
            this.lbl_userWarning.TabIndex = 14;
            this.lbl_userWarning.Text = ">";
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(107, 149);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(100, 20);
            this.txt_location.TabIndex = 13;
            this.txt_location.Validating += new System.ComponentModel.CancelEventHandler(this.txt_location_Validating);
            // 
            // btn_userCreate
            // 
            this.btn_userCreate.Location = new System.Drawing.Point(148, 323);
            this.btn_userCreate.Name = "btn_userCreate";
            this.btn_userCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_userCreate.TabIndex = 12;
            this.btn_userCreate.Text = "Create User";
            this.btn_userCreate.UseVisualStyleBackColor = true;
            this.btn_userCreate.Click += new System.EventHandler(this.btn_userCreate_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(107, 115);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 20);
            this.txt_userName.TabIndex = 11;
            this.txt_userName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_userName_Validating);
            this.txt_userName.Validated += new System.EventHandler(this.txt_userName_Validated);
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(148, 267);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(100, 20);
            this.txt_contact.TabIndex = 9;
            this.txt_contact.Validating += new System.ComponentModel.CancelEventHandler(this.txt_contact_Validating);
            // 
            // lbl_catSelect
            // 
            this.lbl_catSelect.AutoSize = true;
            this.lbl_catSelect.Location = new System.Drawing.Point(184, 230);
            this.lbl_catSelect.Name = "lbl_catSelect";
            this.lbl_catSelect.Size = new System.Drawing.Size(0, 13);
            this.lbl_catSelect.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Categories Selected";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Car",
            "Household item",
            "Property",
            "Electronics"});
            this.comboBox2.Location = new System.Drawing.Point(123, 184);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Enter += new System.EventHandler(this.comboBox2_Enter);
            this.comboBox2.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox2_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Categories";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Contact No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Location";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Create User";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_display);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notifications";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(294, 23);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(124, 32);
            this.btn_display.TabIndex = 1;
            this.btn_display.Text = "Show Notifications";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(211, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 200);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "User Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Search User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label catValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_pType;
        private System.Windows.Forms.RadioButton rb_Used;
        private System.Windows.Forms.RadioButton rb_new;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.TextBox txt_productPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_catSelect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_userCreate;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label lbl_userWarning;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_newAd;
        private System.Windows.Forms.Button btn_removeCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

