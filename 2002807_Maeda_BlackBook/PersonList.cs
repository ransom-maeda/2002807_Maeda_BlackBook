using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002807_Maeda_BlackBook
{
    public class PersonList
    {
        public List<Person> personList;

        public PersonList()
        {
            personList = new List<Person>();
        }

        public void addPerson(Person person)
        {
            personList.Add(person);
        }
    }

}
