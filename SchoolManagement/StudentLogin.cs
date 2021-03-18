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
    public partial class StudentLogin : Form
    {
        public static string formtext = "";
        String connectionString = "Server=ARYASHAJI\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
        

       

        public StudentLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Student loggndStudent = Login(txtUsername.Text, txtPassword.Text);
            if (loggndStudent != null)
            {
                UserHome homepage = new UserHome(loggndStudent);
                homepage.Show();
            }

        }

        private Student Login(string Username, string Password)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("StudentLogin", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Username", Username);
            command.Parameters.AddWithValue("Password", Password);
            MessageBox.Show("successfully login");


            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Student student = new Student();
            student.Id = Convert.ToInt32(reader["Id"]);
            student.Name = reader["Name"].ToString();
            student.Malayalam = Convert.ToInt32(reader["Malayalam"]);
            student.English = Convert.ToInt32(reader["English"]);

            student.Maths = Convert.ToInt32(reader["Maths"]);
            student.Color = reader["Color"].ToString();
            
            student.Top = Convert.ToInt32(Convert.ToInt32(reader["Top"]));
            student.Left = Convert.ToInt32(Convert.ToInt32(reader["Left"]));



            student.Username = reader["Username"].ToString();
            student.Password = reader["Password"].ToString();
           
            return student;
            

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            
            Registration obj = new Registration();
            obj.Show();
            this.Hide();
        }
    }
}
