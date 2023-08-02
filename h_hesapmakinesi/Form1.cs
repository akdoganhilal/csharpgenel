using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h_hesapmakinesi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double sayi1 = 0; 
        bool yeniSayiGirisi = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            string textValue = "0";
            try
            {
                int result;
                if (int.TryParse(textValue, out result)) { lblSonuc.Text = result.ToString(); }
                else { Console.WriteLine("Dönüşüm başarısız!"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }          
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string deger = button.Text;

            if (yeniSayiGirisi)
            {
                lblSonuc.Text = deger;
                yeniSayiGirisi = false;
            }
            else
            {
                if (lblSonuc.Text == "0")
                {
                    lblSonuc.Text = deger;
                }
                else
                {
                    lblSonuc.Text += deger;
                }
            }
        }

        List<double> sayilar = new List<double>();
        List<string> islemler = new List<string>();
        private void btnBol_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string islem = button.Text;

            double sayi;
            if (double.TryParse(lblSonuc.Text, out sayi))
            {
                sayilar.Add(sayi);
                islemler.Add(islem);
                yeniSayiGirisi = true;
            }
            try { lblIslem.Text = string.Join(" ", sayilar.Select((x, i) => x.ToString() + " " + islemler[i]).ToArray()); }
            catch (Exception) { }
        }
        private void btnCarp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string islem = button.Text;

            double sayi;
            if (double.TryParse(lblSonuc.Text, out sayi))
            {
                sayilar.Add(sayi);
                islemler.Add(islem);
                yeniSayiGirisi = true;
            }
            try { lblIslem.Text = string.Join(" ", sayilar.Select((x, i) => x.ToString() + " " + islemler[i]).ToArray()); }
            catch (Exception) { }
        }
        private void btnArti_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string islem = button.Text;

            double sayi;
            if (double.TryParse(lblSonuc.Text, out sayi))
            {
                sayilar.Add(sayi);
                islemler.Add(islem);
                yeniSayiGirisi = true;
            }
            try { lblIslem.Text = string.Join(" ", sayilar.Select((x, i) => x.ToString() + " " + islemler[i]).ToArray()); }
            catch (Exception) { }
                        
        }
        private void btnEksi_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string islem = button.Text;

            double sayi;
            if (double.TryParse(lblSonuc.Text, out sayi))
            {
                sayilar.Add(sayi);
                islemler.Add(islem);
                yeniSayiGirisi = true;
            }
            try { lblIslem.Text = string.Join(" ", sayilar.Select((x, i) => x.ToString() + " " + islemler[i]).ToArray()); }
            catch (Exception) { }
        }
        private void btnEsit_Click(object sender, EventArgs e)
        {
            double sayi;
            if (double.TryParse(lblSonuc.Text, out sayi)) { sayilar.Add(sayi); }
            if (sayilar.Count > 0 && islemler.Count > 0 && sayilar.Count == islemler.Count + 1)
            {
                for (int i = 0; i < islemler.Count; i++)
                {
                    if (islemler[i] == "*" || islemler[i] == "/")
                    {
                        double operand1 = sayilar[i];
                        double operand2 = sayilar[i + 1];
                        double result = 0;

                        switch (islemler[i])
                        {
                            case "*":
                                result = operand1 * operand2;
                                break;
                            case "/":
                                if (operand2 != 0)
                                    result = operand1 / operand2;
                                else
                                {
                                    MessageBox.Show("Bir sayıyı 0'a bölemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    btnC_Click(sender, e);
                                    return;
                                }
                                break;
                        }
                        sayilar[i] = result;
                        sayilar.RemoveAt(i + 1);
                        islemler.RemoveAt(i);
                        i--; 
                    }
                }           
                double sonuc = sayilar[0];
                for (int i = 0; i < islemler.Count; i++)
                {
                    double operand = sayilar[i + 1];
                    switch (islemler[i])
                    {
                        case "+":
                            sonuc += operand;
                            break;
                        case "-":
                            sonuc -= operand;
                            break;
                    }
                }
                lblSonuc.Text = sonuc.ToString();
                lblIslem.Text = "";
                sayilar.Clear();
                islemler.Clear();
                yeniSayiGirisi = true;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = sayi1.ToString();
            lblIslem.Text = "";            
            sayilar.Clear();
            islemler.Clear();           
            yeniSayiGirisi = true;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text.Length > 1)
            {
                lblSonuc.Text = lblSonuc.Text.Substring(0, lblSonuc.Text.Length - 1);
            }
            else
            {
                lblSonuc.Text = "0";
                yeniSayiGirisi = true;
            }
        }
        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (!lblSonuc.Text.Contains("."))
            {
                if (yeniSayiGirisi)
                {
                    lblSonuc.Text = "0,";
                    yeniSayiGirisi = false;
                }
                else
                {
                    lblSonuc.Text += ",";
                }
            }
        }
    }
}