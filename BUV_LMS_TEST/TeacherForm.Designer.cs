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
            btnAddCourses = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCourses
            // 
            btnCourses.Dock = DockStyle.Fill;
            btnCourses.Location = new Point(4, 146);
            btnCourses.Margin = new Padding(4, 5, 4, 5);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(117, 131);
            btnCourses.TabIndex = 0;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(190, 0, 0);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1556187F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 81.84438F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel2.Size = new Size(133, 775);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.Controls.Add(btnDashboard, 0, 0);
            tableLayoutPanel3.Controls.Add(btnCourses, 0, 1);
            tableLayoutPanel3.Controls.Add(btnForum, 0, 2);
            tableLayoutPanel3.Controls.Add(btnInfo, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 132);
            tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(125, 564);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.Location = new Point(4, 5);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(117, 131);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnForum
            // 
            btnForum.Dock = DockStyle.Fill;
            btnForum.Location = new Point(4, 287);
            btnForum.Margin = new Padding(4, 5, 4, 5);
            btnForum.Name = "btnForum";
            btnForum.Size = new Size(117, 131);
            btnForum.TabIndex = 0;
            btnForum.Text = "Forum";
            btnForum.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Dock = DockStyle.Fill;
            btnInfo.Location = new Point(4, 428);
            btnInfo.Margin = new Padding(4, 5, 4, 5);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(117, 131);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "Infomation";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // lbWelcomeT
            // 
            lbWelcomeT.AutoSize = true;
            lbWelcomeT.Location = new Point(184, 63);
            lbWelcomeT.Margin = new Padding(4, 0, 4, 0);
            lbWelcomeT.Name = "lbWelcomeT";
            lbWelcomeT.Size = new Size(169, 25);
            lbWelcomeT.TabIndex = 9;
            lbWelcomeT.Text = "Welcome, Professor";
            // 
            // btnAddCourses
            // 
            btnAddCourses.Location = new Point(184, 150);
            btnAddCourses.Name = "btnAddCourses";
            btnAddCourses.Size = new Size(112, 34);
            btnAddCourses.TabIndex = 10;
            btnAddCourses.Text = "Add Courses";
            btnAddCourses.UseVisualStyleBackColor = true;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 775);
            Controls.Add(btnAddCourses);
            Controls.Add(lbWelcomeT);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnAddCourses;
    }
}