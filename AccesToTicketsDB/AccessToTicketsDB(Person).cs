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
        public List<Common.Person> GetAllPersons()
        {
            if (dataBase.Person == null)
                return null;
            List<Common.Person> Person = new List<Common.Person>();
            foreach (var currPerson in dataBase.Person)
            {
                Common.Person person = new Common.Person();
                person.ID = currPerson.ppers_id;
                person.Name = currPerson.name;
                person.date_begin_ed = (DateTime)currPerson.date_begin_ed;
                person.date_end_ed = (DateTime)currPerson.date_end_ed;
                Person.Add(person);
            }
            return Person;
        }

        public int AddPerson(Common.Person person)
        {
            int canAddPerson = IsUniquePerson(person);
            if (canAddPerson == 0)
            {
                Person dbPerson = new Person();
                dbPerson.name = person.Name;
                dataBase.Person.Add(dbPerson);
                return 0;
            }
            else if (canAddPerson == 1)
                return 1;
            else
                return 2;
        }

        public int IsUniquePerson(Common.Person person)
        {
            var personInPerson = from c in dataBase.Person where c.name == person.Name && c.date_begin_ed == person.date_begin_ed &&
                                     c.date_end_ed == person.date_end_ed select c;

            var personNamesInPerson = from c in dataBase.Person where c.name == person.Name select c;
            if (personInPerson.Count() > 0)
                return 1;
            else if (personNamesInPerson.Count() > 0)
                return 2;
            return 0;
        }

        public bool DeletePerson(Common.Person person)
        {
            bool canDeletePerson = IsUsedPerson(person);
            if (canDeletePerson)
            {
                var PersonToDelete = (from c in dataBase.Person where c.ppers_id == person.ID select c).FirstOrDefault();
                dataBase.Person.Remove(PersonToDelete);
                dataBase.SaveChanges();
                return true;
            }
            return false;
        }

        bool IsUsedPerson(Common.Person person)
        {
            var personUsedInMain = from c in dataBase.Main where c.Person.ppers_id == person.ID select c;
            if (personUsedInMain == null || personUsedInMain.Count() > 0)
                return false;
            return true;
        }
    }
}
