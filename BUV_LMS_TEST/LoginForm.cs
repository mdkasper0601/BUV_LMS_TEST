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
    public partial class LoginForm : Form
    {
        //string connectionString = "Data Source=DESKTOP-I5RPD40; Initial Catalog=BUV_LMS_TEST4; Integrated Security=True";//dòng này là db trong Desktop của Đức nhớ đổi mới dùng được 
        string connectionString = "Data Source=MINHDUC\\SQLEXPRESS; Initial Catalog=BUV_LMS_TEST4; Integrated Security=True"; //dòng này là db trong Lap của Đức cũng nhớ đổi mới dùng được
        SqlConnection cn;
        public LoginForm()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width; // dòng này và dòng dưới để chỉnh form luôn t
            this.Height = Screen.PrimaryScreen.Bounds.Height;// to bằng màn hình mọi máy

            tbPassword.KeyDown += TbPassword_KeyDown; // phục vụ cho đoạn event của nút enter 
        }

        // Đoạn này để nhấn enter thì login sau khi điền tài khoảng mật khẩu 
        private void TbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(sender, e); //Gọi hàm đăng nhập tương ứng
                e.Handled = true; //Ngăn chặn việc nhập xuống hàng mới khi nhấn Enter
            }
        }

        // chỉnh panel chứa login infor vào giữa form
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

        // khi khởi tạo form thì sẽ hiện những thứ trong code này
        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(connectionString);
            cn.Open();
            tbPassword.PasswordChar = '*';
        }

        // log in 
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userID = ""; // lấy ID của người dùng đăng nhập   
            string prefix = ""; // chứa 2 ký tự đầu tiên của ID

            if (!string.IsNullOrWhiteSpace(tbUsername.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                // Lấy thông tin từ CSDL về sinh viên hoặc giảng viên tương ứng với username và password đã nhập
                string sqlQueryStudent = "SELECT student_id FROM Students WHERE username=@username AND password=@password";
                string sqlQueryTeacher = "SELECT teacher_id FROM Teachers WHERE username=@username AND password=@password";

                using (SqlCommand command = new SqlCommand(sqlQueryStudent, cn))
                {
                    command.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                    command.Parameters.AddWithValue("@password", tbPassword.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = reader.GetString(0); // Lấy ID của sinh viên từ CSDL
                            prefix = userID.Substring(0, 2); // Lấy 2 ký tự đầu tiên trong ID

                            if (prefix == "ST") // Nếu là tài khoản sinh viên
                            {
                                this.Hide();

                                StudentForm studentForm = new StudentForm(userID); // Hiển thị form Sinh viên và truyền vào ID
                                studentForm.ShowDialog();
                            }
                        }
                    }
                }

                if (string.IsNullOrEmpty(userID)) // Nếu không phải tài khoản Sinh viên
                {
                    using (SqlCommand command = new SqlCommand(sqlQueryTeacher, cn))
                    {
                        command.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                        command.Parameters.AddWithValue("@password", tbPassword.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userID = reader.GetString(0); // Lấy ID của giảng viên từ CSDL
                                prefix = userID.Substring(0, 2); // Lấy 2 ký tự đầu tiên trong ID

                                if (prefix == "TE") // Nếu là tài khoản giảng viên
                                {
                                    this.Hide();

                                    TeacherForm teacherForm = new TeacherForm(userID); // Hiển thị form Giảng viên và truyền vào ID
                                    teacherForm.ShowDialog();
                                }
                            }
                        }
                    }
                }

                if (string.IsNullOrEmpty(userID)) // Nếu không phải tài khoản sinh viên hay giảng viên
                    MessageBox.Show("Invalid username or password!"); // Thông báo lỗi khi đăng nhập không thành công
            }
            else
            {
                MessageBox.Show("Please fill all information"); // Thông báo cho người dùng nhập đầy đủ thông tin
            }
        }
    }
}
