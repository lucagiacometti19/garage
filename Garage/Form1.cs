using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Garage
{
    public partial class Form1 : Form
    {
        //campi pubblici
        public Garage[] g;
        public int appoggio = 0;
        public int garageSelezionato = 0;
        //campi privati
        private int ticks;
        private string pathLogFile;
        private double durataParcheggioMedioAutoG1 = 0;
        private double durataParcheggioMedioAutoG2 = 0;
        private double durataParcheggioMedioMotoG1 = 0;
        private double durataParcheggioMedioMotoG2 = 0;
        private double durataParcheggioMedioFurgoneG1 = 0;
        private double durataParcheggioMedioFurgoneG2 = 0;
        private int appoggioDurataAutoG1 = 1;
        private int appoggioDurataAutoG2 = 1;
        private int appoggioDurataMotoG1 = 1;
        private int appoggioDurataMotoG2 = 1;
        private int appoggioDurataFurgoneG1 = 1;
        private int appoggioDurataFurgoneG2 = 1;        
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        //logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Form1");
        
        public Form1()
        {
            InitializeComponent();
            g = new Garage[2];          //permetto all'utente si creare al massimo 2 garage con larghezza personalizzata
            timer2.Interval = 1000; timer2.Tick += new EventHandler(timer2_Tick);
            ticks = 0;
            pathLogFile = @"..\..\bin\Debug\log.txt";
            textBox5.KeyPress += textBox4_KeyPress;
            textBox7.KeyPress += textBox4_KeyPress;
            
            if (File.Exists(pathLogFile))
            {
                File.Delete(pathLogFile);
            }
            log.Debug("Programma 'garage' iniziato; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; ");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ticks == 3)
            {
                labelErroreLimite.Visible = false;
                labelErroreTarga.Visible = false;
                timer2.Enabled = false;
                ticks = 0;
            }
            else
            {
                ticks++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            string path = @"..\..\Resources\\closeWindow Hover.png";
            pictureBox1.Load(Path.GetFullPath(path));
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            string path = @"..\..\Resources\\closeWindow.png";
            pictureBox1.Load(Path.GetFullPath(path));
            GC.Collect();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void button1_MouseDown(object sender, MouseEventArgs e)
        {
            garageSelezionato = 0;
            if (e.Button == MouseButtons.Left && g[0] == null)                              //si è premuto col tasto sinistro
            {
                //mostro un nuovo form
                log.Info("Click sul 'bottone1', apertura Form2; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; ");
                Form2 f2 = new Form2();
                f2.Show(this);
            }
            else if (e.Button == MouseButtons.Left && g[0] != null)
            {
                button1.BackColor = Color.DarkGray;
                if (g[1] != null)
                    button2.BackColor = Color.LightGray;
                groupBoxProprietà.Visible = true;
                groupBoxProprietà.Text = g[garageSelezionato].Nome;
                labelProprietà.Visible = true;
                labelProprietà.Text = "Numero auto: " + (g[garageSelezionato].NumeroAuto + g[garageSelezionato].NumeroAutoElettriche) + "\n\n\n" + "Numero moto: " + g[garageSelezionato].NumeroMoto + "\n\n\n" + "Numero furgoni: " + g[garageSelezionato].NumeroFurgoni;
                foreach (TextBox t in FindControls<TextBox>(groupBoxProprietà))
                {
                    t.Visible = true; t.Text = "";
                }
                foreach (ComboBox c in FindControls<ComboBox>(groupBoxProprietà)) { c.Visible = true; c.Text = ""; }
                foreach (Label l in FindControls<Label>(groupBoxProprietà))
                {
                    if (l.Name == "labelErroreTarga" || l.Name == "labelErroreLimite") { }
                    else
                        l.Visible = true;
                }
                foreach (Button b in FindControls<Button>(groupBoxProprietà)) { b.Visible = true; }
                checkBox1.Visible = true; checkBox1.Checked = false;
                labelRisultatoRicerca.Text = "";
                labelRisultatoUscita.Text = "";
            }
        }

        public List<T> FindControls<T>(Control parent) where T : Control
        {
            List<T> foundControls = new List<T>();
            FindControls<T>(parent, foundControls);
            return foundControls;
        }

        public void FindControls<T>(Control parent, List<T> foundControls) where T : Control
        {
            foreach (Control c in parent.Controls)
            {
                if (c is T)
                    foundControls.Add((T)c);
                else if (c.Controls.Count > 0)
                    FindControls<T>(c, foundControls);
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            garageSelezionato = 1;
            if (e.Button == MouseButtons.Left && g[1] == null)                              //si è premuto col tasto sinistro
            {
                //mostro un nuovo form
                log.Info("Click sul 'bottone2', apertura Form2; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; ");
                Form2 f2 = new Form2();
                f2.Show(this);
            }
            else if (e.Button == MouseButtons.Left && g[1] != null)
            {
                button2.BackColor = Color.DarkGray;
                button1.BackColor = Color.LightGray;
                groupBoxProprietà.Visible = true;
                groupBoxProprietà.Text = g[garageSelezionato].Nome;
                labelProprietà.Visible = true;
                labelProprietà.Text = "Numero auto: " + (g[garageSelezionato].NumeroAuto + g[garageSelezionato].NumeroAutoElettriche) + "\n\n\n" + "Numero moto: " + g[garageSelezionato].NumeroMoto + "\n\n\n" + "Numero furgoni: " + g[garageSelezionato].NumeroFurgoni;
                foreach (TextBox t in FindControls<TextBox>(groupBoxProprietà))
                {
                    t.Visible = true; t.Text = "";
                }
                foreach (ComboBox c in FindControls<ComboBox>(groupBoxProprietà)) { c.Visible = true; c.Text = ""; }
                foreach (Label l in FindControls<Label>(groupBoxProprietà))
                {
                    if (l.Name == "labelErroreTarga" || l.Name == "labelErroreLimite") { }
                    else
                        l.Visible = true;
                }
                foreach (Button b in FindControls<Button>(groupBoxProprietà)) { b.Visible = true; }
                checkBox1.Visible = true; checkBox1.Checked = false;
                labelRisultatoRicerca.Text = "";
                labelRisultatoUscita.Text = "";
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cb1 = ""; string cb2 = ""; string cb3 = "";
            try
            {
                cb1 = comboBox1.Text.Substring(0, 2);
            }
            catch { /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ERROR; Orario di entrata dell'auto mancante o non accettabile;" + Environment.NewLine); */}
            try
            {
                cb2 = comboBox2.Text.Substring(0, 2);
            }
            catch { /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ERROR; Orario di entrata della moto mancante o non accettabile;" + Environment.NewLine); */}
            try
            {
                cb3 = comboBox3.Text.Substring(0, 2);
            }
            catch { /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ERROR; Orario di entrata del furgone mancante o non accettabile;" + Environment.NewLine);*/ }
            //aggiungo l'auto
            if (textBox1.Text != "" && cb1 != null)
            {
                if (g[garageSelezionato].IsTargaUnique(textBox1.Text))
                {
                    Auto auto = new Auto { Targa = textBox1.Text, OraDiIngresso = Convert.ToInt32(cb1), IsElettrica = checkBox1.Checked };
                    if (auto.IsElettrica) { g[garageSelezionato].EntraVeicoloElettrico(auto); }
                    else { g[garageSelezionato].EntraVeicoloNonElettrico(auto); }
                    textBox1.Text = "";
                    comboBox1.Text = "";
                    checkBox1.Checked = false;
                    if (g[garageSelezionato].CercaVeicolo(auto.Targa) == -1) { timer2.Enabled = true; labelErroreLimite.Visible = true; labelErroreLimite.Text = "Spazio esaurito, auto non parcheggiata"; log.Error("Spazio esaurito, auto non parcheggiata;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;"); /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ERROR; Spazio esaurito, auto non parcheggiata;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + Environment.NewLine);*/ }
                    else { log.Info("Auto creata e parcheggiata con successo;" + g[garageSelezionato].NumeroAuto + ";" + g[garageSelezionato].NumeroAutoElettriche + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + garageSelezionato + ";"); /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ADD; Auto creata e parcheggiata con successo;" + g[garageSelezionato].NumeroAuto + ";" + g[garageSelezionato].NumeroAutoElettriche + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + garageSelezionato + ";" + Environment.NewLine);*/ }
                }
                else
                {
                    labelErroreTarga.Visible = true; timer2.Enabled = true;
                    textBox1.Text = "";
                    comboBox1.Text = "";
                    checkBox1.Checked = false;
                }
            }
            //aggiungo la moto
            if (textBox2.Text != "" && cb2 != null && textBox4.Text != "")
            {
                if (g[garageSelezionato].IsTargaUnique(textBox2.Text))
                {
                    Moto moto = new Moto { Targa = textBox2.Text, OraDiIngresso = Convert.ToInt32(cb2), Cilindrata = Convert.ToInt32(textBox4.Text) };
                    g[garageSelezionato].EntraVeicoloNonElettrico(moto);
                    textBox2.Text = "";
                    comboBox2.Text = "";
                    textBox4.Text = "";
                    if (g[garageSelezionato].CercaVeicolo(moto.Targa) == -1) { timer2.Enabled = true; labelErroreLimite.Visible = true; labelErroreLimite.Text = "Spazio esaurito, moto non parcheggiata"; log.Error("Spazio esaurito, moto non parcheggiata;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;"); /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ERROR; Spazio esaurito, moto non parcheggiata;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + Environment.NewLine);*/ }
                    else { log.Info("Moto creata e parcheggiata con successo;" + " ;" + " ;" + g[garageSelezionato].NumeroMoto + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + garageSelezionato + ";"); /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ADD; Moto creata e parcheggiata con successo;" + " ;" + " ;" + g[garageSelezionato].NumeroMoto + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + ";" + " ;" + garageSelezionato + ";" + Environment.NewLine);*/ }
                }
                else
                {
                    labelErroreTarga.Visible = true; timer2.Enabled = true;
                    textBox2.Text = "";
                    comboBox2.Text = "";
                    textBox4.Text = "";
                }
            }
            if (textBox3.Text != "" && cb3 != null && textBox5.Text != "")
            {
                if (g[garageSelezionato].IsTargaUnique(textBox3.Text))
                {
                    Furgone furgone = new Furgone { Targa = textBox3.Text, OraDiIngresso = Convert.ToInt32(cb3), Lunghezza = Convert.ToInt32(textBox5.Text) };
                    g[garageSelezionato].EntraVeicoloNonElettrico(furgone);
                    textBox3.Text = "";
                    comboBox3.Text = "";
                    textBox5.Text = "";
                    if (g[garageSelezionato].CercaVeicolo(furgone.Targa) == -1) { timer2.Enabled = true; labelErroreLimite.Visible = true; labelErroreLimite.Text = "Spazio esaurito, furgone non parcheggiato"; log.Error("Spazio esaurito, furgone non parcheggiato;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;"); /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ERROR; Spazio esaurito, furgone non parcheggiato;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + Environment.NewLine);*/ }
                    else { log.Info("Furgone creato e parcheggiato con successo;" + " ;" + " ;" + " ;" + g[garageSelezionato].NumeroFurgoni + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + garageSelezionato + ";"); /*sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ADD; Furgone creato e parcheggiato con successo;" + " ;" + " ;" + " ;" + g[garageSelezionato].NumeroFurgoni + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + garageSelezionato + ";" + Environment.NewLine);*/ }
                }
                else
                {
                    labelErroreTarga.Visible = true;
                    textBox3.Text = "";
                    comboBox3.Text = "";
                    textBox5.Text = "";
                }
            }
            labelProprietà.Text = "Numero auto: " + (g[garageSelezionato].NumeroAuto + g[garageSelezionato].NumeroAutoElettriche) + "\n\n\n" + "Numero moto: " + g[garageSelezionato].NumeroMoto + "\n\n\n" + "Numero furgoni: " + g[garageSelezionato].NumeroFurgoni;
            if (g[garageSelezionato].NumeroAutoElettriche >= 10)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (label14.Text == "Targa")
                {
                    if (g[garageSelezionato].CercaVeicolo(textBox6.Text) == -1)
                    {
                        labelRisultatoRicerca.Text = "Nessuna corrispondenza";
                    }
                    else
                    {
                        labelRisultatoRicerca.Text = "Il veicolo è in posizione " + g[garageSelezionato].CercaVeicolo(textBox6.Text);
                    }
                }
                else
                {
                    labelRisultatoRicerca.Text = g[garageSelezionato].CercaVeicolo(Convert.ToInt32(textBox6.Text) - 1);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool auto = false; bool moto = false; bool furgone = false;
            if (textBox7.Text != "" && comboBox4.Text != "")
            {
                if (g[garageSelezionato].ArrayDiVeicoli[Convert.ToInt32(textBox7.Text) - 1] is Auto)
                    auto = true;
                else if (g[garageSelezionato].ArrayDiVeicoli[Convert.ToInt32(textBox7.Text) - 1] is Moto)
                    moto = true;
                else
                    furgone = true;
                string orarioDiUscita = comboBox4.Text.Substring(0, 2);
                labelRisultatoUscita.Text = "€ " + g[garageSelezionato].EsceVeicolo(Convert.ToInt32(textBox7.Text) - 1, Convert.ToInt32(orarioDiUscita)).ToString();
                labelProprietà.Text = "Numero auto: " + (g[garageSelezionato].NumeroAuto + g[garageSelezionato].NumeroAutoElettriche) + "\n\n\n" + "Numero moto: " + g[garageSelezionato].NumeroMoto + "\n\n\n" + "Numero furgoni: " + g[garageSelezionato].NumeroFurgoni;
                textBox7.Text = "";
                comboBox4.Text = "";
                if (labelRisultatoUscita.Text == "€ -1")
                {
                    labelRisultatoUscita.Text = "Posizione errata: parcheggio vuoto o oltre i limiti";
                }
                else
                {
                    if (garageSelezionato == 0)
                    {
                        if (auto)
                        {
                            durataParcheggioMedioAutoG1 = (durataParcheggioMedioAutoG1 + g[garageSelezionato].DurataParcheggioAuto) / appoggioDurataAutoG1; appoggioDurataAutoG1++;
                            log.Info("Veicolo 'uscito' con successo;" + g[garageSelezionato].NumeroAuto + ";" + g[garageSelezionato].NumeroAutoElettriche + ";" + g[garageSelezionato].NumeroMoto + ";" + g[garageSelezionato].NumeroFurgoni + ";" + " ;" + " ;" + " ;" + " ;" + durataParcheggioMedioAutoG1 + ";" + " ;" + " ;" + garageSelezionato + ";");
                        }
                        else if (moto)
                        {
                            durataParcheggioMedioMotoG1 = (durataParcheggioMedioMotoG1 + g[garageSelezionato].DurataParcheggioMoto) / appoggioDurataMotoG1; appoggioDurataMotoG1++;
                            log.Info("Veicolo 'uscito' con successo;" + g[garageSelezionato].NumeroAuto + ";" + g[garageSelezionato].NumeroAutoElettriche + ";" + g[garageSelezionato].NumeroMoto + ";" + g[garageSelezionato].NumeroFurgoni + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + durataParcheggioMedioMotoG1 + ";" + " ;" + garageSelezionato + ";");
                        }
                        else if (furgone)
                        {
                            durataParcheggioMedioFurgoneG1 = (durataParcheggioMedioFurgoneG1 + g[garageSelezionato].DurataParcheggioFurgone) / appoggioDurataFurgoneG1; appoggioDurataFurgoneG1++;
                            log.Info("Veicolo 'uscito' con successo; " + g[garageSelezionato].NumeroAuto + "; " + g[garageSelezionato].NumeroAutoElettriche + "; " + g[garageSelezionato].NumeroMoto + "; " + g[garageSelezionato].NumeroFurgoni + "; " + "; " + "; " + "; " + "; " + "; " + "; " + durataParcheggioMedioFurgoneG1 + "; " + garageSelezionato + "; ");
                        }
                    }
                    else
                    {
                        if (auto)
                        {
                            durataParcheggioMedioAutoG2 = (durataParcheggioMedioAutoG2 + g[garageSelezionato].DurataParcheggioAuto) / appoggioDurataAutoG2; appoggioDurataAutoG2++;
                            log.Info("Veicolo 'uscito' con successo; " + g[garageSelezionato].NumeroAuto + "; " + g[garageSelezionato].NumeroAutoElettriche + "; " + g[garageSelezionato].NumeroMoto + "; " + g[garageSelezionato].NumeroFurgoni + "; " + "; " + "; " + "; " + "; " + durataParcheggioMedioAutoG2 + "; " + "; " + "; " + garageSelezionato + "; ");
                        }
                        else if (moto)
                        {
                            durataParcheggioMedioMotoG2 = (durataParcheggioMedioMotoG2 + g[garageSelezionato].DurataParcheggioMoto) / appoggioDurataMotoG2; appoggioDurataMotoG2++;
                            log.Info("Veicolo 'uscito' con successo;" + g[garageSelezionato].NumeroAuto + ";" + g[garageSelezionato].NumeroAutoElettriche + ";" + g[garageSelezionato].NumeroMoto + ";" + g[garageSelezionato].NumeroFurgoni + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + durataParcheggioMedioMotoG2 + ";" + " ;" + garageSelezionato + ";");
                        }
                        else if (furgone)
                        {
                            durataParcheggioMedioFurgoneG2 = (durataParcheggioMedioFurgoneG2 + g[garageSelezionato].DurataParcheggioFurgone) / appoggioDurataFurgoneG2; appoggioDurataFurgoneG2++;
                            log.Info("Veicolo 'uscito' con successo;" + g[garageSelezionato].NumeroAuto + ";" + g[garageSelezionato].NumeroAutoElettriche + ";" + g[garageSelezionato].NumeroMoto + ";" + g[garageSelezionato].NumeroFurgoni + ";" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + durataParcheggioMedioFurgoneG2 + ";" + garageSelezionato + ";");
                        }
                    }
                }
            }
            if (g[garageSelezionato].NumeroAutoElettriche < 10)
                checkBox1.Enabled = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (label14.Text == "Targa")
            {
                label14.Text = "Posizione";
                textBox6.Text = "";
                textBox6.KeyPress += textBox4_KeyPress;
            }

            else
            {
                label14.Text = "Targa";
                textBox6.Text = "";
                textBox6.KeyPress -= textBox4_KeyPress;
            }
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Scegliere file da aprire",
                Filter = "Data Files (*.dat)|*.dat"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFile.FileName))
                {
                    using (StreamReader file = new StreamReader(openFile.FileName))
                    {
                        var serializer = new XmlSerializer(typeof(Garage[]), new Type[] { typeof(Veicolo), typeof(Auto), typeof(Furgone), typeof(Moto) });
                        g = (Garage[])serializer.Deserialize(file);
                        if (Directory.Exists(Path.GetDirectoryName(openFile.FileName)))
                        {
                            //elimino il log in utilizzo
                            if(File.Exists(pathLogFile))
                                File.Delete(pathLogFile);
                            File.Copy(Path.Combine(Path.GetDirectoryName(openFile.FileName), "log.txt"), pathLogFile);
                        }
                    }
                    Refresh();
                }
            }
        }

        private void statisticheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStats fs = new FormStats();
            fs.Show(this);
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Data Files (*.dat)|*.dat",
                DefaultExt = "dat",
                AddExtension = true
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                log.Info("Salvataggio dei dati;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;");
                string dir = Path.ChangeExtension(saveFile.FileName, null);     //prende tutto il path, ma senza estensione
                Directory.CreateDirectory(dir);
                string savePath = Path.Combine(dir, Path.GetFileName(saveFile.FileName));
                WriteToXmlFile(savePath, g);
                File.Copy(pathLogFile, Path.Combine(Path.ChangeExtension(saveFile.FileName, null), "log.txt"));
            }
        }

        /// <summary>
        /// Salva il file in XML
        /// </summary>
        /// <param name="filePath">Percorso dove salvare il file</param>
        /// <param name="objectToWrite">Il contenuto da salvare</param>
        /// <param name="append">append true sovrascrive tutto il file, append false salva i dati denza però cancellare i dati già scritti nel file</param>
        public void WriteToXmlFile(string filePath, Garage[] objectToWrite, bool append = false)
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(Garage[]), new Type[] { typeof(Veicolo), typeof(Auto), typeof(Furgone), typeof(Moto) });
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
            }
        }
        
        /// <summary>
        /// Aggiorna graficamente il form in base al contenuto dell'array garage
        /// </summary>
        public override void Refresh()
        {
            string path = @"..\..\Resources\\garage.png";
            button1.Visible = true;
            button2.Visible = true;
            if (g[0] != null)
            {
                button1.Image = new Bitmap(Path.GetFullPath(path));
                button1.BackColor = Color.LightGray;
                button1.Text = g[0].Nome;
                button1.ForeColor = Color.Black;
                button1.Font = new Font(button1.Font, FontStyle.Bold);
            }
            if (g[1] != null)
            {
                button2.Image = new Bitmap(Path.GetFullPath(path));
                button2.BackColor = Color.LightGray;
                button2.Text = g[1].Nome;
                button2.ForeColor = Color.Black;
                button2.Font = new Font(button2.Font, FontStyle.Bold);
            }
            base.Refresh();
            log.Info("Refresh grafico avvenuto con successo; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; ");
        }

        private void garageGraficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.Info("Click sul menuItem 'garage grafico', apertura 'FormGarageGrafico'; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; ");
            FormGarageGrafico form = new FormGarageGrafico();
            form.Show(this);
        }
    }
}
