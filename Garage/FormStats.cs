using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class FormStats : Form
    {
        //campi privati
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private Log log;
        private int garageSelezionato;
        private Form1 parent;

        public FormStats()
        {
            InitializeComponent();
            garageSelezionato = 0;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            Close();
            Dispose();
        }

        private void FormStats_Shown(object sender, EventArgs e)
        {
            parent = Owner as Form1;
            parent.Enabled = false;
            GetStats();
        }

        /// <summary>
        /// Analizza il file log e, in base al garage selezionato, ottiene le informazioni e le mostra
        /// </summary>
        private void GetStats()
        {
            if (File.Exists(@"..\..\bin\Debug\log.txt"))
            {
                SetDefaultTextOnLabels();
                log = new Log(garageSelezionato); bool finito = false; bool auto = false; bool autoElettrica = false; bool moto = false; bool furgone = false; bool durataAuto = false; bool durataMoto = false; bool durataFurgone = false; bool tarAuto = false; bool tarMoto = false; bool tarFurgone = false; bool nome = false; int i = 1;
                while (!finito)
                {
                    try
                    {
                        string logg = File.ReadLines(@"..\..\bin\Debug\log.txt").ElementAt((Convert.ToInt32(File.ReadLines(@"..\..\bin\Debug\log.txt").Count() - i)));
                        List<string> logLine = logg.Split(new[] { ';' }, StringSplitOptions.None).ToList();
                        if (log.NumeroDiAuto(logLine) != -1 && auto == false)
                        { label5.Text = log.NumeroDiAuto(logLine).ToString(); auto = true; }
                        if (log.NumeroDiAutoElettriche(logLine) != -1 && autoElettrica == false)
                        { label6.Text = log.NumeroDiAutoElettriche(logLine).ToString(); autoElettrica = true; }
                        if (log.NumeroDiMoto(logLine) != -1 && moto == false)
                        { label7.Text = log.NumeroDiMoto(logLine).ToString(); moto = true; }
                        if (log.NumeroDiFurgoni(logLine) != -1 && furgone == false)
                        { label9.Text = log.NumeroDiFurgoni(logLine).ToString(); furgone = true; }
                        if (log.DurataParcheggioMedioAuto(logLine) != null && durataAuto == false)
                        { labelDurataAuto.Text = log.DurataParcheggioMedioAuto(logLine).ToString(); durataAuto = true; }
                        if (log.DurataParcheggioMedioMoto(logLine) != null && durataMoto == false)
                        { labelDurataMoto.Text = log.DurataParcheggioMedioMoto(logLine).ToString(); durataMoto = true; }
                        if (log.DurataParcheggioMedioFurgone(logLine) != null && durataFurgone == false)
                        { labelDurataFurgone.Text = log.DurataParcheggioMedioFurgone(logLine).ToString(); durataFurgone = true; }
                        if (log.ValoreTariffaAuto(logLine) != null && tarAuto == false)
                        { labelTariffaAuto.Text = log.ValoreTariffaAuto(logLine).ToString(); tarAuto = true; }
                        if (log.ValoreTariffaMoto(logLine) != null && tarMoto == false)
                        { labelTariffaMoto.Text = log.ValoreTariffaMoto(logLine).ToString(); tarMoto = true; }
                        if (log.ValoreTariffaFurgone(logLine) != null && tarFurgone == false)
                        { labelTariffaFurgone.Text = log.ValoreTariffaFurgone(logLine).ToString(); tarFurgone = true; }
                        if (log.Nome(logLine) != null && nome == false)
                        { labelNome.Text = log.Nome(logLine).ToString(); nome = true; }
                        i++;
                        if (auto && autoElettrica && moto && furgone && durataAuto && durataMoto && durataFurgone && tarAuto && tarMoto && tarFurgone && nome)
                            finito = true;
                    }
                    catch
                    {
                        finito = true;
                    }
                }
                foreach (Label l in parent.FindControls<Label>(this))
                {
                    if (l.Text == "")
                        l.Text = "0";       //se il testo della label è default lo cambio a 0, essenzialmente per motivi estetici
                }
                label1.Text = "";
            }
            else
            {
                foreach (Label l in parent.FindControls<Label>(this))
                {
                    l.Visible = false;
                }
                labelNoStats.Visible = true; labelNoStats.Text = "Nessuna statistica da mostrare ancora";
                labelHeader.Visible = true;
                label1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Garage 1")
            {
                button2.Text = "Garage 2";
                garageSelezionato = 1;
                GetStats();
            }
            else
            {
                button2.Text = "Garage 1";
                garageSelezionato = 0;
                GetStats();
            }
        }

        /// <summary>
        /// imposta il testo default alle label delle informazioni
        /// </summary>
        private void SetDefaultTextOnLabels()
        {
            foreach (Label l in parent.FindControls<Label>(this))
            {
                if ((string)l.Tag == "info")
                    l.Text = "";
            }
        }
    }
}
