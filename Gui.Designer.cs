namespace project282
{
    partial class Gui
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
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentAge = new System.Windows.Forms.MaskedTextBox();
            this.studentCourse = new System.Windows.Forms.MaskedTextBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.MaskedTextBox();
            this.updateStudent = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.generateReport = new System.Windows.Forms.Button();
            this.summery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AllowUserToResizeColumns = false;
            this.mainDataGridView.AllowUserToResizeRows = false;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(12, 12);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(457, 426);
            this.mainDataGridView.TabIndex = 0;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(503, 132);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(137, 20);
            this.studentName.TabIndex = 1;
            // 
            // studentAge
            // 
            this.studentAge.Location = new System.Drawing.Point(503, 183);
            this.studentAge.Name = "studentAge";
            this.studentAge.Size = new System.Drawing.Size(137, 20);
            this.studentAge.TabIndex = 2;
            // 
            // studentCourse
            // 
            this.studentCourse.Location = new System.Drawing.Point(503, 239);
            this.studentCourse.Name = "studentCourse";
            this.studentCourse.Size = new System.Drawing.Size(137, 20);
            this.studentCourse.TabIndex = 3;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(503, 293);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(137, 29);
            this.addStudentBtn.TabIndex = 4;
            this.addStudentBtn.Text = "Add Student Info";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(646, 135);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(75, 13);
            this.name.TabIndex = 5;
            this.name.Text = "Student Name";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(646, 186);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(66, 13);
            this.age.TabIndex = 6;
            this.age.Text = "Student Age";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(646, 242);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(80, 13);
            this.course.TabIndex = 7;
            this.course.Text = "Student Course";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(646, 84);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(58, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "Student ID";
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(503, 81);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(137, 20);
            this.studentID.TabIndex = 8;
            // 
            // updateStudent
            // 
            this.updateStudent.Location = new System.Drawing.Point(503, 352);
            this.updateStudent.Name = "updateStudent";
            this.updateStudent.Size = new System.Drawing.Size(137, 29);
            this.updateStudent.TabIndex = 10;
            this.updateStudent.Text = "Update Student Info";
            this.updateStudent.UseVisualStyleBackColor = true;
            this.updateStudent.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(503, 409);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(137, 29);
            this.deleteStudent.TabIndex = 11;
            this.deleteStudent.Text = "Delete Student Info";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorMessage.Location = new System.Drawing.Point(498, 12);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 25);
            this.errorMessage.TabIndex = 12;
            // 
            // generateReport
            // 
            this.generateReport.Location = new System.Drawing.Point(503, 465);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(137, 29);
            this.generateReport.TabIndex = 13;
            this.generateReport.Text = "Generate Report";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // summery
            // 
            this.summery.AutoSize = true;
            this.summery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summery.Location = new System.Drawing.Point(87, 472);
            this.summery.Name = "summery";
            this.summery.Size = new System.Drawing.Size(0, 20);
            this.summery.TabIndex = 14;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 573);
            this.Controls.Add(this.summery);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.updateStudent);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.course);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.studentCourse);
            this.Controls.Add(this.studentAge);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.mainDataGridView);
            this.Name = "Gui";
            this.Text = "PRG282";
            this.Load += new System.EventHandler(this.Gui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.MaskedTextBox studentAge;
        private System.Windows.Forms.MaskedTextBox studentCourse;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.MaskedTextBox studentID;
        private System.Windows.Forms.Button updateStudent;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.Label summery;
    }
}

