using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mealmate
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

            dietmanage1.Visible = false;
            foodmanage1.Visible = false;
        }
        

        private void buttonhome_Click(object sender, EventArgs e)
        {
            foodmanage1.Visible = false;
            dietmanage1.Visible = false;
        }

        private void buttonfoodmang_Click(object sender, EventArgs e)
        {
          foodmanage1.Visible = true;
            dietmanage1.Visible = false;


        }

      

        private void closebutton_Click(object sender, EventArgs e)
        {
            DialogResult closeresult= MessageBox.Show("هل فعلا تريد الخروج "," تأكيد الخروج ",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);    
           if (closeresult == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

     

        private void buttondietmang_Click(object sender, EventArgs e)
        {
            dietmanage1.Visible = true;
            foodmanage1.Visible=false;
        }

        private void dietmanage1_Load(object sender, EventArgs e)
        {

        }
    }
}
