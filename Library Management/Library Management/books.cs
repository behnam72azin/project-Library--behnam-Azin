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
    public partial class books : Form
    {
        public string library = "";
        
        public books(string lib)
        {
            InitializeComponent();
            library = lib;
        }

        private void fill()
        {
            strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename="+library+";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(strcon);
            SqlDataAdapter users_dataadapter = new SqlDataAdapter("select id_book,isbn,name_book,nev_book,mot_book,num_chap,entesharat,mozo,tozih,kh_book,address_book,present From books", con);
            libraryDataSet.users.Clear();
            DataSet users_dataset = new DataSet();
            users_dataadapter.Fill(users_dataset, "books");
            dataGridView1.DataSource = users_dataset.Tables["books"];
            con.Close();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        SqlConnection con = new SqlConnection();
        public string strcon;
        private void books_Load(object sender, EventArgs e)
        {

            fill();
            if (this.Owner != null)
                this.Owner.Enabled = false;
          
        }

        private void books_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string click = dataGridView1.CurrentCell.Value.ToString();

            if (click == "حذف کتاب")
            {
                if (dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim() == "")
                {

                    DialogResult book;
                    book = FMessegeBox.FarsiMessegeBox.Show("آیا کتاب " + dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() + " حذف شود ؟", "حذف کتاب ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question, FMessegeBox.FMessegeBoxDefaultButton.button2);

                    if (book == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand delete = new SqlCommand("delete from books where id_book='" + dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + "'", con);
                        delete.ExecuteNonQuery();
                        fill();
                    }
                }
                else
                {
                    DialogResult book;
                    book = FMessegeBox.FarsiMessegeBox.Show(" کتاب " + dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() + " به امانت گرفته شده و حذف نمی شود", "اخطار ", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Exclamtion, FMessegeBox.FMessegeBoxDefaultButton.button1);

                 }
              }
            if (click == "ثبت تغییرات")
               {
                    DialogResult book;
                    book = FMessegeBox.FarsiMessegeBox.Show("آیا ثبت تغییرات کتاب " + dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() + " اعمال شود ؟", "ویرایش مشخصات کتاب ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Information, FMessegeBox.FMessegeBoxDefaultButton.button2);

                    if (book == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand delete = new SqlCommand("update books set name_book=N'" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "',nev_book=N'" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "',mozo=N'" + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "',entesharat=N'" + dataGridView1.CurrentRow.Cells[8].Value.ToString() + "',num_chap=N'" + dataGridView1.CurrentRow.Cells[9].Value.ToString() + "',mot_book=N'" + dataGridView1.CurrentRow.Cells[10].Value.ToString() + "',tozih=N'" + dataGridView1.CurrentRow.Cells[11].Value.ToString() + "',kh_book=N'" + dataGridView1.CurrentRow.Cells[12].Value.ToString() + "',isbn=N'" + dataGridView1.CurrentRow.Cells[13].Value.ToString() + "',address_book=N'" + dataGridView1.CurrentRow.Cells[14].Value.ToString() + "' where id_book = '"+ dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'" , con);
                        delete.ExecuteNonQuery();
                        fill();
                    }
               }
            if (click == "اطلاعات کامل")
            {
                Form book = new book(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),0,null,false,library);
                book.Show(this);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                con = new SqlConnection(strcon);
                string search_str = "select * from books where name_book LIKE N'%" + textBox1.Text + "%' or nev_book LIKE N'%" + textBox1.Text + "%'or mot_book LIKE N'%" + textBox1.Text + "%'or id_book LIKE N'%" + textBox1.Text + "%'or entesharat LIKE N'%" + textBox1.Text + "%' or present LIKE N'%" + textBox1.Text + "%'";
                con.Open();
                SqlDataAdapter search = new SqlDataAdapter(search_str, con);
                libraryDataSet.users.Clear();
                DataSet users_dataset = new DataSet();
                search.Fill(users_dataset, "users");
                dataGridView1.DataSource = users_dataset.Tables["users"];
                con.Close();
            }
            else
            {
                con = new SqlConnection(strcon);
                string search_str = "select * from books";
                con.Open();
                SqlDataAdapter search = new SqlDataAdapter(search_str, con);
                libraryDataSet.users.Clear();
                DataSet users_dataset = new DataSet();
                search.Fill(users_dataset, "users");
                dataGridView1.DataSource = users_dataset.Tables["users"];
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.ActiveForm.Close();
        }
    }
}
