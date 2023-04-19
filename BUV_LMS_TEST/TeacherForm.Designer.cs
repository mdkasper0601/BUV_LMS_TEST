﻿namespace BUV_LMS_TEST
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
            btnAddCourse = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnAdd = new Panel();
            pnAdded = new Panel();
            lbAdded = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnAdd.SuspendLayout();
            pnAdded.SuspendLayout();
            SuspendLayout();
            // 
            // btnCourses
            // 
            btnCourses.Dock = DockStyle.Fill;
            btnCourses.Location = new Point(3, 93);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(81, 84);
            btnCourses.TabIndex = 0;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
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
            tableLayoutPanel2.Size = new Size(93, 495);
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
            tableLayoutPanel3.Location = new Point(3, 84);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(87, 363);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(81, 84);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnForum
            // 
            btnForum.Dock = DockStyle.Fill;
            btnForum.Location = new Point(3, 183);
            btnForum.Name = "btnForum";
            btnForum.Size = new Size(81, 84);
            btnForum.TabIndex = 0;
            btnForum.Text = "Forum";
            btnForum.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Dock = DockStyle.Fill;
            btnInfo.Location = new Point(3, 273);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(81, 87);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "Infomation";
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // lbWelcomeT
            // 
            lbWelcomeT.AutoSize = true;
            lbWelcomeT.Location = new Point(2, 6);
            lbWelcomeT.Name = "lbWelcomeT";
            lbWelcomeT.Size = new Size(112, 15);
            lbWelcomeT.TabIndex = 9;
            lbWelcomeT.Text = "Welcome, Professor";
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(592, 205);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(121, 23);
            btnAddCourse.TabIndex = 10;
            btnAddCourse.Text = "Add Courses";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(pnAdded, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(93, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(722, 495);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // pnAdd
            // 
            pnAdd.Controls.Add(textBox1);
            pnAdd.Controls.Add(lbWelcomeT);
            pnAdd.Controls.Add(btnAddCourse);
            pnAdd.Dock = DockStyle.Fill;
            pnAdd.Location = new Point(3, 3);
            pnAdd.Name = "pnAdd";
            pnAdd.Size = new Size(716, 241);
            pnAdd.TabIndex = 0;
            // 
            // pnAdded
            // 
            pnAdded.Controls.Add(lbAdded);
            pnAdded.Dock = DockStyle.Fill;
            pnAdded.Location = new Point(3, 250);
            pnAdded.Name = "pnAdded";
            pnAdded.Size = new Size(716, 242);
            pnAdded.TabIndex = 1;
            // 
            // lbAdded
            // 
            lbAdded.AutoSize = true;
            lbAdded.Location = new Point(2, 3);
            lbAdded.Name = "lbAdded";
            lbAdded.Size = new Size(40, 15);
            lbAdded.TabIndex = 0;
            lbAdded.Text = "added";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 11;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 495);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnAdd.ResumeLayout(false);
            pnAdd.PerformLayout();
            pnAdded.ResumeLayout(false);
            pnAdded.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCourses;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnDashboard;
        private Button btnForum;
        private Button btnInfo;
        private Label lbWelcomeT;
        private Button btnAddCourse;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnAdd;
        private TextBox textBox1;
        private Panel pnAdded;
        private Label lbAdded;
    }
}