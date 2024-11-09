using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// by Brett wilson 601081 Di-jancko_calitz 600356 joshua levi visser 601085

// Github link for this repositorie: https://github.com/DiJanckoCalitz/prg282

namespace project282
{
    // the main and only windows form
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        // make our objects here upon the form being opened
        static FileManager dataManager = new FileManager();

        // list used through out here with datagridview
        static List<Students> students = new List<Students>();

        private void Gui_Load(object sender, EventArgs e)
        {
            students = dataManager.ReadFile("students.txt"); // first thing is to read whats there if any in the students file
            mainDataGridView.DataSource = dataManager.ReadFile("students.txt"); // then update the view with all if any students
        }

        // adding of students button
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            // if else chain to test if all inputs are filled if not send and error message and return early to stop the rest of the code form running
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
                errorMessage.Text = $""; // if all inputs are filled clear the error
            }

            if (!studentAge.Text.All(char.IsDigit)) // make sure age is a num if not give error
            {
                errorMessage.Text = $"Age must be a number";
                return; // stop the rest of the code from running when there is bad age input to prevent the program from crashing
            }

            students = dataManager.ReadFile("students.txt"); // get the current list of students if any from file
            foreach (Students student in students)
            {
                if (student.Id == studentID.Text) // stop duplicate student ids from being added
                {
                    errorMessage.Text = $"Student of ID {studentID.Text} already exists";
                    return;
                }
            }

            // update the list
            students.Add(new Students(studentID.Text, studentName.Text, int.Parse(studentAge.Text), studentCourse.Text));

            // update student file
            dataManager.WriteFile("students.txt", students);

            // update datagridview
            mainDataGridView.DataSource = dataManager.ReadFile("students.txt");
        }

        // the update students button
        private void updateStudent_Click(object sender, EventArgs e)
        {
            // get most recent student file
            students = dataManager.ReadFile("students.txt");
            
            // make sure id is not empty and other inputs can be empty
            if (studentID.Text == "")
            {
                errorMessage.Text = $"Please enter student ID";
                return;
            }

            bool studentFound = false; // used for error display

            foreach (Students student in students)
            {
                // if the id of the stored student mathces that of the want to be updated id then
                if (student.Id == studentID.Text)
                {
                    studentFound = true;

                    // populate inputs with the data of the found studnet
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

                    // update the student with the inputs 
                    student.Id = studentID.Text;
                    student.Name = studentName.Text;
                    student.Age = int.Parse(studentAge.Text);
                    student.Course = studentCourse.Text;
                    break; // no need to run again if studnet is found
                }
            }

            if (!studentFound)
            {
                errorMessage.Text = $"Student ID {studentID.Text} not found";
            }
            else
            {
                errorMessage.Text = "";
            }

            if (students.Count == 0) // in case of empty list
            {
                errorMessage.Text = $"No students in file to update";
            }

            // update student file
            dataManager.WriteFile("students.txt", students);

            // update data grid view
            mainDataGridView.DataSource = dataManager.ReadFile("students.txt");
        }

        // remove student button
        private void deleteStudent_Click(object sender, EventArgs e)
        {
            if (studentID.Text == "")
            {
                errorMessage.Text = $"Please enter student ID";
                return;
            }

            bool studentFound = false;

            // similier to update button
            students = dataManager.ReadFile("students.txt");
            foreach (Students student in students)
            {
                if (student.Id == studentID.Text)
                {
                    studentFound = true;

                    students.Remove(student); // remove student form list once id mathces
                    break;
                }
            }

            if (!studentFound)
            {
                errorMessage.Text = $"Student ID {studentID.Text} not found";
            }
            else
            {
                errorMessage.Text = "";
            }

            if (students.Count == 0)
            {
                errorMessage.Text = $"No students in file to delete";
            }

            dataManager.WriteFile("students.txt", students);
            mainDataGridView.DataSource = dataManager.ReadFile("students.txt");
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            // make the report and write to file
            dataManager.GenerateReport("summary.txt", students);
            // get the report from the file and display it in a label
            summery.Text = dataManager.GetReport("summary.txt");
        }
    }
}
