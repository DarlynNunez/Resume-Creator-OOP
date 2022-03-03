
namespace Resume
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GenerateJSON = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.TextBox();
            this.requiredWorkExperience = new System.Windows.Forms.Label();
            this.workExperience = new System.Windows.Forms.DataGridView();
            this.jobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfButton = new System.Windows.Forms.Button();
            this.loadJsonButton = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.TextBox();
            this.summaryLabeel = new System.Windows.Forms.Label();
            this.workingExperienceLabel = new System.Windows.Forms.Label();
            this.skills = new System.Windows.Forms.TextBox();
            this.skillLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.clgName = new System.Windows.Forms.Label();
            this.yrClgGraduatedLabel = new System.Windows.Forms.Label();
            this.clgUnivName = new System.Windows.Forms.TextBox();
            this.yearClgGraduated = new System.Windows.Forms.TextBox();
            this.collegeTitleLabel = new System.Windows.Forms.Label();
            this.yGHS = new System.Windows.Forms.TextBox();
            this.hsName = new System.Windows.Forms.TextBox();
            this.yrhsEnd = new System.Windows.Forms.Label();
            this.hsLabel = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.highSchoolTitleLabel = new System.Windows.Forms.Label();
            this.educTitleLabel = new System.Windows.Forms.Label();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.llNumber = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.cpNumber = new System.Windows.Forms.TextBox();
            this.emailaLabel = new System.Windows.Forms.Label();
            this.llnLabel = new System.Windows.Forms.Label();
            this.cpnLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.workExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "PERSONAL INFORMATION";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullName.Location = new System.Drawing.Point(145, 67);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(0, 19);
            this.fullName.TabIndex = 47;
            this.fullName.UseWaitCursor = true;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.Location = new System.Drawing.Point(12, 65);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(101, 21);
            this.fullNameLabel.TabIndex = 46;
            this.fullNameLabel.Text = "Full Name:";
            this.fullNameLabel.UseWaitCursor = true;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.CornflowerBlue;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(159, 574);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(150, 40);
            this.reset.TabIndex = 48;
            this.reset.Text = "Reset ALL";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.UseWaitCursor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GenerateJSON
            // 
            this.GenerateJSON.BackColor = System.Drawing.Color.CornflowerBlue;
            this.GenerateJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateJSON.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateJSON.Location = new System.Drawing.Point(716, 574);
            this.GenerateJSON.Name = "GenerateJSON";
            this.GenerateJSON.Size = new System.Drawing.Size(150, 40);
            this.GenerateJSON.TabIndex = 45;
            this.GenerateJSON.Text = "Generate JSON";
            this.GenerateJSON.UseVisualStyleBackColor = false;
            this.GenerateJSON.UseWaitCursor = true;
            this.GenerateJSON.Click += new System.EventHandler(this.GenerateJSON_Click);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update.ForeColor = System.Drawing.Color.Red;
            this.update.Location = new System.Drawing.Point(330, 9);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(0, 27);
            this.update.TabIndex = 44;
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.UseWaitCursor = true;
            this.update.MouseDown += new System.Windows.Forms.MouseEventHandler(this.update_MouseDown);
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseLabel.Location = new System.Drawing.Point(502, 236);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(58, 18);
            this.courseLabel.TabIndex = 43;
            this.courseLabel.Text = "Course:";
            this.courseLabel.UseWaitCursor = true;
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.Color.LavenderBlush;
            this.course.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.course.Location = new System.Drawing.Point(566, 231);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(301, 27);
            this.course.TabIndex = 11;
            this.course.UseWaitCursor = true;
            this.course.Click += new System.EventHandler(this.course_Click);
            this.course.TextChanged += new System.EventHandler(this.course_TextChanged);
            // 
            // requiredWorkExperience
            // 
            this.requiredWorkExperience.AutoSize = true;
            this.requiredWorkExperience.BackColor = System.Drawing.Color.PaleVioletRed;
            this.requiredWorkExperience.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.requiredWorkExperience.ForeColor = System.Drawing.Color.Red;
            this.requiredWorkExperience.Location = new System.Drawing.Point(345, 9);
            this.requiredWorkExperience.Name = "requiredWorkExperience";
            this.requiredWorkExperience.Size = new System.Drawing.Size(0, 21);
            this.requiredWorkExperience.TabIndex = 41;
            this.requiredWorkExperience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.requiredWorkExperience.UseWaitCursor = true;
            // 
            // workExperience
            // 
            this.workExperience.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.workExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workExperience.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobTitle,
            this.companyName,
            this.jobDuration});
            this.workExperience.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.workExperience.Location = new System.Drawing.Point(18, 459);
            this.workExperience.Name = "workExperience";
            this.workExperience.RowTemplate.Height = 25;
            this.workExperience.Size = new System.Drawing.Size(848, 102);
            this.workExperience.TabIndex = 40;
            this.workExperience.UseWaitCursor = true;
            this.workExperience.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workExperience_CellClick);
            this.workExperience.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workExperience_CellContentClick);
            // 
            // jobTitle
            // 
            this.jobTitle.HeaderText = "Job Title";
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Width = 275;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Company Name";
            this.companyName.Name = "companyName";
            this.companyName.Width = 270;
            // 
            // jobDuration
            // 
            this.jobDuration.HeaderText = "Job Duration";
            this.jobDuration.Name = "jobDuration";
            this.jobDuration.Width = 260;
            // 
            // pdfButton
            // 
            this.pdfButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pdfButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pdfButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pdfButton.Location = new System.Drawing.Point(531, 574);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(150, 40);
            this.pdfButton.TabIndex = 39;
            this.pdfButton.Text = "Generate PDF";
            this.pdfButton.UseVisualStyleBackColor = false;
            this.pdfButton.UseWaitCursor = true;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // loadJsonButton
            // 
            this.loadJsonButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loadJsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadJsonButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadJsonButton.Location = new System.Drawing.Point(345, 574);
            this.loadJsonButton.Name = "loadJsonButton";
            this.loadJsonButton.Size = new System.Drawing.Size(150, 40);
            this.loadJsonButton.TabIndex = 38;
            this.loadJsonButton.Text = "Load JSON";
            this.loadJsonButton.UseVisualStyleBackColor = false;
            this.loadJsonButton.UseWaitCursor = true;
            this.loadJsonButton.Click += new System.EventHandler(this.loadJsonButton_Click);
            // 
            // summary
            // 
            this.summary.AcceptsReturn = true;
            this.summary.BackColor = System.Drawing.Color.LavenderBlush;
            this.summary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summary.Location = new System.Drawing.Point(100, 361);
            this.summary.Multiline = true;
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(766, 46);
            this.summary.TabIndex = 7;
            this.summary.UseWaitCursor = true;
            this.summary.Click += new System.EventHandler(this.summary_Click);
            // 
            // summaryLabeel
            // 
            this.summaryLabeel.AutoSize = true;
            this.summaryLabeel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summaryLabeel.Location = new System.Drawing.Point(23, 365);
            this.summaryLabeel.Name = "summaryLabeel";
            this.summaryLabeel.Size = new System.Drawing.Size(76, 18);
            this.summaryLabeel.TabIndex = 36;
            this.summaryLabeel.Text = "Summary:";
            this.summaryLabeel.UseWaitCursor = true;
            // 
            // workingExperienceLabel
            // 
            this.workingExperienceLabel.AutoSize = true;
            this.workingExperienceLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workingExperienceLabel.Location = new System.Drawing.Point(12, 423);
            this.workingExperienceLabel.Name = "workingExperienceLabel";
            this.workingExperienceLabel.Size = new System.Drawing.Size(240, 23);
            this.workingExperienceLabel.TabIndex = 23;
            this.workingExperienceLabel.Text = "WORKING EXPERIENCE";
            this.workingExperienceLabel.UseWaitCursor = true;
            // 
            // skills
            // 
            this.skills.BackColor = System.Drawing.Color.LavenderBlush;
            this.skills.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skills.Location = new System.Drawing.Point(101, 306);
            this.skills.Multiline = true;
            this.skills.Name = "skills";
            this.skills.PlaceholderText = "Seperate by comma (ex: SKILL 1, SKILL 2, SKILL 3, SKILL 4)";
            this.skills.Size = new System.Drawing.Size(766, 46);
            this.skills.TabIndex = 13;
            this.skills.UseWaitCursor = true;
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.skillLabel.Location = new System.Drawing.Point(58, 310);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(41, 18);
            this.skillLabel.TabIndex = 21;
            this.skillLabel.Text = "Skills:";
            this.skillLabel.UseWaitCursor = true;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fNameLabel.Location = new System.Drawing.Point(15, 107);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(84, 18);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First Name:";
            this.fNameLabel.UseWaitCursor = true;
            // 
            // summaryLabel
            // 
            this.summaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(1489, 30);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(50, 13);
            this.summaryLabel.TabIndex = 19;
            this.summaryLabel.Text = "Summary";
            this.summaryLabel.UseWaitCursor = true;
            // 
            // clgName
            // 
            this.clgName.AutoSize = true;
            this.clgName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clgName.Location = new System.Drawing.Point(462, 207);
            this.clgName.Name = "clgName";
            this.clgName.Size = new System.Drawing.Size(98, 18);
            this.clgName.TabIndex = 15;
            this.clgName.Text = "School Name:";
            this.clgName.UseWaitCursor = true;
            this.clgName.Click += new System.EventHandler(this.clgName_Click);
            // 
            // yrClgGraduatedLabel
            // 
            this.yrClgGraduatedLabel.AutoSize = true;
            this.yrClgGraduatedLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yrClgGraduatedLabel.Location = new System.Drawing.Point(459, 273);
            this.yrClgGraduatedLabel.Name = "yrClgGraduatedLabel";
            this.yrClgGraduatedLabel.Size = new System.Drawing.Size(101, 18);
            this.yrClgGraduatedLabel.TabIndex = 16;
            this.yrClgGraduatedLabel.Text = "Yr Graduated:";
            this.yrClgGraduatedLabel.UseWaitCursor = true;
            // 
            // clgUnivName
            // 
            this.clgUnivName.BackColor = System.Drawing.Color.LavenderBlush;
            this.clgUnivName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clgUnivName.Location = new System.Drawing.Point(566, 198);
            this.clgUnivName.MaximumSize = new System.Drawing.Size(429, 23);
            this.clgUnivName.Name = "clgUnivName";
            this.clgUnivName.Size = new System.Drawing.Size(301, 27);
            this.clgUnivName.TabIndex = 10;
            this.clgUnivName.UseWaitCursor = true;
            this.clgUnivName.Click += new System.EventHandler(this.clgUnivName_Click);
            // 
            // yearClgGraduated
            // 
            this.yearClgGraduated.BackColor = System.Drawing.Color.LavenderBlush;
            this.yearClgGraduated.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearClgGraduated.Location = new System.Drawing.Point(566, 269);
            this.yearClgGraduated.MaximumSize = new System.Drawing.Size(129, 23);
            this.yearClgGraduated.Name = "yearClgGraduated";
            this.yearClgGraduated.PlaceholderText = " (ex: 2021)";
            this.yearClgGraduated.Size = new System.Drawing.Size(112, 27);
            this.yearClgGraduated.TabIndex = 12;
            this.yearClgGraduated.UseWaitCursor = true;
            this.yearClgGraduated.Click += new System.EventHandler(this.yearClgGraduated_Click);
            // 
            // collegeTitleLabel
            // 
            this.collegeTitleLabel.AutoSize = true;
            this.collegeTitleLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.collegeTitleLabel.Location = new System.Drawing.Point(443, 178);
            this.collegeTitleLabel.Name = "collegeTitleLabel";
            this.collegeTitleLabel.Size = new System.Drawing.Size(76, 21);
            this.collegeTitleLabel.TabIndex = 14;
            this.collegeTitleLabel.Text = "Tertiary";
            this.collegeTitleLabel.UseWaitCursor = true;
            // 
            // yGHS
            // 
            this.yGHS.BackColor = System.Drawing.Color.LavenderBlush;
            this.yGHS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yGHS.Location = new System.Drawing.Point(566, 135);
            this.yGHS.MaximumSize = new System.Drawing.Size(112, 23);
            this.yGHS.Name = "yGHS";
            this.yGHS.PlaceholderText = " (ex: 2014)";
            this.yGHS.Size = new System.Drawing.Size(112, 27);
            this.yGHS.TabIndex = 9;
            this.yGHS.UseWaitCursor = true;
            this.yGHS.Click += new System.EventHandler(this.yGHS_Click);
            this.yGHS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yGHS_KeyPress);
            // 
            // hsName
            // 
            this.hsName.BackColor = System.Drawing.Color.LavenderBlush;
            this.hsName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hsName.Location = new System.Drawing.Point(566, 98);
            this.hsName.Name = "hsName";
            this.hsName.Size = new System.Drawing.Size(301, 27);
            this.hsName.TabIndex = 8;
            this.hsName.UseWaitCursor = true;
            this.hsName.Click += new System.EventHandler(this.hsName_Click);
            // 
            // yrhsEnd
            // 
            this.yrhsEnd.AutoSize = true;
            this.yrhsEnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yrhsEnd.Location = new System.Drawing.Point(459, 140);
            this.yrhsEnd.Name = "yrhsEnd";
            this.yrhsEnd.Size = new System.Drawing.Size(101, 18);
            this.yrhsEnd.TabIndex = 11;
            this.yrhsEnd.Text = "Yr Graduated:";
            this.yrhsEnd.UseWaitCursor = true;
            // 
            // hsLabel
            // 
            this.hsLabel.AutoSize = true;
            this.hsLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hsLabel.Location = new System.Drawing.Point(462, 107);
            this.hsLabel.Name = "hsLabel";
            this.hsLabel.Size = new System.Drawing.Size(98, 18);
            this.hsLabel.TabIndex = 10;
            this.hsLabel.Text = "School Name:";
            this.hsLabel.UseWaitCursor = true;
            // 
            // lName
            // 
            this.lName.BackColor = System.Drawing.Color.LavenderBlush;
            this.lName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lName.Location = new System.Drawing.Point(101, 132);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(301, 27);
            this.lName.TabIndex = 2;
            this.lName.UseWaitCursor = true;
            this.lName.Click += new System.EventHandler(this.lName_Click);
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lNameLabel.Location = new System.Drawing.Point(15, 144);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(84, 18);
            this.lNameLabel.TabIndex = 8;
            this.lNameLabel.Text = "Last Name:";
            this.lNameLabel.UseWaitCursor = true;
            this.lNameLabel.Click += new System.EventHandler(this.lNameLabel_Click);
            // 
            // highSchoolTitleLabel
            // 
            this.highSchoolTitleLabel.AutoSize = true;
            this.highSchoolTitleLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.highSchoolTitleLabel.Location = new System.Drawing.Point(443, 65);
            this.highSchoolTitleLabel.Name = "highSchoolTitleLabel";
            this.highSchoolTitleLabel.Size = new System.Drawing.Size(100, 21);
            this.highSchoolTitleLabel.TabIndex = 7;
            this.highSchoolTitleLabel.Text = "Secondary";
            this.highSchoolTitleLabel.UseWaitCursor = true;
            this.highSchoolTitleLabel.Click += new System.EventHandler(this.highSchoolTitleLabel_Click);
            // 
            // educTitleLabel
            // 
            this.educTitleLabel.AutoSize = true;
            this.educTitleLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.educTitleLabel.Location = new System.Drawing.Point(504, 32);
            this.educTitleLabel.Name = "educTitleLabel";
            this.educTitleLabel.Size = new System.Drawing.Size(287, 23);
            this.educTitleLabel.TabIndex = 6;
            this.educTitleLabel.Text = "EDUCATIONAL ATTAINMENT";
            this.educTitleLabel.UseWaitCursor = true;
            // 
            // emailAddress
            // 
            this.emailAddress.BackColor = System.Drawing.Color.LavenderBlush;
            this.emailAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailAddress.Location = new System.Drawing.Point(101, 264);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(301, 27);
            this.emailAddress.TabIndex = 6;
            this.emailAddress.UseWaitCursor = true;
            this.emailAddress.Click += new System.EventHandler(this.emailAddress_Click);
            // 
            // llNumber
            // 
            this.llNumber.BackColor = System.Drawing.Color.LavenderBlush;
            this.llNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llNumber.Location = new System.Drawing.Point(101, 231);
            this.llNumber.Name = "llNumber";
            this.llNumber.Size = new System.Drawing.Size(301, 27);
            this.llNumber.TabIndex = 5;
            this.llNumber.UseWaitCursor = true;
            this.llNumber.Click += new System.EventHandler(this.llNumber_Click);
            this.llNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.llNumber_KeyPress);
            // 
            // fName
            // 
            this.fName.BackColor = System.Drawing.Color.LavenderBlush;
            this.fName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fName.Location = new System.Drawing.Point(101, 98);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(301, 27);
            this.fName.TabIndex = 1;
            this.fName.UseWaitCursor = true;
            this.fName.Click += new System.EventHandler(this.fName_Click);
            this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.LavenderBlush;
            this.address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(101, 165);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(301, 27);
            this.address.TabIndex = 3;
            this.address.UseWaitCursor = true;
            this.address.Click += new System.EventHandler(this.address_Click);
            // 
            // cpNumber
            // 
            this.cpNumber.BackColor = System.Drawing.Color.LavenderBlush;
            this.cpNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpNumber.Location = new System.Drawing.Point(101, 198);
            this.cpNumber.Name = "cpNumber";
            this.cpNumber.Size = new System.Drawing.Size(301, 27);
            this.cpNumber.TabIndex = 4;
            this.cpNumber.UseWaitCursor = true;
            this.cpNumber.Click += new System.EventHandler(this.cpNumber_Click);
            this.cpNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpNumber_KeyPress);
            // 
            // emailaLabel
            // 
            this.emailaLabel.AutoSize = true;
            this.emailaLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailaLabel.Location = new System.Drawing.Point(18, 273);
            this.emailaLabel.Name = "emailaLabel";
            this.emailaLabel.Size = new System.Drawing.Size(81, 18);
            this.emailaLabel.TabIndex = 4;
            this.emailaLabel.Text = "Email Add.:";
            this.emailaLabel.UseWaitCursor = true;
            // 
            // llnLabel
            // 
            this.llnLabel.AutoSize = true;
            this.llnLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llnLabel.Location = new System.Drawing.Point(30, 240);
            this.llnLabel.Name = "llnLabel";
            this.llnLabel.Size = new System.Drawing.Size(69, 18);
            this.llnLabel.TabIndex = 3;
            this.llnLabel.Text = "Landline :";
            this.llnLabel.UseWaitCursor = true;
            this.llnLabel.Click += new System.EventHandler(this.llnLabel_Click);
            // 
            // cpnLabel
            // 
            this.cpnLabel.AutoSize = true;
            this.cpnLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpnLabel.Location = new System.Drawing.Point(34, 207);
            this.cpnLabel.Name = "cpnLabel";
            this.cpnLabel.Size = new System.Drawing.Size(65, 18);
            this.cpnLabel.TabIndex = 2;
            this.cpnLabel.Text = "Number:";
            this.cpnLabel.UseWaitCursor = true;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(9, 174);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(90, 18);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Full Address:";
            this.addressLabel.UseWaitCursor = true;
            // 
            // textBox7
            // 
            this.textBox7.AcceptsReturn = true;
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(1277, 50);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(262, 157);
            this.textBox7.TabIndex = 20;
            this.textBox7.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(880, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.GenerateJSON);
            this.Controls.Add(this.update);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.course);
            this.Controls.Add(this.requiredWorkExperience);
            this.Controls.Add(this.workExperience);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.loadJsonButton);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.summaryLabeel);
            this.Controls.Add(this.workingExperienceLabel);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.yearClgGraduated);
            this.Controls.Add(this.clgUnivName);
            this.Controls.Add(this.yrClgGraduatedLabel);
            this.Controls.Add(this.clgName);
            this.Controls.Add(this.collegeTitleLabel);
            this.Controls.Add(this.yGHS);
            this.Controls.Add(this.hsName);
            this.Controls.Add(this.yrhsEnd);
            this.Controls.Add(this.hsLabel);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.highSchoolTitleLabel);
            this.Controls.Add(this.educTitleLabel);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.llNumber);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.address);
            this.Controls.Add(this.cpNumber);
            this.Controls.Add(this.emailaLabel);
            this.Controls.Add(this.llnLabel);
            this.Controls.Add(this.cpnLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.fNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume Creator";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button GenerateJSON;
        private System.Windows.Forms.Label update;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox course;
        private System.Windows.Forms.Label requiredWorkExperience;
        private System.Windows.Forms.DataGridView workExperience;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.Button loadJsonButton;
        private System.Windows.Forms.TextBox summary;
        private System.Windows.Forms.Label summaryLabeel;
        private System.Windows.Forms.Label workingExperienceLabel;
        private System.Windows.Forms.TextBox skills;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label clgName;
        private System.Windows.Forms.Label yrClgGraduatedLabel;
        private System.Windows.Forms.TextBox clgUnivName;
        private System.Windows.Forms.TextBox yearClgGraduated;
        private System.Windows.Forms.Label collegeTitleLabel;
        private System.Windows.Forms.TextBox yGHS;
        private System.Windows.Forms.TextBox hsName;
        private System.Windows.Forms.Label yrhsEnd;
        private System.Windows.Forms.Label hsLabel;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label highSchoolTitleLabel;
        private System.Windows.Forms.Label educTitleLabel;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.TextBox llNumber;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox cpNumber;
        private System.Windows.Forms.Label emailaLabel;
        private System.Windows.Forms.Label llnLabel;
        private System.Windows.Forms.Label cpnLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDuration;
    }
}

