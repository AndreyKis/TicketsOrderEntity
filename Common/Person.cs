using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Person
    {
        public int ID;
        public string Name { get; set; }
        public DateTime date_begin_ed { get; set; }
        public DateTime date_end_ed { get; set; }

        public Person() { }

        public Person(int id, string name, DateTime date_begin_ed, DateTime date_end_ed)
        {
            this.ID = id;
            this.Name = name;
            this.date_begin_ed = date_begin_ed;
            this.date_end_ed = date_end_ed;
        }
        
        public Person (string name, DateTime date_begin_ed, DateTime date_end_ed)
        {
            this.Name = name;
            this.date_begin_ed = date_begin_ed;
            this.date_end_ed = date_end_ed;
        }

        public Person(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
