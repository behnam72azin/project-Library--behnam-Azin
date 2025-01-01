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
    public partial class users : Form
    {
        public string library = "";
        public users(string lib)
        {
            InitializeComponent();
            library = lib;
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

          SqlConnection con=new SqlConnection();
          string strcon;

        private void users_Load_1(object sender, EventArgs e)
        {


             strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + library + ";Integrated Security=True;Connect Timeout=30";
             con = new SqlConnection(strcon);
            // TODO: This line of code loads data into the 'libraryDataSet.users' table. You can move, or remove it, as needed.
            
          //  usersTableAdapter.Fill(libraryDataSet.users);
            dataGridView1.AutoGenerateColumns = false;
               if (this.Owner != null)
               this.Owner.Enabled = false;

            SqlDataAdapter users_dataadapter = new SqlDataAdapter("select active,id_user,name, l_name, f_name, sex, d_day,d_mouth, d_year, sh_m, address,num_t, num_m, educate,ddayn, dmouthn,dyearn,book1,book2 FROM users", con);
            libraryDataSet.users.Clear();
            DataSet users_dataset = new DataSet();
            users_dataadapter.Fill(users_dataset, "users");
            dataGridView1.DataSource = users_dataset.Tables["users"];
            con.Close();
            dataGridView1.Update();
            dataGridView1.Refresh();
            
            
        }

        private void users_FormClosed(object sender, FormClosedEventArgs e)
        {
           if (this.Owner != null)
           this.Owner.Enabled = true; 
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if(dataGridView1.CurrentCell.Value.ToString().Trim()=="حذف")
            {
                string name = dataGridView1.CurrentRow.Cells[4].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                
              if(dataGridView1.CurrentRow.Cells[20].Value.ToString()!=""||dataGridView1.CurrentRow.Cells[20].Value.ToString()!="")
              {
                  FMessegeBox.FarsiMessegeBox.Show("کاربر مورد نظر کتاب به امانت دارد ، تا بازگشت کتاب امکان حذف وی وجود ندارد", "اخطار", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Exclamtion, FMessegeBox.FMessegeBoxDefaultButton.button1);
              }
              else
              {
                
                DialogResult result;
                result = FMessegeBox.FarsiMessegeBox.Show("   آیا " + name + " حذف شود ؟   ", "   حذف کاربر  ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question, FMessegeBox.FMessegeBoxDefaultButton.button2);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.AllowUserToDeleteRows = true;
                    dataGridView1.ReadOnly = false;
                    con = new SqlConnection(strcon);
                    SqlCommand delcom = new SqlCommand();


                    string id_users = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string del = "DELETE FROM users WHERE id_user =" + id_users;
                    con.Open();
                    delcom.CommandText = del;
                    delcom.Connection = con;
                    delcom.ExecuteNonQuery();
                    SqlDataAdapter users_dataadapter = new SqlDataAdapter("select id_user,name, l_name, f_name, sex, d_day,d_mouth, d_year, sh_m, address,num_t, num_m, educate,ddayn, dmouthn,dyearn,active,book1,book2 FROM users", con);
                    libraryDataSet.users.Clear();
                    DataSet users_dataset = new DataSet();
                    users_dataadapter.Fill(users_dataset, "users");
                    dataGridView1.DataSource = users_dataset.Tables["users"];
                    con.Close();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    
                }
              }
            }

            else if (dataGridView1.CurrentCell.Value.ToString().Trim() == "ثبت تغییرات")
            {
                string namems = dataGridView1.CurrentRow.Cells[4].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[5].Value.ToString();

                string name = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                string l_name = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                string f_name = dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
                string sex = dataGridView1[10, dataGridView1.CurrentRow.Index].Value.ToString();
                string sh_m = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                string address = dataGridView1[14, dataGridView1.CurrentRow.Index].Value.ToString();
                string num_t = dataGridView1[15, dataGridView1.CurrentRow.Index].Value.ToString();
                string num_m = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
                string educate = dataGridView1[16, dataGridView1.CurrentRow.Index].Value.ToString();
                string active = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                DialogResult result;
                result = FMessegeBox.FarsiMessegeBox.Show("   آیا تغییرات " + namems + " اعمال شود ؟   ", "   ویرایش اطلاعات کاربر  ", FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Information, FMessegeBox.FMessegeBoxDefaultButton.button2);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.ReadOnly = false;
                    con = new SqlConnection(strcon);
                    SqlCommand editcom = new SqlCommand();


                    string id_users = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string edit = "Update users set name=N'"+name+"',l_name=N'"+l_name+"',f_name=N'"+f_name+"',sex=N'"+sex+"',sh_m=N'"+sh_m+"',address=N'"+address+"',num_t=N'"+num_t+"',num_m=N'"+num_m+"',educate=N'"+educate+"',active=N'"+active+"' WHERE id_user="+id_users;
                    con.Open();
                    editcom.CommandText = edit;
                    editcom.Connection = con;
                    editcom.ExecuteNonQuery();
                    SqlDataAdapter users_dataadapter = new SqlDataAdapter("select id_user,name, l_name, f_name, sex, d_day,d_mouth, d_year, sh_m, address,num_t, num_m, educate,ddayn, dmouthn,dyearn,active,book1,book2 FROM users", con);
                    libraryDataSet.users.Clear();
                    DataSet users_dataset = new DataSet();
                    users_dataadapter.Fill(users_dataset, "users");
                    dataGridView1.DataSource = users_dataset.Tables["users"];
                    con.Close();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    con.Close();
                }
            }

            else if (dataGridView1.CurrentCell.Value.ToString().Trim() == "اطلاعات کامل")
            {
                Form user = new user(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),library);
                user.Show();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {


            FMessegeBox.FMessegeBoxDefaultButton.button2.ToString();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                con = new SqlConnection(strcon);
                string search_str = "select * from users where name LIKE N'%" + textBox1.Text + "%' or l_name LIKE N'%" + textBox1.Text + "%'or sh_m LIKE N'%" + textBox1.Text + "%'or id_user LIKE N'%" + textBox1.Text + "%'or num_m LIKE N'%" + textBox1.Text + "%' ";
                con.Open();
                SqlDataAdapter search = new SqlDataAdapter(search_str,con);
                    libraryDataSet.users.Clear();
                    DataSet users_dataset = new DataSet();
                    search.Fill(users_dataset, "users");
                    dataGridView1.DataSource = users_dataset.Tables["users"];
                con.Close();
            }
            else
            {
                con = new SqlConnection(strcon);
                string search_str = "select * from users";
                con.Open();
                SqlDataAdapter search = new SqlDataAdapter(search_str, con);
                libraryDataSet.users.Clear();
                DataSet users_dataset = new DataSet();
                search.Fill(users_dataset, "users");
                dataGridView1.DataSource = users_dataset.Tables["users"];
                con.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            users.ActiveForm.Close();
        }
    }
}
