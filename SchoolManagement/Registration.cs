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

namespace SchoolManagement
{
    public partial class Registration : Form
    {
        String connectionString = "Server=ARYASHAJI\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("StudentRegister", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", txtName.Text);
            
            command.Parameters.AddWithValue("Malayalam", txtMalayalam.Text);
            command.Parameters.AddWithValue("English", txtEnglish.Text);
            command.Parameters.AddWithValue("Maths", txtMaths.Text);

            command.Parameters.AddWithValue("Username", txtUser.Text);
            command.Parameters.AddWithValue("Password", txtPass.Text);

            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Account Successfully created");
            StudentLogin obj = new StudentLogin();
            obj.Show();
            this.Hide();
            txtName.Text = txtUser.Text = txtPass.Text =  txtEnglish.Text = txtMaths.Text = txtMalayalam.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
    }

