namespace BUV_LMS_TEST
{
    partial class TeacherForm
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
            btnCourses = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDashboard = new Button();
            btnForum = new Button();
            btnInfo = new Button();
            lbWelcomeT = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCourses
            // 
            btnCourses.Dock = DockStyle.Fill;
            btnCourses.Location = new Point(3, 87);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(81, 78);
            btnCourses.TabIndex = 0;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(190, 0, 0);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1556187F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 81.84438F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.Size = new Size(93, 465);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnDashboard, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCourses, 0, 1);
            tableLayoutPanel3.Controls.Add(btnForum, 0, 2);
            tableLayoutPanel3.Controls.Add(btnInfo, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 79);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(87, 338);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(81, 78);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnForum
            // 
            btnForum.Dock = DockStyle.Fill;
            btnForum.Location = new Point(3, 171);
            btnForum.Name = "btnForum";
            btnForum.Size = new Size(81, 78);
            btnForum.TabIndex = 0;
            btnForum.Text = "Forum";
            btnForum.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Dock = DockStyle.Fill;
            btnInfo.Location = new Point(3, 255);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(81, 80);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "Infomation";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // lbWelcomeT
            // 
            lbWelcomeT.AutoSize = true;
            lbWelcomeT.Location = new Point(129, 38);
            lbWelcomeT.Name = "lbWelcomeT";
            lbWelcomeT.Size = new Size(112, 15);
            lbWelcomeT.TabIndex = 9;
            lbWelcomeT.Text = "Welcome, Professor";
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 465);
            Controls.Add(lbWelcomeT);
            Controls.Add(tableLayoutPanel2);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCourses;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnDashboard;
        private Button btnForum;
        private Button btnInfo;
        private Label lbWelcomeT;
    }
}