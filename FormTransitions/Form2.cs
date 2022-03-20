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
    public partial class Form2 : Form
    {
        Form1 ilkForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFormDegistir_Click(object sender, EventArgs e)
        {
            ilkForm = new Form1();
            ilkForm.Show();
            this.Hide();
        }
    }
}
