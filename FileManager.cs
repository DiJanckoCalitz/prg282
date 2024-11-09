using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

// by Brett wilson 601081 Di-jancko_calitz 600356 joshua levi visser 601085

// Github link for this repositorie: https://github.com/DiJanckoCalitz/prg282

namespace project282
{
    // class used in gui for file operations
    internal class FileManager
    {
        // method for writing students to file
        public void WriteFile(string filePath, List<Students> students)
        {
            using (StreamWriter writer = new StreamWriter(filePath)) // streamwriter short hand: using cluase
            {
                foreach (Students student in students)
                {
                    writer.WriteLine(student.ToString()); // ToString stores the student data as item1,item2,item3 for later use in ReadFile
                }
            }
        }

        // method to read students from file
        public List<Students> ReadFile(string filePath)
        {
            List<Students> students = new List<Students>(); // tempory students list

            if ((File.Exists(filePath))) // make sure there is file if not make one
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string line; // hold each line read tempory
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (line != "") // there is a chance of a file being there but being empty this stops it from crashing the program
                            {
                                string[] splitLine = line.Split(','); // store line into an array refer to write
                                students.Add(new Students(splitLine[0], splitLine[1], int.Parse(splitLine[2]), splitLine[3])); // addeds to this methods local list of students
                            }
                        }
                    }
                }
            }
            else
            {
                WriteFile(filePath, students);
            }

            return students; // returns the local list 
        }

        // generates our report
        public void GenerateReport(string filePath, List<Students> students)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string summery = "";

                // age calulations
                var sum = 0;
                foreach (var student in students)
                {
                    sum += student.Age;
                }

                // the summry string
                summery += $"Summery Report\nTotal number of students: {students.Count}\nAverage age: {sum / students.Count}";

                // writes to the repot file the string above
                writer.WriteLine(summery);
            }
        }

        // reads the report from file
        public string GetReport(string filePath)
        {
            string summery = "";

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        summery += line;
                        summery += "\n"; // adds back in the new lines
                    }
                }
            }

            return summery; // retuns the report string fetched from file to be displayed on a label
        }
    }
}
