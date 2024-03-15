using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2I5MLG4;Initial Catalog=WindowsFormAppDB;Integrated Security=True");


        // Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string gender= "";
            if (radMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            List<string> selectedLang = new List<string>();
            if (checkSinhala.Checked)
            {
                selectedLang.Add("Sinhala");
            }
            if (checkEnglish.Checked)
            {
                selectedLang.Add("English");
            }
            if (checkTamil.Checked) 
            {
                selectedLang.Add("Tamil");
            }
            if (checkOther.Checked)
            {
                selectedLang.Add("Other");
            }


            string languages = String.Join(",", selectedLang);

            con.Open();
            using (SqlCommand cmd = new SqlCommand("dbo.SP_Student_Insert", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Full_name", txtName.Text);
                cmd.Parameters.AddWithValue("@Index_no", txtIndexNumber.Text);
                cmd.Parameters.AddWithValue("@Aca_year", comAcademicYear.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", calDOB.Value);
                cmd.Parameters.AddWithValue("@Language", languages);
                cmd.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("data successfullyinserted");
            LoadAllRecords();
        }

        //Read all records

        void LoadAllRecords()
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_Student_View", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            List<string> selectedLang = new List<string>();
            if (checkSinhala.Checked)
            {
                selectedLang.Add("Sinhala");
            }
            if (checkEnglish.Checked)
            {
                selectedLang.Add("English");
            }
            if (checkTamil.Checked)
            {
                selectedLang.Add("Tamil");
            }
            if (checkOther.Checked)
            {
                selectedLang.Add("Other");
            }


            string languages = String.Join(",", selectedLang);

            con.Open();
            using (SqlCommand cmd = new SqlCommand("dbo.SP_Student_Update", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Full_name", txtName.Text);
                cmd.Parameters.AddWithValue("@Index_no", txtIndexNumber.Text);
                cmd.Parameters.AddWithValue("@Aca_year", comAcademicYear.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", calDOB.Value);
                cmd.Parameters.AddWithValue("@Language", languages);
                cmd.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("data successsfully updated");
            LoadAllRecords();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            if(MessageBox.Show("Are you confirm to delete?","Delete", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SP_Student_Delete", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Index_no", txtIndexNumber.Text);
                    cmd.ExecuteNonQuery();
                }

                con.Close();

                MessageBox.Show("data successfully deleted");
                LoadAllRecords();
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            
            using (SqlCommand cmd = new SqlCommand("dbo.SP_Student_Search", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Index_no", txtSerach.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            }

            con.Close();
        }
    }
}
