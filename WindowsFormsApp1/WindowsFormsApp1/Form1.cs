using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Random rnd = new Random();

            int r, g, b;
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            this.BackColor = Color.CadetBlue;
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            Random rnd = new Random();
            int r, g, b;
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
        }



        private void lbl2_DoubleClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r, g, b;
            r = rnd.Next(0, 255);
            g = rnd.Next(0, 255);
            b = rnd.Next(0, 255);

            lbl2.ForeColor = Color.FromArgb(r, g, b);
            lbl2.BackColor = Color.Magenta; 
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            int x, y;

            Random random = new Random();
            x = random.Next(0, 930);
            y = random.Next(0, 430);

            label1.Left = x;
            label1.Top = y;
        }

        private void lbl3_MouseClick(object sender, MouseEventArgs e)
        {
            string name;
            name = lbl3.Text;
            lbl3.BackColor = Color.FromName(name);
        }

        private void Mouse_Enter_MouseEnter(object sender, EventArgs e)
        {

            Change_Text.Text = "Tack för att du har använt mitt fina program";
        }

        private void Mouse_Enter_Click(object sender, EventArgs e)
        {
            Mouse_Enter.BackColor = Color.Wheat;
        }

        private void Mouse_Enter_MouseLeave(object sender, EventArgs e)
        {
            Change_Text.Text = "Hover over blue";
        }

        private void Mathclicker_MouseClick(object sender, MouseEventArgs e)
        {
            score++;
            this.Text = score.ToString();
        }
    }
}
