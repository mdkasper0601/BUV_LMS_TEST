namespace BUV_LMS_TEST
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnDashboard = new Button();
            panel3 = new Panel();
            btnCourses = new Button();
            panel4 = new Panel();
            btnForum = new Button();
            panel5 = new Panel();
            btnInfo = new Button();
            lbWelcome = new Label();
            lbDashboard = new Label();
            lbNoti = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(190, 0, 0);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(139, 531);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 101);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDashboard);
            panel2.Location = new Point(3, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(134, 40);
            panel2.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(0, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(131, 37);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCourses);
            panel3.Location = new Point(3, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(134, 40);
            panel3.TabIndex = 1;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(0, 3);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(131, 37);
            btnCourses.TabIndex = 2;
            btnCourses.Text = "Courses";
            btnCourses.TextAlign = ContentAlignment.MiddleLeft;
            btnCourses.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnForum);
            panel4.Location = new Point(3, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(134, 40);
            panel4.TabIndex = 1;
            // 
            // btnForum
            // 
            btnForum.Location = new Point(0, 3);
            btnForum.Name = "btnForum";
            btnForum.Size = new Size(131, 37);
            btnForum.TabIndex = 2;
            btnForum.Text = "Forum";
            btnForum.TextAlign = ContentAlignment.MiddleLeft;
            btnForum.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnInfo);
            panel5.Location = new Point(3, 248);
            panel5.Name = "panel5";
            panel5.Size = new Size(134, 40);
            panel5.TabIndex = 1;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(0, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(131, 37);
            btnInfo.TabIndex = 2;
            btnInfo.Text = "Infomation";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Location = new Point(166, 14);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(62, 25);
            lbWelcome.TabIndex = 1;
            lbWelcome.Text = "ksfjasf";
            // 
            // lbDashboard
            // 
            lbDashboard.AutoSize = true;
            lbDashboard.Location = new Point(166, 110);
            lbDashboard.Name = "lbDashboard";
            lbDashboard.Size = new Size(62, 25);
            lbDashboard.TabIndex = 1;
            lbDashboard.Text = "ksfjasf";
            // 
            // lbNoti
            // 
            lbNoti.AutoSize = true;
            lbNoti.Location = new Point(166, 288);
            lbNoti.Name = "lbNoti";
            lbNoti.Size = new Size(62, 25);
            lbNoti.TabIndex = 1;
            lbNoti.Text = "ksfjasf";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 531);
            Controls.Add(lbNoti);
            Controls.Add(lbDashboard);
            Controls.Add(lbWelcome);
            Controls.Add(flowLayoutPanel1);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button btnDashboard;
        private Panel panel3;
        private Button btnCourses;
        private Panel panel4;
        private Button btnForum;
        private Panel panel5;
        private Button btnInfo;
        private Label lbWelcome;
        private Label lbDashboard;
        private Label lbNoti;
    }
}