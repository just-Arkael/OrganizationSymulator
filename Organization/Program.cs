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
            decimal mybudget;
            Console.WriteLine("Let's create our company first.");
            Console.WriteLine("What's the name of your company?");
            string myname = Console.ReadLine();
            Console.WriteLine("Give your company a starting budget.");
            decimal.TryParse(Console.ReadLine(), out mybudget);
            Organization team = new Organization(myname, mybudget);
        Reset:
            Console.WriteLine("What's the next projecty your comany is going to make?");
            mybudget = team.WorkLoad(Console.ReadLine());
            if (mybudget > 0)
            {
                Console.WriteLine("Your company received {0} in profits!", mybudget);
            }
            else
            {
                Console.WriteLine("Your company lost {0}...", -mybudget);
            }

            Console.ReadKey();
            goto Reset;

        }
    }


    class Organization
    {
        public string OrganizationName { get; }
        decimal budget;
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
                team[i] = new Post();
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
                        randomsurname = "Kalimur";
                        break;
                    case 1:
                        randomsurname = "Jones";
                        break;
                    case 2:
                        randomsurname = "Rich";
                        break;
                    case 3:
                        randomsurname = "Marbles";
                        break;
                    case 4:
                        randomsurname = "Bighand";
                        break;
                    case 5:
                        randomsurname = "John";
                        break;
                    case 6:
                        randomsurname = "Universe";
                        break;
                    case 7:
                        randomsurname = "Light";
                        break;
                    case 8:
                        randomsurname = "Beremut";
                        break;
                    case 9:
                        randomsurname = "Smetanka";
                        break;
                    case 10:
                        randomsurname = "Cube";
                        break;
                }
                team[i].person = new Employee(randomname, randomsurname);
            }
            team[0].job = "Manager";
            team[0].salary = (decimal)30000;
            team[1].job = "Team Leader";
            team[1].salary = (decimal)27000;
            team[2].job = "Programmer";
            team[2].salary = (decimal)22000;
            team[3].job = "Programmer";
            team[3].salary = (decimal)22000;
            team[4].job = "Junior";
            team[4].salary = (decimal)18000;

        }

        public decimal WorkLoad(string projectname)
        {
            decimal originalbudget = budget;
            budget += 111000 + rand.Next(50000);
            Console.WriteLine("Team {0} is working on project {1}", OrganizationName, projectname);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Total spent on the project:");
            for (byte i = 0; i < 5; i++)
            {
                team[i].person.ShowInfo();
                Console.WriteLine("'s salary - {0}", team[i].salary);
            }
            Console.WriteLine();
            GiveSalaries();
            Console.WriteLine("Budget left: {0}", budget);
            return budget - originalbudget;
        }

        void GiveSalaries()
        {
            for (byte i = 0; i < 5; i++)
            {
                budget -= team[i].salary;
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
