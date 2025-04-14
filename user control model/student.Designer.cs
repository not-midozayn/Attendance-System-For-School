namespace user_control_model
{
    partial class student
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            this.NameLabelFromDB = new System.Windows.Forms.Label();
            this.Name_label_fromDB = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Role_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DashBoard = new System.Windows.Forms.Button();
            this.MarkAttendance_btn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.SubjectReport_btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LTeacherName = new System.Windows.Forms.Label();
            this.panelback = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.toptext = new System.Windows.Forms.Label();
            this.imag2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.allsubjectcheckbox = new System.Windows.Forms.CheckBox();
            this.subjectcheckbox = new System.Windows.Forms.CheckedListBox();
            this.viewattendancegridview = new System.Windows.Forms.DataGridView();
            this.RegisterSubjectChecklist = new System.Windows.Forms.CheckedListBox();
            this.lGender = new System.Windows.Forms.Label();
            this.liconGender = new System.Windows.Forms.Label();
            this.lBirthDate = new System.Windows.Forms.Label();
            this.liconBirth = new System.Windows.Forms.Label();
            this.lAddress = new System.Windows.Forms.Label();
            this.liconAddress = new System.Windows.Forms.Label();
            this.lNumSub = new System.Windows.Forms.Label();
            this.lTextNumberSub = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.liconEmail = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.llName = new System.Windows.Forms.Label();
            this.lFName1 = new System.Windows.Forms.Label();
            this.chooseSubject = new System.Windows.Forms.Label();
            this.liconPhone = new System.Windows.Forms.Label();
            this.studentImage = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelback.SuspendLayout();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewattendancegridview)).BeginInit();
            this.studentImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabelFromDB
            // 
            this.NameLabelFromDB.AutoSize = true;
            this.NameLabelFromDB.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabelFromDB.ForeColor = System.Drawing.Color.White;
            this.NameLabelFromDB.Location = new System.Drawing.Point(140, 63);
            this.NameLabelFromDB.Name = "NameLabelFromDB";
            this.NameLabelFromDB.Size = new System.Drawing.Size(24, 27);
            this.NameLabelFromDB.TabIndex = 6;
            this.NameLabelFromDB.Text = "_";
            this.NameLabelFromDB.Click += new System.EventHandler(this.NameLabelFromDB_Click);
            // 
            // Name_label_fromDB
            // 
            this.Name_label_fromDB.AutoSize = true;
            this.Name_label_fromDB.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label_fromDB.Location = new System.Drawing.Point(112, 50);
            this.Name_label_fromDB.Name = "Name_label_fromDB";
            this.Name_label_fromDB.Size = new System.Drawing.Size(0, 27);
            this.Name_label_fromDB.TabIndex = 3;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Role_label
            // 
            this.Role_label.AutoSize = true;
            this.Role_label.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role_label.ForeColor = System.Drawing.Color.White;
            this.Role_label.Location = new System.Drawing.Point(21, 102);
            this.Role_label.Name = "Role_label";
            this.Role_label.Size = new System.Drawing.Size(55, 27);
            this.Role_label.TabIndex = 2;
            this.Role_label.Text = "Role";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(21, 63);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(102, 27);
            this.welcome_label.TabIndex = 1;
            this.welcome_label.Text = "Welcome";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.DashBoard);
            this.panel1.Controls.Add(this.MarkAttendance_btn);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.SubjectReport_btn);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.text);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 703);
            this.panel1.TabIndex = 282;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Location = new System.Drawing.Point(11, 229);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(11, 43);
            this.panel7.TabIndex = 283;
            // 
            // DashBoard
            // 
            this.DashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard.Location = new System.Drawing.Point(29, 229);
            this.DashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Size = new System.Drawing.Size(215, 43);
            this.DashBoard.TabIndex = 283;
            this.DashBoard.Text = "DashBoard";
            this.DashBoard.UseVisualStyleBackColor = true;
            this.DashBoard.Click += new System.EventHandler(this.DashBoard_Click);
            // 
            // MarkAttendance_btn
            // 
            this.MarkAttendance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkAttendance_btn.Location = new System.Drawing.Point(29, 373);
            this.MarkAttendance_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarkAttendance_btn.Name = "MarkAttendance_btn";
            this.MarkAttendance_btn.Size = new System.Drawing.Size(215, 43);
            this.MarkAttendance_btn.TabIndex = 151;
            this.MarkAttendance_btn.Text = "View Attendance";
            this.MarkAttendance_btn.UseVisualStyleBackColor = true;
            this.MarkAttendance_btn.Click += new System.EventHandler(this.MarkAttendance_btn_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(12, 373);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(11, 43);
            this.panel10.TabIndex = 150;
            // 
            // SubjectReport_btn
            // 
            this.SubjectReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectReport_btn.Location = new System.Drawing.Point(29, 516);
            this.SubjectReport_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectReport_btn.Name = "SubjectReport_btn";
            this.SubjectReport_btn.Size = new System.Drawing.Size(215, 43);
            this.SubjectReport_btn.TabIndex = 7;
            this.SubjectReport_btn.Text = "Register Subject";
            this.SubjectReport_btn.UseVisualStyleBackColor = true;
            this.SubjectReport_btn.Click += new System.EventHandler(this.SubjectReport_btn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(12, 516);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 43);
            this.panel6.TabIndex = 6;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.text.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(4, 130);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(317, 46);
            this.text.TabIndex = 6;
            this.text.Text = "Attendance System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.BackgroundImage = global::user_control_model.Properties.Resources.students;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 111);
            this.panel2.TabIndex = 126;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(273, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(927, 108);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 0);
            this.panel3.TabIndex = 0;
            // 
            // LTeacherName
            // 
            this.LTeacherName.AutoSize = true;
            this.LTeacherName.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTeacherName.ForeColor = System.Drawing.Color.White;
            this.LTeacherName.Location = new System.Drawing.Point(117, 102);
            this.LTeacherName.Margin = new System.Windows.Forms.Padding(0);
            this.LTeacherName.Name = "LTeacherName";
            this.LTeacherName.Size = new System.Drawing.Size(87, 27);
            this.LTeacherName.TabIndex = 7;
            this.LTeacherName.Text = "Student";
            this.LTeacherName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelback
            // 
            this.panelback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelback.Controls.Add(this.paneltop);
            this.panelback.Controls.Add(this.panel5);
            this.panelback.Controls.Add(this.logout_btn);
            this.panelback.Controls.Add(this.LTeacherName);
            this.panelback.Controls.Add(this.NameLabelFromDB);
            this.panelback.Controls.Add(this.Name_label_fromDB);
            this.panelback.Controls.Add(this.Role_label);
            this.panelback.Controls.Add(this.welcome_label);
            this.panelback.Location = new System.Drawing.Point(251, 2);
            this.panelback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelback.Name = "panelback";
            this.panelback.Size = new System.Drawing.Size(1013, 138);
            this.panelback.TabIndex = 281;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.paneltop.Controls.Add(this.toptext);
            this.paneltop.Controls.Add(this.imag2);
            this.paneltop.Location = new System.Drawing.Point(5, -2);
            this.paneltop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1004, 58);
            this.paneltop.TabIndex = 0;
            // 
            // toptext
            // 
            this.toptext.AutoSize = true;
            this.toptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toptext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toptext.Location = new System.Drawing.Point(104, 6);
            this.toptext.Name = "toptext";
            this.toptext.Size = new System.Drawing.Size(714, 42);
            this.toptext.TabIndex = 6;
            this.toptext.Text = "Hst Modern Schools Attentance System";
            // 
            // imag2
            // 
            this.imag2.BackgroundImage = global::user_control_model.Properties.Resources.attendance1;
            this.imag2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imag2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.imag2.Location = new System.Drawing.Point(945, 6);
            this.imag2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imag2.Name = "imag2";
            this.imag2.Size = new System.Drawing.Size(51, 47);
            this.imag2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::user_control_model.Properties.Resources.logout;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(895, 74);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(17, 24);
            this.panel5.TabIndex = 6;
            // 
            // logout_btn
            // 
            this.logout_btn.AutoEllipsis = true;
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_btn.Location = new System.Drawing.Point(884, 66);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(0);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(112, 36);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.Text = "     LogOut";
            this.logout_btn.UseMnemonic = false;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.UseWaitCursor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // allsubjectcheckbox
            // 
            this.allsubjectcheckbox.AutoSize = true;
            this.allsubjectcheckbox.Checked = true;
            this.allsubjectcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allsubjectcheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allsubjectcheckbox.Location = new System.Drawing.Point(463, 166);
            this.allsubjectcheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.allsubjectcheckbox.Name = "allsubjectcheckbox";
            this.allsubjectcheckbox.Size = new System.Drawing.Size(127, 29);
            this.allsubjectcheckbox.TabIndex = 284;
            this.allsubjectcheckbox.Text = "All Subject";
            this.allsubjectcheckbox.UseVisualStyleBackColor = true;
            // 
            // subjectcheckbox
            // 
            this.subjectcheckbox.FormattingEnabled = true;
            this.subjectcheckbox.Items.AddRange(new object[] {
            "Java ",
            "DOT NET ",
            "PYTHON ",
            "OOP"});
            this.subjectcheckbox.Location = new System.Drawing.Point(1136, 551);
            this.subjectcheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.subjectcheckbox.Name = "subjectcheckbox";
            this.subjectcheckbox.Size = new System.Drawing.Size(111, 72);
            this.subjectcheckbox.TabIndex = 286;
            // 
            // viewattendancegridview
            // 
            this.viewattendancegridview.AllowUserToOrderColumns = true;
            this.viewattendancegridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewattendancegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewattendancegridview.Location = new System.Drawing.Point(313, 166);
            this.viewattendancegridview.Margin = new System.Windows.Forms.Padding(4);
            this.viewattendancegridview.Name = "viewattendancegridview";
            this.viewattendancegridview.RowHeadersWidth = 51;
            this.viewattendancegridview.Size = new System.Drawing.Size(927, 492);
            this.viewattendancegridview.TabIndex = 287;
            this.viewattendancegridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewattendancegridview_CellContentClick);
            // 
            // RegisterSubjectChecklist
            // 
            this.RegisterSubjectChecklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSubjectChecklist.FormattingEnabled = true;
            this.RegisterSubjectChecklist.Location = new System.Drawing.Point(371, 248);
            this.RegisterSubjectChecklist.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterSubjectChecklist.Name = "RegisterSubjectChecklist";
            this.RegisterSubjectChecklist.Size = new System.Drawing.Size(252, 354);
            this.RegisterSubjectChecklist.TabIndex = 288;
            this.RegisterSubjectChecklist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.RegisterSubjectChecklist_ItemCheck);
            this.RegisterSubjectChecklist.SelectedIndexChanged += new System.EventHandler(this.RegisterSubjectChecklist_SelectedIndexChanged);
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGender.Location = new System.Drawing.Point(1116, 402);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(66, 29);
            this.lGender.TabIndex = 304;
            this.lGender.Text = "Male";
            // 
            // liconGender
            // 
            this.liconGender.AutoSize = true;
            this.liconGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liconGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.liconGender.Location = new System.Drawing.Point(1080, 402);
            this.liconGender.Name = "liconGender";
            this.liconGender.Size = new System.Drawing.Size(35, 29);
            this.liconGender.TabIndex = 303;
            this.liconGender.Text = "👤";
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBirthDate.Location = new System.Drawing.Point(783, 402);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(156, 29);
            this.lBirthDate.TabIndex = 302;
            this.lBirthDate.Text = "March,5,2000";
            this.lBirthDate.Click += new System.EventHandler(this.lBirthDate_Click);
            // 
            // liconBirth
            // 
            this.liconBirth.AutoSize = true;
            this.liconBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liconBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.liconBirth.Location = new System.Drawing.Point(753, 402);
            this.liconBirth.Name = "liconBirth";
            this.liconBirth.Size = new System.Drawing.Size(36, 29);
            this.liconBirth.TabIndex = 301;
            this.liconBirth.Text = "🎁";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddress.Location = new System.Drawing.Point(783, 338);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(74, 29);
            this.lAddress.TabIndex = 300;
            this.lAddress.Text = "Tanta";
            // 
            // liconAddress
            // 
            this.liconAddress.AutoSize = true;
            this.liconAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liconAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.liconAddress.Location = new System.Drawing.Point(751, 338);
            this.liconAddress.Name = "liconAddress";
            this.liconAddress.Size = new System.Drawing.Size(28, 29);
            this.liconAddress.TabIndex = 299;
            this.liconAddress.Text = "📍";
            this.liconAddress.Click += new System.EventHandler(this.liconAddress_Click);
            // 
            // lNumSub
            // 
            this.lNumSub.AutoSize = true;
            this.lNumSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumSub.Location = new System.Drawing.Point(616, 475);
            this.lNumSub.Name = "lNumSub";
            this.lNumSub.Size = new System.Drawing.Size(26, 29);
            this.lNumSub.TabIndex = 297;
            this.lNumSub.Text = "2";
            // 
            // lTextNumberSub
            // 
            this.lTextNumberSub.AutoSize = true;
            this.lTextNumberSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTextNumberSub.Location = new System.Drawing.Point(365, 475);
            this.lTextNumberSub.Name = "lTextNumberSub";
            this.lTextNumberSub.Size = new System.Drawing.Size(246, 29);
            this.lTextNumberSub.TabIndex = 295;
            this.lTextNumberSub.Text = "Number oF Subjects :";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPhone.Location = new System.Drawing.Point(409, 402);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(156, 29);
            this.lPhone.TabIndex = 294;
            this.lPhone.Text = "01002638890";
            // 
            // liconEmail
            // 
            this.liconEmail.AutoSize = true;
            this.liconEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liconEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.liconEmail.Location = new System.Drawing.Point(364, 340);
            this.liconEmail.Name = "liconEmail";
            this.liconEmail.Size = new System.Drawing.Size(39, 29);
            this.liconEmail.TabIndex = 293;
            this.liconEmail.Text = "✉️";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(409, 340);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(286, 29);
            this.lEmail.TabIndex = 292;
            this.lEmail.Text = "ahmedali123@gmail.com";
            // 
            // llName
            // 
            this.llName.AutoSize = true;
            this.llName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llName.Location = new System.Drawing.Point(373, 268);
            this.llName.Name = "llName";
            this.llName.Size = new System.Drawing.Size(180, 42);
            this.llName.TabIndex = 291;
            this.llName.Text = "Ramadan";
            // 
            // lFName1
            // 
            this.lFName1.AutoSize = true;
            this.lFName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFName1.Location = new System.Drawing.Point(376, 233);
            this.lFName1.Name = "lFName1";
            this.lFName1.Size = new System.Drawing.Size(109, 36);
            this.lFName1.TabIndex = 290;
            this.lFName1.Text = "Ahmed";
            this.lFName1.Click += new System.EventHandler(this.lFName_Click);
            // 
            // chooseSubject
            // 
            this.chooseSubject.AutoSize = true;
            this.chooseSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseSubject.Location = new System.Drawing.Point(366, 199);
            this.chooseSubject.Name = "chooseSubject";
            this.chooseSubject.Size = new System.Drawing.Size(253, 29);
            this.chooseSubject.TabIndex = 305;
            this.chooseSubject.Text = "Choose Your Subjects";
            this.chooseSubject.Visible = false;
            // 
            // liconPhone
            // 
            this.liconPhone.AutoSize = true;
            this.liconPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liconPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.liconPhone.Location = new System.Drawing.Point(366, 402);
            this.liconPhone.Name = "liconPhone";
            this.liconPhone.Size = new System.Drawing.Size(38, 29);
            this.liconPhone.TabIndex = 306;
            this.liconPhone.Text = "📞";
            // 
            // studentImage
            // 
            this.studentImage.BackColor = System.Drawing.Color.White;
            this.studentImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentImage.BackgroundImage")));
            this.studentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.studentImage.Controls.Add(this.panel9);
            this.studentImage.Controls.Add(this.panel11);
            this.studentImage.Location = new System.Drawing.Point(900, 216);
            this.studentImage.Name = "studentImage";
            this.studentImage.Size = new System.Drawing.Size(263, 111);
            this.studentImage.TabIndex = 307;
            this.studentImage.Paint += new System.Windows.Forms.PaintEventHandler(this.studentImage_Paint);
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(273, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(927, 108);
            this.panel9.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(263, 0);
            this.panel11.TabIndex = 0;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 703);
            this.Controls.Add(this.studentImage);
            this.Controls.Add(this.liconPhone);
            this.Controls.Add(this.chooseSubject);
            this.Controls.Add(this.RegisterSubjectChecklist);
            this.Controls.Add(this.lGender);
            this.Controls.Add(this.liconGender);
            this.Controls.Add(this.lBirthDate);
            this.Controls.Add(this.liconBirth);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.liconAddress);
            this.Controls.Add(this.lNumSub);
            this.Controls.Add(this.lTextNumberSub);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.liconEmail);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.llName);
            this.Controls.Add(this.lFName1);
            this.Controls.Add(this.viewattendancegridview);
            this.Controls.Add(this.subjectcheckbox);
            this.Controls.Add(this.allsubjectcheckbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1282, 750);
            this.MinimumSize = new System.Drawing.Size(1282, 750);
            this.Name = "student";
            this.Text = "student";
            this.Load += new System.EventHandler(this.student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelback.ResumeLayout(false);
            this.panelback.PerformLayout();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewattendancegridview)).EndInit();
            this.studentImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabelFromDB;
        private System.Windows.Forms.Label Name_label_fromDB;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MarkAttendance_btn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button SubjectReport_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelback;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label toptext;
        private System.Windows.Forms.Panel imag2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label LTeacherName;
        private System.Windows.Forms.Label Role_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button DashBoard;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.CheckBox allsubjectcheckbox;
        private System.Windows.Forms.CheckedListBox subjectcheckbox;
        private System.Windows.Forms.DataGridView viewattendancegridview;
        private System.Windows.Forms.CheckedListBox RegisterSubjectChecklist;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.Label liconGender;
        private System.Windows.Forms.Label lBirthDate;
        private System.Windows.Forms.Label liconBirth;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label liconAddress;
        private System.Windows.Forms.Label lNumSub;
        private System.Windows.Forms.Label lTextNumberSub;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label liconEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label llName;
        private System.Windows.Forms.Label lFName1;
        private System.Windows.Forms.Label chooseSubject;
        private System.Windows.Forms.Label liconPhone;
        private System.Windows.Forms.Panel studentImage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
    }
}