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
    public partial class Ads_Form : Form
    {
        List<Observer> observers;
        public Ads_Form(List<Observer> obj)
        {
            InitializeComponent();
            observers = obj;
        }

        private void Ads_Form_Load(object sender, EventArgs e)
        {

            foreach (Observer i in observers)
            {
                int count = 1;
                foreach (Ads ad in i.interest())
                {
                    richTextBox2.Text += "Ad: " + count.ToString() + "\n";
                    richTextBox2.Text += "Category: " + ad.Category + "\n";
                    richTextBox2.Text += "Product Name: " + ad.ProdName + "\n";
                    richTextBox2.Text += "Price: " + ad.Price + "\n" + "\n";
                    richTextBox2.Text += "====================\n\n";
                    count++;
                }
                richTextBox2.Text += "\n********************\n\n";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
