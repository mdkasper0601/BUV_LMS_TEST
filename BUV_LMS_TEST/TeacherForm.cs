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
        string connectionString = "Data Source=DESKTOP-I5RPD40; Initial Catalog=BUV_LMS_TEST4; Integrated Security=True";//dòng này là db trong Desktop của Đức nhớ đổi mới dùng được 
        SqlConnection cn;

        string teacherID;

        public TeacherForm()
        {
            InitializeComponent();
        }

        public TeacherForm(string id)
        {
            InitializeComponent();
            teacherID = id;
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
