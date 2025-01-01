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
    public partial class user_ui : Form
    {
        public string library = "";
        public int id ;
        public user_ui(int ids, string lib)
        {
            InitializeComponent();
            id = ids;
            library = lib;
        }
        SqlConnection con;
        DataSet bookd = new DataSet();
        DataSet userd = new DataSet();
        DataSet request = new DataSet();
        bool book_1_2=true;
        private void user_ui_Load(object sender, EventArgs e)
        {

            txtPro.Text = "جهت جستجو واژه مورد نظر را تایپ نمایید";
            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + library + ";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(strcon);

            SqlDataAdapter book = new SqlDataAdapter("select TOP 15 id_book,isbn,name_book,nev_book,mot_book,entesharat,mozo,tozih,kh_book From books ORDER by id_book desc" , con);
            SqlDataAdapter user = new SqlDataAdapter("select * From users where id_user='"+id+"'", con);
            SqlDataAdapter req = new SqlDataAdapter("select name_book,id_book From request where id_user='" + id + "'", con);
            con.Open();
            book.Fill(bookd,"book");
            user.Fill(userd,"user");
            req.Fill(request,"req");
            con.Close();
            if (request.Tables["req"].Rows.Count == 2)
                book_1_2 = false;
            dataGridView1.DataSource = bookd.Tables["book"];
            label2.Text =  userd.Tables["user"].Rows[0].ItemArray.GetValue(0).ToString();
            label4.Text = userd.Tables["user"].Rows[0].ItemArray.GetValue(1).ToString() + " " +  userd.Tables["user"].Rows[0].ItemArray.GetValue(2).ToString(); ;
            byte[] imgup = null;
            imgup = (byte[])(userd.Tables["user"].Rows[0].ItemArray.GetValue(16));
            System.IO.MemoryStream userpic = new System.IO.MemoryStream(imgup);
            pictureBox1.Image = Image.FromStream(userpic);


            if (userd.Tables["user"].Rows[0].ItemArray.GetValue(18).ToString() != "" && userd.Tables["user"].Rows[0].ItemArray.GetValue(18).ToString() != "")
            {
                label8.Text = "مجاز نیستید";
                book_1_2 = false;
            }
            else
                label8.Text = "مجاز هستید";

            if (userd.Tables["user"].Rows[0].ItemArray.GetValue(20).ToString()!="")
            label12.Text = userd.Tables["user"].Rows[0].ItemArray.GetValue(20).ToString();
            if (userd.Tables["user"].Rows[0].ItemArray.GetValue(21).ToString() != "")
            label14.Text = userd.Tables["user"].Rows[0].ItemArray.GetValue(21).ToString();
                //  book_1_2 = false;

           if(request.Tables["req"].Rows.Count==1)
            labelbook1.Text=request.Tables["req"].Rows[0].ItemArray.GetValue(0).ToString();
           if (request.Tables["req"].Rows.Count == 2)
            labelbook2.Text=request.Tables["req"].Rows[0].ItemArray.GetValue(0).ToString();

           if (userd.Tables["user"].Rows[0].ItemArray.GetValue(22).ToString()!="")
           textBox3.Text = userd.Tables["user"].Rows[0].ItemArray.GetValue(22).ToString();
           if (userd.Tables["user"].Rows[0].ItemArray.GetValue(23).ToString() != "")
               textBox1.Text = userd.Tables["user"].Rows[0].ItemArray.GetValue(23).ToString();
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void txtProNet1_Click(object sender, EventArgs e)
        {
            if (txtPro.Text == "جهت جستجو واژه مورد نظر را تایپ نمایید")
            txtPro.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            Form user = new user(id,library);
            user.Show(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlDataAdapter req = new SqlDataAdapter("select name_book,id_book From request where id_user='" + id + "'", con);
            con.Open();
            request.Tables["req"].Clear();
            req.Fill(request, "req");
            con.Close();
            if (request.Tables["req"].Rows.Count == 2)
                book_1_2 = false;
            Form book = new book(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value), id, label4.Text, book_1_2,library);
            book.Owner = this;
            book.Show();
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            txtPro.Text = null;
            string b_asas="name_book",mozo="";

            if (comboBox1.Text.ToString()!="")
            b_asas = comboBox1.Text.ToString();
            if (comboBox2.Text.ToString() != "")
            mozo = comboBox2.Text.ToString();

            switch(b_asas)
            {
                case "شناسه کتاب":
                    b_asas="id_book";
                    break;
                case "کد ملی کتاب،ISBN":
                    b_asas="isbn";
                    break;
                case "نام کتاب":
                    b_asas="name_book";
                    break;
                case "نام نویسنده":
                    b_asas="nev_book";
                    break;
                case "نام مترجم":
                    b_asas="mot_book";
                    break;
                case "نام انتشارات":
                    b_asas="entesharat";
                    break;
                case "توضیحات کتاب":
                    b_asas="tozih";
                    break;
                case "خلاصه کتاب":
                    b_asas="kh_book";
                    break;
             }
            con.Open();
             SqlDataAdapter book = new SqlDataAdapter("select id_book,isbn,name_book,nev_book,mot_book,entesharat,mozo,tozih,kh_book From books where "+b_asas+" LIKE N'%"+txtPro.Text+"%' and mozo LIKE N'%"+mozo+"%'",con);
             DataSet booksearch = new DataSet();
             book.Fill(booksearch, "booksearch");
             con.Close();
             libraryDataSet3.books.Clear();
             dataGridView1.DataSource = booksearch.Tables["booksearch"];
             
        }

        private void glassButton4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            txtPro.Text = "جهت جستجو واژه مورد نظر را تایپ نمایید";
            libraryDataSet3.books.Clear();
            dataGridView1.DataSource = bookd.Tables["book"];
        }

        private void labelbook1_Click(object sender, EventArgs e)
        {
            
            if (request.Tables["req"].Rows.Count == 1)
            {
                Form book = new book(Convert.ToInt16(request.Tables["req"].Rows[0].ItemArray.GetValue(1)), id, label4.Text, book_1_2,library);
                book.Show(this);

            }
        }

        private void labelbook2_Click(object sender, EventArgs e)
        {
            if (request.Tables["req"].Rows.Count == 2)
            {
                Form book = new book(Convert.ToInt16(request.Tables["req"].Rows[1].ItemArray.GetValue(1)), id, label4.Text, book_1_2,library);
                book.Show(this);
            }
        }

        private void labelbook1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter req = new SqlDataAdapter("select name_book,id_book From request where id_user='" + id + "'", con);
            con.Open();
            request.Tables["req"].Clear();
            req.Fill(request, "req");
            con.Close();
        }

        private void labelbook2_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter req = new SqlDataAdapter("select name_book,id_book From request where id_user='" + id + "'", con);
            con.Open();
            request.Tables["req"].Clear();
            req.Fill(request, "req");
            con.Close();
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            user_ui.ActiveForm.Hide();
            form.Show();
        }
    }
}
