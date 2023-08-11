using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h_satranc
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.ProgressBarStyle Style { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
                progressBar1.Value++;
            else
            {
                timer1.Stop();
                this.Hide();
                Form2 baslangc = new Form2();
                baslangc.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
