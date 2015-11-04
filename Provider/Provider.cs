using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Common;
using Common.Tr_Tick_DBDataSetTableAdapters;
namespace Provider
{
    public class Provider
    {
        Tr_Tick_DBDataSet ticketsDataSet = new Tr_Tick_DBDataSet();
        SqlDataAdapter[] ticketsDataAdapters;
        DataTable[] ticketsTables;
        string[] TablesName;
        string targetFile;

        public Provider() { 
        
        targetFile = "Data Source=ANDREW\\SQLEXPRESS;Initial Catalog=Tr_Tick_DB;Integrated Security=True";
        }

        public Tr_Tick_DBDataSet GetAllData()
        {
            
            this.ticketsTables = new DataTable[]
            {
                this.ticketsDataSet.Main,
                this.ticketsDataSet.Person,
                this.ticketsDataSet.Ticket,
                this.ticketsDataSet.Rate,
                this.ticketsDataSet.Price,
                this.ticketsDataSet.Type
            };

            this.TablesName = new string[] {"Main", "Person", "Ticket", "Rate", "Price", "Type"};
            this.ticketsDataAdapters = new SqlDataAdapter[this.TablesName.Length];
            SqlConnection con = new SqlConnection(this.targetFile);
            for (int i = 0; i < this.TablesName.Length; i++)
            {
                this.ticketsDataAdapters[i] = new SqlDataAdapter("SELECT * FROM " + this.TablesName[i], con);

                SqlCommandBuilder combld = new SqlCommandBuilder(this.ticketsDataAdapters[i]);

            }
            for (int i = 0; i < ticketsDataAdapters.Length; i++)
            {
                ticketsDataAdapters[i].Fill(this.ticketsTables[i]);
            }
            return this.ticketsDataSet;
        }

        public void UpdateAllData()
        {
            for (int i = 0; i < this.ticketsDataAdapters.Length; i++)
                this.ticketsDataAdapters[i].Update(this.ticketsTables[i]);
        }
    }
}
