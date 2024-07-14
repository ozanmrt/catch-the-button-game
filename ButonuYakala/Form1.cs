using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonuYakala
{
    public partial class Form1 : Form
    {
        int sayi;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            Random rs = new Random();
            int a, b;
            a = rs.Next(0, 30);
            b = rs.Next(14, 129);
            button1.Location = new Point(a, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Tebrikler "+sayi+" Saniyede Yakaladın!\nTekrar Denemeye Ne Dersin :)");
            button1.Location=new Point(50, 72);
            label2.Text = "0";
            button3.Visible = true;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(label2.Text);
            sayi++;
            label2.Text = sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label2.Text="0";
            button1.Location = new Point(50, 72);
            timer1.Enabled = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button3.Visible = false;
            Random rs = new Random();
            int a = rs.Next(0, 30);
            int b = rs.Next(14, 129);
            button1.Location = new Point(a, b);
            button2.Enabled = true;
        }
    }
}
