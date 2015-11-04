using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesToTicketsDB;
using System.Data.Entity;
using Common;

namespace Проездные
{
    public partial class Client : Form
    {
        AccessToTicketsDB accessToTicketsDB;
        List<Common.Order> allOrders;
        List<Common.Ticket> allTickets; 
        List<Common.Person> allPersons;
        List<Common.Rate> allRates;
        List<Common.Price> allPrices;
        List<Common.TransportType> allTypes;
        List<int> ticketIds;
        public Client()
        {
            InitializeComponent();
            ticketIds = new List<int>();
            Refresh_Click(null, null);
            TicketName_cmbbox.Items.Add("");
            foreach(Common.Ticket tmpTicket in allTickets)
            {
                if (!TicketName_cmbbox.Items.Contains(tmpTicket.Name))
                    TicketName_cmbbox.Items.Add(tmpTicket.Name);
                ticketIds.Add(tmpTicket.ID);
            }
        }

        private void reasizeDataGridView(DataGridView e)
        {
            for (int i = 0; i < e.ColumnCount; i++)
                e.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (
                (sender == null && e == null) ||
                (TickPrice_txtbox.Text.Trim() == null &&
                TickAmount_txtbox.Text.Trim() == String.Empty &&
                TickTransport_txtbox.Text.Trim() == String.Empty)
                )
            {
                //При помощи методов Аксесса, заполняем списки, которыми потом заполним дгрвшки
                accessToTicketsDB = new AccessToTicketsDB();
                allOrders = accessToTicketsDB.GetAllOrders();
                allTickets = accessToTicketsDB.GetAllTickets();
                allPersons = accessToTicketsDB.GetAllPersons();
                allRates = accessToTicketsDB.GetAllRates();
                allPrices = accessToTicketsDB.GetAllPrices();
                allTypes = accessToTicketsDB.GetAllTransportTypes();

                /*//Создаём столбец сумм для таблицы Заказов 
                DataGridViewTextBoxColumn firstColumn = new DataGridViewTextBoxColumn(); 
                


                //firstColumn.HeaderText = "Сума";
                firstColumn.Name = "Сума";


                //Заполняем данными таблицу заказов и добавляем туда столбец суммы
                
                Order_dgrv.ColumnCount++;
                Order_dgrv.Columns[Order_dgrv.ColumnCount].HeaderText = "dfdfdfdf";
                
                if (Order_dgrv.ColumnCount < 10)
                {
                  //  Order_dgrv.Columns.Add(firstColumn);
                   // firstColumn.Name = "Сума";
                }*/
                Order_dgrv.DataSource = allOrders;
                Order_dgrv.Columns[0].HeaderText = "Ім'я";
                Order_dgrv.Columns[1].HeaderText = "Назва квитка";
                Order_dgrv.Columns[2].HeaderText = "Місяць замовлення";
                Order_dgrv.Columns[3].HeaderText = "Кількість"; 
                Order_dgrv.Columns[4].HeaderText = "Сума";
                Order_dgrv.Columns[5].HeaderText = "Борг";
                
                //Order_dgrv.Columns[5].CellTemplate = 

                //Заполняем данными остальные таблицы
                Tickets_dgrv.DataSource = allTickets;
                Tickets_dgrv.Columns[0].HeaderText = "Назва квитка";
                Tickets_dgrv.Columns[1].HeaderText = "Ціна";
                Tickets_dgrv.Columns[2].HeaderText = "Кількість поїздок";
                Tickets_dgrv.Columns[3].HeaderText = "Тип транспорту";

                Person_dgrv.DataSource = allPersons;
                Person_dgrv.Columns[0].HeaderText = "Ім'я";
                Person_dgrv.Columns[1].HeaderText = "Дата вступу";
                Person_dgrv.Columns[2].HeaderText = "Дата випуску";

                Rate_dgrv.DataSource = allRates;
                Rate_dgrv.Columns[0].HeaderText = "Кількість";

                Price_dgrv.DataSource = allPrices;
                Price_dgrv.Columns[0].HeaderText = "Ціна";

                TransportType_dgrv.DataSource = allTypes;
                TransportType_dgrv.Columns[0].HeaderText = "Транспорт";

                //Растягиваем таблицы на полный размер дгрвшки
                reasizeDataGridView(Order_dgrv);
                reasizeDataGridView(Tickets_dgrv);
                reasizeDataGridView(Person_dgrv);
                reasizeDataGridView(Rate_dgrv);
                reasizeDataGridView(Price_dgrv);
                reasizeDataGridView(TransportType_dgrv);
                //Order_dgrv.Columns["Price"].Visible = false;
            }
            else
            {   
                //Фільтрація тікетів
                int PriceInBox = 0; 
                if (TickPrice_txtbox.Text.Trim() != String.Empty)
                {
                    try
                    {
                        PriceInBox = Convert.ToInt32(TickPrice_txtbox.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("Вибачте, але в поле цін краще вводити цифри");
                    }
                }
                Common.Ticket searchedTicket = new Common.Ticket(0, null, PriceInBox,
                    TickAmount_txtbox.Text.Trim(), TickTransport_txtbox.Text.Trim());
                allTickets = accessToTicketsDB.GetSearchedTickets(searchedTicket);
            }
            if(allTickets != null && allTickets.Count != 0)
            {
                Tickets_dgrv.DataSource = allTickets;
            }
            else
            {
                MessageBox.Show("Нема білетів, які задовільняють заданим значенням");
            }

        }
        public void RefreshOrders_btn_Click(object sender, EventArgs e)
        {

            DateTime EdDate = new DateTime();
            DateTime DateOfGiving = new DateTime();
             
            if (EdDate_txtbox.Text.Trim() == String.Empty && DateOfGiving_txtbox.Text.Trim() == String.Empty &&
                TicketName_cmbbox.Text.Trim() == String.Empty && SearchedName_txtbox.Text.Trim() == String.Empty)
            {
                Refresh_Click(null, null);
                return;
            }
            
            
            if (EdDate_txtbox.Text.Trim() != String.Empty)
                {
                    try
                    {
                        EdDate = Convert.ToDateTime(EdDate_txtbox.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Вибачте, але неправильно введені дані в поле перевірки приналежності особи до університета." + 
                        "Спробуйте формат dd.mm.yyyy");
                    } 
                }
            if (DateOfGiving_txtbox.Text.Trim() != String.Empty)
            {
                try
                {
                    DateOfGiving = Convert.ToDateTime(DateOfGiving_txtbox.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Вибачте, але неправильно введені дані в поле з датою здачі грошей. Спробуйте формат dd.mm.yyyy");
                }
            }
                //accessToTicketsDB = new AccessToTicketsDB();
                Order searchedOrder = new Order(0, SearchedName_txtbox.Text.Trim(), TicketName_cmbbox.Text.Trim(), DateOfGiving, 0, 0);
                allOrders = accessToTicketsDB.GetSearchedOrders(searchedOrder, EdDate);
            
            if(allOrders != null && allOrders.Count != 0)
            {
                Order_dgrv.DataSource = allOrders;
            } 
            else
            {
                MessageBox.Show("Нема замовлень, які задовільняють заданим значенням");
            }
        }
        private void AddOrder_Click(object sender, EventArgs e)
        {
            AddNewOrder addNewOrder = new AddNewOrder(allPersons, allTickets);
            if (addNewOrder.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.AddOrder(addNewOrder.newOrder, addNewOrder.getPersonId(),
                     addNewOrder.getTicketId());
                if (a == false) MessageBox.Show("Таке замовлення вже існує, спробуйте змінити дані");
                Refresh_Click(null, null);
            }
        }

        private void AddTicket_Click(object sender, EventArgs e)
        {
            AddNewTicket addNewTicket = new AddNewTicket(allPrices, allRates, allTypes);
            if (addNewTicket.ShowDialog() == DialogResult.OK)
            {
                int a = accessToTicketsDB.AddTicket(addNewTicket.newTicket, addNewTicket.getPriceId(),
                     addNewTicket.getRateId(), addNewTicket.getTypeId());
                if (a == 1) MessageBox.Show("Такий білет вже існує, спробуйте змінити дані");
                else if (a == 2) MessageBox.Show("Білет з таким ім'ям вже існує, спробуйте змінити ім'я");
                Refresh_Click(null, null);
            }
        }

        private void AddNewPrice_btn_Click(object sender, EventArgs e)
        {
            AddNewPrice addNewPrice = new AddNewPrice();
            if (addNewPrice.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.AddPrice(addNewPrice.newPrice);
                if (a == false)
                    MessageBox.Show("Вибачте, але така ціна вже існує");
                Refresh_Click(null, null);
            }
        }

        private void AddNewType_btn_Click(object sender, EventArgs e)
        {
            AddNewType addNewType = new AddNewType();
            if (addNewType.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.AddType(addNewType.newType);
                if (a == false)
                    MessageBox.Show("Вибачте, але такий тип вже існує");
                Refresh_Click(null, null);
            }
        }

        private void AddPers_btn_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPerson = new AddNewPerson();
            if (addNewPerson.ShowDialog() == DialogResult.OK)
            {
                int a = accessToTicketsDB.AddPerson(addNewPerson.newPerson);
                if (a == 1)
                    MessageBox.Show("Вибачте, але людина з повністю ідентичними даними вже існує");
                else if (a == 2)
                    MessageBox.Show("Вибачте, але людина з таким ім'ям вже існує. Ім'я має бути унікальним");
                Refresh_Click(null, null);
            }
        }

        private void AddNewRate_btn_Click(object sender, EventArgs e)
        {
            AddNewRate addNewRate = new AddNewRate();
            if (addNewRate.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.AddRate(addNewRate.newRate);
                if (a == false)
                    MessageBox.Show("Вибачте, але така кількість поїздок вже існує");
                Refresh_Click(null, null);
            }
        }
        private void DeleteOrder_btn_Click(object sender, EventArgs e)
        {
            DeleteOrder deleteOrder = new DeleteOrder(allOrders, allTickets);
            if(deleteOrder.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.DeleteOrder(deleteOrder.deletedOrder, deleteOrder.givingDate);
                if (a == false)
                    MessageBox.Show("Вибачте, але замовлення з таким даними не існує. Видалення неможливе");
                Refresh_Click(null, null);
            }
        }
        private void DeletePr_btn_Click(object sender, EventArgs e)
        {
            DeletePrice deletePrice = new DeletePrice(allPrices);
            if (deletePrice.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.DeletePrice(deletePrice.deletedPrice);
                if (a == false)
                    MessageBox.Show("Вибачте, але з цією ціною існує сформований квиток. Видалення заборонене");
                Refresh_Click(null, null);
            }
        }

        private void DeleteRate_btn_Click(object sender, EventArgs e)
        {
            DeleteRate deleteRate = new DeleteRate(allRates);
            if (deleteRate.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.DeleteRate(deleteRate.deletedRate);
                //allRates = accessToTicketsDB.GetAllRates();
                if (a == false)
                    MessageBox.Show("Вибачте, але з цією кількістю поїздок існує сформований квиток. Видалення заборонене");
                Refresh_Click(null, null);
            }
        }

        private void DeleteType_btn_Click(object sender, EventArgs e)
        {
            DeleteType deleteType = new DeleteType(allTypes);
            if (deleteType.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.DeleteType(deleteType.deletedType);
                if (a == false)
                    MessageBox.Show("Вибачте, але з цим типом транспорту існує сформований квиток. Видалення заборонене");
                Refresh_Click(null, null);
            }
        }

        private void DeletePerson_btn_Click(object sender, EventArgs e)
        {
            DeletePerson deletePerson = new DeletePerson(allPersons);
            if (deletePerson.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.DeletePerson(deletePerson.deletedPerson);
                if (a == false)
                    MessageBox.Show("Вибачте, але на цю людину оформлене замовлення. Видалення заборонене");
                Refresh_Click(null, null);
            }
        }

        private void DeleteTicket_btn_Click(object sender, EventArgs e)
        {
            DeleteTicket deleteTicket = new DeleteTicket(allTickets);
            if (deleteTicket.ShowDialog() == DialogResult.OK)
            {
                bool a = accessToTicketsDB.DeleteTicket(deleteTicket.deletedTicket);
                if (a == false)
                    MessageBox.Show("Вибачте, але на цей квиток існують замовлення. Видалення заборонене");
                Refresh_Click(null, null);
            }
        }
    }
}
