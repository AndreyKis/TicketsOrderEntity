using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Price
    {
        public int ID;
        public int Value { get; set; }

        public Price() { }
        
        public Price(int id, int value)
        {
            this.ID = id;
            this.Value = value;
        }

        public Price(int value)
        {
            this.Value = value;
        }
    }
}
