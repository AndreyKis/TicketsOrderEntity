using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TransportType
    {
        public int ID;
        public string Name { get; set; }

        public TransportType() { }

        public TransportType(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public TransportType (string name)
        {
            this.Name = name;
        }
    }
}
