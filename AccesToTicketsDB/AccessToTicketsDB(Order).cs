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
        public List<Common.Order> GetAllOrders()
        {
            if (dataBase.Main == null)
                return null;
            List<Common.Order> orders = new List<Common.Order>();
            foreach (var currOrder in dataBase.Main)
            {
                Common.Order order = new Common.Order();
                order.ID = currOrder.m_id;
                order.PersonName = currOrder.Person.name;
                order.TicketName = currOrder.Ticket.ticket_name;
                order.Date = currOrder.month;
                order.Amount = currOrder.amount;
                order.Pledge = (int)currOrder.pledge;
                order.Sum = currOrder.amount * currOrder.Ticket.Price.price_name;
                orders.Add(order);
            }
            return orders;
        }

        public List<Order> GetSearchedOrders(Common.Order searchedOrder, DateTime edDate)
        {
            string stringSearchedOrders = searchedOrder.Date.ToString();
            var listOfSearchedOrders = from c in dataBase.Main where 
                                           (
                                            ((searchedOrder.PersonName == "") || (c.Person.name == searchedOrder.PersonName)) &&
                                            ((searchedOrder.TicketName == "") || (c.Ticket.ticket_name == searchedOrder.TicketName)) &&
                                            ((stringSearchedOrders == "01.01.0001 0:00:00") || (c.month == searchedOrder.Date))
                                           ) select c;

            if (listOfSearchedOrders == null)
                return null;

            List<Common.Order> orders = new List<Common.Order>();

            foreach (Main tmpSearchedOrder in listOfSearchedOrders)
            {
                if (edDate.ToString() != "01.01.0001 0:00:00")
                {
                    if (edDate < tmpSearchedOrder.Person.date_end_ed &&
                        edDate > tmpSearchedOrder.Person.date_begin_ed)
                        orders.Add(new Common.Order(tmpSearchedOrder.m_id, tmpSearchedOrder.Person.name, 
                            tmpSearchedOrder.Ticket.ticket_name, tmpSearchedOrder.month, tmpSearchedOrder.amount, 
                            (int)tmpSearchedOrder.pledge));
                }
                else
                    orders.Add(new Common.Order(tmpSearchedOrder.m_id, tmpSearchedOrder.Person.name, tmpSearchedOrder.Ticket.ticket_name,
                            tmpSearchedOrder.month, tmpSearchedOrder.amount, (int)tmpSearchedOrder.pledge));
            }
            return orders;
        }
        
        public bool AddOrder(Order order, int personId, int ticketId)
        {
            bool canAdd = IsUniqueOrder(order, personId, ticketId);
            if (canAdd == true)
            {
                Main orderToAdd = new Main();
                orderToAdd.pers_id = personId;
                orderToAdd.ticket_id = ticketId;
                orderToAdd.month = order.Date;
                orderToAdd.pledge = order.Pledge;
                dataBase.Main.Add(orderToAdd);
                dataBase.SaveChanges();
                return true;
            }
            return false;
        }

        bool IsUniqueOrder(Order order, int personId, int ticketId)
        {
            var orderUsedInOrder = from c in dataBase.Main where c.Person.name == order.PersonName && c.ticket_id == ticketId select c;
            if (orderUsedInOrder != null && orderUsedInOrder.Count() > 0)
                return false;
            return true;
        }

        public bool DeleteOrder(Order order, /*int personId, int ticketId,*/ DateTime givingDate)
        {
            var orderToDelete = (from c in dataBase.Main
                                where c.Person.name == order.PersonName && c.Ticket.ticket_name == order.TicketName &&
                                    c.month == givingDate
                                select c).FirstOrDefault();
            if (orderToDelete == null)
                return false;
            else
            {
                dataBase.Main.Remove(orderToDelete);
                return true;
            }
            
        }
    }
}
