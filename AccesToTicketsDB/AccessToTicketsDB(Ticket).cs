using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common;
using System.Threading.Tasks;

namespace AccesToTicketsDB
{
    public partial class AccessToTicketsDB
    {
        //Вытягиваем по-сложному Тикеты
        public List<Common.Ticket> GetAllTickets()
        {
            if (dataBase.Ticket == null)
                return null;
            List<Common.Ticket> Ticket = new List<Common.Ticket>();
            foreach (var currTicket in dataBase.Ticket)
            {
                Common.Ticket ticket = new Common.Ticket();
                ticket.ID = currTicket.tticket_id;
                ticket.Name = currTicket.ticket_name;
                ticket.Price = currTicket.Price.price_name;
                ticket.Rate = currTicket.Rate.rrate_name;
                ticket.Type = currTicket.Type.ttype_name;
                Ticket.Add(ticket);
            }
            return Ticket;
        }

        //Фильтруем красиво
        public List<Common.Ticket> GetSearchedTickets(Common.Ticket searchedTicket)
        {
            var searchedTickets = from c in dataBase.Ticket where 
                                       (
                                        ((searchedTicket.Price == 0) || (c.Price.price_name == searchedTicket.Price)) &&
                                        ((searchedTicket.Type == String.Empty) || (c.Type.ttype_name == searchedTicket.Type)) && 
                                        ((searchedTicket.Rate == String.Empty) || (c.Rate.rrate_name == searchedTicket.Rate))
                                       )
                                  select c;
            
            if (searchedTickets == null)
                return null;

            List<Common.Ticket> tickets = new List<Common.Ticket>();

            foreach (Ticket tmpSearchedTicket in searchedTickets)
            {   
                tickets.Add(
                    new Common.Ticket(tmpSearchedTicket.tticket_id, tmpSearchedTicket.ticket_name, tmpSearchedTicket.Price.price_name,
                        tmpSearchedTicket.Rate.rrate_name, tmpSearchedTicket.Type.ttype_name)
                        );
            }

            return tickets;
        }

        public int AddTicket(Common.Ticket ticket, int priceId, int rateId, int typeId)
        {
            int canAdd = IsUniqueTicket(ticket, priceId, rateId, typeId);
            if (canAdd == 0)
            {
                Ticket ticketToAdd = new Ticket();
                ticketToAdd.ticket_name = ticket.Name;
                ticketToAdd.tprice_id = priceId;
                ticketToAdd.trate_id = rateId;
                ticketToAdd.ttype_id = typeId;
                dataBase.Ticket.Add(ticketToAdd);
                dataBase.SaveChanges();
                return 0;
            }
            else if (canAdd == 1)
                return 1;
            return 2;
        }

        int IsUniqueTicket(Common.Ticket ticket, int priceId, int rateId, int typeId)
        {
            var ticketsUsedInTicket = from c in dataBase.Ticket
                                      where c.ticket_name == ticket.Name &&
                                          c.Price.price_name == ticket.Price && c.Rate.rrate_name == ticket.Rate &&
                                          c.Type.ttype_name == ticket.Type
                                      select c;
            var ticketNameUsedInTicket = from c in dataBase.Ticket where c.ticket_name == ticket.Name select c;
            if (ticketsUsedInTicket != null && ticketsUsedInTicket.Count() > 0)
                return 1;
            else if (ticketNameUsedInTicket != null && ticketNameUsedInTicket.Count() > 0)
                return 2;
                return 0;
        }

        public bool DeleteTicket(Common.Ticket ticket)
        {
            bool canDeleteTicket = IsUsedTicket(ticket);
            if (canDeleteTicket)
            {
                var ticketToDelete = (from c in dataBase.Ticket where c.ticket_name == ticket.Name select c).FirstOrDefault();
                dataBase.Ticket.Remove(ticketToDelete);
                dataBase.SaveChanges();
                return true;
            }
            return false;
        }

        bool IsUsedTicket(Common.Ticket ticket)
        {
            var ticketUsedInMain = from c in dataBase.Main where c.Ticket.ticket_name == ticket.Name select c;
            if (ticketUsedInMain == null || ticketUsedInMain.Count() > 0)
                return false;
            return true;
        }
    }
}
