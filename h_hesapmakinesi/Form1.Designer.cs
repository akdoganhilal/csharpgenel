namespace h_hesapmakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnEksi = new System.Windows.Forms.Button();
            this.btnArti = new System.Windows.Forms.Button();
            this.btnEsit = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblIslem = new System.Windows.Forms.Label();
            this.btnVirgul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSonuc.Font = new System.Drawing.Font("BankGothic Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Black;
            this.lblSonuc.Location = new System.Drawing.Point(124, 40);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(171, 25);
            this.lblSonuc.TabIndex = 16;
            this.lblSonuc.Text = "Sonuç";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(30, 235);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 57);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(99, 235);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 57);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(168, 235);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 57);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(99, 300);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 57);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(99, 170);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 57);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(99, 106);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 57);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(168, 170);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 57);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(168, 106);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 57);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(30, 171);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 57);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(30, 106);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 57);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Transparent;
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("BankGothic Lt BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Maroon;
            this.btnC.Location = new System.Drawing.Point(33, 25);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(41, 39);
            this.btnC.TabIndex = 10;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnEksi
            // 
            this.btnEksi.BackColor = System.Drawing.Color.Transparent;
            this.btnEksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksi.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btnEksi.ForeColor = System.Drawing.Color.Maroon;
            this.btnEksi.Location = new System.Drawing.Point(236, 171);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(60, 57);
            this.btnEksi.TabIndex = 16;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = false;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // btnArti
            // 
            this.btnArti.BackColor = System.Drawing.Color.Transparent;
            this.btnArti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArti.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btnArti.ForeColor = System.Drawing.Color.Maroon;
            this.btnArti.Location = new System.Drawing.Point(236, 235);
            this.btnArti.Name = "btnArti";
            this.btnArti.Size = new System.Drawing.Size(60, 57);
            this.btnArti.TabIndex = 15;
            this.btnArti.Text = "+";
            this.btnArti.UseVisualStyleBackColor = false;
            this.btnArti.Click += new System.EventHandler(this.btnArti_Click);
            // 
            // btnEsit
            // 
            this.btnEsit.BackColor = System.Drawing.Color.Transparent;
            this.btnEsit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEsit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsit.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btnEsit.ForeColor = System.Drawing.Color.Maroon;
            this.btnEsit.Location = new System.Drawing.Point(236, 106);
            this.btnEsit.Name = "btnEsit";
            this.btnEsit.Size = new System.Drawing.Size(60, 57);
            this.btnEsit.TabIndex = 17;
            this.btnEsit.Text = "=";
            this.btnEsit.UseVisualStyleBackColor = false;
            this.btnEsit.Click += new System.EventHandler(this.btnEsit_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.BackColor = System.Drawing.Color.Transparent;
            this.btnCarp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarp.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btnCarp.ForeColor = System.Drawing.Color.Maroon;
            this.btnCarp.Location = new System.Drawing.Point(236, 300);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(60, 57);
            this.btnCarp.TabIndex = 14;
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = false;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.BackColor = System.Drawing.Color.Transparent;
            this.btnBol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBol.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F);
            this.btnBol.ForeColor = System.Drawing.Color.Maroon;
            this.btnBol.Location = new System.Drawing.Point(168, 300);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(60, 57);
            this.btnBol.TabIndex = 13;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = false;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // lblIslem
            // 
            this.lblIslem.BackColor = System.Drawing.Color.Transparent;
            this.lblIslem.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIslem.ForeColor = System.Drawing.Color.Black;
            this.lblIslem.Location = new System.Drawing.Point(124, 25);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(172, 15);
            this.lblIslem.TabIndex = 34;
            this.lblIslem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVirgul
            // 
            this.btnVirgul.BackColor = System.Drawing.Color.Transparent;
            this.btnVirgul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgul.Font = new System.Drawing.Font("BankGothic Lt BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgul.ForeColor = System.Drawing.Color.Maroon;
            this.btnVirgul.Location = new System.Drawing.Point(30, 300);
            this.btnVirgul.Name = "btnVirgul";
            this.btnVirgul.Size = new System.Drawing.Size(60, 57);
            this.btnVirgul.TabIndex = 12;
            this.btnVirgul.Text = ",";
            this.btnVirgul.UseVisualStyleBackColor = false;
            this.btnVirgul.Click += new System.EventHandler(this.btnVirgul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("BankGothic Lt BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Maroon;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(77, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(41, 39);
            this.btnSil.TabIndex = 11;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 383);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVirgul);
            this.Controls.Add(this.lblIslem);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnEsit);
            this.Controls.Add(this.btnArti);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblSonuc);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Thistle;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button btnArti;
        private System.Windows.Forms.Button btnEsit;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Button btnVirgul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Timer timer1;
    }
}

