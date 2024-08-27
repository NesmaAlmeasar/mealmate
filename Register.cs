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

       

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        
        }

        private void labeltitle_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (textBoxphone.Text == "")
            {
                MessageBox.Show("يرجى ادخال جميع البيانات ");

            }
            else if(password.Text != confPassword.Text)
            {
                MessageBox.Show("كلمة المرور غيرمطابقة  ");

            }
            else
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
                        conn.Close();
                        textBoxphone.Clear();
                        FirstName.Clear();
                        LastName.Clear();
                        email.Clear();
                        password.Clear();
                        confPassword.Clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء إنشاء الحساب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            }

     

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void Register_Load(object sender, EventArgs e)
        {
            FirstName.Focus();
        }

        private void confPassword_TextChanged(object sender, EventArgs e)
        {
             if (password.Text != confPassword.Text)
            {
                confPassword.BackColor = Color.Red;
            }
        }
    }
}
