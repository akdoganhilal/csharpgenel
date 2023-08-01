using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h_renkliekolayzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Height = random.Next(240);
            panel2.Height = random.Next(240);
            panel3.Height = random.Next(240);
            panel4.Height = random.Next(240);
            panel5.Height = random.Next(240);
            panel6.Height = random.Next(240);
            panel7.Height = random.Next(240);
            panel8.Height = random.Next(240);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int x, y, z;

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer3.Enabled = true;
            x = random.Next(255);
            y = random.Next(255);
            z = random.Next(255);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.FromArgb(x, y, z);
            panel2.BackColor = Color.FromArgb(x, y, z);
            panel3.BackColor = Color.FromArgb(x, y, z);
            panel4.BackColor = Color.FromArgb(x, y, z);
            panel5.BackColor = Color.FromArgb(x, y, z);
            panel6.BackColor = Color.FromArgb(x, y, z);
            panel7.BackColor = Color.FromArgb(x, y, z);
            panel8.BackColor = Color.FromArgb(x, y, z);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer3.Enabled = false;
            panel1.BackColor = Color.PaleGreen;
            panel2.BackColor = Color.LightSteelBlue;
            panel3.BackColor = Color.MediumTurquoise;
            panel4.BackColor = Color.MediumOrchid;
            panel5.BackColor = Color.Crimson;
            panel6.BackColor = Color.LightPink;
            panel7.BackColor = Color.LightSalmon;
            panel8.BackColor = Color.OrangeRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            timer2.Enabled = true;
            x = random.Next(255);
            y = random.Next(255);
            z = random.Next(255);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {           
            panel1.BackColor = Color.FromArgb(x, y, z);
            panel2.BackColor = Color.FromArgb(x, z, y);
            panel3.BackColor = Color.FromArgb(y, z, x);
            panel4.BackColor = Color.FromArgb(y, y, z);
            panel5.BackColor = Color.FromArgb(z, x, y);
            panel6.BackColor = Color.FromArgb(z, y, x);
            panel7.BackColor = Color.FromArgb(x, x, z);
            panel8.BackColor = Color.FromArgb(y, x, z);
        }
    }
}
