using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUV_LMS_TEST
{
    public partial class TeacherForm : Form
    {
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
    }
}
