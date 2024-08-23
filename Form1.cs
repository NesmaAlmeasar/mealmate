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

namespace mealmate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void passwordlable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
           // this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True");
            conn.Open();

            string Email = email.Text;
            string Password = password.Text;
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Password", Password); 

              int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)
                {
                    admin adminform = new admin();
                    adminform.Show();   
                    Form1 form = new Form1();
                    form.Hide();
                }
                else
                {
                    MessageBox.Show("البريد الإلكتروني أو كلمة المرور غير صحيحة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
