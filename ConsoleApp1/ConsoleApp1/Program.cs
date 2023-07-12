using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person 
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
    }
    public class Program
    {
        public static void Main(string [] args)
        {
            List<Person> list = GetAll();
            int count = 0;
            Console.WriteLine("Enter Name");
            string user = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.Name==user)
                {
                    count++;
                }
            }

            if (count>0)
            {
                Console.WriteLine("Found User : " +count);
            }
            else
            {
                Console.WriteLine("User Not Found");
            }
        }
        static List<Person> GetAll()
        {
            var person1 = new Person()
            {
                Name = "Vusal",
                Surname = "Zeynalov",
                Age = 19
            };
            var person2 = new Person()
            {
                Name = "Abdulla",
                Surname = "Babayev",
                Age = 14
            };
            var person3 = new Person()
            {
                Name = "Alisa",
                Surname = "Aliyeva",
                Age = 14
            };
            var person4 = new Person()
            {
                Name = "Abdulla",
                Surname = "valiyev",
                Age = 14
            };
            var person5 = new Person()
            {
                Name = "A",
                Surname = "B",
                Age = 14
            };
            var person6 = new Person()
            {
                Name = "B",
                Surname = "Novruzzadaaaa",
                Age = 14
            };
            var person7 = new Person()
            {
                Name = "Niyazi",
                Surname = "Aliyev",
                Age = 14
            };
            var person8 = new Person()
            {
                Name = "Vugar",
                Surname = "Hasimov",
                Age = 14
            };
            var person9 = new Person()
            {
                Name = "Narmin",
                Surname = "Agayev",
                Age = 14
            };
            var person10 = new Person()
            {
                Name = "Guldeste",
                Surname = "Novruzzada",
                Age = 14
            };
            var personList = new List<Person>()
            {
                person1, person2, person3, person4, person5, person6, person7, person8, person9, person10
            };

            return personList;
        }

    }
}
//Exercise
//user-dan bir input qebul edin (axtarisha vermey isteyen ad menasinda) ve o daxil oldughu ada gore hemin adami 
//List-dan tapin. Hemin ad ile adam tapildisa console-da "found" yazilsin. Eks halda "not found".