using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person : IComparable
    {
        private string name;
        private int age;

        public string Name { get { return name; }
                             set { name = value; } }
        //public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
       
        public int CompareTo(object obj)
        {
            if (obj is Person other)
            {
                // Сравнение по имени
                return this.Name.CompareTo(other.Name);
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{Name}, Возраст: {Age}";
        }
    }
}
