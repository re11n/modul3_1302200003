using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302200003
{
    public partial class Form1 : Form
    {

        private string output = "";
        private string simpanangka = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            simpanangka = label1.Text;
            output = "";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            output = output + "1";
            label1.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            output = output + "0";
            label1.Text = output;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output = output + "2";
            label1.Text = output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output = output + "3";
            label1.Text = output;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output = output + "4";
            label1.Text = output;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output = output + "5";
            label1.Text = output;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output = output + "6";
            label1.Text = output;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            output = output + "7";
            label1.Text = output;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            output = output + "8";
            label1.Text = output;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            output = output + "9";
            label1.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ;
            var hasil = int.Parse(simpanangka) + int.Parse(output);
            label1.Text = "" + hasil;
        }
    }
}
