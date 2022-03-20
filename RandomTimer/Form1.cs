using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //label1.Text = rnd.Next(100).ToString();

            //DateTime zamaNe = DateTime.Now;
            //label1.Text = zamaNe.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            timer1.Interval = 10000; // 10 sn.de bir ! :)

            //timer1.Stop();
        }
    }
}
