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
    public partial class FormGarageGrafico : Form
    {
        //campi privati
        private Form1 parent;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public FormGarageGrafico()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void labelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }


        private void FormGarageGrafico_Load(object sender, EventArgs e)
        {
            parent = Owner as Form1;
            parent.Enabled = false;
            int tag = 0;
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 20; column++)
                {
                    Color color = Color.Gray;
                    try
                    {
                        if (parent.g[parent.garageSelezionato].ArrayDiVeicoli[tag] is Auto)
                            color = Color.Yellow;
                        else if (parent.g[parent.garageSelezionato].ArrayDiVeicoli[tag] is Moto)
                            color = Color.Red;
                        else if (parent.g[parent.garageSelezionato].ArrayDiVeicoli[tag] is Furgone)
                            color = Color.Green;
                    }
                    catch
                    {
                        if (tag > 9)
                            break;
                    }
                    PictureBox picture = new PictureBox { Name = tag.ToString(), Tag = tag, Dock = DockStyle.Fill, BackColor = color };
                    picture.MouseClick += new MouseEventHandler(PictureClick);
                    tableLayoutPanel1.Controls.Add(picture, column, row);
                    tag++;
                }
            }
        }

        void PictureClick(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int tag = Convert.ToInt32(pictureBox.Tag);
            Veicolo veicolo = parent.g[parent.garageSelezionato].ArrayDiVeicoli[tag];
            if (veicolo != null)
            {
                FormInfo info = new FormInfo(veicolo);
                info.Show(this);
            }
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

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("GANG");
        }
    }
}
