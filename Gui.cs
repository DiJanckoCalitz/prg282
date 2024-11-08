using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project282
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        static FileManager dataManager = new FileManager();

        static List<Students> students = new List<Students>();

        private void Gui_Load(object sender, EventArgs e)
        {
            students = dataManager.ReadFile("students.txt");
            mainDataGridView.DataSource = dataManager.ReadFile("students.txt");
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            if (studentID.Text == "")
            {
                errorMessage.Text = $"Please fill in all feilds";
                return;
            }
            else if (studentName.Text == "")
            {
                errorMessage.Text = $"Please fill in all feilds";
                return;
            }
            else if (studentAge.Text == "")
            {
                errorMessage.Text = $"Please fill in all feilds";
                return;
            }
            else if (studentCourse.Text == "")
            {
                errorMessage.Text = $"Please fill in all feilds";
                return;
            }
            else
            {
                errorMessage.Text = $"";
            }

            if (!studentAge.Text.All(char.IsDigit))
            {
                errorMessage.Text = $"Age must be a number";
                return;
            }

            students = dataManager.ReadFile("students.txt");
            foreach (Students student in students)
            {
                if (student.Id == studentID.Text)
                {
                    errorMessage.Text = $"Student of ID {studentID.Text} already exists";
                    return;
                }
            }

            students.Add(new Students(studentID.Text, studentName.Text, int.Parse(studentAge.Text), studentCourse.Text));

            dataManager.WriteFile("students.txt", students);

            mainDataGridView.DataSource = dataManager.ReadFile("students.txt");
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            students = dataManager.ReadFile("students.txt");

            if (studentID.Text == "")
            {
                errorMessage.Text = $"Please enter student ID";
                return;
            }

            foreach (Students student in students)
            {
                if (student.Id == studentID.Text)
                {
                    if (studentName.Text == "")
                    {
                        studentName.Text = student.Name;
                    }
                    if (studentAge.Text == "")
                    {
                        studentAge.Text = student.Age.ToString();
                    }
                    if (studentCourse.Text == "")
                    {
                        studentCourse.Text = student.Course;
                    }

                    student.Id = studentID.Text;
                    student.Name = studentName.Text;
                    student.Age = int.Parse(studentAge.Text);
                    student.Course = studentCourse.Text;
                    break;
                }
                else
                {
                    errorMessage.Text = $"Student ID {studentID.Text} not found";
                }
            }

            if (students.Count == 0)
            {
                errorMessage.Text = $"No students in file to update";
            }

            dataManager.WriteFile("students.txt", students);
            mainDataGridView.DataSource = dataManager.ReadFile("students.txt");
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
        }
    }
}
