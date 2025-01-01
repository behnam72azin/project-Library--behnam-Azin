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
    public partial class user : Form
    {
        public int id_user = 0;
        public string library = "";
        public user(int id, string lib)
        {
            InitializeComponent();
            id_user = id;
            library = lib;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {
            string strcon = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + library + ";Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(strcon);
            SqlDataAdapter user = new SqlDataAdapter("select * from users where id_user='" + id_user + "'", con);

            DataSet userds = new DataSet();
            user.Fill(userds, "user");
            con.Close();

            textBox10.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(0).ToString();
            textBox2.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(1).ToString();
            textBox3.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(2).ToString();
            textBox4.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(3).ToString();
            textBox5.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(4).ToString();
            textBox6.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(7).ToString() + "/" + userds.Tables["user"].Rows[0].ItemArray.GetValue(6).ToString() + "/" + userds.Tables["user"].Rows[0].ItemArray.GetValue(5).ToString();
            textBox7.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(8).ToString();
            textBox8.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(9).ToString();
            textBox9.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(10).ToString();
            textBox1.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(11).ToString();
            textBox11.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(12).ToString();
            textBox12.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(15).ToString() + "/" + userds.Tables["user"].Rows[0].ItemArray.GetValue(14).ToString() + "/" + userds.Tables["user"].Rows[0].ItemArray.GetValue(13).ToString();
            if (userds.Tables["user"].Rows[0].ItemArray.GetValue(17).ToString() != "")
                textBox13.Text = "کاربر " + userds.Tables["user"].Rows[0].ItemArray.GetValue(17).ToString() + " هست";
            textBox14.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(18).ToString();
            textBox15.Text = userds.Tables["user"].Rows[0].ItemArray.GetValue(19).ToString();

            byte[] imgup = null;
            imgup = (byte[])(userds.Tables["user"].Rows[0].ItemArray.GetValue(16));
            System.IO.MemoryStream userpic = new System.IO.MemoryStream(imgup);
            pictureBox1.Image = Image.FromStream(userpic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.ActiveForm.Close();
        }
    }
}
