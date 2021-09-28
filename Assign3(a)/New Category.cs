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
    public partial class New_Category : Form
    {
        public string newCat;
        public New_Category()
        {
            InitializeComponent();
            newCat = "";
            btn_newSubmit.DialogResult = DialogResult.OK;
            btn_clear.DialogResult = DialogResult.Cancel;
        }

        private void New_Category_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_newSubmit_Click(object sender, EventArgs e)
        {
            newCat = txt_newCategory.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_newCategory.Clear();
        }
    }
}
