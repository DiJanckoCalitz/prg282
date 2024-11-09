using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// by Brett wilson 601081 Di-jancko_calitz 600356 joshua levi visser 601085

// Github link for this repositorie: https://github.com/DiJanckoCalitz/prg282

namespace project282
{
    // our student data type 
    internal class Students
    {
        // student properties
        private string id;
        private string name;
        private int age;
        private string course;

        // constructor used through out
        public Students(string id, string name, int age, string course)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.course = course;
        }

        // the string overide for storing student in a file
        public override string ToString()
        {
            return $"{id},{name},{age},{course}";
        }

        // getters and setters
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }
    }
}
