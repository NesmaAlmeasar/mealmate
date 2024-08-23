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
        public foodmanage()
        {
            InitializeComponent();
        }


        private void foodmanage_Load(object sender, EventArgs e)
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

        private void add_Click(object sender, EventArgs e)
        {
            addfood addfoodform = new addfood();
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
                    foodmanage_Load(sender, e);
                    MessageBox.Show("تم حذف الوجبة بنجاح!");
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار وجبة لحذفها.");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            addfood addfoodform = new addfood();
            addfoodform.state =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value) ;

            addfoodform.Show();
        }
    }
}
