using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign3_a_
{
    public partial class Form1 : Form
    {
        private List<string> cat;
        public Admin admin;
        public Form1()
        {
            admin = new Admin();
            cat = new List<string>();
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            catValue.Text = comboBox1.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_Enter(object sender, EventArgs e)
        {
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbl_catSelect.Text.Contains(comboBox2.Text))
            {
                lbl_catSelect.Text += "";
            }
            else
            { 
                lbl_catSelect.Text += comboBox2.Text + " ";
                cat.Add(comboBox2.Text);
            }
        }

        private void txt_catOther_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txt_pName.Text))
            {
                e.Cancel = true;
                lbl_warning.Text = "Warning: Enter all required information to post Ad";
                errorProvider1.SetError(txt_pName, "Enter Product Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
                
            }
        }

        private void txt_productPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_productPrice.Text))
            {
                
                e.Cancel = true;
                lbl_warning.Text = "Warning: Enter all required information to post Ad";
                errorProvider1.SetError(txt_productPrice, "Enter Product Price");
            }
            else
            {
                
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if(comboBox1.SelectedItem==null)
            {
                
                errorProvider1.SetError(comboBox1, "Select any one Category");
                e.Cancel = true;
                lbl_warning.Text = "Warning: Enter all required information to post Ad";
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void btn_post_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren(ValidationConstraints.Visible))
            {
                MessageBox.Show("Ad has been Uploaded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_warning.Text = ">";

                Ads ad = new Ads(txt_pName.Text, catValue.Text, txt_productPrice.Text);
                admin.notifyObserver(ad);
                txt_pName.Text = "";
                txt_productPrice.Text = "";
                catValue.Text = "";
                comboBox1.Text = "";
                if(rb_new.Checked==true)
                {
                    rb_new.Checked = false;
                }
                else
                {
                    rb_Used.Checked = false;
                }

                
                
            }

        }

        private void lbl_pType_Validating(object sender, CancelEventArgs e)
        {
            if (!rb_new.Checked && !rb_Used.Checked)
            {
                
                errorProvider1.SetError(lbl_pType, "Select product type");
                lbl_warning.Text = "Warning: Enter all required information to post Ad";
                e.Cancel = true;
            }
            else
            {
                
                e.Cancel = false;
                errorProvider1.Clear();
            }
            
        }

        private void txt_userName_Validated(object sender, EventArgs e)
        {

        }

        private void txt_userName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userName.Text))
            {
                e.Cancel = true;
                lbl_userWarning.Text = "Warning: Enter all required information user";
                errorProvider1.SetError(txt_userName, "Enter user name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txt_location_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_location.Text))
            {
                e.Cancel = true;
                lbl_userWarning.Text = "Warning: Enter all required information user";
                errorProvider1.SetError(txt_location, "Enter location of user");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txt_contact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_contact.Text))
            {
                e.Cancel = true;
                lbl_userWarning.Text = "Warning: Enter all required information user";
                errorProvider1.SetError(txt_contact, "Enter contact no of user");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox2, "Select at least one Category");
                e.Cancel = true;
                lbl_userWarning.Text = "Warning: Enter all required information user";
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void btn_userCreate_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Visible))
            {
                MessageBox.Show("User has been registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl_userWarning.Text = ">";
                User user = new User(txt_userName.Text, txt_contact.Text, txt_location.Text, new List<string>(cat));
                
                admin.registerObserver(user);
                txt_userName.Text = "";
                txt_location.Text = "";
                comboBox2.Text = "";
                lbl_catSelect.Text = "";
                txt_contact.Text = "";
                cat.Clear();
                
            }
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            foreach(Observer i in admin.obs)
            {
                richTextBox1.Text += "User details" + "\n\n";
                richTextBox1.Text += i.display();
                richTextBox1.Text += "\nSuggestions" + "\n\n";
                int count = 1;
                richTextBox1.Text += "---------------------------------------\n\n";
                foreach (Ads ad in i.interest())
                {
                    richTextBox1.Text += "Ad: " + count.ToString()+ "\n";
                    richTextBox1.Text += "Category: "+ad.Category+"\n";
                    richTextBox1.Text += "Product Name: " + ad.ProdName + "\n";
                    richTextBox1.Text += "Price: "+ad.Price+"\n" + "\n";
                    richTextBox1.Text += "---------------------------------------\n\n";
                    count++;
                }
                richTextBox1.Text += "\n**************************************************\n\n";

                
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ads_Form obj = new Ads_Form(new List<Observer>(admin.obs));
            obj.Show();

        }

        private void btn_newAd_Click(object sender, EventArgs e)
        {
            New_Category new_Category = new New_Category();
            
            if(new_Category.ShowDialog()==DialogResult.OK)
            {
                comboBox1.Items.Add(new_Category.newCat);
                comboBox2.Items.Add(new_Category.newCat);
            }
        }

        private void btn_removeCat_Click(object sender, EventArgs e)
        {
            List<string> currentCat=new List<string>();
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                currentCat.Add(comboBox1.Items[i].ToString());
            }
            Remove_Category obj = new Remove_Category(new List<string>(currentCat));
            if(obj.ShowDialog()==DialogResult.OK)
            {
                comboBox1.Items.Remove(obj.toRemove);
                comboBox2.Items.Remove(obj.toRemove);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SearchUser searchUser = new SearchUser();
            searchUser.Show();
        }
    }
}
