namespace Garage
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garageGraficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxProprietà = new System.Windows.Forms.GroupBox();
            this.labelErroreLimite = new System.Windows.Forms.Label();
            this.labelErroreTarga = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelRisultatoUscita = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.labelRisultatoRicerca = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAuto = new System.Windows.Forms.Label();
            this.labelProprietà = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxProprietà.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 343);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Image = global::Garage.Properties.Resources.add1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(0, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 152);
            this.button2.TabIndex = 2;
            this.button2.Text = "Aggiungi garage";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelHeader.Font = new System.Drawing.Font("Magneto", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Teal;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(159, 36);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "LG";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelHeader_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Image = global::Garage.Properties.Resources.add1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(0, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 153);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aggiungi garage";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(155, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 36);
            this.label1.TabIndex = 2;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mostraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(163, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(111, 24);
            this.menuStrip1.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem,
            this.salvaToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.apriToolStripMenuItem.Text = "Apri";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // mostraToolStripMenuItem
            // 
            this.mostraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticheToolStripMenuItem,
            this.garageGraficoToolStripMenuItem});
            this.mostraToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostraToolStripMenuItem.Name = "mostraToolStripMenuItem";
            this.mostraToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.mostraToolStripMenuItem.Text = "Mostra";
            // 
            // statisticheToolStripMenuItem
            // 
            this.statisticheToolStripMenuItem.Name = "statisticheToolStripMenuItem";
            this.statisticheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statisticheToolStripMenuItem.Text = "Statistiche";
            this.statisticheToolStripMenuItem.Click += new System.EventHandler(this.statisticheToolStripMenuItem_Click);
            // 
            // garageGraficoToolStripMenuItem
            // 
            this.garageGraficoToolStripMenuItem.Name = "garageGraficoToolStripMenuItem";
            this.garageGraficoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.garageGraficoToolStripMenuItem.Text = "Garage grafico";
            this.garageGraficoToolStripMenuItem.Click += new System.EventHandler(this.garageGraficoToolStripMenuItem_Click);
            // 
            // groupBoxProprietà
            // 
            this.groupBoxProprietà.Controls.Add(this.labelErroreLimite);
            this.groupBoxProprietà.Controls.Add(this.labelErroreTarga);
            this.groupBoxProprietà.Controls.Add(this.comboBox4);
            this.groupBoxProprietà.Controls.Add(this.label17);
            this.groupBoxProprietà.Controls.Add(this.labelRisultatoUscita);
            this.groupBoxProprietà.Controls.Add(this.button5);
            this.groupBoxProprietà.Controls.Add(this.label16);
            this.groupBoxProprietà.Controls.Add(this.textBox7);
            this.groupBoxProprietà.Controls.Add(this.label15);
            this.groupBoxProprietà.Controls.Add(this.labelRisultatoRicerca);
            this.groupBoxProprietà.Controls.Add(this.button4);
            this.groupBoxProprietà.Controls.Add(this.label14);
            this.groupBoxProprietà.Controls.Add(this.textBox6);
            this.groupBoxProprietà.Controls.Add(this.label13);
            this.groupBoxProprietà.Controls.Add(this.label12);
            this.groupBoxProprietà.Controls.Add(this.comboBox3);
            this.groupBoxProprietà.Controls.Add(this.comboBox2);
            this.groupBoxProprietà.Controls.Add(this.label11);
            this.groupBoxProprietà.Controls.Add(this.label10);
            this.groupBoxProprietà.Controls.Add(this.label9);
            this.groupBoxProprietà.Controls.Add(this.label8);
            this.groupBoxProprietà.Controls.Add(this.label7);
            this.groupBoxProprietà.Controls.Add(this.label6);
            this.groupBoxProprietà.Controls.Add(this.label5);
            this.groupBoxProprietà.Controls.Add(this.label4);
            this.groupBoxProprietà.Controls.Add(this.button3);
            this.groupBoxProprietà.Controls.Add(this.textBox5);
            this.groupBoxProprietà.Controls.Add(this.textBox4);
            this.groupBoxProprietà.Controls.Add(this.textBox3);
            this.groupBoxProprietà.Controls.Add(this.textBox2);
            this.groupBoxProprietà.Controls.Add(this.label2);
            this.groupBoxProprietà.Controls.Add(this.checkBox1);
            this.groupBoxProprietà.Controls.Add(this.comboBox1);
            this.groupBoxProprietà.Controls.Add(this.textBox1);
            this.groupBoxProprietà.Controls.Add(this.labelAuto);
            this.groupBoxProprietà.Controls.Add(this.labelProprietà);
            this.groupBoxProprietà.Controls.Add(this.label3);
            this.groupBoxProprietà.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProprietà.Location = new System.Drawing.Point(163, 39);
            this.groupBoxProprietà.Name = "groupBoxProprietà";
            this.groupBoxProprietà.Size = new System.Drawing.Size(579, 297);
            this.groupBoxProprietà.TabIndex = 4;
            this.groupBoxProprietà.TabStop = false;
            this.groupBoxProprietà.Visible = false;
            // 
            // labelErroreLimite
            // 
            this.labelErroreLimite.BackColor = System.Drawing.Color.Red;
            this.labelErroreLimite.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErroreLimite.ForeColor = System.Drawing.Color.White;
            this.labelErroreLimite.Location = new System.Drawing.Point(138, 162);
            this.labelErroreLimite.Name = "labelErroreLimite";
            this.labelErroreLimite.Size = new System.Drawing.Size(216, 16);
            this.labelErroreLimite.TabIndex = 40;
            this.labelErroreLimite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelErroreLimite.Visible = false;
            // 
            // labelErroreTarga
            // 
            this.labelErroreTarga.BackColor = System.Drawing.Color.Red;
            this.labelErroreTarga.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErroreTarga.ForeColor = System.Drawing.Color.White;
            this.labelErroreTarga.Location = new System.Drawing.Point(360, 162);
            this.labelErroreTarga.Name = "labelErroreTarga";
            this.labelErroreTarga.Size = new System.Drawing.Size(93, 16);
            this.labelErroreTarga.TabIndex = 39;
            this.labelErroreTarga.Text = "Targa già usata";
            this.labelErroreTarga.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelErroreTarga.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.comboBox4.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.comboBox4.Location = new System.Drawing.Point(237, 256);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(78, 24);
            this.comboBox4.TabIndex = 38;
            this.comboBox4.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(236, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 15);
            this.label17.TabIndex = 37;
            this.label17.Text = "Orario uscita";
            this.label17.Visible = false;
            // 
            // labelRisultatoUscita
            // 
            this.labelRisultatoUscita.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRisultatoUscita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRisultatoUscita.Location = new System.Drawing.Point(385, 248);
            this.labelRisultatoUscita.Name = "labelRisultatoUscita";
            this.labelRisultatoUscita.Size = new System.Drawing.Size(185, 39);
            this.labelRisultatoUscita.TabIndex = 36;
            this.labelRisultatoUscita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRisultatoUscita.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(321, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Esce";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(155, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "Posizione";
            this.label16.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox7.Location = new System.Drawing.Point(138, 257);
            this.textBox7.MaxLength = 2;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(93, 23);
            this.textBox7.TabIndex = 33;
            this.textBox7.Visible = false;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(28, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 24);
            this.label15.TabIndex = 32;
            this.label15.Text = "Esce veicolo";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Visible = false;
            // 
            // labelRisultatoRicerca
            // 
            this.labelRisultatoRicerca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRisultatoRicerca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRisultatoRicerca.Location = new System.Drawing.Point(301, 208);
            this.labelRisultatoRicerca.Name = "labelRisultatoRicerca";
            this.labelRisultatoRicerca.Size = new System.Drawing.Size(272, 23);
            this.labelRisultatoRicerca.TabIndex = 31;
            this.labelRisultatoRicerca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRisultatoRicerca.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(237, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Cerca";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(138, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Targa";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox6.Location = new System.Drawing.Point(138, 208);
            this.textBox6.MaxLength = 7;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(93, 23);
            this.textBox6.TabIndex = 28;
            this.textBox6.Visible = false;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(28, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "Cerca veicolo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(4, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(570, 1);
            this.label12.TabIndex = 26;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormatString = "t";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.comboBox3.Location = new System.Drawing.Point(360, 133);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(78, 24);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormatString = "t";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.comboBox2.Location = new System.Drawing.Point(360, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 24);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(450, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Lunghezza";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(452, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cilindrata";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(357, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Orario entrata";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(357, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Orario entrata";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(357, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Orario entrata";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(287, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Targa";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(287, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Targa";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(287, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Targa";
            this.label4.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(524, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 155);
            this.button3.TabIndex = 15;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox5.Location = new System.Drawing.Point(444, 134);
            this.textBox5.MaxLength = 3;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 23);
            this.textBox5.TabIndex = 14;
            this.textBox5.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox4.Location = new System.Drawing.Point(444, 86);
            this.textBox4.MaxLength = 4;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 23);
            this.textBox4.TabIndex = 13;
            this.textBox4.Visible = false;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(261, 134);
            this.textBox3.MaxLength = 7;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 23);
            this.textBox3.TabIndex = 10;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(261, 86);
            this.textBox2.MaxLength = 7;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(136, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aggiungi moto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(444, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Elettrica";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormatString = "t";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.comboBox1.Location = new System.Drawing.Point(360, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(261, 39);
            this.textBox1.MaxLength = 7;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // labelAuto
            // 
            this.labelAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelAuto.Location = new System.Drawing.Point(135, 25);
            this.labelAuto.Name = "labelAuto";
            this.labelAuto.Size = new System.Drawing.Size(104, 48);
            this.labelAuto.TabIndex = 1;
            this.labelAuto.Text = "Aggiungi auto";
            this.labelAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAuto.Visible = false;
            // 
            // labelProprietà
            // 
            this.labelProprietà.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelProprietà.Location = new System.Drawing.Point(6, 22);
            this.labelProprietà.Name = "labelProprietà";
            this.labelProprietà.Size = new System.Drawing.Size(124, 150);
            this.labelProprietà.TabIndex = 0;
            this.labelProprietà.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProprietà.Visible = false;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(135, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Aggiungi furgone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Garage.Properties.Resources.closeWindow;
            this.pictureBox1.Location = new System.Drawing.Point(716, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(751, 343);
            this.Controls.Add(this.groupBoxProprietà);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxProprietà.ResumeLayout(false);
            this.groupBoxProprietà.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxProprietà;
        private System.Windows.Forms.Label labelProprietà;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAuto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelRisultatoUscita;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelRisultatoRicerca;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelErroreLimite;
        private System.Windows.Forms.Label labelErroreTarga;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garageGraficoToolStripMenuItem;
    }
}

