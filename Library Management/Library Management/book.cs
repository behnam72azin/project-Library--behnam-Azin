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
    public partial class book : Form
    {
        public int id_book = 0,id_user=0;
        public string name = "";
        public bool book_p = false ,book_1_2=true;
        public string library = "";


        public book(int id_b, int id_u, string nam, bool book, string lib)
        {
            InitializeComponent();
            id_book = id_b;
            id_user = id_u;
            name = nam;
            book_1_2 = book;
            library = lib;

            


       }

        SqlConnection con = new SqlConnection();
        private void book_Load(object sender, EventArgs e)
        {

           // user_ui f= (user_ui)this.Owner;
         //   f.labelbook1.Text = "sdfdsf"; 

            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + library + ";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(strcon);
            SqlDataAdapter book = new SqlDataAdapter("select * From books where id_book='"+id_book.ToString()+"'", con);
            
            DataSet bookds = new DataSet();
            book.Fill(bookds, "book");
            con.Close();
            textBox12.Text = bookds.Tables["book"].Rows[0].ItemArray.GetValue(0).ToString();
            textBox3.Text  = bookds.Tables["book"].Rows[0].ItemArray.GetValue(1).ToString();
            textBox4.Text  = bookds.Tables["book"].Rows[0].ItemArray.GetValue(2).ToString();
            textBox5.Text  = bookds.Tables["book"].Rows[0].ItemArray.GetValue(3).ToString();
            textBox6.Text  = bookds.Tables["book"].Rows[0].ItemArray.GetValue(4).ToString();
            textBox7.Text  = bookds.Tables["book"].Rows[0].ItemArray.GetValue(6).ToString();
            textBox8.Text  = bookds.Tables["book"].Rows[0].ItemArray.GetValue(5).ToString();
            textBox9.Text  = bookds.Tables["book"].Rows[0].ItemArray.GetValue(7).ToString();
            textBox10.Text = bookds.Tables["book"].Rows[0].ItemArray.GetValue(10).ToString();
            if (bookds.Tables["book"].Rows[0].ItemArray.GetValue(12).ToString() != "")
            {
               
                
                    textBox11.Text = " امانت گرفته شده توسط : " + bookds.Tables["book"].Rows[0].ItemArray.GetValue(12).ToString();
                    book_p = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                
            }
            else
            {
                if (bookds.Tables["book"].Rows[0].ItemArray.GetValue(13).ToString() != "")
                {
                    textBox11.Text = "کتاب رزرو است";
                    book_p = false;
                    
                    button3.Enabled = false;
                }
                else
                {
                    textBox11.Text = "کتاب موجود است";
                    book_p = true;
                }
            }

            textBox1.Text = bookds.Tables["book"].Rows[0].ItemArray.GetValue(9).ToString();
            textBox2.Text = bookds.Tables["book"].Rows[0].ItemArray.GetValue(8).ToString();
            byte[] img = null;
            img = (byte[])(bookds.Tables["book"].Rows[0].ItemArray.GetValue(11));
            System.IO.MemoryStream bookpic = new System.IO.MemoryStream(img);
            pictureBox1.Image = Image.FromStream(bookpic);

            if (id_book == 0 || id_user == 0)
            {
                button3.Enabled = false;
                button2.Enabled = false;
            }
                
                       }



        private void button1_Click_1(object sender, EventArgs e)
        {

            book.ActiveForm.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(book_p)
            {

                if (book_1_2)
                {
                    string strinsert = "INSERT INTO request (id_book,name_book,nev_book,id_user,name,address) VALUES (N'" + id_book + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + id_user + "',N'" + name + "',N'" + textBox10.Text + "')";
                    SqlCommand com = new SqlCommand(strinsert, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    strinsert = "UPDATE books set rezerv='"+id_user+"' where id_book='" + id_book + "'";
                    string strreq = "select name_book from request where id_user='" + id_user + "'";
                    DataSet req = new DataSet();
                    SqlDataAdapter reqa = new SqlDataAdapter(strreq, con);
                    reqa.Fill(req, "reqbook");
                   //strreq = "select name_book1,name_book2 from users where id_user='" + id_user + "'";
                   //reqa = new SqlDataAdapter(strreq, con);
                   //reqa.Fill(req, "requser");
                    user_ui user_ui = (user_ui)this.Owner;
                    if(req.Tables["reqbook"].Rows.Count==1)
                    user_ui.labelbook1.Text = req.Tables["reqbook"].Rows[0].ItemArray.GetValue(0).ToString();
                    if (req.Tables["reqbook"].Rows.Count == 2)
                    {
                    user_ui.labelbook1.Text = req.Tables["reqbook"].Rows[0].ItemArray.GetValue(0).ToString();
                    user_ui.labelbook2.Text = req.Tables["reqbook"].Rows[1].ItemArray.GetValue(0).ToString();
                    }
                    com = new SqlCommand(strinsert, con);
                    com.ExecuteNonQuery();
                    con.Close();
                    textBox11.Text = "کتاب رزرو است";

                        button3.Enabled = false;
                        button2.Enabled = true;

                    FMessegeBox.FarsiMessegeBox.Show("کتاب با موفقیت رزرو شد ، برای دریافت کتاب به مدیر کتابخانه مراجعه کنید", "اعلان", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Information);
                   
                    
                    }
                else
                    FMessegeBox.FarsiMessegeBox.Show("شما مجاز به دریافت کتاب نیستید ، هم اکنون دو کتاب به امانت دارید", "اعلان", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Exclamtion);

            }
            else
                FMessegeBox.FarsiMessegeBox.Show("کتاب در کتابخانه موجود نیست", "اعلان", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Information);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strinsert = "delete from request where id_book=N'"+id_book+"' and id_user=N'"+id_user+"'";
            SqlCommand com = new SqlCommand(strinsert, con);
            con.Open();
            com.ExecuteNonQuery();
            strinsert = "UPDATE books set rezerv='' where id_book=N'" + id_book + "' and rezerv=N'"+id_user+"'";
            com = new SqlCommand(strinsert, con);
            com.ExecuteNonQuery();

            string strreq = "select name_book from request where id_user='" + id_user + "'";
            DataSet req = new DataSet();
            SqlDataAdapter reqa = new SqlDataAdapter(strreq, con);
            reqa.Fill(req, "reqbook");
            //strreq = "select name_book1,name_book2 from users where id_user='" + id_user + "'";
            //reqa = new SqlDataAdapter(strreq, con);
            //reqa.Fill(req, "requser");
            user_ui user_ui = (user_ui)this.Owner;
            if (req.Tables["reqbook"].Rows.Count == 1 && id_user!=0)
            {
                user_ui.labelbook1.Text = req.Tables["reqbook"].Rows[0].ItemArray.GetValue(0).ToString();
                user_ui.labelbook2.Text = "رزرو نشده";
            }
            else if (id_user != 0)
            {
                user_ui.labelbook1.Text = "رزرو نشده";
                user_ui.labelbook2.Text = "رزرو نشده";
            }

            con.Close();
            textBox11.Text = "کتاب موجود است";
            button3.Enabled = true;
            button2.Enabled = false;
            
            FMessegeBox.FarsiMessegeBox.Show("درخواست رزرو این کتاب لغو شد", "اعلان", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Information);

        }
    }
}
