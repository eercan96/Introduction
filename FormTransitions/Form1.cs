using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTransitions
{
    public partial class Form1 : Form
    {
        Form2 frmNew = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnFormDegistir_Click(object sender, EventArgs e)
        {
            frmNew.Show();
            this.Hide();

            // this.Close();

        }
    }
}
