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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        
        }

        private void labeltitle_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            int UserID =int.Parse(textBoxphone.Text);
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string Email = email.Text;
            string Password = password.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True");
            conn.Open();

            string query = "INSERT INTO Users (UserID, FirstName, LastName, Email, Password) VALUES (@UserID,@FirstName, @LastName, @Email, @Password)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Password", Password);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("تم إنشاء الحساب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء إنشاء الحساب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }

        private void passwordlable_Click(object sender, EventArgs e)
        {

        }

        private void emaillabel_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
