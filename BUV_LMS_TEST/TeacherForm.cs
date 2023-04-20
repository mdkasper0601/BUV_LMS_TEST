using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUV_LMS_TEST
{
    public partial class TeacherForm : Form
    {
<<<<<<< HEAD
        string connectionString = "Data Source=DESKTOP-I5RPD40; Initial Catalog=BUV_LMS_TEST4; Integrated Security=True";//dòng này là db trong Desktop của Đức nhớ đổi mới dùng được 
=======
        //string connectionString = "Data Source=DESKTOP-I5RPD40; Initial Catalog=BUV_LMS_TEST4; Integrated Security=True";//dòng này là db trong Desktop của Đức nhớ đổi mới dùng được 
        string connectionString = "Data Source=MINHDUC\\SQLEXPRESS; Initial Catalog=BUV_LMS_TEST4; Integrated Security=True"; //dòng này là db trong Lap của Đức cũng nhớ đổi mới dùng được
>>>>>>> 385df7398596445f856a6cacee0c832897853c5f
        SqlConnection cn;

        string teacherID;


        public TeacherForm(string id)
        {
            InitializeComponent();
            teacherID = id;
            this.Width = Screen.PrimaryScreen.Bounds.Width;   // dòng này và dòng dưới để chỉnh form luôn t
            this.Height = Screen.PrimaryScreen.Bounds.Height; // to bằng màn hình mọi máy
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            LoadTeacherName();
        }

        private void LoadTeacherName()
        {
            string sqlQuery = "SELECT lastname FROM Teachers WHERE teacher_id=@id";

            using (SqlCommand command = new SqlCommand(sqlQuery, cn))
            {
                command.Parameters.AddWithValue("@id", teacherID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string teacherName = reader.GetString(0);
                        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                        lbWelcomeT.Text += " " + textInfo.ToTitleCase(teacherName); // Hiển thị tên giáo viên lên Label
                    }
                }
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            LoadTeacherName();
        }

        private void LoadTeacherName()
        {
            string sqlQuery = "SELECT lastname FROM Teachers WHERE teacher_id=@id";

            using (SqlCommand command = new SqlCommand(sqlQuery, cn))
            {
                command.Parameters.AddWithValue("@id", teacherID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string teacherName = reader.GetString(0);
                        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                        lbWelcomeT.Text += " " + textInfo.ToTitleCase(teacherName); // Hiển thị tên giáo viên lên Label
                    }
                }
            }
        }
        private int count = 0;
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // Tạo button mới
            Button courseButton = new Button();
            courseButton.Text = "Course";
            courseButton.Location = new Point(50, 50 + count * 30);
            // Đặt tên cho button mới
            courseButton.Name = "courseButton" + count.ToString();
            Controls.Add(courseButton);

            // Xử lý sự kiện Click của button mới
            courseButton.Click += new EventHandler(courseButton_Click);

            // Tăng biến đếm
            count++;
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            // Lấy tên của button được gọi
            string buttonName = ((Button)sender).Name;
            Form form = new Form();
            this.Hide();
            form.ShowDialog();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {

        }
    }
}
