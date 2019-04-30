namespace Garage
{
    partial class FormStats
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMoto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelNoStats = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTariffaAuto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTariffaMoto = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelTariffaFurgone = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelAuto = new System.Windows.Forms.Label();
            this.labelDurataAuto = new System.Windows.Forms.Label();
            this.labelDurataMoto = new System.Windows.Forms.Label();
            this.labelFurgone = new System.Windows.Forms.Label();
            this.labelDurataFurgone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(85, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 36);
            this.label1.TabIndex = 4;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHeader.Font = new System.Drawing.Font("Magneto", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Teal;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(85, 36);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "LG";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(395, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Esci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero di auto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero di auto eletriche";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero di moto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(187, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 10;
            this.label5.Tag = "info";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(187, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 11;
            this.label6.Tag = "info";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(187, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 12;
            this.label7.Tag = "info";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMoto
            // 
            this.labelMoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMoto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoto.Location = new System.Drawing.Point(302, 53);
            this.labelMoto.Name = "labelMoto";
            this.labelMoto.Size = new System.Drawing.Size(183, 19);
            this.labelMoto.TabIndex = 13;
            this.labelMoto.Text = "Durata media parcheggio moto";
            this.labelMoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(190, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 14;
            this.label9.Tag = "info";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNoStats
            // 
            this.labelNoStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNoStats.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoStats.ForeColor = System.Drawing.Color.Red;
            this.labelNoStats.Location = new System.Drawing.Point(29, 107);
            this.labelNoStats.Name = "labelNoStats";
            this.labelNoStats.Size = new System.Drawing.Size(528, 35);
            this.labelNoStats.TabIndex = 15;
            this.labelNoStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNoStats.Visible = false;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Numero di furgoni";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(29, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Garage 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(302, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tariffa auto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTariffaAuto
            // 
            this.labelTariffaAuto.Location = new System.Drawing.Point(460, 106);
            this.labelTariffaAuto.Name = "labelTariffaAuto";
            this.labelTariffaAuto.Size = new System.Drawing.Size(97, 19);
            this.labelTariffaAuto.TabIndex = 20;
            this.labelTariffaAuto.Tag = "info";
            this.labelTariffaAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(302, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 19);
            this.label14.TabIndex = 21;
            this.label14.Text = "Tariffa moto";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTariffaMoto
            // 
            this.labelTariffaMoto.Location = new System.Drawing.Point(460, 133);
            this.labelTariffaMoto.Name = "labelTariffaMoto";
            this.labelTariffaMoto.Size = new System.Drawing.Size(97, 19);
            this.labelTariffaMoto.TabIndex = 22;
            this.labelTariffaMoto.Tag = "info";
            this.labelTariffaMoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(302, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 19);
            this.label16.TabIndex = 23;
            this.label16.Text = "Tariffa furgone";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(302, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 19);
            this.label17.TabIndex = 24;
            this.label17.Text = "Nome garage";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTariffaFurgone
            // 
            this.labelTariffaFurgone.Location = new System.Drawing.Point(460, 160);
            this.labelTariffaFurgone.Name = "labelTariffaFurgone";
            this.labelTariffaFurgone.Size = new System.Drawing.Size(97, 19);
            this.labelTariffaFurgone.TabIndex = 25;
            this.labelTariffaFurgone.Tag = "info";
            this.labelTariffaFurgone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNome
            // 
            this.labelNome.Location = new System.Drawing.Point(460, 187);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(97, 19);
            this.labelNome.TabIndex = 26;
            this.labelNome.Tag = "info";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAuto
            // 
            this.labelAuto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAuto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuto.Location = new System.Drawing.Point(29, 162);
            this.labelAuto.Name = "labelAuto";
            this.labelAuto.Size = new System.Drawing.Size(183, 19);
            this.labelAuto.TabIndex = 27;
            this.labelAuto.Text = "Durata media parcheggio auto";
            this.labelAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDurataAuto
            // 
            this.labelDurataAuto.Location = new System.Drawing.Point(232, 162);
            this.labelDurataAuto.Name = "labelDurataAuto";
            this.labelDurataAuto.Size = new System.Drawing.Size(55, 19);
            this.labelDurataAuto.TabIndex = 28;
            this.labelDurataAuto.Tag = "info";
            this.labelDurataAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDurataMoto
            // 
            this.labelDurataMoto.Location = new System.Drawing.Point(502, 52);
            this.labelDurataMoto.Name = "labelDurataMoto";
            this.labelDurataMoto.Size = new System.Drawing.Size(55, 19);
            this.labelDurataMoto.TabIndex = 29;
            this.labelDurataMoto.Tag = "info";
            this.labelDurataMoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFurgone
            // 
            this.labelFurgone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFurgone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFurgone.Location = new System.Drawing.Point(302, 79);
            this.labelFurgone.Name = "labelFurgone";
            this.labelFurgone.Size = new System.Drawing.Size(203, 19);
            this.labelFurgone.TabIndex = 30;
            this.labelFurgone.Text = "Durata media parcheggio furgone";
            this.labelFurgone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDurataFurgone
            // 
            this.labelDurataFurgone.Location = new System.Drawing.Point(511, 78);
            this.labelDurataFurgone.Name = "labelDurataFurgone";
            this.labelDurataFurgone.Size = new System.Drawing.Size(46, 19);
            this.labelDurataFurgone.TabIndex = 31;
            this.labelDurataFurgone.Tag = "info";
            this.labelDurataFurgone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(590, 264);
            this.Controls.Add(this.labelDurataFurgone);
            this.Controls.Add(this.labelFurgone);
            this.Controls.Add(this.labelDurataMoto);
            this.Controls.Add(this.labelDurataAuto);
            this.Controls.Add(this.labelAuto);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelTariffaFurgone);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelTariffaMoto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelTariffaAuto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelMoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNoStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStats";
            this.Text = "FormStats";
            this.Shown += new System.EventHandler(this.FormStats_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeader;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labelMoto;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label labelNoStats;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label labelTariffaAuto;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label labelTariffaMoto;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label labelTariffaFurgone;
        public System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.Label labelAuto;
        public System.Windows.Forms.Label labelDurataAuto;
        public System.Windows.Forms.Label labelDurataMoto;
        public System.Windows.Forms.Label labelFurgone;
        public System.Windows.Forms.Label labelDurataFurgone;
    }
}