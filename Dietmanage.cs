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
    public partial class Dietmanage : UserControl
    {
        public Dietmanage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dietmanage_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True");
            conn.Open();
            string query = "SELECT * FROM DietaryRestrictions";

            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            conn.Close();
        }

        private void addDiet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True");
            try
            {
                conn.Open(); 

                string query = "INSERT INTO DietaryRestrictions (RestrictionID, RestrictionName ,RestrictionDescription) " +
                               "VALUES (@RestrictionID, @RestrictionName, @RestrictionDescription)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RestrictionID", int.Parse(RestrictionID.Text));
                    cmd.Parameters.AddWithValue("@RestrictionName", RestrictionName.Text);
                    cmd.Parameters.AddWithValue("@RestrictionDescription", RestrictionDescription.Text);
                 

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("تم إضافة النظام الغذائي  بنجاح!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
            finally
            {
                conn.Close(); // التأكد من إغلاق الاتصال
            }

            groupBox1.Visible = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("هل انت متأكد انك تريد الحذف ", "تأكيد الحذف  ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int mealId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["RestrictionID"].Value);

                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EKGE4HQ;Initial Catalog=mealmate;Integrated Security=True"))
                    {
                        conn.Open();
                        string query = "DELETE FROM DietaryRestrictions WHERE RestrictionID = @RestrictionID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@RestrictionID", RestrictionID);
                        cmd.ExecuteNonQuery();
                    }

                    // إعادة تحميل البيانات
                    Dietmanage_Load(sender, e);    
                    MessageBox.Show("تم حذف النظام الغذائي  بنجاح!");
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار نظام غذائي  للحذف .");
            }
        }
    }
}
