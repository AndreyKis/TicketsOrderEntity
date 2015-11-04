using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data;

namespace AccesToTicketsDB
{
    public partial class AccessToTicketsDB
    {
        public List<Common.Rate> GetAllRates()
        {
            if (dataBase.Rate == null)
                return null;
            List<Common.Rate> Rate = new List<Common.Rate>();
            foreach(var currRate in dataBase.Rate)
            {
                Common.Rate rate = new Common.Rate();
                rate.ID = currRate.rrate_id;
                rate.Name = currRate.rrate_name;
                Rate.Add(rate);
            }
            return Rate;
        }

        public bool AddRate(Common.Rate rate)
        {
            bool canAdd = IsUniqueRate(rate);
            if (canAdd)
            {
                Rate rateDB = new Rate();
                rateDB.rrate_name = rate.Name;
                dataBase.Rate.Add(rateDB);
                return true;
            }
            return false;
        }

        public bool IsUniqueRate(Common.Rate rate)
        {
            var ratesUsedInRate = from c in dataBase.Rate where c.rrate_name == rate.Name select c;
            if (ratesUsedInRate == null || ratesUsedInRate.Count() == 0) 
                return false;
            return true;
        }

        public bool DeleteRate(Common.Rate rate)
        {
            bool canDeleteRate = IsUsedRate(rate);
            if (canDeleteRate)
            {
                var ratesToDelete = (from c in dataBase.Rate where c.rrate_name == rate.Name select c).FirstOrDefault();
                dataBase.Rate.Remove(ratesToDelete);
                dataBase.SaveChanges();
                return true;
            }
            return false;
        }

        bool IsUsedRate(Common.Rate rate)
        {
            var ratesUsedInTicketRows = from c in dataBase.Ticket where c.Rate.rrate_name == rate.Name select c;
            if (ratesUsedInTicketRows == null || ratesUsedInTicketRows.Count() > 0)
                return false;
            return true;
        }
    }
}
