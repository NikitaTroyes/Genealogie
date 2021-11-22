using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogie
{
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected int birthDate;
        protected int deathDate;
        protected string status; 

        public Person (string firstName, string lastName, int birthDate, int deathDate, string status)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.deathDate = deathDate;
            this.status = status; 
        }

        public Person(string firstName, string lastName, int birthDate, string status)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.status = status;
        }

        public Person(string firstName, string lastName, int birthDate, int deathDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.deathDate = deathDate;
        }

        public Person(string firstName, string lastName, int birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public abstract void Add(Person person);

        public abstract string GetData();

    }

    public class Genitor : Person
    {
        List<Person> listPerson = new List<Person>();

        public Genitor(string firstName, string lastName, int birthDate, int deathDate) : base(firstName, lastName, birthDate, deathDate) { }
        public Genitor(string firstName, string lastName, int birthDate) : base(firstName, lastName, birthDate) { }

        public override void Add(Person person)
        {
            listPerson.Add(person); 
        }

        public override string GetData()
        {
            StringBuilder sbPerson = new StringBuilder();

            foreach (Person person in listPerson)

            {

                sbPerson.Append(person.GetData() + "\n");

            }

            return sbPerson.ToString();
        }
    }

    public class Member : Person
    {
        public Member(string firstName, string lastName, int birthDate, int deathDate, string status) : base(firstName, lastName, birthDate, deathDate, status) { }
        public Member(string firstName, string lastName, int birthDate, string status) : base(firstName, lastName, birthDate, status) { }
        public override void Add(Person person)
        {
        }

        public override string GetData()
        {
            return "FirstName: " + firstName + "\nLastName: " + lastName + "\nBirthDate: " + birthDate.ToString() + "\nDeathDate: " + deathDate.ToString() + "\nStatus: " + status + "\n";  
        }


    }



}
