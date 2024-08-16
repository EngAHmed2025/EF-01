using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entites
{
    internal class Course
    {

        public int ID { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
        public int Top_ID { get; set; }
    }
}
