using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int i = 1;

            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++;
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayac = 1;

            do
            {
                //  MessageBox.Show("Merhabalar arkadaşlar.......");
                listBox1.Items.Add(sayac);
                sayac++;

            } while (sayac <= 100);

        }

        private void btnWhileIki_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int sayac = 5;

            while (sayac > 0)
            {
                faktoriyel *= sayac;
                sayac--;
            }

            MessageBox.Show(faktoriyel.ToString());

        }

        private void btnDoWhileIki_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int sayac = 0;

            if (sayac == 0)
            {
                MessageBox.Show(faktoriyel.ToString());
            }

            do
            {
                // if kontrolü sayacın 0 geldiği durum için konulmalı....

                faktoriyel *= sayac;
                sayac--;

            } while (sayac > 0);

            MessageBox.Show(faktoriyel.ToString());

        }
    }
}
