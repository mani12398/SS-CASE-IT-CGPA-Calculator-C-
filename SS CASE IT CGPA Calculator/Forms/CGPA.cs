using System;
using System.Drawing;
using System.Windows.Forms;

namespace SS_CASE_IT_CGPA_Calculator.Forms
{
    public partial class CGPA : Form
    {
        int[] Indexes = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };
        char[] fvalue = new char[8];
        public CGPA()
        {
            InitializeComponent();
        }
        
        private void CGPA_Load(object sender, EventArgs e)
        {
            LoadTheme();
            DisableAll();
            ContextMenuTextBoxes();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = Class1.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Class1.SecondaryColor;

                }
            }

            label1.ForeColor = Class1.SecondaryColor;
            label2.ForeColor = Class1.SecondaryColor;
            label3.ForeColor = Class1.SecondaryColor;
            label4.ForeColor = Class1.SecondaryColor;
            label5.ForeColor = Class1.SecondaryColor;
            label6.ForeColor = Class1.SecondaryColor;
            label7.ForeColor = Class1.SecondaryColor;
            label8.ForeColor = Class1.SecondaryColor;
            label9.ForeColor = Class1.SecondaryColor;
            label10.ForeColor = Class1.SecondaryColor;
            label11.ForeColor = Class1.SecondaryColor;
            label12.ForeColor = Class1.SecondaryColor;
            label13.ForeColor = Class1.SecondaryColor;
            label14.ForeColor = Class1.SecondaryColor;
            label15.ForeColor = Class1.SecondaryColor;
            label16.ForeColor = Class1.SecondaryColor;
            label17.ForeColor = Class1.SecondaryColor;
            label18.ForeColor = Class1.SecondaryColor;



        }

        public void ClearAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

           

            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;

            label14.Text = "0";
            label16.Text = "0.00";
            label18.Text = "0.00";

        }

        public void DisableAll()
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;

           

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;

        }

        public void ContextMenuTextBoxes()
        {
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.ContextMenu = new ContextMenu();

            textBox2.KeyDown += textBox2_KeyDown;
            textBox2.ContextMenu = new ContextMenu();

            textBox3.KeyDown += textBox3_KeyDown;
            textBox3.ContextMenu = new ContextMenu();

            textBox4.KeyDown += textBox4_KeyDown;
            textBox4.ContextMenu = new ContextMenu();

            textBox5.KeyDown += textBox5_KeyDown;
            textBox5.ContextMenu = new ContextMenu();

            textBox6.KeyDown += textBox6_KeyDown;
            textBox6.ContextMenu = new ContextMenu();

            textBox7.KeyDown += textBox7_KeyDown;
            textBox7.ContextMenu = new ContextMenu();

            textBox8.KeyDown += textBox8_KeyDown;
            textBox8.ContextMenu = new ContextMenu();

         


        }

        private void CheckTextBoxes()
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "")
            {
                label18.Text = "0.00";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Enabled = true;

            }

            if (textBox1.Text == "")
            {
                comboBox1.SelectedIndex = -1;
                comboBox1.Enabled = false;
                textBox9.Clear();

            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {
                comboBox2.Enabled = true;

            }

            if (textBox2.Text == "")
            {
                comboBox2.SelectedIndex = -1;
                comboBox2.Enabled = false;
                textBox10.Clear();

            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox3.Text != "")
            {
                comboBox3.Enabled = true;

            }

            if (textBox3.Text == "")
            {
                comboBox3.SelectedIndex = -1;
                comboBox3.Enabled = false;
                textBox11.Clear();

            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text != "")
            {
                comboBox4.Enabled = true;

            }

            if (textBox4.Text == "")
            {
                comboBox4.SelectedIndex = -1;
                comboBox4.Enabled = false;
                textBox12.Clear();

            }

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (textBox5.Text != "")
            {
                comboBox5.Enabled = true;

            }

            if (textBox5.Text == "")
            {
                comboBox5.SelectedIndex = -1;
                comboBox5.Enabled = false;
                textBox13.Clear();

            }

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            if (textBox6.Text != "")
            {
                comboBox6.Enabled = true;

            }

            if (textBox6.Text == "")
            {
                comboBox6.SelectedIndex = -1;
                comboBox6.Enabled = false;
                textBox14.Clear();

            }

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (textBox7.Text != "")
            {
                comboBox7.Enabled = true;

            }

            if (textBox7.Text == "")
            {
                comboBox7.SelectedIndex = -1;
                comboBox7.Enabled = false;
                textBox15.Clear();

            }

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            if (textBox8.Text != "")
            {
                comboBox8.Enabled = true;

            }

            if (textBox8.Text == "")
            {
                comboBox8.SelectedIndex = -1;
                comboBox8.Enabled = false;
                textBox16.Clear();

            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {       
            if (textBox9.Text != "")
            {
                textBox2.Enabled = true;
            }

            if(textBox9.Text!="")
            label16.Text = (double.Parse(label16.Text) + double.Parse(textBox9.Text)).ToString("#0.00");
            label18.Text = (double.Parse(label16.Text) / double.Parse(label14.Text)).ToString("#0.00");
            CheckTextBoxes();
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                textBox3.Enabled = true;
            }
            if (textBox10.Text != "")
            label16.Text = (double.Parse(label16.Text) + double.Parse(textBox10.Text)).ToString("#0.00");
            label18.Text = (double.Parse(label16.Text) / double.Parse(label14.Text)).ToString("#0.00");
            CheckTextBoxes();
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                textBox4.Enabled = true;
            }
            if (textBox11.Text != "")
            label16.Text = (double.Parse(label16.Text) + double.Parse(textBox11.Text)).ToString("#0.00");
            label18.Text = (double.Parse(label16.Text) / double.Parse(label14.Text)).ToString("#0.00");
            CheckTextBoxes();
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                textBox5.Enabled = true;
            }
            if (textBox12.Text != "")
             label16.Text = (double.Parse(label16.Text) + double.Parse(textBox12.Text)).ToString("#0.00");
            label18.Text = (double.Parse(label16.Text) / double.Parse(label14.Text)).ToString("#0.00");
            CheckTextBoxes();
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                textBox6.Enabled = true;
            }
            if (textBox13.Text != "")
             label16.Text = (double.Parse(label16.Text) + double.Parse(textBox13.Text)).ToString("#0.00");
            label18.Text = (double.Parse(label16.Text) / double.Parse(label14.Text)).ToString("#0.00");
            CheckTextBoxes();
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                textBox7.Enabled = true;
            }
            if (textBox14.Text != "")
            label16.Text = (double.Parse(label16.Text) + double.Parse(textBox14.Text)).ToString("#0.00");
            label18.Text = (double.Parse(label16.Text) / double.Parse(label14.Text)).ToString("#0.00");
            CheckTextBoxes();
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {
                textBox8.Enabled = true;
            }
            if (textBox15.Text != "")
             label16.Text = (double.Parse(label16.Text) + double.Parse(textBox15.Text)).ToString("#0.00");
            label18.Text = (double.Parse(label16.Text) / double.Parse(label14.Text)).ToString("#0.00");
            CheckTextBoxes();
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
             label16.Text = (double.Parse(label16.Text) + double.Parse(textBox16.Text)).ToString("#0.00");
            label18.Text = (double.Parse(label16.Text) / double.Parse(label14.Text)).ToString("#0.00");
            CheckTextBoxes();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (textBox1.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == '4')
                {
                    fvalue[0] = '4';
                }

                else
                {
                    fvalue[0] = '!';
                }
            }

            else if (textBox1.Text.Length == 1)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

            else if (textBox1.Text.Length == 2)
            {
                if (fvalue[0] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            else if (textBox1.Text.Length == 3)
            {
                if (fvalue[0] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (textBox2.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == '4')
                {
                    fvalue[1] = '4';
                }

                else
                {
                    fvalue[1] = '!';
                }
            }

            else if (textBox2.Text.Length == 1)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

            else if (textBox2.Text.Length == 2)
            {
                if (fvalue[1] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            else if (textBox2.Text.Length == 3)
            {
                if (fvalue[1] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }


            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (textBox3.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == '4')
                {
                    fvalue[2] = '4';
                }

                else
                {
                    fvalue[2] = '!';
                }
            }

            else if (textBox3.Text.Length == 1)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

            else if (textBox3.Text.Length == 2)
            {
                if (fvalue[2] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            else if (textBox3.Text.Length == 3)
            {
                if (fvalue[2] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }


            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (textBox4.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == '4')
                {
                    fvalue[3] = '4';
                }

                else
                {
                    fvalue[3] = '!';
                }
            }

            else if (textBox4.Text.Length == 1)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

            else if (textBox4.Text.Length == 2)
            {
                if (fvalue[3] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            else if (textBox4.Text.Length == 3)
            {
                if (fvalue[3] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }


            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (textBox5.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == '4')
                {
                    fvalue[4] = '4';
                }

                else
                {
                    fvalue[4] = '!';
                }
            }

            else if (textBox5.Text.Length == 1)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }


            else if (textBox5.Text.Length == 2)
            {
                if (fvalue[4] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            else if (textBox5.Text.Length == 3)
            {
                if (fvalue[4] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }


            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (textBox6.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == '4')
                {
                    fvalue[5] = '4';
                }

                else
                {
                    fvalue[5] = '!';
                }
            }

            else if (textBox6.Text.Length == 1)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

            else if (textBox6.Text.Length == 2)
            {
                if (fvalue[5] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            else if (textBox6.Text.Length == 3)
            {
                if (fvalue[5] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (textBox7.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == '4')
                {
                    fvalue[6] = '4';
                }

                else
                {
                    fvalue[6] = '!';
                }
            }

            else if (textBox7.Text.Length == 1)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

            else if (textBox7.Text.Length == 2)
            {
                if (fvalue[6] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            else if (textBox7.Text.Length == 3)
            {
                if (fvalue[6] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }


            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (textBox8.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4')
                {
                    e.Handled = true;
                }

                else if (e.KeyChar == '4')
                {
                    fvalue[7] = '4';
                }

                else
                {
                    fvalue[7] = '!';
                }
            }

            else if (textBox8.Text.Length == 1)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
            }

            else if (textBox8.Text.Length == 2)
            {
                if (fvalue[7] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            else if (textBox8.Text.Length == 3)
            {
                if (fvalue[7] == '4')
                {
                    if (e.KeyChar != '0')
                    {
                        e.Handled = true;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }

            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            string text1 = textBox9.Text;
            string text2 = "";

            if (textBox1.Text.Length == 1 || textBox1.Text.Length == 3 || textBox1.Text.Length == 4)
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    text2 = (double.Parse(textBox1.Text) * int.Parse(comboBox1.Text)).ToString("#0.00");

                    if (string.Equals(text1, text2) == false)
                    {
                        label16.Text = (double.Parse(label16.Text) - double.Parse(text1)).ToString("#0.00");
                        textBox9.Text = text2;
                    }
                }
            }

        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            string text1 = textBox10.Text;
            string text2 = "";

            if (textBox2.Text.Length == 1 || textBox2.Text.Length == 3 || textBox2.Text.Length == 4)
            {
                if (comboBox2.SelectedIndex != -1)
                {
                    text2 = (double.Parse(textBox2.Text) * int.Parse(comboBox2.Text)).ToString("#0.00");

                    if (string.Equals(text1, text2) == false)
                    {
                        label16.Text = (double.Parse(label16.Text) - double.Parse(text1)).ToString("#0.00");
                        textBox10.Text = text2;
                    }
                }
            }
        }
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            string text1 = textBox11.Text;
            string text2 = "";

            if (textBox3.Text.Length == 1 || textBox3.Text.Length == 3 || textBox3.Text.Length == 4)
            {
                if (comboBox3.SelectedIndex != -1)
                {
                    text2 = (double.Parse(textBox3.Text) * int.Parse(comboBox3.Text)).ToString("#0.00");

                    if (string.Equals(text1, text2) == false)
                    {
                        label16.Text = (double.Parse(label16.Text) - double.Parse(text1)).ToString("#0.00");
                        textBox11.Text = text2;
                    }
                }
            }
        }
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            string text1 = textBox12.Text;
            string text2 = "";

            if (textBox4.Text.Length == 1 || textBox4.Text.Length == 3 || textBox4.Text.Length == 4)
            {
                if (comboBox4.SelectedIndex != -1)
                {
                    text2 = (double.Parse(textBox4.Text) * int.Parse(comboBox4.Text)).ToString("#0.00");

                    if (string.Equals(text1, text2) == false)
                    {
                        label16.Text = (double.Parse(label16.Text) - double.Parse(text1)).ToString("#0.00");
                        textBox12.Text = text2;
                    }
                }
            }
        }
        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            string text1 = textBox13.Text;
            string text2 = "";

            if (textBox5.Text.Length == 1 || textBox5.Text.Length == 3 || textBox5.Text.Length == 4)
            {
                if (comboBox5.SelectedIndex != -1)
                {
                    text2 = (double.Parse(textBox5.Text) * int.Parse(comboBox5.Text)).ToString("#0.00");

                    if (string.Equals(text1, text2) == false)
                    {
                        label16.Text = (double.Parse(label16.Text) - double.Parse(text1)).ToString("#0.00");
                        textBox13.Text = text2;
                    }
                }
            }
        }
        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            string text1 = textBox14.Text;
            string text2 = "";

            if (textBox6.Text.Length == 1 || textBox6.Text.Length == 3 || textBox6.Text.Length == 4)
            {
                if (comboBox6.SelectedIndex != -1)
                {
                    text2 = (double.Parse(textBox6.Text) * int.Parse(comboBox6.Text)).ToString("#0.00");

                    if (string.Equals(text1, text2) == false)
                    {
                        label16.Text = (double.Parse(label16.Text) - double.Parse(text1)).ToString("#0.00");
                        textBox14.Text = text2;
                    }
                }
            }
        }
        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            string text1 = textBox15.Text;
            string text2 = "";

            if (textBox7.Text.Length == 1 || textBox7.Text.Length == 3 || textBox7.Text.Length == 4)
            {
                if (comboBox7.SelectedIndex != -1)
                {
                    text2 = (double.Parse(textBox7.Text) * int.Parse(comboBox7.Text)).ToString("#0.00");

                    if (string.Equals(text1, text2) == false)
                    {
                        label16.Text = (double.Parse(label16.Text) - double.Parse(text1)).ToString("#0.00");
                        textBox15.Text = text2;
                    }
                }
            }
        }
        private void textBox8_KeyUp(object sender, KeyEventArgs e)
        {
            string text1 = textBox16.Text;
            string text2 = "";

            if (textBox8.Text.Length == 1 || textBox8.Text.Length == 3 || textBox8.Text.Length == 4)
            {
                if (comboBox8.SelectedIndex != -1)
                {
                    text2 = (double.Parse(textBox8.Text) * int.Parse(comboBox8.Text)).ToString("#0.00");

                    if (string.Equals(text1, text2) == false)
                    {
                        label16.Text = (double.Parse(label16.Text) - double.Parse(text1)).ToString("#0.00");
                        textBox16.Text = text2;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Indexes[0] != -1)
            {
                int ind = Indexes[0];
                label14.Text = (int.Parse(label14.Text) - int.Parse(comboBox1.Items[ind].ToString())).ToString();

                if (Indexes[0] != comboBox1.SelectedIndex)
                {
                    label16.Text = (double.Parse(label16.Text) - double.Parse(textBox9.Text)).ToString("#0.00");
                }
            }

           
            if (comboBox1.SelectedIndex != -1)
            {
                label14.Text = (int.Parse(label14.Text) + int.Parse(comboBox1.Text)).ToString();
                textBox9.Text = (double.Parse(textBox1.Text) * int.Parse(comboBox1.Text)).ToString("#0.00");
            }

            Indexes[0] = comboBox1.SelectedIndex;

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Indexes[1] != -1)
            {
                int ind = Indexes[1];
                label14.Text = (int.Parse(label14.Text) - int.Parse(comboBox2.Items[ind].ToString())).ToString();

                if (Indexes[1] != comboBox2.SelectedIndex)
                {
                    label16.Text = (double.Parse(label16.Text) - double.Parse(textBox10.Text)).ToString("#0.00");
                }
            }

            if (comboBox2.SelectedIndex != -1)
            {
                label14.Text = (int.Parse(label14.Text) + int.Parse(comboBox2.Text)).ToString();
                textBox10.Text = (double.Parse(textBox2.Text) * int.Parse(comboBox2.Text)).ToString("#0.00");
            }

            Indexes[1] = comboBox2.SelectedIndex;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Indexes[2] != -1)
            {
                int ind = Indexes[2];
                label14.Text = (int.Parse(label14.Text) - int.Parse(comboBox3.Items[ind].ToString())).ToString();

                if (Indexes[2] != comboBox3.SelectedIndex)
                {
                    label16.Text = (double.Parse(label16.Text) - double.Parse(textBox11.Text)).ToString("#0.00");
                }
            }

            if (comboBox3.SelectedIndex != -1)
            {
                label14.Text = (int.Parse(label14.Text) + int.Parse(comboBox3.Text)).ToString();
                textBox11.Text = (double.Parse(textBox3.Text) * int.Parse(comboBox3.Text)).ToString("#0.00");
            }

            Indexes[2] = comboBox3.SelectedIndex;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Indexes[3] != -1)
            {
                int ind = Indexes[3];
                label14.Text = (int.Parse(label14.Text) - int.Parse(comboBox4.Items[ind].ToString())).ToString();

                if (Indexes[3] != comboBox4.SelectedIndex)
                {
                    label16.Text = (double.Parse(label16.Text) - double.Parse(textBox12.Text)).ToString("#0.00");
                }
            }

            if (comboBox4.SelectedIndex != -1)
            {
                label14.Text = (int.Parse(label14.Text) + int.Parse(comboBox4.Text)).ToString();
                textBox12.Text = (double.Parse(textBox4.Text) * int.Parse(comboBox4.Text)).ToString("#0.00");
            }

            Indexes[3] = comboBox4.SelectedIndex;
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Indexes[4] != -1)
            {
                int ind = Indexes[4];
                label14.Text = (int.Parse(label14.Text) - int.Parse(comboBox5.Items[ind].ToString())).ToString();

                if (Indexes[4] != comboBox5.SelectedIndex)
                {
                    label16.Text = (double.Parse(label16.Text) - double.Parse(textBox13.Text)).ToString("#0.00");
                }
            }

            if (comboBox5.SelectedIndex != -1)
            {
                label14.Text = (int.Parse(label14.Text) + int.Parse(comboBox5.Text)).ToString();
                textBox13.Text = (double.Parse(textBox5.Text) * int.Parse(comboBox5.Text)).ToString("#0.00");
            }

            Indexes[4] = comboBox5.SelectedIndex;
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Indexes[5] != -1)
            {
                int ind = Indexes[5];
                label14.Text = (int.Parse(label14.Text) - int.Parse(comboBox6.Items[ind].ToString())).ToString();

                if (Indexes[5] != comboBox6.SelectedIndex)
                {
                    label16.Text = (double.Parse(label16.Text) - double.Parse(textBox14.Text)).ToString("#0.00");
                }
            }

            if (comboBox6.SelectedIndex != -1)
            {
                label14.Text = (int.Parse(label14.Text) + int.Parse(comboBox6.Text)).ToString();
                textBox14.Text = (double.Parse(textBox6.Text) * int.Parse(comboBox6.Text)).ToString("#0.00");
            }

            Indexes[5] = comboBox6.SelectedIndex;
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Indexes[6] != -1)
            {
                int ind = Indexes[6];
                label14.Text = (int.Parse(label14.Text) - int.Parse(comboBox7.Items[ind].ToString())).ToString();

                if (Indexes[6] != comboBox7.SelectedIndex)
                {
                    label16.Text = (double.Parse(label16.Text) - double.Parse(textBox15.Text)).ToString("#0.00");
                }
            }

            if (comboBox7.SelectedIndex != -1)
            {
                label14.Text = (int.Parse(label14.Text) + int.Parse(comboBox7.Text)).ToString();
                textBox15.Text = (double.Parse(textBox7.Text) * int.Parse(comboBox7.Text)).ToString("#0.00");
            }

            Indexes[6] = comboBox7.SelectedIndex;
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Indexes[7] != -1)
            {
                int ind = Indexes[7];
                label14.Text = (int.Parse(label14.Text) - int.Parse(comboBox8.Items[ind].ToString())).ToString();

                if (Indexes[7] != comboBox8.SelectedIndex)
                {
                    label16.Text = (double.Parse(label16.Text) - double.Parse(textBox16.Text)).ToString("#0.00");
                }
            }

            if (comboBox8.SelectedIndex != -1)
            {
                label14.Text = (int.Parse(label14.Text) + int.Parse(comboBox8.Text)).ToString();
                textBox16.Text = (double.Parse(textBox8.Text) * int.Parse(comboBox8.Text)).ToString("#0.00");
            }

            Indexes[7] = comboBox8.SelectedIndex;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            e.SuppressKeyPress = true;

            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }
        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            e.SuppressKeyPress = true;

            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }
        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            e.SuppressKeyPress = true;

            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }
        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            e.SuppressKeyPress = true;

            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }
        private void comboBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            e.SuppressKeyPress = true;

            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }
        private void comboBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            e.SuppressKeyPress = true;

            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }
        private void comboBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            e.SuppressKeyPress = true;

            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }
        private void comboBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
            e.SuppressKeyPress = true;

            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
            DisableAll();
        }

      

        
    }

}
