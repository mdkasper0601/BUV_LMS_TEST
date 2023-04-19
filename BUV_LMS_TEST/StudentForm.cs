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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BUV_LMS_TEST
{
    public partial class StudentForm : Form
    {
        SqlConnection cn;
        string studentID; // thêm một biến để lưu trữ ID

        public StudentForm() // hàm tạo mặc định
        {
            InitializeComponent();
        }

        public StudentForm(string id) // hàm tạo mới nhận tham số là ID
        {
            InitializeComponent();
            studentID = id;
            this.Width = Screen.PrimaryScreen.Bounds.Width; // dòng này và dòng dưới để chỉnh form luôn t
            this.Height = Screen.PrimaryScreen.Bounds.Height;// to bằng màn hình mọi máy
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome, " + studentID;
            lbWelcome.Font = new Font(lbWelcome.Font.Name, lbWelcome.Font.Size + 20);
            lbDashboard.Text = "Dashboard";
            lbNoti.Text = "Notification";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
