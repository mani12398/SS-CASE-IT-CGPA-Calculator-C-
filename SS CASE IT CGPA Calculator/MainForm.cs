using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace SS_CASE_IT_CGPA_Calculator
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            button10.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void Reset()
        {
            DisableButton();
            label1.Text = "CGPA CALCULATOR";
            panel3.BackColor = Color.FromArgb(0, 150, 136);
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            button10.Visible = false;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(Class1.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(Class1.ColorList.Count);
            }
            tempindex = index;
            string color = Class1.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panel3.BackColor = color;
                    panel2.BackColor = Class1.ChangeColorBrightness(color, -0.3);
                    Class1.PrimaryColor = color;
                    Class1.SecondaryColor = Class1.ChangeColorBrightness(color, -0.3);
                    button10.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(childForm);
            this.panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms._1stSem(1), sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms._1stSem(2), sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms._1stSem(3), sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms._1stSem(4), sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms._1stSem(5), sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms._1stSem(6), sender);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms._1stSem(7), sender);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms._1stSem(8), sender);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CGPA(), sender);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                int boundWidth = Screen.PrimaryScreen.Bounds.Width;
                int boundHeight = Screen.PrimaryScreen.Bounds.Height;
                int x = boundWidth - this.Width;
                int y = boundHeight - this.Height;
                this.Location = new Point(x / 2, y / 2);


            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        

        
    }
}
