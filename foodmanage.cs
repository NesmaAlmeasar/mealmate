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
    public partial class foodmanage : UserControl
    {

        addfood addfoodform = new addfood();
        public foodmanage()
        {
            InitializeComponent();
        }


          void display()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True");
            conn.Open();

            string query = "SELECT * FROM Meals ";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            conn.Close();
        }

        private void foodmanage_Load(object sender, EventArgs e)
        {
            display();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addfoodform.state = 0;

            addfoodform.Show();


        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("هل انت متأكد انك تريد الحذف ","تأكيد الحذف  ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int mealId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["MealID"].Value);

                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True"))
                    {
                        conn.Open();
                        string query = "DELETE FROM Meals WHERE MealID = @MealID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MealID", mealId);
                        cmd.ExecuteNonQuery();
                    }

                    // إعادة تحميل البيانات
                    display();  
                    MessageBox.Show("تم حذف الوجبة بنجاح!");
                    display();
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار وجبة لحذفها.");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //    addfoodform.state = Convert.ToInt32(dataGridView1.CurrentRow.Cells["0"]);
                addfoodform.state = 1;
                addfoodform.txtMealID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                addfoodform.txtMealID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                addfoodform.txtMealName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                addfoodform.txtDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                addfoodform.txtMealPce.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                addfoodform.cboCategory.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value;
                addfoodform.txtPhoto.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                addfoodform.Show();
            }
            else
            {
                MessageBox.Show("يرجى اختيار وجبة ");
            }
            display();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  
        }
    }
}
