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
    public partial class UserHome : Form
    {
        Student _student;
        String connectionString = "Server=ARYASHAJI\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
        public UserHome(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void lblTheme_Click(object sender, EventArgs e)
        {
            setColor(_student.Id);
        }

        private void setColor(int studentid)
        {
            colorDialog1.ShowDialog();
            this.BackColor = Color.FromArgb(colorDialog1.Color.ToArgb());
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SetColor", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", studentid);
            command.Parameters.AddWithValue("Color", colorDialog1.Color.ToArgb().ToString());
            command.ExecuteNonQuery();
            con.Close();
        }

        private void UserHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdatewindowPosition(this.Left, this.Top, _student.Id);
        }

        private void UpdatewindowPosition(int left, int top, int studentid)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = new SqlCommand("UpdateWindowPosition", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id", studentid);
            command.Parameters.AddWithValue("Left", Left);
            command.Parameters.AddWithValue("Top", Top);
            command.ExecuteNonQuery();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(_student.Color));
            this.Left = _student.Left;
            this.Top = _student.Top;
            lblMalayalam.Text = "Malayalam  :" + _student.Malayalam;
            lblEnglish.Text = "English          :" + _student.English;
            lblMaths.Text = "Maths             :" + _student.Maths;
            lblTotal.Text = "Total              :" + (_student.Malayalam + _student.English + _student.Maths);
            this.Text = lblUsername.Text = "Welcome......" + _student.Name;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            StudentLogin obj = new StudentLogin();
            obj.Show();
            this.Close();
        }
    }
}
