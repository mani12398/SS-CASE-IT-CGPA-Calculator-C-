using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_CASE_IT_CGPA_Calculator
{
    public partial class SplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int RightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public SplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
            this.progressBar1.Maximum = 50;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value == 50)
            {
                timer1.Enabled = false;
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }
            else
            {
                this.progressBar1.Value += 1;
            }
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
