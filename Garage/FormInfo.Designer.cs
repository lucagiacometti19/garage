namespace Garage
{
    partial class FormInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTipoVeicolo = new System.Windows.Forms.Label();
            this.labelTarga = new System.Windows.Forms.Label();
            this.labelOrario = new System.Windows.Forms.Label();
            this.labelDescrizione = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 36);
            this.label1.TabIndex = 3;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Garage.Properties.Resources.closeWindow;
            this.pictureBox1.Location = new System.Drawing.Point(283, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // labelTipoVeicolo
            // 
            this.labelTipoVeicolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTipoVeicolo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoVeicolo.Location = new System.Drawing.Point(12, 48);
            this.labelTipoVeicolo.Name = "labelTipoVeicolo";
            this.labelTipoVeicolo.Size = new System.Drawing.Size(294, 23);
            this.labelTipoVeicolo.TabIndex = 5;
            this.labelTipoVeicolo.Text = "TIPO VEICOLO";
            this.labelTipoVeicolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTarga
            // 
            this.labelTarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelTarga.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelTarga.Location = new System.Drawing.Point(13, 94);
            this.labelTarga.Name = "labelTarga";
            this.labelTarga.Size = new System.Drawing.Size(130, 18);
            this.labelTarga.TabIndex = 6;
            this.labelTarga.Text = "Targa";
            this.labelTarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrario
            // 
            this.labelOrario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelOrario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelOrario.Location = new System.Drawing.Point(13, 125);
            this.labelOrario.Name = "labelOrario";
            this.labelOrario.Size = new System.Drawing.Size(130, 41);
            this.labelOrario.TabIndex = 7;
            this.labelOrario.Text = "Ora di ingresso";
            this.labelOrario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescrizione
            // 
            this.labelDescrizione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelDescrizione.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.labelDescrizione.Location = new System.Drawing.Point(12, 179);
            this.labelDescrizione.Name = "labelDescrizione";
            this.labelDescrizione.Size = new System.Drawing.Size(131, 37);
            this.labelDescrizione.TabIndex = 8;
            this.labelDescrizione.Text = "Descrizione";
            this.labelDescrizione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(149, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 18);
            this.label6.TabIndex = 9;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(149, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 41);
            this.label7.TabIndex = 10;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 6.5F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(152, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 37);
            this.label8.TabIndex = 11;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(318, 225);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDescrizione);
            this.Controls.Add(this.labelOrario);
            this.Controls.Add(this.labelTarga);
            this.Controls.Add(this.labelTipoVeicolo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfo";
            this.Text = "FormInfo";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTipoVeicolo;
        private System.Windows.Forms.Label labelTarga;
        private System.Windows.Forms.Label labelOrario;
        private System.Windows.Forms.Label labelDescrizione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}