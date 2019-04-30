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
    public partial class Form2 : Form
    {
        //campi privati
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private Form1 parent;
        private Garage garage;
        private int ticks;
        //logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Form2");

        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 1000; timer1.Tick += new EventHandler(timer1_Tick);
            ticks = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button2.Enabled = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (garage != null && parent.appoggio == 0)
            {
                parent.g[parent.appoggio] = garage;
                log.Info("Primo garage creato con successo, ritorno al Form1;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;");
                log.Info("Propietà primo garage;" + " ;" + " ;" + " ;" + " ;" + garage.TariffaAuto + ";" + garage.TariffaMoto + ";" + garage.TariffaFurgone + ";" + garage.Nome + ";" + " ;" + " ;" + " ;" + parent.appoggio + ";");
                //parent.sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; INFO; Primo garage creato con successo, ritorno al Form1;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + Environment.NewLine +
                //DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; PROPERTIES; Propietà primo garage;" + " ;" + " ;" + " ;" + " ;" + garage.TariffaAuto + ";" + garage.TariffaMoto + ";" + garage.TariffaFurgone + ";" + garage.Nome + ";" + " ;"  + " ;" + " ;" + parent.appoggio + ";" + Environment.NewLine);
                string path = @"..\..\Resources\\garage.png";
                parent.button1.Image = new Bitmap(Path.GetFullPath(path));
                parent.button1.BackColor = Color.LightGray;
                parent.button1.Text = garage.Nome;
                parent.button2.Visible = true;
                parent.button1.ForeColor = Color.Black;
                parent.appoggio = 1; parent.button1.Font = new Font(parent.button1.Font, FontStyle.Bold);
            }
            else if(garage != null && parent.appoggio == 1)
            {
                parent.g[parent.appoggio] = garage;
                log.Info("Secondo garage creato con successo, ritorno al Form1;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;");
                log.Info("Propietà secondo garage;" + " ;" + " ;" + " ;" + " ;" + garage.TariffaAuto + ";" + garage.TariffaMoto + ";" + garage.TariffaFurgone + ";" + garage.Nome + ";" + " ;" + " ;" + " ;" + parent.appoggio + ";");
                //parent.sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; INFO; Secondo garage creato con successo, ritorno al Form1;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" +" ;" + " ;" + Environment.NewLine +
                //                 DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; PROPERTIES; Propietà secondo garage;" + " ;" + " ;" + " ;" + " ;" + garage.TariffaAuto + ";" + garage.TariffaMoto + ";" + garage.TariffaFurgone + ";" + garage.Nome + ";" + " ;" + " ;" + " ;" + parent.appoggio + ";" + Environment.NewLine); 
                string path = @"..\..\Resources\\garage.png";
                parent.button2.Image = new Bitmap(Path.GetFullPath(path));
                parent.button2.BackColor = Color.LightGray;
                parent.button2.Text = garage.Nome;
                parent.button2.ForeColor = Color.Black; parent.button2.Font = new Font(parent.button2.Font, FontStyle.Bold);
            }
            else { }
            parent.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticks == 5)
            {
                labelErrore.Visible = false;
                timer1.Enabled = false;
                ticks = 0;
            }
            else
            {
                ticks++;
            }
        }

        private void button3_Click_(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bool canConvertTariffaAuto = Int32.TryParse(textBox2.Text, out int tariffaAuto);
                bool canConvertTariffaMoto = Int32.TryParse(textBox3.Text, out int tariffaMoto);
                bool canConvertTariffaFurgone = Int32.TryParse(textBox4.Text, out int tariffaFurgone);
                bool canConvertIndexGarage = Int32.TryParse(textBox5.Text, out int lunghezzaGarage);
                if (canConvertTariffaAuto && canConvertTariffaFurgone && canConvertTariffaMoto && canConvertIndexGarage && lunghezzaGarage > 10 && lunghezzaGarage < 101)
                {
                    garage = new Garage(tariffaAuto, tariffaMoto, tariffaFurgone, Convert.ToInt32(textBox5.Text), textBox1.Text);
                    groupBox1.Visible = false;
                    Close();
                }
                else
                {
                    foreach (TextBox textbox in parent.FindControls<TextBox>(this))            //tolgo tutti gli input dalle textbox
                    {
                        textbox.Text = "";
                    }
                    labelErrore.Visible = true;
                    log.Error("Creazione del garage fallito[Errore: parametri inseriti non accettabili]" + " ; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; " + "; ");
                    //parent.sb.Append(DateTime.Now.ToString("yyyy/MM/dd -- HH:mm:ss") + "; ERROR; Creazione del garage fallito [Errore: parametri inseriti non accettabili]" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + " ;" + Environment.NewLine);
                    timer1.Enabled = true;
                }
            }
            else
            {
                labelErrore.Visible = true;
                timer1.Enabled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            parent = Owner as Form1;
            parent.Enabled = false;
        }
    }
}
