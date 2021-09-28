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
    public partial class Remove_Category : Form
    {
        private List<string> categories;
        public string toRemove;
        public Remove_Category(List<string> cat)
        {
            categories = cat;
            InitializeComponent();
            toRemove = "";
            btn_removeOK.DialogResult = DialogResult.OK;
            
        }

        private void Remove_Category_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(String i in categories)
            {
                if(i.ToUpper()==txt_removeCat.Text.ToUpper())
                {
                    toRemove = i;
                }
            }
        }

        private void btn_catClear_Click(object sender, EventArgs e)
        {
            txt_removeCat.Clear();
        }
    }
}
