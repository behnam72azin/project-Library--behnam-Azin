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
using System.Drawing.Imaging;

namespace Library_Management
{
    public partial class admin : Form
    {
        public string library = "";
        public int nrow;
        public int id;
        public admin(int i,int j,string lib)
        {
            InitializeComponent();
            nrow=i;
            id = j;
            library = lib;
        }
 /*======================================================================*/

        SqlConnection con;
        SqlDataAdapter da = new SqlDataAdapter(), da1 = new SqlDataAdapter(), da2 = new SqlDataAdapter(), da3 = new SqlDataAdapter(), da4 = new SqlDataAdapter();
        DataSet ds = new DataSet(), ds1 = new DataSet(), ds2 = new DataSet(), ds3 = new DataSet(), ds4_amanat = new DataSet();
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        SqlCommandBuilder scb;
        SqlCommand sqc, sqcu, sqcd, sqce, sqcbook;
        bool newrows=false;
        bool nrowbut = false;
        bool sabt = false;
        bool sabtbook = false;
        bool textboxactb = true;
        int identity_users = 0;
        int identity_admins,identity_book = 0;
        Image im,imbook;
 /*======================================================================*/     
        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet_amanat.amanat' table. You can move, or remove it, as needed.
     //       this.amanatTableAdapter.Fill(this.libraryDataSet_amanat.amanat);
            // TODO: This line of code loads data into the 'libraryDataSet_amanat.amanat' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'libraryDataSet6.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.libraryDataSet6.users);
            // TODO: This line of code loads data into the 'libraryDataSet6.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet6.books);
            // TODO: This line of code loads data into the 'libraryDataSet4.request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.libraryDataSet4.request);

            if (this.Owner != null)
                this.Owner.Hide();
            label8.Text = "";
            label9.Text = "";
            textboxdisact();
/*====comboBOX=======================*/

            for (int i = 1385; i <= 1410; i++)
            {
                comboBox7.Items.Add(i);
            }
            for (int i = 1330; i <= 1385; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i);
                comboBox6.Items.Add(i);
            }
            for (int i = 1; i <= 31; i++)
            {
                comboBox3.Items.Add(i);
                comboBox5.Items.Add(i);
            }
/*=============نوسازی پایگاه داده======================================*/

            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;          
/*======================================================================*/

           
         
            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + library + ";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(strcon);
            string strsql="select * from admins";
            da=new SqlDataAdapter(strsql,con);
            ds=new DataSet();

            con.Open();
            da.Fill(ds,"admin");

            strsql = "select id_user from users";
            da1 = new SqlDataAdapter(strsql, con);
            da1.Fill(ds1, "user");

            strsql = "select id_book from books";
            da3 = new SqlDataAdapter(strsql, con);
            da3.Fill(ds1, "book");

            strsql = "select IDENT_CURRENT( 'users' )";
            sqcd = new SqlCommand(strsql, con);
            identity_users = Convert.ToInt32(sqcd.ExecuteScalar());

            strsql = "select IDENT_CURRENT( 'admins' )";
            sqcd = new SqlCommand(strsql, con);
            identity_admins = Convert.ToInt32(sqcd.ExecuteScalar());

           

            label44.DataBindings.Add(new Binding("Text", ds, "admin.name"));
            label45.DataBindings.Add(new Binding("Text", ds, "admin.l_name"));
            label46.DataBindings.Add(new Binding("Text", ds, "admin.id"));
            label47.DataBindings.Add(new Binding("Text", ds, "admin.password"));
            textBox3.ReadOnly = true;
            
            textBox3.BackColor = Color.Silver;
            
            textBox7.ReadOnly = true;
            this.tabPage1.BindingContext[ds, "admin"].Position = nrow;

            int count = this.tabPage1.BindingContext[ds, "admin"].Count;
            textBox7.Text = "      تعداد مدیران     =    " + count + "           تعداد اعضاء    =    " + ds1.Tables["user"].Rows.Count + "\r\n \r\n      تعداد کتب        =    " + ds1.Tables["book"].Rows.Count;

            if (ds.Tables["admin"].Rows.Count > 0)
                label7.Text = ds.Tables["admin"].Rows[nrow].ItemArray.GetValue(3).ToString() + " " + ds.Tables["admin"].Rows[nrow].ItemArray.GetValue(4).ToString();
            else
                label7.Text = " مدیر ثبت نشده است ";

            /*==========tapbox2=======================================================*/
            count = this.tabPage1.BindingContext[ds1, "user"].Count;
            if (count > 0)
                textBox8.Text = Convert.ToString(identity_users + 1);// Convert.ToString(Convert.ToInt16(ds1.Tables["user"].Rows[count - 1].ItemArray.GetValue(0)) + 1);
            else
                textBox8.Text = "2000";

            con.Close();
            

        }

        private void textboxdisact()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }
        private void textboxact()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            Form log = new Form1();
            admin.ActiveForm.Hide();
            log.Show(this);
            


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    

        private void button3_Click(object sender, EventArgs e)
        {
            if (newrows == true)
            {

            
                
                
                    label9.Text = "";
                string save = Convert.ToString(textBox6.Text);
                if (save == textBox5.Text)
               {
                    dr["nrow"] = this.tabPage1.BindingContext[ds, "admin"].Count;
                    dr["password"] = Convert.ToString(textBox6.Text);
                    dr["name"] = Convert.ToString(textBox1.Text);
                    dr["l_name"] = Convert.ToString(textBox2.Text);
                    ds.Tables["admin"].Rows.Add(dr);
                    con.Open();
                    scb = new SqlCommandBuilder(da);
                    da = scb.DataAdapter;
                    da.Update(ds, "admin");
                    ds.Tables["admin"].Clear();
                    da.Fill(ds, "admin");
                    con.Close();

                    admin.ActiveForm.Refresh();
                    

                    int count = this.tabPage1.BindingContext[ds, "admin"].Count;
                    this.tabPage1.BindingContext[ds, "admin"].Position = (count - 1);

                    button4.Enabled = true;
                    nrowbut = false;

                    if (ds.Tables["admin"].Rows.Count > 0)
                    {

                        label46.Text = Convert.ToString(identity_admins); //Convert.ToInt16(ds.Tables["admin"].Rows[count-2].ItemArray.GetValue(1))+1);
                        

                    }
                     else
                    {
                        if(identity_admins==1001)
                        label46.Text = "1000"; 
                        else
                        label46.Text = Convert.ToString(identity_admins);

                    }
                   

                    if (textboxactb == false)
                    {
                        textboxdisact();
                        textboxactb = true;
                    }

                    newrows = false;
                }
                else
                {
                    label9.Text = "رمز وارد شده اشتباه است ، دوباره با دقت وارد کنید";
                }


                
                 textBox7.Text = "      تعداد مدیران     =    " + this.tabPage1.BindingContext[ds, "admin"].Count + "           تعداد اعضاء    =    " + ds1.Tables["user"].Rows.Count + "\r\n \r\n      تعداد کتب        =    " + ds1.Tables["book"].Rows.Count;



                admin.ActiveForm.Refresh();
                
            }
            else
            {






                if(textBox1.Text!="")
                label44.Text = textBox1.Text;
                if (textBox2.Text != "")
                label45.Text = textBox2.Text;
                
                string save = Convert.ToString(textBox6.Text);
                if (save == textBox5.Text)
                {

                    if (textBox6.Text != "")
                    label47.Text = textBox6.Text;
                    admin.ActiveForm.Refresh();

                    this.tabPage1.BindingContext[ds, "admin"].Position = this.tabPage1.BindingContext[ds, "admin"].Position;// this.tabPage1.BindingContext[ds, "admin"].Count-1;
                    con.Open();

                    scb = new SqlCommandBuilder(da);
                    da = scb.DataAdapter;
                    da.Update(ds, "admin");
                    con.Close();
                    if (textboxactb == false)
                    {
                        textboxdisact();
                        textboxactb = true;
                    }
                    button4.Enabled = true;
                    nrowbut = false;
                    
                }
                else
                                    
                {
                    label9.Text = "رمز وارد شده اشتباه است ، دوباره با دقت وارد کنید";
                }
                

                

            }
            


        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin.ActiveForm.Refresh();
            if (this.tabPage1.BindingContext[ds, "admin"].Position>0)
            this.tabPage1.BindingContext[ds, "admin"].Position -=1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            admin.ActiveForm.Refresh();
            int count=this.tabPage1.BindingContext[ds, "admin"].Count;
            int pos=this.tabPage1.BindingContext[ds, "admin"].Position;
            if (count > pos)
                
                this.tabPage1.BindingContext[ds, "admin"].Position +=1;
          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textboxactb)
            {
                textboxact();
                textboxactb = false;
            }
            dr = ds.Tables["admin"].NewRow();
                                            
            int count = this.tabPage1.BindingContext[ds, "admin"].Count;
            this.tabPage1.BindingContext[ds, "admin"].Position=count-1;
         
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label8.Text = "نام و نام خانوادگی و رمز عبور جدید را برای مدیر جدید وارد نمایید";

            if (count > 0)
            {

                textBox3.Text = Convert.ToString(identity_admins + 1); // Convert.ToInt16(ds.Tables["admin"].Rows[count-1].ItemArray.GetValue(1)) + 1);
                identity_admins += 1;
            }
            else
            {
                if (identity_admins == 1000)
                    textBox3.Text = "1000";
                else
                {
                    textBox3.Text = Convert.ToString(identity_admins + 1);
                    identity_admins += 1;
                }
            } 
           
         //   label9.Text = "";
            newrows = true;

            nrowbut = true;
            button4.Enabled = false;
            button3.Select();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (label46.Text != ""&&label46.Text!="موجود نیست")
            {
                if (label46.Text != id.ToString())
                {
                    string sqldel = "delete from admins where id= " + label46.Text;
                    string sqlnrow = "update admins set nrow=nrow-1 where id>" + label46.Text;
                    con.Open();
                    sqc = new SqlCommand(sqlnrow, con);
                    sqc.ExecuteNonQuery();
                    sqcd = new SqlCommand(sqldel, con);
                    sqcd.ExecuteNonQuery();
                    ds.Clear();
                    ds.Tables["admin"].Clear();
                    da.Fill(ds, "admin");
                    con.Close();

                    int count = this.tabPage1.BindingContext[ds, "admin"].Count;
                    textBox7.Text = "      تعداد مدیران     =    " + count + "           تعداد اعضاء    =    " + ds1.Tables["user"].Rows.Count + "\r\n \r\n      تعداد کتب        =    " + ds1.Tables["book"].Rows.Count;

                    admin.ActiveForm.Refresh();
                    this.tabPage1.BindingContext[ds, "admin"].Position = (this.tabPage1.BindingContext[ds, "admin"].Count) - 1;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                
                textBox16.Text = op.SafeFileName;
                pictureBox1.ImageLocation = op.FileName;
            }  
        }

        private void button10_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = im;
            if (sabt)
                button9.Enabled = true;
            
            label27.Text = "";
            //textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            
            int count = this.tabPage1.BindingContext[ds1, "user"].Count;
            if (count > 0)
                textBox8.Text = Convert.ToString( Convert.ToInt16(ds1.Tables["user"].Rows[count - 1].ItemArray.GetValue(0)) + 1);
            else
                textBox8.Text = "2000";
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                label26.Text = "فقط از اعداد 0 تا 9 استفاده شود ";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";

        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";

        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";

        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";

        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            label26.Text = " ";
        }


        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }



        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "" && textBox12.Text != "" && textBox14.Text != "")
            {
                if ((comboBox1.Text == "سال") || (comboBox2.Text == "ماه") || (comboBox3.Text == "روز"))
                { comboBox1.Text = ""; comboBox2.Text = ""; comboBox3.Text = ""; }
                if ((comboBox7.Text == "سال") || (comboBox6.Text == "ماه") || (comboBox5.Text == "روز"))
                { comboBox7.Text = ""; comboBox6.Text = ""; comboBox5.Text = ""; }

                
                string sex = "";
                if (radioButton1.Checked)
                    sex = "مرد";
                else
                    sex = "زن";

                System.IO.MemoryStream userpic = new System.IO.MemoryStream();
                pictureBox1.Image.Save(userpic, pictureBox1.Image.RawFormat);
                byte[] imgu = userpic.GetBuffer();

                string user_sql = "insert into users(" + "name," + "l_name," + "f_name," + "sex," + "d_year," + "d_mouth," + "d_day," + "sh_m," + "address," + "num_t," + "num_m," + "educate," + "dyearn," + "dmouthn," + "ddayn," + "image," + "active"+")values(N'" + textBox9.Text + "',N'" + textBox10.Text + "',N'" + textBox11.Text + "',N'" + sex + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "',N'" + textBox12.Text + "',N'" + textBox15.Text + "','" + textBox13.Text + "','" + textBox14.Text + "',N'" + comboBox4.SelectedItem + "','" + comboBox7.Text + "','" + comboBox6.Text + "','" + comboBox5.Text + "',@pic,N'فعال')";
                con.Open();
                SqlCommand user_in = new SqlCommand(user_sql, con);
                user_in.Parameters.AddWithValue("@Pic", imgu);
                user_in.ExecuteNonQuery();
                user_sql = "select name,l_name,id_user,image from users where name=N'"+textBox9.Text+"'and l_name=N'"+textBox10.Text+"'";
                da1 = new SqlDataAdapter(user_sql, con);
                da1.Fill(ds1, "userr");
                user_sql = "select id_user from users";
                da1 = new SqlDataAdapter(user_sql, con);
                ds1.Tables["user"].Clear();
                da1.Fill(ds1, "user");
                con.Close();
                sabt = true;
                button9.Enabled = false;
                
                label27.Text = ds1.Tables["userr"].Rows[0].ItemArray.GetValue(0).ToString() + " " + ds1.Tables["userr"].Rows[0].ItemArray.GetValue(1).ToString() + " اکنون به عنوان عضو جدید ذخیره شد  ";
                ds1.Tables["userr"].Clear();

                int count = this.tabPage1.BindingContext[ds, "admin"].Count;
                textBox7.Text = "      تعداد مدیران     =    " + count + "           تعداد اعضاء    =    " + ds1.Tables["user"].Rows.Count + "\r\n \r\n      تعداد کتب        =    " + ds1.Tables["book"].Rows.Count;


            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            imbook = pictureBox2.Image;
            im = pictureBox1.Image;



            string strbook = "select IDENT_CURRENT( 'books' )";
            con.Open();
            sqcbook = new SqlCommand(strbook, con);
            identity_book = Convert.ToInt32(sqcbook.ExecuteScalar());
            con.Close();

            if (identity_book > 20000)
            {
                textBox23.Text = (identity_book + 1).ToString();
            }
            else
            {
                textBox23.Text = "20000";
            }
            
              
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox18.Text != "" && comboBox8.Text != "")
            {

                string inbook = "insert into books(" + "isbn," + "name_book," + "nev_book," + "mot_book," + "num_chap," + "entesharat," + "mozo," + "tozih," + "kh_book," + "address_book," + "image_book," + "present" + ")values(N'" + textBox17.Text + "',N'" + textBox18.Text + "',N'" + textBox19.Text + "',N'" + textBox20.Text + "',N'" + textBox21.Text + "',N'" + textBox22.Text + "',N'" + comboBox8.SelectedItem + "',N'" + textBox26.Text + "',N'" + textBox25.Text + "',N'" + textBox24.Text + "',@picbook,'')";
                System.IO.MemoryStream bookpic = new System.IO.MemoryStream();
                pictureBox2.Image.Save(bookpic, pictureBox2.Image.RawFormat);
                byte[] img = bookpic.GetBuffer();
                con.Open();
                sqcbook = new SqlCommand(inbook, con);
                sqcbook.Parameters.AddWithValue("@Picbook", img);
                sqcbook.ExecuteNonQuery();

                inbook = "select id_book from books";
                da1 = new SqlDataAdapter(inbook, con);
                ds1.Tables["book"].Clear();
                da1.Fill(ds1, "book");

                inbook = "select name_book from books where name_book=N'" + textBox18.Text + "'";
                da2 = new SqlDataAdapter(inbook, con);
                da2.Fill(ds2, "downbook");
                con.Close();
                label42.Text =  "  کتاب  " + ds2.Tables[0].Rows[0].ItemArray.GetValue(0).ToString() + " اکنون در لیست کتاب ها ذخیره شد ";
                ds2.Tables[0].Clear();
                sabtbook = true;
                button12.Enabled = false;

                int count = this.tabPage1.BindingContext[ds, "admin"].Count;
                textBox7.Text = "      تعداد مدیران     =    " + count + "           تعداد اعضاء    =    " + ds1.Tables["user"].Rows.Count + "\r\n \r\n      تعداد کتب        =    " + ds1.Tables["book"].Rows.Count;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string strbook = "select IDENT_CURRENT( 'books' )";
            con.Open();
            sqcbook = new SqlCommand(strbook, con);
            identity_book = Convert.ToInt32(sqcbook.ExecuteScalar());
            con.Close();

            textBox23.Text = (identity_book + 1).ToString();
            sabtbook = false;
            button12.Enabled = true;
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
          //  textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
          //  comboBox8.SelectedText="";
            pictureBox2.Image = imbook;
            
            label42.Text = "";


        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                
                textBox27.Text = op.SafeFileName;
                pictureBox2.ImageLocation = op.FileName;
            }  
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                label43.Text = "فقط از اعداد 0 تا 9 استفاده شود ";
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            label43.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textboxactb)
            {
                textboxact();
                textboxactb = false;
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            button4.Enabled = false;
            nrowbut = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            label27.Text = "";
            label42.Text = "";
            con.Open();
            /*==========request=======================================================*/
            string strsql = "select * from request";
            da4 = new SqlDataAdapter(strsql, con);
            ds3 = new DataSet();
            da4.Fill(ds3, "req");

            dataGridView1.DataSource = ds3.Tables["req"];
          //  ds3.Tables["req"].Clear();
            //===============امانات===========================================//
            string amanatst = "select * from amanat  ";// id_book.books,name_book.books,id_user.users,name.users,l_name.users,pm.users From users,books where present.books = id_user.users";
            
            SqlDataAdapter amanatda = new SqlDataAdapter(amanatst, con);
            ds4_amanat = new DataSet();
            amanatda.Fill(ds4_amanat, "amanat");
            dataGridView2.DataSource = ds4_amanat.Tables["amanat"];
          //  ds4_amanat.Tables["amanat"].Clear();
            con.Close();

        }

        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form users = new users(library);
            users.Show(this);
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form books = new books(library);
            books.Show(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "اطلاعات کتاب")
            {
                Form book = new book(Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value), 0, "", false, library);
                book.Show();
            }
            else if (dataGridView1.CurrentCell.Value.ToString() == "اطلاعات کاربر")
            {
                Form user = new user(Convert.ToInt16(dataGridView1.CurrentRow.Cells[6].Value), library);
                user.Show();
            }
            else if (dataGridView1.CurrentCell.Value.ToString() == "تایید درخواست")
            {

                string reqstr="select book1,book2 from users where id_user='"+dataGridView1.CurrentRow.Cells[6].Value.ToString()+"'";
                con.Open();
                SqlDataAdapter reqda=new SqlDataAdapter(reqstr,con);
                DataSet dsreq=new DataSet();
                reqda.Fill(dsreq,"req");
                if(dsreq.Tables["req"].Rows[0].ItemArray.GetValue(0).ToString()=="")
                    reqstr = "UPDATE users SET   savabegh =N'" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'+ savabegh,  book1= N'" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "', name_book1=N'" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' where id_user=N'" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "'";
                else if(dsreq.Tables["req"].Rows[0].ItemArray.GetValue(1).ToString()=="")
                    reqstr = "UPDATE users SET   savabegh =N'" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'+ savabegh,  book2= N'" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "', name_book2=N'" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' where id_user=N'" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "'";
                SqlCommand reqcom = new SqlCommand(reqstr,con);
                reqcom.ExecuteNonQuery();
                reqstr="delete from request where id_book='"+dataGridView1.CurrentRow.Cells[4].Value.ToString()+"'";
                reqcom = new SqlCommand(reqstr,con);
                reqcom.ExecuteNonQuery();
                reqstr = "update books set rezerv=NULL , present='" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "' where rezerv = N'" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "'and id_book= N'" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'";
                reqcom = new SqlCommand(reqstr,con);
                reqcom.ExecuteNonQuery();
                libraryDataSet4.request.Clear();
                ds3.Tables["req"].Clear();
                string strsql = "select * from request";
                da4 = new SqlDataAdapter(strsql, con);
                da4.Fill(ds3, "req");
                dataGridView1.DataSource = ds3.Tables["req"];
                con.Close();
             }
            else if(dataGridView1.CurrentCell.Value.ToString() == "لغو")
            {
                con.Open();
                string reqstr = "delete from request where id_user='" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "'";
                SqlCommand reqcom = new SqlCommand(reqstr, con);
                reqcom.ExecuteNonQuery();
                reqstr = "update books set rezerv='' , present='' ";
                reqcom = new SqlCommand(reqstr, con);
                reqcom.ExecuteNonQuery();
                
                libraryDataSet4.request.Clear();
                ds3.Tables["req"].Clear();
                string strsql = "select * from request";
                da4 = new SqlDataAdapter(strsql, con);
                da4.Fill(ds3, "req");
                dataGridView1.DataSource = ds3.Tables["req"];
                con.Close();
            }
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.Value.ToString() == "مشخصات کتاب")
            {
                Form book = new book(Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value), 0, "", false,library);
                book.Show();
            }
            else if (dataGridView2.CurrentCell.Value.ToString() == "مشخصات کاربر")
            {
                Form user = new user(Convert.ToInt16(dataGridView2.CurrentRow.Cells[2].Value),library);
                user.Show();
            }
            else if (dataGridView2.CurrentCell.Value.ToString() == "بازگشت کتاب")
            {
                 DialogResult result;
                result = FMessegeBox.FarsiMessegeBox.Show(" آیا بازگشت کتاب را تایید میکنید ؟  ", "   بازگشت کتاب  ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question, FMessegeBox.FMessegeBoxDefaultButton.button2);

                if (result == DialogResult.Yes)
                {
                    con.Open();
                    string amanate = "UPDATE books set present=NULL where id_book='"+ dataGridView2.CurrentRow.Cells[0].Value.ToString()+"'";
                    SqlCommand amanat = new SqlCommand(amanate,con);
                    amanat.ExecuteNonQuery();
                    amanate = "UPDATE users set book1=NULL, name_book1=NULL,pm=NULL  where book1='"+dataGridView2.CurrentRow.Cells[0].Value.ToString()+"'";
                    amanat = new SqlCommand(amanate,con);
                    amanat.ExecuteNonQuery();
                    amanate = "UPDATE users set book2=NULL, name_book2=NULL,pm=NULL  where book2='"+dataGridView2.CurrentRow.Cells[0].Value.ToString()+"'";
                    amanat = new SqlCommand(amanate,con);
                    amanat.ExecuteNonQuery();
                    string amanatst = "select * from amanat  ";// id_book.books,name_book.books,id_user.users,name.users,l_name.users,pm.users From users,books where present.books = id_user.users";
                    //con.Open();
                    libraryDataSet_amanat.amanat.Clear();
                    ds4_amanat.Tables["amanat"].Clear();
                    SqlDataAdapter amanatda = new SqlDataAdapter(amanatst, con);
                    amanatda.Fill(ds4_amanat, "amanat");
                    dataGridView2.DataSource = ds4_amanat.Tables["amanat"];
                    con.Close();



                   
                }
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            
            if (dataGridView2.RowCount!=0)
            {
                con.Open();
                string amanate = "UPDATE users set pm = N'" + textBox4.Text + "' where id_user= '" + dataGridView2.CurrentRow.Cells[2].Value.ToString() + "'";
                SqlCommand amanat = new SqlCommand(amanate, con);
                amanat.ExecuteNonQuery();
                string amanatst = "select * from amanat  ";
                libraryDataSet_amanat.amanat.Clear();
                ds4_amanat.Tables["amanat"].Clear();
                SqlDataAdapter amanatda = new SqlDataAdapter(amanatst, con);
                amanatda.Fill(ds4_amanat, "amanat");
                dataGridView2.DataSource = ds4_amanat.Tables["amanat"];
                con.Close();
            }
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount != 0)
            {
                textBox4.Text = "";
                con.Open();
                string amanate = "UPDATE users set pm = N'" + textBox4.Text + "' where id_user= '" + dataGridView2.CurrentRow.Cells[2].Value.ToString() + "'";
                SqlCommand amanat = new SqlCommand(amanate, con);
                amanat.ExecuteNonQuery();
                string amanatst = "select * from amanat  ";
                libraryDataSet_amanat.amanat.Clear();
                ds4_amanat.Tables["amanat"].Clear();
                SqlDataAdapter amanatda = new SqlDataAdapter(amanatst, con);
                amanatda.Fill(ds4_amanat, "amanat");
                dataGridView2.DataSource = ds4_amanat.Tables["amanat"];
                con.Close();
                textBox4.Text = ": پیام مدیریت";
            }

        }

        private void glassButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text != "")
            {
                
                string search_str = "select * from amanat where name LIKE N'%" + textBox28.Text + "%' or l_name LIKE N'%" + textBox28.Text + "%'or id_book LIKE N'%" + textBox28.Text + "%'or id_user LIKE N'%" + textBox28.Text + "%'or name_book LIKE N'%" + textBox28.Text + "%' ";
                con.Open();
                SqlDataAdapter amanatda = new SqlDataAdapter(search_str, con);
               
                libraryDataSet_amanat.amanat.Clear();
                ds4_amanat.Tables["amanat"].Clear();
                
                amanatda.Fill(ds4_amanat, "amanat");
                dataGridView2.DataSource = ds4_amanat.Tables["amanat"];
                con.Close();
            }
            else
            {
                con.Open();
                string amanatst = "select * from amanat  ";
                libraryDataSet_amanat.amanat.Clear();
                ds4_amanat.Tables["amanat"].Clear();
                SqlDataAdapter amanatda = new SqlDataAdapter(amanatst, con);
                amanatda.Fill(ds4_amanat, "amanat");
                dataGridView2.DataSource = ds4_amanat.Tables["amanat"];
                con.Close();
            }
        }

        private void textBox28_Click(object sender, EventArgs e)
        {
            textBox28.Text = "";
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if(textBox30.Text=="110")
            {
                textBox30.Text = "";
                textBox30.Enabled = false;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
            
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult result;
                result = FMessegeBox.FarsiMessegeBox.Show(" آیا لیست درخواست ها پاک شوند ؟  ", "   نوسازی  ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question, FMessegeBox.FMessegeBoxDefaultButton.button2);

                if (result == DialogResult.Yes)
                {

                      string req = "truncate table request";
                      con.Open();
                      SqlCommand q = new SqlCommand(req, con);
                      q.ExecuteNonQuery();
                      con.Close();
                      button17.Enabled = false;
                      button18.Enabled = false;
                      button19.Enabled = false;
                      button20.Enabled = false;
                      textBox30.Enabled = true;
                }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = FMessegeBox.FarsiMessegeBox.Show(" آیا لیست اعضا پاک شوند ؟  ", "   نوسازی  ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question, FMessegeBox.FMessegeBoxDefaultButton.button2);

            if (result == DialogResult.Yes)
            {

                string req = "truncate table users";
                con.Open();
                SqlCommand q = new SqlCommand(req, con);
                q.ExecuteNonQuery();
                con.Close();
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                textBox30.Enabled = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = FMessegeBox.FarsiMessegeBox.Show(" آیا لیست کتاب ها پاک شوند ؟  ", "   نوسازی  ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question, FMessegeBox.FMessegeBoxDefaultButton.button2);

            if (result == DialogResult.Yes)
            {

                string req = "truncate table books";
                con.Open();
                SqlCommand q = new SqlCommand(req, con);
                q.ExecuteNonQuery();
                con.Close();
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                textBox30.Enabled = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = FMessegeBox.FarsiMessegeBox.Show(" آیا لیست مدیران پاک شوند ؟  ", "   نوسازی  ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question, FMessegeBox.FMessegeBoxDefaultButton.button2);

            if (result == DialogResult.Yes)
            {

                string req = "truncate table admins";
                con.Open();
                SqlCommand q = new SqlCommand(req, con);
                q.ExecuteNonQuery();
                con.Close();
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                textBox30.Enabled = true;
            }
        }

    }
}
