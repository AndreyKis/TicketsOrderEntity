using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Ticket
    {
        public int ID;
        public string Name { get; set; }
        public int Price { get; set; }
        public string Rate { get; set; }
        public  string Type { get; set; }

        /*public Dictionary<string, int> PriceFields { get; private set; }
        public Dictionary<string, string> RateFields { get; private set; }
        public Dictionary<string, string> TypeFields { get; private set; }
        public Dictionary<string, string> TicketFields { get; private set; }*/

        public Ticket() { }

        public Ticket(int id, string name, int price, string rate, string type)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Rate = rate;
            this.Type = type;
        }

        public Ticket (string name, int price, string rate, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Rate = rate;
            this.Type = type;
        }

        public Ticket(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
