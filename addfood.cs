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
    public partial class addfood : Form
    {

        public int state;
        public addfood()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addfood addfoodform = new addfood();
            addfoodform.Close();
        admin adminform = new admin();  
            adminform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMealName.Text == "" || txtPhoto.Text == "" || txtPhoto.Text == "" || txtMealPce.Text == "")
            {
                MessageBox.Show("عليك كتابه جميع البيانات ");
            }
            else
            {
                if (state == 0)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True");

                    try
                    {
                        conn.Open();

                        string query = "INSERT INTO Meals (MealID, MealName, Photo, Description, MealPce, CategoryID) " +
                                       "VALUES (@MealID, @MealName, @Photo, @Description, @MealPce, @CategoryID)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MealID", int.Parse(txtMealID.Text));
                            cmd.Parameters.AddWithValue("@MealName", txtMealName.Text);
                            cmd.Parameters.AddWithValue("@Photo", txtPhoto.Text); // استخدام مسار الصورة من TextBox
                            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                            cmd.Parameters.AddWithValue("@MealPce", int.Parse(txtMealPce.Text));
                            cmd.Parameters.AddWithValue("@CategoryID", ((dynamic)cboCategory.SelectedItem).Value);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("تم إضافة الوجبة بنجاح!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close(); // التأكد من إغلاق الاتصال
                    }

                    addfood addfoodform = new addfood();
                    addfoodform.Close();
                    admin adminform = new admin();
                    adminform.Show();
                } 
                else
                {
                    button2.Text = "تعديل ";
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True");

                    try
                    {
                        conn.Open();

                        string query = "UPDATE Meals " +
                        "SET " +
                            "MealName = @MealName, " +
                            "Description = @Description, " +
                            "MealPce = @MealPce, " +
                              "CategoryID = @CategoryID " +
                              "WHERE MealID = @MealID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MealID", int.Parse(txtMealID.Text));
                            cmd.Parameters.AddWithValue("@MealName", txtMealName.Text);
                            cmd.Parameters.AddWithValue("@Photo", txtPhoto.Text); // استخدام مسار الصورة من TextBox
                            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                            cmd.Parameters.AddWithValue("@MealPce", int.Parse(txtMealPce.Text));
                            cmd.Parameters.AddWithValue("@CategoryID", ((dynamic)cboCategory.SelectedItem).Value);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("تم إضافة الوجبة بنجاح!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close(); // التأكد من إغلاق الاتصال
                    }

                    addfood addfoodform = new addfood();
                    addfoodform.Close();
                    admin adminform = new admin();
                    adminform.Show();
                }
            }

            }
        

        private void addfood_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True");

            try
            {
                conn.Open();
                string query = "SELECT CategoryID, CategoryName FROM FoodCategories"; 
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cboCategory.Items.Add(new
                    {
                        Text = reader["CategoryName"].ToString(),
                        Value = reader["CategoryID"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
            finally
            {
                conn.Close(); // تأكد من إغلاق الاتصال
            }

            cboCategory.DisplayMember = "Text";
            cboCategory.ValueMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Dell\\Pictures";
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "اختيار صورة";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);
                    txtPhoto.Text = filePath; 
                }
            }
        }
    }
}
