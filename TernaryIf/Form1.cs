using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TernaryIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTernaryIf_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtSayi.Text);
            

            int absNumber = (number < 0) ? -1 * number : number;
            MessageBox.Show(absNumber.ToString());


        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
