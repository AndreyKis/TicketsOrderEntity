using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Rate
    {
        public int ID;
        public string Name { get; set; }

        public Rate() { }

        public Rate(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        
        public Rate (string name)
        {
            this.Name = name;
        }
    }
}
