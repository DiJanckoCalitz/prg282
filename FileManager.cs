﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace project282
{
    internal class FileManager
    {
        public void WriteFile(string filePath, List<Students> students)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Students student in students)
                {
                    writer.WriteLine(student.ToString());
                }
            }
        }

        public List<Students> ReadFile(string filePath)
        {
            List<Students> students = new List<Students>();

            if ((File.Exists(filePath)))
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (line != "")
                            {
                                string[] splitLine = line.Split(',');
                                students.Add(new Students(splitLine[0], splitLine[1], int.Parse(splitLine[2]), splitLine[3]));
                            }
                        }
                    }
                }
            }
            else
            {
                WriteFile(filePath, students);
            }

            return students;
        }
    }
}