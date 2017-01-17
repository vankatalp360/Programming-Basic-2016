using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _14.Чертане_с_костенурка
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }

        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                Turtle.Delay = 200;
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Green;
            for (int i = 0; i < 5; i++)
            {
                Turtle.Delay = 200;
                Turtle.Forward(200);
                Turtle.Rotate(144);              
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            int M = 15;
            int M1 = 0;

            for (int i = 0; i < 20; i++)
            {
                M1 = M + 7;
                M = M1;
                Turtle.Delay = 200;
                Turtle.Forward(M1);
                Turtle.Rotate(60);
            }
        }

        private void buttonDony_Click(object sender, EventArgs e)
        {

        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 50;
            for (int i = 0; i < 36; i++)
            {
                Turtle.Forward(250);
                Turtle.Rotate(170);
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.PenColor = Color.Red;
            for (int i = 0; i < 22; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(120);
            }
        }
    }
}
