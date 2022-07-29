using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Organization
    {
        public string OrganizationName { get; }
        public decimal budget { get; }
        public Post[] team;
        Random rand = new Random();

        public Organization(string name, decimal budjet)
        {
            string randomname = "";
            string randomsurname = "";
            
            OrganizationName = name;
            budget = budjet;
            team = new Post[5];
            for (byte i = 0; i < 5; i++)
            {
                team[0].job = "Manager";
                team[0].salary = (decimal)20000;
                team[0].person = new Employee(randomname, randomsurname);
                switch (rand.Next(10))
                {
                    case 0:
                        randomname = "Ivan";
                        break;
                    case 1:
                        randomname = "Marry";
                        break;
                    case 2:
                        randomname = "Markus";
                        break;
                    case 3:
                        randomname = "Jessica";
                        break;
                    case 4:
                        randomname = "Alex";
                        break;
                    case 5:
                        randomname = "John";
                        break;
                    case 6:
                        randomname = "Stuard";
                        break;
                    case 7:
                        randomname = "Hope";
                        break;
                    case 8:
                        randomname = "Cally";
                        break;
                    case 9:
                        randomname = "Alexander";
                        break;
                    case 10:
                        randomname = "Eugene";
                        break;
                }
                switch (rand.Next(10))
                {
                    case 0:
                        randomsurname = "Ivan";
                        break;
                    case 1:
                        randomsurname = "Marry";
                        break;
                    case 2:
                        randomsurname = "Markus";
                        break;
                    case 3:
                        randomsurname = "Jessica";
                        break;
                    case 4:
                        randomsurname = "Alex";
                        break;
                    case 5:
                        randomsurname = "John";
                        break;
                    case 6:
                        randomsurname = "Stuard";
                        break;
                    case 7:
                        randomsurname = "Hope";
                        break;
                    case 8:
                        randomsurname = "Cally";
                        break;
                    case 9:
                        randomsurname = "Alexander";
                        break;
                    case 10:
                        randomsurname = "Eugene";
                        break;
                }

            }

        }


    }


    class Post
    {
        public Employee person;
        public string job;
        public decimal salary;
    }


    class Employee
    {
        readonly string name;
        readonly string surname;

        public Employee(string firstname, string lastname)
        {
            name = firstname;
            surname = lastname;
        }

        public void ShowInfo()
        {
            Console.Write(name + " " + surname);
        }

    }
}
