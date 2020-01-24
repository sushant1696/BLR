using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.AddresBook
{
    class PersonList
    {
        private List<Person> people = new List<Person>();

        public List<Person> Person { get => this.people; set => this.people = value; }
    }
   
}
