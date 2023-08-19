using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_25._07._2023_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        } 
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = button1.Text;


        }


        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = button2.Text;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = textBox1.Text;
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = textBox2.Text;
        }

        private void checkBox1_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = checkBox1.Text;
        }

        private void checkBox2_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = checkBox2.Text;
        }

        private void radioButton1_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = radioButton1.Text;
        }

        private void radioButton2_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = radioButton2.Text;
        }
    }
}
