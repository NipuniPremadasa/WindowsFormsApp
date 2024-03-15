namespace WindowsFormsApp
{
    partial class Signup
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
            this.groupDetails = new System.Windows.Forms.GroupBox();
            this.checkOther = new System.Windows.Forms.CheckBox();
            this.checkTamil = new System.Windows.Forms.CheckBox();
            this.checkEnglish = new System.Windows.Forms.CheckBox();
            this.checkSinhala = new System.Windows.Forms.CheckBox();
            this.calDOB = new System.Windows.Forms.DateTimePicker();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.comAcademicYear = new System.Windows.Forms.ComboBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtIndexNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblLanguages = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStudenDetails = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblIndexNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSerach = new System.Windows.Forms.TextBox();
            this.groupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDetails
            // 
            this.groupDetails.Controls.Add(this.checkOther);
            this.groupDetails.Controls.Add(this.checkTamil);
            this.groupDetails.Controls.Add(this.checkEnglish);
            this.groupDetails.Controls.Add(this.checkSinhala);
            this.groupDetails.Controls.Add(this.calDOB);
            this.groupDetails.Controls.Add(this.radFemale);
            this.groupDetails.Controls.Add(this.radMale);
            this.groupDetails.Controls.Add(this.comAcademicYear);
            this.groupDetails.Controls.Add(this.txtMobile);
            this.groupDetails.Controls.Add(this.txtIndexNumber);
            this.groupDetails.Controls.Add(this.txtName);
            this.groupDetails.Controls.Add(this.lblMobile);
            this.groupDetails.Controls.Add(this.lblLanguages);
            this.groupDetails.Controls.Add(this.lblDOB);
            this.groupDetails.Controls.Add(this.lblGender);
            this.groupDetails.Controls.Add(this.lblStudenDetails);
            this.groupDetails.Controls.Add(this.lblYear);
            this.groupDetails.Controls.Add(this.lblIndexNumber);
            this.groupDetails.Controls.Add(this.lblName);
            this.groupDetails.Location = new System.Drawing.Point(12, 44);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(742, 305);
            this.groupDetails.TabIndex = 0;
            this.groupDetails.TabStop = false;
            this.groupDetails.Text = "Student Details";
            // 
            // checkOther
            // 
            this.checkOther.AutoSize = true;
            this.checkOther.Location = new System.Drawing.Point(497, 251);
            this.checkOther.Name = "checkOther";
            this.checkOther.Size = new System.Drawing.Size(61, 20);
            this.checkOther.TabIndex = 6;
            this.checkOther.Text = "Other";
            this.checkOther.UseVisualStyleBackColor = true;
            // 
            // checkTamil
            // 
            this.checkTamil.AutoSize = true;
            this.checkTamil.Location = new System.Drawing.Point(392, 251);
            this.checkTamil.Name = "checkTamil";
            this.checkTamil.Size = new System.Drawing.Size(63, 20);
            this.checkTamil.TabIndex = 6;
            this.checkTamil.Text = "Tamil";
            this.checkTamil.UseVisualStyleBackColor = true;
            // 
            // checkEnglish
            // 
            this.checkEnglish.AutoSize = true;
            this.checkEnglish.Location = new System.Drawing.Point(279, 251);
            this.checkEnglish.Name = "checkEnglish";
            this.checkEnglish.Size = new System.Drawing.Size(73, 20);
            this.checkEnglish.TabIndex = 6;
            this.checkEnglish.Text = "English";
            this.checkEnglish.UseVisualStyleBackColor = true;
            // 
            // checkSinhala
            // 
            this.checkSinhala.AutoSize = true;
            this.checkSinhala.Location = new System.Drawing.Point(158, 251);
            this.checkSinhala.Name = "checkSinhala";
            this.checkSinhala.Size = new System.Drawing.Size(74, 20);
            this.checkSinhala.TabIndex = 6;
            this.checkSinhala.Text = "Sinhala";
            this.checkSinhala.UseVisualStyleBackColor = true;
            // 
            // calDOB
            // 
            this.calDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calDOB.Location = new System.Drawing.Point(158, 214);
            this.calDOB.Name = "calDOB";
            this.calDOB.Size = new System.Drawing.Size(121, 22);
            this.calDOB.TabIndex = 5;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(279, 179);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(74, 20);
            this.radFemale.TabIndex = 4;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(158, 179);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(58, 20);
            this.radMale.TabIndex = 4;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // comAcademicYear
            // 
            this.comAcademicYear.DisplayMember = "19/20";
            this.comAcademicYear.FormattingEnabled = true;
            this.comAcademicYear.Items.AddRange(new object[] {
            "19/20",
            "20/21",
            "21/22",
            "22/23",
            "23/24"});
            this.comAcademicYear.Location = new System.Drawing.Point(158, 109);
            this.comAcademicYear.Name = "comAcademicYear";
            this.comAcademicYear.Size = new System.Drawing.Size(121, 24);
            this.comAcademicYear.TabIndex = 3;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(158, 146);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(208, 22);
            this.txtMobile.TabIndex = 2;
            // 
            // txtIndexNumber
            // 
            this.txtIndexNumber.Location = new System.Drawing.Point(158, 76);
            this.txtIndexNumber.Name = "txtIndexNumber";
            this.txtIndexNumber.Size = new System.Drawing.Size(208, 22);
            this.txtIndexNumber.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(540, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(20, 152);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(48, 16);
            this.lblMobile.TabIndex = 0;
            this.lblMobile.Text = "Mobile";
            // 
            // lblLanguages
            // 
            this.lblLanguages.AutoSize = true;
            this.lblLanguages.Location = new System.Drawing.Point(20, 251);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(75, 16);
            this.lblLanguages.TabIndex = 0;
            this.lblLanguages.Text = "Languages";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(20, 220);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(36, 16);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "DOB";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 183);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // lblStudenDetails
            // 
            this.lblStudenDetails.Location = new System.Drawing.Point(0, 0);
            this.lblStudenDetails.Name = "lblStudenDetails";
            this.lblStudenDetails.Size = new System.Drawing.Size(100, 23);
            this.lblStudenDetails.TabIndex = 1;
            this.lblStudenDetails.Text = "Student Details";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(20, 118);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(100, 16);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Academic Year";
            // 
            // lblIndexNumber
            // 
            this.lblIndexNumber.AutoSize = true;
            this.lblIndexNumber.Location = new System.Drawing.Point(20, 82);
            this.lblIndexNumber.Name = "lblIndexNumber";
            this.lblIndexNumber.Size = new System.Drawing.Size(90, 16);
            this.lblIndexNumber.TabIndex = 0;
            this.lblIndexNumber.Text = "Index Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(517, 361);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 39);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(679, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 414);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(742, 255);
            this.dataGrid.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(420, 361);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(598, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 39);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSerach
            // 
            this.txtSerach.Location = new System.Drawing.Point(12, 367);
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.Size = new System.Drawing.Size(402, 22);
            this.txtSerach.TabIndex = 3;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(766, 682);
            this.Controls.Add(this.txtSerach);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupDetails);
            this.Name = "Signup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.groupDetails.ResumeLayout(false);
            this.groupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDetails;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStudenDetails;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblIndexNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.ComboBox comAcademicYear;
        private System.Windows.Forms.TextBox txtIndexNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker calDOB;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.CheckBox checkOther;
        private System.Windows.Forms.CheckBox checkTamil;
        private System.Windows.Forms.CheckBox checkEnglish;
        private System.Windows.Forms.CheckBox checkSinhala;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSerach;
    }
}

