using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Програмка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string im = this.textBox1.Text;
             


            switch (im)
            {
                case "Дони": textBox2.Text = ("Ваньо"); break;
                case "Ваньо": textBox2.Text = ("Дони"); break;

            }

        }
    }
}
