using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Threading.Tasks;
using System.Data.Entity;


namespace AccesToTicketsDB
{
    public partial class AccessToTicketsDB
    {

        Tr_Tick_DBEntities dataBase = new Tr_Tick_DBEntities();

        public AccessToTicketsDB ()
        {
            dataBase.Main.Load();
            dataBase.Person.Load();
            dataBase.Price.Load();
            dataBase.Rate.Load();
            dataBase.Ticket.Load();
            dataBase.Type.Load();        
        }
    }
}
