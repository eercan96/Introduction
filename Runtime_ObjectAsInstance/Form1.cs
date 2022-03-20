using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runtime_ObjectAsInstance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Button customButton = new Button();

            customButton.Width = 70;
            customButton.Height = 30;
            customButton.Text = "New:)";

            Random rnd = new Random();
            customButton.Location = new Point(rnd.Next(350), rnd.Next(350)); // (rnd.Next(), rnd.Next()); 

            //Location ya da left-top ile button yerlerini belirleyebiliriz!:)
            // selin.Left = rnd.Next(50, 350);
            // selin.Top = rnd.Next(350);
            customButton.Parent = this;
        }
    }
}
