namespace h_satranc
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.basla = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basla
            // 
            this.basla.BackColor = System.Drawing.Color.Transparent;
            this.basla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.basla.ForeColor = System.Drawing.Color.Transparent;
            this.basla.Location = new System.Drawing.Point(54, 187);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(76, 24);
            this.basla.TabIndex = 0;
            this.basla.UseVisualStyleBackColor = false;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Transparent;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikis.ForeColor = System.Drawing.Color.Transparent;
            this.cikis.Location = new System.Drawing.Point(526, 187);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(59, 24);
            this.cikis.TabIndex = 1;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 411);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.basla);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.Button cikis;
    }
}