using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project282
{
    internal class Students
    {
        private string id;
        private string name;
        private int age;
        private string course;

        public Students(string id, string name, int age, string course)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.course = course;
        }

        public override string ToString()
        {
            return $"{id},{name},{age},{course}";
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }
    }
}
