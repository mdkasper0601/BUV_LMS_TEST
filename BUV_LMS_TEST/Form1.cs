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
using System.Security.Cryptography;

namespace BUV_LMS_TEST
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-I5RPD40; Initial Catalog=BUV_LMS_TEST4; Integrated Security=True";
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {
            // Get the size of the form
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Get the size of the panel
            int panelWidth = loginPanel.Size.Width;
            int panelHeight = loginPanel.Size.Height;

            // Calculate the new position of the panel
            int newX = (formWidth - panelWidth) / 2;
            int newY = (formHeight - panelHeight) / 2;

            // Set the new location of the panel
            loginPanel.Location = new Point(newX, newY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            tbPassword.PasswordChar = '*';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string sql_query1 = "SELECT student_id,username,password FROM Students WHERE username = @usernameS AND password = @password";
            string sql_query2 = "SELECT teacher_id,username,password FROM Teachers WHERE username = @usernameT AND password = @password";
            string IDS = "";
            string IDT = "";

            // Đoạn dưới đây để check đăng nhập vào giảng viên hay sinh viên 

            // Đoạn dưới là của sinh viên 
            using (SqlCommand command = new SqlCommand(sql_query1, cn))
            {

                command.Parameters.AddWithValue("@usernameS", tbUsername.Text.Trim());
                command.Parameters.AddWithValue("@password", tbPassword.Text);
                
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IDS = reader.GetString(0); // lấy id cúa sinh viên nếu đăng nhập vào hệ thống cho sinh viên 
                        this.Hide();
                        StudentForm studentForm = new StudentForm(); // hiện form student
                        studentForm.ShowDialog();
                    }
                }
            }


            // Đoạn dưới là của giảng viên 
            using (SqlCommand command = new SqlCommand(sql_query2, cn))
            {

                command.Parameters.AddWithValue("@usernameT", tbUsername.Text.Trim());
                command.Parameters.AddWithValue("@password", tbPassword.Text);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IDT = reader.GetString(0); // lấy id cúa giảng viên nếu đăng nhập vào hệ thống cho sinh viên 
                        this.Hide();
                        TeacherForm teacherForm = new TeacherForm(); // hiện form teacher
                        teacherForm.ShowDialog();   
                    }
                }
            }
        }
    }
}