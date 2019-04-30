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
    public partial class FormInfo : Form
    {
        //campi privati
        private FormGarageGrafico parent;
        private Veicolo veicolo;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public FormInfo(Veicolo veicolo)
        {
            InitializeComponent();
            this.veicolo = veicolo;
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            parent = Owner as FormGarageGrafico;
            parent.Enabled = false;
            //labell tipo veicolo
            if (veicolo is Auto)
                labelTipoVeicolo.Text = "Auto";
            else if (veicolo is Moto)
                labelTipoVeicolo.Text = "Moto";
            else
                labelTipoVeicolo.Text = "Furgone";
            //label targa
            label6.Text = veicolo.Targa;
            //label orario di entrata
            label7.Text = veicolo.OraDiIngresso.ToString();
            //label descrizione
            label8.Text = veicolo.Descrizione();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            parent.Enabled = true;
            Close();
            Dispose();
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
    }
}
