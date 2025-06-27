using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>
        {
            new Person("Андрей", 20),
            new Person("Максим", 30),
            new Person("Григорий", 22),
            new Person("Виктор", 28)
        };

            foreach (var p in peopleList)
                Console.WriteLine(p);
                Console.WriteLine();
            // Сортировка списка
            peopleList.Sort();

            Console.WriteLine("Отсортированный список: ");
            foreach (var p in peopleList)
                Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}

