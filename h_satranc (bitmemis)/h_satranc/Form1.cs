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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void VarsayilanRenkleri()
        {

            //SİYAHLAR

            //Piyonlar
            SP1.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            SP2.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            SP3.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            SP4.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            SP5.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            SP6.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            SP7.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            SP8.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);

            //Kaleler
            SK1.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            SK2.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);

            //Atlar
            SA1.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            SA2.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);

            //Filler
            SF1.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            SF2.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);

            //Vezir
            SV.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);

            //Şah
            SŞ.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);



            //BEYAZLAR

            //Piyonlar
            BP1.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            BP2.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            BP3.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            BP4.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            BP5.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            BP6.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            BP7.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            BP8.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);

            //Kaleler
            BK1.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            BK2.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);

            //Atlar
            BA1.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);
            BA2.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);

            //Filler
            BF1.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);
            BF2.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);

            //Vezir 
            BV.BackColor = System.Drawing.Color.FromArgb(104, 69, 0);

            //Şah 
            BŞ.BackColor = System.Drawing.Color.FromArgb(188, 182, 177);


        }
    }
}
