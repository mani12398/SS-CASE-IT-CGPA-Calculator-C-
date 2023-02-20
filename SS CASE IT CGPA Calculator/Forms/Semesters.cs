using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SS_CASE_IT_CGPA_Calculator.Forms
{
    public partial class _1stSem : Form
    {
        string var1 = null, var2 = null, var3 = null, var4 = null, var5 = null, var6 = null;
        int Sem_No;
        int count = 0;
        int[] CmbPreInd = new int[6];
        string[] items = new string[6];
        ArrayList arr1 = new ArrayList();
        ArrayList arr2 = new ArrayList();
        public delegate int mydel1(object var);
        public delegate void mydel2(object var);
        mydel1 data1;
        mydel2 data2;

        public _1stSem(int no)
        {
            InitializeComponent();
            Sem_No = no;
            ChangeFormText();
        }

        private void _1stSem_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ClearaArray();
            ClearComboArray();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox6.Enabled = false;
            textBox5.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;
            textBox12.Enabled = false;
            textBox11.Enabled = false;
            textBox15.Enabled = false;
            textBox14.Enabled = false;
            textBox18.Enabled = false;
            textBox17.Enabled = false;

            comboBox1.KeyDown += comboBox1_KeyDown;
            comboBox1.ContextMenu = new ContextMenu();

            comboBox2.KeyDown += comboBox2_KeyDown;
            comboBox2.ContextMenu = new ContextMenu();

            comboBox3.KeyDown += comboBox3_KeyDown;
            comboBox3.ContextMenu = new ContextMenu();

            comboBox4.KeyDown += comboBox4_KeyDown;
            comboBox4.ContextMenu = new ContextMenu();

            comboBox5.KeyDown += comboBox5_KeyDown;
            comboBox5.ContextMenu = new ContextMenu();

            comboBox6.KeyDown += comboBox6_KeyDown;
            comboBox6.ContextMenu = new ContextMenu();

            comboBox7.KeyDown += comboBox7_KeyDown;
            comboBox7.ContextMenu = new ContextMenu();

            comboBox8.KeyDown += comboBox8_KeyDown;
            comboBox8.ContextMenu = new ContextMenu();

            comboBox9.KeyDown += comboBox9_KeyDown;
            comboBox9.ContextMenu = new ContextMenu();

            comboBox10.KeyDown += comboBox10_KeyDown;
            comboBox10.ContextMenu = new ContextMenu();

            comboBox11.KeyDown += comboBox11_KeyDown;
            comboBox11.ContextMenu = new ContextMenu();

            comboBox12.KeyDown += comboBox12_KeyDown;
            comboBox12.ContextMenu = new ContextMenu();

            
            
        }

        public void CheckComboBox7()
        {
            if (comboBox7.Enabled == true)
            {
                if (comboBox7.SelectedIndex <= -1)
                {
                    if (textBox2.Text != "")  
                    {
                        count += int.Parse(textBox2.Text);
                    }
                    
                }
            }
        }
        public void CheckComboBox8()
        {
            if (comboBox8.Enabled == true)
            {
                if (comboBox8.SelectedIndex <= -1)
                {
                    if (textBox5.Text != "")
                    {
                        count += int.Parse(textBox5.Text);
                    }
                }
            }
        }
        public void CheckComboBox9()
        {
            if (comboBox9.Enabled == true)
            {
                if (comboBox9.SelectedIndex <= -1)
                {
                    if (textBox8.Text != "")
                    {
                        count += int.Parse(textBox8.Text);
                    }

                }
            }
        }
        public void CheckComboBox10()
        {
            if (comboBox10.Enabled == true)
            {
                if (comboBox10.SelectedIndex <= -1)
                {
                    if (textBox11.Text != "") 
                    {
                        count += int.Parse(textBox11.Text);
                    }
                    
                }
            }
        }
        public void CheckComboBox11()
        {
            if (comboBox11.Enabled == true)
            {
                if (comboBox11.SelectedIndex <= -1)
                {
                    if(textBox14.Text != "")
                    {
                       count += int.Parse(textBox14.Text);
                    }    
                    
                }
            }
        }
        public void CheckComboBox12()
        {
            if (comboBox12.Enabled == true)
            {

                if (comboBox12.SelectedIndex <= -1)
                {
                    if(textBox17.Text != "")
                    {
                        count += int.Parse(textBox17.Text);
                    }
                   
                }
            }
        }
        private void CheckComboBoxes()
        {
            CheckComboBox7();
            CheckComboBox8();
            CheckComboBox9();
            CheckComboBox10();
            CheckComboBox11();
            CheckComboBox12();
        }

        private void ChangeFormText()
        {
            if (Sem_No == 1)
            {
                this.Text = "1st Semester";
            }

            else if (Sem_No == 2)
            {
                this.Text = "2nd Semester";
            }

            else if (Sem_No == 3)
            {
                this.Text = "3rd Semester";
            }

            else if (Sem_No == 4)
            {
                this.Text = "4th Semester";
            }

            else if (Sem_No == 5)
            {
                this.Text = "5th Semester";
            }

            else if (Sem_No == 6)
            {
                this.Text = "6th Semester";
            }

            else if (Sem_No == 7)
            {
                this.Text = "7th Semester";
            }

            else
            {
                this.Text = "8th Semester";
            }

        }

        private void CheckTextBoxes()
        {
            if (textBox24.Text == "" && textBox23.Text == "" && textBox22.Text == "" && textBox21.Text == "" && textBox20.Text == "" && textBox19.Text == "")
            {
                label11.Text = "0.00";
            }

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

            radioButton1.ForeColor = Class1.SecondaryColor;
            radioButton2.ForeColor = Class1.SecondaryColor;
            radioButton3.ForeColor = Class1.SecondaryColor;
            radioButton4.ForeColor = Class1.SecondaryColor;

            checkBox1.ForeColor = Class1.SecondaryColor;
            checkBox2.ForeColor = Class1.SecondaryColor;

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

        }

        private void ClearaArray()
        {
            for (int i = 0; i < CmbPreInd.Length; i++)
            {
                CmbPreInd[i] = -1;
            }

        }

        private void ClearComboArray()
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = null;
            }
        }

        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            return con;
        }

        public DataSet GetData(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public void LoadDataComboBox(string query)
        {


            DataSet ds = GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                arr1.Add(ds.Tables[0].Rows[i][0].ToString());
            }
                

        }

        public void AssignValues()
        {
            foreach (var item in arr1)
            {
                data1(item);
            }
        }

        public void RemoveValues(string val1)
        {
            foreach (var item in arr2)
            {
                if (item.ToString() != val1)
                {
                    data2(item);
                }

            }
        }

        public void ClearVariables()
        {
            var1 = var2 = var3 = var4 = var5 = var6 = null;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;





                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();



                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();

                
                


                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;

                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";

                ClearaArray();
                ClearComboArray();


            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;





                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();



                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();


                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();

               


                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";
                ClearaArray();
                ClearComboArray();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;





                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();



                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();


                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";
                ClearaArray();
                ClearComboArray();

            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;




                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();

                



                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";
                ClearaArray();
                ClearComboArray();
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;





                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();



                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                ClearaArray();
                ClearComboArray();
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;





                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();



                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;

                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";
                ClearaArray();
                ClearComboArray();
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;




                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();



                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";
                ClearaArray();
                ClearComboArray();

            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;





                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();


                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                comboBox6.SelectedIndex = -1;

                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";
                ClearaArray();
                ClearComboArray();
            }
        }

        private void radioButton1_TabStopChanged(object sender, EventArgs e)
        {
            ((RadioButton)sender).TabStop = true;
        }
        private void radioButton2_TabStopChanged(object sender, EventArgs e)
        {
            ((RadioButton)sender).TabStop = true;
        }
        private void radioButton3_TabStopChanged(object sender, EventArgs e)
        {
            ((RadioButton)sender).TabStop = true;
        }
        private void radioButton4_TabStopChanged(object sender, EventArgs e)
        {
            ((RadioButton)sender).TabStop = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                if (checkBox1.Checked == true)
                {
                    comboBox1.Enabled = true;

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();

                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";




                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";

                    checkBox2.Checked = false;
                    string query = "select Course_Name from BS where Course_Department ='CS'and Course_Semester=" + Sem_No + " and Course_Student_Type in('EM','E')";

                    arr1.Clear();
                    arr2.Clear();
                    ClearVariables();
                    arr1.Insert(0, "----- Choose Option -----");
                    LoadDataComboBox(query);



                    data1 = comboBox1.Items.Add; AssignValues();

                    data1 = comboBox2.Items.Add; AssignValues();

                    data1 = comboBox3.Items.Add; AssignValues();

                    data1 = comboBox4.Items.Add; AssignValues();

                    data1 = comboBox5.Items.Add; AssignValues();

                    data1 = comboBox6.Items.Add; AssignValues();

                    

                }
                else if (checkBox1.Checked == false)
                {

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();

                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();


                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        comboBox1.Enabled = false;
                    }

                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;

                   
                }

                else
                {

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();


                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;

                }


            }

            else if (radioButton2.Checked == true)
            {


                if (checkBox1.Checked == true)
                {
                    comboBox1.Enabled = true;

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();


                    ClearaArray();
                    ClearComboArray();

                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    checkBox2.Checked = false;
                    string query = "select Course_Name from BS where Course_Department ='SE'and Course_Semester=" + Sem_No + " and Course_Student_Type in('EM','E')";
                    arr1.Clear();
                    arr2.Clear();
                    ClearVariables();
                    arr1.Insert(0, "----- Choose Option -----");
                    LoadDataComboBox(query);

                    
                    data1 = comboBox1.Items.Add; AssignValues();

                    data1 = comboBox2.Items.Add; AssignValues();

                    data1 = comboBox3.Items.Add; AssignValues();

                    data1 = comboBox4.Items.Add; AssignValues();

                    data1 = comboBox5.Items.Add; AssignValues();

                    data1 = comboBox6.Items.Add; AssignValues();
                }
                else if (checkBox1.Checked == false)
                {

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();


                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        comboBox1.Enabled = false;
                    }
                   

                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }
                else
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";

                    

                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();


                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;

                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                }


            }

            else if (radioButton3.Checked == true)
            {

                if (checkBox1.Checked == true)
                {
                    comboBox1.Enabled = true;

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();
                    ClearaArray();
                    ClearComboArray();

                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    checkBox2.Checked = false;
                    string query = "select Course_Name from BS where Course_Department ='AI'and Course_Semester=" + Sem_No + " and Course_Student_Type in('EM','E')";
                    arr1.Clear();
                    arr2.Clear();
                    ClearVariables();
                    arr1.Insert(0, "----- Choose Option -----");
                    LoadDataComboBox(query);

                    data1 = comboBox1.Items.Add; AssignValues();

                    data1 = comboBox2.Items.Add; AssignValues();

                    data1 = comboBox3.Items.Add; AssignValues();

                    data1 = comboBox4.Items.Add; AssignValues();

                    data1 = comboBox5.Items.Add; AssignValues();

                    data1 = comboBox6.Items.Add; AssignValues();
                }
                else if (checkBox1.Checked == false)
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        comboBox1.Enabled = false;
                    }

                   
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }
                else
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                }


            }

            else if (radioButton4.Checked == true)
            {
                comboBox1.Items.Clear();
                if (checkBox1.Checked == true)
                {
                    comboBox1.Enabled = true;

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    checkBox2.Checked = false;
                    string query = "select Course_Name from BS where Course_Department ='CYS'and Course_Semester=" + Sem_No + " and Course_Student_Type in('EM','E')";
                    arr1.Clear();
                    arr2.Clear();
                    ClearVariables();
                    arr1.Insert(0, "----- Choose Option -----");
                    LoadDataComboBox(query);

                    data1 = comboBox1.Items.Add; AssignValues();

                    data1 = comboBox2.Items.Add; AssignValues();

                    data1 = comboBox3.Items.Add; AssignValues();

                    data1 = comboBox4.Items.Add; AssignValues();

                    data1 = comboBox5.Items.Add; AssignValues();

                    data1 = comboBox6.Items.Add; AssignValues();
                }

                else if (checkBox1.Checked == false)
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();
                    ClearaArray();
                    ClearComboArray();

                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();
                    
                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        comboBox1.Enabled = false;
                    }

                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                }

                else
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }


            }

            else
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();
                ClearaArray();
                ClearComboArray();
                comboBox1.Text = "----- Choose Option -----";
                comboBox2.Text = "----- Choose Option -----";
                comboBox3.Text = "----- Choose Option -----";
                comboBox4.Text = "----- Choose Option -----";
                comboBox5.Text = "----- Choose Option -----";
                comboBox6.Text = "----- Choose Option -----";



                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();
                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                if (checkBox2.Checked == true)
                {
                    comboBox1.Enabled = true;

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    checkBox1.Checked = false;
                    string query = "select Course_Name from BS where Course_Department ='CS'and Course_Semester=" + Sem_No + " and Course_Student_Type in('EM','M')";

                    arr1.Clear();
                    arr2.Clear();
                    ClearVariables();
                    arr1.Insert(0, "----- Choose Option -----");
                    LoadDataComboBox(query);

                    data1 = comboBox1.Items.Add; AssignValues();

                    data1 = comboBox2.Items.Add; AssignValues();

                    data1 = comboBox3.Items.Add; AssignValues();

                    data1 = comboBox4.Items.Add; AssignValues();

                    data1 = comboBox5.Items.Add; AssignValues();

                    data1 = comboBox6.Items.Add; AssignValues();

                }
                else if (checkBox2.Checked == false)
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();
                    ClearaArray();

                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        comboBox1.Enabled = false;
                    }

                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }
                else
                {
                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();



                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }

            }

            else if (radioButton2.Checked == true)
            {

                if (checkBox2.Checked == true)
                {
                    comboBox1.Enabled = true;

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    checkBox1.Checked = false;
                    string query = "select Course_Name from BS where Course_Department ='SE'and Course_Semester=" + Sem_No + " and Course_Student_Type in('EM','M')";

                    arr1.Clear();
                    arr2.Clear();
                    ClearVariables();
                    arr1.Insert(0, "----- Choose Option -----");
                    LoadDataComboBox(query);

                    data1 = comboBox1.Items.Add; AssignValues();

                    data1 = comboBox2.Items.Add; AssignValues();

                    data1 = comboBox3.Items.Add; AssignValues();

                    data1 = comboBox4.Items.Add; AssignValues();

                    data1 = comboBox5.Items.Add; AssignValues();

                    data1 = comboBox6.Items.Add; AssignValues();

                }
                else if (checkBox2.Checked == false)
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();
                  
                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        comboBox1.Enabled = false;
                    }

                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                }
                else
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }


            }

            else if (radioButton3.Checked == true)
            {

                if (checkBox2.Checked == true)
                {
                    comboBox1.Enabled = true;
                   
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";

                    ClearaArray();
                    ClearComboArray();
                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    checkBox1.Checked = false;
                    string query = "select Course_Name from BS where Course_Department ='AI'and Course_Semester=" + Sem_No + " and Course_Student_Type in('EM','M')";

                    arr1.Clear();
                    arr2.Clear();
                    ClearVariables();
                    arr1.Insert(0, "----- Choose Option -----");
                    LoadDataComboBox(query);

                    data1 = comboBox1.Items.Add; AssignValues();

                    data1 = comboBox2.Items.Add; AssignValues();

                    data1 = comboBox3.Items.Add; AssignValues();

                    data1 = comboBox4.Items.Add; AssignValues();

                    data1 = comboBox5.Items.Add; AssignValues();

                    data1 = comboBox6.Items.Add; AssignValues();

                }
                else if (checkBox2.Checked == false)
                {
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();
                    ClearaArray();
                    ClearComboArray();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        comboBox1.Enabled = false;
                    }

                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }
                else
                {
                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }


            }

            else if (radioButton4.Checked == true)
            {

                if (checkBox2.Checked == true)
                {
                    comboBox1.Enabled = true;
                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();

                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    checkBox1.Checked = false;

                    string query = "select Course_Name from BS where Course_Department ='CYS'and Course_Semester=" + Sem_No + " and Course_Student_Type in('EM','M')";

                    arr1.Clear();
                    arr2.Clear();
                    ClearVariables();
                    arr1.Insert(0, "----- Choose Option -----");
                    LoadDataComboBox(query);
                    data1 = comboBox1.Items.Add; AssignValues();

                    data1 = comboBox2.Items.Add; AssignValues();

                    data1 = comboBox3.Items.Add; AssignValues();

                    data1 = comboBox4.Items.Add; AssignValues();

                    data1 = comboBox5.Items.Add; AssignValues();

                    data1 = comboBox6.Items.Add; AssignValues();

                }
                else if (checkBox2.Checked == false)
                {
                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();
                   
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";


                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        comboBox1.Enabled = false;
                    }

                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }
                else
                {
                    ClearaArray();
                    ClearComboArray();
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox4.Items.Clear();
                    comboBox5.Items.Clear();
                    comboBox6.Items.Clear();
                    label6.Text = "0";
                    label9.Text = "0.00";
                    label11.Text = "0.00";
                    label14.Text = "0";
                    comboBox1.Text = "----- Choose Option -----";
                    comboBox2.Text = "----- Choose Option -----";
                    comboBox3.Text = "----- Choose Option -----";
                    comboBox4.Text = "----- Choose Option -----";
                    comboBox5.Text = "----- Choose Option -----";
                    comboBox6.Text = "----- Choose Option -----";



                    comboBox7.SelectedIndex = -1;
                    comboBox8.SelectedIndex = -1;
                    comboBox9.SelectedIndex = -1;
                    comboBox10.SelectedIndex = -1;
                    comboBox11.SelectedIndex = -1;
                    comboBox12.SelectedIndex = -1;


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox14.Clear();
                    textBox15.Clear();
                    textBox17.Clear();
                    textBox18.Clear();

                    textBox16.Clear();
                    textBox13.Clear();
                    textBox10.Clear();
                    textBox7.Clear();
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox24.Clear();
                    textBox23.Clear();
                    textBox22.Clear();
                    textBox20.Clear();
                    textBox21.Clear();
                    textBox19.Clear();

                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                    comboBox6.Enabled = false;
                    comboBox7.Enabled = false;
                    comboBox8.Enabled = false;
                    comboBox9.Enabled = false;
                    comboBox10.Enabled = false;
                    comboBox11.Enabled = false;
                    comboBox12.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = false;
                    textBox11.Enabled = false;
                    textBox12.Enabled = false;
                    textBox14.Enabled = false;
                    textBox15.Enabled = false;
                    textBox17.Enabled = false;
                    textBox18.Enabled = false;
                }


            }
            else
            {
                ClearaArray();
                ClearComboArray();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();
                label6.Text = "0";
                label9.Text = "0.00";
                label11.Text = "0.00";
                label14.Text = "0";
                comboBox1.Text = "----- Choose Option -----";
                comboBox2.Text = "----- Choose Option -----";
                comboBox3.Text = "----- Choose Option -----";
                comboBox4.Text = "----- Choose Option -----";
                comboBox5.Text = "----- Choose Option -----";
                comboBox6.Text = "----- Choose Option -----";



                comboBox7.SelectedIndex = -1;
                comboBox8.SelectedIndex = -1;
                comboBox9.SelectedIndex = -1;
                comboBox10.SelectedIndex = -1;
                comboBox11.SelectedIndex = -1;
                comboBox12.SelectedIndex = -1;


                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox17.Clear();
                textBox18.Clear();

                textBox16.Clear();
                textBox13.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox24.Clear();
                textBox23.Clear();
                textBox22.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox19.Clear();

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
                comboBox7.Enabled = false;
                comboBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox2.Text;


            if (comboBox1.SelectedItem.ToString() != "----- Choose Option -----")
            {

                string query = "select * from BS where Course_Name='" + comboBox1.SelectedItem.ToString() + "'";
                DataSet ds = GetData(query);
                textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox2.Text = ds.Tables[0].Rows[0][2].ToString();

                if (txt != "")
                {
                    if (string.Equals(txt, textBox2.Text) == false)
                    {
                        label6.Text = (int.Parse(label6.Text) - int.Parse(txt)).ToString();
                    }
                        
                }

                if (items[0] != comboBox1.SelectedItem.ToString())
                {
                    comboBox7.Enabled = true;
                    comboBox7.SelectedIndex = -1;

                    textBox16.Clear();
                    textBox24.Clear();
                }

                items[0] = comboBox1.SelectedItem.ToString();

            }


            if (var1 != null) { arr2.Remove(var1); }
            var1 = comboBox1.SelectedItem.ToString();
            if (var1 != "----- Choose Option -----")
            arr2.Add(var1);
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            data1 = comboBox2.Items.Add; AssignValues();
            data1 = comboBox3.Items.Add; AssignValues();
            data1 = comboBox4.Items.Add; AssignValues();
            data1 = comboBox5.Items.Add; AssignValues();
            data1 = comboBox6.Items.Add; AssignValues();

            data2 = comboBox2.Items.Remove; RemoveValues(var2);
            data2 = comboBox3.Items.Remove; RemoveValues(var3);
            data2 = comboBox4.Items.Remove; RemoveValues(var4);
            data2 = comboBox5.Items.Remove; RemoveValues(var5);
            data2 = comboBox6.Items.Remove; RemoveValues(var6);



            if (var1 == "----- Choose Option -----")
            {
                if (textBox2.Text != "")
                {
                    label6.Text = (int.Parse(label6.Text) - int.Parse(textBox2.Text)).ToString();
                }
                    
                if (textBox24.Text != "")
                {
                    label9.Text = (double.Parse(label9.Text) - double.Parse(textBox24.Text)).ToString("#0.00");
                }

                CmbPreInd[0] = -1;
                items[0] = null;
                textBox1.Clear();
                textBox2.Clear();
                textBox16.Clear();
                textBox24.Clear();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                comboBox7.Enabled = false;
                comboBox7.SelectedIndex = -1;
            }
           
              
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox5.Text;

            if (comboBox2.SelectedItem.ToString() != "----- Choose Option -----")
            {
                string query = "select * from BS where Course_Name='" + comboBox2.SelectedItem.ToString() + "'";
                DataSet ds = GetData(query);
                textBox6.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox5.Text = ds.Tables[0].Rows[0][2].ToString();

                if (txt != "")
                {
                    if (string.Equals(txt, textBox5.Text) == false)
                    {
                        label6.Text = (int.Parse(label6.Text) - int.Parse(txt)).ToString();
                    }
                        
                }

                if (items[1] != comboBox2.SelectedItem.ToString())
                {
                    comboBox8.Enabled = true;
                    comboBox8.SelectedIndex = -1;

                    textBox13.Clear();
                    textBox23.Clear();
                }

                items[1] = comboBox2.SelectedItem.ToString();
            }


            if (var2 != null) { arr2.Remove(var2); }
            var2 = comboBox2.SelectedItem.ToString();
            if (var2 != "----- Choose Option -----")
            arr2.Add(var2);
            comboBox1.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            data1 = comboBox1.Items.Add; AssignValues();
            data1 = comboBox3.Items.Add; AssignValues();
            data1 = comboBox4.Items.Add; AssignValues();
            data1 = comboBox5.Items.Add; AssignValues();
            data1 = comboBox6.Items.Add; AssignValues();

            data2 = comboBox1.Items.Remove; RemoveValues(var1);
            data2 = comboBox3.Items.Remove; RemoveValues(var3);
            data2 = comboBox4.Items.Remove; RemoveValues(var4);
            data2 = comboBox5.Items.Remove; RemoveValues(var5);
            data2 = comboBox6.Items.Remove; RemoveValues(var6);


            if (var2 == "----- Choose Option -----")
            {
                if (textBox5.Text != "")
                {
                    label6.Text = (int.Parse(label6.Text) - int.Parse(textBox5.Text)).ToString();
                }
                   
                if (textBox23.Text != "")
                {
                    label9.Text = (double.Parse(label9.Text) - double.Parse(textBox23.Text)).ToString("#0.00");
                }
                CmbPreInd[1] = -1;
                items[1] = null;
                textBox5.Clear();
                textBox6.Clear();
                textBox13.Clear();
                textBox23.Clear();
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                comboBox8.Enabled = false;
                comboBox8.SelectedIndex = -1;
            }
           
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox8.Text;

            if (comboBox3.SelectedItem.ToString() != "----- Choose Option -----")
            {
                string query = "select * from BS where Course_Name='" + comboBox3.SelectedItem.ToString() + "'";
                DataSet ds = GetData(query);
                textBox9.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox8.Text = ds.Tables[0].Rows[0][2].ToString();

                if (txt != "")
                {
                    if (string.Equals(txt, textBox8.Text) == false)
                    {
                        label6.Text = (int.Parse(label6.Text) - int.Parse(txt)).ToString();
                    }
                        
                }

                if (items[2] != comboBox3.SelectedItem.ToString())
                {
                    comboBox9.Enabled = true;
                    comboBox9.SelectedIndex = -1;

                    textBox10.Clear();
                    textBox22.Clear();
                }

                items[2] = comboBox3.SelectedItem.ToString();
            }


            if (var3 != null) { arr2.Remove(var3); }
            var3 = comboBox3.SelectedItem.ToString();
            if (var3 != "----- Choose Option -----")
            arr2.Add(var3);
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            data1 = comboBox2.Items.Add; AssignValues();
            data1 = comboBox1.Items.Add; AssignValues();
            data1 = comboBox4.Items.Add; AssignValues();
            data1 = comboBox5.Items.Add; AssignValues();
            data1 = comboBox6.Items.Add; AssignValues();

            data2 = comboBox2.Items.Remove; RemoveValues(var2);
            data2 = comboBox1.Items.Remove; RemoveValues(var1);
            data2 = comboBox4.Items.Remove; RemoveValues(var4);
            data2 = comboBox5.Items.Remove; RemoveValues(var5);
            data2 = comboBox6.Items.Remove; RemoveValues(var6);

            if (var3 == "----- Choose Option -----")
            {
                if (textBox8.Text != "")
                {
                    label6.Text = (int.Parse(label6.Text) - int.Parse(textBox8.Text)).ToString();
                }
                    
                if (textBox22.Text != "")
                {
                    label9.Text = (double.Parse(label9.Text) - double.Parse(textBox22.Text)).ToString("#0.00");
                }
                CmbPreInd[2] = -1;
                items[2] = null;
                textBox9.Clear();
                textBox8.Clear();
                textBox10.Clear();
                textBox22.Clear();
                textBox9.Enabled = false;
                textBox8.Enabled = false;
                comboBox9.Enabled = false;
                comboBox9.SelectedIndex = -1;
            }
          
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox11.Text;

            if (comboBox4.SelectedItem.ToString() != "----- Choose Option -----")
            {
                string query = "select * from BS where Course_Name='" + comboBox4.SelectedItem.ToString() + "'";
                DataSet ds = GetData(query);
                textBox12.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox11.Text = ds.Tables[0].Rows[0][2].ToString();

                if (txt != "")
                {
                    if (string.Equals(txt, textBox11.Text) == false)
                    {
                        label6.Text = (int.Parse(label6.Text) - int.Parse(txt)).ToString();
                    }
                        
                }
                
                if (items[3] != comboBox4.SelectedItem.ToString())
                {
                    comboBox10.Enabled = true;
                    comboBox10.SelectedIndex = -1;

                    textBox7.Clear();
                    textBox21.Clear();
                }

                items[3] = comboBox4.SelectedItem.ToString();
            }

            if (var4 != null) { arr2.Remove(var4); }
            var4 = comboBox4.SelectedItem.ToString();
            if (var4 != "----- Choose Option -----")
            arr2.Add(var4);
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox1.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            data1 = comboBox2.Items.Add; AssignValues();
            data1 = comboBox3.Items.Add; AssignValues();
            data1 = comboBox1.Items.Add; AssignValues();
            data1 = comboBox5.Items.Add; AssignValues();
            data1 = comboBox6.Items.Add; AssignValues();

            data2 = comboBox2.Items.Remove; RemoveValues(var2);
            data2 = comboBox3.Items.Remove; RemoveValues(var3);
            data2 = comboBox1.Items.Remove; RemoveValues(var1);
            data2 = comboBox5.Items.Remove; RemoveValues(var5);
            data2 = comboBox6.Items.Remove; RemoveValues(var6);

            if (var4 == "----- Choose Option -----")
            {
                if (textBox11.Text != "")
                {
                    label6.Text = (int.Parse(label6.Text) - int.Parse(textBox11.Text)).ToString();
                }
                    
                if (textBox21.Text != "")
                {
                    label9.Text = (double.Parse(label9.Text) - double.Parse(textBox21.Text)).ToString("#0.00");
                }
                CmbPreInd[3] = -1;
                items[3] = null;
                textBox12.Clear();
                textBox11.Clear();
                textBox7.Clear();
                textBox21.Clear();
                textBox12.Enabled = false;
                textBox11.Enabled = false;
                comboBox10.Enabled = false;
                comboBox10.SelectedIndex = -1;
            }

          
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox14.Text;

            if (comboBox5.SelectedItem.ToString() != "----- Choose Option -----")
            {
                string query = "select * from BS where Course_Name='" + comboBox5.SelectedItem.ToString() + "'";
                DataSet ds = GetData(query);
                textBox15.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox14.Text = ds.Tables[0].Rows[0][2].ToString();

                if (txt != "")
                {
                    if (string.Equals(txt, textBox14.Text) == false)
                    {
                        label6.Text = (int.Parse(label6.Text) - int.Parse(txt)).ToString();
                    }
                        
                }

                if (items[4] != comboBox5.SelectedItem.ToString())
                {
                    comboBox11.Enabled = true;
                    comboBox11.SelectedIndex = -1;

                    textBox4.Clear();
                    textBox20.Clear();
                }

                items[4] = comboBox5.SelectedItem.ToString();
            }

            if (var5 != null) { arr2.Remove(var5); }
            var5 = comboBox5.SelectedItem.ToString();
            if (var5 != "----- Choose Option -----")
            arr2.Add(var5);
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox1.Items.Clear();
            comboBox6.Items.Clear();

            data1 = comboBox2.Items.Add; AssignValues();
            data1 = comboBox3.Items.Add; AssignValues();
            data1 = comboBox4.Items.Add; AssignValues();
            data1 = comboBox1.Items.Add; AssignValues();
            data1 = comboBox6.Items.Add; AssignValues();

            data2 = comboBox2.Items.Remove; RemoveValues(var2);
            data2 = comboBox3.Items.Remove; RemoveValues(var3);
            data2 = comboBox4.Items.Remove; RemoveValues(var4);
            data2 = comboBox1.Items.Remove; RemoveValues(var1);
            data2 = comboBox6.Items.Remove; RemoveValues(var6);

            if (var5 == "----- Choose Option -----")
            {
                if (textBox14.Text != "")
                {
                    label6.Text = (int.Parse(label6.Text) - int.Parse(textBox14.Text)).ToString();
                }
                    
                if (textBox20.Text != "")
                {
                    label9.Text = (double.Parse(label9.Text) - double.Parse(textBox20.Text)).ToString("#0.00");
                }
                CmbPreInd[4] = -1;
                items[4] = null;
                textBox15.Clear();
                textBox14.Clear();
                textBox4.Clear();
                textBox20.Clear();
                textBox15.Enabled = false;
                textBox14.Enabled = false;
                comboBox11.Enabled = false;
                comboBox11.SelectedIndex = -1;
            }

           
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox17.Text;

            if (comboBox6.SelectedItem.ToString() != "----- Choose Option -----")
            {
                string query = "select * from BS where Course_Name='" + comboBox6.SelectedItem.ToString() + "'";
                DataSet ds = GetData(query);
                textBox18.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox17.Text = ds.Tables[0].Rows[0][2].ToString();

                if (txt != "")
                {
                    if (string.Equals(txt, textBox17.Text) == false)
                    {
                        label6.Text = (int.Parse(label6.Text) - int.Parse(txt)).ToString();
                    }
                        
                }

                if (items[5] != comboBox6.SelectedItem.ToString())
                {
                    comboBox12.Enabled = true;
                    comboBox12.SelectedIndex = -1;

                    textBox3.Clear();
                    textBox19.Clear();
                }

                items[5] = comboBox6.SelectedItem.ToString();
            }


            if (var6 != null) { arr2.Remove(var6); }
            var6 = comboBox6.SelectedItem.ToString();
            if (var6 != "----- Choose Option -----")
            arr2.Add(var6);
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox1.Items.Clear();

            data1 = comboBox2.Items.Add; AssignValues();
            data1 = comboBox3.Items.Add; AssignValues();
            data1 = comboBox4.Items.Add; AssignValues();
            data1 = comboBox5.Items.Add; AssignValues();
            data1 = comboBox1.Items.Add; AssignValues();

            data2 = comboBox2.Items.Remove; RemoveValues(var2);
            data2 = comboBox3.Items.Remove; RemoveValues(var3);
            data2 = comboBox4.Items.Remove; RemoveValues(var4);
            data2 = comboBox5.Items.Remove; RemoveValues(var5);
            data2 = comboBox1.Items.Remove; RemoveValues(var1);

            if (var6 == "----- Choose Option -----")
            {
                if (textBox17.Text != "")
                {
                    label6.Text = (int.Parse(label6.Text) - int.Parse(textBox17.Text)).ToString();
                }
                    
                if (textBox19.Text != "")
                {
                    label9.Text = (double.Parse(label9.Text) - double.Parse(textBox19.Text)).ToString("#0.00");
                }
                CmbPreInd[5] = -1;
                items[5] = null;
                textBox18.Clear();
                textBox17.Clear();
                textBox3.Clear();
                textBox19.Clear();
                textBox18.Enabled = false;
                textBox17.Enabled = false;
                comboBox12.Enabled = false;
                comboBox12.SelectedIndex = -1;
            }

           
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox24.Text;

            if (txt != "")
            {
                if (CmbPreInd[0] != comboBox7.SelectedIndex)
                label9.Text = (double.Parse(label9.Text) - double.Parse(txt)).ToString("#0.00");
            }
            CmbPreInd[0] = comboBox7.SelectedIndex;
            comboBox2.Enabled = true;
            if (comboBox7.SelectedIndex == 0)
            {
                textBox16.Text = "4.00";
            }
            else if (comboBox7.SelectedIndex == 1)
            {
                textBox16.Text = "3.67";

            }
            else if (comboBox7.SelectedIndex == 2)
            {
                textBox16.Text = "3.33";

            }
            else if (comboBox7.SelectedIndex == 3)
            {
                textBox16.Text = "3.00";

            }
            else if (comboBox7.SelectedIndex == 4)
            {
                textBox16.Text = "2.67";

            }
            else if (comboBox7.SelectedIndex == 5)
            {
                textBox16.Text = "2.33";

            }
            else if (comboBox7.SelectedIndex == 6)
            {
                textBox16.Text = "2.00";

            }
            else if (comboBox7.SelectedIndex == 7)
            {
                textBox16.Text = "1.67";

            }
            else if (comboBox7.SelectedIndex == 8)
            {
                textBox16.Text = "1.33";

            }
            else if (comboBox7.SelectedIndex == 9)
            {
                textBox16.Text = "1.00";

            }
            else if (comboBox7.SelectedIndex == 10)
            {
                textBox16.Text = "0.00";

            }
           
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox23.Text;

            if (txt != "")
            {
                if (CmbPreInd[1] != comboBox8.SelectedIndex)
                label9.Text = (double.Parse(label9.Text) - double.Parse(txt)).ToString("#0.00");
            }
            CmbPreInd[1] = comboBox8.SelectedIndex;
            comboBox3.Enabled = true;
            if (comboBox8.SelectedIndex == 0)
            {
                textBox13.Text = "4.00";
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                textBox13.Text = "3.67";

            }
            else if (comboBox8.SelectedIndex == 2)
            {
                textBox13.Text = "3.33";

            }
            else if (comboBox8.SelectedIndex == 3)
            {
                textBox13.Text = "3.00";

            }
            else if (comboBox8.SelectedIndex == 4)
            {
                textBox13.Text = "2.67";

            }
            else if (comboBox8.SelectedIndex == 5)
            {
                textBox13.Text = "2.33";

            }
            else if (comboBox8.SelectedIndex == 6)
            {
                textBox13.Text = "2.00";

            }
            else if (comboBox8.SelectedIndex == 7)
            {
                textBox13.Text = "1.67";

            }
            else if (comboBox8.SelectedIndex == 8)
            {
                textBox13.Text = "1.33";

            }
            else if (comboBox8.SelectedIndex == 9)
            {
                textBox13.Text = "1.00";

            }
            else if (comboBox8.SelectedIndex == 10)
            {
                textBox13.Text = "0.00";

            }
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox22.Text;

            if (txt != "")
            {
                if (CmbPreInd[2] != comboBox9.SelectedIndex)
                label9.Text = (double.Parse(label9.Text) - double.Parse(txt)).ToString("#0.00");
            }
            CmbPreInd[2] = comboBox9.SelectedIndex;
            comboBox4.Enabled = true;
            if (comboBox9.SelectedIndex == 0)
            {
                textBox10.Text = "4.00";
            }
            else if (comboBox9.SelectedIndex == 1)
            {
                textBox10.Text = "3.67";

            }
            else if (comboBox9.SelectedIndex == 2)
            {
                textBox10.Text = "3.33";

            }
            else if (comboBox9.SelectedIndex == 3)
            {
                textBox10.Text = "3.00";

            }
            else if (comboBox9.SelectedIndex == 4)
            {
                textBox10.Text = "2.67";

            }
            else if (comboBox9.SelectedIndex == 5)
            {
                textBox10.Text = "2.33";

            }
            else if (comboBox9.SelectedIndex == 6)
            {
                textBox10.Text = "2.00";

            }
            else if (comboBox9.SelectedIndex == 7)
            {
                textBox10.Text = "1.67";

            }
            else if (comboBox9.SelectedIndex == 8)
            {
                textBox10.Text = "1.33";

            }
            else if (comboBox9.SelectedIndex == 9)
            {
                textBox10.Text = "1.00";

            }
            else if (comboBox9.SelectedIndex == 10)
            {
                textBox10.Text = "0.00";

            }
        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox21.Text;

            if (txt != "")
            {
                if (CmbPreInd[3] != comboBox10.SelectedIndex)
                label9.Text = (double.Parse(label9.Text) - double.Parse(txt)).ToString("#0.00");
            }
            CmbPreInd[3] = comboBox10.SelectedIndex;
            comboBox5.Enabled = true;
            if (comboBox10.SelectedIndex == 0)
            {
                textBox7.Text = "4.00";
            }
            else if (comboBox10.SelectedIndex == 1)
            {
                textBox7.Text = "3.67";

            }
            else if (comboBox10.SelectedIndex == 2)
            {
                textBox7.Text = "3.33";

            }
            else if (comboBox10.SelectedIndex == 3)
            {
                textBox7.Text = "3.00";

            }
            else if (comboBox10.SelectedIndex == 4)
            {
                textBox7.Text = "2.67";

            }
            else if (comboBox10.SelectedIndex == 5)
            {
                textBox7.Text = "2.33";

            }
            else if (comboBox10.SelectedIndex == 6)
            {
                textBox7.Text = "2.00";

            }
            else if (comboBox10.SelectedIndex == 7)
            {
                textBox7.Text = "1.67";

            }
            else if (comboBox10.SelectedIndex == 8)
            {
                textBox7.Text = "1.33";

            }
            else if (comboBox10.SelectedIndex == 9)
            {
                textBox7.Text = "1.00";

            }
            else if (comboBox10.SelectedIndex == 10)
            {
                textBox7.Text = "0.00";

            }
        }
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox20.Text;

            if (txt != "")
            {
                if (CmbPreInd[4] != comboBox11.SelectedIndex)
                label9.Text = (double.Parse(label9.Text) - double.Parse(txt)).ToString("#0.00");
            }
            CmbPreInd[4] = comboBox11.SelectedIndex;
            comboBox6.Enabled = true;
            if (comboBox11.SelectedIndex == 0)
            {
                textBox4.Text = "4.00";
            }
            else if (comboBox11.SelectedIndex == 1)
            {
                textBox4.Text = "3.67";

            }
            else if (comboBox11.SelectedIndex == 2)
            {
                textBox4.Text = "3.33";

            }
            else if (comboBox11.SelectedIndex == 3)
            {
                textBox4.Text = "3.00";

            }
            else if (comboBox11.SelectedIndex == 4)
            {
                textBox4.Text = "2.67";

            }
            else if (comboBox11.SelectedIndex == 5)
            {
                textBox4.Text = "2.33";

            }
            else if (comboBox11.SelectedIndex == 6)
            {
                textBox4.Text = "2.00";

            }
            else if (comboBox11.SelectedIndex == 7)
            {
                textBox4.Text = "1.67";

            }
            else if (comboBox11.SelectedIndex == 8)
            {
                textBox4.Text = "1.33";

            }
            else if (comboBox11.SelectedIndex == 9)
            {
                textBox4.Text = "1.00";

            }
            else if (comboBox11.SelectedIndex == 10)
            {
                textBox4.Text = "0.00";

            }
        }
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt = textBox19.Text;

            if (txt != "")
            {
                if (CmbPreInd[5] != comboBox12.SelectedIndex)
                label9.Text = (double.Parse(label9.Text) - double.Parse(txt)).ToString("#0.00");
            }
            CmbPreInd[5] = comboBox12.SelectedIndex;
            if (comboBox12.SelectedIndex == 0)
            {
                textBox3.Text = "4.00";
            }
            else if (comboBox12.SelectedIndex == 1)
            {
                textBox3.Text = "3.67";

            }
            else if (comboBox12.SelectedIndex == 2)
            {
                textBox3.Text = "3.33";

            }
            else if (comboBox12.SelectedIndex == 3)
            {
                textBox3.Text = "3.00";

            }
            else if (comboBox12.SelectedIndex == 4)
            {
                textBox3.Text = "2.67";

            }
            else if (comboBox12.SelectedIndex == 5)
            {
                textBox3.Text = "2.33";

            }
            else if (comboBox12.SelectedIndex == 6)
            {
                textBox3.Text = "2.00";

            }
            else if (comboBox12.SelectedIndex == 7)
            {
                textBox3.Text = "1.67";

            }
            else if (comboBox12.SelectedIndex == 8)
            {
                textBox3.Text = "1.33";

            }
            else if (comboBox12.SelectedIndex == 9)
            {
                textBox3.Text = "1.00";

            }
            else if (comboBox12.SelectedIndex == 10)
            {
                textBox3.Text = "0.00";

            }
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
        private void comboBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void comboBox12_KeyPress(object sender, KeyPressEventArgs e)
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
        private void comboBox9_KeyDown(object sender, KeyEventArgs e)
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
        private void comboBox10_KeyDown(object sender, KeyEventArgs e)
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
        private void comboBox11_KeyDown(object sender, KeyEventArgs e)
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
        private void comboBox12_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                label6.Text = (int.Parse(label6.Text) + int.Parse(textBox2.Text)).ToString();
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                label6.Text = (int.Parse(label6.Text) + int.Parse(textBox5.Text)).ToString();
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                label6.Text = (int.Parse(label6.Text) + int.Parse(textBox8.Text)).ToString();
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                label6.Text = (int.Parse(label6.Text) + int.Parse(textBox11.Text)).ToString();
            }
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                label6.Text = (int.Parse(label6.Text) + int.Parse(textBox14.Text)).ToString();
            }
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text != "")
            {
                label6.Text = (int.Parse(label6.Text) + int.Parse(textBox17.Text)).ToString();
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            double a;
            double b;

            bool isAValid = double.TryParse(textBox16.Text, out a);
            bool isBValid = double.TryParse(textBox2.Text, out b);

            textBox24.Text = (a * b).ToString("#0.00");
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            double a;
            double b;

            bool isAValid = double.TryParse(textBox13.Text, out a);
            bool isBValid = double.TryParse(textBox5.Text, out b);

            textBox23.Text = (a * b).ToString("#0.00");
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double a;
            double b;

            bool isAValid = double.TryParse(textBox10.Text, out a);
            bool isBValid = double.TryParse(textBox8.Text, out b);

            textBox22.Text = (a * b).ToString("#0.00");
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double a;
            double b;

            bool isAValid = double.TryParse(textBox7.Text, out a);
            bool isBValid = double.TryParse(textBox11.Text, out b);

            textBox21.Text = (a * b).ToString("#0.00");
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double a;
            double b;

            bool isAValid = double.TryParse(textBox4.Text, out a);
            bool isBValid = double.TryParse(textBox14.Text, out b);

            textBox20.Text = (a * b).ToString("#0.00");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double a;
            double b;

            bool isAValid = double.TryParse(textBox3.Text, out a);
            bool isBValid = double.TryParse(textBox17.Text, out b);

            textBox19.Text = (a * b).ToString("#0.00");
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {           
            CheckComboBoxes();
            if (textBox24.Text != "")
            {               
                label9.Text = (double.Parse(label9.Text) + double.Parse(textBox24.Text)).ToString("#0.00");
                label11.Text = "";
                double res = double.Parse(label9.Text) / (double.Parse(label6.Text)-count);
                label11.Text += "" + res.ToString("#0.00");               
            }
            label14.Text = (int.Parse(label6.Text) - count).ToString();
            count = 0;
            CheckTextBoxes();
        }
        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            CheckComboBoxes();
            if (textBox23.Text != "")
            {
                label9.Text = (double.Parse(label9.Text) + double.Parse(textBox23.Text)).ToString("#0.00");
                label11.Text = "";
                double res = double.Parse(label9.Text) / (double.Parse(label6.Text) - count);
                label11.Text += "" + res.ToString("#0.00");               
            }
            label14.Text = (int.Parse(label6.Text) - count).ToString();
            count = 0;
            CheckTextBoxes();
        }
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            CheckComboBoxes();
            if (textBox22.Text != "")
            {
                label9.Text = (double.Parse(label9.Text) + double.Parse(textBox22.Text)).ToString("#0.00");
                label11.Text = "";
                double res = double.Parse(label9.Text) / (double.Parse(label6.Text) - count);
                label11.Text += "" + res.ToString("#0.00");            
            }
            label14.Text = (int.Parse(label6.Text) - count).ToString();
            count = 0;
            CheckTextBoxes();
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            CheckComboBoxes();
            if (textBox21.Text != "")
            {
                label9.Text = (double.Parse(label9.Text) + double.Parse(textBox21.Text)).ToString("#0.00");
                label11.Text = "";
                double res = double.Parse(label9.Text) / (double.Parse(label6.Text) - count);
                label11.Text += "" + res.ToString("#0.00");               
            }
            label14.Text = (int.Parse(label6.Text) - count).ToString();
            count = 0;
            CheckTextBoxes();
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            CheckComboBoxes();
            if (textBox20.Text != "")
            {
                label9.Text = (double.Parse(label9.Text) + double.Parse(textBox20.Text)).ToString("#0.00");
                label11.Text = "";
                double res = double.Parse(label9.Text) / (double.Parse(label6.Text) - count);
                label11.Text += "" + res.ToString("#0.00");             
            }
            label14.Text = (int.Parse(label6.Text) - count).ToString();
            count = 0;
            CheckTextBoxes();
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            CheckComboBoxes();
            if (textBox19.Text != "")
            {
                label9.Text = (double.Parse(label9.Text) + double.Parse(textBox19.Text)).ToString("#0.00");
                label11.Text = "";
                double res = double.Parse(label9.Text) / (double.Parse(label6.Text) - count);
                label11.Text += "" + res.ToString("#0.00");              
            }
            label14.Text = (int.Parse(label6.Text) - count).ToString();
            count = 0;
            CheckTextBoxes();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {
           
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        

    }
}
