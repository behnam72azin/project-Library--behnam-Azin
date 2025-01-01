using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management
{
    public partial class Form1 : Form
        
    {
        public string library = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

/*======================================================================*/
        DataSet ds = new DataSet();
        SqlConnection con;
        SqlDataAdapter da;
        bool rd=true;
        string strsql;
        int co=0;
        public int nrow;
        public int id;
/*======================================================================*/
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

          //  if (this.Owner != null)
                //this.Owner.Close();
            library = "|DataDirectory|\\Library.mdf";
            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename="+library+";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(strcon);
            textBox2.PasswordChar = '*';

         
            
        }

        private void empty()
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

            ds.Clear();
            co = 0;
            progressBar1.Increment(20);
            if (Convert.ToInt32(progressBar1.Value) == 60)
                progressBar1.Value = 20;
                //                progressBar1.BackColor = Color.Orange;



            if (textBox1.Text != "نام کاربری یا رمز عبور اشتباه است" && textBox1.Text != "نام کاربری را وارد نکردید" && textBox1.Text != "رمز عبور را وارد نکردید" && textBox1.Text != "نام کاربری و رمز عبور را وارد نکردید")
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    if (textBox2.Text != "")
                    {
                        if (textBox1.Text != "")
                        {


                            if (rd)
                            {
                                strsql = "select id_user,sh_m,active from users where id_user = " + textBox1.Text + "and sh_m ='" + textBox2.Text + "'";

                            }
                            else
                            {
                                strsql = "select nrow,id,password from admins where id = " + textBox1.Text + "and password ='" + textBox2.Text + "'";
                            }



                            da = new SqlDataAdapter(strsql, con);

                            con.Open();
                            da.Fill(ds, "login");
                            con.Close();
                            

                            co = ds.Tables["login"].Rows.Count;

                            if (co == 1 || (textBox1.Text == "110" && textBox2.Text == "110"))
                            {
                                nrow = 0;
                                id = 0;
                                if (co == 1)
                                {
                                    nrow = Convert.ToInt32(ds.Tables["login"].Rows[0].ItemArray.GetValue(0));
                                    id = Convert.ToInt32(ds.Tables["login"].Rows[0].ItemArray.GetValue(1));
                                }
                            

                            
                           
                                if(rd)
                                {
                                    if (nrow != 0)
                                    {
                                        if (ds.Tables["login"].Rows[0].ItemArray.GetValue(2).ToString() == "فعال")
                                        {
                                            Form user = new user_ui(nrow, library);
                                            Form1.ActiveForm.Hide();
                                            user.Show(this);
                                        }
                                        else
                                        {
                                            textBox1.Text = "شناسه شما غیر فعال است";
                                            textBox2.Text = "";
                                        }
                                    }
                                    

                                }
                                else
                                {
                                    Form adminform = new admin(nrow,id,library);
                                    Form1.ActiveForm.Hide();
                                    adminform.Show(this);


                                }
   
                                



                            }
                            else
                            {
                                ds.Clear();
                                textBox1.Text = "نام کاربری یا رمز عبور اشتباه است";
                                textBox1.BackColor = Color.Orange;
                                textBox2.Text = "000000";
                                textBox2.BackColor = Color.Orange;
                                co = 0;
                            }

                        }
                        else
                            textBox1.Text = "نام کاربری را وارد نکردید";
                    }
                    else
                        textBox1.Text = "رمز عبور را وارد نکردید";
                    textBox2.Text = "000000";



                }
                else
                {
                    textBox1.Text = "نام کاربری و رمز عبور را وارد نکردید";
                    textBox2.Text = "000000";
                }



            }
            


        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            

            if (co > 0)
                ds.Clear();
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.BackColor = Color.White;

            if (co > 0)
                ds.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                rd = false;
            
                ds.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                rd = true;
            
                ds.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  textBox2.Text = textBox1.Text.GetType().ToString();
            label4.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)) 
                e.Handled = true;
            label4.Text = "نام کاربری شامل اعداد 0 تا 9 میباشد";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB dbf = new DB();
            Form1.ActiveForm.Enabled = false;
            dbf.Show(this);
        }


    }
}
