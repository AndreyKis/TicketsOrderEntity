using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Order
    {
        public int ID;
        public string PersonName { get; set; }
        public string TicketName { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int Sum { get; set; }
        public int Pledge { get; set; }

        /*public Dictionary<string, int> PriceFields { get; private set; }
        public Dictionary<string, string> RateFields { get; private set; }
        public Dictionary<string, string> TypeFields { get; private set; }
        public Dictionary<string, string> TicketFields { get; private set; }*/

        public Order() { }

        public Order(int id, string person, string ticket, DateTime date, int amount, int pledge)
        {
            this.ID = id;
            this.PersonName = person;
            this.TicketName = ticket;
            this.Date = date;
            this.Amount = amount;
            this.Pledge = pledge;
        }

        public Order(string person, string ticket, DateTime date, int amount, int pledge)
        {
            this.PersonName = person;
            this.TicketName = ticket;
            this.Date = date;
            this.Amount = amount;
            this.Pledge = pledge;
        }

       /* public Order(int id, string person, string ticket, DateTime date, int amount, int pledge, Price price)
        {
            this.ID = id;
            this.PersonName = person;
            this.TicketName = ticket;
            this.Date = date;
            this.Amount = amount;
            this.Pledge = pledge;
            this.Price = price;
        }*/
    }
}
